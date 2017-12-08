using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consapino.App.BE
{
    public class AreasBE
    {
        public int AreaId { get; set; }
        public String Nombre { get; set; }
        public String Estado { get; set; }
        public int? UnidadNegocioId { get; set; }

        public AreasBE()
        {

        }
        public AreasBE(int AreaId, String Nombre, String Estado, int? UnidadNegocioId)
        {
            this.AreaId = AreaId;
            this.Nombre = Nombre;
            this.Estado = Estado;
            this.UnidadNegocioId = UnidadNegocioId;
        }
    }
}