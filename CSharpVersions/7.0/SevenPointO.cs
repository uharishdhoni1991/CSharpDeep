using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpVersions._7._0
{
    internal class SevenPointO
	{
		public SevenPointO()
		{
			Features();
		}

		private void Features()
		{
			TuplesAndDiscards();
			PatternMatching();
			//Async Main
			LocalFunctions();
		}

		private void LocalFunctions()
		{
			CheckThis();

			void CheckThis()
			{
				if(this == null)
				{
					Console.WriteLine("");
				}

			}
		}

		private int PatternMatching()
		{			
			int sum = 0;
			List<object> sequence = new List<object>();
			foreach (var i in sequence)
			{
				switch (i)
				{
					case 0:
						break;
					case IEnumerable<int> childSequence:
						{
							foreach (var item in childSequence)
								sum += (item > 0) ? item : 0;
							break;
						}
					case int n when n > 0:
						sum += n;
						break;
					case null:
						Console.Write("Null found in sequence");
						break;
					default:
						throw new InvalidOperationException("Unrecognized type");
				}
			}
			return sum;			
		}

		private (int,int,int) TuplesAndDiscards()
		{
			int length = 5;
			int breadth = 5;
			int height = 5;

			return (length, breadth, height);
		}

	    static async Task<int> Main()
		{
			return await DoAsyncOperation();
		}

		private static Task<int> DoAsyncOperation()
		{
			return null;
		}
	}
}
