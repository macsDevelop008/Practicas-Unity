using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chassis : MonoBehaviour
{


    [SerializeField] Transform _frenteDerechaPsicionNeumatico;
    [SerializeField] Transform _frenteIzquierdaPsicionNeumatico;
    [SerializeField] Transform _atrasDerechaPsicionNeumatico;
    [SerializeField] Transform _atrasIzquierdaPsicionNeumatico;

    public Transform GetPosicionNeumatico(PosicionNeumatico posicion)
    {
        switch(posicion)
        {
            case PosicionNeumatico.FrenteDerecha:
                return _frenteDerechaPsicionNeumatico;

            case PosicionNeumatico.FrenteIzquierda:
                return _frenteIzquierdaPsicionNeumatico;

            case PosicionNeumatico.AtrasDerecha:
                return _atrasDerechaPsicionNeumatico;

            case PosicionNeumatico.AtrasIzquierda:
                return _atrasIzquierdaPsicionNeumatico;         
        }

        return null;
    }

    protected abstract void OnCollisionEnter(Collision other);



}
