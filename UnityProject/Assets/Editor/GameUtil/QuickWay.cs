using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

/// <summary>
/// sceneManageMent 学习
/// 
/// </summary>
public class QuickWay : MonoBehaviour
{
    [MenuItem("StartScene/Go Main", false, 1112)]
    static void GoFEditor()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/main.unity");
        }
    }
    
    [MenuItem("StartScene/Go GameScene", false, 1112)]
    static void GoGameScene()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/AssetRaw/Scenes/GameScene.unity");
        }
    }

    [MenuItem("StartScene/Go TestScene", false, 1112)]
    static void GoTestScene()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Doc/ATest/ATestScene.unity");
        }
    }
    
    
}
