using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractPowerUp : MonoBehaviour
{
    [SerializeField] string _id;

    public string Id()
    {
        return _id;
    }
}
