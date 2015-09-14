using System;

namespace RetoZonas3
{
	public class Zona4
	{
		public double Costo {get;set;}
		public Zona4 (double x)
		{
			Costo = x * 0.04+25;
			Console.WriteLine ("El cargo del producto es: {0} ",Costo);

		}
	}
}

