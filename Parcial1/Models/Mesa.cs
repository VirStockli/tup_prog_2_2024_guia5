using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal class Mesa : Producto
    {
        private double ancho;
        private double grosor;

        public Mesa(double precio, double largo, double ancho, double grosor) : base(precio, largo)
        { }

        public override double Peso()
        {
            double peso = (largo*ancho*grosor)*0.3;
            return peso;
        }

        public override double Precio()
        {
            double precio = Peso()*precioBase*1.25;
            return precio;
        }
    }
}
