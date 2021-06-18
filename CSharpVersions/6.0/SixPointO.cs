using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpVersions._6._0
{
	internal class SixPointO
	{
		//8 Features
		//Auto Property Initialisers
		internal int AutoProperty { get; set; } = 12;

		internal Dictionary<int, int> _dictionaryInitialiser = new Dictionary<int, int>()
		{
			[1] = 5
		};

		internal SixPointO(int nameOfParam)
		{
			//NameOf Param
			if (nameOfParam == 0)
				throw new ArgumentNullException(nameof(nameOfParam));

			Features();
		}
		void Features()
		{
			//Using Static Feature
			WriteLine("Using static feature");

			//Dictionary Initialiser
			_dictionaryInitialiser[0] = 5;

			//Exception Filters
			try
			{
				_dictionaryInitialiser = null;
				_dictionaryInitialiser[1] = 10;
			}
			catch (Exception ex) when (AutoProperty != 12)
			{
				if (ex != null)
				{
					Console.WriteLine(ex.Message);
				}
			}

			//NullConditional Operator
			_dictionaryInitialiser?.Add(1, 1);

			//string interpolation
			int? interpolationInput = null;
			string stringInterpolated = $"{interpolationInput} -- Might be empty";
			Console.WriteLine(stringInterpolated);
		}

		async void AwaitFeature()
		{
			try
			{
				int val = 0;
				var val1 = val / 0;

				if (val1 == 0)
					throw new ArgumentException(val.ToString());
			}
			catch (Exception ex)
			{
				await HandleCatch(ex);
			}
		}

		
		//Expression Bodies methods
		private async Task HandleCatch(Exception ex) => throw new NotImplementedException();
	}
}
