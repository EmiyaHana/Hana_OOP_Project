using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set 
        { if (string.IsNullOrEmpty(value)) { name = "Unknown Hero"; }
          else { name = value; }
        }
    }

    private int health;
    public int Health 
    {
        get { return health; }
        set { if (value >= 0) health = value;
            else health = 0;
        }
    }

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
        Health -= damageValue;
    }

    public void Attack(Monster target)
    {
        Debug.Log($"(Name) attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public bool IsAlive() { return Health > 0; }
}
