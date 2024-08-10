using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class MonsterLv1 : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public Vector2 velocity = new Vector2(0, -1f);

    protected Vector3 pos;
    protected Vector3 pos1;
    protected float a = 0; // Chỉnh sửa cho Monster chạy đi chạy lại qua trục x
    protected float b = 0; // Chỉnh sửa cho Monster chạy đi chạy lại qua trục x

    public List<GameObject> listObjNow;

    public MonsterPrefab1 monsterPrefab1;


    private void Start()
    {
        GameObject obj = GameObject.Find("MonsterPrefab1");
        this.monsterPrefab1 = obj.GetComponent<MonsterPrefab1>();

        this.rbd2 = GetComponent<Rigidbody2D>();
        this.pos = new Vector3(transform.position.x, (transform.position.y - 4), 0);

        this.a = transform.position.x + 2;
        this.b = transform.position.x - 2;

        this.velocity.x = 2f;

        this.listObjNow = new List<GameObject>();

    }

    private void FixedUpdate()
    {
        this.Movenment();
    }

    protected void Movenment()
    {
        
        if (monsterPrefab1.listObj.Count == monsterPrefab1.maxObj)
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
