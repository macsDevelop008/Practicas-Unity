
using UnityEngine;

public interface IEstructuraCarro
{
    //Retorna el objeto (Prefab) carro.
    //@return float --Prefab carro.
    GameObject retornarObjetoCarro();

    //------------------------------------

    //Retorna la velocidad del Carro.
    //@return float --Valor Actual de la velocidad del carro.
    float retornarVelocidad();

    //Retorna la potencia del Carro.
    //@return float --Valor Actual de la potencia del carro.
    float retornarPotencia();

    //Retorna la exploracion del Carro.
    //@return float --Valor Actual de la exploracion del carro.
    float retornarExploiracion();

    //---------------------------

    //Añade velocidad al carro.
    void añadirVelocidad(float pVelocidad);

    //Añade potencia al carro.
    void añadirPotencia(float pPotencia);

    //Añade exploracion al carro.
    void añadirExploracion(float pExploracion);

    //---------------------------

    //Quita velocidad al carro.
    void quitarVelocidad(float pVelocidad);

    //Quita potencia al carro.
    void quitarPotencia(float pPotencia);

    //Quita exploracion al carro.
    void quitarExploracion(float pExploracion);

    //---------------------------

    //Retorna el objeto que representa el aumento en la velocidad del carro (Si cuenta con uno).
    GameObject retornarObjetoVelocidadAñadida();

    //Retorna el objeto que representa el aumento en la velocidad del carro (Si cuenta con uno).
    GameObject retornarObjetoPotenciaAñadida();

    //Retorna el objeto que representa el aumento en la velocidad del carro (Si cuenta con uno).
    GameObject retornarObjetoExploracionAñadida();

    //---------------------------

    //Añadir objeto que representa el aumento de la velocidad del carro (Si no cuenta ya con uno).
    void añadirObjetoVelocidad(GameObject pObjetoVelocidad);

    //Añadir objeto que representa el aumento de la potencia del carro (Si no cuenta ya con uno).
    void añadirObjetoPotencia(GameObject pObjetoPotencia);

    //Añadir objeto que representa el aumento de la exploracion del carro (Si no cuenta ya con uno).
    void añadirObjetoExploracion(GameObject pObjetoExploracion);

    //---------------------------

    //Quita objeto que representa el aumento de la velocidad del carro (Si cuenta con uno).
    void quitarObjetoVelocidad();

    //Quita objeto que representa el aumento de la potencia del carro (Si cuenta con uno).
    void quitarObjetoPotencia();

    //Quita objeto que representa el aumento de la exploracion del carro (Si cuenta con uno).
    void quitarObjetoExploracion();
}
