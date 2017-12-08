using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consapino.App.BE
{
    public class NotificacionBE
    {
        public int NotificacionId { get; set; }
        public String Titulo { get; set; }
        public String Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        public String Estado { get; set; }
        public bool? EsCorreo { get; set; }
        public bool? EsNotificado { get; set; }

        public NotificacionBE()
        {

        }

        public NotificacionBE(int NotificacionId, String Titulo, String Mensaje, DateTime Fecha,
            String Estado, bool? EsCorreo, bool? EsNotificado)
        {
            this.NotificacionId = NotificacionId;
            this.Titulo = Titulo;
            this.Mensaje = Mensaje;
            this.Fecha = Fecha;
            this.Estado = Estado;
            this.EsCorreo = EsCorreo;
            this.EsNotificado = EsNotificado;
        }
    }

}