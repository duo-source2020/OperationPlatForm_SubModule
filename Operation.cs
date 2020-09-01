using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlatForm
{
	public class Operation
	{
		public static int Run(int b1, int b2, Func<int, int, int> mathOperation)
		{
			return mathOperation(b1, b2);
		}
	}
}
