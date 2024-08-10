using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBullet : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public Vector2 velocity;
    public float speed = 15f;
    void Start()
    {
        this.rbd2 = GetComponent<Rigidbody2D>();
        Invoke("Destroy", 0.64f);
    }

    private void FixedUpdate()
    {
        this.BulletMove();
    }

    protected void BulletMove()
    {
        this.velocity.y = this.speed;
        this.rbd2.MovePosition(this.rbd2.position + velocity * Time.fixedDeltaTime);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }


}
