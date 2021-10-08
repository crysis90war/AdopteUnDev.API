using AdopteUnDev.BLL.Interfaces;
using AdopteUnDev.DAL.Repositories;
using AdopteUnDev.DAL.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Connection;
using AdopteUnDev.BLL.Repositories;
using AdopteUnDev.BLL.Services;
using AdopteUnDev.API.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AdopteUnDev.API
{
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

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                OpenApiSecurityScheme openApiSecurityScheme = new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header
                };

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DemoRoleApi", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n                       Enter 'Bearer' [space] and then your token in the text input below.                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    //Défini une paire de clé valeur au niveau du dictionnaire
                    [openApiSecurityScheme] = new List<string>()
                });
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("ClientRequired", policy => policy.RequireAuthenticatedUser().RequireRole("Client"));
                options.AddPolicy("DevelopperRequired", policy => policy.RequireAuthenticatedUser().RequireRole("Developper"));
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenManager.secret)),
                        ValidateIssuer = true,
                        ValidIssuer = TokenManager.myIssuer,
                        ValidateAudience = true,
                        ValidAudience = TokenManager.myAudience,
                    };
                });

            /*
            Singleton => Une seule instance du service pour la durée de vie de l'application
            Scoped    => Une nouvelle instance à chaque appel client 
            Transient => Une nouvelle instance à chaque appel du service
            ! Chaque fois qu'un client va interroger le controller, l'instance de services va être crée pour toute la durée de l'appel !
            */

            services.AddSingleton(sp => new Connection(Configuration.GetConnectionString("default")));
            // token 
            services.AddSingleton<TokenManager>();

            // Ici l'ajout de mes routes
            // Exemple : services.AddScoped<IClientDalRepository, ClientDalRepository>();

            // injection de dependance pour le client 
            services.AddScoped<IClientDalRepository, ClientDalRepository>();
            services.AddScoped<IClientBllRepository, ClientBllRepository>();

            // injection de dependance pour le contrat 
            services.AddScoped<IContratDalRepository, ContratDalRepository>();
            services.AddScoped<IContratBllRepository, ContratBllRepository>();

            // Developpeur 
            services.AddScoped<IDeveloppeurDalRepository, DeveloppeurDalRepository>();
            services.AddScoped<IDeveloppeurBllRepository, DeveloppeurBllRepository>();

            //Competences
            services.AddScoped<ICompetenceDalRepository, CompetenceDalRepository>();
            services.AddScoped<ICompetenceBllRepository, CompetenceBllRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AdopteUnDev.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
