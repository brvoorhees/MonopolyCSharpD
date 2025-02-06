using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCSharp
{
    public class Validator
    {
        public int PlayerValidation(List<Player> players)
        {
            int selectPlayer = 0;
            bool validPlayer = false;
                while (!validPlayer)
                {
                    Player.PlayerDetails(players);
                try
                {
                    Console.WriteLine("Select a valid player id\n");
                    selectPlayer = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not a valid player\n");
                }
                    
                    for (int i = 0; i < players.Count(); i++)
                    {
                        if (selectPlayer == players[i].PlayerNames)
                        {
                            
                            validPlayer = true;
                        

                        }

                    }

                }
            return selectPlayer;
        }
    }
}
