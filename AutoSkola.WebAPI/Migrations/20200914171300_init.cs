using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoSkola.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 100, nullable: false),
                    Opis = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: false),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RasporedPolaganja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPolaganja = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasporedPolaganja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipUposlenika",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipUposlenika", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usluga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Cijena = table.Column<float>(nullable: false),
                    Opis = table.Column<string>(maxLength: 1000, nullable: false),
                    KategorijaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usluga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usluga_Kategorija",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kandidat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kandidat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnik_Kandidat",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kartice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojKartice = table.Column<long>(nullable: false),
                    SecurityCode = table.Column<int>(nullable: false),
                    ExpMonth = table.Column<int>(nullable: false),
                    ExpYear = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kartice_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnik_Uposlenik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    MarkaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Model__MarkaId__2180FB33",
                        column: x => x.MarkaId,
                        principalTable: "Marka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlogaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_Korisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_Uloga",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LjekarskoUvjerenje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzdavanja = table.Column<DateTime>(type: "date", nullable: false),
                    DatumVazenja = table.Column<DateTime>(type: "date", nullable: false),
                    Opis = table.Column<string>(maxLength: 1000, nullable: false),
                    KandidatId = table.Column<int>(nullable: false),
                    SposobanZaObuku = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LjekarskoUvjerenje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LjekarskoUvjerenje_Kandidat",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RasporedCasova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KandidatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasporedCasova", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RasporedCasova_Kandidat",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminRasporedaPolaganja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Od = table.Column<string>(maxLength: 50, nullable: false),
                    Do = table.Column<string>(maxLength: 50, nullable: false),
                    RasporedPolaganjaId = table.Column<int>(nullable: false),
                    KandidatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminRasporedaPolaganja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerminRasporedaPolaganja_Kandidat",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TerminRasporedaPolaganja_RasporedPolaganja",
                        column: x => x.RasporedPolaganjaId,
                        principalTable: "RasporedPolaganja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iznos = table.Column<float>(nullable: false),
                    Svrha = table.Column<string>(maxLength: 100, nullable: false),
                    DatumUplate = table.Column<DateTime>(type: "date", nullable: false),
                    KandidatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uplata_Kandidat",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UslugeProdavnica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KandidatId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UslugeProdavnica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UslugeProdavnica_Kandidat_KandidatId",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Potvrda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPolaganja = table.Column<DateTime>(type: "date", nullable: false),
                    KandidatId = table.Column<int>(nullable: false),
                    KategorijaId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Potvrda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Potvrda_Kandidat",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Potvrda_Kategorija",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Potvrda_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UposlenikTipUposlenika",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(nullable: false),
                    TipUposlenikaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UposlenikTipUposlenika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UposlenikTipUposlenika_TipUposlenika",
                        column: x => x.TipUposlenikaId,
                        principalTable: "TipUposlenika",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UposlenikTipUposlenika_Uposlenik",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Utisak",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<decimal>(nullable: false),
                    KandidatId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utisak", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utisak_Kandidat_KandidatId",
                        column: x => x.KandidatId,
                        principalTable: "Kandidat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Utisak_Uposlenik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategorijaId = table.Column<int>(nullable: false),
                    RegistarskaOznaka = table.Column<string>(maxLength: 10, nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    ModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vozilo_Kategorija",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozilo_Model",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjev",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPodnosenjaZahtjeva = table.Column<DateTime>(type: "date", nullable: false),
                    LjekarskoUvjerenjeId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false),
                    UslugaId = table.Column<int>(nullable: false),
                    Odobren = table.Column<bool>(nullable: false),
                    Odbacen = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjev", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zahtjev_LjekarskoUvjerenje",
                        column: x => x.LjekarskoUvjerenjeId,
                        principalTable: "LjekarskoUvjerenje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Uposlenik",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zahtjev_Usluga",
                        column: x => x.UslugaId,
                        principalTable: "Usluga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OdabranaUsluga",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UslugaId = table.Column<int>(nullable: false),
                    UslugeProdavnicaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdabranaUsluga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OdabranaUsluga_Usluga_UslugaId",
                        column: x => x.UslugaId,
                        principalTable: "Usluga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OdabranaUsluga_UslugeProdavnica_UslugeProdavnicaId",
                        column: x => x.UslugeProdavnicaId,
                        principalTable: "UslugeProdavnica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TerminRasporedCasova",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Od = table.Column<string>(maxLength: 50, nullable: false),
                    Do = table.Column<string>(maxLength: 50, nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    RasporedCasovaId = table.Column<int>(nullable: false),
                    UposlenikId = table.Column<int>(nullable: false),
                    VoziloId = table.Column<int>(nullable: false),
                    Teorija = table.Column<bool>(nullable: false),
                    Prakticno = table.Column<bool>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminRasporedCasova", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TerminRasporedCasova_RasporedCasova",
                        column: x => x.RasporedCasovaId,
                        principalTable: "RasporedCasova",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TerminRasporedCasova_Uposlenik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TerminRasporedCasova_Vozilo",
                        column: x => x.VoziloId,
                        principalTable: "Vozilo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Kandidat__80B06D40CCC24699",
                table: "Kandidat",
                column: "KorisnikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kartice_KorisnikId",
                table: "Kartice",
                column: "KorisnikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_LjekarskoUvjerenje_KandidatId",
                table: "LjekarskoUvjerenje",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_MarkaId",
                table: "Model",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_OdabranaUsluga_UslugaId",
                table: "OdabranaUsluga",
                column: "UslugaId");

            migrationBuilder.CreateIndex(
                name: "IX_OdabranaUsluga_UslugeProdavnicaId",
                table: "OdabranaUsluga",
                column: "UslugeProdavnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Potvrda_KandidatId",
                table: "Potvrda",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Potvrda_KategorijaId",
                table: "Potvrda",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Potvrda_UposlenikId",
                table: "Potvrda",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedCasova_KandidatId",
                table: "RasporedCasova",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminRasporedaPolaganja_KandidatId",
                table: "TerminRasporedaPolaganja",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminRasporedaPolaganja_RasporedPolaganjaId",
                table: "TerminRasporedaPolaganja",
                column: "RasporedPolaganjaId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminRasporedCasova_RasporedCasovaId",
                table: "TerminRasporedCasova",
                column: "RasporedCasovaId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminRasporedCasova_UposlenikId",
                table: "TerminRasporedCasova",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_TerminRasporedCasova_VoziloId",
                table: "TerminRasporedCasova",
                column: "VoziloId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_KandidatId",
                table: "Uplata",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "UQ__Uposleni__80B06D408E949E19",
                table: "Uposlenik",
                column: "KorisnikId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikTipUposlenika_TipUposlenikaId",
                table: "UposlenikTipUposlenika",
                column: "TipUposlenikaId");

            migrationBuilder.CreateIndex(
                name: "IX_UposlenikTipUposlenika_UposlenikId",
                table: "UposlenikTipUposlenika",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Usluga_KategorijaId",
                table: "Usluga",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_UslugeProdavnica_KandidatId",
                table: "UslugeProdavnica",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Utisak_KandidatId",
                table: "Utisak",
                column: "KandidatId");

            migrationBuilder.CreateIndex(
                name: "IX_Utisak_UposlenikId",
                table: "Utisak",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_KategorijaId",
                table: "Vozilo",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo_ModelId",
                table: "Vozilo",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "UQ__Vozilo__751AFE0F221233CC",
                table: "Vozilo",
                column: "RegistarskaOznaka",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_LjekarskoUvjerenjeId",
                table: "Zahtjev",
                column: "LjekarskoUvjerenjeId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_UposlenikId",
                table: "Zahtjev",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjev_UslugaId",
                table: "Zahtjev",
                column: "UslugaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kartice");

            migrationBuilder.DropTable(
                name: "KorisnikUloga");

            migrationBuilder.DropTable(
                name: "OdabranaUsluga");

            migrationBuilder.DropTable(
                name: "Potvrda");

            migrationBuilder.DropTable(
                name: "TerminRasporedaPolaganja");

            migrationBuilder.DropTable(
                name: "TerminRasporedCasova");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "UposlenikTipUposlenika");

            migrationBuilder.DropTable(
                name: "Utisak");

            migrationBuilder.DropTable(
                name: "Zahtjev");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "UslugeProdavnica");

            migrationBuilder.DropTable(
                name: "RasporedPolaganja");

            migrationBuilder.DropTable(
                name: "RasporedCasova");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "TipUposlenika");

            migrationBuilder.DropTable(
                name: "LjekarskoUvjerenje");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Usluga");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Kandidat");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Marka");

            migrationBuilder.DropTable(
                name: "Korisnik");
        }
    }
}
