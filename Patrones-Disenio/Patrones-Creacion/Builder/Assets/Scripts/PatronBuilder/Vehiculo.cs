using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    Dictionary<PosicionNeumatico, Neumatico> _neumaticos;   //Neumatico y su posicion
    Chassis _chassis;   //Chasis

    //Aquí es donde estaria toda la logica del vehiculo, si resibe daño, etc.
    public void SetComponentes(Dictionary<PosicionNeumatico, Neumatico> neumaticos, Chassis chassis)
    {
        _neumaticos = neumaticos;
        _chassis = chassis;
    }
}
