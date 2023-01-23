using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    class SupportingClass
    {
        // Print function returns nothing and prints the board display
        public void printBoard(char[] boardArray)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + boardArray[1]  + "  |  " + boardArray[2] + "  |  " + boardArray[3] );
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + boardArray[4] + "  |  " + boardArray[5] + "  |  " + boardArray[6] );
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + boardArray[7] + "  |  " + boardArray[8] + "  |  " + boardArray[9]);
            Console.WriteLine("     |     |      ");
        }

        // Private function saves code by returning integer based on player's letter
        private int checkPlayer (char letter)
        {
            if (letter == 'X')
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        //Checkwinner function determines if there was a win or if the whole board was filled as a tie
        public int checkWinner (char[] boardArray)
        {
            // Check Horizontal rows for a winner
            if ( (boardArray[1] == boardArray[2]) && (boardArray[2] == boardArray[3]) )
            {
                return checkPlayer(boardArray[1]);
            }
            else if ((boardArray[4] == boardArray[5]) && (boardArray[5] == boardArray[6]))
            {
                return checkPlayer(boardArray[4]);
            }
            else if ((boardArray[7] == boardArray[8]) && (boardArray[8] == boardArray[9]))
            {
                return checkPlayer(boardArray[7]);
            }

            // Check vertical rows
            else if ((boardArray[1] == boardArray[4]) && (boardArray[4] == boardArray[7]))
            {
                return checkPlayer(boardArray[1]);
            }
            else if ((boardArray[2] == boardArray[5]) && (boardArray[5] == boardArray[8]))
            {
                return checkPlayer(boardArray[2]);
            }
            else if ((boardArray[3] == boardArray[6]) && (boardArray[6] == boardArray[9]))
            {
                return checkPlayer(boardArray[3]);
            }

            // Check Diagonal Wins
            else if ((boardArray[1] == boardArray[5]) && (boardArray[5] == boardArray[9]))
            {
                return checkPlayer(boardArray[1]);
            }
            else if ((boardArray[3] == boardArray[5]) && (boardArray[5] == boardArray[7]))
            {
                return checkPlayer(boardArray[3]);
            }

            // Return -1 if the board is full with no winner aka a tie
            else if ( boardArray[1] != '1' && boardArray[2] != '2' && boardArray[3] != '3' && boardArray[4] != '4' && boardArray[5] != '5' && boardArray[6] != '6' && boardArray[7] != '7' && boardArray[8] != '8' && boardArray[9] != '9' )
            {
                return -1;
            }
            // No winner or tie returns 0
            else
            {
                return 0;
            }
        }
    }
}
