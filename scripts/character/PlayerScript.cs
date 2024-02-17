using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float ms = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    
    void FixedUpdate()
    {
        SwitchSides();
        rb.MovePosition(rb.position + movement * ms * Time.fixedDeltaTime);
    }
    
    void SwitchSides()
    {
        float moveInput = Input.GetAxis("Horizontal");
        
        if (moveInput < 0 )
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (moveInput > 0 )
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

}