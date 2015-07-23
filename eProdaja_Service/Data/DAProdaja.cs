using eProdaja_Service.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DAProdaja
    {
        public static int InsertProdaju(Izlazi i, List<IzlazStavke> izlazStavke)
        {
            int izID = 0;
            try
            {
                Int32 izlazID = Convert.ToInt32(Connection.dm.esp_Izlazi_Insert(i.BrojRacuna, i.KorisnikID, i.Zakljucen, i.IznosBezPDV, i.IznosSaPDV, i.SkladisteID).First());
                izID = izlazID;
                foreach (IzlazStavke IzS in izlazStavke)
                {
                    Connection.dm.esp_IzlazStavke_Insert(izlazID, IzS.ProizvodID, IzS.Kolicina, IzS.Cijena, IzS.Popust);
                }
            }
            catch (EntityException e)
            {
                ExceptionHandler.HandleException(e);
            }
            return izID;
        }

        public static string GetZadnjiRacun() {
            return Connection.dm.esp_Izlazi_GetZadnjiRacun().First().ToString();
        }
    }
}
