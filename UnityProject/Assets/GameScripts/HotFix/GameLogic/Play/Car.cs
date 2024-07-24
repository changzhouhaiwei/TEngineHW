using System;
using Sirenix.OdinInspector;
using TEngine;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLogic
{
    
    [DisallowMultipleComponent]
    public class Car : MonoBehaviour
    {
        public void Awake()
        {
            AddTouch();
        }

        public void AddTouch()
        {
            EventTriggerListener.Get(gameObject).OnClick += CBTouch;
        }
        
        /// <summary>
        ///  点击
        /// </summary>
        public void CBTouch(GameObject obj)
        {
            Debug.Log("触摸了");
        }

        /// <summary>
        /// 移动逻辑
        /// </summary>
        public void DOMove()
        {
            
        }
        
        
    }
}
