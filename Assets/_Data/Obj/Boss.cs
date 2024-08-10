using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Boss : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public Vector2 velocity = new Vector2(0, -1f);

    protected Vector3 pos;
    protected Vector3 pos1;
    protected float a = 0; // Chỉnh sửa cho Monster chạy đi chạy lại qua trục x
    protected float b = 0; // Chỉnh sửa cho Monster chạy đi chạy lại qua trục x

    public List<GameObject> listObjNow;

    public BossPrefab bossPrefab;


    private void Start()
    {
        GameObject obj = GameObject.Find("BossPrefab");
        this.bossPrefab = obj.GetComponent<BossPrefab>();

        this.rbd2 = GetComponent<Rigidbody2D>();
        this.pos = new Vector3(transform.position.x, (transform.position.y - 3), 0);

        this.a = transform.position.x + 2;
        this.b = transform.position.x - 2;

        this.velocity.x = 2.5f;

        this.listObjNow = new List<GameObject>();

    }

    private void FixedUpdate()
    {
        this.Movenment();
    }

    protected void Movenment()
    {

        if (bossPrefab.listObj.Count == bossPrefab.maxObj)
        {
            this.velocity.y = -13f;

            if (transform.position.y <= this.pos.y)
            {
                this.velocity.y = 0;
            }

            if (transform.position.x >= a)
            {
                this.velocity.x = -2.5f;
            }

            if (transform.position.x <= b)
            {
                this.velocity.x = 2.5f;
            }

            this.rbd2.MovePosition(this.rbd2.position + this.velocity * Time.fixedDeltaTime);
        }
    }
}
