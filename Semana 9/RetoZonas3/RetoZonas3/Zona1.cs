using System;

namespace RetoZonas3
{
	public class Zona1
	{
		public double Costo {get;set;}
		public Zona1 (double x)
		{
			Costo = x * 0.25;
			Console.WriteLine ("El cargo del producto es: {0} ",Costo);

		}


	}
}

