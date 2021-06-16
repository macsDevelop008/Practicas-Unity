using System;
//llamado desde la GUI al iniciar, se llama para cada carro.
public class CrearCarroCarrera
{
    IFabricaCarro _fabrica;

    IEstructuraCarro _estructura;


    public CrearCarroCarrera(string nombre)
    {
        _fabrica = (IFabricaCarro) Activator.CreateInstance(Type.GetType(nombre));
    }

    public void crearEstructuraCarroCarrera(SOBaseCarro pDatos)
    {
        _estructura = _fabrica.crearEstructuraCarro(pDatos);
    }

    public IEstructuraCarro darEstructuraCarro()
    {
        return this._estructura;
    }
}