using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_AdminUI
{
    public class Global
    {
        //Pristup sistemu
        public static eProdaja_Service.Data.Korisnici prijavljeniKorisnik { get; set; }

        //Učitavanje poruke na osnovu ključa
        public static string GetString(string key)
        {
            ResourceManager rm = new ResourceManager("eProdaja_AdminUI.Poruke", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}
