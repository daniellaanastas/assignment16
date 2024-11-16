using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) { }
    public void Attack(Character target, int damage)
    {
        int currentHealth = target.GetHealth(); 
        currentHealth -= damage; 
        target.SetHealth(currentHealth); 
        Debug.Log($"{GetName()} attacked {target.GetName()} for {damage} damage. {target.GetName()}'s current health: {target.GetHealth()}");
    }
}

