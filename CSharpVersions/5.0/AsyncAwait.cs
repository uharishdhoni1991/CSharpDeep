using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CSharpVersions._2._0;

namespace CSharpVersions._5._0
{
	internal class AsyncAwait : IExecute
	{
		public void Execute()
		{
			M1();
			Console.ReadLine();
		}

		private async Task M1()
		{
			//Prepare Coconut chutney
			var grindingTask = PrepareCoconutPaste();
			var oilMustardTask = PrepareOilAndMustard();

			List<Task> chutneyTasks = new List<Task> { grindingTask, oilMustardTask };

			while (chutneyTasks.Any())
			{
				var completedTask = await Task.WhenAny(chutneyTasks);

				if (completedTask == grindingTask)
					Console.WriteLine("Coconut paste is ready");
				if (completedTask == oilMustardTask)
					Console.WriteLine("Oil with Mustard is ready");

				Console.WriteLine("---Pls Wait--");
				chutneyTasks.Remove(completedTask);
			}

			Console.WriteLine("Mix em both and serve");
		}

		private async Task PrepareOilAndMustard()
		{
			Console.WriteLine("Pour oil into Pan and heat it up");
			await Task.Delay(2 * 60 * 1000);

			Console.WriteLine("Drop mustard seeds until it pops out");
			await Task.Delay(30000);
		}

		private async Task<CoconutPaste> PrepareCoconutPaste()
		{
			Console.WriteLine("Grinding coconut in mixie");
			await Task.Delay(2 * 60 * 1000);

			return new CoconutPaste();
		}
	}
}
