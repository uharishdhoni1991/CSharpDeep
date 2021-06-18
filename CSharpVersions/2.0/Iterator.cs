using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpVersions._2._0
{
	internal class Iterator : IExecute
	{
		public void Execute()
		{
			Room r = new Room();

			foreach (var chair in r)
				Console.WriteLine(chair.Name);

			Console.ReadKey();
		}
	}

	internal class Room
	{
		private readonly List<Chair> _chairs = new List<Chair>();

		public Room()
		{
			AddChair(1, "Wooden");
			AddChair(2, "Plastic");
		}

		private void AddChair(int id, string name)
		{
			_chairs.Add(new Chair(id, name));
		}

		public IEnumerator<Chair> GetEnumerator()
		{
			var t = _chairs.Select(x => new { Portia = 420 , PortiaNaai = x.Name });

			foreach (var chair in _chairs)
				yield return chair;			
		}
	}

	internal class Chair
	{
		private readonly int _id;
		private readonly string _name;

		public int Id { get { return _id; } }
		public string Name { get { return _name; } }

		public Chair(int id, string name)
		{
			_id = id;
			_name = name;
		}
	}
}
