using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class BoxEnumrator:IInterface1
{
    public bool MoveNext()
    {
        return true;
    }

    public void Reset()
    {
        
    }
    
    public void GoTest()
    {
        
    }
}


public class PersonBE
{
    public string firstName ;
    public string lastName ;
}


public class PeopleBE : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        return GetEnumerator();
    }
}

