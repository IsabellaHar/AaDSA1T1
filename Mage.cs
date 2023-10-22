using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Task1
{

    //Task 1.1 - Part 3/3
    public class Mage : Character
    {
        private int manaPoints { get; set; }      //capacity to cast spells
        private int fireBallDamage { get; set; }  //damage caused when a Mage throws a fireball

        //Step 4 - default constructor
        public Mage()
        {
            name = "Merlin";
            hitPoints = 60;
            strenght = 8;
            defence = 10;
            manaPoints = 100;
            fireBallDamage = 36;
        }

        //Step 3 - Implementation specific for Mage
        public override int doAction()  //returns damanage done
        //If a Mage has sufficient manaPoints they can throw fireballs, otherwise they just attack with their strength.
        {
            if (manaPoints > 10)
            {
                manaPoints = manaPoints - 10;  //throwing a fireball uses up manaPoints
                return fireBall();  //method implementation below
            }
            else
                Console.WriteLine("The Mage, " + name + ", has attacked.");
                Console.WriteLine();
            return strenght;
        }


        public int fireBall()
        {
            Console.WriteLine(name + " has thrown a fireball.");
            Console.WriteLine();
            return fireBallDamage;
        }
    } //end Mage class
}
