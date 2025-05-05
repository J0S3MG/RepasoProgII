using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoProg2.Models
{
    [Serializable]
    public class Mantenimiento: Servicio
    {
        private double extra;
        public Mantenimiento(int cod, string desc, double preB)
        {
            precioB = preB;
            descripcion = desc;
            NroCod = cod;
        }
        public Mantenimiento(int cod)
        {
            NroCod = cod;
        }
        public Mantenimiento() { }
        public void PorcentajeExtra(double ext)
        {
            extra = precioB * ext / 100;
        }
        public override string TareaRealizada()
        {
            throw new NotImplementedException();
        }
        public override double Precio()
        {
            double pre = precioB + extra;
            return pre;
        }
        public override string Escribir()
        {
            return $"{base.Escribir()};{Precio()}";
        }
    }
}
