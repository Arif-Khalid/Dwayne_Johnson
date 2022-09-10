using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public GameObject player;
    public float speed = 1;
    public float enemyViewRange = 10;
    Rigidbody2D enemyRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(player.transform.position, enemyRigidbody.position) < enemyViewRange) {
            enemyRigidbody.velocity = speed * ((Vector2)player.transform.position - enemyRigidbody.position).normalized;
        }
    }
}

/*
If player is within enemyViewRange:
The enemy will move towards the player directly, without considering obstacles, etc.
*/