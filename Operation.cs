using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationPlatForm
{
	public class Operation
	{
		public static int Run(int runPar1, int runPar2, Func<int, int, int> twoIntegerOperation)
		{
			return twoIntegerOperation(runPar1, runPar2);
		}		
	}
}
