using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float runSpeed;
    public float jumpForce;
    private float moveInput;
    
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    public float jumpTimeCounter;
    public float jumpTime;
    public bool isJumping;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            animator.SetBool("IsWalking", true);
        }
        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            animator.SetBool("IsWalking", true);
        }
        else if (moveInput == 0)
            animator.SetBool("IsWalking", false);

      

        if (isGrounded == true && Input.GetKeyDown(KeyCode.W))
        {
            isJumping = true;
            //animator
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.W) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false;
        }
    }

} 