using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    // all my varibles
    private float x;
    public float speed;
    private Rigidbody2D rb;
    public float jumpForce;
    bool flip = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    //turns the player left and right with movement
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce)); 
        }
        if (x > 0 && !flip)
        {
            Flip();
        }
        if (x < 0 && flip)
        {
            Flip();
        }
        void Flip()
        {
            flip = !flip;
            transform.Rotate(0, 180, 0);
        }
    }
}
