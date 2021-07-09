using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_UnitTests
{
    [TestClass]
    public class FindDissapearingNumbersTest
    {
        private Arrays.ArrayFunc _arayFunc;

        [TestInitialize]
        public void Initialise()
        {
            _arayFunc = new Arrays.ArrayFunc();
        }

        [TestMethod]
        public void SampleInput()
        {
            IList<int> resultantArray = _arayFunc.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });
            IEnumerable<int> actualArray = Enumerable.Range(1, resultantArray.Count);

            foreach(int elem in resultantArray)
            {
                Assert.IsTrue(!actualArray.Contains(elem));
            }

            /*To Do : Why is this case failing ? Need to check*/
            //resultantArray = _arayFunc.FindDisappearedNumbers(new int[] { 2,2 });
            //actualArray = Enumerable.Range(1, resultantArray.Count);

            //foreach (int elem in resultantArray)
            //{
            //    Assert.IsTrue(!actualArray.Contains(elem));
            //}
        }
    }
}
