using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consapino.App.BE
{
    public class ErrorBE
    {
        public int Codigo { get; set; }
        public String Descripcion { get; set; }

        public ErrorBE(int codigo, String descripcion)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;

        }
    }
}