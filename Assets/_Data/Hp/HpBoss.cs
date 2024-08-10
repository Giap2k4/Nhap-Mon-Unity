using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBoss : HpObj
{
    private void Reset()
    {
        this.hp = 50;
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
