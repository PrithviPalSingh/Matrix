using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class SearchInMatrix
    {
        public static void fnSearchInMatrix1(int[] intArray, int m, int n, int num)
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

            int found = 0;

            for (int i = 0; i < m; i++)
            {
                if (arr[i][0] > num)
                    break;

                for (int j = 0; j < n; j++)
                {
                    if (arr[i][j] > num)
                        break;

                    if (arr[i][j] == num)
                    {
                        found = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(found);
        }

        public static void fnSearchInMatrix(int[] intArray, int m, int n, int num)
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

            int found = 0;
            int r = 0, c = n - 1;
            while (r < m && c >= 0)
            {
                var item = arr[r][c];
                if (item == num)
                {
                    found = 1;
                    break;
                }

                if (item < num)
                {
                    r++;
                }

                if (item > num)
                {
                    c--;
                }
            }

            Console.WriteLine(found);
        }
    }
}
