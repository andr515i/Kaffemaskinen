using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal class CoffeeBeanContainer : Container, ICoffeeContainer
	{
		private int beanCount;

		public int BeanCount
		{
			get { return beanCount; }
			set { beanCount = value; }
		}

		private int totalAllowedBeans;

		public int TotalAllowedBeans
		{
			get { return totalAllowedBeans; }
			set { totalAllowedBeans = value; }
		}

	}
}
