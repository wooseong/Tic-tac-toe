using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Score
{
    public static void show_score(int[] game_score, int player_set)
    {
        if (player_set == 0)
        {
            Console.WriteLine("\n  이름이 설정되지 않았습니다.");
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine("\n  이긴 횟수  ");
            Console.WriteLine("      {0}      :  {1}", game_score[1], player1.player_name);
            if (player_set == 2)
                Console.WriteLine("      {0}      :  {1}", game_score[2], player2.player_name);
            Console.WriteLine("      {0}      :  Com", game_score[3]);
            Console.ReadLine();
        }
    }
}
