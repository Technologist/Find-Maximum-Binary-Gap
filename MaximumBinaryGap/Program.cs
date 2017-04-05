using System;

namespace MaximumBinaryGap
{
    internal class Program
    {
        private static void Main()
        {
            int N = 0b11_001000000_1111_00_1_0_111;
            Processing(N);

            N = 0b11_001000_1001_0000000000_10_1_0_111;
            Processing(N);

            Console.ReadLine();
        }

        private static void Processing(int N)
        {
            var binaryValue = Convert.ToString(N, 2);
            var result1 = Solution.GetMaxBinGap_Solution1(N);
            var result2 = Solution.GetMaxBinGap_Solution2(N);

            Console.WriteLine($"Bainary Value : {binaryValue}");
            Console.WriteLine($"Solution 1 Result : {result1}");
            Console.WriteLine($"Solution 2 Result : {result2}");
        }
    }
}
