using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Pathfinding;

public class AiMovement : MonoBehaviour
{
    [SerializeField]AIPath aiPath;
    [SerializeField] LayerMask whatisObstaclesAndPlayer;
    [SerializeField] float attackDistance;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject fireBall;
    [SerializeField] float timeBetweenShots;
    [SerializeField] Animator animator;
    [SerializeField] AudioSource audioSource;
    Vector3 dir;
    bool shot = false;

    private void Update()
    {
        dir = aiPath.destination - transform.position;
        if(dir.x > 0)
        {
            transform.localScale = new Vector3(5, transform.localScale.y, transform.localScale.z);
        }
        else if(dir.x < 0)
        {
            transform.localScale = new Vector3(-5, transform.localScale.y, transform.localScale.z);
        }
        Debug.DrawLine(transform.position, transform.position + dir.normalized*attackDistance);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, attackDistance, whatisObstaclesAndPlayer);
        if(hit.collider != null)
        {
            Debug.Log("Hit something");
            if(hit.collider.tag == "Player")
            {
                //Stop and shoot
                if (!shot) { Shoot(); }
                aiPath.maxSpeed = 0;
            }
            else
            {
                aiPath.maxSpeed = 2;
            }
        }
        else
        {
            aiPath.maxSpeed = 2;
        }
        animator.SetFloat("Speed", aiPath.velocity.magnitude);
    }

    public void StopMoving()
    {
        //aiPath.maxSpeed = 0;
        aiPath.enabled = false;
    }

    private void Shoot()
    {
        audioSource.Play();
        Instantiate<GameObject>(fireBall, firePoint.position, Quaternion.LookRotation(Vector3.forward,dir));
        shot = true;
        Invoke(nameof(resetShoot), timeBetweenShots);
    }

    void resetShoot()
    {
        shot = false;
    }
}
