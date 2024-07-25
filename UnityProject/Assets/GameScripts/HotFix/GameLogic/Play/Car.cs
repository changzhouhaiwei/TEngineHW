using System;
using Sirenix.OdinInspector;
using TEngine;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameLogic
{
    public enum CarState
    {
        Default = 0,
        InGridMoving,
        InRoadMoving,
        Arrive,
    }
    
    [DisallowMultipleComponent]
    public class Car : MonoBehaviour
    {
        private BoxCollider m_collider;
        private Rigidbody m_rigidBody;
        private bool m_isMoving;
        private float m_speed;
        private CarState m_state = CarState.Default;
        
        public void Awake()
        {
            m_speed = 5.5f;
            m_collider = GetComponent<BoxCollider>();
            m_rigidBody = GetComponent<Rigidbody>();
            
            //设置层级
            gameObject.layer = LayerMask.NameToLayer("Car");
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
            m_isMoving = true;
        }

        /// <summary>
        /// 移动逻辑
        /// </summary>
        public void DOMove()
        {
            m_isMoving = true;
        }

        public void MoveForward()
        {
            if (m_isMoving)
            {
                m_rigidBody.MovePosition(transform.position +  transform.forward * Time.fixedDeltaTime * m_speed);
            }
        }

        public void Update()
        {
        }

        public void FixedUpdate()
        {
            MoveForward();
        }

        /// <summary>
        /// 常规物理碰撞
        /// </summary>
        /// <param name="collision"></param>
        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("enter col  " + collision.gameObject.name);
        }

        /// <summary>
        /// 勾选了  is_trigger
        /// </summary>
        /// <param name="other"></param>
        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("enter col  " + other.gameObject.name);
        }

        public void CheckColStop(Collider other)
        {
            //撞到墙壁和汽车都停止
            int colType = 0;
            if (other.GetComponent<Wall>() != null)
            {
                colType = 1;
            }
            else if(other.GetComponent<Car>() != null)
            {
                colType = 2;
            }

            if (colType > 0)
            {
                m_isMoving = false;
                m_rigidBody.velocity = Vector3.zero;
                m_rigidBody.angularVelocity  = Vector3.zero;;
            }

            //SearchLeave
            if (colType == 1)
            {
                
            }
        }

        public void SearchMoving(WallType wType)
        {
            
        }

    }
}
