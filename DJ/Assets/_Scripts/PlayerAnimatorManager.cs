using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;
    [SerializeField] Animator _anim;
    [SerializeField] bool _isMoving;
    private void Awake()
    {
        _playerManager = GetComponent<PlayerManager>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float _moveDirectionX = _playerManager.GetMoveDirectionX();
        float _moveDirectionY = _playerManager.GetMoveDirectionY();
        _isMoving = (_moveDirectionX != 0 || _moveDirectionY != 0) ? true : false;

        _anim.SetBool("isMoving", _isMoving);

    }



}
