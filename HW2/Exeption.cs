using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Exep
    {

        public int CheckExeption() 
        {
            int n;
            while (true)
            {
                var tmp = Console.ReadLine();
                if (int.TryParse(tmp, out n))
                {
                    return n;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите число!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }

        }

        public int CheckExeption(int n)
        {
            // int n;
            while (true)
            {
                var tmp = Console.ReadLine();
                if (int.TryParse(tmp, out n))
                {
                    return n;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введите число!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }
    }
}
