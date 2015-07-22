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

    }
}
