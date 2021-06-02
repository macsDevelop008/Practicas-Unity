using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCustomer : MonoBehaviour
{
    [SerializeField] private PowerUpConfiguration _configuration;
    private FactoryPowerUp _factoryPowerUp;

    private void Awake()
    {
        _factoryPowerUp = new FactoryPowerUp(Instantiate(_configuration));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //Crea el power up con ese id
            _factoryPowerUp.Create("1");
        }
    }
}
