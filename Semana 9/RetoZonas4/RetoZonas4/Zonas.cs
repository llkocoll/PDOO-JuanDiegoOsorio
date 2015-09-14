using System;

namespace RetoZonas4
{
	public class Zonas
	{
		public Zonas ()
		{
		}
		public double Costo {get;set;}
		public void Zona1(double x)
		{
			Costo = x * 0.25;
			Console.WriteLine ("El cargo de envío es de: {0}", Costo);
		}
		public void Zona2(double x)
		{
			Costo = x * 0.12+25;
			Console.WriteLine ("El cargo de envío es de: {0}", Costo);
		}
		public void Zona3(double x)
		{
			Costo = x * 0.08;
			Console.WriteLine ("El cargo de envío es de: {0}", Costo);
		}
		public void Zona4(double x)
		{
			Costo = x * 0.04+25;
			Console.WriteLine ("El cargo de envío es de: {0}", Costo);
		}
	}
}

