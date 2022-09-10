using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;

    [Header("Character Max Stats")]
    [SerializeField] float _playerMaxHealth = 10;
    [Header("Character Stats")]
    [SerializeField] float _playerHealth = 10;
    [SerializeField] float _playerStamina = 10;
    [SerializeField] float _playerMana = 10;

    [Header("Character Models")]
    [SerializeField] Sprite[] _hurtModels;

    private void Awake()
    {
        _playerManager = GetComponent<PlayerManager>();
    }

    public void TakeDamage(float damage)
    {
        _playerHealth -= damage;
        if(_playerHealth <= 0)
        {
            _playerManager.SetIsDead(true);
        }
    }

    public void DrainStamina(float stamina)
    {
        _playerStamina -= stamina;
    }

    public void DrainMana(float mana)
    {
        _playerMana -= mana;
    }

    public float GetMaxHealth()
    {
        return _playerMaxHealth;
    }

    public float GetCurrentHealth()
    {
        return _playerHealth;
    }
    
}
