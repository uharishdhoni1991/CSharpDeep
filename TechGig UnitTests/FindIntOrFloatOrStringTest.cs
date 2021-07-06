using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TechGig.Practice;

namespace TechGig_UnitTests
{
    [TestClass]
    public class FindIntOrFloatOrStringTest
    {        
        [TestMethod]
        public void ValidateForAllInts()
        {
            IExecute executor = new FindIntOrFloatOrString();

            var strWriter = new StringWriter();
            Console.SetOut(strWriter);

            var strReader = new StringReader(Int64.MaxValue.ToString()); //Highest Int
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsInteger, ((FindIntOrFloatOrString)executor).Outputstring);

            strReader = new StringReader(Int64.MinValue.ToString()); //Lowest Int
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsInteger, ((FindIntOrFloatOrString)executor).Outputstring);
        }

        [TestMethod]
        public void ValidateForAllFloats()
        {
            IExecute executor = new FindIntOrFloatOrString();

            var strWriter = new StringWriter();
            Console.SetOut(strWriter);

            var strReader = new StringReader(float.MaxValue.ToString()); //Highest Float
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsFloat, ((FindIntOrFloatOrString)executor).Outputstring);

            strReader = new StringReader(float.MinValue.ToString()); //Lowest Float
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsFloat, ((FindIntOrFloatOrString)executor).Outputstring);
        }

        [TestMethod]
        public void ValidateForSomethingElse()
        {
            IExecute executor = new FindIntOrFloatOrString();

            var strWriter = new StringWriter();
            Console.SetOut(strWriter);

            var strReader = new StringReader("340282356779733661637539395458142568449.0f"); //Highest Float + 1
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsSomethingElse, ((FindIntOrFloatOrString)executor).Outputstring);
        }

        [TestMethod]
        public void ValidateForString()
        {
            IExecute executor = new FindIntOrFloatOrString();

            var strWriter = new StringWriter();
            Console.SetOut(strWriter);

            var strReader = new StringReader("340282356779733661637539395458142568449..0f");
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsString, ((FindIntOrFloatOrString)executor).Outputstring);

            strReader = new StringReader("340282356779733661637539395458142568449.0ff");
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsString, ((FindIntOrFloatOrString)executor).Outputstring);

            strReader = new StringReader("--340282356779733661637539395458142568449.0f");
            Console.SetIn(strReader);
            executor.Execute();

            Assert.AreEqual(((FindIntOrFloatOrString)executor).IsString, ((FindIntOrFloatOrString)executor).Outputstring);
        }
    }
}
