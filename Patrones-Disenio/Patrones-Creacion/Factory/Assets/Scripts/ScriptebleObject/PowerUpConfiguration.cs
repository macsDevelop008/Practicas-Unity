using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Customer/Power Up Configuration")]
public class PowerUpConfiguration : ScriptableObject
{
    //Aqui se almacenan todos los prefabs 
 
    [SerializeField] private AbstractPowerUp[] _powerUps;
    private Dictionary<string, AbstractPowerUp> _ideToPowerUp;

    private void Awake()
    {
        _ideToPowerUp = new Dictionary<string, AbstractPowerUp>();
        
        foreach (var powerUp in _powerUps)
        {
            _ideToPowerUp.Add(powerUp.Id(), powerUp);
        }
    }

    public AbstractPowerUp GetPwerUpPrefabById(string id)
    {
        if (!_ideToPowerUp.TryGetValue(id, out var powerUp))
        {
            throw new Exception("Paila ñeñe no existe");
        }

        return powerUp;
    }
}
