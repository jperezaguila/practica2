using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2.clases
{
    public class CuentaCorriente : Producto, ICalculoSeguro
    {
        public decimal Credito { get; set; }
        public decimal  Interes { get; set; }


        public override void Ingreso(decimal cantidad)
        {
            Saldo+=cantidad;
            Console.WriteLine("Ingreso realizado con Exito");
            Detalle();
        }

        public override void Retirada(decimal cantidad)
        {
            if (Saldo >= cantidad)
            {
                Saldo -= cantidad;
                Console.WriteLine("Retirada realizada con Exito");
                Detalle();
            }
            else if (Saldo + Credito >= cantidad)
            {
                var cs = cantidad - Saldo;
                var interes = cs*Interes;
                Saldo -= cantidad + interes;
                Console.Write("Retirada realizada con Exito");
            }
            else
            {
             Console.WriteLine("Saldo Insuficiente");
                Detalle();
            }
        }
        public decimal Prima(int edad, decimal cantidad)
        {
            if (edad < 40)
            {
                return cantidad*(decimal) 0.01;
            }
            else
            {
                return cantidad*(decimal) 0.03;

            }
            
        }

        public decimal Cancelacion(decimal cantidad)
        {
            return cantidad*(decimal) 0.01;
        }
    }



}
