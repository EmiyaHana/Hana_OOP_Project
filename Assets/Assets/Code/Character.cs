using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public abstract class Character : MonoBehaviour
{
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

    /*private int health;
    public int Health 
    {
        get { return health; }
        set { if (value >= 0) health = value;
            else health = 0;
        }
    }*/
    
    public int AttackPower { get; set; }

    public virtual void Init(string newName, int newHP, int newAttackPower)
    {
        Name = newName;
        Health = newHP;
        AttackPower = newAttackPower;
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Name : {Name} | HP : {Health} | Atk. Power : {AttackPower}");
    }

    public void TakeDamage(int damageValue)
    {
        /*Health -= damageValue;*/

        Health = Mathf.Clamp(Health - damageValue, 0, maxHealth);
        /*if (Health < 0) Health = 0;
        else if (Health >= maxHealth) Health = maxHealth;*/
    }

    public abstract void Attack(Character Target);

    public abstract void Attack(Character Target, int bonusDamage);

    //public abstract OnDefeated();

    /*public virtual void Attack(Character target)
    {
        target.TakeDamage(AttackPower);
    }*/

    public bool IsAlive() { return Health > 0; }
}
