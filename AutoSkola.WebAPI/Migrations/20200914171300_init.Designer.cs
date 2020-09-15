﻿// <auto-generated />
using System;
using AutoSkola.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoSkola.WebAPI.Migrations
{
    [DbContext(typeof(AutoSkolaContext))]
    [Migration("20200914171300_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Kandidat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasName("UQ__Kandidat__80B06D40CCC24699");

                    b.ToTable("Kandidat");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Kartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BrojKartice")
                        .HasColumnType("bigint");

                    b.Property<int>("ExpMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpYear")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("SecurityCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId")
                        .IsUnique();

                    b.ToTable("Kartice");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisnikUloga");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.LjekarskoUvjerenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumIzdavanja")
                        .HasColumnType("date");

                    b.Property<DateTime>("DatumVazenja")
                        .HasColumnType("date");

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<bool>("SposobanZaObuku")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.ToTable("LjekarskoUvjerenje");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Marka");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("MarkaId");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.OdabranaUsluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UslugaId")
                        .HasColumnType("int");

                    b.Property<int>("UslugeProdavnicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UslugaId");

                    b.HasIndex("UslugeProdavnicaId");

                    b.ToTable("OdabranaUsluga");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Potvrda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPolaganja")
                        .HasColumnType("date");

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<int>("UposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Potvrda");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.RasporedCasova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.ToTable("RasporedCasova");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.RasporedPolaganja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPolaganja")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("RasporedPolaganja");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.TerminRasporedCasova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<string>("Do")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Od")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Prakticno")
                        .HasColumnType("bit");

                    b.Property<int>("RasporedCasovaId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("Teorija")
                        .HasColumnType("bit");

                    b.Property<int>("UposlenikId")
                        .HasColumnType("int");

                    b.Property<int>("VoziloId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RasporedCasovaId");

                    b.HasIndex("UposlenikId");

                    b.HasIndex("VoziloId");

                    b.ToTable("TerminRasporedCasova");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.TerminRasporedaPolaganja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Do")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.Property<string>("Od")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RasporedPolaganjaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.HasIndex("RasporedPolaganjaId");

                    b.ToTable("TerminRasporedaPolaganja");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.TipUposlenika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("TipUposlenika");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Uloga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Uplata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("date");

                    b.Property<float>("Iznos")
                        .HasColumnType("real");

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.Property<string>("Svrha")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Uposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId")
                        .IsUnique()
                        .HasName("UQ__Uposleni__80B06D408E949E19");

                    b.ToTable("Uposlenik");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.UposlenikTipUposlenika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TipUposlenikaId")
                        .HasColumnType("int");

                    b.Property<int>("UposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipUposlenikaId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("UposlenikTipUposlenika");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Usluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Usluga");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.UslugeProdavnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.ToTable("UslugeProdavnica");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Utisak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KandidatId")
                        .HasColumnType("int");

                    b.Property<decimal>("Ocjena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UposlenikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KandidatId");

                    b.HasIndex("UposlenikId");

                    b.ToTable("Utisak");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Vozilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("RegistarskaOznaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("ModelId");

                    b.HasIndex("RegistarskaOznaka")
                        .IsUnique()
                        .HasName("UQ__Vozilo__751AFE0F221233CC");

                    b.ToTable("Vozilo");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Zahtjev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPodnosenjaZahtjeva")
                        .HasColumnType("date");

                    b.Property<int>("LjekarskoUvjerenjeId")
                        .HasColumnType("int");

                    b.Property<bool>("Odbacen")
                        .HasColumnType("bit");

                    b.Property<bool>("Odobren")
                        .HasColumnType("bit");

                    b.Property<int>("UposlenikId")
                        .HasColumnType("int");

                    b.Property<int>("UslugaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LjekarskoUvjerenjeId");

                    b.HasIndex("UposlenikId");

                    b.HasIndex("UslugaId");

                    b.ToTable("Zahtjev");
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Kandidat", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Korisnik", "Korisnik")
                        .WithOne("Kandidat")
                        .HasForeignKey("AutoSkola.WebAPI.Database.Kandidat", "KorisnikId")
                        .HasConstraintName("FK_Korisnik_Kandidat")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Kartica", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Korisnik", "Korisnik")
                        .WithOne("Kartica")
                        .HasForeignKey("AutoSkola.WebAPI.Database.Kartica", "KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.KorisnikUloga", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUloga")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK_KorisnikUloga_Korisnik")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Uloga", "Uloga")
                        .WithMany("KorisnikUloga")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("FK_KorisnikUloga_Uloga")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.LjekarskoUvjerenje", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany("LjekarskoUvjerenje")
                        .HasForeignKey("KandidatId")
                        .HasConstraintName("FK_LjekarskoUvjerenje_Kandidat")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Model", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Marka", "Marka")
                        .WithMany("Model")
                        .HasForeignKey("MarkaId")
                        .HasConstraintName("FK__Model__MarkaId__2180FB33")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.OdabranaUsluga", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Usluga", "Usluga")
                        .WithMany()
                        .HasForeignKey("UslugaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.UslugeProdavnica", "UslugeProdavnica")
                        .WithMany("OdabraneUsluge")
                        .HasForeignKey("UslugeProdavnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Potvrda", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany("Potvrda")
                        .HasForeignKey("KandidatId")
                        .HasConstraintName("FK_Potvrda_Kandidat")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Kategorija", "Kategorija")
                        .WithMany("Potvrda")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK_Potvrda_Kategorija")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Uposlenik", "Uposlenik")
                        .WithMany("Potvrda")
                        .HasForeignKey("UposlenikId")
                        .HasConstraintName("FK_Potvrda_UposlenikId")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.RasporedCasova", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany("RasporedCasova")
                        .HasForeignKey("KandidatId")
                        .HasConstraintName("FK_RasporedCasova_Kandidat")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.TerminRasporedCasova", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.RasporedCasova", "RasporedCasova")
                        .WithMany("TerminRasporedCasova")
                        .HasForeignKey("RasporedCasovaId")
                        .HasConstraintName("FK_TerminRasporedCasova_RasporedCasova")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Uposlenik", "Uposlenik")
                        .WithMany("TerminRasporedCasova")
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Vozilo", "Vozilo")
                        .WithMany("TerminRasporedCasova")
                        .HasForeignKey("VoziloId")
                        .HasConstraintName("FK_TerminRasporedCasova_Vozilo")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.TerminRasporedaPolaganja", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany("TerminRasporedaPolaganja")
                        .HasForeignKey("KandidatId")
                        .HasConstraintName("FK_TerminRasporedaPolaganja_Kandidat")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.RasporedPolaganja", "RasporedPolaganja")
                        .WithMany("TerminRasporedaPolaganja")
                        .HasForeignKey("RasporedPolaganjaId")
                        .HasConstraintName("FK_TerminRasporedaPolaganja_RasporedPolaganja")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Uplata", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany("Uplata")
                        .HasForeignKey("KandidatId")
                        .HasConstraintName("FK_Uplata_Kandidat")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Uposlenik", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Korisnik", "Korisnik")
                        .WithOne("Uposlenik")
                        .HasForeignKey("AutoSkola.WebAPI.Database.Uposlenik", "KorisnikId")
                        .HasConstraintName("FK_Korisnik_Uposlenik")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.UposlenikTipUposlenika", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.TipUposlenika", "TipUposlenika")
                        .WithMany("UposlenikTipUposlenika")
                        .HasForeignKey("TipUposlenikaId")
                        .HasConstraintName("FK_UposlenikTipUposlenika_TipUposlenika")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Uposlenik", "Uposlenik")
                        .WithMany("UposlenikTipUposlenika")
                        .HasForeignKey("UposlenikId")
                        .HasConstraintName("FK_UposlenikTipUposlenika_Uposlenik")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Usluga", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kategorija", "Kategorija")
                        .WithMany("Usluga")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK_Usluga_Kategorija")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.UslugeProdavnica", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany()
                        .HasForeignKey("KandidatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Utisak", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kandidat", "Kandidat")
                        .WithMany("Utisak")
                        .HasForeignKey("KandidatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Uposlenik", "Uposlenik")
                        .WithMany("Utisak")
                        .HasForeignKey("UposlenikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Vozilo", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.Kategorija", "Kategorija")
                        .WithMany("Vozilo")
                        .HasForeignKey("KategorijaId")
                        .HasConstraintName("FK_Vozilo_Kategorija")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Model", "Model")
                        .WithMany("Vozilo")
                        .HasForeignKey("ModelId")
                        .HasConstraintName("FK_Vozilo_Model")
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSkola.WebAPI.Database.Zahtjev", b =>
                {
                    b.HasOne("AutoSkola.WebAPI.Database.LjekarskoUvjerenje", "LjekarskoUvjerenje")
                        .WithMany("Zahtjev")
                        .HasForeignKey("LjekarskoUvjerenjeId")
                        .HasConstraintName("FK_Zahtjev_LjekarskoUvjerenje")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Uposlenik", "Uposlenik")
                        .WithMany("Zahtjev")
                        .HasForeignKey("UposlenikId")
                        .HasConstraintName("FK_Zahtjev_Uposlenik")
                        .IsRequired();

                    b.HasOne("AutoSkola.WebAPI.Database.Usluga", "Usluga")
                        .WithMany("Zahtjev")
                        .HasForeignKey("UslugaId")
                        .HasConstraintName("FK_Zahtjev_Usluga")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
