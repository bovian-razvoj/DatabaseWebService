//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseWebService.DomainPDO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nastavitve
    {
        public int NastavitveID { get; set; }
        public Nullable<int> PovprasevanjeStevilcenjeStev { get; set; }
        public string PovprasevanjeStevilcenjePredpona { get; set; }
        public string Opombe { get; set; }
        public Nullable<System.DateTime> ts { get; set; }
        public Nullable<int> tsIDOsebe { get; set; }
        public Nullable<System.DateTime> tsUpdate { get; set; }
        public Nullable<int> tsUpdateUserID { get; set; }
        public Nullable<bool> PosiljanjePoste { get; set; }
        public string EmailStreznik { get; set; }
        public Nullable<int> EmailVrata { get; set; }
        public Nullable<bool> EmailSifriranjeSSL { get; set; }
    }
}