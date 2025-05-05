using System;
using System.Collections.Generic;

namespace RepasoProg2.Models
{
    [Serializable]
    public class Ticket : IExportable
    {
        private Cliente cli;
        static List<Servicio> servicios = new List<Servicio>();
        static int nroOrd = 0;
        public int NroOrd
        {
            get { return nroOrd; }
        }
        DateTime Fecha;

        public Ticket(string nom, string cuil)
        {
            try
            {
                cli = new Cliente(nom, cuil);
                nroOrd = nroOrd + 1;
                Fecha = DateTime.Now;
            }
            catch (CUILException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void AgregarServico(Servicio s)
        {
            servicios.Add(s);
        }
        public static Servicio QuitarServico(int nro)
        {
            servicios.Sort();
            Servicio busq = new Mantenimiento(nro);
            int idx = servicios.BinarySearch(busq);
            Servicio s = servicios[idx];
            if (idx >= 0 && idx < servicios.Count)
                servicios.RemoveAt(idx);
            return s;
        }
        public double PrecioFinal()
        {
            double total = 0;
            foreach (Servicio s in servicios)
            {
                total += s.Precio();
            }
            return total;
        }
        public void Leer(string[] n)
        {
            throw new NotImplementedException();
        }

        public string Escribir()//Igual al ToString
        {
            string date = $"{nroOrd};{cli.Cuil};{cli.Nom};{Fecha};{PrecioFinal()}";
            return date;
        }
    }
}
