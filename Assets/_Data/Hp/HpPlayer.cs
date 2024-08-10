using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : HpObj
{
    private void Reset()
    {
        this.hp = 20;
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if (this.IsDead())
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
            UIManager.instance.gameManager.SetActive(true);

        }
    }
}
