using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpMonsterLv1 : HpObj
{
    private void Reset()
    {
        this.hp = 5;
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
