using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletPrefab : CreateObj
{
    public BossPrefab bossPrefab;
    public BossBullet bossBullet;

    public List<string> listName;
    public List<GameObject> listMons;
    protected int b = 0;
    public int c = 0;

    private void Reset()
    {
        this.nameObj = "BossBullet";
        this.nameObjParent = "BossBulletPrefab";

        this.maxObj = 30;
        this.timeCreate = 0.8f;

    }

    private void Start()
    {
        GameObject obj = GameObject.Find("BossPrefab");
        this.bossPrefab = obj.GetComponent<BossPrefab>();

        this.listMons = new();
    }


    private void Update()
    {
        this.Create();
        this.CheckDestroy();

    }

    public override void Create()
    {

        if (this.bossPrefab.listObj.Count > 0)
        {
            this.listName = new();
            this.GetNameObjPosition();

            if ((this.b + 1) > this.listName.Count)
            {
                this.b = 0;
                return;
            }

            this.objPosition = GameObject.Find(this.listName[b]);


            if (this.listObj.Count >= this.maxObj) return;

            this.speed += Time.deltaTime;
            if (this.speed < this.timeCreate) return;
            this.speed = 0;

            GameObject obj = Instantiate(this.obj);
            obj.SetActive(true);
            obj.transform.position = this.objPosition.transform.position;
            obj.name = this.obj.name;
            obj.transform.parent = this.objParent.transform;
            BossBullet bullet1 = obj.GetComponent<BossBullet>();
            bullet1.velocity = new Vector2(0, bullet1.speed);
            this.listObj.Add(obj);

            GameObject obj2 = Instantiate(this.obj);
            obj2.SetActive(true);
            obj2.transform.position = this.objPosition.transform.position;
            obj2.name = this.obj.name;
            obj2.transform.parent = this.objParent.transform;
            BossBullet bullet2 = obj2.GetComponent<BossBullet>();
            bullet2.velocity = new Vector2(5, bullet2.speed);
            this.listObj.Add(obj2);


            GameObject obj3 = Instantiate(this.obj);

            obj3.SetActive(true);
            obj3.transform.position = this.objPosition.transform.position;
            obj3.name = this.obj.name;
            obj3.transform.parent = this.objParent.transform;
            this.listObj.Add(obj3);
            BossBullet bullet3 = obj3.GetComponent<BossBullet>();
            bullet3.velocity = new Vector2(-5f, bullet3.speed);

            this.listName.Clear();

            b++;
        }
    }

    protected void GetNameObjPosition()
    {
        foreach (Transform child in bossPrefab.transform)
        {
            this.listName.Add(child.name);
        }
    }
}
