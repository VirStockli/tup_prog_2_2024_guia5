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
        { 
            listaProductos.Add (unproducto);
        }

        public bool QuitarProducto(int codigo)
        {
            // bool eliminado = false;

            Producto c = BuscarProducto(codigo);
            
            if (c != null)
            {
                listaProductos.Remove(c);
                //eliminado = true;
                return true;
            }
            
            return false;
        }

        public Producto BuscarProducto(int codigo)
        {
           listaProductos.Sort();

            Producto pedido = null;
            pedido.Codigo = codigo;

            int idx = listaProductos.BinarySearch(pedido);
            if (idx >= 0)
            {
                return listaProductos[idx] as Producto;
            }
            
            return null;

           

        }
        public Producto BuscarProducto2(int codigo)
        {
            int inf = 0;
            int sup = listaProductos.Count - 1;
            
            while (inf < sup)
            {
                int medio = (inf + sup) / 2;
                
                Producto buscado = listaProductos[medio] as Producto;
                if (buscado == null) return null;
                
                if (buscado.Codigo == codigo)
                { return buscado; }
                
                else if (buscado.Codigo < codigo) { sup = medio - 1; }
                else { inf = medio + 1; }
            }
            return null;
        }


    }
}
