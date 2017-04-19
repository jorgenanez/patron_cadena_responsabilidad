using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadena_responsabilidad
{
    abstract class aprobador
    {
        protected aprobador sucesor;

        public void SetSucesor(aprobador sucesor)
        {
            this.sucesor = sucesor;
        }

        public abstract void Solicitud_proceso(Compra compra);
    }
}
