using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMonsterOnTrigger1 : OnTrigger
{
    public HpPlayer hpPlayer;
    public List<string> listTag;

    private void Start()
    {
        this.listTag = new List<string>()
        {
            "MonsterLv1",
            "PlayerBullet",
        };
    }

    public override string CheckTag()
    {
        for (int i = 0; i < this.listTag.Count; i++)
        {
            if (this.checkNametag == this.listTag[i])
            {
                this.checkNametag2 = this.listTag[i];
                return this.checkNametag2;
            }
        }

        return null;
    }



    protected override void Damage(int damage)
    {
        GameObject obj = GameObject.Find(this.nameOnTrigger);
        this.hpPlayer = obj.GetComponent<HpPlayer>();
        this.hpPlayer.Receive(damage);
        Destroy(gameObject);
    }
}
