using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    abstract class Producto : IComparable<Producto>
    {
        protected double precioBase;
        protected double largo;
        private int codigo;

        public int Codigo
        {
            get
            { return codigo; }
            set
            { //this.codigo = Convert.ToInt32(tbCodigo.Text);
            }
        }

        public Producto(double precio, double largo)
        {
            this.precioBase = precio;
            this.largo = largo;
        }   
    
        public abstract double Peso();
        public abstract double Precio();
        public int CompareTo(Producto p)
        { 
            Producto producto = p as Producto; //"(Producto)obj;"

            return Codigo.CompareTo(producto.Codigo*-1); //*1 menor a mayor; *-1 para mayor a menor 
        }
    }
}
