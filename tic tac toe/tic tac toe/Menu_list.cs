using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Menu_list
{

    private int menu_number;
    private string menu_number_check;
    private VS_player withplayer;

    public void show_MENU()
    {
        withplayer = new VS_player();

        do
        {
            Console.Clear(); //콘솔창 화면을 지워주는 Console Class의 메서드
            Console.WriteLine("\n  1. Vs Com");
            Console.WriteLine("  2. Vs Player");
            Console.WriteLine("  3. Score");
            Console.WriteLine("  4. exit");
            Console.Write("\n  ");

            menu_number_check = Console.ReadLine();

            if ( !(menu_number_check.Equals("1") || menu_number_check.Equals("2") ||
                menu_number_check.Equals("3") || menu_number_check.Equals("4")) )
            {

                Console.WriteLine("  잘못입력하셨습니다.");
                Console.WriteLine("  다시 선택하여 주십시오.....");
                Thread.Sleep(500);
                continue;

            }

            menu_number = int.Parse(menu_number_check);

            if (menu_number == 1)
            {
            }
            else if (menu_number == 2)
            {
                withplayer.vs_player();
            }
            else if (menu_number == 3)
            {
            }
            else if (menu_number == 4)
                break;

        } while (true);
    }
}