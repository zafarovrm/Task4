using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    //Метод находит количество квадратов, размещенных на прямоугольнике
    class Program
    {
        static void Main(string[] args)
        {
            #region Исходные данные
            Console.WriteLine("Введите значение A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C");
            int c = Convert.ToInt32(Console.ReadLine());
            int vert = 0;
            int horz = 0;
            int count = 0;
            int i = 0;//Количество столбцов
            #endregion
            // Количество квадратов по вертикали
            while (a >= c)
            {
                a -= c;
                vert++;
            }
            // Количество квадратов по горизонтали
            while (b >= c)
            {
                b -= c;
                horz++;
            }
            // Общее количество квадратов
            while (i < vert)
            {
                i++;
                count += horz;
            }

            Console.WriteLine("Количество квадратов {0}", count);
            Console.ReadKey();
        }
    }
}
