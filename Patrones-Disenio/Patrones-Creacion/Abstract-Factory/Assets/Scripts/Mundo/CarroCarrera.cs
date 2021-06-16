using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroCarrera : IEstructuraCarro
{

    //Atributos
    GameObject _objetoCarro;

    float _velocidad;
    float _potencia;
    float _exploracion;

    GameObject _objetoVelocidad;
    GameObject _objetoPotencia;
    GameObject _objetoExploracion;

    //Vector3 _posModeEngine;  //Posicion objeto - Representa potencia
    //Vector3 _posModLights;  //Posicion objeto - Representa exploracion
    //Vector3 _posModSpiler;  //Posicion objeto - Representa velocidad


    //Constructor
    public CarroCarrera(SOBaseCarro pElementosCarro)
    {
        this._objetoCarro = pElementosCarro._objeto;

        this._velocidad = pElementosCarro._velocidad;
        this._potencia = pElementosCarro._potencia;
        this._exploracion = pElementosCarro._exploracion;

        this._objetoVelocidad = null;
        this._objetoPotencia = null;
        this._objetoExploracion = null;

        //this._posModeEngine = pElementosCarro._posModeEngine.position;
        //this._posModLights = pElementosCarro._posModLights.position;
        //this._posModSpiler = pElementosCarro._posModSpiler.position;
    }

    public GameObject retornarObjetoCarro(){ return this._objetoCarro; }

    //----------------------------------------------------------------------------

    public float retornarVelocidad(){ return this._velocidad; }
    public float retornarPotencia(){ return this._potencia; }
    public float retornarExploiracion(){ return this._exploracion; }

    //----------------------------------------------------------------------------

    public void añadirVelocidad(float pVelocidad){ this._velocidad += pVelocidad;}
    public void añadirPotencia(float pPotencia){ this._potencia += pPotencia;}
    public void añadirExploracion(float pExploracion){ this._exploracion += pExploracion;}

    //----------------------------------------------------------------------------

    public void quitarVelocidad(float pVelocidad){ this._velocidad = pVelocidad; }
    public void quitarPotencia(float pPotencia){ this._potencia = pPotencia; }
    public void quitarExploracion(float pExploracion){ this._exploracion = pExploracion; }

    //----------------------------------------------------------------------------

    public GameObject retornarObjetoVelocidadAñadida(){ return this._objetoVelocidad;}
    public GameObject retornarObjetoPotenciaAñadida(){ return this._objetoPotencia;}
    public GameObject retornarObjetoExploracionAñadida(){ return this._objetoExploracion;}

    //----------------------------------------------------------------------------

    public void añadirObjetoVelocidad(GameObject pObjetoVelocidad){ this._objetoVelocidad = pObjetoVelocidad;}
    public void añadirObjetoPotencia(GameObject pObjetoPotencia){ this._objetoPotencia = pObjetoPotencia;}
    public void añadirObjetoExploracion(GameObject pObjetoExploracion){ this._objetoExploracion = pObjetoExploracion;}

    //----------------------------------------------------------------------------

    public void quitarObjetoVelocidad()
    {
        //Destruir objeto

        this._objetoVelocidad = null; 
    }
    public void quitarObjetoPotencia()
    {
        //Destruir objeto
        
        this._objetoPotencia = null; 
    }
    public void quitarObjetoExploracion()
    {
        //Destruir objeto
        
        this._objetoExploracion = null; 
    }
}
