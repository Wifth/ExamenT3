using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenT3
{
    public class CitaUtil
    {
        static void Crear()
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
        }
        static void Lista()
        {

        }
        static void Modificar()
        {

        }
    }
}
