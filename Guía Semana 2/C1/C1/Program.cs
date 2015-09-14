using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = 0, r = 0, a = 0, h = 0;
            string r1 = "", h1 = "";

            Console.WriteLine("Ingrese el radio del cilindro:");
            r1 = Console.ReadLine();

            Console.WriteLine("Ingrese la altura del cilindro:");
            h1 = Console.ReadLine();

            if (double.TryParse(r1, out r))
            {
                if (double.TryParse(h1, out h))
                {
                    a = 2 * Math.PI * r * h;
                    v = Math.PI * (r * r) * h;

                    Console.WriteLine("El área del cilindro es: " + a);
                    Console.WriteLine("El volumen del cilindro es: " + v);
                }
                else
                {
                    Console.WriteLine("Valor erróneo");
                }
            }
            else
            {
                Console.WriteLine("Valor erróneo");
            }


            Console.ReadKey();
        }
    }
}
