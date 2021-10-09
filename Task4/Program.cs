using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //Метод находит квадрат введенного числа
        static void Main(string[] args)
        {
            #region Исходные данные
            Console.WriteLine("Введите целое число >0");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2 = 0;
            #endregion
            if (N < 1 && N % 1 == 0)
            {
                Console.WriteLine("Ошибка! Число должно быть >0");
            }
            for (int i = 1; i < N; i++)
            {
                N2 += i * 2 - 1;
                Console.WriteLine("Квадрат числа равен {0}", N2);
            }
            Console.ReadKey();
        }
    }
}
