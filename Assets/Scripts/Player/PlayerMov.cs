using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float movSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public Joystick joystick;
    public bool canMove = true;

    void Start()
    {
        Debug.Log("teste");
    }

    void Update()
    {
        /* movement desktop
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        */
        if (canMove)
        {
            movement.x = joystick.Horizontal;
            movement.y = joystick.Vertical;

            animator.SetFloat("horizontal", movement.x);
            animator.SetFloat("vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);
        }
        else
        {
            movement.x = 0;
            movement.y = 0;
            
            animator.SetFloat("horizontal", movement.x);
            animator.SetFloat("vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);
        }
    }

    void FixedUpdate()
    {
       // Debug.Log(rb.position);
            rb.MovePosition(rb.position + (movement * movSpeed * Time.fixedDeltaTime));
       // animator.SetBool("isAttacking", false);
    }

    public void movePlayer(Vector2 movement)
    {
        Debug.Log(rb.position);
        Debug.Log(new Vector3(rb.position.x + movement.x, rb.position.y + movement.y, 10));
        GameObject playerLocal = GameObject.FindWithTag("Player");
        playerLocal.transform.position = new Vector3(rb.position.x + movement.x, rb.position.y + movement.y, 10);
        // rb.MovePosition(rb.position + new Vector2(x, y));
        Debug.Log(rb.position);
    }
}