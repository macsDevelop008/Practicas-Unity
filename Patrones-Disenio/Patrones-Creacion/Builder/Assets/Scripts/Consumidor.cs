using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumidor : MonoBehaviour
{
    private void Awake()
    {
        VehiculoBuilder vehiculo = new VehiculoBuilder();
        
        //Aquí se crearia un vehiculo, para instanciar cosas(GameObjects) se le pasaria en esos "null"
        //es decir por parametro
        vehiculo
        .WithChassis(null)
        .WithNeumatico(PosicionNeumatico.AtrasDerecha, null)
        .WithPosicion(new Vector3(1,2,3))
        .Build();

        //Para poder crear otro NUEVO pero que tiene algunas caracterizticas similares al previamente creado
        //se llama a el mismo vehiculo, s ele cambia lo que se desea y se le hace el Build

        //Crearia otro vehiculo igual al anterior pero con esta nueva rotacion   
        vehiculo.WithRotacion(new Quaternion(1,0,1,1)); 
    }
}
