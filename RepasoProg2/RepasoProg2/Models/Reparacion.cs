using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoProg2.Models
{
    [Serializable]
    public class Reparacion: Servicio
    {
        public double PreRep {  get; set; }
        public Reparacion(int cod, string desc, double preB)
        {
            precioB = preB;
            descripcion = desc;
            NroCod = cod;
        }
        public Reparacion() { }
        public override string TareaRealizada()
        {
            throw new NotImplementedException();
        }
        public override double Precio()
        {
            double pre = precioB * 60 + PreRep;
            return pre;
        }
        public override void Leer(string[] n)
        {
            base.Leer(n);
            PreRep = Convert.ToDouble(n[4]);
        }
        public override string Escribir()
        {
            return $"{base.Escribir()};{Precio()};{PreRep}";
        }
    }
}
