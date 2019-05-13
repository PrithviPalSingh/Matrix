using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MinimumNumberOfOnes
    {
        public static void fnMinOneIndex(int[] intArray, int n)
        {
            int[][] arr = new int[n][];
            int k = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = intArray[k++];
                    if (arr[i][j] == 1)
                        if (!dict.ContainsKey(i))
                            dict.Add(i, 1);
                        else
                            dict[i]++;
                }
            }

            int min = int.MaxValue;
            int minIndex = -1;
            foreach (var item in dict)
            {
                if (item.Value < min)
                {
                    min = item.Value;
                    minIndex = item.Key;
                }
            }

            Console.WriteLine(minIndex);

        }

        public static void fnMinOneIndex1(int[] intArray, int n)
        {
            int[][] arr = new int[n][];
            int k = 0;

            int min = int.MaxValue;
            int minIndex = -1;


            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];
                int innerMin = 0;
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = intArray[k++];
                    if (arr[i][j] == 1)
                    {
                        innerMin++;
                    }
                }

                if (innerMin < min)
                {
                    min = innerMin;
                    minIndex = i;
                }
            }


            Console.WriteLine(minIndex);

        }
    }
}
