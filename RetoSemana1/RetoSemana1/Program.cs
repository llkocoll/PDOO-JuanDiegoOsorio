using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoSemana1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string x1 = "";

            Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
            x1 = Console.ReadLine();

            do
            {
                if (x1 == "byte") 
                {
                    Console.WriteLine("El tamaño en bits es de 8 y su rango es de 0 a 255");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "sbyte")
                {
                    Console.WriteLine("El tamaño en bits es de 8 y su rango es de -128 a 127");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "int" || x1=="int32")
                {
                    Console.WriteLine("El tamaño en bits es de 32 y su rango es de -2,147,483,648 a 2,147,483,647");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "uint" || x1 == "uint32")
                {
                    Console.WriteLine("El tamaño en bits es de 32 y su rango es de 0 a 4294967295");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "short" || x1 == "int16")
                {
                    Console.WriteLine("El tamaño en bits es de 16 y su rango es de -32,768 a 32,767");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "ushort" || x1 == "uint16")
                {
                    Console.WriteLine("El tamaño en bits es de 16 y su rango es de 0 a 65535");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "long" || x1 == "int64")
                {
                    Console.WriteLine("El tamaño en bits es de 64 y su rango es de -9223372036854775808 a 9223372036854775807");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "ulong" || x1 == "uint64")
                {
                    Console.WriteLine("El tamaño en bits es de 64 y su rango es de 0 a 18446744073709551615");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "float" || x1 == "single")
                {
                    Console.WriteLine("El tamaño en bits es de 32 y su rango es de -3.402823e38 a 3.402823e38");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "double")
                {
                    Console.WriteLine("El tamaño en bits es de 64 y su rango es de -1.79769313486232e308 a 1.79769313486232e308");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "char")
                {
                    Console.WriteLine("El tamaño en bits es de 16 y su rango es de símbolos unicódigo usados en texto");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "bool" || x1 == "boolean")
                {
                    Console.WriteLine("El tamaño en bits es de 8 y su rango es de falso o verdadero");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "object")
                {
                    Console.WriteLine("Es una base tipo de todos los otros tipos");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "string")
                {
                    Console.WriteLine("Es una secuencia de caracteres");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

                if (x1 == "decimal")
                {
                    Console.WriteLine("El tamaño en bits es de 128 y su rango es de ±1.0 x 10e-28 a ±7.9 x 10e28");
                    Console.ReadKey();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el tipo de dato sobre el cuál desea información, escriba salir si desea cerrar el programa");
                    x1 = Console.ReadLine();
                }

             

                
            }
            while (x1 != "salir");

            
        }
    }
}
