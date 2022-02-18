using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonFactory
{
    class AccionesEmpleado
    {
        
        public void Vacaciones(string cedula,string inicio, string finalizacion)
        {
            Console.WriteLine("Vacaciones aplicadas correctamente para el empleado con cedula: {0}. Desde {1} hasta {2}",cedula,inicio,finalizacion);

        }
        public void Permiso(string cedula, string fecha, string causa)
        { 
            Console.WriteLine("Permiso aplicado para el emplado con cedula: {0} dia: {1}",cedula, fecha);
        }

    }
}
