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
    
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkaID { get; set; }
        public int NarudzbaID { get; set; }
        public int ProizvodID { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Narudzbe Narudzbe { get; set; }
        public virtual Proizvodi Proizvodi { get; set; }
    }
}
