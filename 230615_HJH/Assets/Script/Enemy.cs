using System;

public class Enemy
{
    public enum EnemyType
    {
        Basic = 0,
        Range,
    }

    private EnemyType enemyType;
    private float speed;
    private int atk;
    private string name;
    private int hp;


    public Enemy(EnemyType type , int atk, float speed, int hp)
    {
        this.enemyType = type;
        this.hp = hp;
        this.atk = atk;
        this.speed = speed;
    }


    public int Hp
    {
        get { return this.hp;  }
    }

    public int Atk
    {
        get { return this.atk; }
    }
    public float Speed
    {
        get { return this.speed; }
    }
    public bool Hit(int dmg)
    {
        if (this.hp - dmg <= 0) return false;
        this.hp -= dmg;

        return true;    

    }


}