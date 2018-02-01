using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        private Game game;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            Console.WriteLine("Please enter player 1's name:");
            Player player1 = new Player();
            player1.Name = Console.ReadLine();

            Console.WriteLine("Please enter player 2's name:");
            Player player2 = new Player();
            player2.Name = Console.ReadLine();

            Console.Clear();

            game = new Game(player1, player2);

            game.GameMenu(player1);
            game.Player1Choice = PlayerChoice();
            
            Console.Clear();

            game.GameMenu(player2);
            game.Player2Choice = PlayerChoice();

            Console.Clear();

            string winner = game.CalculateWinner();
            if (winner == "tie")
            {
                Console.WriteLine("The game is a tie");
            }
            else
            {
                Console.WriteLine("The winner is " + game.CalculateWinner());
            }

            Console.ReadLine();
        }

        private string PlayerChoice()
        {
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "rock" || userInput == "paper" || userInput == "scissors")
            {
                return userInput;
            } else
            {
                Console.WriteLine("Invalid choice");
                return PlayerChoice();
            }
        }
    }
}
