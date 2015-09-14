using System;

namespace RetoZonas3
{
	public class Zona3
	{
		public double Costo {get;set;}
		public Zona3 (double x)
		{
			Costo = x *0.08;
			Console.WriteLine ("El cargo del producto es: {0} ",Costo);

		}
	}
}

