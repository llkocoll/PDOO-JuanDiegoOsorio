using System;

namespace RetoZonas4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string NombreZona = "", Precio1="";
			double Precio = 0;
			Zonas zona = new Zonas ();
			do {

				Console.WriteLine ("Ingrese la zona a la que desea acceder:");
				NombreZona = Console.ReadLine ();
				if (NombreZona == "Zona 1") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						zona.Zona1(Precio);

					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 

				if (NombreZona == "Zona 2") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						zona.Zona2(Precio);

					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 
				if (NombreZona == "Zona 3") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						zona.Zona3(Precio);

					} else {
						Console.WriteLine ("Valor erróneo");
					}

				} 
				if (NombreZona == "Zona 4") {
					Console.WriteLine ("Ingrese el precio del producto:");
					Precio1 = Console.ReadLine ();

					if (double.TryParse (Precio1, out Precio)) {
						zona.Zona4(Precio);

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
