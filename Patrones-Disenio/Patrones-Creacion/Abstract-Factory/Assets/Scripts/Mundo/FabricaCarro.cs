using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FabricaCarro : IFabricaCarro
{
    IEstructuraCarro IFabricaCarro.crearEstructuraCarro(SOBaseCarro pBaseCarro)
    {
        CarroCarrera nuevoCarro = new CarroCarrera(pBaseCarro);
        return nuevoCarro;
    }
}
