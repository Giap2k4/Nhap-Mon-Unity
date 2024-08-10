using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterBulletPrefab : CreateObj
{
    public MonsterPrefab1 monsterPrefab1;
    public List<string> listName;
    public List<GameObject> listMons;
    protected int b = 0;
    public MonsterLv1 mon;

    private void Reset()
    {
        this.nameObj = "MonsterBullet";
        this.nameObjParent = "MonsterBulletPrefab";

        this.maxObj = 20;
        this.timeCreate = 0.5f;

    }

    private void Start()
    {
        GameObject obj = GameObject.Find("MonsterPrefab1");
        this.monsterPrefab1 = obj.GetComponent<MonsterPrefab1>();
        this.listMons = new();
    }


    private void Update()
    {
        this.Create();
        this.CheckDestroy();

    }

    public override void Create()
    {
        if (this.monsterPrefab1.listObj.Count > 0)
        {
            this.listName = new();
            this.GetNameObjPosition();

            if ((this.b + 1) > this.listName.Count)
            {
                this.b = 0;
                return;
            }



            this.objPosition = GameObject.Find(this.listName[b]);


            if (this.listObj.Count == this.maxObj) return;

            this.speed += Time.deltaTime;
            if (this.speed < this.timeCreate) return;
            this.speed = 0;

            GameObject obj = Instantiate(this.obj);
            obj.SetActive(true);
            obj.transform.position = this.objPosition.transform.position;
            obj.name = this.obj.name;
            obj.transform.parent = this.objParent.transform;


            this.listObj.Add(obj);

            this.listName.Clear();

            b++;
        }
    }

    protected void GetNameObjPosition()
    {
        foreach (Transform child in monsterPrefab1.transform)
        {
            this.listName.Add(child.name);
        }
    }

}
