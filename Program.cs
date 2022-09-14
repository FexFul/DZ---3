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
            Console.WriteLine("Введите число строк матрицы: ");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите число столбцов матрицы: ");
            int y = Int32.Parse(Console.ReadLine());

            long[,] matrix1 = new long [x,y];
            int[,] matrix2 = new int[x,y];
            Random r = new Random();
            Int64 sum = 0;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix1[i,j] = r.Next();
                    matrix2[i,j] = r.Next();
                    sum += matrix1[i,j];
                }
            }

            Console.WriteLine("Первая матрица: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{matrix2[i, j]} ");
                    matrix1[i,j] = matrix1[i,j] + matrix2[i,j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма матриц: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Общая сумма: {sum}");

            Console.ReadLine();
        }
    }
}
