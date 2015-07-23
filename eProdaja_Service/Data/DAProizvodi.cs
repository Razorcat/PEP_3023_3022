using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Data
{
    public class DAProizvodi
    {
        public static int TotalRows { get; set; }
        public static void Insert(Proizvodi proizvod)
        {
            Connection.dm.esp_Proizvodi_Insert(proizvod.Naziv, proizvod.Sifra, proizvod.Cijena,
                                               proizvod.VrstaID, proizvod.JedinicaMjereID, proizvod.Slika, proizvod.SlikaThumb);
        }

        public static void VrsteProizvodaInsert(VrsteProizvoda vrste)
        {
            Connection.dm.esp_VrsteProizvoda_Insert(vrste.Naziv);

        }
        public static List<VrsteProizvoda> VrsteSelect()
        {
            List<VrsteProizvoda> vrste = Connection.dm.VrsteProizvoda.OrderBy(x => x.Naziv).ToList();

            VrsteProizvoda empty = new VrsteProizvoda();
            empty.VrstaID = 0;
            empty.Naziv = "";
            vrste.Insert(0, empty);

            return vrste;
        }

        public static List<JediniceMjere> JediniceMjereSelect()
        {
            List<JediniceMjere> jedinice = Connection.dm.JediniceMjere.OrderBy(x => x.Naziv).ToList();

            JediniceMjere empty = new JediniceMjere();
            empty.JedinicaMjereID = 0;
            empty.Naziv = "";
            jedinice.Insert(0, empty);

            return jedinice;
        }

        public static Object SelectByVrsta(int vrstaId)
        {
            return Connection.dm.esp_Proizvodi_SelectByVrsta(vrstaId).ToList();
        }

        public static List<esp_Proizvodi_SelectBySifraNaziv_Result> SelectBySifraNaziv(string sifra, string naziv)
        {
            return Connection.dm.esp_Proizvodi_SelectBySifraNaziv(sifra, naziv).ToList();
        }

        public static Proizvodi SelectById(int proizvodId)
        {
            return Connection.dm.esp_Proizvodi_SelectById(proizvodId).FirstOrDefault();
        }

        public static object SelectByNaziv(string p)
        {
            return Connection.dm.esp_Proizvodi_SelectByNaziv(p);
        }

        public static List<Brosure> SelectBrosuru()
        {
            return Connection.dm.Brosure.ToList();

        }

        public static object SelectBrosure()
        {

            return Connection.dm.esp_BrosureProizvodi_SelectAll();
        }

        public static DataRow SelectById2(int proizvodId)
        { 
            SqlConnection con = new SqlConnection(Connection.dm.Database.Connection.ConnectionString);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("esp_Proizvodi_SelectById", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("ProizvodID", SqlDbType.Int).Value = proizvodId;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                return dt.Rows[0];
            }
            finally
            {
                con.Close();
            }
         
        }

        public static List<esp_Proizvodi_SelectByVrstaNaziv_Result> SelectByVrstaNaziv(int vrstaId, string naziv, int offset, int maxRows)
        {
            System.Data.Entity.Core.Objects.ObjectParameter total = new System.Data.Entity.Core.Objects.ObjectParameter("TotalRows", 0);
            List<esp_Proizvodi_SelectByVrstaNaziv_Result> proizvodi = Connection.dm.esp_Proizvodi_SelectByVrstaNaziv(vrstaId, naziv, offset, maxRows, total).ToList();

            TotalRows = Convert.ToInt32(total.Value);

            return proizvodi;
        }

        public static List<esp_Izlaz_SelectByDatum_Result> SelectProdajaByDatum(DateTime datumOd, DateTime datumDo)
        {
            return Connection.dm.esp_Izlaz_SelectByDatum(datumOd, datumDo).ToList();
        }

        public static List<esp_ProizvodiSkladiste_SelectByNazivSifra_Result> SelectByNazivSifra(string Naziv, string Sifra) {
            return Connection.dm.esp_ProizvodiSkladiste_SelectByNazivSifra(Naziv, Sifra).ToList();
        }


        #region Nabavka
        public static void InsertNabavka(Ulazi ulaz, List<UlazStavke> stavke)
        {
            int ulazId = Convert.ToInt32(Connection.dm.esp_Ulazi_Insert(ulaz.BrojFakture, ulaz.Datum, ulaz.IznosRacuna, ulaz.PDV,
                                           ulaz.Napomena, ulaz.SkladisteID, ulaz.KorisnikID, ulaz.DobavljacID).First());
            
            foreach (UlazStavke s in stavke)
            {
                Connection.dm.esp_UlazStavke_Insert(ulazId, s.ProizvodID, s.Kolicina, s.Cijena);
            }
        }

        #endregion
    }
}
