using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadena_responsabilidad
{
    class Compra
    {
         private int _numero;
    private double _cantidad;
    private string _descripcion;
 
    
    public Compra(int numero, double cantidad, string descripcion)
    {
      this._numero = numero;
      this._cantidad = cantidad;
      this._descripcion = descripcion;
    }
 
    public int Numero
    {
      get { return _numero; }
      set { _numero = value; }
    }
 
    
    public double Cantidad
    {
      get { return _cantidad; }
      set { _cantidad = value; }

        }
    public string Descripcion
    {
      get { return _descripcion; }
      set { _descripcion = value; }
    }

    }
}
