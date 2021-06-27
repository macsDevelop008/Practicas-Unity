using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_1 : MonoBehaviour
{
    public static Singleton_1 _shared;

    private void Awake()
    {
        _shared = this;
    }
}
