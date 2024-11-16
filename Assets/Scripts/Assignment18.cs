using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        public float X, Y, Z;

        public Position(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void printPosition()
        {
            Debug.Log($"X: {X}, Y: {Y}, Z: {Z}");
        }
    }

    public class Character
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set
            {
                if (value > 100)
                    health = 100;
                else if (value < 0)
                    health = 0;
                else
                    health = value;
            }
        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.Health = health;
            this.position = position;
        }

        public Character() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}, Health: {Health}");
            position.printPosition();
        }

        public void Attack(int damage, Character target, string attackType = null)
        {
            target.Health -= damage;

            if (!string.IsNullOrEmpty(attackType))
            {
                Debug.Log($"{name} performed {attackType} attack on {target.name}");
            }
        }

    }

    public class Soldier : Character
    {
        public Soldier() : base() { }
        public Soldier(string name, int health, Position position) : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }

    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
