using System;

namespace Eventos
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int Dinero = 0, DineroMeta=0;
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
			Contador c = new Contador (DineroMeta);		


			c.EventoMeta += MetaAlcanzada;
			c.EventoAbono += Abono;
			do {
				Console.WriteLine ("Ingrese cuánto dinero quiere depositar:");
				Dinero1 = Console.ReadLine ();
				if (int.TryParse (Dinero1, out Dinero))
				{
				c.Agregar (Dinero);
				}
			} while (int.TryParse (Dinero1, out Dinero));
		}
		static void Abono (object x, EventoAbonoArg e)
		{
			Console.WriteLine ("Lleva {0} ahorrados", e.Acumulado);
		}

		static void MetaAlcanzada (object x, EventoMetaArg e)
		{
			Console.WriteLine ("La meta de {0} ha sido alcanzada!", e.MetaObjetivo);
			Environment.Exit (0);
		}
	}
	class Contador
	{
		private int Meta;
		private int Total;
		public Contador (int MetaEntregada)
		{
			Meta = MetaEntregada;
		}
		public void Agregar (int x)
		{
			Total = Total + x;
			EventoAbonoArg AbonoArg = new EventoAbonoArg ();
			AbonoArg.Acumulado = Total;
			OnEventoAbono (AbonoArg);
			if (Total >= Meta) 
			{
				EventoMetaArg MetaArg = new EventoMetaArg();
				MetaArg.MetaObjetivo = Meta;
				OnEventoMeta (MetaArg);
			}

			
		}
		protected virtual void OnEventoMeta (EventoMetaArg e)
		{
			if (EventoMeta != null)
			{
				EventoMeta(this, e);
			}
		}

		protected virtual void OnEventoAbono (EventoAbonoArg e)
			{
				if (EventoAbono != null)
				{
				EventoAbono(this, e);
				}
			}

		public event EventHandler<EventoMetaArg> EventoMeta;
		public event EventHandler<EventoAbonoArg> EventoAbono;

	}

	public class EventoAbonoArg : EventArgs
	{
		public int Acumulado { get; set;}
	}

	public class EventoMetaArg : EventArgs
	{
		public int MetaObjetivo { get; set;}
	}
}
