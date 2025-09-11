using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknown Monster"; }
            else { name = value; }
        }
    }

    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }

    public int AttackPower { get; private set; }

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

    public Monster(string newName, int newHP, int newAttackPower, int newLootReward)
    {
        Name = newName;
        Health = newHP;
        AttackPower = newAttackPower;
        LootReward = newLootReward;
    }

    public void ShowStat()
    {
        Debug.Log($"Monster : {Name} | HP : {Health} | Attack Power : {AttackPower} | Loot Reward : {LootReward}");
    }

    public void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"Player Take {damageValue} Damage");
    }

    public void Attack(Hero target)
    {
        Debug.Log($"(Name) attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive() { return health > 0; }

    public int DropReward()
    {
        return LootReward;
    }
}