using System;

namespace RepasoProg2.Models
{
    [Serializable]
    public abstract class Servicio : IComparable, IExportable
    {
        public int NroCod { get; set; }
        protected string descripcion;
        protected double precioB;

        public abstract string TareaRealizada();
        public abstract double Precio();

        public int CompareTo(object obj)
        {
            Servicio s = obj as Servicio;
            if (s != null)
                return NroCod.CompareTo(s.NroCod);
            return 1;
        }

        public virtual void Leer(string[] n)
        {
            NroCod = Convert.ToInt32(n[1]);
            descripcion = n[2];
            precioB = Convert.ToDouble(n[3]);
        }

        public virtual string Escribir()
        {
            string date = $"{NroCod};{descripcion}";
            return date;
        }
    }
}
