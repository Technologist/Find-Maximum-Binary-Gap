using MaximumBinaryGap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaximumBinaryGapTests
{
    [TestClass()]
    public class SolutionTests
    {
        

        [TestMethod()]
        public void GetMaxBinGap_Solution1Test()
        {
            //Given
            int N = 0b1110000101001111101;
            int expected = 4;
            //Processing
            int actual = Solution.GetMaxBinGap_Solution1(N);
            //Assertion
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMaxBinGap_Solution2Test()
        {
            //Given
            int N = 0b1110000101001111101;
            int expected = 4;
            //Processing
            int actual = Solution.GetMaxBinGap_Solution2(N);
            //Assertion
            Assert.AreEqual(expected, actual);
        }
    }
}