using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// No hace falta que sea "MonoBehaviour"
public class VehiculoBuilder
{
    //Variables donde se guardan las distintas piezas
    Chassis _chassis;
    readonly Dictionary<PosicionNeumatico, Neumatico> _neumaticos;
    Vector3 _posicion;
    Quaternion _rotacion; 
    Vehiculo _vehiculo;


    //Constructor, aquí podemos indicar valores por defecto si se desea, valores que el usuario
    //no debe modificar para crear el objeto. Se usa mas que todo para el test
    public VehiculoBuilder()
    {
        _chassis = null;
        _neumaticos = new Dictionary<PosicionNeumatico, Neumatico>();
        _posicion = Vector3.zero;
        _rotacion = Quaternion.identity;
        _vehiculo = null;
    }

    //Metodos para asignar las piezas

    //Se retorna a si mismo y recibe un chassis
    public VehiculoBuilder WithChassis(Chassis chassis)
    {
        _chassis = chassis;

        return this;
    }
    public VehiculoBuilder WithNeumatico(PosicionNeumatico posicionNeumatico, Neumatico neumatico)
    {
        _neumaticos.Add(posicionNeumatico, neumatico);

        return this;
    }
    public VehiculoBuilder WithPosicion(Vector3 posicion)
    {
        _posicion = posicion;
        return this;
    }
        public VehiculoBuilder WithRotacion(Quaternion rotacion)
    {
        _rotacion = rotacion;
        return this;
    }
    //Muy importante en este caso, el metodo para el prefab
    public VehiculoBuilder FromVehiculoPrefab(Vehiculo vehiculo)
    {
        _vehiculo = vehiculo;
        return this;
    }


    //Metodo que retorta el vehiculo ya CONTRUIDO
    public Vehiculo Build()
    {
        //En este caso para crear el vehiculo pues seria instanciandole, al igual que los neumaticos y chassis
        var vehiculo = Object.Instantiate(_vehiculo, _posicion, _rotacion);
        var chassis = Object.Instantiate(_chassis, vehiculo.transform, true);
        var neumaticos = new Dictionary<PosicionNeumatico, Neumatico>();
        foreach(var neumatico in _neumaticos)
        {
            var neumaticoInstancia = Object.Instantiate(neumatico.Value, chassis.GetPosicionNeumatico(neumatico.Key));
            neumaticos.Add(neumatico.Key, neumaticoInstancia);
        }

        vehiculo.SetComponentes(neumaticos, chassis);

        return (Vehiculo) vehiculo;
    }

}
