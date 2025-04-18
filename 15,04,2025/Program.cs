using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_04_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = new int[3, 3];
            //Random random = new Random();
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrix[i, j] = random.Next(1,9);
            //    }
            //    }
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();  // Переход на новую строку



             /* 
             //1
             int[,] matrix3 = {{1, 2, 3 },
                               {4, 5, 6},
                               {7, 8, 9}
                              };
             for (int i = 0; i < matrix3.GetLength(0); i++)//перебор строк
             {
                for (int j = 0; j < matrix3.GetLength(1); j++)//перебор столбцов
             {
                Console.Write(matrix3[i, j] + " ");//вывод массива через пробел
             }
             Console.WriteLine();
             }
             

             int[,] matrix = {{1, 2, 3, 4},
                              {5, 6, 7, 8},
                              {9, 10, 11, 12 },
                              {13, 14, 15, 16},
                             };
             for (int i = 0; i < matrix.GetLength(0); i++)
             {
                 for (int j = 0; j < matrix.GetLength(1); j++)
                 {
                     Console.Write(Math.Pow(matrix[i, j], 2) + " ");
                 }
                 Console.WriteLine();
             }
              */

           //2
           int[,] matrix1 = {{1, 2, 3, 4},
                             {5, 6, 7, 8},
                             {9, 10, 11, 12},
                             {13, 14, 15, 16}
                            };
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
                            */



            //3
            /*
            int[,] matrix3 = {{1, 2, 3 },
                               {4, 5, 6},
                               {7, 8, 9}
                              };
            int sum = 0; 
            for (int i = 0; i < matrix3.GetLength(0); i++)//перебор строк
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)//перебор столбцов
                {
                    Console.Write(matrix3[i, j] + " ");//вывод массива через пробел
                    sum += matrix3[i, j]; 
                }
                Console.WriteLine();
            }
            Console.WriteLine("сумма всех элементов: " + sum);
            */


            //v2
            /*
                        Console.Write("Введите кол-во строк: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Введите кол-во столбцов: ");
                        int b = int.Parse(Console.ReadLine());
                        int[,] matrix = new int[a, b];
                        int sum = 0;
                        Console.WriteLine("Введите элементы массива через пробел: ");
                        for (int i = 0; i < a; i++)
                        {
                            string[] input = Console.ReadLine().Split(' ');
                            for (int j = 0; j < b; j++)
                            {
                                matrix[i, j] = int.Parse(input[j]);
                                sum += matrix[i, j];
                            }
                        }

                        Console.WriteLine("Сумма всех элементов массива: " + sum);
            */









            //4
            /*
            int[,] a = { { 1, 2, 3 },
                 { 4, 5, 6 },
                 { 7, 8, 9 },};
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++) // строки
            {
                for (int j = 0; j < a.GetLength(1); j++) // столбцы
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            Console.WriteLine("максимальный элемент массива" + max);
            */


            //6
            /*
            Console.Write("Введите количество строк: ");
            int kolvo = int.Parse(Console.ReadLine());
            int[][] mass = new int[kolvo][];
            int count = 1;
            for (int i = 0; i < kolvo; i++)
            {
                mass[i] = new int[i + 1];
                for (int j = 0; j < mass[i].Length; j++)
                {
                    mass[i][j] = count++;
                }
            }

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    Console.Write($"{mass[i][j]} \t");
                }
                Console.WriteLine();
                */
            }
        }
    }
}

          



