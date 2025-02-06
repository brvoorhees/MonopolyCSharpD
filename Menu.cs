using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCSharp
{
    public class Menu
    {
        public int MenuOption()
        {
            int option = 98;
            while (option == 98)
            try
            {
                Console.WriteLine("Select a Transaction \n (1) Pass Go \n (2) Purchase Something \n (3) Pay another player \n (4) Pay a penalty \n (5) Land on Free Parking \n (6) Receive a reward \n (7) Sell Houses or Motels \n (8) Mortgage a property \n (99) Exit program\n");
                option = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Please provide an Integer value\n");
            }
            return option;
        }
        public int Purchase()
        {
            int amount = 1;
            while (amount ==  1)
            {
                try
                {
                    Console.WriteLine("How much was your purchase?\n");
                    amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please provide an Integer value\n");
                }
            }
            return amount;
        }
        public int OwePayPlayer()
        {
            int amount = 1;
            while (amount == 1)
            {
                try
                {
                    Console.WriteLine("How much do you owe them?\n");
                    amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please provide an Integer value\n");
                }
            }
            return amount;
        }
        public int Penalty()
        {
            int amount = 1;
            while (amount == 1)
            {
                try
                {
                    Console.WriteLine("How much of a penalty do you owe?\n");
                    amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please provide an Integer value\n");
                }
            }
            return amount;
        }
        public int Reward()
        {
            int amount = 1;
            while(amount == 1)
            {
                try
                {
                    Console.WriteLine("How much is your reward?\n");
                    amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please provide an Integer value\n");
                }
            }
            return amount;
        }
        public int Selling()
        {
            int amount = 1;
            while(amount ==1)
            {
                try
                {
                    Console.WriteLine("How much are you selling your houses or hotels for?\n");
                    amount = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Please provide an Integer value\n");
                }
            }
            return amount;

        }
        public int Mortgage()
        {
            int amount = 1;
            while (amount == 1)
            {
                try
                {
                    Console.WriteLine("How much are you getting from mortgaging your property(s)\n");
                    amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please provide an Integer value\n");
                }
            }
            return amount;
        }
    
    }
}
