using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bosscoder_Tests
{
    public static class Helpers
    {
        public static void CheckMatrixEquality(int[][] expected, int[][] actual)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }
    }
}
