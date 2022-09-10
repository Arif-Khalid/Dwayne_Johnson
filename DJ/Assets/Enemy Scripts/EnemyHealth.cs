using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    bool dead = false;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && !dead) {
            // dies
            dead = true;
            enemyAnimator.SetBool("dead", true);
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
    
}
/*
Enemy health system
- if health <= 0, then dies
*/