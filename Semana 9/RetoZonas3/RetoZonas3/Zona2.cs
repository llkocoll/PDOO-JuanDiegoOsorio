using System;

namespace RetoZonas3
{
	public class Zona2
	{
		public double Costo {get;set;}
		public Zona2 (double x)
		{
			Costo = x *0.12+25;
			Console.WriteLine ("El cargo del producto es: {0} ",Costo);

		}
	}
}

