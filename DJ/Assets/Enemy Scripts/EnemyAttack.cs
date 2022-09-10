using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int attackDamage = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) 
    {
        // if collision with player
        if (collision.gameObject.tag == "Player") {
            Debug.Log("collision with player");
            
            // add take damage to player
        }
        Debug.Log("test");
    }
    void OnCollisionExit(Collision collision) 
    {
        // if no more collision with player
        if (collision.gameObject.tag == "Player") {
            Debug.Log("no collision with player");
            
            // stop take damage to player
        }
        Debug.Log("test");
    }
    
}
/*
Enemy attack:
- does damage to player based on attackDamage
- 

*/