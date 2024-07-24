using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class TaskTest : MonoBehaviour
{
    // UniTask    
    private void Awake()
    {
                
    }


    async UniTask<string> DemoSync()
    {
        var asset = await Resources.LoadAsync<TextAsset>("foo");

        Debug.Log("0");
        
        await UniTask.WaitForEndOfFrame();
        
        Debug.Log("1");
        // return await UniTask.Yield(0)f;
        return "";
    }

    //异步编程
    public async UniTask DoAsync()
    {
        
        //
        await UniTask.Yield();
    }
    
    
    
}
