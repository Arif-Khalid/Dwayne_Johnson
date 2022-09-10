using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy_Movement : MonoBehaviour
{
    GameObject player;
    public float speed = 1;
    public float enemyViewRange = 10;
    Rigidbody2D enemyRigidbody;
    Animator enemyAnimator;
    SpriteRenderer spriteRenderer;
    float distanceAway;
    Vector3 dir;
    [SerializeField] AIPath aiPath;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        //enemyRigidbody = gameObject.GetComponent<Rigidbody2D>();
        enemyAnimator = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = aiPath.destination - transform.position;
        if (dir.x > 0)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else if (dir.x < 0)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
        enemyAnimator.SetFloat("Speed", aiPath.velocity.magnitude);
    }
    public void StopMoving() {
        aiPath.maxSpeed = 0;
    }
}

/*
If player is within enemyViewRange:
The enemy will move towards the player directly, without considering obstacles, etc.
*/