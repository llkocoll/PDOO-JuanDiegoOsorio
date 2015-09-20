using System;

namespace Lambdas
{
	public delegate int DelAbono (int y);
	public delegate int DelMeta (int y);

	class MainClass
	{
		public static void Main (string[] args)
		{
			int Dinero = 0, DineroMeta=0, Total=0;
			string Dinero1 = "", DineroMeta1="";

			do 
			{
				Console.WriteLine ("Ingrese la meta de ahorro que desea alcanzar:");
				DineroMeta1 = Console.ReadLine ();
				if(!int.TryParse (DineroMeta1, out DineroMeta))
				{
					Console.WriteLine ("Valor erróneo");
				}

			} 
			while (!int.TryParse (DineroMeta1, out DineroMeta)); 
				


			do {
				Console.WriteLine ("Ingrese cuánto dinero quiere depositar:");
				Dinero1 = Console.ReadLine ();
				if (int.TryParse (Dinero1, out Dinero))
				{
					
					Total = Total + Dinero;
					DelAbono DAbono = (y) => y; 
					Console.WriteLine ("Lleva {0} ahorrados",DAbono(Total)); 
					if (Total >= DineroMeta) 
					{
						DelMeta DMeta = (y) => y;
						Console.WriteLine ("La meta de {0} ha sido alcanzada!", DMeta (DineroMeta));
						Environment.Exit (0);
					}
				}
			} while (int.TryParse (Dinero1, out Dinero));
		}

	}



}
