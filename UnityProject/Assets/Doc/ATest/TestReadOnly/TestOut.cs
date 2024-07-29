using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class TestOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int resultSum;
        int resultProduct;

        CalculateOutSum(1, 2, out resultSum, out resultProduct);

        GameObject oo = new GameObject();
        TestObj(out oo);
        Debug.Log($"地址1ref {oo.GetHashCode()}");
        TestObj2(ref oo);
        Debug.Log($"地址2ref{oo.GetHashCode()}");
        
        Debug.Log("00==== " + oo.name);
        Debug.Log($"{oo.name}");
        
    }

    
        
    public void CalculateOutSum(int a,int b , out int sum,out int product)
    {
        sum = a + b;
        product = a * b;
    }

    //值类型在栈中 引用类型在堆中 out只出不进
    public void TestObj(out GameObject ooo)
    {
        // ooo.name = "100"; // 这里会报错 只出不进的意思是，引用对象成员变量无法改变，只能改变引用本身。
        ooo = gameObject;
    }


    //引用类型 有进有出
    public void TestObj2(ref GameObject oo)
    {
        //引用对象也能改变本身,也能改变成员变量
        oo.name = "100";
        oo = this.gameObject; 
    }
}
