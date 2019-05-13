using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MaximumNumberOfOnes
    {
        public static void fnMaxOneIndex(int[] intArray, int n)
        {
            int[][] arr = new int[n][];
            int k = 0;
            int count = 0;
            int maxIndex = -1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = new int[n];                
                for (int j = 0; j < n; j++)
                {
                    arr[i][j] = intArray[k++];
                }

                int index = BinarySearch(arr[i], 0, n - 1, 1);
                int innerCount = n - index;

                if (innerCount > count)
                {
                    count = innerCount;
                    maxIndex = i;
                }
            }

            Console.WriteLine(maxIndex);
        }

        public static int BinarySearch(int[] arr, int low, int high, int num)
        {
            int mid = (low + high) / 2;

            if (low > high)
                return high + 1;

            if (arr[mid] >= num)
                return BinarySearch(arr, low, mid - 1, num);
            else
                return BinarySearch(arr, mid + 1, high, num);
        }
    }
}
