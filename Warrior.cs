using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Task1
{
    //Task 1.1 - Part 2/3
    //Intermediate class between base class Character and Derived Class Paladin
    public class Warrior : Character
    {
        protected int ragePoints { get; set; }  //minimum number needed to perform a heavy swing

        //Step 4 - default constructor
        public Warrior()
        {
            hitPoints = 25;
            strenght = 10;  
            defence = 10;
            ragePoints = 20;  
        }


        //Step 3 - Implementation specific to Warrior and inherited by Paladin
        public override int doAction()
        //If warriors have sufficient ragePoints, their action is a heavy swing, otherwise they just attack.
        //Method returns the damage inflicted from either action undertaken
        {
            
            if (ragePoints > 15)
            {
                ragePoints = ragePoints - 15;  //doing a heavy swing costs ragePoints
                return heavySwing(); //uses method below
            }

            ragePoints = ragePoints + 5;  //ragePoint increase when warrior doesn't do a heavy swing
            Console.WriteLine(name + " has attacked.");
            Console.WriteLine();
            return strenght; //return strength being the default damange of the attack

        }


        //Step 3 - method specific to Warrior and inherited by Paladin
        public int heavySwing()
        //This method sets out what happens when a warrior does a heavy swing
        {
            Console.WriteLine(name + " has swung his axe.");
            Console.WriteLine();
            return strenght * 3;  //A heavy swing inflicts 3 times the damage of a normal attack 
        }


    } //end warrior class
}
