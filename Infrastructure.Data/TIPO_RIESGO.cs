//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_RIESGO
    {
        public TIPO_RIESGO()
        {
            this.POLIZAs = new HashSet<POLIZA>();
        }
    
        public int ID_TIPO_RIESGO { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ICollection<POLIZA> POLIZAs { get; set; }
    }
}