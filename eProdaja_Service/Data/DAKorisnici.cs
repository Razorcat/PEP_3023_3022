using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace eProdaja_Service.Data
{
    public class DAKorisnici
    {
        public static void Insert(Korisnici korisnik)
        {
            try
            {
                int korisnikId = Convert.ToInt32(Connection.dm.esp_Korisnici_Insert(korisnik.Ime, korisnik.Prezime, korisnik.Email,
                                                                       korisnik.Telefon, korisnik.KorisnickoIme, korisnik.LozinkaSalt, korisnik.LozinkaHash).FirstOrDefault());

                foreach (Uloge item in korisnik.Uloge)
                {
                    Connection.dm.esp_KorisniciUloge_Insert(korisnikId, item.UlogaID);
                }
            }
            catch (EntityException e)
            {
                Util.ExceptionHandler.HandleException(e);
            }
        }

        public static void Update(Korisnici korisnik)
        {
            Connection.dm.esp_Korisnici_Update(korisnik.KorisnikID, korisnik.Ime, korisnik.Prezime,
                                               korisnik.Email, korisnik.Telefon);

        }

        public static void UpdateStatus(int korisnikId, bool status)
        {
            Connection.dm.esp_Korisnici_UpdateStatus(korisnikId, status);
        }

        public static List<Uloge> UlogeSelect()
        {
            return Connection.dm.Uloge.OrderBy(x => x.Naziv).ToList();
        }

        public static Korisnici SelectByKorisnickoIme(string korisnickoIme, string lozinka)
        {
            Korisnici k = Connection.dm.esp_Korisnici_SelectByKorisnickoIme(korisnickoIme).FirstOrDefault();

            if (k != null)
            {
                if (Util.UIHelper.GenerateHash(lozinka, k.LozinkaSalt) == k.LozinkaHash)
                {
                    k.Uloge = Connection.dm.esp_KorisniciUloge_SelectByKorisnik(k.KorisnikID).ToList();
                    return k;
                }
            }

            
            return null;
        }

        public static Korisnici SelectById(int korisnikId)
        {
            return Connection.dm.esp_Korisnici_SelectById(korisnikId).FirstOrDefault();
        }

        public static List<esp_Korisnici_SelectByName_Result> SelectByName(string imePrezime)
        {
            return Connection.dm.esp_Korisnici_SelectByName(imePrezime).ToList();
        }

        public static List<Uloge> SelectUloge(int korisnikId)
        {
            return Connection.dm.esp_KorisniciUloge_SelectByKorisnik(korisnikId).ToList();
        }

        public static void UpdateUloge(int korisnikId, List<Uloge> uloge)
        {
            Connection.dm.esp_KorisniciUloge_Delete(korisnikId);

            foreach (Uloge item in uloge)
            {
                Connection.dm.esp_KorisniciUloge_Insert(korisnikId, item.UlogaID);
            }

        }

        public static void ResetPassword(Korisnici k)
        {
            Connection.dm.esp_Korisnici_ResetPass(k.KorisnikID, k.LozinkaSalt, k.LozinkaHash);
        }
      
    }
}
