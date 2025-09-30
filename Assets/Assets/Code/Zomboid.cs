using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Zomboid : Monster
{
    public override int LootReward => 10;

    public void InitializeZomboid(string name)
    {
        base.Init(name, 75, 10);
    }

    public override void Roar()
    {
        Debug.Log("Lieutenant!!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attack {target.Name} with carnage bites for {AttackPower} damage!");
    }
}
