using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoSkola.WebAPI.Services.Korisnik;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;

namespace AutoSkola.WebAPI.Database
{
    public class DBInitializer
    {
        public static void Seed(AutoSkolaContext context)

        {

            AddKategorije(context); 
            AddMarka(context);
            AddModel(context);
            AddVozilo(context);
            AddUsluge(context);
            AddUloga(context);         
            AddKorisnik(context);//dodaje se korisnik,Uloga, KorisnikUloga, Uposlenici,Kandidati, TipUposlenika,UposlTipUposl,LjekskarkoUvjerenje
            AddRasporedPolaganja(context);
            Console.WriteLine("SVE DODANO :-D!");
        }

        private static int GenerisiInt(int from, int to)

        {

            var rand = new Random();

            return rand.Next(from, to);

        }

        private static DateTime GenerisiDatum()

        {

            return new DateTime(year: GenerisiInt(2017, 2020),

                month: GenerisiInt(1, 13),

                day: GenerisiInt(1, 29));

        }

        private static void AddKategorije(AutoSkolaContext context)

        {
            if (context.Kategorija.ToList().Count > 0)
                return;

            context.Kategorija.AddRange(

                new Kategorija { Naziv= "A kategorija",Opis= "A kategorija je kategorija za upravljanje motorima i teškim triciklima čija snaga motora je veća od 15 KW" },
                new Kategorija { Naziv = "B kategorija", Opis = "B – kategorija je dozvola za upravljanje putničkim vozilom" },
                new Kategorija { Naziv = "C kategorija", Opis = "C kategorija je dozvola za upravljanje teretnim vozilom čija je najveća dozvoljena masa veća od 3.5t" },
                new Kategorija { Naziv = "D kategorija", Opis = "D kategorija je kategorija za upravljanje autobusima" }
            );

            context.SaveChanges();

        

        }

        private static void AddUloge(AutoSkolaContext context)
        {
            if (context.Uloga.ToList().Count > 0) return;
            var referent = new Uloga()
            {
                Naziv = "referent",
                Opis = "Uloga za referenta"
            };
            var kandidat = new Uloga()
            {
                Naziv = "kandidat",
                Opis = "Uloga za kandidata"
            };
            var instruktor = new Uloga()
            {
                Naziv = "instruktor",
                Opis = "Uloga za instruktora"
            };

            context.Add(referent);
            context.Add(kandidat);
            context.Add(instruktor);

            context.SaveChanges();
        }
        
