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
    
    public partial class Profesion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesion()
        {
            this.Estudios = new HashSet<Estudios>();
            this.PostGrado = new HashSet<PostGrado>();
        }
    
        public int ProfesionId { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public Nullable<int> InstitucionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estudios> Estudios { get; set; }
        public virtual Institucion Institucion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostGrado> PostGrado { get; set; }
    }
}
