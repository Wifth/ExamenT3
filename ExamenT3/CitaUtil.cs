using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenT3
{
    public class CitaUtil
    {
        public static void Crear(Cita[] citas, ref int cantidad)
        {
            Console.Write("Ingrese el número de cita: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese que enfermedad tiene: ");
            string enfermedad = Console.ReadLine();
            Console.Write("Ingrese el código del estudiante");
            string codigo = Console.ReadLine();
            Console.Write("Ingrese la universidad del estudiante: ");
            string universidad = Console.ReadLine();
            Console.Write("Ingrese el precio de la cita: ");
            int precio = int.Parse(Console.ReadLine());

            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);
            citas[cantidad] = new Cita(n, estudiante, enfermedad, precio);
            cantidad++;
        }
        public static void Lista(Cita[] citas, int cantidad)
        {
            double totalPrecio = 0;

            Console.WriteLine("\nLista de Citas:");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(citas[i].ToString());
                totalPrecio += citas[i].Precio;
            }

            Console.WriteLine($"\nTotal de precios de todas las citas: {totalPrecio:C}");
        }
        public static void Modificar(Cita[] citas, int cantidad)
        {
            Console.Write("Ingrese el texto a buscar en la universidad: ");
            string buscar = Console.ReadLine();

            Console.Write("Ingrese el nuevo texto para reemplazar: ");
            string reemplazo = Console.ReadLine();

            for (int i = 0; i < cantidad; i++)
            {
                if (citas[i].Estudiante.Universidad.Contains(buscar))
                {
                    citas[i].Estudiante.Universidad = citas[i].Estudiante.Universidad.Replace(buscar, reemplazo);
                }
            }
            Console.WriteLine("Modificación realizada exitosamente.");
        }
    }
}
