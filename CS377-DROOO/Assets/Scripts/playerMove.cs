using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float jumpVelocity = 7.5f;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    public bool isAttached = false;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
    }

    void FixedUpdate()
    {
        if (!isAttached) //While not attached to a station, allow movement
        {
            //Horizontal Movement
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.fixedDeltaTime * moveSpeed;

            //Adds variable jumping, tighter falling
            if (rb.velocity.y < 0)
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y *
                    (fallMultiplier - 1) * Time.fixedDeltaTime;
            }
            else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y *
                    (lowJumpMultiplier - 1) * Time.fixedDeltaTime;
            }
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded) //Check for jump && touching grounded surface
        {
            rb.AddForce(new Vector2(0f, jumpVelocity), ForceMode2D.Impulse);
        }
    }
}
