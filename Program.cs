using MonopolyCSharp;
using System.Threading.Tasks;


//Number of Players
Initialization initial = new Initialization();
 int numberOfPlayers = initial.NumberOfPlayers();

int version = initial.PlayVersion();

//Creating and adding a list of players based on number provided above <7
List<Player> players = new List<Player>();


for (int i  = 0; i < numberOfPlayers; i++)
{
    int p = i+1;
    Console.WriteLine("");
    Console.WriteLine($"Player number {p}\n");
    string enumeration = "";
    while (enumeration == "")
    {
        enumeration = initial.PlayerEnum();
    } 
    Player player = new Player(p, version, enumeration) ;
    players.Add(player);
}

int thePot = 0;
int selectPlayer = 0;
int payPlayer = 0;
int amount;


bool not99 = false;
while (!not99)
{

Validator validator = new Validator();
selectPlayer = validator.PlayerValidation(players);
bool loss = false;
Menu menu = new Menu();
int option = menu.MenuOption();
    if (option == 1)
    {
        //Pass go get 200
        amount = 200;
        Player.CurrentMoney(players, selectPlayer, loss, amount);
    }
    else if (option == 2)
    {
        //Purchase something
        loss = true;
        amount = menu.Purchase();
        Player.CurrentMoney(players, selectPlayer, loss, amount);
    }
    else if (option == 3)
    {
        //Pay another player
        bool uniqueName = false;
            while (!uniqueName)
        {
            int tempValidationName = validator.PlayerValidation(players);
            if (selectPlayer != tempValidationName)
            {
                payPlayer = tempValidationName;
                uniqueName = true;
            }
               
        }
        loss = true;
        //Charge selectedPlayer
        amount = menu.OwePayPlayer();
        Player.CurrentMoney(players, selectPlayer, loss, amount);
        //Give money to payPlayer
        loss = false;
        Player.CurrentMoney(players, payPlayer, loss, amount);
    }
    else if (option == 4)
    {
        //Pay a penalty
        amount = menu.Penalty();
        loss = true;
        Player.CurrentMoney(players, selectPlayer, loss, amount);
        thePot += amount;
        Console.WriteLine($"Total available in the Pot is {thePot}");
    }
    else if (option == 5)
    {
        //Land on Free Parking
        Console.WriteLine("You get the Jack Pot!");    
        Player.CurrentMoney(players, selectPlayer, loss, thePot);
        thePot = 0;
    }
    else if (option == 6)
    {
        //Receive a reward
        amount = menu.Reward();
        Player.CurrentMoney(players, selectPlayer, loss, amount);
        
    }
    else if (option == 7)
    {
        //Sell property
        amount = menu.Selling();
        Player.CurrentMoney(players, selectPlayer, loss, amount);
        
    }
    else if (option == 8)
    {
        //Mortgage a property
        amount = menu.Mortgage();
        Player.CurrentMoney(players, selectPlayer, loss, amount);
    }
    else if (option == 99)
    {
        //Exit the program
        break;
    }
    else
    {
        //Bad response
        Console.WriteLine("Not a valid response! Try again");
    }

}
