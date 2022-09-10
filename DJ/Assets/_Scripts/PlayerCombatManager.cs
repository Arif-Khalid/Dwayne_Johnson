using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;
    [SerializeField] Transform _playerHand;
    [SerializeField] WeaponItem _currentWeaponItem;
    
    private void Awake()
    {
        _playerManager = GetComponent<PlayerManager>();
    }

    public void LoadCurrentWeapon()
    {
        Instantiate(_currentWeaponItem, _playerHand);
    }

    public void HandleAttacking()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(_currentWeaponItem != null && _currentWeaponItem.GetAttackBool() == false)
            {
                _currentWeaponItem.SetAttackBool(true);
            }
        }
    }

}