        private static void AddKorisnik(AutoSkolaContext context)
        {
            if (context.Korisnik.ToList().Count > 0)
                return;

            var salt = KorisnikService.GenerateSalt();
            var hash = KorisnikService.GenerateHash(salt, "test");

            var korisnik = new Korisnik()
            {
                Email = "uposlenik1@gmail.com",
                KorisnickoIme = "uposlenik",
                LozinkaHash = hash,
                LozinkaSalt =  salt, 
                Status = true
            };
            var korisnik4 = new Korisnik()
            {
                Email = "uposlenik2@gmail.com",
                KorisnickoIme = "uposlenik2",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = true
            };
            var korisnik2 = new Korisnik()
            {
                Email = "kandidat1@gmail.com",
                KorisnickoIme = "kandidat",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = false
            };
            var korisnik5 = new Korisnik()
            {
                Email = "kandidat2@gmail.com",
                KorisnickoIme = "kandidat2",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = false
            };
            var korisnik6 = new Korisnik()
            {
                Email = "kandidat3@gmail.com",
                KorisnickoIme = "kandidat3",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = false
            };
            var korisnik7 = new Korisnik()
            {
                Email = "kandidat4@gmail.com",
                KorisnickoIme = "kandidat4",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = false
            };
            var korisnik8 = new Korisnik()
            {
                Email = "kandidat5@gmail.com",
                KorisnickoIme = "kandidat5",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = false
            };
            var korisnik3 = new Korisnik()
            {
                Email = "instruktor@gmail.com",
                KorisnickoIme = "instruktor",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = true
            };
            var korisnik9 = new Korisnik()
            {
                Email = "instruktor2@gmail.com",
                KorisnickoIme = "instruktor2",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = true
            };//instruktor2
            var korisnik10 = new Korisnik()
            {
                Email = "instruktor3@gmail.com",
                KorisnickoIme = "instruktor3",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = true
            };//instruktor3
            var korisnik11 = new Korisnik()
            {
                Email = "instruktor4@gmail.com",
                KorisnickoIme = "instruktor4",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = true
            };//instruktor4
            var korisnik12 = new Korisnik()
            {
                Email = "instruktor5@gmail.com",
                KorisnickoIme = "instruktor5",
                LozinkaHash = hash,
                LozinkaSalt = salt,
                Status = true
            };//instruktor5

            var k1 = context.Korisnik.Add(korisnik);//referent
            var k2 = context.Korisnik.Add(korisnik2);//kandidat
            var k3 = context.Korisnik.Add(korisnik3);//instruktor
            var k4 = context.Korisnik.Add(korisnik4);//referent
            var k5 = context.Korisnik.Add(korisnik5); //kandidat
            var k6 = context.Korisnik.Add(korisnik6); //kandidat
            var k7 = context.Korisnik.Add(korisnik7); //kandidat
            var k8 = context.Korisnik.Add(korisnik8); //kandidat
            var k9 = context.Korisnik.Add(korisnik9);//instruktor2
            var k10 = context.Korisnik.Add(korisnik10);//instruktor3
            var k11 = context.Korisnik.Add(korisnik11);//instruktor4
            var k12 = context.Korisnik.Add(korisnik12);//instruktor5
           
            context.SaveChanges();

           

            var korisnikUloga1 = new KorisnikUloga()
            {
                KorisnikId = k1.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv.Equals("referent")).Id
            };
            var korisnikUloga2 = new KorisnikUloga()
            {
                KorisnikId = k2.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "kandidat").Id
            };
            var korisnikUloga3 = new KorisnikUloga()
            {
                KorisnikId = k3.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "instruktor").Id
            };
            var korisnikUloga4 = new KorisnikUloga()
            {
                KorisnikId = k4.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "referent").Id
            };
            var korisnikUloga5 = new KorisnikUloga()
            {
                KorisnikId = k5.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "kandidat").Id
            };
            var korisnikUloga6 = new KorisnikUloga()
            {
                KorisnikId = k6.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "kandidat").Id
            };
            var korisnikUloga7 = new KorisnikUloga()
            {
                KorisnikId = k7.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "kandidat").Id
            };
            var korisnikUloga8 = new KorisnikUloga()
            {
                KorisnikId = k8.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "kandidat").Id
            };
            var korisnikUloga9 = new KorisnikUloga()
            {
                KorisnikId = k9.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "instruktor").Id
            };
            var korisnikUloga10 = new KorisnikUloga()
            {
                KorisnikId = k10.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "instruktor").Id
            };
            var korisnikUloga11 = new KorisnikUloga()
            {
                KorisnikId = k11.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "instruktor").Id
            };
            var korisnikUloga12 = new KorisnikUloga()
            {
                KorisnikId = k12.Entity.Id,
                UlogaId = context.Uloga.FirstOrDefault(x => x.Naziv == "instruktor").Id
            };
            context.KorisnikUloga.Add(korisnikUloga1);
            context.KorisnikUloga.Add(korisnikUloga2);
            context.KorisnikUloga.Add(korisnikUloga3);
            context.KorisnikUloga.Add(korisnikUloga4);
            context.KorisnikUloga.Add(korisnikUloga5);
            context.KorisnikUloga.Add(korisnikUloga6);
            context.KorisnikUloga.Add(korisnikUloga7);
            context.KorisnikUloga.Add(korisnikUloga8);
            context.SaveChanges();


           

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Slike", "slika.png");
            byte[] slika = File.ReadAllBytes(path);
            //referenti
            var uposlenik1 = new Uposlenik()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Uposlenik1",
                KorisnikId = k1.Entity.Id,
                Prezime = "Prezime1",
                Slika = slika
            };
            var uposlenik3 = new Uposlenik()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Uposlenik2",
                KorisnikId = k4.Entity.Id,
                Prezime = "Prezime2",
                Slika = slika
            };
            //kandidti
            var kandidat1 = new Kandidat()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Kandidat1",
                KorisnikId = k2.Entity.Id,
                Prezime = "Prezime1",
                Slika = slika,
                Status = true
            };
            var kandidat2 = new Kandidat()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Kandidat2",
                KorisnikId = k5.Entity.Id,
                Prezime = "Prezime2",
                Slika = slika,
                Status = true
            };
            var kandidat3 = new Kandidat()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Kandidat3",
                KorisnikId = k6.Entity.Id,
                Prezime = "Prezime3",
                Slika = slika,
                Status = true
            };
            var kandidat4 = new Kandidat()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Kandidat4",
                KorisnikId = k7.Entity.Id,
                Prezime = "Prezime4",
                Slika = slika,
                Status = true
            };
            var kandidat5 = new Kandidat()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Kandidat5",
                KorisnikId = k8.Entity.Id,
                Prezime = "Prezime5",
                Slika = slika,
                Status = true
            };
            // Instruktor
            var uposlenik2 = new Uposlenik()
            {
                DatumRodjenja = DateTime.Now,
                Ime = "Instruktor1",
                KorisnikId = k3.Entity.Id,
                Prezime = "Prezime1",
                Slika = slika
            };
            var uposlenikI2 = new Uposlenik()
            {
                DatumRodjenja = GenerisiDatum(),
                Ime = "Instruktor2",
                KorisnikId = k9.Entity.Id,
                Prezime = "Prezime2",
                Slika = slika
            };
            var uposlenikI3 = new Uposlenik()
            {
                DatumRodjenja = GenerisiDatum(),
                Ime = "Instruktor3",
                KorisnikId = k10.Entity.Id,
                Prezime = "Prezime3",
                Slika = slika
            };
            var uposlenikI4 = new Uposlenik()
            {
                DatumRodjenja = GenerisiDatum(),
                Ime = "Instruktor4",
                KorisnikId = k11.Entity.Id,
                Prezime = "Prezime4",
                Slika = slika
            };
            var uposlenikI5 = new Uposlenik()
            {
                DatumRodjenja = GenerisiDatum(),
                Ime = "Instruktor5",
                KorisnikId = k12.Entity.Id,
                Prezime = "Prezime5",
                Slika = slika
            };
          
            var kandidat = context.Kandidat.Add(kandidat1);
            var kandidat22 = context.Kandidat.Add(kandidat2);
            var kandidat33 = context.Kandidat.Add(kandidat3);
            var kandidat44 = context.Kandidat.Add(kandidat4);
            var kandidat55 = context.Kandidat.Add(kandidat5);

            var uposlenik_db = context.Uposlenik.Add(uposlenik1);
            var referent_db = context.Uposlenik.Add(uposlenik3);
            var instruktor_db = context.Uposlenik.Add(uposlenik2);
            var instruktor2_db = context.Uposlenik.Add(uposlenikI2);
            var instruktor3_db = context.Uposlenik.Add(uposlenikI3);
            var instruktor4_db = context.Uposlenik.Add(uposlenikI4);
            var instruktor5_db = context.Uposlenik.Add(uposlenikI5);

            context.SaveChanges();


            
            //Utisci
            context.Utisak.AddRange(
                new Utisak { KandidatId=kandidat.Entity.Id,UposlenikId=instruktor_db.Entity.Id,Ocjena=4},
                new Utisak { KandidatId = kandidat.Entity.Id, UposlenikId = instruktor2_db.Entity.Id, Ocjena = 3 },
                new Utisak { KandidatId = kandidat22.Entity.Id, UposlenikId = instruktor_db.Entity.Id, Ocjena = 5 },
                new Utisak { KandidatId = kandidat22.Entity.Id, UposlenikId = instruktor4_db.Entity.Id, Ocjena = 3 },
                new Utisak { KandidatId = kandidat22.Entity.Id, UposlenikId = instruktor5_db.Entity.Id, Ocjena = 4 },
                new Utisak { KandidatId = kandidat33.Entity.Id, UposlenikId = instruktor5_db.Entity.Id, Ocjena = 4 },
                new Utisak { KandidatId = kandidat33.Entity.Id, UposlenikId = instruktor2_db.Entity.Id, Ocjena = 5 },
                new Utisak { KandidatId = kandidat44.Entity.Id, UposlenikId = instruktor_db.Entity.Id, Ocjena = 4 },
                new Utisak { KandidatId = kandidat44.Entity.Id, UposlenikId = instruktor3_db.Entity.Id, Ocjena = 2 },
                new Utisak { KandidatId = kandidat44.Entity.Id, UposlenikId = instruktor4_db.Entity.Id, Ocjena = 5 },
                new Utisak { KandidatId = kandidat55.Entity.Id, UposlenikId = instruktor_db.Entity.Id, Ocjena = 2 },
                new Utisak { KandidatId = kandidat55.Entity.Id, UposlenikId = instruktor5_db.Entity.Id, Ocjena = 5 }
                );
            context.SaveChanges();
           
            var tipReferent = new TipUposlenika()
            {
                Naziv = "referent"
            };

            var tipInstruktor = new TipUposlenika()
            {
                Naziv = "instruktor"
            };

            var tip1referent = context.TipUposlenika.Add(tipReferent);
            var tip2instruktor = context.TipUposlenika.Add(tipInstruktor);

            context.SaveChanges();

           

            //referenti
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip1referent.Entity.Id,
                UposlenikId = uposlenik_db.Entity.Id
            });
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip1referent.Entity.Id,
                UposlenikId = referent_db.Entity.Id
            });
            //instruktori
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip2instruktor.Entity.Id,
                UposlenikId = instruktor_db.Entity.Id
            });
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip2instruktor.Entity.Id,
                UposlenikId = instruktor2_db.Entity.Id
            });
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip2instruktor.Entity.Id,
                UposlenikId = instruktor3_db.Entity.Id
            });
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip2instruktor.Entity.Id,
                UposlenikId = instruktor4_db.Entity.Id
            });
            context.UposlenikTipUposlenika.Add(new UposlenikTipUposlenika()
            {
                TipUposlenikaId = tip2instruktor.Entity.Id,
                UposlenikId = instruktor5_db.Entity.Id
            });
            
            

            context.SaveChanges();

           
            //Ljekarsko
            if (context.LjekarskoUvjerenje.ToList().Count() > 0)
                return;
            var lj1=context.LjekarskoUvjerenje.Add(
                new LjekarskoUvjerenje {DatumVazenja=GenerisiDatum(),DatumIzdavanja= GenerisiDatum(), KandidatId=kandidat.Entity.Id,SposobanZaObuku=true,Opis="Sposoban"}
                );
            var lj2 = context.LjekarskoUvjerenje.Add(
                new LjekarskoUvjerenje { DatumVazenja = GenerisiDatum(), DatumIzdavanja = GenerisiDatum(), KandidatId = kandidat22.Entity.Id, SposobanZaObuku = true, Opis = "Sposoban" }
                );
            var lj3 = context.LjekarskoUvjerenje.Add(
                new LjekarskoUvjerenje { DatumVazenja = GenerisiDatum(), DatumIzdavanja = GenerisiDatum(), KandidatId = kandidat33.Entity.Id, SposobanZaObuku = true, Opis = "Sposoban" }
                );                                    
            var lj4 = context.LjekarskoUvjerenje.Add(   
                new LjekarskoUvjerenje { DatumVazenja = GenerisiDatum(), DatumIzdavanja = GenerisiDatum(), KandidatId = kandidat44.Entity.Id, SposobanZaObuku = true, Opis = "Sposoban" }
                );                                     
            var lj5 = context.LjekarskoUvjerenje.Add(   
                new LjekarskoUvjerenje { DatumVazenja = GenerisiDatum(), DatumIzdavanja = GenerisiDatum(), KandidatId = kandidat55.Entity.Id, SposobanZaObuku = true, Opis = "Sposoban" }
                );
            context.SaveChanges();
          



            //potvrde
            if (context.Potvrda.ToList().Count() > 0)
                return;
            context.Potvrda.Add(
                new Potvrda {DatumPolaganja=DateTime.Now,KandidatId=kandidat.Entity.Id,KategorijaId=2,UposlenikId=uposlenik_db.Entity.Id }
                );
            context.Potvrda.Add(
               new Potvrda { DatumPolaganja = DateTime.Now, KandidatId = kandidat22.Entity.Id, KategorijaId = 2, UposlenikId = uposlenik_db.Entity.Id }
               );
            context.SaveChanges();
          
            //raspored casova
            if (context.RasporedCasova.ToList().Count() > 0)
                return;
            
            var rc1=context.RasporedCasova.Add(
               new RasporedCasova { KandidatId = kandidat.Entity.Id }
               );
            var rc2 = context.RasporedCasova.Add(
              new RasporedCasova { KandidatId = kandidat22.Entity.Id }
              );
            var rc3 = context.RasporedCasova.Add(
              new RasporedCasova { KandidatId = kandidat33.Entity.Id }
              );
            var rc4 = context.RasporedCasova.Add(
              new RasporedCasova { KandidatId = kandidat44.Entity.Id }
              );
            var rc5 = context.RasporedCasova.Add(
              new RasporedCasova { KandidatId = kandidat55.Entity.Id }
              );
            
            context.SaveChanges();
           
            //termin rasporeda casova
            if (context.TerminRasporedCasova.ToList().Count() > 0)
                return;

            context.TerminRasporedCasova.AddRange(
                //kandidat
               new TerminRasporedCasova {
                   RasporedCasovaId=rc1.Entity.Id,
                   Od="12"
                   ,Do="13"
                   ,Datum=DateTime.Today,
                   VoziloId = context.Vozilo.FirstOrDefault( x=> x.RegistarskaOznaka == "019-K-897").Id,
                   Status = true,
                   UposlenikId = instruktor_db.Entity.Id,
                   Prakticno=true
               },
               new TerminRasporedCasova { 
                   RasporedCasovaId = rc1.Entity.Id,
                   Od = "10",
                   Do = "11",
                   Datum = DateTime.Today,
                   VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                   Status = false,
                   UposlenikId= instruktor_db.Entity.Id,
                   Prakticno = true
               },
               //kandidat22
                new TerminRasporedCasova
                {
                    RasporedCasovaId = rc2.Entity.Id,
                    Od = "9"
                   ,
                    Do = "10"
                   ,
                    Datum = GenerisiDatum(),
                    VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "019-K-897").Id,
                    Status = true,
                    UposlenikId = instruktor_db.Entity.Id,
                    Prakticno = true
                },
               new TerminRasporedCasova
               {
                   RasporedCasovaId = rc2.Entity.Id,
                   Od = "10",
                   Do = "11",
                   Datum = GenerisiDatum(),
                   VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                   Status = false,
                   UposlenikId = instruktor_db.Entity.Id,
                   Prakticno = true
               },
                new TerminRasporedCasova
                {
                    RasporedCasovaId = rc2.Entity.Id,
                    Od = "10",
                    Do = "11",
                    Datum = GenerisiDatum(),
                    VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                    Status = false,
                    UposlenikId = instruktor2_db.Entity.Id,
                    Teorija = true
                },
                 new TerminRasporedCasova
                 {
                     RasporedCasovaId = rc2.Entity.Id,
                     Od = "10",
                     Do = "11",
                     Datum = GenerisiDatum(),
                     VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                     Status = false,
                     UposlenikId = instruktor2_db.Entity.Id,
                     Teorija = true
                 },
                 //kandidat 33
                  new TerminRasporedCasova
                  {
                      RasporedCasovaId = rc3.Entity.Id,
                      Od = "10",
                      Do = "11",
                      Datum = GenerisiDatum(),
                      VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                      Status = false,
                      UposlenikId = instruktor3_db.Entity.Id,
                      Teorija = true
                  },
                  //kandidat44
                   new TerminRasporedCasova
                   {
                       RasporedCasovaId = rc4.Entity.Id,
                       Od = "10",
                       Do = "11",
                       Datum = GenerisiDatum(),
                       VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                       Status = false,
                       UposlenikId = instruktor4_db.Entity.Id,
                       Teorija = true
                   },
                    //kandidat55
                    new TerminRasporedCasova
                    {
                        RasporedCasovaId = rc5.Entity.Id,
                        Od = "13",
                        Do = "14",
                        Datum = GenerisiDatum(),
                        VoziloId = context.Vozilo.FirstOrDefault(x => x.RegistarskaOznaka == "009-O-007").Id,
                        Status = false,
                        UposlenikId = instruktor4_db.Entity.Id,
                        Teorija = true
                    }
               );

            context.SaveChanges();
            
            //Uplate
            if (context.Uplata.ToList().Count() > 0)
                return;

            context.Uplata.AddRange(
               new Uplata {DatumUplate=DateTime.Now,KandidatId=kandidat.Entity.Id,Iznos=450,Svrha="Rata"},
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat.Entity.Id, Iznos = 450, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat.Entity.Id, Iznos = 450, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat.Entity.Id, Iznos = 30, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat.Entity.Id, Iznos = 360, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat22.Entity.Id, Iznos = 500, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat22.Entity.Id, Iznos = 10, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat22.Entity.Id, Iznos = 25, Svrha = "Dodatni cas" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat22.Entity.Id, Iznos = 30, Svrha = "Dodatni cas" },
                new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat33.Entity.Id, Iznos = 500, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat33.Entity.Id, Iznos = 10, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat44.Entity.Id, Iznos = 25, Svrha = "Dodatni cas" },
                new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat55.Entity.Id, Iznos = 500, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat55.Entity.Id, Iznos = 140, Svrha = "Rata" },
               new Uplata { DatumUplate = GenerisiDatum(), KandidatId = kandidat55.Entity.Id, Iznos = 25, Svrha = "Dodatni cas" }
               );
            context.SaveChanges();
           
            //Zahtjevi
            if (context.Zahtjev.ToList().Count() > 0)
                return;
            context.Zahtjev.AddRange(
                new Zahtjev {DatumPodnosenjaZahtjeva=GenerisiDatum(),LjekarskoUvjerenjeId=lj1.Entity.Id,UposlenikId= instruktor_db.Entity.Id,UslugaId=1, Odobren = false, Odbacen = false },
                new Zahtjev { DatumPodnosenjaZahtjeva = GenerisiDatum(), LjekarskoUvjerenjeId = lj1.Entity.Id, UposlenikId = instruktor_db.Entity.Id, UslugaId = 1, Odobren = false, Odbacen = false },
                new Zahtjev { DatumPodnosenjaZahtjeva = GenerisiDatum(), LjekarskoUvjerenjeId = lj2.Entity.Id, UposlenikId = instruktor_db.Entity.Id, UslugaId = 1, Odobren = false, Odbacen = false },
                new Zahtjev { DatumPodnosenjaZahtjeva = GenerisiDatum(), LjekarskoUvjerenjeId = lj3.Entity.Id, UposlenikId = instruktor3_db.Entity.Id, UslugaId = 1, Odobren = false, Odbacen = false },
                new Zahtjev { DatumPodnosenjaZahtjeva = GenerisiDatum(), LjekarskoUvjerenjeId = lj4.Entity.Id, UposlenikId = instruktor4_db.Entity.Id, UslugaId =2, Odobren = false, Odbacen = false },
                new Zahtjev { DatumPodnosenjaZahtjeva = GenerisiDatum(), LjekarskoUvjerenjeId = lj5.Entity.Id, UposlenikId = instruktor4_db.Entity.Id, UslugaId = 1, Odobren = false, Odbacen = false }

                );
            context.SaveChanges();
         
        }
       

   

        private static void AddVozilo(AutoSkolaContext context)

        {

            if (context.Vozilo.ToList().Count > 0)

                return;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Slike","XR_1706-680x365.jpg");
            byte[] slika = File.ReadAllBytes(path);
            context.Vozilo.AddRange(

                new Vozilo { KategorijaId = 1, ModelId = 1, RegistarskaOznaka = "019-K-897",Slika=slika},
                new Vozilo { KategorijaId = 1, ModelId = 1, RegistarskaOznaka = "009-K-897", Slika = slika},
                new Vozilo { KategorijaId = 1, ModelId = 1, RegistarskaOznaka = "459-K-545" ,Slika=slika},
                new Vozilo { KategorijaId = 1, ModelId = 1, RegistarskaOznaka = "034-J-907" ,Slika=slika},
                new Vozilo { KategorijaId = 2, ModelId = 2, RegistarskaOznaka = "339-M-857" ,Slika=slika},
                new Vozilo { KategorijaId = 2, ModelId = 2, RegistarskaOznaka = "009-O-007" ,Slika=slika},
                new Vozilo { KategorijaId = 2, ModelId = 2, RegistarskaOznaka = "239-O-327" ,Slika=slika},
                new Vozilo { KategorijaId = 3, ModelId = 3, RegistarskaOznaka = "329-I-822" ,Slika=slika},
                new Vozilo { KategorijaId = 3, ModelId = 3, RegistarskaOznaka = "059-H-327" ,Slika=slika},
                new Vozilo { KategorijaId = 3, ModelId = 3, RegistarskaOznaka = "112-E-893" ,Slika=slika},
                new Vozilo { KategorijaId = 4, ModelId = 4, RegistarskaOznaka = "213-E-432" ,Slika=slika},
                new Vozilo { KategorijaId = 4, ModelId = 4, RegistarskaOznaka = "533-J-865" ,Slika=slika},
                new Vozilo { KategorijaId = 4, ModelId = 4, RegistarskaOznaka = "231-M-874", Slika = slika }

                );

            context.SaveChanges();

         

        }
        

        private static void AddMarka(AutoSkolaContext context)

        {

            if (context.Marka.ToList().Count > 0)

                return;

            context.Marka.AddRange(

                new Marka { Naziv = "Yamaha" },
                new Marka { Naziv = "Volkswagen" },
                new Marka { Naziv = "Mercedess" }

            );

            context.SaveChanges();

           

        }
        

        private static void AddModel(AutoSkolaContext context)

        {

            if (context.Model.ToList().Count > 0)

                return;

            context.Model.AddRange(

                new Model { Naziv="MT-09", MarkaId=1 },//jamaha
                new Model { Naziv = "Golf", MarkaId = 2 },//VW
                new Model { Naziv = "Sprinter", MarkaId = 2 },//VW
                new Model { Naziv = "Conecto NGT", MarkaId = 3 }//Mercedes
            );

            context.SaveChanges();


        }

        

        private static void AddUsluge(AutoSkolaContext context)

        {

            if (context.Usluga.ToList().Count > 0)

                return;

            context.Usluga.AddRange(

                new Usluga { Naziv="Obuka", Cijena=1800, Opis="40 casova teorije, 40 casova voznje, polaganje prve pomoci", KategorijaId=2},
                new Usluga { Naziv = "Obuka", Cijena = 1800, Opis = "40 casova teorije, 40 casova voznje, polaganje prve pomoci", KategorijaId = 2 },
                new Usluga { Naziv = "Obuka", Cijena = 900, Opis = "20 casova teorije, 20 casova voznje, polaganje prve pomoci", KategorijaId = 1 },
                new Usluga { Naziv = "Obuka", Cijena = 2000, Opis = "40 casova teorije, 40 casova voznje, polaganje prve pomoci", KategorijaId = 3 },
                new Usluga { Naziv = "Obuka", Cijena = 2000, Opis = "40 casova teorije, 40 casova voznje, polaganje prve pomoci", KategorijaId = 4 },
                new Usluga { Naziv = "Dodatni čas(teorija) ", Cijena = 20, Opis = "Predavanje iz oblasti koju kandidat odabere", KategorijaId = 1 },
                new Usluga { Naziv = "Dodatni čas(teorija) ", Cijena = 20, Opis = "Predavanje iz oblasti koju kandidat odabere", KategorijaId = 2 },
                new Usluga { Naziv = "Dodatni čas(teorija) ", Cijena = 20, Opis = "Predavanje iz oblasti koju kandidat odabere", KategorijaId = 3 },
                new Usluga { Naziv = "Dodatni čas(teorija) ", Cijena = 20, Opis = "Predavanje iz oblasti koju kandidat odabere", KategorijaId = 4 },
                new Usluga { Naziv = "Dodatni čas(praktično) ", Cijena = 15, Opis = "Vožnja po gradu i poligonu", KategorijaId = 1 },
                new Usluga { Naziv = "Dodatni čas(praktično) ", Cijena = 20, Opis = "Vožnja po gradu i poligonu", KategorijaId = 2 },
                new Usluga { Naziv = "Dodatni čas(praktično) ", Cijena = 25, Opis = "Vožnja po gradu i poligonu", KategorijaId = 3 },
                new Usluga { Naziv = "Dodatni čas(praktično) ", Cijena = 25, Opis = "Vožnja po gradu i poligonu", KategorijaId = 4 },
                new Usluga { Naziv = "Prva pomoć", Cijena = 80, Opis = "Prakticno i teoretsko predavanje o davanju prve pomoći ", KategorijaId = 4 }
            );

            context.SaveChanges();

           

        }

        private static void AddUloga(AutoSkolaContext context)

        {
            if (context.Uloga.ToList().Count > 0)
                return;

            context.Uloga.AddRange(

                new Uloga { Naziv = "Kandidat", Opis="Pregleda informacije o obuci" },
                new Uloga { Naziv = "Referent", Opis = "Vodi administrativni deo" },
                new Uloga { Naziv = "Instruktor", Opis = "Evidentira održane časove" }
            );

            context.SaveChanges();

            

        }
        private static void AddRasporedPolaganja(AutoSkolaContext context)

        {
            if (context.RasporedPolaganja.ToList().Count > 0)
                return;
            var rp1 =context.RasporedPolaganja.Add(
                         new RasporedPolaganja { DatumPolaganja = DateTime.Now }
                         );
            var rp2 = context.RasporedPolaganja.Add(
                         new RasporedPolaganja { DatumPolaganja = GenerisiDatum() }
                         );
            context.SaveChanges();
           
            //termin rasporeda polaganja
            if (context.TerminRasporedCasova.ToList().Count() > 0)
                return;
            context.TerminRasporedaPolaganja.AddRange(
                new TerminRasporedaPolaganja {Od="10:00",Do="12:00",KandidatId=1,RasporedPolaganjaId=rp1.Entity.Id },
                new TerminRasporedaPolaganja { Od = "12:00", Do = "13:00", KandidatId = 2, RasporedPolaganjaId = rp1.Entity.Id },
                new TerminRasporedaPolaganja { Od = "13:00", Do = "15:00", KandidatId = 3, RasporedPolaganjaId = rp1.Entity.Id }
                );
            context.SaveChanges();
           

        }
   
    }
}

