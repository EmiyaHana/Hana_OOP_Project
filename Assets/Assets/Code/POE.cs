using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class POE : Monster
{
    public override int LootReward => 20;

    public void InitializePOE(string name)
    {
        base.Init(name, 200, 20);
    }

    public override void Roar()
    {
        Debug.Log("Rawr!!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attack {target.Name} with thunder smite for {AttackPower} damage!");
    }
}
