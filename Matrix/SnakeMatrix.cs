using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class SnakeMatrix
    {
        public static void fnSankeMatrix(int[] intArray, int n)
        {
            int[][] arr = new int[n][];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = intArray[k++];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                        Console.Write(arr[i][j] + " ");
                    else
                        Console.Write(arr[i][n - 1 - j] + " ");
                }
            }

            Console.WriteLine();

        }
    }
}
