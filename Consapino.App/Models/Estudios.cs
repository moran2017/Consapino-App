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
    
    public partial class Estudios
    {
        public int EstudiosId { get; set; }
        public int ProfesionId { get; set; }
        public string OtraProfesion { get; set; }
        public int InstitucionId { get; set; }
        public string OtraInstitucion { get; set; }
        public int ColegiaturaId { get; set; }
        public string Estado { get; set; }
        public int TrabajadorId { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }
        public Nullable<int> GradoId { get; set; }
    
        public virtual Grado Grado { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual Profesion Profesion { get; set; }
        public virtual Trabajador Trabajador { get; set; }
    }
}
