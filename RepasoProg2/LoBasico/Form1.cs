using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoBasico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaModalForm venti = new VentanaModalForm();// ACA creo un obj ventana. Importante cambiar el valor del modifire a public.

            string nombre = "";
            if(venti.ShowDialog() == DialogResult.OK)
            {
               nombre = venti.txtNombre.Text;// Asigno un valor con la propiedad Text del componente texbox
            }
            lblMostrar.Text = nombre;

        }
    }
}
