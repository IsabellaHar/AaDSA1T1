using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1Task1
{

    //Task 1.2
    public class Paladin : Warrior
    {
        private int healAmount { get; set; }  //hitPoints are restored to this level when a Paladin heals

        //Step 4 - Default constructor
        public Paladin()
        {
            name = "The Green Knight";
            hitPoints = 50;
            strenght = 15;
            defence = 15;
            ragePoints = 30;
            healAmount = 20;
        }

        //Step 3 - Uses Warrior implementation and adds extra action heal
        public override int doAction()
        //Paladin's can do everything a warrior does, plus they can heal themselves 
        //if they are still alive but low on hitPoints
        {
            //check if the Paladin needs to heal

            if (hitPoints < 10)
            {
                return heal(); //method set out below
            }

            //if hitPoints OK, attack using standard Warrior actions
            return base.doAction();
        }

        public int heal()
        //This method restores the Paladin's hitPoints up to the amount specified in healAmount;        
        {
            hitPoints = healAmount;
            Console.WriteLine(name + " has drunk a healing potion");
            Console.WriteLine();
            return 0;
        }



    }

}
