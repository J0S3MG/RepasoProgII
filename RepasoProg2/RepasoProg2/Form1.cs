using RepasoProg2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace RepasoProg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<Ticket> Tickets;
        string Path = Application.StartupPath + "\\datos.bin";
        #region Load--Deserealizacion de la Pila.
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path) == true)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;
                try
                {
                    fs = new FileStream(Path, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    Tickets = bf.Deserialize(fs) as Stack<Ticket>;
                    //Agregamos los ticket al listbox.
                    foreach (Ticket t in Tickets)
                    {
                        lbxVista.Items.Add(t.Escribir());
                        cbxNroTicket.Items.Add(t.NroOrd);
                    }
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            else if (Tickets == null)// En caso de que sea la primera vez que se ejecuta el programa.
            {
                //Creo la pila de tickets.
                Tickets = new Stack<Ticket>();
                //Creo 2 tickets para agregar a la pila.
                Ticket t1 = new Ticket("Liam", "20428882222");
                Ticket t2 = new Ticket("Jose", "20448196144");
                //Creo los servicos para agregar a los tickets.
                Servicio m = new Mantenimiento(01, "ajuste de cambios", 200);
                Servicio r = new Reparacion(02, "cambio de piñon", 300);
                //Agrego los servicios a los tickets.
                t1.AgregarServico(m);
                t2.AgregarServico(r);
                //Agrego los tickets a la pila.
                Tickets.Push(t1);
                Tickets.Push(t2);
                //Agregamos los ticket al listbox.
                foreach (Ticket t in Tickets)
                {
                    lbxVista.Items.Add(t.Escribir());
                    cbxNroTicket.Items.Add(t.NroOrd);
                }
            }
        }
        #endregion
        #region Closing--Serializacion de la Pila.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(Path, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, Tickets);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int nro = Convert.ToInt32(btnEliminar.Text);
            /*Ticket t = new Ticket();
             * Servicio s = t.QuitarServicio(nro);*/
            Servicio s = Ticket.QuitarServico(nro);
            if (s != null) MessageBox.Show("El servicio se borro correctamente");
        }

        private void tbxNro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imp = new OpenFileDialog();
            imp.Filter = "ficheros csv|*.csv";
            if (imp.ShowDialog() == DialogResult.OK)
            {
                string ruta = imp.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                Servicio s = null;
                try
                {
                    fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea = sr.ReadLine();
                    while (sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        string[] dat = linea.Split(';');
                        string tipo = dat[0];
                        if (tipo == "R")
                        {
                            s = new Reparacion();
                            s.Leer(dat);
                        }
                        else if (tipo == "M")
                        {
                            s = new Mantenimiento();
                            s.Leer(dat);
                        }
                        lbxVista.Items.Add(s.Escribir());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnExpT_Click(object sender, EventArgs e)
        {
            SaveFileDialog Ex = new SaveFileDialog();
            Ex.Filter = "ficheros csv|*.csv";
            if (Ex.ShowDialog()==DialogResult.OK)
            {
                string path = Ex.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("NroOrden;Cuil;NombreCli;Fecha;Monto");
                    foreach (Ticket t in Tickets)
                    {
                        sw.WriteLine(t.Escribir());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }

        private void btnCrearT_Click(object sender, EventArgs e)
        {
            string nom = tbxNombre.Text;
            string cuil = tbxCuil.Text;
            Ticket t = new Ticket(nom, cuil);
            Tickets.Push(t);
            lbxVista.Items.Add(t.Escribir());
            cbxNroTicket.Items.Add(t);
        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            Servicio s = null;
            string des = tbxDesc.Text;
            int cod = Convert.ToInt32(tbxCodigo.Text);
            double pre = Convert.ToDouble(tbxPrecio.Text);
            if (rbtMantenimiento.Checked)
            {
                s = new Mantenimiento(cod, des, pre);
            }
            else if (rbtReparacion.Checked)
            {
                s = new Reparacion(cod, des, pre);
            }
            int nro = cbxNroTicket.SelectedIndex;
            #region Buscar el Ticket
            /*Esta seria la forma larga
            foreach(Ticket t in Tickets)
            {
                if(nro == t.NroOrd)
                {
                    t.AgregarServico(s);
                }
            }
            */
            #endregion
            Ticket t = Tickets.Where(b => b.NroOrd == nro).FirstOrDefault();//Esta es la forma facil
            t.AgregarServico(s);
        }
    }
}
