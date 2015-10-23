using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using practica2.clases;

namespace practica2
{

    class Program
    {
        static void Main(String[] args)
        {
            var cl = new Cliente()
            {
                Nombre = "Alberto",
                Dni = "6666666E",
                Tel = "9999999999"
            };

            var ca = new CuentaAhorro()
            {
                Cliente = cl,
                Saldo = 12000,
                Bonificacion = 0.01,
                Penalizacion = 0.03
            };

            var cc = new CuentaCorriente()
            {
                Cliente = cl,
                Saldo = 12000,
                Credito = 500,
                Interes = (decimal)0.02
            };
            cc.Retirada(3000);
            ca.Retirada(10000);

            Console.ReadLine();

        }
    }
}
