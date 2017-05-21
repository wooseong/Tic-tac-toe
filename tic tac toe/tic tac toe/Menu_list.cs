using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Menu_list
{
    private VS_player withplayer;
    private VS_com withcom;

    private int player_set = 0;
    private int[] game_score = { 0, 0, 0, 0};// draw, player1, player2, com

    private int menu_number, vsplayer_menu, vscom_menu;
    private string menu_number_check, vsplayer_menu_check, vscom_menu_check;

    public void show_MENU()
    {

        do
        {
            withplayer = new VS_player();
            withcom = new VS_com();

            Console.Clear(); //콘솔창 화면을 지워주는 Console Class의 메서드
            Console.WriteLine("\n  1. Vs Com");
            Console.WriteLine("  2. Vs Player");
            Console.WriteLine("  3. Score");
            Console.WriteLine("  4. exit");
            Console.Write("\n  ");

            menu_number_check = Console.ReadLine();

            if (!(menu_number_check.Equals("1") || menu_number_check.Equals("2") ||
                menu_number_check.Equals("3") || menu_number_check.Equals("4")))
            {

                Console.WriteLine("  잘못입력하셨습니다.");
                Console.WriteLine("  다시 선택하여 주십시오.....");
                Thread.Sleep(500);
                continue;

            }

            menu_number = int.Parse(menu_number_check);

            if (menu_number == 1)
            {
                if (player_set == 0)
                {
                    Console.Clear();
                    player1.player1_name();
                    player_set = 1;
                }
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n  1. player1의 이름 변경");
                    Console.WriteLine("  2. Game start!!");

                    vscom_menu_check = Console.ReadLine();

                    if  (!(vscom_menu_check.Equals("1") || vscom_menu_check.Equals("2")) )
                    {

                        Console.WriteLine("  잘못입력하셨습니다.");
                        Console.WriteLine("  다시 선택하여 주십시오.....");
                        Thread.Sleep(500);
                        continue;

                    }

                    vscom_menu = int.Parse(vscom_menu_check);

                    if (vscom_menu == 1)
                    {
                        Console.Clear();
                        player1.player1_name();
                    }

                    else if (vscom_menu == 2)
                    {
                        game_score[withcom.vs_com()]++;
                        break;
                    }
                } while (true);
            }


            else if (menu_number == 2)
            {
                if (player_set == 0)
                {
                    Console.Clear();
                    player1.player1_name();
                    Console.Clear();
                    player2.player2_name();
                    player_set = 2;
                }
                if (player_set == 1)
                {
                    Console.Clear();
                    player2.player2_name();
                    player_set = 2;
                }
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n  1. player1의 이름 변경");
                    Console.WriteLine("  2. player2의 이름 변경");
                    Console.WriteLine("  3. Game start!!");

                    vsplayer_menu_check = Console.ReadLine();

                    if (!(vsplayer_menu_check.Equals("1") || vsplayer_menu_check.Equals("2") || vsplayer_menu_check.Equals("3")))
                    {

                        Console.WriteLine("  잘못입력하셨습니다.");
                        Console.WriteLine("  다시 선택하여 주십시오.....");
                        Thread.Sleep(500);
                        continue;

                    }

                    vsplayer_menu = int.Parse(vsplayer_menu_check);

                    if (vsplayer_menu == 1)
                    {
                        Console.Clear();
                        player1.player1_name();
                    }
                    else if (vsplayer_menu == 2)
                    {
                        Console.Clear();
                        player2.player2_name();
                    }
                    else if (vsplayer_menu == 3)
                    {
                        game_score[withplayer.vs_player()]++;
                        break;
                    }
                } while (true);

            }


            else if (menu_number == 3)
            {
                Score.show_score(game_score);
            }
            
        } while (menu_number != 4);
    }
}