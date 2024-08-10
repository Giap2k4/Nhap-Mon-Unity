using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPrefab : CreateObj
{
    private void Reset()
    {
        this.nameObj = "Boss";
        this.nameObjPosition = "SpawnMonster";
        this.nameObjParent = "BossPrefab";

        this.objPosition = GameObject.Find("SpawnMonster");

        this.maxObj = 1;
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
            this.objPosition.transform.position
        };

        return list;
    }
}
