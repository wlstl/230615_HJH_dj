using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyObject : MonoBehaviour { 


    [SerializeField] private Sprite[] enemyimg;
    [SerializeField] private Slider hpbar;
    Enemy enemy =null;
 
    public void SetEnemy(Enemy e)
    {
        this.enemy = e;
        hpbar.maxValue = enemy.Hp;
            hpbar.value = enemy.Hp;
    }

    private void Start()
    {
        SetEnemy(new Enemy(Enemy.EnemyType.Basic, 100, 10, 1.5f));
       }
    public void Update()
    {


        MoveEnemy();
     
    }
    private void MoveEnemy()
    {
        if (this.transform.position.y <= -2) return;
        transform.position -=  new Vector3(0, enemy.Speed * Time.deltaTime, 0) * 1;
    }

}


