using Cysharp.Threading.Tasks;
using GameBase;
using UnityEngine;

namespace GameLogic
{
    public class CarManager : Singleton<CarManager>
    {
        /// <summary>
        /// 获得一辆汽车
        /// </summary>
        /// <returns></returns>
        public async UniTask<Car> GetACar()
        {
            return new Car();
        }
    }
}