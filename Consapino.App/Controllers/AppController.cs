using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Consapino.App.BE;
using Consapino.App.Models;

namespace Consapino.App.Controllers
{
    public class AppController : ApiController
    {
        [HttpGet]
        [Route("Usuario/Validar")]
        public UsuarioBE UsuarioValidar(String Codigo, String Password)
        {
            try
            {
                CosapinoAppEntities context = new CosapinoAppEntities();
                Administrador objUsuario = context.Administrador.FirstOrDefault
                    (X => X.Codigo == Codigo && X.Password == Password);

                if (objUsuario == null)
                    return new UsuarioBE(0, "Codigo de Usuario y/o Password invalida");

                if (objUsuario.Rol != "ADM")
                    return new UsuarioBE(0, "El rol no se encuentra autorizado en el sistema");

                return new UsuarioBE(objUsuario.Codigo, objUsuario.Password);
            }
            catch (Exception ex)
            {
                return new UsuarioBE(99, "el sistema no se encuentra disponible:" + ex.ToString());
            }
        }

        [HttpGet]
        [Route("Distrito/List")]
        public List<DistritosBE> GetListDistrito()
        {
            try
            {
                CosapinoAppEntities context = new CosapinoAppEntities();
                List<Distrito> LstDistrito = context.Distrito.ToList();
                List<DistritosBE> LstDistritoBe = new List<DistritosBE>();

                foreach (var item in LstDistrito)
                {
                    DistritosBE objDistritoBe = new DistritosBE(item.DistritoId,
                        item.Descripcion,item.ProvinciaId, item.Estado, item.UbigeoId);

                    LstDistritoBe.Add(objDistritoBe);
                }
                return LstDistritoBe;
            }
            catch (Exception ex)
            {
                return new List<DistritosBE>();
            }
        }

        [HttpGet]
        [Route("Notificado/List")]
        public List<NotificacionBE> GetListNotificado()
        {
            try
            {
                CosapinoAppEntities context = new CosapinoAppEntities();
                List<Notificacion> LstNotificacion = context.Notificacion.ToList();
                List<NotificacionBE> LstNotificacionBe = new List<NotificacionBE>();

                foreach (var item in LstNotificacion)
                {
                    NotificacionBE objNotificacionBE = new NotificacionBE(item.NotificacionId,
                        item.Titulo, item.Mensaje,item.Fecha,item.Estado,item.EsCorreo,item.EsNotificacion);

                    LstNotificacionBe.Add(objNotificacionBE);
                }
                return LstNotificacionBe;
            }
            catch (Exception ex)
            {
                return new List<NotificacionBE>();
            }
        }

        [HttpGet]
        [Route("Area/List")]
        public List<AreasBE> GetListArea()
        {
            try
            {
                CosapinoAppEntities context = new CosapinoAppEntities();
                List<Area> LstArea = context.Area.ToList();
                List<AreasBE> LstAreaBe = new List<AreasBE>();

                foreach (var item in LstArea)
                {
                    AreasBE objAreasBE = new AreasBE(item.AreaId,
                        item.Nombre, item.Estado, item.UnidadNegocioId);

                    LstAreaBe.Add(objAreasBE);
                }
                return LstAreaBe;
            }
            catch (Exception ex)
            {
                return new List<AreasBE>();
            }
        }
    }
}