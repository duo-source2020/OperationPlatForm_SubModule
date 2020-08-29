using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlatForm
{
	public class Operation
	{
		//declare delegate
		//public delegate int IntegerOperation(int par1, int par2);

		//public static int Run(int b1, int b2, IntegerOperation mathOperation)
		public static int Run(int b1, int b2, Func<int, int, int> mathOperation)
		{
			Predicate<int> isOk = GreaterThan;

			Console.WriteLine(isOk(b1));

			return mathOperation(b1, b2);
		}

		public static bool GreaterThan(int x)
		{
			return x> 0; 
		}
	}
}
