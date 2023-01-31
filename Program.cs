using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 0, 0, 1, 1, 0, 1 };
            Console.WriteLine(Solution(arr));
        }

        public static int Solution(int[] A)
        {
            int zeroCount = 0;
            int pairCount = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    pairCount += zeroCount;
                }
                if (pairCount > 1000000000)
                {
                    pairCount = -1;
                }
            }

            return pairCount;
        }
    }
}
