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

		public static int Run(int runPar1, int runPar2, TwoIntegerOperation twoIntegerOperation)
		{
			return twoIntegerOperation(runPar1, runPar2);
		}		
	}
}
