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
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
       // Debug.Log(rb.position);
        rb.MovePosition(rb.position + (movement * movSpeed * Time.fixedDeltaTime));
    }
}