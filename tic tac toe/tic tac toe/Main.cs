using System;

class Example
{
    public static void Main()
    {
        int menu_number;
        ConsoleKeyInfo cki; //누른 콘솔 키를 식별 하는 값입니다.
        Console.TreatControlCAsInput = true; // Control 보조키와 C 콘솔 키의 조합(Ctrl+C)이 일반 입력으로 처리되는지
                                             // 운영 체제에서 처리하는 충돌로 처리되는지를 나타내는 값을 가져오거나 설정합니다.
        VS_Player Player;
        Player = new VS_Player();

        do
        {
            Console.WriteLine("1. Vs Com");
            Console.WriteLine("2. Vs Player");
            Console.WriteLine("3. Score");
            Console.WriteLine("Press the Escape (Esc) key to quit: ");

            cki = Console.ReadKey(true);

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

        } while (cki.Key != ConsoleKey.Escape);
    }
}