using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja_Service.Data;

namespace eProdaja_Service.Data
{
    public class DABrosure
    {
        public static void Insert(Brosure b)
        {
            Connection.dm.esp_Brosure_Insert(b.NazivBrosure,b.DatumPocetka,b.DatumIsteka);
        }

        public static void insertBrosureProizvodi(BrosureProizvodi bp)
        {
            Connection.dm.esp_ProizvodiBrosure_Insert(bp.ProizvodID, bp.BrosuraID,bp.AkcijskaCijena);
        }

        public static List<Brosure> SelectAll()
        {
            List<Brosure> brosure = Connection.dm.Brosure.OrderBy(x => x.NazivBrosure).ToList();

            Brosure empty = new Brosure();
            empty.BrosuraID = 0;
            empty.NazivBrosure = "";
            brosure.Insert(0, empty);

            return brosure;
        }

        public static List<esp_Proizvodi_SelectByBrosura_Result> GetBrosura(int brosuraId)
        {
            return Connection.dm.esp_Proizvodi_SelectByBrosura(brosuraId).ToList();
        }

        public static List<esp_BrosureProizvodiGetByBrosuraID_Result> GetBrosureProizvodi(int BrosuraId)
        {
            return Connection.dm.esp_BrosureProizvodiGetByBrosuraID(BrosuraId).ToList();
        }

    }
}
