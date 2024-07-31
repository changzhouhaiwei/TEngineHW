using GameBase;

namespace GameLogic
{
    /// <summary>
    /// 双方向彼此前进，达到自己射程开始攻击，一方全部阵亡结束
    /// </summary>
    public class BattleLogic:Singleton<BattleLogic>
    {
        private const long maxFrame = 99999;
        private long curFrame = 0;
        private bool bStart = false;
        private bool bOver = false;
        
        public void StartGame()
        {
            curFrame = 0;
        }

        /// <summary>
        /// 更新每一帧的逻辑，逻辑帧可以设定为1秒30次
        /// 客户端表现如移动动作按照这个次序播放
        /// 
        /// </summary>
        public void Update()
        {
            if (bStart)
            {
                curFrame ++;
                RunPerFrameLogic();
                CheckGameOver();
            }
        }

        public void RunPerFrameLogic()
        {
            var list = BattleMgr.Instance.AllUnitList;
            foreach (var unit in list)
            {
                unit.Update();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetGameResult()
        {
            while (curFrame <= maxFrame && !bOver)
            {
                Update();
            }
        }
        
        public void CheckGameOver()
        {
            bOver = false;
        }
    }
}