using System.Collections.Generic;
using GameBase;

namespace GameLogic
{
    enum DataType
    {
        BagData = 0,
        RoleData = 1,
    }
    public class GameData:Singleton<GameData>
    {
        private Dictionary<DataType, int> m_allDataDic;
    }
}