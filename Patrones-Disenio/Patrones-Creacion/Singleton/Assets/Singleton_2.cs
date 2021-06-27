using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_2 
{
    Singleton_2 _shared;

    private Singleton_2()
    {
        
    }

    public Singleton_2 Instantiate()
    {
        if(_shared != null)
        {
            return _shared;
        }
        else
        {
            _shared = new Singleton_2();
            return _shared;
        }
    }
}
