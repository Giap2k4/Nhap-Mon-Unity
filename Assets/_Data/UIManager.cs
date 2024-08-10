using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;
    public GameObject gameManager;

    void Awake()
    {
        UIManager.instance = this;

        this.gameManager = GameObject.Find("bnStart");
        this.gameManager.SetActive(false);
    }

    
}
