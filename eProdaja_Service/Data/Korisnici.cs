//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eProdaja_Service.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnici
    {
        public Korisnici()
        {
            this.Izlazi = new HashSet<Izlazi>();
            this.KorisniciUloge = new HashSet<KorisniciUloge>();
            this.Ulazi = new HashSet<Ulazi>();
        }
    
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }
    
        public virtual ICollection<Izlazi> Izlazi { get; set; }
        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual ICollection<Ulazi> Ulazi { get; set; }
    }
}
