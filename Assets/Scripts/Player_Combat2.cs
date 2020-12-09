using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Combat2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public LayerMask enemyLayers;
    public Transform AttackPoint;


    public float attackRate = 1f;
    float nextAttackTime = 0f;
    public float attackRange = 0.5f;
    public int attackDamage = 20;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }
    void Attack()
    {
        //Play Animation
        animator.SetTrigger("Attack");

        //Detect Enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);

        //Damage Enemies
        foreach (Collider2D enemy in hitEnemies)
        {
            //enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
            enemy.GetComponent<BossHealth>().TakeDamage(attackDamage);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;

        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
    }

}
