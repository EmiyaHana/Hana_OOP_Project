using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class RLCraft : Monster
{
    public override int LootReward => 5;

    public void InitializeRLCraft(string name)
    {
        base.Init(name, 80, 5);
    }

    public override void Roar()
    {
        Debug.Log("Repa!!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attack {target.Name} with clashing bone for {AttackPower} damage!");
    }
}
