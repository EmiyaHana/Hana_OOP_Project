using System.Collections.Generic;
using UnityEngine;

public class Monster : Character
{
    private int lootReward;
    public int LootReward
    { 
        get { return lootReward; }
        set 
        { 
            if (value < 0) {  lootReward = 0; } 
            else { lootReward = value; }
        } 
    }
    
    private bool defeated = false;

    public void Init(string newName, int newHP, int newAttackPower, int newLootReward)
    {
        base.Init(newName, newHP, newAttackPower);
        LootReward = newLootReward;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Lootings : {LootReward}");
    }

    public int DropReward()
    {
        return LootReward;
    }
}