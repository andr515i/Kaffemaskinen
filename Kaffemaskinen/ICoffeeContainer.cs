using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal interface ICoffeeContainer
	{
		public int BeanCount { get; protected set; }

		public int TotalAllowedBeans { get; set; }
	}
}
