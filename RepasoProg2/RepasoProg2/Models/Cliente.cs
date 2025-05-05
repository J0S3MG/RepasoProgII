using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RepasoProg2.Models
{
    [Serializable]
    public class Cliente
    {
        public long Cuil {  get; set; }
        public string Nom {  get; set; }

        public Cliente(string nom, string cuil)
        {
            Regex regex = new Regex(@"^\d{11}$");
            if (!regex.IsMatch(cuil))
            {
                throw new FormatException("El CUIL debe tener exactamente 11 números sin caracteres especiales.");
            }
            else
            {
                Cuil = Convert.ToInt64(cuil);
            }
            Nom = nom;
        }
    }
}
