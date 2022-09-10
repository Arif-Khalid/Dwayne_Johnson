using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    GameObject player;
    public float speed = 1;
    public float enemyViewRange = 10;
    Rigidbody2D enemyRigidbody;
    Animator enemyAnimator;
    SpriteRenderer spriteRenderer;
    float distanceAway;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyRigidbody = gameObject.GetComponent<Rigidbody2D>();
        enemyAnimator = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceAway = Vector3.Distance(player.transform.position, enemyRigidbody.position);
        
        // moving when within a range
        if (distanceAway < enemyViewRange && distanceAway > 0.5) {
            // moving towards the left
            if (enemyRigidbody.velocity.x < 0) {
                spriteRenderer.flipX = true;
            } else {
                spriteRenderer.flipX = false;
            }

            // apply velocity to enemy
            enemyRigidbody.velocity = speed * ((Vector2)player.transform.position - enemyRigidbody.position).normalized;
            enemyAnimator.SetBool("moving", true);
        } else {
            // set velocity to zero
            StopMoving();
        }
    }
    public void StopMoving() {
        // this will stop all movement for the enemy
        enemyRigidbody.velocity = Vector2.zero;
        enemyAnimator.SetBool("moving", false);
    }
}

/*
If player is within enemyViewRange:
The enemy will move towards the player directly, without considering obstacles, etc.
*/