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
    
    public partial class PerfilDocumento
    {
        public decimal idPerfilDocumento { get; set; }
        public decimal idRol { get; set; }
        public decimal idDocumento { get; set; }
        public bool consultar { get; set; }
        public bool cargar { get; set; }
        public bool descargar { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
