using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Timeline;

public class Character : MonoBehaviour
{
    private static int attack = 6;
    private static int defense = 5;
    private static int speed = 4;
    private static int health = 5;
    private static int recovery = 4;
    private string fighterType = "Swordsman";
    private List<int>[,,,,] playerStats = new List<int>[attack, defense, speed, health, recovery];

    private void mainMethod()
    {
        
    }

}
