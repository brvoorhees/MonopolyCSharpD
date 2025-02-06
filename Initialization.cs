using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCSharp
{
    public class Initialization
    {
        int numberOfPlayers;
        public int NumberOfPlayers()
        {
           
            bool validNumber = false;
            while (!validNumber)
            {
                Console.WriteLine($"How many players are going to be playing?\n");
                try
                {
                    numberOfPlayers = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }
                catch
                {
                    Console.WriteLine("Please provide a numeric value!\n");
                }
                if (numberOfPlayers < 7 && numberOfPlayers > 1)
                {
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine("Please select a number starting at 2 and up to 6\n");                                
                }
            }
            return numberOfPlayers;
        }
        public int PlayVersion()
        {
            int version = 0;
            bool correctVersion = false;

            while (!correctVersion)
            {
                bool ifVersion = false;
                while(!ifVersion)
                {
                    Console.WriteLine("What version are we going to play? (1. Normal, 2. Fast)\n");
                    try
                    {
                        version = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Needs to be a numeric value of 1 or 2\n");
                    }
                    if (version == 1 || version == 2)
                    {
                        correctVersion = true;
                        ifVersion = true;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid version!\nTry again!\n");
                    }
                }
                

               
                
            }
            return version;

        }
        public string PlayerEnum()
        {
            Console.WriteLine($"Which Character piece do you want represnting you?\n");
            Console.WriteLine($"ex. Gold Bag, Tridant, Top Hat, Dog, Cat, Tank, Eiffle Tower, Bulldozer, Guitar? The sky is the limit.\n");
            string enumeration = Console.ReadLine();
            return enumeration;
    }
       
    }
}
