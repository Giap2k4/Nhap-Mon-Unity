using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MonsterBulletLv2 : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public Vector2 velocity;
    public float speed = -7f;
    void Start()
    {
        this.rbd2 = GetComponent<Rigidbody2D>();
        Invoke("Destroy", 3f);
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
