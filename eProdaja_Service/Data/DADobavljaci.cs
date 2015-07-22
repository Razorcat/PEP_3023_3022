using eProdaja_Service.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
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
        public static List<Dobavljaci> SelectByNazivAll(String naziv)
        {
            return Connection.dm.esp_Dobavljaci_SelectByNazivAll(naziv).ToList();
        }

        public static Dobavljaci SelectById(int dobavljacId)
        {
            return Connection.dm.esp_Dobavljaci_SelectById(dobavljacId).First();
        }
        public static void UpdateStatus(int DobavljacId, bool status)
        {
            Connection.dm.esp_Dobavljaci_UpdateStatus(DobavljacId, status);
        }

        public static void InsertDobavljaca(Dobavljaci dobavljac)
        {
            try
            {
                Connection.dm.esp_Dobavljaci_Insert(dobavljac.Naziv, dobavljac.KontaktOsoba, dobavljac.Adresa, dobavljac.Telefon,
                        dobavljac.Fax, dobavljac.Web, dobavljac.Email, dobavljac.ZiroRacuni, dobavljac.Napomena,dobavljac.Status);
            }
            catch (EntityException e)
            {
                ExceptionHandler.HandleException(e);
            }
        }
    }
}
