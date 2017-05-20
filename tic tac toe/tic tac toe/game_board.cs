using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class game_board
{
    public static char[] game_Board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    public static void Board()
    {
        Console.WriteLine("         |       |        ");
        Console.WriteLine("     {0}   |   {1}   |   {2}", game_Board[1], game_Board[2], game_Board[3]);
        Console.WriteLine("  _______|_______|_______ ");
        Console.WriteLine("         |       |        ");
        Console.WriteLine("     {0}   |   {1}   |   {2}", game_Board[4], game_Board[5], game_Board[6]);
        Console.WriteLine("  _______|_______|_______ ");
        Console.WriteLine("         |       |        ");
        Console.WriteLine("     {0}   |   {1}   |   {2}", game_Board[7], game_Board[8], game_Board[9]);
        Console.WriteLine("         |       |        ");
    }

}
