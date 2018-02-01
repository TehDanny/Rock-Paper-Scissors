using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Game
    {
        public string Player1Choice { get; set; }
        public string Player2Choice { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void GameMenu(Player player)
        {
            Console.WriteLine(player.Name + " make your choice");
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
        }

        internal string CalculateWinner()
        {
            string winner = "tie";
            
            if(Player1Choice == "rock")
            {
                if (Player2Choice == "paper")
                {
                    winner = Player2.Name;
                }
                else if (Player2Choice == "scissors")
                {
                    winner = Player1.Name;
                }
            }
            else if(Player1Choice == "paper")
            {
                if (Player2Choice == "rock")
                {
                    winner = Player1.Name;
                }
                else if (Player2Choice == "scissors")
                {
                    winner = Player2.Name;
                }
            }
            else if(Player1Choice == "scissors")
            {
                if (Player2Choice == "rock")
                {
                    winner = Player2.Name;
                }
                else if (Player2Choice == "paper")
                {
                    winner = Player1.Name;
                }
            }

            return winner;
        }
    }
}
