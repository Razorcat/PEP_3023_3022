﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eProdaja_Service.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class eProdajaEntities : DbContext
    {
        public eProdajaEntities()
            : base("name=eProdajaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Dobavljaci> Dobavljaci { get; set; }
        public DbSet<Izlazi> Izlazi { get; set; }
        public DbSet<IzlazStavke> IzlazStavke { get; set; }
        public DbSet<JediniceMjere> JediniceMjere { get; set; }
        public DbSet<Korisnici> Korisnici { get; set; }
        public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Kupci> Kupci { get; set; }
        public DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<Narudzbe> Narudzbe { get; set; }
        public DbSet<Ocjene> Ocjene { get; set; }
        public DbSet<Proizvodi> Proizvodi { get; set; }
        public DbSet<Skladista> Skladista { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Ulazi> Ulazi { get; set; }
        public DbSet<UlazStavke> UlazStavke { get; set; }
        public DbSet<Uloge> Uloge { get; set; }
        public DbSet<VrsteProizvoda> VrsteProizvoda { get; set; }
        public DbSet<BrosureProizvodi> BrosureProizvodi { get; set; }
        public DbSet<Brosure> Brosure { get; set; }
    
        public virtual ObjectResult<Nullable<decimal>> esp_Korisnici_Insert(string ime, string prezime, string email, string telefon, string korisnickoIme, string lozinkaSalt, string lozinkaHash)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_Korisnici_Insert", imeParameter, prezimeParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectByKorisnickoIme(string korisnickoIme)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectByKorisnickoIme", korisnickoImeParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectByKorisnickoIme(string korisnickoIme, MergeOption mergeOption)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectByKorisnickoIme", mergeOption, korisnickoImeParameter);
        }
    
        public virtual int esp_KorisniciUloge_Insert(Nullable<int> korisnikID, Nullable<int> ulogaID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var ulogaIDParameter = ulogaID.HasValue ?
                new ObjectParameter("UlogaID", ulogaID) :
                new ObjectParameter("UlogaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_KorisniciUloge_Insert", korisnikIDParameter, ulogaIDParameter);
        }
    
        public virtual ObjectResult<Uloge> esp_KorisniciUloge_SelectByKorisnik(Nullable<int> korisnikID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Uloge>("esp_KorisniciUloge_SelectByKorisnik", korisnikIDParameter);
        }
    
        public virtual ObjectResult<Uloge> esp_KorisniciUloge_SelectByKorisnik(Nullable<int> korisnikID, MergeOption mergeOption)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Uloge>("esp_KorisniciUloge_SelectByKorisnik", mergeOption, korisnikIDParameter);
        }
    
        public virtual int esp_Korisnici_ResetPass(Nullable<int> korisnikID, string lozinkaSalt, string lozinkaHash)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Korisnici_ResetPass", korisnikIDParameter, lozinkaSaltParameter, lozinkaHashParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectById(Nullable<int> korisnikID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectById", korisnikIDParameter);
        }
    
        public virtual ObjectResult<Korisnici> esp_Korisnici_SelectById(Nullable<int> korisnikID, MergeOption mergeOption)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici>("esp_Korisnici_SelectById", mergeOption, korisnikIDParameter);
        }
    
        public virtual ObjectResult<esp_Korisnici_SelectByName_Result> esp_Korisnici_SelectByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Korisnici_SelectByName_Result>("esp_Korisnici_SelectByName", nameParameter);
        }
    
        public virtual int esp_Korisnici_Update(Nullable<int> korisnikID, string ime, string prezime, string email, string telefon)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Korisnici_Update", korisnikIDParameter, imeParameter, prezimeParameter, emailParameter, telefonParameter);
        }
    
        public virtual int esp_Korisnici_UpdateStatus(Nullable<int> korisnikID, Nullable<bool> status)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Korisnici_UpdateStatus", korisnikIDParameter, statusParameter);
        }
    
        public virtual int esp_KorisniciUloge_Delete(Nullable<int> korisnikID)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_KorisniciUloge_Delete", korisnikIDParameter);
        }
    
        public virtual ObjectResult<Dobavljaci> esp_Dobavljaci_SelectById(Nullable<int> dobavljacID)
        {
            var dobavljacIDParameter = dobavljacID.HasValue ?
                new ObjectParameter("DobavljacID", dobavljacID) :
                new ObjectParameter("DobavljacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Dobavljaci>("esp_Dobavljaci_SelectById", dobavljacIDParameter);
        }
    
        public virtual ObjectResult<Dobavljaci> esp_Dobavljaci_SelectById(Nullable<int> dobavljacID, MergeOption mergeOption)
        {
            var dobavljacIDParameter = dobavljacID.HasValue ?
                new ObjectParameter("DobavljacID", dobavljacID) :
                new ObjectParameter("DobavljacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Dobavljaci>("esp_Dobavljaci_SelectById", mergeOption, dobavljacIDParameter);
        }
    
        public virtual ObjectResult<Dobavljaci> esp_Dobavljaci_SelectByNaziv(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Dobavljaci>("esp_Dobavljaci_SelectByNaziv", nazivParameter);
        }
    
        public virtual ObjectResult<Dobavljaci> esp_Dobavljaci_SelectByNaziv(string naziv, MergeOption mergeOption)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Dobavljaci>("esp_Dobavljaci_SelectByNaziv", mergeOption, nazivParameter);
        }
    
        public virtual int esp_Proizvodi_Insert(string naziv, string sifra, Nullable<decimal> cijena, Nullable<int> vrstaID, Nullable<int> jedinicaMjereID, byte[] slika, byte[] slikaThumb)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var sifraParameter = sifra != null ?
                new ObjectParameter("Sifra", sifra) :
                new ObjectParameter("Sifra", typeof(string));
    
            var cijenaParameter = cijena.HasValue ?
                new ObjectParameter("Cijena", cijena) :
                new ObjectParameter("Cijena", typeof(decimal));
    
            var vrstaIDParameter = vrstaID.HasValue ?
                new ObjectParameter("VrstaID", vrstaID) :
                new ObjectParameter("VrstaID", typeof(int));
    
            var jedinicaMjereIDParameter = jedinicaMjereID.HasValue ?
                new ObjectParameter("JedinicaMjereID", jedinicaMjereID) :
                new ObjectParameter("JedinicaMjereID", typeof(int));
    
            var slikaParameter = slika != null ?
                new ObjectParameter("Slika", slika) :
                new ObjectParameter("Slika", typeof(byte[]));
    
            var slikaThumbParameter = slikaThumb != null ?
                new ObjectParameter("SlikaThumb", slikaThumb) :
                new ObjectParameter("SlikaThumb", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Proizvodi_Insert", nazivParameter, sifraParameter, cijenaParameter, vrstaIDParameter, jedinicaMjereIDParameter, slikaParameter, slikaThumbParameter);
        }
    
        public virtual ObjectResult<Proizvodi> esp_Proizvodi_SelectById(Nullable<int> proizvodID)
        {
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proizvodi>("esp_Proizvodi_SelectById", proizvodIDParameter);
        }
    
        public virtual ObjectResult<Proizvodi> esp_Proizvodi_SelectById(Nullable<int> proizvodID, MergeOption mergeOption)
        {
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proizvodi>("esp_Proizvodi_SelectById", mergeOption, proizvodIDParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectBySifraNaziv_Result> esp_Proizvodi_SelectBySifraNaziv(string sifra, string naziv)
        {
            var sifraParameter = sifra != null ?
                new ObjectParameter("Sifra", sifra) :
                new ObjectParameter("Sifra", typeof(string));
    
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectBySifraNaziv_Result>("esp_Proizvodi_SelectBySifraNaziv", sifraParameter, nazivParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectByVrsta_Result> esp_Proizvodi_SelectByVrsta(Nullable<int> vrstaID)
        {
            var vrstaIDParameter = vrstaID.HasValue ?
                new ObjectParameter("VrstaID", vrstaID) :
                new ObjectParameter("VrstaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectByVrsta_Result>("esp_Proizvodi_SelectByVrsta", vrstaIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_Ulazi_Insert(string brojFakture, Nullable<System.DateTime> datum, Nullable<decimal> iznosRacuna, Nullable<decimal> pDV, string napomena, Nullable<int> skladisteID, Nullable<int> korisnikID, Nullable<int> dobavljacID)
        {
            var brojFaktureParameter = brojFakture != null ?
                new ObjectParameter("BrojFakture", brojFakture) :
                new ObjectParameter("BrojFakture", typeof(string));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            var iznosRacunaParameter = iznosRacuna.HasValue ?
                new ObjectParameter("IznosRacuna", iznosRacuna) :
                new ObjectParameter("IznosRacuna", typeof(decimal));
    
            var pDVParameter = pDV.HasValue ?
                new ObjectParameter("PDV", pDV) :
                new ObjectParameter("PDV", typeof(decimal));
    
            var napomenaParameter = napomena != null ?
                new ObjectParameter("Napomena", napomena) :
                new ObjectParameter("Napomena", typeof(string));
    
            var skladisteIDParameter = skladisteID.HasValue ?
                new ObjectParameter("SkladisteID", skladisteID) :
                new ObjectParameter("SkladisteID", typeof(int));
    
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var dobavljacIDParameter = dobavljacID.HasValue ?
                new ObjectParameter("DobavljacID", dobavljacID) :
                new ObjectParameter("DobavljacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_Ulazi_Insert", brojFaktureParameter, datumParameter, iznosRacunaParameter, pDVParameter, napomenaParameter, skladisteIDParameter, korisnikIDParameter, dobavljacIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_UlazStavke_Insert(Nullable<int> ulazID, Nullable<int> proizvodID, Nullable<int> kolicina, Nullable<decimal> cijena)
        {
            var ulazIDParameter = ulazID.HasValue ?
                new ObjectParameter("UlazID", ulazID) :
                new ObjectParameter("UlazID", typeof(int));
    
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            var kolicinaParameter = kolicina.HasValue ?
                new ObjectParameter("Kolicina", kolicina) :
                new ObjectParameter("Kolicina", typeof(int));
    
            var cijenaParameter = cijena.HasValue ?
                new ObjectParameter("Cijena", cijena) :
                new ObjectParameter("Cijena", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_UlazStavke_Insert", ulazIDParameter, proizvodIDParameter, kolicinaParameter, cijenaParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectByVrstaNaziv_Result> esp_Proizvodi_SelectByVrstaNaziv(Nullable<int> vrstaID, string naziv, Nullable<int> offset, Nullable<int> maxRows, ObjectParameter totalRows)
        {
            var vrstaIDParameter = vrstaID.HasValue ?
                new ObjectParameter("VrstaID", vrstaID) :
                new ObjectParameter("VrstaID", typeof(int));
    
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var offsetParameter = offset.HasValue ?
                new ObjectParameter("Offset", offset) :
                new ObjectParameter("Offset", typeof(int));
    
            var maxRowsParameter = maxRows.HasValue ?
                new ObjectParameter("MaxRows", maxRows) :
                new ObjectParameter("MaxRows", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectByVrstaNaziv_Result>("esp_Proizvodi_SelectByVrstaNaziv", vrstaIDParameter, nazivParameter, offsetParameter, maxRowsParameter, totalRows);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_Kupci_Insert(string ime, string prezime, string email, string korisnickoIme, string lozinkaSalt, string lozinkaHash)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_Kupci_Insert", imeParameter, prezimeParameter, emailParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter);
        }
    
        public virtual ObjectResult<Kupci> esp_Kupci_SelectByKorisnickoIme(string korisnickoIme)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Kupci>("esp_Kupci_SelectByKorisnickoIme", korisnickoImeParameter);
        }
    
        public virtual ObjectResult<Kupci> esp_Kupci_SelectByKorisnickoIme(string korisnickoIme, MergeOption mergeOption)
        {
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Kupci>("esp_Kupci_SelectByKorisnickoIme", mergeOption, korisnickoImeParameter);
        }
    
        public virtual ObjectResult<esp_Narudzbe_SelectAktivne_Result> esp_Narudzbe_SelectAktivne()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Narudzbe_SelectAktivne_Result>("esp_Narudzbe_SelectAktivne");
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectBySkladiste_Result> esp_Proizvodi_SelectBySkladiste(Nullable<int> skladisteID)
        {
            var skladisteIDParameter = skladisteID.HasValue ?
                new ObjectParameter("SkladisteID", skladisteID) :
                new ObjectParameter("SkladisteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectBySkladiste_Result>("esp_Proizvodi_SelectBySkladiste", skladisteIDParameter);
        }
    
        public virtual ObjectResult<esp_Izlaz_SelectByDatum_Result> esp_Izlaz_SelectByDatum(Nullable<System.DateTime> datumOd, Nullable<System.DateTime> datumDo)
        {
            var datumOdParameter = datumOd.HasValue ?
                new ObjectParameter("DatumOd", datumOd) :
                new ObjectParameter("DatumOd", typeof(System.DateTime));
    
            var datumDoParameter = datumDo.HasValue ?
                new ObjectParameter("DatumDo", datumDo) :
                new ObjectParameter("DatumDo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Izlaz_SelectByDatum_Result>("esp_Izlaz_SelectByDatum", datumOdParameter, datumDoParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> esp_VrsteProizvoda_Insert(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("esp_VrsteProizvoda_Insert", nazivParameter);
        }
    
        public virtual ObjectResult<VrsteProizvoda> esp_VrsteProizvoda_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VrsteProizvoda>("esp_VrsteProizvoda_SelectAll");
        }
    
        public virtual ObjectResult<VrsteProizvoda> esp_VrsteProizvoda_SelectAll(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VrsteProizvoda>("esp_VrsteProizvoda_SelectAll", mergeOption);
        }
    
        public virtual ObjectResult<Proizvodi> esp_Proizvodi_SelectByNaziv(string naziv)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("naziv", naziv) :
                new ObjectParameter("naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proizvodi>("esp_Proizvodi_SelectByNaziv", nazivParameter);
        }
    
        public virtual ObjectResult<Proizvodi> esp_Proizvodi_SelectByNaziv(string naziv, MergeOption mergeOption)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("naziv", naziv) :
                new ObjectParameter("naziv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proizvodi>("esp_Proizvodi_SelectByNaziv", mergeOption, nazivParameter);
        }
    
        public virtual ObjectResult<esp_BrosureProizvodi_SelectAll_Result1> esp_BrosureProizvodi_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_BrosureProizvodi_SelectAll_Result1>("esp_BrosureProizvodi_SelectAll");
        }
    
        public virtual int esp_Brosure_Insert(string naziv, Nullable<System.DateTime> datumP, Nullable<System.DateTime> datumI)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var datumPParameter = datumP.HasValue ?
                new ObjectParameter("DatumP", datumP) :
                new ObjectParameter("DatumP", typeof(System.DateTime));
    
            var datumIParameter = datumI.HasValue ?
                new ObjectParameter("DatumI", datumI) :
                new ObjectParameter("DatumI", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Brosure_Insert", nazivParameter, datumPParameter, datumIParameter);
        }
    
        public virtual int esp_ProizvodiBrosure_Insert(Nullable<int> proizvodID, Nullable<int> brosuraID)
        {
            var proizvodIDParameter = proizvodID.HasValue ?
                new ObjectParameter("ProizvodID", proizvodID) :
                new ObjectParameter("ProizvodID", typeof(int));
    
            var brosuraIDParameter = brosuraID.HasValue ?
                new ObjectParameter("BrosuraID", brosuraID) :
                new ObjectParameter("BrosuraID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_ProizvodiBrosure_Insert", proizvodIDParameter, brosuraIDParameter);
        }
    
        public virtual ObjectResult<esp_Proizvodi_SelectByBrosura_Result> esp_Proizvodi_SelectByBrosura(Nullable<int> brosuraID)
        {
            var brosuraIDParameter = brosuraID.HasValue ?
                new ObjectParameter("brosuraID", brosuraID) :
                new ObjectParameter("brosuraID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_Proizvodi_SelectByBrosura_Result>("esp_Proizvodi_SelectByBrosura", brosuraIDParameter);
        }
    }
}
