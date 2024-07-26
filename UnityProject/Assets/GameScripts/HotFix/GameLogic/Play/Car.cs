using System;
using System.Collections;
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
        InRotation,
    }
    
    [DisallowMultipleComponent]
    public class Car : MonoBehaviour
    {
        private BoxCollider m_collider;
        private Rigidbody m_rigidBody;
        private bool m_isMoving;
        private float m_speed;
        private CarState m_state = CarState.Default;
        
        private Vector3 m_dstRot;
        private Vector3 m_rotDstPos;
        
        
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
            gameObject.name = "CarMove";
            m_isMoving = true;
        }

        
        /// <summary>
        /// 向前移动
        /// </summary>
        public void MoveForward()
        {
            if (m_isMoving)
            {
                m_rigidBody.MovePosition(transform.position +  transform.forward * Time.fixedDeltaTime * m_speed);
            }
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
            if(m_isMoving)
                CheckColStop(other);
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
                var wallType = other.GetComponent<Wall>().m_wallType;
                SearchMoving(wallType,other.gameObject);
            }
        }

        public void SearchMoving(WallType wType,GameObject wall)
        {
            m_dstRot = new Vector3(0, 90, 0);
            // 向左转 顺时针旋转90度 并将位置移动到 z 等于wall的z
            if (wType == WallType.Down || wType == WallType.Up)
            {
                m_rotDstPos = new Vector3(wall.transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                m_rotDstPos = new Vector3(transform.position.x, transform.position.y,wall.transform.position.z);
            }
            
            StartCoroutine(DoRotAnim());
        }

        private IEnumerator DoRotAnim()
        {
            m_state = CarState.InRotation;

            Quaternion startRotation = transform.rotation;
            Vector3 startPosition = transform.position;

            var targetRotation = Quaternion.Euler(transform.eulerAngles + m_dstRot);
            var targetPosition = m_rotDstPos;

            float duration = 0.4f;
            float elapsedTime = 0.0f;

            while (elapsedTime < duration)
            {
                transform.rotation = Quaternion.Slerp(startRotation, targetRotation, elapsedTime / duration);
                transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }
            
            // 确保最终位置和旋转准确
            transform.rotation = targetRotation;
            transform.position = targetPosition;

            // MoveForward();
            m_isMoving = true;
        }
        
    }
}
