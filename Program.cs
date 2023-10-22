using System;
using System.Xml.Linq;

namespace Assessment1Task1


    //TO DO
    //check all attributes used
    //check all steps covered
    //more comments?
    //check inhertence all used
    //check encapsulation - functions do everything?
    //check constructors

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paladin myPaladin = new Paladin();
            int paladinDamange = 0;

            Console.WriteLine("The first combatant is a Paladin called " + myPaladin.getName());
            Console.WriteLine(myPaladin.getName() + " has " + myPaladin.getHitPoints() + " hit points.");
            Console.WriteLine();


            Mage myMage = new Mage();
            int mageDamange = 0;
            Console.WriteLine("The second combatant is a Mage called " + myMage.getName());
            Console.WriteLine(myMage.getName() + " has " + myMage.getHitPoints() + " hit points.");
            Console.WriteLine();

            //Step 5

            Console.WriteLine("The battle begins.");
            Console.WriteLine();

            while (true)
            {
                mageDamange = myMage.doAction();
                Console.WriteLine(myPaladin.getName() + " has " + myPaladin.takeDamage(mageDamange) + " hitpoints remaining.");
                Console.WriteLine() ;
                if (myPaladin.isAlive() == false)
                    {
                        Console.WriteLine(myPaladin.getName() + " has been defeated by " + myMage.getName());
                        break;
                    }
                    
                    

                 paladinDamange = myPaladin.doAction();
                 Console.WriteLine(myMage.getName() + " has " + myMage.takeDamage(paladinDamange) + " hitpoints remaining");
                Console.WriteLine() ;   
                 if (myMage.isAlive() == false)
                    {
                        Console.WriteLine(myMage.getName() + " has been defeated by " + myPaladin.getName());
                        break;
                    }
            }




        } //end Main

    } //end Program class
} //end Namespace