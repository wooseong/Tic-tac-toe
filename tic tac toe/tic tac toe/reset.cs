using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class reset
{
   public static void Reset()
    {
        game_board.game_Board[0] = '0';
        game_board.game_Board[1] = '1';
        game_board.game_Board[2] = '2';
        game_board.game_Board[3] = '3';
        game_board.game_Board[4] = '4';
        game_board.game_Board[5] = '5';
        game_board.game_Board[6] = '6';
        game_board.game_Board[7] = '7';
        game_board.game_Board[8] = '8';
        game_board.game_Board[9] = '9';
    }
}
