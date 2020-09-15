using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AutoMapper;
using AutoSkola.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using AutoSkola.WebAPI.Services;
using AutoSkola.Model.Requests;
using AutoSkola.WebAPI.Services.Kandidati;
using AutoSkola.WebAPI.Services.UplateServices;
using AutoSkola.WebAPI.Services.Zahtjevi;
using AutoSkola.WebAPI.Services.RasporedCasovaService;
using AutoSkola.WebAPI.Services.RasporedCasovaService.TerminRasporeda;
using AutoSkola.Model;
using AutoSkola.WebAPI.Services.Usluge;
using AutoSkola.WebAPI.Services.RasporedPolaganja;
using AutoSkola.WebAPI.Services.RasporedPolaganja.TerminRasporedaPolaganja;
using AutoSkola.WebAPI.Services.Kategorije;
using AutoSkola.WebAPI.Services.Uposlenici;
using AutoSkola.WebAPI.Services.Potvrde;
using AutoSkola.WebAPI.Services.Vozilo;
using System.Runtime;
using AutoSkola.WebAPI.Services.Marka;
using AutoSkola.WebAPI.Services.Model;
using AutoSkola.WebAPI.Services.Korisnik;
using AutoSkola.WebAPI.Services.TipUposlenika;
using AutoSkola.WebAPI.Services.KorisnikUloga;
using AutoSkola.WebAPI.Services.Uloga;
using AutoSkola.WebAPI.Services.UposlenikTipUposlenika;
using Microsoft.AspNetCore.Authentication;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;
using AutoSkola.WebAPI.Filters;
using AutoSkola.WebAPI.Security;
using AutoSkola.WebAPI.Services.LjekarskoUvjerenje;
using AutoSkola.WebAPI.Services.UslugeProdavnica;
using AutoSkola.WebAPI.Services.OdabraneUsluge;
using AutoSkola.WebAPI.Services.Utisci;

namespace AutoSkola.WebAPI
{

    public class AuthOperationFilter : Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var isAuthorized = context.MethodInfo.DeclaringType.GetCustomAttributes(true).OfType<AuthorizeAttribute>().Any() ||
                               context.MethodInfo.GetCustomAttributes(true).OfType<AuthorizeAttribute>().Any();
            if (!isAuthorized) return;
            operation.Responses.TryAdd("401", new OpenApiResponse { Description = "Unauthorized" });
            operation.Responses.TryAdd("403", new OpenApiResponse { Description = "Forbidden" });
            var basicSecurityScheme = new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basic" },
            };
            operation.Security.Add(new OpenApiSecurityRequirement()
            {
                [basicSecurityScheme] = new string[] { }
            });
        }
    }

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(options => options.Filters.Add(new ErrorFilter()));

            services.AddDbContext<AutoSkolaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Docker")));

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
                    ("BasicAuthentication", null);

            services.AddMvc()
