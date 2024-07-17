using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Person
{
    public string name { get; set; }
}

public readonly struct PersonReadonly
{
    public string name { get;  }

    public PersonReadonly(string n)
    {
        name = n;
    }
    
}

public class TestClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        var p1 = new Person() { name = "p1" };
        var p2 = new PersonReadonly(name);
        var p22 = new PersonReadonly("p1");
        
        
        Debug.Log("start");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


