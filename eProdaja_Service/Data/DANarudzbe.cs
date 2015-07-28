using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DANarudzbe
    {
        public static void Insert(Narudzbe narudzba, string korisnickoIme)
        {
            narudzba.KupacID = Connection.dm.esp_Kupci_SelectByKorisnickoIme(korisnickoIme).First().KupacID;

            Connection.dm.Narudzbe.Add(narudzba);
            Connection.dm.SaveChanges();            
        }

      
        public static string GetMaxBrojNarudzbe()
        {
            Narudzbe lastOrder = Connection.dm.Narudzbe.OrderByDescending(x => x.NarudzbaID).Take(1).FirstOrDefault();
            if (lastOrder != null)
                return lastOrder.BrojNarudzbe;

            return "0-yyyy";
        }

        public static int CountAktivne()
        {
            return Connection.dm.Narudzbe.Where(x => x.Status == true).Count();
        }
        public static List<esp_Narudzbe_SelectAktivne_Result> SelectAktivne()
        {
            return Connection.dm.esp_Narudzbe_SelectAktivne().ToList();
        }

        public static List<esp_Narudzbe_GetProizvodeByNarudzbaId_Result> GetProizvodeNarudzbaByID(int NarudzbaId) {
            return Connection.dm.esp_Narudzbe_GetProizvodeByNarudzbaId(NarudzbaId).ToList();
        }
        public static void OtkaziNarudzbu(int NarudzbaId, bool Otkazano) {
            Connection.dm.esp_Narudzbe_Otkazi(NarudzbaId, Otkazano);
        }
        public static NarudzbaStavke NarudzbeStavkaGetByProizvodId(int ProizvodId) {
            return Connection.dm.esp_NarudzbeStavka_GetByProizvodID(ProizvodId).First();
        }
    }
}
