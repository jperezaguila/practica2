using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2.clases
{
    public interface ICalculoSeguro
    {
        decimal Prima(int edad, decimal cantidad);
        decimal Cancelacion(decimal cantidad);
    }

}
