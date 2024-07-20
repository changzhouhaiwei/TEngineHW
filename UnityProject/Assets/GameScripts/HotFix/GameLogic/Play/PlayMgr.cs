using System.Collections.Generic;
using GameBase;
using UnityEngine;

namespace GameLogic
{
    public class PlayMgr : Singleton<PlayMgr>
    {
        private List<Car> m_allCars = new List<Car>();
        //初始化场景元素，汽车等
        //读取表格
    
        public void InitField()
        {
            //x的坐标是44.5 - 55.5  距离11 44.5 + (x - 1)
            //y的坐标是44.5 - 55.5  距离11 44.5 + (y - 1)
        }

        public void AddCar(Car car)
        {
            m_allCars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            m_allCars.Remove(car);
        }

        public void StartGame()
        {
        
        }
    }
}
