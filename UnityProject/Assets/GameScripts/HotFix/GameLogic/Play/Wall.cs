using System;
using UnityEngine;

namespace GameLogic
{
   public enum WallType
    {
        Up = 0,
        Right = 1,
        Down = 2,
        Left = 3
    }
    public class Wall : MonoBehaviour
    {
        public  WallType m_wallType;

        private void Awake()
        {
            gameObject.layer = LayerMask.NameToLayer("Wall");
        }

        /// <summary>
        /// 常规物理碰撞
        /// </summary>
        /// <param name="collision"></param>
        public void OnCollisionEnter(Collision collision)
        {
             Debug.Log("wall enter col  " + collision.gameObject.name);
        }

        /// <summary>
        /// 勾选了  is_trigger
        /// </summary>
        /// <param name="other"></param>
        public void OnTriggerEnter(Collider other)
        {
             Debug.Log("wall enter col  " + other.gameObject.name);
        }
    }
}