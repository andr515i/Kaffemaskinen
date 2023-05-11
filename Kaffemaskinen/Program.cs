namespace Kaffemaskinen
{
	internal class Program
	{
		static void Main(string[] args)
		{

			CoffeeMachine cf = new CoffeeMachine(new Filter("Kaffe"));

			Console.WriteLine(cf.TurnOn());
			Console.WriteLine(cf.FillLiquidContainer(100000, "Vand"));
			Console.WriteLine(cf.Brewer.Brew());
			Console.WriteLine(cf.TurnOff() + "\n\n");

			CoffeeMachine cf2 = new CoffeeMachine(new Filter("Te"));
			Console.WriteLine(cf2.TurnOn());
			Console.WriteLine(cf2.FillLiquidContainer(100000, "vand"));
			Console.WriteLine(cf2.Brewer.Brew());
			//cf2.FilterHolder.Filter.Ingredient = "Lars";
			//Console.WriteLine(cf2.Brewer.Brew());
			//cf2.FilterHolder.Filter = new Filter("Tue");  //these dont work, as i dont change Brewer.Ingredient at any point
			//Console.WriteLine(cf2.Brewer.Brew());
			//Console.WriteLine(cf2.FilterHolder.ChangeFilter(new Filter("Emil")));
			//Console.WriteLine(cf2.Brewer.Brew());
			Console.WriteLine(cf2.TurnOff() + "\n\n");

			CoffeeMachine cf3 = new CoffeeMachine(new Filter("Espresso"));
			Console.WriteLine(cf3.TurnOn());
			Console.WriteLine(cf3.FillLiquidContainer(100000, "vand"));
			Console.WriteLine(cf3.Brewer.Brew());
			Console.WriteLine(cf3.TurnOff() + "\n\n");

			Console.Read();
		}
	}
}