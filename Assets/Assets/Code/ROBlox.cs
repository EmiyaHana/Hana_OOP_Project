using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ROBlox : Monster
{
    public override int LootReward => 15;

    public void InitializeROBlox(string name)
    {
        base.Init(name, 100, 15);
    }

    public override void Roar()
    {
        Debug.Log("Roleplay!!");
    }

    public override void Attack(Character target)
    {
        base.Attack(target);
        Debug.Log($"{Name} attack {target.Name} with terrific hypnosis for {AttackPower} damage!");
    }
}
