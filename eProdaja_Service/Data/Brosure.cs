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
    
    public partial class Brosure
    {
        public Brosure()
        {
            this.BrosureProizvodi = new HashSet<BrosureProizvodi>();
        }
    
        public int BrosuraID { get; set; }
        public string NazivBrosure { get; set; }
        public System.DateTime DatumPocetka { get; set; }
        public System.DateTime DatumIsteka { get; set; }
    
        public virtual ICollection<BrosureProizvodi> BrosureProizvodi { get; set; }
    }
}
