using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyCSharp
{
    public class Player
    {
        protected int numberOfPlayers;
        protected int playerNames;
        protected int playerMoney;
        protected string playerEnum;
        public bool loss;
        public int PlayerNames
        {
            get { return playerNames; }
            set { playerNames = value; }
        }
        public int PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }
        public string PlayerEnum
        {
            get { return playerEnum; }
            set { playerEnum = value; }
        }
        
        public Player(int playerNumber, int version, string enumeration)
        {
            PlayerEnum = enumeration;
            PlayerNames = playerNumber;
            if (version == 1)
            {
                PlayerMoney = 1500;
            }
            else if (version == 2)
            {
                PlayerMoney = 2500;
            }
        }
        
        public static void PlayerDetails(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                players[i].Details();
            }
        }
        public static void CurrentMoney(List<Player>players, int playerSelected, bool loss, int playerChange)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].PlayerNames == playerSelected)
                {
                    if (loss == true)
                    {
                        if (players[i].PlayerMoney >  playerChange)
                        {
                            players[i].PlayerMoney = players[i].PlayerMoney - playerChange;
                        }
                        else
                        { 
                            Console.WriteLine($"{players[i].PlayerEnum} Your going to need to sell some houses, hotels, or mortgage a property, because you are going negative!\n");
                            players[i].PlayerMoney = players[i].PlayerMoney - playerChange;
                        }
                    }
                    else
                    {
                        players[i].PlayerMoney = players[i].PlayerMoney + playerChange;
                    }
                }
            }
        }
        
        public void Details()
        {
            Console.WriteLine("");
            Console.WriteLine($"{PlayerNames}, {PlayerEnum}, {PlayerMoney}\n" );
        }

      
    }
  
}
