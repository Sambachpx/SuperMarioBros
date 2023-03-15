using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
<<<<<<< HEAD
=======
    public float speed = 100f; 
    public float jumpForce = 10f; 
    public float doubleJumpForce = 12f; 
    private Rigidbody2D rb; 
    private bool isGrounded; 
    private bool doubleJump; 
>>>>>>> 081757e7d8ef8a0bfb30609c67776ee516ac0501

    public Rigidbody2D rb2d;
    public SpriteRenderer rend;
    public float Speed = 5;
    public float JumpSpeed = 50;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()

    {
        float h = Input.GetAxis("Horizontal") * Speed;
        rb2d.velocity = new Vector2(h, rb2d.velocity.y);

<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.Space))
=======
        
        isGrounded = Physics2D.Linecast(transform.position, GameObject.Find("player").transform.position, 1 << LayerMask.NameToLayer("sol"));

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
>>>>>>> 081757e7d8ef8a0bfb30609c67776ee516ac0501
        {
            rb2d.AddForce(transform.up * JumpSpeed, ForceMode2D.Impulse);
        }
    }
}