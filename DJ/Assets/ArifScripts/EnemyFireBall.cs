using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBall : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float speed;
    [SerializeField] float timeAlive;

    private void Start()
    {
        _rb.velocity = transform.up * speed;
        StartCoroutine(deathTimer());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Deal Damage to player ...other.gameObject.GetComponent<>
        }
        Destroy(this.gameObject);
    }

    IEnumerator deathTimer()
    {
        yield return new WaitForSeconds(timeAlive);
        Destroy(this.gameObject);
    }
}
