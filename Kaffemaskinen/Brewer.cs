using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal class Brewer
	{

		public string? Beverage { get; set; }

		public int Liquid { get; set; }

		public string Brew()
		{
			if (Liquid > 100)
			{
				Liquid -= 100;
				if (Beverage == null)
				{
					return "Brewing 1 cup of tasteless, bland and boring hot water................ finished brewing.";
				}
				return $"brewing 1 cup of {Beverage}. . . finished brewing. ";
			}
			return "not enough liquid, plis fill up :=)";
		}

	}
}
