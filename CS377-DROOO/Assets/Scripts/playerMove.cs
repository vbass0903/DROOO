﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMove : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float jumpVelocity = 7.5f;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public bool isAttached = false;
    ControllerActions controls;
    Rigidbody2D rb;
    Vector2 move;
    float jumping;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controls = new ControllerActions();

        controls.Gameplay.Jump.performed += ctx => Jump();
        
        controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    }

    void Update()
    {
        jumping = controls.Gameplay.Jump.ReadValue<float>(); //Check for jump 
    }

    void FixedUpdate()
    {
        if (!isAttached) //While not attached to a station, allow movement
        {
            //Horizontal Movement
            Vector3 movement = new Vector3(move.x, 0f, 0f);
            transform.position += movement * Time.fixedDeltaTime * moveSpeed;

            //Adds variable jumping, tighter falling
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y *
                    (fallMultiplier - 1) * Time.fixedDeltaTime;
            }
            else if (rb.velocity.y > 0 && jumping == 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y *
                    (lowJumpMultiplier - 1) * Time.fixedDeltaTime;
            }
        }
    }

    void Jump()
    {
        if (isGrounded && !isAttached) //Check for touching grounded surface and attachment
        {
            rb.AddForce(new Vector2(0f, jumpVelocity), ForceMode2D.Impulse);
        }
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }
    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
