using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadena_responsabilidad
{
    class Vicepresidente : aprobador
    {
        public override void Solicitud_proceso(Compra compra)
        {
            if (compra.Cantidad < 25000.0)
            {
                Console.WriteLine("El {0} aprobo la solicitud # {1} ya que la cantidad es menor a 25000 y mayor que 10000\n",
                  this.GetType().Name, compra.Numero);
            }
            else if (sucesor != null)
            {
                sucesor.Solicitud_proceso(compra);
            }
        }
    }
}
