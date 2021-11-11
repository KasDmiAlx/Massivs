using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стандвртные_операции_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявление массива.
            int[] num = { 4, -5, 2, 0, 23 };
            //Выводим массив.
            foreach (int i in num)
            {
                Console.WriteLine(i.ToString());
            }
            //Переворачиваем массив.
            Console.WriteLine("Перевернутый массив");
            Array.Reverse(num);
            foreach (int i in num)
            {
                Console.WriteLine(i.ToString());
            }
            //Сортируем массив.
            Array.Sort(num);
            Console.WriteLine("Отсортированный массив");
            foreach (int i in num)
            {
                Console.WriteLine(i.ToString());
            }
            //Обнуляем массив.
             Array.Clear(num, 0, 5);
            Console.WriteLine("Обнуленный массив");
            foreach (int i in num)
            {
                Console.WriteLine(i.ToString());
                Console.ReadKey();
            }

        }

    }

}
     
