using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace subtema4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo = "";
            string carrera = "";
            string bienvenido = "";

            do
            {
                Console.Clear();

                Console.WriteLine("******** MENU DE OPCIONES ********");
                Console.WriteLine("1. Leer codigo de estudiante y carrera");
                Console.WriteLine("2. Formar una nueva etiqueta");
                Console.WriteLine("3. Mostrar longitud de caracteres");
                Console.WriteLine("4. Mostrar primer y ultimo caracter");
                Console.WriteLine("5. Imprimir carrera caracter por caracter");
                Console.WriteLine("6. Crear nueva etiqueta de bienvenida");
                Console.WriteLine("7. Generar correo UPN");
                Console.WriteLine("8. Salir");

                Console.Write("\nSeleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese codigo de estudiante: ");
                        codigo = Console.ReadLine();

                        Console.Write("Carrera: ");
                        carrera = Console.ReadLine();
                        break;

                    case 2:
                        bienvenido = codigo + " | carrera: " + carrera;
                        Console.WriteLine("Etiqueta generada: " + bienvenido);
                        break;

                    case 3:
                        Console.WriteLine("La longitud del codigo es: " + codigo.Length);
                        Console.WriteLine("La longitud de la carrera es: " + carrera.Length);
                        Console.WriteLine("La longitud de la etiqueta es: " + bienvenido.Length);
                        break;

                    case 4:
                        Console.WriteLine("El primer caracter del codigo es: " + codigo[0]);
                        Console.WriteLine("El ultimo caracter del codigo es: " + codigo[codigo.Length - 1]);
                        break;

                    case 5:
                        Console.WriteLine("Carrera caracter por caracter:");

                        for (int i = 0; i < carrera.Length; i++)
                        {
                            Console.WriteLine(carrera[i]);
                        }
                        break;

                    case 6:
                        bienvenido = "Codigo: " + codigo +
                                     " | Carrera: " + carrera +
                                     " - Periodo: 2026-2";

                        Console.WriteLine("Nueva etiqueta de bienvenida: " + bienvenido);
                        break;

                    case 7:
                        Console.Write("ingrese nombres y apellidos: ");
                        string alumno = Console.ReadLine(); 

                        string[] partes = alumno.Split(' ');
                        

                        string primerNombre = partes[0];
                        string iniciales = "";

                        for (int i = partes.Length - 2; i < partes.Length; i++)
                        {
                            iniciales += partes[i].Substring(0, 1); 
                        }

                        Console.WriteLine("correo UPN generado!!!");

                       
                        Console.WriteLine($"{primerNombre}{iniciales}@upn.pe");
                        break;

                    case 8:
                        Console.WriteLine("saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                if (opcion != 8)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 8);
        }
    }
}