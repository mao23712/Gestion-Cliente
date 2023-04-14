using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparacion
{
    class Cliente
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string CorreoElectronico { get; set; }

        public Cliente(string nombre, int edad, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            CorreoElectronico = correoElectronico;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Edad: {Edad}, Correo electrónico: {CorreoElectronico}";
        }
    }

    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Bienvenido al sistema de gestión de clientes.");
                Console.WriteLine("1. Registrar un cliente");
                Console.WriteLine("2. Ver la lista de clientes");
                Console.WriteLine("3. Eliminar un cliente");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarCliente();
                  
                        break;
                    case "2":
                        VerClientes();
                        break;
                    case "3":
                        EliminarCliente();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void RegistrarCliente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del cliente:");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el correo electrónico del cliente:");
            string correoElectronico = Console.ReadLine();

            Cliente cliente = new Cliente(nombre, edad, correoElectronico);
            clientes.Add(cliente);

            Console.WriteLine("Cliente registrado exitosamente.");
            Console.Clear();
        }

        static void VerClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                Console.WriteLine("Lista de clientes:");
                foreach (Cliente cliente in clientes)
                {
                    Console.WriteLine(cliente);
                }
            }
        }

        static void EliminarCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                Console.WriteLine("Ingrese el correo electrónico del cliente a eliminar:");
                string correoElectronico = Console.ReadLine();

                bool encontrado = false;
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].CorreoElectronico == correoElectronico)
                    {
                        clientes.RemoveAt(i);
                        encontrado = true;
                        Console.WriteLine("Cliente eliminado exitosamente.");
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontró ningún cliente con el correo electrónico ingresado.");
                }
            }
        }
    }
}
