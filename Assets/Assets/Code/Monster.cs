using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

/*public enum MonsterType
{
    POE,
    RLCraft,
    ROBlox,
    Zomboid
}*/

public abstract class Monster : Character
{
    public abstract int LootReward { get;  }

    //public MonsterType monType { get; private set; }

    private bool defeated = false;

    /*public void Init(MonsterType monType)
    {
        switch (monType)
        {
            case MonsterType.POE:
                base.Init("POE", 200, 20);
                LootReward = 50;
                break;
            case MonsterType.RLCraft:
                base.Init("RLCraft", 80, 5);
                LootReward = 15;
                break;
            case MonsterType.ROBlox:
                base.Init("ROBlox", 100, 15);
                LootReward = 25;
                break;
            case MonsterType.Zomboid:
                base.Init("Zomboid", 75, 10);
                LootReward = 10;
                break;
        }
    }*/

    public abstract void Roar();

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Lootings : {LootReward}");
    }

    public override void Attack(Character target)
    {
        //base.Attack(target);
        Debug.Log($"{Name} smashes {target.Name} for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        //base.Attack(target);
        Debug.Log($"{Name} clashes {target.Name} for {(AttackPower * 2) + (bonusDamage / 2)} damage!");
        target.TakeDamage((AttackPower * 2) + (bonusDamage / 2));
        Debug.Log($"{Name} take {(AttackPower * 2) + (bonusDamage / 2)} damage!");
    }

    public override void OnDefeated()
    {
        Debug.Log($"{name} has been defeated.");
    }

    public int DropReward()
    {
        return LootReward;
    }
}