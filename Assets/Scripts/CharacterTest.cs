using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

public class CharacterTest : MonoBehaviour
{
    void Start()
    {
        Character soldier = new Soldier();
        Character officer = new Officer("Jane", 100, new Position(2, 2, 2));

        Character[] characters = new Character[] { soldier, officer };

        foreach (Character character in characters)
        {
            character.DisplayInfo();
        }

        Debug.Log($"Before attack: {soldier.name}'s Health: {soldier.Health}");
        officer.Attack(20, soldier);
        Debug.Log($"After attack: {soldier.name}'s Health: {soldier.Health}");
    }


}
