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
            }
        }
    }
 }



