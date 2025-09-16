using System.Collections.Generic;
using UnityEngine;

public class Hero : Character
{
    private int gold;
    public int Gold
    { 
        get { return gold; }
        set 
        {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }

    public override void Init(string newName, int newHP, int newAttackPower)
    {
        base.Init(newName, newHP, newAttackPower);
        Gold = 10;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Gold : {Gold}");
    }

    public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold += amount;
        }
    }
}