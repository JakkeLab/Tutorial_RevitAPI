using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_3_3_ArrayAndList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Park", "Jake", "Mike", "Kim", "Paul" };
            //names[6] = "Melon";
            int[,] nums = new int[,] { { 1, 1 } , { 2, 1 } };
            int[,] nums2 = new int[2, 2] { { 1, 1 }, { 2, 1 } };
            int[,] nums3 = new int[ , ] { { 1, 1, 3, 5 }, { 2, 1, 5, 4 } };
            int[][] nums4 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4, 5 } };
            int[][] nums5 = new int[3][] {new int[3], new int[2], new int[1] };
            nums5[0][0] = 1;
            nums5[0][1] = 2;
            nums5[0][2] = 3;
            nums5[1][0] = 1;
            nums5[1][1] = 2;
            nums5[2][0] = 1;
            List<int> indicies = new List<int>();
            indicies.Add(1);
            indicies[1] = 2;
        }
    }
}
