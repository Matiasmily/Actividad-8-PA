// See https://aka.ms/new-console-template for more information
using Actividad_8;

List <Recetas> listaRecetas = new List <Recetas> ();
Recetas recetaObjeto = new Recetas(listaRecetas);
bool menu = true;

do
{
    try
    {
        recetaObjeto.MostrarMenu();
        int opcion = int.Parse(Console.ReadLine() ?? "");
        switch (opcion)
        {
            case 1:
                recetaObjeto.IngresarRecetas(listaRecetas);
                break;
            case 2:
                recetaObjeto.BuscarRecetas(listaRecetas);
                break;
            case 3:
                recetaObjeto.MostrarRecetas(listaRecetas);
                break;
            case 4:
                Console.WriteLine("\nUsted está saliendo del programa...");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                menu = false;
                break;
            default:
                Console.WriteLine("\nIngrese una opción válida");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese una opción válida..");
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadKey();
    }
} while (menu);
