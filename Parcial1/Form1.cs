using Parcial1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        Producto[] productos = new Producto[10];
        int cont = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            double precio, largo, ancho, grosor;
            int codigo = Convert.ToInt32(tbCodigo.Text);
            if (codigo < 1000000)
            {
                //if (tbPrecio.Text != null)
                    precio = Convert.ToDouble(tbPrecio.Text);
                //if (tbLargo.Text != null)
                    largo = Convert.ToDouble(tbLargo.Text);
                Banco b = new Banco(precio, largo);
                b.Codigo = codigo;
                cbLista.Items.Add(codigo);
                productos[cont++] = b;
               
            } 
            else
            {
                //if (tbPrecio.Text != null)
                    precio = Convert.ToDouble(tbPrecio.Text);
                //if (tbLargo.Text != null)
                    largo = Convert.ToDouble(tbLargo.Text);
                //if (tbAncho.Text != null)
                    ancho = Convert.ToDouble(tbAncho.Text);
                //if (tbGrosor.Text != null)
                    grosor = Convert.ToDouble(tbGrosor.Text);

                Mesa m = new Mesa(precio, largo, ancho, grosor);
                m.Codigo = codigo;

                cbLista.Items.Add(codigo);

                productos[cont++] = m;
            }

            tbPrecio.Clear();
            tbLargo.Clear();
            tbAncho.Clear();
            tbCodigo.Clear();
            tbGrosor.Clear();

        }

       public void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDirec.Text;
            Presupuesto p = new Presupuesto(nombre, direccion);
        }

        public void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbLista.SelectedIndex;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
