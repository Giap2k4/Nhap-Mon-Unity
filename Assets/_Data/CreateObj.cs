using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    static public CreateObj instance;

    public GameObject obj; // Tạo ra từ GameObject nào
    public GameObject objPosition; // VỊ trí
    public GameObject objParent; // Nằm trong gameObject nào
    public List<GameObject> listObj;
    public List<Vector3> listPos;

    public string nameObj = "";
    protected string nameObjPosition = "";
    public string nameObjParent = "";

    protected float speed = 0;
    public float timeCreate = 0.2f;

    public int a = 0;
    public int maxObj = 0;

    private void Awake()
    {
        CreateObj.instance = this;

        this.obj = GameObject.Find(nameObj);
        this.obj.SetActive(false);
        this.objPosition = GameObject.Find(nameObjPosition);
        this.objParent = GameObject.Find(nameObjParent);

        this.listObj = new();
    }



    public virtual void Create()
    {
        
        if (this.listObj.Count == this.maxObj) return;

        this.speed += Time.deltaTime;
        if (this.speed < this.timeCreate) return;
        this.speed = 0;

        GameObject obj = Instantiate(this.obj);
        obj.SetActive(true);
        obj.transform.position = this.listPos[a];
        obj.name = this.obj.name + this.listObj.Count;
        obj.transform.parent = this.objParent.transform;

        this.listObj.Add(obj);

        a++;
    }

    public virtual void CheckDestroy()
    {
        GameObject obj;

        for (int i = 0; i < this.listObj.Count; i++)
        {
            obj = this.listObj[i];
            if (obj == null) this.listObj.RemoveAt(i);
        }
    }

}
