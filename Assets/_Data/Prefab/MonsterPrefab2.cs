using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPrefab2 : CreateObj
{
    private void Reset()
    {
        this.nameObj = "MonsterLv2";
        this.nameObjPosition = "SpawnMonster";
        this.nameObjParent = "MonsterPrefab2";

        this.objPosition = GameObject.Find("SpawnMonster");

        this.maxObj = 2;
        this.listPos = Posi();
    }


    public override void CheckDestroy()
    {
        //Debug.Log("HI");
    }
    protected List<Vector3> Posi()
    {
        List<Vector3> list = new List<Vector3>()
        {
            new Vector3(this.objPosition.transform.position.x + 3, this.objPosition.transform.position.y, 0),
            new Vector3(this.objPosition.transform.position.x - 3, this.objPosition.transform.position.y, 0),
        };

        return list;
    }
}
