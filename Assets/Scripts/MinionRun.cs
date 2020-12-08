using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionRun : StateMachineBehaviour
{
    Transform player;
    FacePlayer faceplayer;
    Rigidbody2D rb;

    public float attackRange = 3f;
    public float speed = 2.5f;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        faceplayer = animator.GetComponent<FacePlayer>();
    }

     //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            faceplayer.LookAtPlayer();
            //Vector2 target = new Vector2(player.position.x, rb.position.y);
            //Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
            //rb?.MovePosition(newPos);
            animator.SetTrigger("Attack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

}
