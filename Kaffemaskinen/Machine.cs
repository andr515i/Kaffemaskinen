using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
	internal abstract class Machine
	{
		public bool TurnedOn { get; protected set; } = false;

	
		public virtual string TurnOn()
		{
			if (TurnedOn)
			{
				return "Machine already turned on";
			}
			else
			{
				TurnedOn = true;
				return "Machine turning on";
			}
		}
		public virtual string TurnOff()
		{
			if (!TurnedOn)
			{
				return "Machine already turned off";
			}
			else
			{
				TurnedOn = false;
				return "Machine turning off";
			}
		}

	}
}
