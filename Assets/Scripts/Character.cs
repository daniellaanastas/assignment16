using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{

    string Name;
    int Health;

    public Character()
    {
    }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public int GetHealth()
    {
        return Health;
    }

    public void SetHealth(int health)
    {
        if (health > 100)
            Health = 100;
        else if (health < 0)
            Health = 0;
        else
            Health = health;
    }

}
