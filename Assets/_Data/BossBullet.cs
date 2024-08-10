using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BossBullet : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public Vector2 velocity;
    public float speed = -5f;
    public float speedX = 0;
    public List<float> listSpeedX;

    public BossBulletPrefab bossBulletPrefab;
    void Start()
    {
        this.rbd2 = GetComponent<Rigidbody2D>();
        this.listSpeedX = new List<float>()
        {
            2f, -2f
        };

        GameObject obj = GameObject.Find("BossBulletPrefab");
        this.bossBulletPrefab = obj.GetComponent<BossBulletPrefab>();

        Invoke("Destroy", 2f);
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
