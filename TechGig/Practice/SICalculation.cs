using System;

namespace TechGig.Practice
{
    internal class SICalculation : IExecute
    {
        public void Execute()
        {
            double principal = default(double);
            int interest = 0;
            int years = 0;

            bool prin = Double.TryParse(Console.ReadLine(), out principal);
            bool inte = int.TryParse(Console.ReadLine(), out interest);
            bool yr = int.TryParse(Console.ReadLine(), out years);

            if (!(prin && inte && yr))
                return;

            int simpleinterest = Convert.ToInt32(Math.Round((principal * interest * years) / 100));
            Console.WriteLine(simpleinterest);
        }
    }
}