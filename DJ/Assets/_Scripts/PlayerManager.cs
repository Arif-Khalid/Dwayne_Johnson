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
    [SerializeField] Animator _anim;
    private void Awake()
    {
        _playerMovementManager = GetComponent<PlayerMovementManager>();
        _playerAnimatorManager = GetComponent<PlayerAnimatorManager>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
       HandleMovement();
       HandleRotation();
    }

    public Animator GetAnimator()
    {
        return _anim;
    }

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


}
