using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class CountPairInMatrix
    {
        public static void fnCountPairInMatrix1(int[][] mat1, int[][] mat2, int val)
        {
            int n = mat1.Length;
            int i = 0, j = 0;
            int k = n - 1, l = n - 1;
            int count = 0;
            while (true)
            {
                var ele = mat1[i][j] + mat2[k][l];

                if (ele < val)
                {
                    if (j == n - 1)
                    { i++; j = 0; }
                    else
                    { j++; }
                }
                else if (ele > val)
                {
                    if (l == 0)
                    { k--; l = n - 1; }
                    else
                    { l--; }
                }
                else
                {
                    //Console.WriteLine(mat1[i][j] + " : " + mat2[k][l]);

                    count++;
                    if (j == n - 1)
                    { i++; j = 0; }
                    else
                    { j++; }

                    if (l == 0)
                    { k--; l = n - 1; }
                    else
                    { l--; }
                }

                if (i == n - 1 && j == n - 1 && k == 0 && l == 0)
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }

        public static void fnCountPairInMatrix(int[][] mat1, int[][] mat2, int n, int val)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!dict.ContainsKey(mat2[i][j]))
                        dict.Add(mat2[i][j], 1);
                    else
                        dict[mat2[i][j]]++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var ele = val - mat1[i][j];
                    if (dict.ContainsKey(ele))
                    { count += dict[ele]; }
                }
            }

            Console.WriteLine(count);
        }
    }
}
