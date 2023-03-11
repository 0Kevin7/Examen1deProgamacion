using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje_de_autopista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase ClsTransacciones
            ClsTransacciones transaccion = new ClsTransacciones("Juan Perez", 1234567890, 1000.0);

            // Realizar una transacción: ingresar $500 a la cuenta
            transaccion.ingresar(500.0);

            // Consultar el saldo actual
            double saldoActual = transaccion.consultar();
            Console.WriteLine("El saldo actual es: {0}", saldoActual);

            // Modificar el saldo
            transaccion.modificar(1500.0);

            // Generar un reporte de la transacción
            transaccion.reporte();

            // Esperar a que el usuario presione una tecla para cerrar el programa
            Console.ReadKey();
        }
        public static void menu()
        {
            byte opcion = 0;
            ClsTransacciones transaccion = new ClsTransacciones("Juan Perez", 12345, 1000.00);
            do
            {
                Console.WriteLine("1 - Opcion Ingresar");
                Console.WriteLine("2 - Opcion Consulta");
                Console.WriteLine("3 - Opcion Modificar");
                Console.WriteLine("4 - Opcion Reporte");
                Console.WriteLine("5 - Opcion Salir");
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Digite la cantidad a ingresar: ");
                        double cantidadIngreso = double.Parse(Console.ReadLine());
                        transaccion.ingresar(cantidadIngreso);
                        break;
                    case 2:
                        Console.WriteLine("Su saldo actual es: {0}", transaccion.consultar());
                        break;
                    case 3:
                        Console.Write("Digite el nuevo saldo: ");
                        double cantidadModificar = double.Parse(Console.ReadLine());
                        transaccion.modificar(cantidadModificar);
                        break;
                    case 4:
                        transaccion.reporte();
                        break;
                    case 5:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }

            } while (opcion != 5);
        }
    }
}