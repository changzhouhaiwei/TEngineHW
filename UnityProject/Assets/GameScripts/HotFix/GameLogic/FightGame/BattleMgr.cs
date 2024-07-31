using System.Collections.Generic;
using GameBase;
using UnityEngine;

namespace GameLogic
{
    public sealed class BattleMgr : Singleton<BattleMgr>
    {
        private List<FightUnit> m_allUnitList =  new List<FightUnit>();

        //共有属性 
        public List<FightUnit> AllUnitList
        {
            get { return m_allUnitList; }
            set { m_allUnitList = value; }
        }

        /// <summary>
        /// 逻辑与显示分离分离
        /// </summary>
        public void Init()
        {
            
        }
        
        public void AddUnit()
        {
            
        }

        public void RemoveUnit()
        {
            
        }
        
    }
}