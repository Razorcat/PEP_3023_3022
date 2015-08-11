using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DAPitanjaOdgovori
    {
        public static void InsertPitanje(int kupacId, string pitanje)
        {
            Connection.dm.esp_Pitanja_Insert(kupacId, pitanje);
        }
        public static void InsertOdgovor(int pitanjeId,int korisnikId, string odgovor)
        {
            Connection.dm.esp_Pitanja_OdgovorInsert(pitanjeId, korisnikId, odgovor);
        }
        public static List<esp_Pitanja_GetAll_Result> GetPitanja() {
            return Connection.dm.esp_Pitanja_GetAll().ToList();
        }
    }
}
