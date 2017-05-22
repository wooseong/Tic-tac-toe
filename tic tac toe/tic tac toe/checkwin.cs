using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class checkwin
{
    public static int Checkwin()
    {
        if (game_board.game_Board[1] == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[3])
        {
            return 1;
        }
        else if (game_board.game_Board[4] == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[6])
        {
            return 1;
        }
        else if (game_board.game_Board[7] == game_board.game_Board[8] && game_board.game_Board[8] == game_board.game_Board[9])
        {
            return 1;
        }


        else if (game_board.game_Board[1] == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[7])
        {
            return 1;
        }
        else if (game_board.game_Board[2] == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[8])
        {
            return 1;
        }
        else if (game_board.game_Board[3] == game_board.game_Board[6] && game_board.game_Board[6] == game_board.game_Board[9])
        {
            return 1;
        }


        else if (game_board.game_Board[1] == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[9])
        {
            return 1;
        }
        else if (game_board.game_Board[3] == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[7])
        {
            return 1;
        }

        else if (game_board.game_Board[1] != '1' && game_board.game_Board[2] != '2' && game_board.game_Board[3] != '3' && game_board.game_Board[4] != '4' && game_board.game_Board[5] != '5' && game_board.game_Board[6] != '6' && game_board.game_Board[7] != '7' && game_board.game_Board[8] != '8' && game_board.game_Board[9] != '9')
        {
            return -1;
        }

        else
        {
            return 0;
        }

    }
}
