using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    class Program
    {
        //Метод находит каких чисел больше положительных или отрицательных
        static void Main(string[] args)
        {
            #region Исходные данные
            Console.WriteLine("Введите последовательность целых чисел");
            int plus = 0;
            int minus = 0;
            int n = 0;
            #endregion
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    plus++;
                }
                if (n < 0)
                {
                    minus++;
                }
            } while (n != 0);
            {
                Console.WriteLine("Количество положительных чисел {0}, Количество отрицательных чисел {1}", plus, minus);
            }
            Console.ReadKey();
        }
    }
}
