using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorManager : MonoBehaviour
{
    [SerializeField] PlayerManager _playerManager;
    [SerializeField] Animator _anim;

    private void Awake()
    {
        _playerManager = GetComponent<PlayerManager>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }

    public void SetAnimatorBool(string boolName, bool value)
    {
        _anim.SetBool(boolName, value);
    }

    public void PlayTargetAnimation(string targetAnim)
    {
        _anim.Play(targetAnim);
    }
}
