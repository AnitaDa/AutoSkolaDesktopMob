using AutoMapper;
using AutoSkola.Model;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSkola.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Kandidat, Model.MKandidat>();
            CreateMap<Model.Requests.KandidatUpsertRequest, Database.Kandidat>();
            CreateMap<Database.Zahtjev, Model.MKandidat>();
            CreateMap<Model.Requests.KandidatUpsertRequest, Database.Kandidat>().ReverseMap();
            CreateMap<Database.Uposlenik, Model.MUposlenik>();
            CreateMap<Database.UposlenikTipUposlenika, Model.MUposlenik>();
            CreateMap<Model.Requests.UposlenikUpsertRequest, Database.Uposlenik>();

            CreateMap<Database.Potvrda, Model.MPotvrda>();
          

            CreateMap<Database.Uplata, Model.MUplate>();
            CreateMap<Model.Requests.UplataUpsertRequest,Database.Uplata>();
            
            CreateMap<Database.Zahtjev, Model.MZahtjevi>().ReverseMap();
            CreateMap<Database.Zahtjev, Model.Requests.ZahtjeviUpsertRequest>().ReverseMap();

            CreateMap<Database.RasporedCasova, Model.MRasporedCasova>();
            CreateMap<Model.Requests.RasporedCasovaUpsertRequest, Database.RasporedCasova>();

            CreateMap<Database.TerminRasporedCasova, Model.MTerminRasporedaCasova>();
            CreateMap<Model.Requests.TerminRPUpsertRequest, Database.TerminRasporedCasova>();//?
            CreateMap<Database.Usluga, Model.MUsluge>().ReverseMap();
            CreateMap<Database.RasporedPolaganja, MRasporedPolaganja>().ReverseMap();
            CreateMap<Database.TerminRasporedaPolaganja, MTerminRasporedaPolaganja>();

            CreateMap<Model.Requests.TeminRCUpsertRequest, Database.TerminRasporedCasova>().ReverseMap();
            CreateMap<Model.Requests.RasporedPolaganjaUpsertRequest, Database.RasporedPolaganja>().ReverseMap();
            CreateMap<Database.Kategorija, MKategorije>();
            CreateMap<Model.Requests.KategorijeUpsertRequest, Database.Kategorija>().ReverseMap();
            CreateMap<Model.Requests.PotvrdaUpsertRequest, Database.Potvrda>();
            CreateMap<Database.Vozilo, Model.MVozilo>();
            CreateMap<Model.Requests.UslugaUpsertRequest,Database.Usluga>().ReverseMap();
            CreateMap<Model.Requests.TerminRPUpsertRequest, Database.TerminRasporedaPolaganja>().ReverseMap();
            CreateMap<Database.Marka, Model.MMarka>();
            CreateMap<Database.Model, Model.MModel>();
            CreateMap<Model.Requests.VoziloUpsertRequest,Database.Vozilo>().ReverseMap();
            CreateMap<Database.TipUposlenika, Model.MTipUposlenika>();
            CreateMap<Database.Korisnik, Model.MKorisnik>().ReverseMap();
            CreateMap<Model.Requests.KorisnikUpsertRequest, Database.Korisnik>();
            CreateMap<Database.Uloga,Model.MUloga>();
            CreateMap<Database.KorisnikUloga, Model.MKorisnikUloga>().ReverseMap();
            CreateMap<Model.Requests.KorisnikUlogaUpsertRequest, Database.KorisnikUloga>();
            CreateMap<Model.Requests.UTUUpsertRequest, Database.UposlenikTipUposlenika>();
            CreateMap<Database.UposlenikTipUposlenika, Model.MUposlenikTipUposlenika>();
            CreateMap<Model.Requests.LjekarskoUvjerenjeUpsertRequest, Database.LjekarskoUvjerenje>();
            CreateMap<Database.LjekarskoUvjerenje, Model.MLjekarskoUvjerenje>();
            CreateMap<Model.Requests.UslugeProdavnicaUpsertRequest, Database.UslugeProdavnica>();
            CreateMap<Database.UslugeProdavnica, Model.MUslugeProdavnica>();
            CreateMap<Model.Requests.OdabraneUslugeUspertRequest, Database.OdabranaUsluga>();
            CreateMap<Database.OdabranaUsluga,Model.MOdabraneUsluge>();
            CreateMap<Database.Utisak, MUtisak>();
            CreateMap<UtisakUpsertRequest,Database.Utisak>();
        }
    }
}
