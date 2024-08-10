using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpMonsterLv2 : HpObj
{
    private void Reset()
    {
        this.hp = 10;
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            Destroy(gameObject);
            EffectManager.instance.Effect("MonsterDie", transform.position, transform.rotation);
        }
    }
}
