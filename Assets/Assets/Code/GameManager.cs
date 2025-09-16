using System.Collections.Generic;
using UnityEngine;

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

        currentMonster = Instantiate(monsterPreFabs[0]);
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
        }

        /*Hero G = new Hero("GMan", 100, 20);
        
        Monster Mon1 = new Monster("RLCraft", 80, 5, 15);
        Monster Mon2 = new Monster("Zomboid", 75, 10, 10);
        Monster Mon3 = new Monster("ROBlox", 100, 15, 25);

        monsters.Add(Mon1);
        monsters.Add(Mon2);
        monsters.Add(Mon3);
        monsters.Add(new Monster("POE", 200, 20, 50));

        G.ShowStat();
        
        foreach (var m in monsters)
        {
            m.ShowStat();
        }

        Mon1.ShowStat();

        G.Attack(Mon1);

        Mon1.ShowStat();

        G.ShowStat();

        Mon1.Attack(G);

        G.ShowStat();*/
    }
}