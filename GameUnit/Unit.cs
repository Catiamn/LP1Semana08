using System;
using System.Reflection.Metadata.Ecma335;
using Humanizer;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }


        //manda os valores para numerais romanos com a ajuda de Humanizer
        public void Move() => Console.WriteLine(movement.ToRoman());

        public override string ToString()
        {
            return $"SettlerUnit: HP={Health} COST={Cost:f2}";
        }

    }
}
