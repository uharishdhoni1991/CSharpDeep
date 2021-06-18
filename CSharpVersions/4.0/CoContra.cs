using System;
using System.Collections.Generic;
using System.Linq;
using CSharpVersions._2._0;

namespace CSharpVersions._4._0
{
	internal class CoContra : IExecute
	{
		public CoContra()
		{
		}

		public void Execute()
		{
			IEnumerable<Shape> shape = new List<Shape>();
			shape = new List<Square>();

			Action<Shape> shapeAction = CheckShape;
			shapeAction(new Shape());
			Action<Square> squareAction = CheckShape;
			squareAction(new Square());
		}

		private void CheckSquare(Square square)
		{
			if (square == null)
				return;

			Console.WriteLine(square.ToString());
		}

		private void CheckShape(Shape shape)
		{
			if (shape == null)
				return;

			Console.WriteLine(shape.ToString());
		}
	}

	internal class Shape
	{
	}

	internal class Square : Shape
	{
	}
}
