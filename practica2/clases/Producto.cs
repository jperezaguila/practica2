using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2.clases
{
    public abstract class Producto
    {
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }
        
        //creacion de funciones abstractas publicas
        public abstract void Ingreso(decimal cantidad);
        public abstract void Retirada(decimal cantidad);

        public void Detalle()
        {//2:c currency es la moneda 
        Console.WriteLine("{0} {1} Saldo : {2:c}", Cliente.Dni, Cliente.Nombre,Saldo);
        }
     }

}

