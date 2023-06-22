using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{


    int a;

    int[] arrayNumber = new int[10];

    Enemy[] enemyList = new Enemy[10];

    List<int> listNumber = new List<int>();
    List<Enemy> eList = new List<Enemy>();

    void Start()
    {
        eList[0] = new Enemy("name", 10);

        eList.Add(new Enemy("name", 10));

        Enemy e = new Enemy("test", 1);

        eList[0] = e;


        for(int i =0; i < enemyList.Length; i++) 
        { 
        
        
        }


        
        Enemy e1 = new Enemy("elf , 10");
        Enemy e2 = new Enemy("dragon , 100");

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();
    }
}
