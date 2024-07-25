using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GameBase;
using UnityEngine;

namespace GameLogic
{
    public class PlayMgr : Singleton<PlayMgr>
    {
        private List<Car> m_allCars = new List<Car>();
        //初始化场景元素，汽车等
        //读取表格
    
        public async UniTask InitField()
        {
            //x的坐标是44.5 - 55.5  距离11 44.5 + (x - 1)
            //y的坐标是44.5 - 55.5  距离11 44.5 + (y - 1)
            // var pos = 
            for (int i = 0; i < 10; i++)
            {
                var carObj = await CarManager.Instance.GetACar();
                AddCar(carObj);
                carObj.transform.position = new Vector3(44.5f, 0f, 44.5f + i);
                carObj.transform.localRotation = Quaternion.Euler(0,90f,0);
            }
            
        }

        public async UniTask PlayEnterAnim()
        {
            
        }

        public async UniTask StartTouch()
        {
            
        }

        public void AddCar(Car car)
        {
            m_allCars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            m_allCars.Remove(car);
        }
        
        
        /// <summary>
        /// 使用UniTask 初始化游戏进程
        /// </summary>
        public async UniTask StartGame()
        {
            await InitField();
            await PlayEnterAnim();
            await StartTouch();
        }
    }
}
