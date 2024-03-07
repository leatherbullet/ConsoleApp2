using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[2, 3];

            int minValue = 1;
            int maxValue = 10;
            int lineSum = 0;
            int columArrayMultiple = 1;
            int lineIndex = 1;
            int columArray = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
            
            for (int i = 0; i < array.GetLength(1); i++)
            {
                lineSum += array[lineIndex, i];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                columArrayMultiple *= array[i, columArray];
            }

            Console.WriteLine($"Сумма строки {lineIndex + 1} равна:{lineSum}\n" +
                $"Произведение солбца {columArray + 1} равен:{columArrayMultiple}");
        }
    }
}
