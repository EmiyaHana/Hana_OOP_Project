using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GameManager : MonoBehaviour
{
    public Hero hero;
    public List<Monster> monsterPreFabs;
    public List<Weapon> weaponPreFabs;

    public Monster currentMonster;

    public List<Monster> monsters = new List<Monster>();
    public List<Weapon> weapons = new List<Weapon>();

    void Start()
    {
        Weapon Sword = Instantiate(weaponPreFabs[0], new Vector3(-3, -1, 0), Quaternion.identity);
        Weapon Thunderbolt = Instantiate(weaponPreFabs[1], new Vector3(-2, -1, 0), Quaternion.identity);
        Weapon Mace = Instantiate(weaponPreFabs[2], new Vector3(-1, -1, 0), Quaternion.identity);
        Weapon Grimmoire = Instantiate(weaponPreFabs[3], new Vector3(0, -1, 0), Quaternion.identity);
        Weapon Jaws = Instantiate(weaponPreFabs[4], new Vector3(1, -1, 0), Quaternion.identity);

        Sword.InitializeWeapon("GBlade", 10);
        Thunderbolt.InitializeWeapon("SlamDun", 10);
        Mace.InitializeWeapon("Real-Life Pain", 2);
        Grimmoire.InitializeWeapon("BrainRot", 7);
        Jaws.InitializeWeapon("RRah!", 5);

        hero.Init("GMan", 100, 20);
        hero.ShowStat();

        Monster POEobj = Instantiate(monsterPreFabs[0]);
        POE POE1 = POEobj.GetComponent<POE>();
        if (POE1 != null)
        {
            POE1.InitializePOE("POE");
        }
        monsters.Add(POEobj);

        Monster RLCraftobj = Instantiate(monsterPreFabs[1]);
        RLCraft RLCraft1 = RLCraftobj.GetComponent<RLCraft>();
        if (RLCraft1 != null)
        {
            RLCraft1.InitializeRLCraft("RLCraft");
        }
        monsters.Add(RLCraftobj);

        Monster ROBloxobj = Instantiate(monsterPreFabs[2]);
        ROBlox ROBlox1 = ROBloxobj.GetComponent<ROBlox>();
        if (ROBlox1 != null)
        {
            ROBlox1.InitializeROBlox("ROBlox");
        }
        monsters.Add(ROBloxobj);

        Monster Zomboidobj = Instantiate(monsterPreFabs[3]);
        Zomboid Zomboid1 = Zomboidobj.GetComponent<Zomboid>();
        if (Zomboid1 != null)
        {
            Zomboid1.InitializeZomboid("Zomboid");
        }
        monsters.Add(Zomboidobj);

        //SpawnMonster(MonsterType.POE);
        //SpawnMonster(MonsterType.RLCraft);
        //SpawnMonster(MonsterType.ROBlox);
        //SpawnMonster(MonsterType.Zomboid);

        foreach (var monster in monsters)
        {
            monster.ShowStat();
            monster.Roar();
        }

        Debug.Log("Monster has arrived... Battle!");
        Debug.Log("Ready... Fight!");

        hero.EquipWeapon(Sword);
        POE1.EquipWeapon(Thunderbolt);
        RLCraft1.EquipWeapon(Mace);
        ROBlox1.EquipWeapon(Grimmoire);
        Zomboid1.EquipWeapon(Jaws);

        currentMonster = monsters[0];

        hero.Attack(currentMonster, hero.EquippedWeapon);
        currentMonster.Attack(hero, currentMonster.EquippedWeapon);
        hero.ShowStat();
        currentMonster.ShowStat();
    }
}