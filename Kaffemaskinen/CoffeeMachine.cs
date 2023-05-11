using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal class CoffeeMachine : Machine
	{
		public FilterHolder FilterHolder { get; set; } = new FilterHolder();

		

		public Brewer Brewer { get; set; } = new Brewer();

		public string? LiquidContained { get; set; }


		public CoffeeMachine(Filter filter)
		{
			FilterHolder.Filter = filter;
			Brewer.Beverage = filter.Ingredient;
			
		}


		public string FillLiquidContainer(int fillLiquidAmount, string liquidType)
		{
			Brewer.Liquid += fillLiquidAmount;
			LiquidContained = liquidType;
			return $"loading {fillLiquidAmount} ml's of {liquidType} into liquid storage";
		}

		public string RemoveLiquid(int removeLiquidAmount)
		{
			Brewer.Liquid -= removeLiquidAmount;
			return $"Removed {removeLiquidAmount} ml's from the liquid storage";
		}
	}
}
