//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace tictactoe_16
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            String str;
//            int n;
//            int[,] arr;
//            arr = new int[10];
//            Random r = new Random();
//            r.Next(25);

//            List<int> list = new List<int>();
//            ArrayList arrayList = new ArrayList(); // 연결리스트

//            Console.Clear(); //콘솔창 화면을 지워주는 Console Class의 메서드
//            Console.WriteLine("Console.WirteLine은 개행한 후에 출력");
//            Console.Write("Console.Wirte은 개행이 포함이 안됨");
//            Console.WriteLine("Console.WirteLine은 개행한 후에 출력");
//            Console.Write("Input : ");

//            str = Console.ReadLine();
//            /*
//            C#은 Console.ReadLine()을 통해 입력을 받는다. 
//            반환 값은 String
//            */

//            Console.WriteLine(str);
//            n = Convert.ToInt32(str); // Convert Class 를 이용해 int 타입의 변수 n에 값을 복사
//            n += 1;
//            Console.WriteLine(n);


//            Console.ReadKey(true);
//            Console.Clear(); //콘솔창 화면을 지워주는 Console Class의 메서드
//            Console.WriteLine("List, ArrayList");



//            list.Add(1);
//            list.Add(2);
//            list.Add(3);

//            foreach (int i in list)
//            {
//                Console.WriteLine(i);
//            }

//            arrayList.Add("ABC");
//            arrayList.Add(999);
//            arrayList.Add("XYZ");

//            foreach (var i in arrayList)
//            {
//                Console.WriteLine(i);
//            }

//            Console.ReadKey(true);
//            Console.Clear(); //콘솔창 화면을 지워주는 Console Class의 메서드

//        }
//    }
//}
