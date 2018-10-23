using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            array1[0] = 8;
            int[] array2 = new int [15] { 1, 2, 3, 8, 10, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            int[,] matrix1 = new int[4, 5];
            matrix1[2, 3] = 5;
            int[,] matrix2 = { { 1, 2, 0 }, { 2, 3, 5 } };

            int[][] arrayOfArrays = new int[3][];
            for(int i = 0; i < arrayOfArrays.Length; ++i)
            {
                arrayOfArrays[i] = new int[i + 1];
            }
            Console.WriteLine(arrayOfArrays[2][1]);
            Console.WriteLine(arrayOfArrays[1].Length);
            int[][] aoa =
            {
                new int[] {1 },
                new int[] {1, 2, 3, 4, 5 }
            };



        }
    }
}
