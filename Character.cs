using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Task1
{
    //Task 1.1 - Part 1/3
    //Base class for all game characters
    public abstract class Character
    {
        protected string name;
        protected int hitPoints;  //health, resilience or durability, how much damange a character can sustain before dying, damanage reduces hitpoints
        protected int strenght;   //base level of damage a character can do to another character in one attack/hit
        protected int defence;    //how much damage a character can sustain from one attack/hit without being affected 

        //public getter for name
        public string getName()
        {
            return name;
        }
        //public getts for hitPoints
        public int getHitPoints()
        { 
            return hitPoints; 
        }


        //Step 4 - Default constructor not provided for Character class as it is abstract, all properties set by constructors of derived classes.
        
        //Step 3 - each character type has its own implementation
        public abstract int doAction();  //returns an int of how much damage a character's action has inflicted

        //Step 3 - this implementation used by all character types
        public int takeDamage(int damage)
        {

            int damageInflicted = damage - defence;
            if (damageInflicted < 1) damageInflicted = 1;
            hitPoints = hitPoints - damageInflicted;
            return hitPoints;
        }

        //Step 3 - this implementation is used by all character types
        public bool isAlive()
        {
            if (hitPoints > 0) return true;
            else return false;
        }

    } //end character class
}
