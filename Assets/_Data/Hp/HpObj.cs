using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpObj : MonoBehaviour
{
    public int hp = 20;

    public virtual void Receive(int damage)
    {
        this.hp -= damage;
    }

    public bool IsDead()
    {
        return this.hp <= 0;
    }

}
