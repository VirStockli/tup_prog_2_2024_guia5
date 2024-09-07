using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal class Banco : Producto//,IComparable<Banco>
    {
        public Banco(double precio, double largo) : base(precio,largo)
        { }
        //public int CompareTo(Banco b)
        //{
        //    Banco ba = b as Banco; //"(Producto)obj;"

        //    return Codigo.CompareTo(ba.Codigo * -1); //*1 menor a mayor; *-1 para mayor a menor 
        //}

        public override double Peso()
        {
           double peso = (largo*0.25)*0.42;
            return peso;
        }

        public override double Precio()
        {
           double peso = Peso();
            double precio = peso * precioBase * 1.15;
            return precio;
        }
    }
}
