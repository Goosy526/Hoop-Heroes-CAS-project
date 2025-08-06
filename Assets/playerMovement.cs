using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float Move;

    public float Speed;
    public float Jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(Move * Speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump(w)"))
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, Jump * 10));
        }
    }
}
