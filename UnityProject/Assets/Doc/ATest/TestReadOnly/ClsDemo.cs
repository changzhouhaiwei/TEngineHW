using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ClsDemo
{
    private static readonly Dictionary<Type,object> mList = new Dictionary<Type, object>();

    public static void AddModule(object obj)
    {
        mList.Add(typeof(GameObject),obj);
    }

    //静态类 不能有成员函数
    // private  Dictionary<string, GameObject> mDo = new Dictionary<string, GameObject>;
    
    // ClsDemo

    
}
