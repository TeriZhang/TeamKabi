using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{
    public Vector2 moveDir;
    public Rigidbody2D rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
        float moveX = Input.GetAxisRaw("Horizontal") ;
        float moveY = Input.GetAxisRaw("Vertical") ;

        moveDir = new Vector2(moveX, moveY).normalized;
    }
    void move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
