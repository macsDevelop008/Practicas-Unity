using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Carro Nuevo", menuName = "Carro")] 
public class SOBaseCarro : ScriptableObject
{
    public string fabrica = "FabricaCarro"; //Guarda el nombre de la Fabrica(Clase) segun el tipo de vehiculo, este caso carro
    public GameObject _objeto;         //Carro PreFab, archivo .obj, .fbx, etc.
    [Range(1,100)]public float _velocidad = 1;
    [Range(1,100)]public float _potencia = 1;
    [Range(1,100)]public float _exploracion = 1;

    //public Transform _posModeEngine;  //Transform objeto - Representa potencia
    //public Transform _posModLights;  //Transform objeto - Representa exploracion
    //public Transform _posModSpiler;  //Transform objeto - Representa velocidad
    
}
