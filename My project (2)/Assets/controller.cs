using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 5f; 
    public float jumpForce = 10f; 
    public float doubleJumpForce = 12f; 
    private Rigidbody2D rb; 
    private bool isGrounded; 
    private bool doubleJump; 

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 position = rb.position + Vector2.right * horizontal * speed * Time.deltaTime;
        rb.MovePosition(position);

        
        isGrounded = Physics2D.Linecast(transform.position, GameObject.Find("player").transform.position, 1 << LayerMask.NameToLayer("Ground"));

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            doubleJump = true;
        }
        
        else if (Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.AddForce(Vector2.up * doubleJumpForce, ForceMode2D.Impulse);
            doubleJump = false;
        }
    }
}
