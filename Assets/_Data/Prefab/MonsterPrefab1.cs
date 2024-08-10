using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPrefab1 : CreateObj
{

    private void Reset()
    {
        this.nameObj = "MonsterLv1";
        this.nameObjPosition = "SpawnMonster";
        this.nameObjParent = "MonsterPrefab1";

        this.objPosition = GameObject.Find("SpawnMonster");

        this.maxObj = 3;
        this.listPos = Posi();
    }


    private void Update()
    {
        this.Create();
        this.CheckDestroy();

    }

    public override void CheckDestroy()
    {
        //Debug.Log("HI");
    }
    protected List<Vector3> Posi()
    {
        List<Vector3> list = new List<Vector3>()
        {
            this.objPosition.transform.position,
            new Vector3(this.objPosition.transform.position.x + 6, this.objPosition.transform.position.y, 0),
            new Vector3(this.objPosition.transform.position.x - 6, this.objPosition.transform.position.y, 0),
        };

        return list;
    }

}
