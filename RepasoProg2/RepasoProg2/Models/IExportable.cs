﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoProg2.Models
{
    public interface IExportable
    {
        void Leer(string[] n);
        string Escribir();
    }
}
