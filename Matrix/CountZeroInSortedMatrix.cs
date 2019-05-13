using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class CountZeroInSortedMatrix
    {
        public static void fnCountZeroInSortedMatrix(int[][] intArray)
        {
            int count = 0;
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                if (intArray[i][0] != 0)
                {
                    continue;
                }

                for (int j = 0; j < intArray[i].Length; j++)
                {
                    if (intArray[i][j] != 0)
                        break;

                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
