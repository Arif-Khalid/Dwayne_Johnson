using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;

    [Header("Movement Values")]
    [SerializeField] float _moveSpeed = 5.0f;
    [SerializeField] float _moveDirectionX;
    [SerializeField] float _moveDirectionY;

    [SerializeField] Rigidbody2D _playerRb;

    private void Awake()
    {
        _playerManager = GetComponent<PlayerManager>();
        _playerRb = GetComponent<Rigidbody2D>();

        if (_playerRb == null)
        {
            Debug.LogError("Rigidbody Missing! Assign Rigidbody.");
        }
    }

    public void HandleMovement()
    {
        _moveDirectionX = Input.GetAxis("Horizontal");
        _moveDirectionY = Input.GetAxis("Vertical");

        if (_moveDirectionX != 0)
        {
            _playerRb.velocity = new Vector2(_moveDirectionX * _moveSpeed, _playerRb.velocity.y);
        }
        else
        {
            _playerRb.velocity = new Vector2(0, _playerRb.velocity.y);
        }
        if (_moveDirectionY != 0)
        {
            _playerRb.velocity = new Vector2(_playerRb.velocity.x, _moveDirectionY * _moveSpeed);
        }
        else
        {
            _playerRb.velocity = new Vector2(_playerRb.velocity.x, 0);
        }
    }

    public void HandleRotation()
    {
        if (_moveDirectionX > 0)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else if (_moveDirectionX < 0)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
    }

    public float GetMoveDirectionX()
    {
        return _moveDirectionX;
    }

    public float GetMoveDirectionY()
    {
        return _moveDirectionY;
    }
}
