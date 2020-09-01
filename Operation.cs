using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlatForm
{
	public class Operation
	{
		public delegate int TwoIntegerOperation(int par1, int par2);

		public static int Run(int b1, int b2, TwoIntegerOperation mathOperation)
		{
			return mathOperation(b1, b2);
		}
	}
}
