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
    
    public partial class UnidadNegocio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnidadNegocio()
        {
            this.Area = new HashSet<Area>();
            this.Experiencia = new HashSet<Experiencia>();
        }
    
        public int UnidadNegocioId { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public int DistribucionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Area> Area { get; set; }
        public virtual Distribucion Distribucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Experiencia> Experiencia { get; set; }
    }
}
