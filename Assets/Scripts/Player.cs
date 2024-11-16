using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name, int health) : base(name, health) { }

    public void Heal(int amount)
    {
        int currentHealth = GetHealth(); 
        currentHealth += amount;
        SetHealth(currentHealth);
        Debug.Log($"{GetName()} healed by {amount}. Current health: {GetHealth()}");
    }

}
