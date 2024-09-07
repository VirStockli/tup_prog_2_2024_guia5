using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal class Presupuesto
    {
        
        public double Precio {  get; set; }
        
        private ArrayList listaProductos = new ArrayList();
        private ArrayList solicitante = new ArrayList();
        public Presupuesto(string nombre, string direccion) 
        { 
            Cliente c = new Cliente (nombre,direccion);
            solicitante.Add (c);
        }

        public void AgregarProducto(Producto unproducto)
        { listaProductos.Add (unproducto);
        }

        public bool QuitarProducto(int codigo)
        {
            
            Producto c = BuscarProducto(codigo);
            if (c != null)
            {
                listaProductos.Remove(c);
            }
            return             
        }

        public Producto BuscarProducto(int codigo)
        {
            listaProductos.Sort();
            Producto p = listaProductos.BinarySearch (codigo);

        }


    }
}
