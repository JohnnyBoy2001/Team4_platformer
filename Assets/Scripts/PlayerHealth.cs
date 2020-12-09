using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public Animator animator;
    public Health healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }*/
    }
    public void TakeDamage(int damage)
    {
        if(currentHealth > 0)
        {
            animator.SetTrigger("Damage");
            currentHealth -= damage;
            healthbar.SetHealth(currentHealth);
        }    
            
        else if(currentHealth <= 0)
        {
            animator.SetBool("IsDead", true);
            GetComponent<PlayerController>().enabled = false;
            GetComponent<GameManager>().EndGame();
        }
    }
}
