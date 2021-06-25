using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CSharpVersions._2._0;

namespace CSharpVersions
{
	class Program
	{
		static void Main(string[] args)
		{
            //C#2.0
            //Anonymous Method
            IExecute prep = new AnonymousMethod();
            prep.Execute();

            //Iterators
            IExecute iter = new Iterator();
            iter.Execute();

            //Covariance & Contravariance
            IExecute coContra = new CoContra();
            coContra.Execute();

            //C#4.0
            //CoContra
            IExecute coContra4 = new _4._0.CoContra();
            coContra4.Execute();

            //C# 5.0
            //Async-Await
            IExecute task = new _5._0.AsyncAwait();
            task.Execute();          
		}
	}
}
