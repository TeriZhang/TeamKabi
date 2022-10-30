using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{
    public Vector2 moveDir;
    public Rigidbody2D rb;
    public float moveSpeed;
    public bool facingRight;
    float moveX;
    float moveY;
    // Start is called before the first frame update
<<<<<<< Updated upstream
    void Start()
    {
        
=======

    AnimationSis anisis;
    public GameObject sprite;


    void Start()
    {
        //anisis = GameObject.Find("charSprite").GetComponent<AnimationSis>();
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        inputs();
        move();

    }

    private void FixedUpdate()
    {
        
    }

    void inputs()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;

        if (moveX > 0 && !facingRight)
        {
            Flip();
        }
        if(moveX < 0 && facingRight)
        {
            Flip();
        }
    }
    void move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
<<<<<<< Updated upstream
=======
        //anisis.animator.SetFloat("Speed", Mathf.Abs(moveDir.x * moveSpeed + moveDir.y * moveSpeed));
        sprite.GetComponent<Animator>().SetFloat("Pseed", Mathf.Abs(moveDir.x * moveSpeed + moveDir.y * moveSpeed));
>>>>>>> Stashed changes
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }

    public void Stop()
    {
        rb.velocity = Vector2.zero;
    }
}
