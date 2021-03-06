//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consapino.App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experiencia
    {
        public int ExperienciaId { get; set; }
        public Nullable<int> AreaId { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public Nullable<bool> EsActual { get; set; }
        public Nullable<int> SubSectorId { get; set; }
        public Nullable<int> UnidaNegocioId { get; set; }
        public string NombreCliente { get; set; }
        public int EmpresaId { get; set; }
        public string OtraEmpresa { get; set; }
        public int TrabajadorId { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string Funcion { get; set; }
        public Nullable<int> SectorId { get; set; }
        public Nullable<int> ProyectoId { get; set; }
        public string NombreProyecto { get; set; }
        public Nullable<int> TipoProyectoId { get; set; }
        public Nullable<int> DistribucionId { get; set; }
        public Nullable<int> PosicionId { get; set; }
        public Nullable<decimal> MontoProyecto { get; set; }
        public Nullable<int> TipoMonedaId { get; set; }
        public Nullable<int> PersonasCargoId { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual Distribucion Distribucion { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual PersonasCargo PersonasCargo { get; set; }
        public virtual Posicion Posicion { get; set; }
        public virtual Proyecto Proyecto { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual TipoMoneda TipoMoneda { get; set; }
        public virtual TipoProyecto TipoProyecto { get; set; }
        public virtual Trabajador Trabajador { get; set; }
        public virtual UnidadNegocio UnidadNegocio { get; set; }
    }
}
