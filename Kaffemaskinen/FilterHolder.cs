using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal class FilterHolder
	{
		public Filter? Filter { get; set; }


		public string ChangeFilter(Filter newFilter)
		{
			Filter = newFilter;

			return "New filter inserted. Remember to throw any used one out!";
		}

	}
}
