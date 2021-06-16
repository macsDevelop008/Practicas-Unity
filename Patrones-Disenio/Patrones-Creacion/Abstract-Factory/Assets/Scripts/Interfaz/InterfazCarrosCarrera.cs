using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazCarrosCarrera : MonoBehaviour
{
    [SerializeField] Button _btnSiguiente;
    [SerializeField] Button _btnAtras;
    [SerializeField] SOBaseCarro[] _datosTodosCarros;
    List<CarroCarrera> _listadoCarros;
    int _posicionCarroActual;


    // Primer frame
    void Start()
    {
        _posicionCarroActual = 0;
        _listadoCarros = new List<CarroCarrera>();
        //Crear Automoviles
        crearCarros();
        //Posicionarlos en la GUI el primer carro
        posicionarCarro();
    }

    void crearCarros()
    {
        for(int i = 0; i < _datosTodosCarros.Length; i++)
        {
            CrearCarroCarrera nuevoCarro = new CrearCarroCarrera(_datosTodosCarros[i].fabrica);

            nuevoCarro.crearEstructuraCarroCarrera(_datosTodosCarros[i]);

            _listadoCarros.Add((CarroCarrera)nuevoCarro.darEstructuraCarro());
        }
    }

    void posicionarCarro()
    {
        //Quitar carro actual de la UI
        PivotCentro._shared.destruirCarroCentralActual();

        //Intanciar graficamente y ajustar posicion
        Vector3 posicion = PivotCentro._shared.retornarPosicion();
        Quaternion rotacion = PivotCentro._shared.retornarRotacion();
        GameObject carroCentroPivot = Instantiate(_listadoCarros[_posicionCarroActual].retornarObjetoCarro(),
                                                                                        posicion, rotacion);
        //Poner el carro en la UI segun contador
        PivotCentro._shared.cambiarCarroCentralActual(carroCentroPivot);

        carroCentroPivot.AddComponent(typeof(Rotacion));
        
        //Ajustar estadisticas segun el carro actual
        PanelEstadisticas._shared.modificarVelocidad(_listadoCarros[_posicionCarroActual].retornarVelocidad());
        PanelEstadisticas._shared.modificarPotencia(_listadoCarros[_posicionCarroActual].retornarPotencia());
        PanelEstadisticas._shared.modificarExploracion(_listadoCarros[_posicionCarroActual].retornarExploiracion());
    }


    //EVENTOS-----------------------
    public void btn_Siguiente()
    {
       _posicionCarroActual++;
        posicionarCarro();
        if(_posicionCarroActual >= _datosTodosCarros.Length-1)
        {
            _btnSiguiente.interactable = false;
        }
        if(_posicionCarroActual > 0)
        {
            _btnAtras.interactable = true;
        }
    }
    public void btn_Atras()
    {
        _posicionCarroActual--;
        posicionarCarro();
        if(_posicionCarroActual <= 0)
        {
            _btnAtras.interactable = false;
        }
        if(_posicionCarroActual < _datosTodosCarros.Length)
        {
            _btnSiguiente.interactable = true;
        }
    }
}