#pragma warning disable CS0618 // 'CompatibilityVersion.Version_2_2' is obsolete: 'This CompatibilityVersion value is obsolete. The recommended alternatives are Version_3_0 or later.'
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
#pragma warning restore CS0618 // 'CompatibilityVersion.Version_2_2' is obsolete: 'This CompatibilityVersion value is obsolete. The recommended alternatives are Version_3_0 or later.'
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        var problems = new ValidateFilter(context);
                        return new BadRequestObjectResult(problems);
                    };
                });

            services.Configure<ApiBehaviorOptions>(a =>
            {
                a.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ValidateFilter(context);
                    return new BadRequestObjectResult(problemDetails)
                    {
                        ContentTypes = { "application / problem + json", "application / problem + xml" }
                    };
                };
            });

            ConfigureInterfaces(services);

            services.AddSwaggerGen(c => { 
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API V1", Version = "v1" });
                c.AddSecurityDefinition("basic",
                        new OpenApiSecurityScheme()
                        {
                            Name = "Authorization",
                            Type = SecuritySchemeType.Http,
                            Scheme = "basic",
                            In = ParameterLocation.Header,
                            Description = "Basic authentication header"
                        });
                c.OperationFilter<AuthOperationFilter>();
            });

            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();              
        }

        private void ConfigureInterfaces(IServiceCollection services)
        {
            services.AddScoped<ICRUDBaseService<Model.MKandidat, KandidatSearchRequest, KandidatUpsertRequest, KandidatUpsertRequest>, KandidatService>();
            services.AddScoped<ICRUDBaseService<Model.MUplate, UplataSearchRequest, UplataUpsertRequest, UplataUpsertRequest>, UplateService>();
            services.AddScoped<ICRUDBaseService<Model.MZahtjevi, ZahtjeviSearchRequest, ZahtjeviUpsertRequest, ZahtjeviUpsertRequest>, ZahtjeviService>();
            services.AddScoped<ICRUDBaseService<MRasporedCasova, RasporedSearchRequest,RasporedCasovaUpsertRequest,object>, RasporedService>();
            services.AddScoped<ICRUDBaseService<Model.MTerminRasporedaCasova, TerminRCSearchRequest, TeminRCUpsertRequest, TeminRCUpsertRequest>, TerminRasporedaCasovaService>();
            services.AddScoped<ICRUDBaseService<Model.MUsluge, ZahtjeviSearchRequest, ZahtjeviUpsertRequest, ZahtjeviUpsertRequest>, UslugaZahtjevService>();
            services.AddScoped<ICRUDBaseService<Model.MRasporedPolaganja, RasporedPolaganjaSearchRequest, RasporedPolaganjaUpsertRequest, object>, RasporedPolaganjaService>();
            services.AddScoped<ICRUDBaseService<Model.MTerminRasporedaPolaganja, TerminRPSearchRequest, TerminRPUpsertRequest, TerminRPUpsertRequest>, TerminRasporedaPolaganjaService>();
            services.AddScoped<ICRUDBaseService<Model.MUsluge, UslugaSearchRequest, UslugaUpsertRequest, UslugaUpsertRequest>, UslugaService>();
            services.AddScoped<ICRUDBaseService<Model.MKategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest>, KategorijeService>();
            services.AddScoped<ICRUDBaseService<Model.MUposlenik, UposleniciSearchRequest, UposlenikUpsertRequest, UposlenikUpsertRequest>, UposleniciService>();
            services.AddScoped<ICRUDBaseService<Model.MPotvrda, PotvrdaSearchRequest, PotvrdaUpsertRequest, object>, PotvrdeService>();
            services.AddScoped<ICRUDBaseService<Model.MVozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest>, VoziloService>();
            services.AddScoped<ICRUDBaseService<Model.MMarka, object, object, object>, MarkaService>();
            services.AddScoped<ICRUDBaseService<Model.MModel, object, object, object>, ModelService>();
            services.AddScoped<IKorisniciService, KorisnikService>();
            services.AddScoped<ICRUDBaseService<MKorisnikUloga, KorisnikUlogaSearchRequest, KorisnikUlogaUpsertRequest, object>, KorisnikUlogaService>();
            services.AddScoped<IBaseServices<MUloga, object>, UlogaService>();
            services.AddScoped<ICRUDBaseService<MUposlenikTipUposlenika, object, UTUUpsertRequest, object>, UposlenikTipUposlenikaService>();
            services.AddScoped<IBaseServices<MTipUposlenika, object>, TipUposlenikaService>();
            services.AddScoped<ICRUDBaseService<MLjekarskoUvjerenje, object, object, object>, LjekarskoUvjerenjeService>();
            services.AddScoped<ICRUDBaseService<MUslugeProdavnica, object, UslugeProdavnicaUpsertRequest, object>, UslugeProdavnicaService>();
            services.AddScoped<ICRUDBaseService<MOdabraneUsluge, object, OdabraneUslugeUspertRequest, object>, OdabraneUslugeService>();
            services.AddScoped<ICRUDBaseService<MUtisak, UtisakSearchRequest, UtisakUpsertRequest, object>,UtisciService>();
            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
