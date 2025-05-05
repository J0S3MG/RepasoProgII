using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoProg2.Models
{
    public class CUILException: ApplicationException
    {
        public CUILException() { }
        public CUILException(string message) : base(message) { }
        public CUILException(string msj, Exception ex) : base(msj, ex)
        {

        }
    }
}
