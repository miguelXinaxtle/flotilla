//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UnidadPropiedad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnidadPropiedad()
        {
            this.SincronizacionUnidad = new HashSet<SincronizacionUnidad>();
        }
    
        public decimal idUnidad { get; set; }
        public string vin { get; set; }
        public decimal idDocumento { get; set; }
        public string valor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SincronizacionUnidad> SincronizacionUnidad { get; set; }
    }
}
