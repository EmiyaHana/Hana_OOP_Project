using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Weapon : MonoBehaviour
{
    public string WeaponName {  get; private set; }

    public int BonusDamage { get; private set; }
    public void InitializeWeapon(string weaponName, int weaponDamage)
    {
        WeaponName = weaponName;
        BonusDamage = weaponDamage;
    }

    public void ShowStat()
    {
        Debug.Log($"Name : {WeaponName} | Damage : {BonusDamage}");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
