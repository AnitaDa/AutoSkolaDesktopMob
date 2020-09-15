using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoSkola.WebAPI.Database
{
    public partial class AutoSkolaContext : DbContext
    {
        public AutoSkolaContext()
        {
        }

        public AutoSkolaContext(DbContextOptions<AutoSkolaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kandidat> Kandidat { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUloga { get; set; }
        public virtual DbSet<LjekarskoUvjerenje> LjekarskoUvjerenje { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
#pragma warning disable CS0114 // 'AutoSkolaContext.Model' hides inherited member 'DbContext.Model'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public virtual DbSet<Model> Model { get; set; }
#pragma warning restore CS0114 // 'AutoSkolaContext.Model' hides inherited member 'DbContext.Model'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public virtual DbSet<Potvrda> Potvrda { get; set; }
        public virtual DbSet<RasporedCasova> RasporedCasova { get; set; }
        public virtual DbSet<RasporedPolaganja> RasporedPolaganja { get; set; }
        public virtual DbSet<TerminRasporedCasova> TerminRasporedCasova { get; set; }
        public virtual DbSet<TerminRasporedaPolaganja> TerminRasporedaPolaganja { get; set; }
        public virtual DbSet<TipUposlenika> TipUposlenika { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Uplata> Uplata { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<UposlenikTipUposlenika> UposlenikTipUposlenika { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }
        public virtual DbSet<Vozilo> Vozilo { get; set; }
        public virtual DbSet<Zahtjev> Zahtjev { get; set; }
        public virtual DbSet<UslugeProdavnica> UslugeProdavnica { get; set; }
        public virtual DbSet<OdabranaUsluga> OdabranaUsluga { get; set; }
        public virtual DbSet<Kartica> Kartice { get; set; }
        public virtual DbSet<Utisak> Utisak { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QQNGECN\\SQLEXPRESS;Database=AutoSkola;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kandidat>(entity =>
            {
                entity.HasIndex(e => e.KorisnikId)
                    .HasName("UQ__Kandidat__80B06D40CCC24699")
                    .IsUnique();

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Korisnik)
                    .WithOne(p => p.Kandidat)
                    .HasForeignKey<Kandidat>(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnik_Kandidat");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KorisnikUloga>(entity =>
            {
                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUloga)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga_Korisnik");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUloga)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga_Uloga");
            });

            modelBuilder.Entity<LjekarskoUvjerenje>(entity =>
            {
                entity.Property(e => e.DatumIzdavanja).HasColumnType("date");

                entity.Property(e => e.DatumVazenja).HasColumnType("date");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Kandidat)
                    .WithMany(p => p.LjekarskoUvjerenje)
                    .HasForeignKey(d => d.KandidatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LjekarskoUvjerenje_Kandidat");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
                entity.HasOne(d => d.Marka)
                    .WithMany(p => p.Model)
                    .HasForeignKey(d => d.MarkaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Model__MarkaId__2180FB33");
            });
            modelBuilder.Entity<Marka>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });
            modelBuilder.Entity<Potvrda>(entity =>
            {
                entity.Property(e => e.DatumPolaganja).HasColumnType("date");

                entity.HasOne(d => d.Kandidat)
                    .WithMany(p => p.Potvrda)
                    .HasForeignKey(d => d.KandidatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Potvrda_Kandidat");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Potvrda)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Potvrda_Kategorija");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Potvrda)
                    .HasForeignKey(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Potvrda_UposlenikId");
            });

            modelBuilder.Entity<RasporedCasova>(entity =>
            {
                entity.HasOne(d => d.Kandidat)
                    .WithMany(p => p.RasporedCasova)
                    .HasForeignKey(d => d.KandidatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RasporedCasova_Kandidat");
            });

            modelBuilder.Entity<RasporedPolaganja>(entity =>
            {
                entity.Property(e => e.DatumPolaganja).HasColumnType("date");
            });

            modelBuilder.Entity<TerminRasporedCasova>(entity =>
            {
                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Do)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Od)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.RasporedCasova)
                    .WithMany(p => p.TerminRasporedCasova)
                    .HasForeignKey(d => d.RasporedCasovaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminRasporedCasova_RasporedCasova");

                entity.HasOne(d => d.Vozilo)
                    .WithMany(p => p.TerminRasporedCasova)
                    .HasForeignKey(d => d.VoziloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminRasporedCasova_Vozilo");
            });

            modelBuilder.Entity<TerminRasporedaPolaganja>(entity =>
            {
                entity.Property(e => e.Do)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Od)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Kandidat)
                    .WithMany(p => p.TerminRasporedaPolaganja)
                    .HasForeignKey(d => d.KandidatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminRasporedaPolaganja_Kandidat");

                entity.HasOne(d => d.RasporedPolaganja)
                    .WithMany(p => p.TerminRasporedaPolaganja)
                    .HasForeignKey(d => d.RasporedPolaganjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminRasporedaPolaganja_RasporedPolaganja");
            });

            modelBuilder.Entity<TipUposlenika>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(500);
            });

            modelBuilder.Entity<Uplata>(entity =>
            {
                entity.Property(e => e.DatumUplate).HasColumnType("date");

                entity.Property(e => e.Svrha)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Kandidat)
                    .WithMany(p => p.Uplata)
                    .HasForeignKey(d => d.KandidatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uplata_Kandidat");
            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.HasIndex(e => e.KorisnikId)
                    .HasName("UQ__Uposleni__80B06D408E949E19")
                    .IsUnique();

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Korisnik)
                    .WithOne(p => p.Uposlenik)
                    .HasForeignKey<Uposlenik>(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnik_Uposlenik");
            });

            modelBuilder.Entity<UposlenikTipUposlenika>(entity =>
            {
                entity.HasOne(d => d.TipUposlenika)
                    .WithMany(p => p.UposlenikTipUposlenika)
                    .HasForeignKey(d => d.TipUposlenikaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UposlenikTipUposlenika_TipUposlenika");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.UposlenikTipUposlenika)
                    .HasForeignKey(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UposlenikTipUposlenika_Uposlenik");
            });

            modelBuilder.Entity<Usluga>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Usluga)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usluga_Kategorija");
            });

            modelBuilder.Entity<Vozilo>(entity =>
            {
                entity.HasIndex(e => e.RegistarskaOznaka)
                    .HasName("UQ__Vozilo__751AFE0F221233CC")
                    .IsUnique();

                entity.Property(e => e.RegistarskaOznaka)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozilo_Kategorija");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Vozilo)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vozilo_Model");
            });

            modelBuilder.Entity<Zahtjev>(entity =>
            {
                entity.Property(e => e.DatumPodnosenjaZahtjeva).HasColumnType("date");

                entity.HasOne(d => d.LjekarskoUvjerenje)
                    .WithMany(p => p.Zahtjev)
                    .HasForeignKey(d => d.LjekarskoUvjerenjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zahtjev_LjekarskoUvjerenje");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Zahtjev)
                    .HasForeignKey(d => d.UposlenikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zahtjev_Uposlenik");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Zahtjev)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zahtjev_Usluga");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
