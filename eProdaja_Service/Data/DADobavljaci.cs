using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DADobavljaci
    {
        public static List<Dobavljaci> SelectByNaziv(string naziv)
        {
            return Connection.dm.esp_Dobavljaci_SelectByNaziv(naziv).ToList();
        }

        public static Dobavljaci SelectById(int dobavljacId)
        {
            return Connection.dm.esp_Dobavljaci_SelectById(dobavljacId).First();
        }
    }
}
