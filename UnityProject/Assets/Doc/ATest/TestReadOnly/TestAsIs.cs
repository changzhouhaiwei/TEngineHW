using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAsIs : MonoBehaviour
{
    class GrandFather
    {
        
    }

    class Dad : GrandFather
    {
        
    }

    class Son :Dad
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // GameObject gogo = gameObject;
        // var i = gogo as Image;

        // float i = 123445.1f;
        // var d = i is int;

        var son = new Son();
        var dad = new Dad();
        var grandFa = new GrandFather();

        Debug.Log($"son is {son is GrandFather}");
        Debug.Log($"dad {grandFa is Dad}");
        Debug.Log($"grand is {son is Son}");

        // var dd = dad as GrandFather;
        // var 
        var ga = grandFa as Dad;
        Debug.Log($"grandfaya {ga == null}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
