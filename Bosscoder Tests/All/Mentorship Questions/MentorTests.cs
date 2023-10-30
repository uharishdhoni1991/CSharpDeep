using Bosscoder.Mentorship;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bosscoder_Tests.All.Mentorship_Questions
{
    [TestClass]
    public class MentorTests
    {
        [TestMethod]
        public void TwoSumTest()
        {
            TwoSum ts = new TwoSum();            

            int[] expected = new int[] { 1, 2 };
            int[] actual = ts.GetTwoSum(new int[] { 3, 2, 4 }, 6);

            CollectionAssert.AreEqual(expected, actual);

            //expected = new int[] { 0, 1 };
            //actual = ts.GetTwoSum(new int[] { 3, 3 }, 6);

            //CollectionAssert.AreEqual(expected, actual);            
        }
    }
}
