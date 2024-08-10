using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public MonsterPrefab1 monsterPrefab1;
    public MonsterPrefab2 monsterPrefab2;
    public BossPrefab bossPrefab;

    protected int b = 0;
    private void Awake()
    {
        GameObject obj = GameObject.Find("MonsterPrefab1");
        this.monsterPrefab1 = obj.GetComponent<MonsterPrefab1>();

        GameObject obj2 = GameObject.Find("MonsterPrefab2");
        this.monsterPrefab2 = obj2.GetComponent<MonsterPrefab2>();

        GameObject obj3 = GameObject.Find("BossPrefab");
        this.bossPrefab = obj3.GetComponent<BossPrefab>();
    }

    private void Update()
    {
        this.CheckLevel();
    }

    protected void CheckLevel()
    {
        int a = 0;
        foreach (GameObject child in this.monsterPrefab1.listObj)
        {

            if (child == null)
            {
                a++;
                if (a == this.monsterPrefab1.maxObj)
                {
                    this.monsterPrefab2.Create();
                    this.monsterPrefab2.CheckDestroy();
                    this.checkBoss();
                }
                
            }
        }
    }

    protected void checkBoss()
    {
        int a = 0;
        foreach (GameObject child in this.monsterPrefab2.listObj)
        {

            if (child == null)
            {
                a++;
                if (a == this.monsterPrefab2.maxObj)
                {
                    this.bossPrefab.Create();
                    this.bossPrefab.CheckDestroy();

                }

            }
        }
    }


} 
