using System;
using System.IO;

namespace SingletonFactory
{
    class Log
    {
        String nombre, apellido, sueldo, posicion, departamento, TipoEmp,cedula;
        private static Log log;
        private Log()
        {

        }
        public static Log GetLog()
        {
            if (log == null)
            {
                log = new Log();
                return log;
            }
            else
            {
                return log;
            }

        }
        public void CrearLog(String nombre, String apellido,String cedula, String sueldo, String posicion, String departamento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.sueldo = sueldo;
            this.posicion = posicion;
            this.departamento = departamento;

             
            StreamWriter escribir = File.AppendText("log.txt");
            escribir.WriteLine(nombre+","+apellido+","+cedula+","+sueldo+","+posicion+","+departamento +","+DateTime.Now.ToString("dd/mm/yy hh:mm:ss tt"));
            escribir.Close();


        }
        public void BorrarLog(string cedula)
        {
            string respuesta = "",cadena;
            StreamReader lectura;
            StreamWriter temporal;

            bool encontrado;
            try
            {
                
                encontrado = false;
                lectura = File.OpenText("log.txt");
                string[] campos = new string[7];
                temporal = File.CreateText("tmp.txt");
                cedula = cedula.ToUpper();
                cadena = lectura.ReadLine();
                while (cadena != null)
                {

                    campos = cadena.Split(",");
                    if (campos[2].Trim().Equals(cedula))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        temporal.WriteLine(cadena);

                    }
                    cadena = lectura.ReadLine();

                }
                lectura.Close();
                temporal.Close();
                if (encontrado == false)
                {
                    Console.WriteLine("No se ha encontrado un empleado con la cedula {0}", cedula);
                    Console.ReadKey();
                }
                else if (encontrado == true)
                {
                    Console.WriteLine("registro eliminado");
                    File.Delete("log.txt");
                    File.Move("tmp.txt", "log.txt");
                    Console.ReadKey();
                }
            }
            finally
            {

            }

        }


    }
}
