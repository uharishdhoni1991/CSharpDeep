using TechGig.Practice;

namespace TechGig
{
    class Program
    {
        static void Main(string[] args)
        {
            ////C# Skill Test
            //IExecute skillTest = new SkillTest();
            //skillTest.Execute();

            //IExecute skillTest2 = new SkillTest2();
            //skillTest2.Execute();

            //IExecute skillTest3 = new PrimeNoInRange();
            //skillTest3.Execute();

            //IExecute numberTypeResolver = new NumberTypeResolver();			
            //numberTypeResolver.Execute();

            //IExecute secondLargest = new SecondLargestArrayElement();
            //secondLargest.Execute();

            //IExecute matrixAddition = new MatrixAddition();
            //matrixAddition.Execute();

            IExecute rollAMatrix = new RollAMatrix();
            rollAMatrix.Execute();
        }
    }
}
