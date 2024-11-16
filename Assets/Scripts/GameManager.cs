using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player = new Player("Subhi", 90);
        Enemy enemy = new Enemy("Zarifeh", 80);

        Debug.Log($"Player: {player.GetName()}, Health: {player.GetHealth()}");
        Debug.Log($"Enemy: {enemy.GetName()}, Health: {enemy.GetHealth()}");

        player.Heal(10);
        enemy.Attack(player, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
