using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DAKupci
    {
        public static void Insert(Kupci kupac)
        {
            Connection.dm.esp_Kupci_Insert(kupac.Ime, kupac.Prezime, kupac.Email,
                                           kupac.KorisnickoIme, kupac.LozinkaSalt, kupac.LozinkaHash);
        }

        public static Kupci SelectByKorisnickoIme(string korisnickoIme, string lozinka)
        {
            Kupci k = Connection.dm.esp_Kupci_SelectByKorisnickoIme(korisnickoIme).FirstOrDefault();

            if (k != null)
            {
                if (Util.UIHelper.GenerateHash(lozinka, k.LozinkaSalt) == k.LozinkaHash)
                    return k;
                else
                    throw new Exception("Unijeli ste pogrešnu lozinku.");

            }

            return null;

        }

    }
}
