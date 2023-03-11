using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peaje_de_autopista
{
    internal class ClsTransacciones
    {//Atributos
        private string nombreCliente;
        private int cuenta;
        private double saldo;

        //Constructor 
        public ClsTransacciones(string nombreCliente, int cuenta, double saldo)
        {
            this.nombreCliente = nombreCliente;
            this.cuenta = cuenta;
            this.saldo = saldo;
        }
        //Metodo para ingresar dinero 
        public void ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine("Ingreso exitoso. Su saldo actual es: {0}", saldo);

            }
            else
            {
                Console.WriteLine("Cantidad no valida.");
            }
        }
        //Metodo para consultar saldo 
        public double consultar()
        {
            return saldo;
        }
        //Metodo para modificar Saldo 
        public void modificar(double cantidad)
        {
            saldo = cantidad;
            Console.WriteLine("Saldo modificado exitosamente. Nuevo saldo: {0}", saldo);
        }
        //Metodo para generar reporte 
        public void reporte()
        {
            Console.WriteLine("Nombre del cliente: {0}", nombreCliente);
            Console.WriteLine("Número de cuenta: {0}", cuenta);
            Console.WriteLine("Saldo actual: {0}", saldo);
        }

    }

}