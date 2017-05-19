using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Menu
{
    
    private ConsoleKeyInfo cki; //누른 콘솔 키를 식별 하는 값입니다.
    private VS_Player Player;

    public void MENU()
    {
        Console.TreatControlCAsInput = true; // Control 보조키와 C 콘솔 키의 조합(Ctrl+C)이 일반 입력으로 처리되는지
                                             // 운영 체제에서 처리하는 충돌로 처리되는지를 나타내는 값을 가져오거나 설정합니다.
        Player = new VS_Player();

        do
        {
            Console.Clear(); //콘솔창 화면을 지워주는 Console Class의 메서드
            Console.WriteLine("1. Vs Com");
            Console.WriteLine("2. Vs Player");
            Console.WriteLine("3. Score");
            Console.WriteLine("Press the Escape (Esc) key to quit: ");

            cki = Console.ReadKey(true);
            Console.WriteLine("{0}", cki.KeyChar);
            if (cki.Key == ConsoleKey.Escape) break;
            Thread.Sleep(500);

            if (cki.KeyChar == '1')
            {
            }

            else if (cki.KeyChar == '2')
            {
                Player.vs_player();
            }

            else if (cki.KeyChar == '3')
            {
            }

        } while (true);
    }
}