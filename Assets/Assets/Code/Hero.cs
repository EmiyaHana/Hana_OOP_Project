using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Hero : Character
{
    private int maxGold = 999;
    public int Gold { get; private set; }

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

    public void Heal(int healValue)
    {
        Health = Mathf.Clamp(Health + healValue, 0, maxHealth);
        Debug.Log($"{Name} heals {healValue} HP! Health : {Health}");
    }

    public override void Attack(Character target)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} slashes {target.Name} for {AttackPower} damage!");
    }

    public override void Attack(Character target, int bonusDamage)
    {
        //base.Attack(target);
        Debug.Log($"{Name} smites {target.Name} for {AttackPower + bonusDamage} damage!");
        target.TakeDamage(AttackPower + bonusDamage);
        Debug.Log($"{Name} take {AttackPower + bonusDamage} damage!");
    }

    /*public override void Ondefeated()
    {

    }*/

    public void EarnGold(int amount)
    {
        if (amount > 0)
        {
            Gold = Mathf.Clamp(Gold + amount, 0, maxGold);
            Debug.Log($"Monster has been defeated! {Name} earns {amount} Golds!");
        }
    }
}