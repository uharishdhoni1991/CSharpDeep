using System;

namespace CSharpVersions._2._0
{
    public delegate Small covarDel(Big mc);

	public class Small
	{
	}

	public class Big : Small
	{
        
	}

    internal class CoContra : IExecute
    {
        public Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }
        public Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

		public void Execute()
		{
            covarDel del = Method1;

            del(new Big());

            del = Method2;
            del(new Big());

			Console.ReadLine();

        }
	}
}
