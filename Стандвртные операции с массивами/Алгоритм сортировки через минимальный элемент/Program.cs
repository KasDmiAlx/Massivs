using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алгоритм_сортировки_через_минимальный_элемент
{
    class Program
    {
        const int N_max = 1000000;  // максимальная размерность массива
        static double[] a = new double[N_max];  // объявление массива

        static void Main(string[] args)

        {
            int n = InputA();  // количество элементов и ввод массива
            OutputA("До сортировки", n);  // вывод массива
            MaxSort(n);//
            OutputA("После минимальной сортировки", n);
            BoobleSort(n);
            OutputA("После пузырьковой сортировки", n);
            Console.ReadKey();
        }
                //ввод данных
                static int InputA()
                {
                    int n;
                    Console.Write("Введите кол-во чисел ");
                    n = Convert.ToInt32(Console.ReadLine());
                    for (int i=0;i<n;i++)
                    {
                        Console.Write("a[{0}]=", i);
                        a[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    return n;
                }
                //вывод массива
                static void OutputA(string z,int n)
                {
                    Console.WriteLine(z);
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0:#,#}  ", a[i]); 
                    }
                    Console.WriteLine();
                }
        //сортировка через минимальный элемент по возрастанию
                static void MaxSort(int n)
                {
                    double p;
                    int k;
                    for(int i = 0; i < n - 1; i++)
                    {
                        k=k_min(i + 1, n);
                        if (a[i] > a[k])
                        {
                            p = a[i];
                            a[i] = a[k];
                            a[k] = p;
                        }
                    }
                }
                static int k_min(int j, int n)
                {
                    double min = a[j];
                    int k = j;
                    for (int i = j + 1; i < n; i++)
                    {
                        if (a[i] < min)
                        {
                            min = a[i];
                            k = i;
                        }
                    }
                    return k;
                }
                // Пузырьковая сортировка по убыванию
                static void BoobleSort(int n)
                {
                    double c;
                    for (int i=0;i>0;i--)
                        for(int j = 0; j < i; j++)
                        {
                            if (a[j] < a[j+1])
                            {
                                c = a[j];
                                a[j] = a[j + 1];
                                a[j + 1] = c;
                            }
                        }
            Console.ReadKey();
                }
            }
        }  
