using System;

namespace SingletonFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Opciones opcion = new Opciones();
            int op =0;
            Console.WriteLine("******************BIENVENIDO******************");
            Console.ReadKey();
            do
            {

                Console.Clear();
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1. Crear Empleado");
                Console.WriteLine("2. Vacaciones");
                Console.WriteLine("3. Permiso");
                Console.WriteLine("4. Desvinculacion");
                Console.WriteLine("5. Salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        opcion.CrearEmpleado(); 
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        opcion.Vacaciones();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        opcion.Permiso();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        opcion.Desvincular();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("usted ha elegido terminar el programa");
                        Console.ReadKey();
                        break;

                }

            } while (op != 5);
        }
    }
}
