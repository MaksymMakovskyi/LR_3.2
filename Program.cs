using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            m2:
            Console.WriteLine(" Введiть для точки М координату X: ");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine(" Введiть для точки М координату Y: ");
            float y = float.Parse((Console.ReadLine()));
            if (y <= 0)
            {
                if (x > 0)
                {
                    N = 2;
                }
                else
                { N = 4; }
            }
            else if (x >= 0)
            {
                if (y >= Math.Pow(x, 1 / 7))
                {
                    N = 4;
                }
                else
                {
                    N = 1;
                }
            }
            else
            {
                N = 3;
            }
            Console.WriteLine('\t' + " Результат:");
            Console.WriteLine(" Точка М(" +x + " ; " +y + ")" + " лежить в областi N = " +N);
            Console.WriteLine('\n' +" Для повторного вводу натиснiть будь-яку клавiшу " +'\n'+ " Для завершення програми натиснiть Enter.");
            string p = Console.ReadLine();
            if (p != "" ) goto m2;
        }
    }
}
