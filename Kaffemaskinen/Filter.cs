using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal class Filter
	{

		public string? Ingredient { get; set; }

		public Filter()
		{

		}
		public Filter(string ingredient)
		{
			Ingredient = ingredient;
		}
	}
}
