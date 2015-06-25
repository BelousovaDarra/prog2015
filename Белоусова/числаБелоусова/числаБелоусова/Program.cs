using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace числаБелоусова
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 min = 0, max = int.MaxValue, x = max / 2, z=0, f=0;
            Console.WriteLine("Загадайте число от 0 до " + max + "\nДля ответов на вопросы используйте команды 1-да 0-нет");

            while (z==0)
            {
                Console.WriteLine("Ваше число меньше " + x + "?");
                if (Console.ReadLine()[0] == '1')
                {
                    max = x;
                    x = max / 2 + min / 2;
                }
                else
                {
                    min = x;
                    x = max / 2 + min / 2;
                  
                }
               
                    x = (max + min) / 2;
                if (x == min)
                {
                    z=1;
                }
            }

            Console.WriteLine("Вы загадали " + x + "?");
            if (Console.ReadLine()[0] == '1')
            {
                Console.WriteLine("Ура!");
            }
            else
            {
                Console.WriteLine("Не возможно");
            }

            Console.ReadKey();






        }
    }
}
