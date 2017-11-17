using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            int xp = 0;
            int level = 10;
            int monsterLevel = 10;
            Random rdm = new Random();
            List<string> inventory = new List<string>();
            inventory.Add("Basic Sword");
            inventory.Add("Basic Shield");

            Console.WriteLine("Welcome to my game.");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ".");
            while (true)
            {
                Console.WriteLine("Level: " + level + "       XP: " + xp);
                Console.WriteLine("Would you like to 1) FIGHT MONSTERS 2) VIEW INVENTORY 3) QUIT?");
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    Console.WriteLine("A level " + monsterLevel + " monster want to fight!");
                    int myHealth = level;
                    int monsterHealth = monsterLevel;
                    if (level >= monsterLevel)
                    {
                        while(true)
                        {
                            Console.WriteLine("Click ENTER to attack.");
                            Console.ReadLine();
                            int roll = rdm.Next(0, level / 3);
                            Console.WriteLine("You rolled a " + roll + ".");
                            monsterHealth = monsterHealth - roll;
                            Console.WriteLine(name + "'s health: " + myHealth + "         Monster's health: " + monsterHealth);

                            if (myHealth <= 0 || monsterHealth <=0)
                            {
                                break;
                            }
                            Console.WriteLine("Click ENTER to see enemy's attack.");
                            Console.ReadLine();
                            roll = rdm.Next(0, level / 3);
                            Console.WriteLine("The monster rolled a " + roll + ".");
                            myHealth = myHealth - roll;
                            Console.WriteLine(name + "'s health: " + myHealth + "         Monster's health: " + monsterHealth);
                            if (myHealth <= 0 || monsterHealth <= 0)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    //adding xp 
                    if (myHealth > 0) //if I win
                    {
                        Console.WriteLine("Congratulations!  You gained " + monsterLevel + " experience.");
                        xp = xp + monsterLevel;
                    }
                    else //if I lose
                    {
                        Console.WriteLine("You died and lost " + (monsterLevel / 2) + " experience.");
                        xp = xp - (monsterLevel / 2);
                    }
                }

                if (userChoice == "2")
                {
                    for (int i = 0; i < inventory.Count(); i++)
                    {
                        Console.WriteLine(inventory[i]);
                    }
                }
                if (userChoice == "3")
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
