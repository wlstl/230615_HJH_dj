using System;
public class Enemy {
    private int hp;
    private string name;

    public Enemy(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

    public void GetEnemeyInfo()
    {
        UnityEngine.Debug.Log($"name : {this.name} attack : {this.hp}");
    }
}
