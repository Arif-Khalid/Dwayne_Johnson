using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Items/Weapon Item")]
public class WeaponItem : MonoBehaviour
{
    public GameObject modelPrefab;
    [SerializeField] string _weaponName;
    //[SerializeField] GameObject _weaponModel;
    [SerializeField] BoxCollider2D _damageCollider;
    [SerializeField] bool attack;
    [SerializeField] Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _damageCollider = GetComponent<BoxCollider2D>();
        if(_damageCollider == null)
        {
            Debug.LogError("BoxCollider is NULL");
        }
        else
        {
            _damageCollider.enabled = false;
        }
        attack = false;
    }
    private void Update()
    {
        _anim.SetBool("attack", attack);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void EnableDamageCollider()
    {
        _damageCollider.enabled = true;
    }

    public void DisableDamageCollider()
    {
        _damageCollider.enabled = false;
        attack = false;
    }

    public void SetAttackBool(bool value)
    {
        attack = value;
    }

    public bool GetAttackBool()
    {
        return attack;
    }
}
