using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class SpiralMatrix
    {
        public static void fnSpiralMatrix(int[] intArray, int m, int n)
        {
            int[][] arr = new int[m][];
            int k = 0;

            for (int i = 0; i < m; i++)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = intArray[k++];
                }
            }

            int leftLimit = 0;
            int rightLimit = n;
            int upLimit = 0;
            int downLimit = m;
            int t = 0;
            while (leftLimit < rightLimit && upLimit < downLimit)
            {
                for (t = leftLimit; t < rightLimit; t++)
                {
                    Console.Write(arr[upLimit][t] + " ");
                }
                upLimit++;

                for (t = upLimit; t < downLimit; t++)
                {
                    Console.Write(arr[t][rightLimit - 1] + " ");
                }
                rightLimit--;

                if (upLimit < downLimit)
                {
                    for (t = rightLimit - 1; t >= leftLimit; t--)
                    {
                        Console.Write(arr[downLimit - 1][t] + " ");
                    }
                    downLimit--;
                }

                if (leftLimit < rightLimit)
                {
                    for (t = downLimit - 1; t >= upLimit; t--)
                    {
                        Console.Write(arr[t][leftLimit] + " ");

                    }
                    leftLimit++;
                }
            }

            Console.WriteLine();
        }
    }
}
