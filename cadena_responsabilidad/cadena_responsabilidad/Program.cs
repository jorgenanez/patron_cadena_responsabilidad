using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadena_responsabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            aprobador Jorge = new Director();
            aprobador Angel = new Vicepresidente();
            aprobador Luis = new Presidente();

            Jorge.SetSucesor(Angel);
            Angel.SetSucesor(Luis);

            Console.WriteLine("metodo cadena de responsabilidad\n ");
            Compra p = new Compra(2034, 350.00, "Proyecto A");
            Jorge.Solicitud_proceso(p);

            p = new Compra(2035, 32590.10, "Proyecto B");
            Jorge.Solicitud_proceso(p);

            p = new Compra(2036, 122100.00, "Proyecto C");
            Jorge.Solicitud_proceso(p);

            p = new Compra(2037, 24000.0, "Proyecto D");
            Jorge.Solicitud_proceso(p);
           
            Console.ReadKey();
        }
    }
}
