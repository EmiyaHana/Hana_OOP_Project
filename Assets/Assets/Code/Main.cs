using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private List<Monster> monsters = new List<Monster>();
    void Start()
    {
        Hero G = new Hero("GMan", 100, 20);
        
        Monster Mon1 = new Monster("RLCraft", 80, 5, 15);
        Monster Mon2 = new Monster("Zomboid", 75, 10, 10);
        Monster Mon3 = new Monster("ROBlox", 100, 15, 25);

        monsters.Add(Mon1);
        monsters.Add(Mon2);
        monsters.Add(Mon3);
        monsters.Add(new Monster("POE", 200, 20, 50));

        G.ShowStat();
        
        /*Debug.Log($"Hero : {G.Name} | HP : {G.Health} | Gold : {G.Gold}");

        Debug.Log($"Monster : {Mon1.Name} | HP : {Mon1.Health}");
        Debug.Log($"Monster : {Mon2.Name} | HP : {Mon2.Health}");
        Debug.Log($"Monster : {Mon3.Name} | HP : {Mon3.Health}");*/
        foreach (var m in monsters)
        {
            /*Debug.Log($"Monster : {m.Name} | HP : {m.Health}");*/
            m.ShowStat();
        }

        Mon1.ShowStat();

        G.Attack(Mon1);

        Mon1.ShowStat();

        G.ShowStat();

        Mon1.Attack(G);

        G.ShowStat();
    }
}