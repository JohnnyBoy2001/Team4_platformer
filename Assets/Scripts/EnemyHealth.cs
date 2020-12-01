using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Animator animator;
    
    public int maxHealth = 100;
    int currentHealth;
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //Play Hurt Animation
        

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died");
        animator.SetBool("IsDead", true);

        //GetComponent<Collider2D>().enabled = false;
        GetComponent<Move>().enabled = false;
        this.enabled = false;
    }
    // Update is called once per frame
   
}
