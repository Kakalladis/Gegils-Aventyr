using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    Rigidbody2D rb;
    [SerializeField] float walkSpeed;
    [SerializeField] float jumpSpeed;
    

    bool isGrounded = true;


    private void OnCollisionEnter2D(Collision2D other) {
        isGrounded = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(walkSpeed, 0));
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-walkSpeed, 0));
        }

        if(Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);
            isGrounded = false;
        }
        
    }
}
