using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    class Program
    {
        static char[] gameBoard = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static void Main(string[] args)
        {
            // Welcome the user to the game
            SupportingClass sc = new SupportingClass();
            Console.WriteLine("Lets play Tic-Tac-Toe!");
            int Player = 1;
            int numberPicked;
            int whoWon = 0;
            string Continue = "";
            // Create a game board array to store the players’ choices
            while (whoWon == 0)
            {
                Console.WriteLine("Player 1 is X and Player 2 is O");
                Console.WriteLine(" ");
                
                if (Continue == "Y" || Continue == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Player 1 is X and Player 2 is O");
                }
                if (Player % 2 == 0) //checking the chance of the player
                {
                    Console.WriteLine("Player 2's Turn");
                }
                else
                {
                    Console.WriteLine("Player 1's Turn");
                }
                sc.printBoard(gameBoard);
                numberPicked = int.Parse(Console.ReadLine());
                // If user choice is not taken, add it to the game board array
                if (!(gameBoard[numberPicked] == 'O' || gameBoard[numberPicked] == 'X'))
                {
                    if (Player % 2 == 0)
                    {
                        gameBoard[numberPicked] = 'O';
                        Player++;
                    }
                    else
                    {
                        gameBoard[numberPicked] = 'X';
                        Player++;
                    }
                }
                // They must pick a new spot if taken
                else
                {
                    Console.WriteLine("Please pick another spot");
                    Console.WriteLine("Press Y to Continue");
                    Continue = Console.ReadLine();
                }
                // -- call CheckWin Function  --
                whoWon = sc.checkWinner(gameBoard);
                Console.Clear();
            }
            Console.Clear();// clearing the console
            sc.printBoard(gameBoard); //  ----- PRINT BOARD FUNCTION  -----
            if (whoWon == 1)
            // if flag value is 1 then player 1 wins, otherwise flag value 2 indicates player 2 won
            //means who played marked last time which has win
            {
                Console.WriteLine("Player 1 won!");
            }
            else if (whoWon == 2)
            {
                Console.WriteLine("Player 2 won!");
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
