using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementManager))]
[RequireComponent(typeof(PlayerAnimatorManager))]
[RequireComponent(typeof(Animator))]
public class PlayerManager : MonoBehaviour
{
    [SerializeField] PlayerMovementManager _playerMovementManager;
    [SerializeField] PlayerAnimatorManager _playerAnimatorManager;
    [SerializeField] PlayerStatsManager _playerStatsManager;
    [SerializeField] PlayerCombatManager _playerCombatManager;
    [SerializeField] Animator _anim;

    [Header("Character Booleans")]
    [SerializeField] bool _isDead;
    [SerializeField] bool _isMoving;

    private void Awake()
    {
        _playerMovementManager = GetComponent<PlayerMovementManager>();
        _playerAnimatorManager = GetComponent<PlayerAnimatorManager>();
        _playerStatsManager = GetComponent<PlayerStatsManager>();
        _playerCombatManager = GetComponent<PlayerCombatManager>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
       HandleMovement();
       HandleRotation();
       HandleAttacking();
        _isMoving = (GetMoveDirectionX() != 0 || GetMoveDirectionY() != 0) ? true : false;
       _playerAnimatorManager.SetAnimatorBool("isMoving", _isMoving);
    }

    public Animator GetAnimator()
    {
        return _anim;
    }

    #region PlayerAnimatorManager Methods

    #endregion

    #region PlayerMovementManager Methods
    public void HandleMovement()
    {
        _playerMovementManager.HandleMovement();
    }

    public void HandleRotation()
    {
        _playerMovementManager.HandleRotation();

    }
    public float GetMoveDirectionX()
    {
        return _playerMovementManager.GetMoveDirectionX();
    }

    public float GetMoveDirectionY()
    {
        return _playerMovementManager.GetMoveDirectionY();
    }
    #endregion

    private void HandleAttacking()
    {
        _playerCombatManager.HandleAttacking();
    }

}
