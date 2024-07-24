using Cysharp.Threading.Tasks;
using GameBase;
using TEngine;
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
            var obj = await GameModule.Resource.LoadAssetAsync<GameObject>("BlueCar");
            GameObject.Instantiate(obj);
            return obj.AddComponent<Car>();
        }
    }
}