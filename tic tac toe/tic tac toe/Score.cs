using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Score
{
    public static List<int> vs_com_score = new List<int>(new int[] { 0 });
    public static ArrayList vs_player_score = new ArrayList(new int[] { 0, 0 });

    public static void show_score(int player_set)
    {
        if (player_set == 0)
        {
            Console.WriteLine("\n  이름이 설정되지 않았습니다.");
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine("\n  Com을 이긴 횟수  ");
            Console.WriteLine("      {0}      :  {1}", vs_com_score[0], player1.player_name);
            if (player_set == 2)
            {
                Console.WriteLine("\n  이긴 횟수  ");
                Console.WriteLine("      {0}      :  {1}", vs_player_score[0], player1.player_name);
                Console.WriteLine("      {0}      :  {1}", vs_player_score[1], player2.player_name);
            }
            Console.ReadLine();
        }
    }
}
