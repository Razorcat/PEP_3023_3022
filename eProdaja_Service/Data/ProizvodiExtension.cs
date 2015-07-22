using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public partial class Proizvodi
    {
        public override string ToString()
        {
            return Sifra + "-" + Naziv;
        }
    }
}
