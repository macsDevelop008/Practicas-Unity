using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


public class FactoryPowerUp 
{
    private PowerUpConfiguration _configuration;

    public FactoryPowerUp(PowerUpConfiguration configuration)
    {
        _configuration = configuration;
    }

    public AbstractPowerUp Create(string id)
    {
        var powerup = _configuration.GetPwerUpPrefabById(id);

        return Object.Instantiate(powerup);

    }
}
