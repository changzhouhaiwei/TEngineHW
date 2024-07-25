using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class GameMainUI : UIWindow
    {
        #region 脚本工具生成的代码
        private Image m_imgC;
        private Text m_textA;
        private RectTransform m_rectB;
        private Button m_btnD;

        private LoopListView m_listView;
        protected override void ScriptGenerator()
        {
            m_imgC = FindChildComponent<Image>("m_imgC");
            m_textA = FindChildComponent<Text>("m_textA");
            m_rectB = FindChildComponent<RectTransform>("m_rectB");
            m_btnD = FindChildComponent<Button>("m_btnD");
            m_btnD.onClick.AddListener(OnClickDBtn);
            
            m_listView = gameObject.GetComponentInChildren<LoopListView>();
        }
        #endregion

        #region 事件
        private void OnClickDBtn()
        {
        }
        #endregion

        void InitListView()
        {
            m_listView.SetListItemCount(10);
        }
        
    }
}