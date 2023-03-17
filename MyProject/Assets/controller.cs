using UnityEngine;

public class controller : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public SpriteRenderer rend;
    public float Speed = 20;
    public float JumpSpeed = 5;

    public int jumpsLeft = 2;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Speed;
        rb2d.velocity = new Vector2(h, rb2d.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && jumpsLeft > 0)
        {
            rb2d.AddForce(transform.up * JumpSpeed, ForceMode2D.Impulse);
            jumpsLeft--;
        }

        if (h > 0)
        {
            rend.flipX = false;
        }
        else if (h < 0)
        {
            rend.flipX = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpsLeft = 2;
        }
    }
}