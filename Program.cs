using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ___4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Subject 1

            Console.WriteLine("Введите число строк матрицы: ");
            int x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите число столбцов матрицы: ");
            int y1 = Int32.Parse(Console.ReadLine());

            int[,] matrix1 = new int[x1,y1];
            Random r = new Random();
            Int64 sum = 0;

            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < y1; j++)
                {
                    matrix1[i,j] = r.Next();
                    sum += matrix1[i,j];
                }
            }

            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < y1; j++)
                {
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Общая сумма: {sum}");

            Console.ReadLine();
            #endregion

            #region Subject 2



            #endregion
        }
    }
}
