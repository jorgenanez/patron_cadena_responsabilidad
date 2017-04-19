using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptrondcomportamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            AgregadaConcreta a = new AgregadaConcreta();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            
            IteradorConcreto i = new IteradorConcreto(a);

            Console.WriteLine("Iterando sobre la colección:");

            object item = i.Primero();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Siguiente();
            }

             Console.Read();
        }
            }
    // "Agregada" 
    abstract class Agregada
    {
        public abstract Iterator CrearIterator();
    }

    // "AgregadaConcreta" 
    class AgregadaConcreta : Agregada
    {
        private ArrayList items = new ArrayList();

        public override Iterator CrearIterator()
        {
            return new IteradorConcreto(this);
        }

       
        public int Conteo
        {
            get { return items.Count; }
        }

       
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

    // "Iterator" 
    abstract class Iterator
    {
        public abstract object Primero();
        public abstract object Siguiente();
        public abstract bool Hecho();
        public abstract object ActualItem();
    }

    // "IteradorConcreto" 
    class IteradorConcreto : Iterator
    {
        private AgregadaConcreta Agregada;
        private int Actual = 0;

        // Constructor 
        public IteradorConcreto(AgregadaConcreta Agregada)
        {
            this.Agregada = Agregada;
        }

        public override object Primero()
        {
            return Agregada[0];
        }

        public override object Siguiente()
        {
            object ret = null;
            if (Actual < Agregada.Conteo - 1)
            {
                ret = Agregada[++Actual];
            }

            return ret;
        }

        public override object ActualItem()
        {
            return Agregada[Actual];
        }

        public override bool Hecho()
        {
            return Actual >= Agregada.Conteo ? true : false;
        }
    }
}
