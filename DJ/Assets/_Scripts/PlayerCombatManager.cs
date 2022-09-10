using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;
    [SerializeField] Transform _playerHand;
    [SerializeField] WeaponItem _weaponItem;
    
    private void Awake()
    {
        _playerManager = GetComponent<PlayerManager>();
    }

    public void LoadWeaponInHand()
    {
        
    }

    public void HandleAttacking()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            if(_weaponItem != null && _weaponItem.GetAttackBool() == false)
            { 
                _weaponItem.SetAttackBool(true);
            }
        }
    }

}
