using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public Vector2 velocity;

    public float pressHorizontal = 0;
    protected float speed = 15f;

    private void Awake()
    {
        this.rbd2 = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        this.Movement();
    }

    protected void Movement()
    {

        this.velocity.x = this.pressHorizontal * this.speed;

        if(transform.position.x <= -8)
        {
            this.velocity.x = 0;
            if (this.pressHorizontal > 0) this.velocity.x = this.speed; 
        }
        
        if(transform.position.x >= 8)
        {
            this.velocity.x = 0;
            if (this.pressHorizontal < 0) this.velocity.x = -1 * this.speed; 
        }

        this.rbd2.MovePosition(this.rbd2.position + this.velocity * Time.fixedDeltaTime);
    }
}
