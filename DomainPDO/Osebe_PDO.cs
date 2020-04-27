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
    
    public partial class Osebe_PDO
    {
        public Osebe_PDO()
        {
            this.OsebeNadrejeni_PDO = new HashSet<OsebeNadrejeni_PDO>();
            this.OsebeNadrejeni_PDO1 = new HashSet<OsebeNadrejeni_PDO>();
            this.StrankaZaposleni_PDO = new HashSet<StrankaZaposleni_PDO>();
            this.SystemEmailMessage_PDO = new HashSet<SystemEmailMessage_PDO>();
            this.Povprasevanje = new HashSet<Povprasevanje>();
        }
    
        public int OsebaID { get; set; }
        public int VlogaID { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov { get; set; }
        public Nullable<System.DateTime> DatumRojstva { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DatumZaposlitve { get; set; }
        public string UporabniskoIme { get; set; }
        public string Geslo { get; set; }
        public string TelefonGSM { get; set; }
        public Nullable<int> Zunanji { get; set; }
        public string DelovnoMesto { get; set; }
        public string ProfileImage { get; set; }
        public Nullable<System.DateTime> ts { get; set; }
        public Nullable<int> tsIDOsebe { get; set; }
        public Nullable<System.DateTime> tsUpdate { get; set; }
        public Nullable<int> tsUpdateUserID { get; set; }
        public Nullable<bool> PDODostop { get; set; }
        public string EmailGeslo { get; set; }
        public string EmailStreznik { get; set; }
        public Nullable<int> EmailVrata { get; set; }
        public Nullable<bool> EmailSifriranjeSSL { get; set; }
        public string Podpis { get; set; }
        public string PantheonUsrID { get; set; }
    
        public virtual ICollection<OsebeNadrejeni_PDO> OsebeNadrejeni_PDO { get; set; }
        public virtual ICollection<OsebeNadrejeni_PDO> OsebeNadrejeni_PDO1 { get; set; }
        public virtual ICollection<StrankaZaposleni_PDO> StrankaZaposleni_PDO { get; set; }
        public virtual Vloga_PDO Vloga_PDO { get; set; }
        public virtual ICollection<SystemEmailMessage_PDO> SystemEmailMessage_PDO { get; set; }
        public virtual ICollection<Povprasevanje> Povprasevanje { get; set; }
    }
}