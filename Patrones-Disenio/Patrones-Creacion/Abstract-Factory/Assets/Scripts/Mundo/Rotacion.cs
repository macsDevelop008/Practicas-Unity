using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    void Update() 
    {
        rotar();
    }
    void rotar()
    {
        this.transform.rotation *= Quaternion.AngleAxis(30.0f * Time.deltaTime, Vector3.up);
    }
}
