using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cadena = new int[9] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            
            Console.WriteLine("El valor mínimo es: "+cadena.Min());
            Console.WriteLine("El valor máximo es: " + cadena.Max());
            Console.ReadKey();
        }
    }
}
