using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayerOnTrigger : OnTrigger
{
    public HpMonsterLv1 hpMonsterLv1;

    public HpMonsterLv2 hpMonsterLv2;

    public HpBoss HpBoss;

    public List<string> listTag; // Những thẻ Tag sẽ return

    private void Start()
    {
        this.listTag = new List<string>()
        {
            "Player",
            "MonsterLv1Bulet",
            "MonsterLv2Bullet"
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
        if (this.checkNametag == "MonsterLv1")
        {
            GameObject obj = GameObject.Find(this.nameOnTrigger);
            this.hpMonsterLv1 = obj.GetComponent<HpMonsterLv1>();
            this.hpMonsterLv1.Receive(damage);
            Destroy(gameObject);
            EffectManager.instance.Effect("PlayerBullet", transform.position, transform.rotation);
        }

        if (this.checkNametag == "MonsterLv2")
        {
            GameObject obj = GameObject.Find(this.nameOnTrigger);
            this.hpMonsterLv2 = obj.GetComponent<HpMonsterLv2>();
            this.hpMonsterLv2.Receive(damage);
            Destroy(gameObject);
            EffectManager.instance.Effect("PlayerBullet", transform.position, transform.rotation);
        }

        if (this.checkNametag == "Boss")
        {
            GameObject obj = GameObject.Find(this.nameOnTrigger);
            this.HpBoss = obj.GetComponent<HpBoss>();
            this.HpBoss.Receive(damage);
            Debug.Log("Check");
            Destroy(gameObject);
            EffectManager.instance.Effect("PlayerBullet", transform.position, transform.rotation);
        }

    }

}
