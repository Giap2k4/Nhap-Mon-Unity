using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public GameObject obj;
    public string nameOnTrigger = "";
    public List<string> nameTag;
    public string checkNametag = ""; // Khi va chạm thì sẽ biết được checkNameTag = ...
    public string checkNametag2 = ""; // Lớp con điền thông tin vào

    public int dmg = 1;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        this.obj = collision.gameObject;
        this.checkNametag = collision.gameObject.tag;
        this.nameOnTrigger = collision.gameObject.name;
        this.CheckTag();

        if (this.checkNametag == this.checkNametag2)
        {
            return;
        }

        if (obj != null)
        {
            Damage(this.dmg);
        }
    }

    public virtual string CheckTag()
    {
        return this.checkNametag2;
    }

    protected virtual void Damage(int damage)
    {
        
    }

}
