using System;

namespace TechGig.Practice
{
    internal class SICalculation : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("SI");

            Double principal = Double.Parse(Console.ReadLine());
            int interest = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            if (principal < 0 || principal > 1000 || interest < 0 || interest > 1000 || years < 0 || years > 1000)
                return;

            int simpleinterest = Convert.ToInt32(Math.Round((principal * interest * years) / 100));
            Console.WriteLine(simpleinterest);
        }
    }
}