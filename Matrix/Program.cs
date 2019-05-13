using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //TransposeAMatrix.fnTranspose(new int[] { 1, 2, -9, -2 }, 2);
            //SnakeMatrix.fnSankeMatrix(new int[] { 45, 48, 54, 21, 89, 87, 70, 78, 15 }, 3);
            //MinimumNumberOfOnes.fnMinOneIndex(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }, 5);
            //CountZeroInSortedMatrix.fnCountZeroInSortedMatrix(new int[][] {
            //new int[] { 0, 0, 0, 0, 1},new int[] {0, 0, 0, 1, 1 },
            //    new int[] {0, 1, 1, 1, 1 },new int[] {1, 1, 1, 1, 1 }
            //,new int[] { 1, 1, 1, 1, 1} });

            //SpiralMatrix.fnSpiralMatrix(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 4, 4);

            //SearchInMatrix.fnSearchInMatrix(new int[] { 3, 30, 38, 44, 52, 54, 57, 60, 69 }, 3, 3, 62);
            //int[][] mat1 = new int[][] { new int[]{ 1 ,5 ,6 },
            //    new int[]{8 ,10, 11 },new int[] { 15, 16, 18 } };
            //int[][] mat2 = new int[][] { new int[]{ 2, 4, 7 },
            //    new int[]{9, 10, 12 },new int[] { 13, 16, 20 } };
            //CountPairInMatrix.fnCountPairInMatrix(mat1, mat2, 3, 21);

            //Console.WriteLine(MaximumNumberOfOnes.BinarySearch(new int[] { 0, 1, 1, 1, 1 }, 0, 4, 1));
            MaximumNumberOfOnes.fnMaxOneIndex(new int[] { 0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 4);
            Console.Read();
        }
    }
}
