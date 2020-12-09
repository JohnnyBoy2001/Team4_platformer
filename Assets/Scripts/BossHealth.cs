using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public Animator animator;
    //public BossRun bossRun;

    public int maxHealth = 220;
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
        animator.SetTrigger("Hurt");

        if (currentHealth < 200)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died");
        //animator.SetBool("IsDead", true);

        //GetComponent<Collider2D>().enabled = false;
        //bossRun.speed = 0f;
        //bossRun.attackRange = 0f;
        this.enabled = false;
    }
    // Update is called once per frame
    public int GetHealth()
    {
        return currentHealth;
    }
}
