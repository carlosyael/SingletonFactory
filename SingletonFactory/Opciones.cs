using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonFactory
{
    class Opciones
    {
        private AccionesEmpleado AcEmp=new AccionesEmpleado();
        private string cedula, Fecha1, Fecha2, causa;
        public void CrearEmpleado() {
            IEmpleado empleado;
            Factoria fabrica = new Factoria();
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("***Elije una opcion****\n" +
                "1. Empleado Tiempo Completo\n" +
                "2. Empleado Medio Tiempo\n" +
                "3. Empleado Temporal\n" +
                "4. Salir"); 
                op = int.Parse(Console.ReadLine());
                if (op < 4 && op > 0)
                {
                    empleado = fabrica.CrearEmpleado(op);
                    empleado.AgregarDatos();
                }

            } while (op != 4);
        }
        public void Vacaciones()
        {
            Console.WriteLine("ingresa la cedula: ");
            cedula = Console.ReadLine();
            Console.WriteLine("ingresa la fecha de inicio: ");
            Fecha1 = Console.ReadLine();
            Console.WriteLine("ingresa la fecha de finalizacion: ");
            Fecha2 = Console.ReadLine();
            AcEmp.Vacaciones(cedula,Fecha1,Fecha2);
            
        }
        public void Permiso()
        {
            Console.WriteLine("ingresa la cedula: ");
            cedula = Console.ReadLine();
            Console.WriteLine("ingresa la fecha de efectividad: ");
            Fecha1 = Console.ReadLine();
            Console.WriteLine("Ingresa la causa o razon del permiso: ");
            causa = Console.ReadLine();
            AcEmp.Permiso(cedula, Fecha1, causa);
        }
        public void Desvincular()
        {
            Console.WriteLine("Ingrese la cedula del empleado a desvincular");
            cedula = Console.ReadLine();
            Log log = Log.GetLog();
            log.BorrarLog(cedula);
        }

    }
}
