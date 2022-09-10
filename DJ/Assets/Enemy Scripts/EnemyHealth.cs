using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    bool dead = false;
    int previousHealth;
    BoxCollider2D enemyCollider;
    Enemy_Movement enemy_Movement;
    Animator enemyAnimator;
    SpriteRenderer enemySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        enemyCollider = GetComponent<BoxCollider2D>();
        enemy_Movement = GetComponent<Enemy_Movement>();
        enemySpriteRenderer = GetComponent<SpriteRenderer>();

        previousHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (previousHealth != health) {
            // calls take damage if health is adjusted manually in the editor
            previousHealth = health;
            TakeDamage(0);
        }
    }
    public void TakeDamage(int damage) {
        // call this function to make the enemy take damage

        StartCoroutine(DamageColor()); // damage indicator: red color

        health -= damage;
        previousHealth = health;

        if (health <= 0 && !dead) {
            // dies
            dead = true;
            enemyAnimator.SetBool("dead", true);
            enemy_Movement.StopMoving();
            enemy_Movement.enabled = false;
            enemyCollider.enabled = false;

            StartCoroutine(Fade());
        }
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1f);
        for (float t = 0; t <= 1; t += 0.1f) {
            enemySpriteRenderer.color =  Color.Lerp(Color.white, Color.red, t);
            yield return new WaitForSeconds(0.1f);
        }
        for (float t = 0; t <= 1; t += 0.01f) {
            enemySpriteRenderer.color =  Color.Lerp(Color.red, Color.clear, t);
            yield return new WaitForSeconds(0.1f);
        }
        // either this or reinstantiate the enemy with prefab
        gameObject.SetActive(false);
    }
    IEnumerator DamageColor()
    {
        for (float t = 0; t <= 1; t += 0.1f) {
            enemySpriteRenderer.color =  Color.Lerp(Color.white, Color.red, t);
            yield return new WaitForSeconds(0.02f);
        }
        for (float t = 0; t <= 1; t += 0.1f) {
            enemySpriteRenderer.color =  Color.Lerp(Color.red, Color.white, t);
            yield return new WaitForSeconds(0.02f);
        }
    }
    
    
}
/*
Enemy health system
- if health <= 0, then dies
*/