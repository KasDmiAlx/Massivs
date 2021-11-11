using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace многомерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем двумерный массив
            int[,] myArr = new int[4, 5];
            Random ran = new Random();
            //Инициализируем данный массив
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
