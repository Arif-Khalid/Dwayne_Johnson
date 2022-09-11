using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBall : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float speed;
    [SerializeField] float timeAlive;
    [SerializeField] float damage;

    private void Start()
    {
        _rb.velocity = transform.up * speed;
        StartCoroutine(deathTimer());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Hit Player");
            //Deal Damage to player ...other.gameObject.GetComponent<>
            other.gameObject.GetComponent<PlayerManager>().TakeDamage(damage);
        }
        Destroy(this.gameObject);
    }

    IEnumerator deathTimer()
    {
        yield return new WaitForSeconds(timeAlive);
        Destroy(this.gameObject);
    }
}
