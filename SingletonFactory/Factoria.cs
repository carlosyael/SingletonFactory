using System;

namespace SingletonFactory
{
    class Factoria
    {
        public IEmpleado CrearEmpleado(int op)
        {
            if (op == 1)
            {
                Console.Clear();
                Console.WriteLine("*****Empleado Tiempo Completo*****");
                return new TiempoCompleto();
            }
            else if (op == 2)
            {
                Console.Clear();
                Console.WriteLine("*****Empleado Medio Tiempo*****");
                return new MedioTiempo();
            }
            else
            { 
                Console.Clear();
                Console.WriteLine("*****Empleado Temporal*****");
                return new Temporal();
            }

        }
    }
}
