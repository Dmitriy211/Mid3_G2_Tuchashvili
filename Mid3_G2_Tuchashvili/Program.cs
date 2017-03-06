using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;                                 // ██-██-██-██-██▄
using System.Threading.Tasks;

namespace Mid3_G2_Tuchashvili
{
    class Program
    {
        public static void Move()
        {
            while (true)
            {
                Console.Clear();
                if (y == 3)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(train);
                    x++;
                    Thread.Sleep(100);
                }
                if (x == 30)
                    y++;
                if (y == 4)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(train2);
                    x--;
                    Thread.Sleep(100);
                }
                if (x == 0)
                    y--;

            }
        }


        public static string train, train2;
        public static int x, y;

        static void Main(string[] args)
        {

            train = "██-██-██-██-██▄";
            train2 = "▄██-██-██-██-██";
            x = 0;
            y = 3;

            Thread t = new Thread(new ThreadStart(Move));
            t.Start();

        }
    }
}
