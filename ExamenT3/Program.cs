// See https://aka.ms/new-console-template for more information
using ExamenT3;

int CantidadCitas;
byte opcion;
string regresar;
CitaUtil c = new CitaUtil();
Cita[] citas = new Cita[10];

do
{
    Console.WriteLine("************ MENÚ *************");
    Console.WriteLine("     * 1. Crear      *");
    Console.WriteLine("     * 2. Lista      *");
    Console.WriteLine("     * 3. Modificar  *");
    Console.WriteLine("     * 0. Salir      *");
    Console.WriteLine("*******************************\n");

    Console.Write("Ingrese opción: ");

    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {
        Console.Write("Error: Ingrese opción: ");
    }

    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1: c.Crear(citas, CantidadCitas); break;
        case 2: c.lista(citas, CantidadCitas); break;
        case 3: c.Modificar(citas, CantidadCitas); break;
    }
    Console.Write("\nDesea regresar al menú? [si]: ");
    regresar = Console.ReadLine().ToLower();
    Console.Clear();
} while (regresar == "si");