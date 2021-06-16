using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelEstadisticas : MonoBehaviour
{
    public static PanelEstadisticas _shared;

    [SerializeField] Slider _sldVelocidad;
    [SerializeField] Slider _sldPotencia;
    [SerializeField] Slider _sldExploracion;

    [SerializeField] Text _txtVelocidad;
    [SerializeField] Text _txtPotencia;
    [SerializeField] Text _txtExploracion;


    void Awake() 
    {
        _shared = this;
    }

    public void modificarVelocidad(float pNum)
    {
        _sldVelocidad.value = pNum;
        _txtVelocidad.text = pNum.ToString();
    }

    public void modificarPotencia(float pNum)
    {
        _sldPotencia.value = pNum;
        _txtPotencia.text = pNum.ToString();
    }

    public void modificarExploracion(float pNum)
    {
        _sldExploracion.value = pNum;
        _txtExploracion.text = pNum.ToString();
    }

}
