using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DASkladista
    {
        public static List<Skladista> SelectAll()
        {
            List<Skladista> skladista = Connection.dm.Skladista.OrderBy(x => x.Naziv).ToList();

            Skladista empty = new Skladista();
            empty.SkladisteID = 0;
            empty.Naziv = "";
            skladista.Insert(0, empty);

            return skladista;
        }

        public static List<esp_Proizvodi_SelectBySkladiste_Result> GetStanjeSkladista(int skladisteId)
        {
            return Connection.dm.esp_Proizvodi_SelectBySkladiste(skladisteId).ToList();        
        }
    }
}
