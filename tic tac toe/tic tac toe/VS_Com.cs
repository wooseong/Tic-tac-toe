using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


class VS_com
{
    static int playerturn;
    static int choice;
    static string choicecheck;
    static int gamedecision = 0;
    Random random = new Random();

    public int vs_com()
    {
        playerturn = random.Next(2);// 0 or 1

        Console.Clear();
        Console.WriteLine("\n  차례는 랜덤으로 정해집니다....\n");
        Thread.Sleep(500);

        if (playerturn == 0)
            Console.WriteLine("  {0}님이 선공입니다. : O", player1.player_name);
        else
            Console.WriteLine("  Com이 선공입니다. : X");

        Thread.Sleep(1500);

        do
        {
            Console.Clear();
            Console.WriteLine("\n    {0}    VS    Com    \n", player1.player_name);
            game_board.Board();

            if (playerturn == 0)
            {// player1의 차례  
                Console.WriteLine("\n  {0}님의 턴입니다. : O", player1.player_name);
                Console.Write("  ");
                choicecheck = Console.ReadLine();

                if (!(choicecheck.Equals("1") || choicecheck.Equals("2") || choicecheck.Equals("3") ||
                    choicecheck.Equals("4") || choicecheck.Equals("5") || choicecheck.Equals("6") ||
                    choicecheck.Equals("7") || choicecheck.Equals("8") || choicecheck.Equals("9")))
                {
                    Console.WriteLine("\n  잘못입력하셨습니다.");
                    Console.WriteLine("  다시 선택하여 주십시오.....");
                    Thread.Sleep(1000);
                    continue;
                }
                choice = int.Parse(choicecheck);

                if (game_board.game_Board[choice] != 'X' && game_board.game_Board[choice] != 'O') // 아무도 체크 안한 곳이면
                {
                        game_board.game_Board[choice] = 'O';
                        playerturn = 1;
                }
                else // 누군가 이미 체크한 곳이면
                {
                    Console.WriteLine("\n  이미 선택이 되어진 자리입니다.");
                    Console.WriteLine("  다시 선택하여 주십시오.....");
                    Thread.Sleep(1300);
                    continue;
                }
            }

            else
            {
                choice = com.choice_com();
                game_board.game_Board[choice] = 'X';
                playerturn = 0;
            }

            gamedecision = checkwin.Checkwin();
        } while (gamedecision != 1 && gamedecision != -1);

        Console.Clear();
        Console.WriteLine();
        game_board.Board();

        if (gamedecision == 1)
        {
            if (playerturn == 1)
            {
                Console.WriteLine("\n  {0}님이 이겼습니다.", player1.player_name);
                Console.ReadLine();
                reset.Reset();
                return 1;
            }
            else if (playerturn == 0)
            {
                Console.WriteLine("\n  Com이 이겼습니다.");
                Console.ReadLine();
                reset.Reset();
                return 3;
            }
        }
        else
        {
            Console.WriteLine("\n  Draw");
            Console.ReadLine();
            reset.Reset();
            return 0;
        }
        return 0;
    }
}
