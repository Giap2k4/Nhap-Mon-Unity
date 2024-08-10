using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletPrefab : CreateObj
{
    private void Start()
    {
        Invoke("Create", 1f);
    }

    private void Reset()
    {
        this.nameObj = "PlayerBullet";
        this.nameObjParent = "PlayerBulletPrefab";
        //this.objPosition = null;
        this.maxObj = 30;
        

        this.objPosition = GameObject.Find("Player");
        
        this.a = 0;
    }


    private void Update()
    {
        this.Create();
        this.CheckDestroy();

    }

    public override void Create()
    {
        this.objPosition = GameObject.Find("Player");

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

    }

}
