using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_8
{
    public class Recetas
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string Preparacion { get; set; }

        public Recetas(string iD, string nombre, string ingredientes, string preparacion)
        {
            ID = iD;
            Nombre = nombre;
            Ingredientes = ingredientes;
            Preparacion = preparacion;
        }
        public Recetas(List<Recetas> listaRecetas) { }

        public void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("--- RECETAS CULINARIAS ---");
            Console.WriteLine("1. Agregar recetas");
            Console.WriteLine("2. Buscar recetas");
            Console.WriteLine("3. Mostrar todas las recetas");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opción: ");
        }
        public void IngresarRecetas(List<Recetas> listaRecetas)
        {
            Console.Clear();
            Console.WriteLine("--- AGREGAR RECETAS ---");
            Console.Write("ID: ");
            string id = Console.ReadLine()??"";
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()??"".ToUpper();
            Console.Write("Ingredientes: ");
            string ingredientes = Console.ReadLine() ?? "";
            Console.Write("Preparación: ");
            string preparacion = Console.ReadLine() ?? "";
            listaRecetas.Add(new Recetas(id, nombre, ingredientes, preparacion));
            Console.WriteLine("\nReceta agregada con éxito");
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadKey();
        }
        public void BuscarRecetas(List<Recetas> listaRecetas)
        {
            Console.Clear();
            Console.WriteLine("--- BUSCAR RECETAS ---");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()??"".ToUpper();
            Recetas? buscarReceta = listaRecetas.Find(x => x.Nombre == nombre);
            if (buscarReceta != null)
            {
                Console.WriteLine("\nReceta Encontrada");
                Console.WriteLine($"ID: {buscarReceta.ID}\nNombre: {buscarReceta.Nombre}\nIngredientes: {buscarReceta.Ingredientes}\nPreparación: {buscarReceta.Preparacion}");
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se ha encontrado ninguna receta con ese nombre");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public void MostrarRecetas(List<Recetas> listaRecetas)
        {
            Console.Clear();
            Console.WriteLine("--- MOSTRAR RECETAS ---");
            foreach (Recetas recetas in listaRecetas)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine($"ID: {recetas.ID}\nNombre: {recetas.Nombre}\nIngredientes: {recetas.Ingredientes}\nPreparación: {recetas.Preparacion}");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadKey();
        }
    }
}
