using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class GameManager : MonoBehaviour
{
    /*private List<Monster> monsters = new List<Monster>();*/
    public Hero hero;
    public List<Monster> monsterPreFabs;

    public Monster currentMonster;

    public List<Monster> monsters = new List<Monster>();

    void Start()
    {
        hero.Init("GMan", 100, 20);
        hero.ShowStat();

        SpawnMonster(MonsterType.POE);
        SpawnMonster(MonsterType.RLCraft);
        SpawnMonster(MonsterType.ROBlox);
        SpawnMonster(MonsterType.Zomboid);

        foreach (var monster in monsters)
        {
            monster.ShowStat();
        }

        currentMonster = monsters[0];

        Debug.Log("Monster has arrived... Battle!");

        currentMonster = monsters[0];

        hero.Attack(currentMonster, 10);
        currentMonster.Attack(hero, 5);
        hero.ShowStat();
        currentMonster.ShowStat();

        /*currentMonster = Instantiate(monsterPreFabs[0]);
        currentMonster.Init("POE", 200, 20, 50);
        monsters.Add(currentMonster);

        currentMonster = Instantiate(monsterPreFabs[1]);
        currentMonster.Init("RLCraft", 80, 5, 15);
        monsters.Add(currentMonster);
        
        currentMonster = Instantiate(monsterPreFabs[2]);
        currentMonster.Init("ROBlox", 100, 15, 25);
        monsters.Add(currentMonster);
        
        currentMonster = Instantiate(monsterPreFabs[3]);
        currentMonster.Init("Zomboid", 75, 10, 10);
        monsters.Add(currentMonster);
        
        foreach (var monster in monsters)
        {
            monster.ShowStat();
        }*/
    }

    public void SpawnMonster(MonsterType monType)
    {
        Monster monstersPreFabs = monsterPreFabs[(int)monType];

        Monster monsterObj = Instantiate(monstersPreFabs);

        monsterObj.Init(monType);

        monsters.Add(monsterObj);
    }
}