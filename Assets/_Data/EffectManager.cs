using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    static public EffectManager instance;   
    public List<GameObject> effect;

    private void Awake()
    {
        EffectManager.instance = this;

        this.effect = new List<GameObject>();
        this.loadEffect();
    }

    protected void loadEffect()
    {
        foreach (Transform a in transform)
        {
            if (a != null)
            {
                this.effect.Add(a.gameObject);
                a.gameObject.SetActive(false);
                
            }
        }
    }

    public void Effect(string nameEffect, Vector3 pos, Quaternion rot)
    {
        GameObject eff = this.GetNameEffect(nameEffect);
        GameObject obj = Instantiate(eff, pos, rot);
        obj.SetActive(true);
        obj.transform.parent = transform;

    }

    public GameObject GetNameEffect(string nameEffect)
    {
        foreach (GameObject a in this.effect)
        {
            if (nameEffect == a.name)
            {
                return a;
            }
        }

        return null;
    }
}
