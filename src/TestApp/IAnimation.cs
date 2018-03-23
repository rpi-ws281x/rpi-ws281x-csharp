using rpi_ws281x;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
	interface IAnimation
	{
		void Execute(AbortRequest request);
	}
}
