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
    
    public partial class Unidad
    {
        public decimal idUnidad { get; set; }
        public string vin { get; set; }
        public string idLicitacion { get; set; }
        public string economicoInt { get; set; }
        public string economicoExt { get; set; }
        public string placa { get; set; }
        public string poliza { get; set; }
        public string tenencia { get; set; }
        public string verificacion { get; set; }
        public string permisoEspecial { get; set; }
        public string domicilioEntrega { get; set; }
    
        public virtual LicitacionUnidad LicitacionUnidad { get; set; }
    }
}
