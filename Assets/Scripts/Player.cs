using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private CharacterStatus baseStatus;

    [SerializeField] private string name;
    [SerializeField] private int level;
    [SerializeField] private long gold;

    private void Awake()
    {
        
    }

    void Start()
    {
        InitStatus();
        InitPlayerInfo();
    }


    //void Update()
    //{
        
    //}

    private void InitStatus()
    {
        baseStatus.attck = 35;
        baseStatus.defence = 40;
        baseStatus.health = 100;
        baseStatus.critical = 25;
    }

    private void InitPlayerInfo()
    {
        name = "Chad";
        level = 10;
        gold = 20000;

        UIManager.instance.txtName.text = name;
        UIManager.instance.txtLevel.text = level.ToString();
        UIManager.instance.txtGold.text = gold.ToString();
    }
}
