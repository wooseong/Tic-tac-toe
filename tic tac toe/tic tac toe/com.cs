using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class com
{
    private static int random_choice;
    static Random random = new Random();

    public static int choice_com()
    {
        if ('X' == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[3] && game_board.game_Board[1] == '1')
        {
            return 1;
        }
        else if ('X' == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[7] && game_board.game_Board[1] == '1')
        {
            return 1;
        }
        else if ('X' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[9] && game_board.game_Board[1] == '1')
        {
            return 1;
        }


        else if ('X' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[3] && game_board.game_Board[2] == '2')
        {
            return 2;
        }
        else if ('X' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[8] && game_board.game_Board[2] == '2')
        {
            return 2;
        }


        else if ('X' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[2] && game_board.game_Board[3] == '3')
        {
            return 3;
        }
        else if ('X' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[7] && game_board.game_Board[3] == '3')
        {
            return 3;
        }
        else if ('X' == game_board.game_Board[6] && game_board.game_Board[6] == game_board.game_Board[9] && game_board.game_Board[3] == '3')
        {
            return 3;
        }


        else if ('X' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[7] && game_board.game_Board[4] == '4')
        {
            return 4;
        }
        else if ('X' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[6] && game_board.game_Board[4] == '4')
        {
            return 4;
        }


        else if ('X' == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[8] && game_board.game_Board[5] == '5')
        {
            return 5;
        }
        else if ('X' == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[6] && game_board.game_Board[5] == '5')
        {
            return 5;
        }


        else if ('X' == game_board.game_Board[3] && game_board.game_Board[3] == game_board.game_Board[9] && game_board.game_Board[6] == '6')
        {
            return 6;
        }
        else if ('X' == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[5] && game_board.game_Board[6] == '6')
        {
            return 6;
        }


        else if ('X' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[4] && game_board.game_Board[7] == '7')
        {
            return 7;
        }
        else if ('X' == game_board.game_Board[3] && game_board.game_Board[3] == game_board.game_Board[5] && game_board.game_Board[7] == '7')
        {
            return 7;
        }
        else if ('X' == game_board.game_Board[8] && game_board.game_Board[8] == game_board.game_Board[9] && game_board.game_Board[7] == '7')
        {
            return 7;
        }


        else if ('X' == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[5] && game_board.game_Board[8] == '8')
        {
            return 8;
        }
        else if ('X' == game_board.game_Board[7] && game_board.game_Board[7] == game_board.game_Board[9] && game_board.game_Board[8] == '8')
        {
            return 8;
        }


        else if ('X' == game_board.game_Board[3] && game_board.game_Board[3] == game_board.game_Board[6] && game_board.game_Board[9] == '9')
        {
            return 9;
        }
        else if ('X' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[5] && game_board.game_Board[9] == '9')
        {
            return 9;
        }
        else if ('X' == game_board.game_Board[7] && game_board.game_Board[7] == game_board.game_Board[8] && game_board.game_Board[9] == '9')
        {
            return 9;
        }


        else if ('O' == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[3] && game_board.game_Board[1] == '1')
        {
            return 1;
        }
        else if ('O' == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[7] && game_board.game_Board[1] == '1')
        {
            return 1;
        }
        else if ('O' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[9] && game_board.game_Board[1] == '1')
        {
            return 1;
        }


        else if ('O' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[3] && game_board.game_Board[2] == '2')
        {
            return 2;
        }
        else if ('O' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[8] && game_board.game_Board[2] == '2')
        {
            return 2;
        }


        else if ('O' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[2] && game_board.game_Board[3] == '3')
        {
            return 3;
        }
        else if ('O' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[7] && game_board.game_Board[3] == '3')
        {
            return 3;
        }
        else if ('O' == game_board.game_Board[6] && game_board.game_Board[6] == game_board.game_Board[9] && game_board.game_Board[3] == '3')
        {
            return 3;
        }


        else if ('O' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[7] && game_board.game_Board[4] == '4')
        {
            return 4;
        }
        else if ('O' == game_board.game_Board[5] && game_board.game_Board[5] == game_board.game_Board[6] && game_board.game_Board[4] == '4')
        {
            return 4;
        }


        else if ('O' == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[8] && game_board.game_Board[5] == '5')
        {
            return 5;
        }
        else if ('O' == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[6] && game_board.game_Board[5] == '5')
        {
            return 5;
        }


        else if ('O' == game_board.game_Board[3] && game_board.game_Board[3] == game_board.game_Board[9] && game_board.game_Board[6] == '6')
        {
            return 6;
        }
        else if ('O' == game_board.game_Board[4] && game_board.game_Board[4] == game_board.game_Board[5] && game_board.game_Board[6] == '6')
        {
            return 6;
        }


        else if ('O' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[4] && game_board.game_Board[7] == '7')
        {
            return 7;
        }
        else if ('O' == game_board.game_Board[3] && game_board.game_Board[3] == game_board.game_Board[5] && game_board.game_Board[7] == '7')
        {
            return 7;
        }
        else if ('O' == game_board.game_Board[8] && game_board.game_Board[8] == game_board.game_Board[9] && game_board.game_Board[7] == '7')
        {
            return 7;
        }


        else if ('O' == game_board.game_Board[2] && game_board.game_Board[2] == game_board.game_Board[5] && game_board.game_Board[8] == '8')
        {
            return 8;
        }
        else if ('O' == game_board.game_Board[7] && game_board.game_Board[7] == game_board.game_Board[9] && game_board.game_Board[8] == '8')
        {
            return 8;
        }


        else if ('O' == game_board.game_Board[3] && game_board.game_Board[3] == game_board.game_Board[6] && game_board.game_Board[9] == '9')
        {
            return 9;
        }
        else if ('O' == game_board.game_Board[1] && game_board.game_Board[1] == game_board.game_Board[5] && game_board.game_Board[9] == '9')
        {
            return 9;
        }
        else if ('O' == game_board.game_Board[7] && game_board.game_Board[7] == game_board.game_Board[8] && game_board.game_Board[9] == '9')
        {
            return 9;
        }

        else
        {
            if (game_board.game_Board[5] == 'O')
            {
                if (game_board.game_Board[1] == '1')
                {
                    return 1;
                }
                else if (game_board.game_Board[3] == '3')
                {
                    return 3;
                }
                else if (game_board.game_Board[3] == '7')
                {
                    return 7;
                }
                else if (game_board.game_Board[9] == '9')
                {
                    return 9;
                }
            }
            while (true)
            {
                random_choice = random.Next(1, 9);
                if (game_board.game_Board[random_choice] != 'X' && game_board.game_Board[random_choice] != 'O')
                    return random_choice;
            }
        }
    }
}
