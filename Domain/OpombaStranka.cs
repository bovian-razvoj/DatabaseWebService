//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseWebService.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class OpombaStranka
    {
        public int idOpombaStranka { get; set; }
        public Nullable<int> idStranka { get; set; }
        public string Opomba { get; set; }
        public Nullable<System.DateTime> ts { get; set; }
        public Nullable<int> tsIDOsebe { get; set; }
    
        public virtual Stranka Stranka { get; set; }
    }
}
