using System;
using UnityEngine;

namespace GameLogic
{
    public class Car : MonoBehaviour
    {
        public void Awake()
        {
            PlayMgr.Instance.AddCar(this);
        }
        
        /// <summary>
        ///  点击
        /// </summary>
        public void CBTouch()
        {
            
        }

        /// <summary>
        /// 移动逻辑
        /// </summary>
        public void DOMove()
        {
            
        }
        
        
    }
}
