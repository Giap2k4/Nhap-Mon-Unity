using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBossOnTrigger : OnTrigger
{
    public HpPlayer hpPlayer;
    public List<string> listTag;

    private void Reset()
    {
        this.dmg = 3;
    }
    private void Start()
    {
        this.listTag = new List<string>()
        {
            "Boss",
            "PlayerBullet",
            "BossBullet"
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

        return "";
    }



    protected override void Damage(int damage)
    {
        Debug.Log("test: "+checkNametag2);
        GameObject obj = GameObject.Find(this.nameOnTrigger);
        this.hpPlayer = obj.GetComponent<HpPlayer>();
        this.hpPlayer.Receive(damage);
        Destroy(gameObject);
    }
}
