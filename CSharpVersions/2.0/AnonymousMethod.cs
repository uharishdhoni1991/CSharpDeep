using System;

namespace CSharpVersions._2._0
{
	delegate void Evaluate(int item);
	public class AnonymousMethod : IExecute
	{
		private void CheckOdd(int item)
		{
			if (item % 2 == 0)
				return;

			Console.WriteLine("Odd");
		}

		private void CheckEven(int item)
		{
			if (item % 2 != 0)
				return;

			Console.WriteLine("Even");
		}

		public void Execute()
		{
			Evaluate ev = delegate (int item)
			{
				Console.WriteLine(item);
			};
			ev(10);

			ev = new Evaluate(CheckOdd);
			ev(10);

			ev = new Evaluate(CheckEven);
			ev(10);

			Console.ReadKey();
		}

	}
}
