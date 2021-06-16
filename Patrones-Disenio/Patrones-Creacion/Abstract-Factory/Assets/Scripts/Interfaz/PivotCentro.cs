using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotCentro : MonoBehaviour
{
    public static PivotCentro _shared;

    [SerializeField] GameObject _objetoCentralActual;

    void Awake() 
    {
        _shared = this;
    }

    public GameObject retornarCarroCentralActual()
    {
        return this._objetoCentralActual;
    }
    public void cambiarCarroCentralActual(GameObject pCarro)
    {
        _objetoCentralActual = pCarro;
    }
    public void destruirCarroCentralActual()
    {
        if(_objetoCentralActual != null)
        Destroy(_objetoCentralActual);
    }
    public Vector3 retornarPosicion()
    {
        return this.transform.position;
    }

    public Quaternion retornarRotacion()
    {
        return this.transform.rotation;
    }

}
