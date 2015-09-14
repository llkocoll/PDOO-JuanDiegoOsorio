using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = "";
            int n = 0;
            string[] dias = new string[8] {"x","Domingo","Lunes","Martes","Miércoles","Jueves","Viernes","Sábado" };

            Console.WriteLine("Ingrese un número del 1 al 7:");
            n1 = Console.ReadLine();

            if (int.TryParse(n1, out n))
                {
                    Console.WriteLine("El día de la semana es: " + dias[n]);
                }
            else
            {
                Console.WriteLine("Valor erróneo.");
            }

            Console.ReadKey();

                
        }
    }
}
