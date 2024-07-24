using GameBase;
using UnityEngine;

namespace GameLogic
{
    public class StuffHeafFactory : Singleton<StuffHeafFactory>
    {
        public IStuffHead CreateHead()
        {
            return new IteanHead();
        }
    }
}