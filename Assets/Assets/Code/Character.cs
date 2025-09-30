using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public abstract class Character : MonoBehaviour
{
    public Weapon EquippedWeapon {  get; private set; }

    private string name;
    public string Name
    {
        get { return name; }
        set 
        { if (string.IsNullOrEmpty(value)) { name = "Unknown"; }
          else { name = value; }
        }
    }

    public int Health { get; protected set; }
    protected int maxHealth = 200;
    
    public int AttackPower { get; set; }

    public virtual void Init(string newName, int newHP, int newAttackPower)
    {
        Name = newName;
        Health = newHP;
        AttackPower = newAttackPower;
    }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Name : {Name} | HP : {Health} | Atk. Power : {AttackPower}");
    }

    public void TakeDamage(int damageValue)
    {
        Health = Mathf.Clamp(Health - damageValue, 0, maxHealth);
    }

    public abstract void Attack(Character Target);

    public abstract void Attack(Character Target, int bonusDamage);

    public virtual  void Attack(Character Target, Weapon weapon)
    {
        if (weapon != null)
        {
            int damage = AttackPower + weapon.BonusDamage;
            Target.TakeDamage(damage);
            Debug.Log($"{Name} uses {weapon.WeaponName} with bonus {weapon.BonusDamage} | " +
                $"Total Damage : {damage} to {Target.Name}.");
        }
    }

    public abstract void OnDefeated();

    public bool IsAlive() { return Health > 0; }
}
