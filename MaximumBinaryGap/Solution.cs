using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaximumBinaryGap
{
    public class Solution
    {
        

        public static int GetMaxBinGap_Solution1(int N)
        {
            var gap = Convert.ToString(N, 2);
            var s = gap.Split('1');
            return s.Select(element => element.Length).Concat(new[] {0}).Max();
        }

        public static int GetMaxBinGap_Solution2(int N)
        {
            var gap = Convert.ToString(N, 2);
            var n = 0;
            for (var i = 0; i < gap.Length; i++)
            {
                string input = gap.Substring(i, gap.Length - i);
                Match match = Regex.Match(input, @"1([0\-]+)1");
                if (match.Success)
                {
                    int key = match.Groups[1].Value.Length;
                    if (key > n) n = key;
                }
            }
            return n;
        }

    }
}
