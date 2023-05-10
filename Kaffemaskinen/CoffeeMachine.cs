using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	public enum CoffeeStrength {Light, Medium, Strong }
	internal class CoffeeMachine : Machine
	{
		public FilterHolder? FilterHolder { get; set; }
		public WaterContainer? WaterContainer { get; set; }

		public CoffeeBeanContainer? BeanContainer { get; set; }



		public string BrewCoffee()
		{
			GrindCoffeeBeans(beans, CoffeeStrength)
		}
	}
}
