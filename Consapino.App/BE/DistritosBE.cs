using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consapino.App.BE
{
    public class DistritosBE
    {
        public int DistritoId { get; set; }
        public String Descripcion { get; set; }
        public int ProvinciaId { get; set; }
        public String Estado { get; set; }
        public String UbigeoId { get; set; }

        public DistritosBE()
        {

        }

        public DistritosBE(int DistritoId, String Descripcion, int ProvinciaId,
            String Estado, String UbigeoId)
        {
            this.DistritoId = DistritoId;
            this.Descripcion = Descripcion;
            this.ProvinciaId = ProvinciaId;
            this.Estado = Estado;
            this.UbigeoId = UbigeoId;
        }
    }
}