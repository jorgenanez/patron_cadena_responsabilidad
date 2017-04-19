using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadena_responsabilidad
{
    class Presidente : aprobador
    {
        public override void Solicitud_proceso(Compra compra)
        {
            if (compra.Cantidad < 100000.0)
            {
                Console.WriteLine("El {0} aprobo la solicitud # {1} ya que la cantidad es menor a 100000 y mayor que 25000 \n",
                  this.GetType().Name, compra.Numero);
            }
            else
            {
                Console.WriteLine(
                  "Peticion # {0} requiere de una reunion con ejecutivos para ver su aprobacion ya que la cantidad es mayor a 100000\n",
                  compra.Numero);
            }
        }
    }
}
