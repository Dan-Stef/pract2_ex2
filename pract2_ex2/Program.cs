using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract2_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество прошедших дней");
            int n = Convert.ToInt32(Console.ReadLine());
            n = n % 365 / 30;
            switch (n)
            {
               
                case 0: Console.WriteLine("Январь"); break;
                case 1: Console.WriteLine("Февраль"); break;
                case 2: Console.WriteLine("Март"); break;
                case 3: Console.WriteLine("Апрель"); break;
                case 4: Console.WriteLine("Май"); break;
                case 5: Console.WriteLine("Июнь"); break;
                case 6: Console.WriteLine("Июль"); break;
                case 7: Console.WriteLine("Август"); break;
                case 8: Console.WriteLine("Сентябрь"); break;
                case 9: Console.WriteLine("Октябрь"); break;
                case 10: Console.WriteLine("Ноябрь"); break;
                case 11: Console.WriteLine("Декабрь"); break;
                case 12: Console.WriteLine("Декабрь"); break;
            }
            Console.ReadKey();
        }
    }
}
