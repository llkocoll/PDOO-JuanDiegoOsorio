using System;

namespace RetoZonas
{
	class MainClass
	{
		public delegate void ZonasDelegate (double x);
		public  void Z1(double x)
		{
			x=x*0.25;
			Console.WriteLine ("El cargo del producto es {0}",x );
		}
		public static void Z2(double x)
		{
			x=x*0.12+25;
			Console.WriteLine ("El cargo del producto es {0}",x );
		}
		public static void Z3(double x)
		{
			x=x*0.08;
			Console.WriteLine ("El cargo del proucto es {0}",x );
		}

		public static void Z4(double x)
		{
			x=x*0.04 + 25;
			Console.WriteLine ("El cargo del producto es {0}",x );
		}

		public static void Main (string[] args)
		{
			MainClass y = new MainClass();
			ZonasDelegate a;

			string NombreZona = "", Precio1="";
			double Precio = 0;
			do {
					
				Console.WriteLine ("Ingrese la zona a la que desea acceder:");
				NombreZona = Console.ReadLine ();
				if (NombreZona == "Zona 1") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						a = new ZonasDelegate (y.Z1);
						a (Precio);
					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 

				if (NombreZona == "Zona 2") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						a = new ZonasDelegate (Z2);
						a (Precio);
					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 
				if (NombreZona == "Zona 3") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						a = new ZonasDelegate (Z3);
						a (Precio);
					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 
				if (NombreZona == "Zona 4") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						a = new ZonasDelegate (Z4);
						a (Precio);
					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 


				Console.ReadKey ();
			} while ((NombreZona == "Zona 1") || (NombreZona == "Zona 2") || (NombreZona == "Zona 3") || (NombreZona == "Zona 4"));

			if ((NombreZona != "Zona 1") || (NombreZona != "Zona 2") || (NombreZona != "Zona 3") || (NombreZona != "Zona 4"))
			{
				Console.WriteLine ("Esta zona no existe");
			}
				
		}
	}
}
