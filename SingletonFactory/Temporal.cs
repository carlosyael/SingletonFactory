﻿using System;
using System.IO;
namespace SingletonFactory
{
    class Temporal : IEmpleado
    {
        bool encontrado;
        StreamWriter escritura;
        StreamReader lectura;
        String nombre, apellido, cedula, telefono, sueldo, pagoHora, jornada, posicion, departamento,cadena;
        string[] campos = new string[7];
        public void AgregarDatos()
        { 
            encontrado = false;
            //en esta parte creamos o abrimos el documento
            escritura = File.AppendText("log.txt");
            escritura.Close(); 
            //usamos la cedula como identificador
            Console.WriteLine("ingrese la cedudula o pasaporte");
            cedula = Console.ReadLine();
            //pasamos a evaluar dicha informacion
            lectura = File.OpenText("log.txt");
            cadena = lectura.ReadLine();
            while (cadena != null)
            {
                campos = cadena.Split(",");
                if (campos[2].Trim().Equals(cedula))
                {
                    encontrado = true;
                    Console.WriteLine("YA HAY UN EMPLEADO REGISTRADO CON ESE PASAPORTE O CEDULA");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                cadena = lectura.ReadLine();
            }
            lectura.Close();

            if (encontrado == false)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la cedula");
                cedula = Console.ReadLine();
                Console.WriteLine("Ingrese el telefono");
                telefono = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo");
                sueldo = Console.ReadLine();
                Console.WriteLine("Ingrese la pago por hora");
                pagoHora = Console.ReadLine();
                Console.WriteLine("Ingrese la jornada laboral");
                jornada = Console.ReadLine();
                Console.WriteLine("Ingrese la posición");
                posicion = Console.ReadLine();
                Console.WriteLine("Ingrese el departamento");
                departamento = Console.ReadLine();

                Log log = Log.GetLog();
                log.CrearLog(nombre, apellido,cedula, sueldo, posicion, departamento );
            }
        }

    }
}