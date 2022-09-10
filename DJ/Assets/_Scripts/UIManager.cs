using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;
    [SerializeField] Slider healthBar;

    private void Awake()
    {
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    private void Start()
    {
        healthBar.maxValue = _playerManager.GetMaxHealth();
        healthBar.value = _playerManager.GetCurrentHealth();
    }

    public void TakeDamage(float damage)
    {
        healthBar.value -= damage;
    }

}
