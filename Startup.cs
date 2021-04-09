using Aula2ExemploCrud.Adapter;
using Aula2ExemploCrud.Bordas___Interfaces.UseCases.Repositorio;
using Aula2ExemploCrud.Bordas_Interfaces.Adapter;
using Aula2ExemploCrud.Bordas_Interfaces.UseCases;
using Aula2ExemploCrud.Context;
using Aula2ExemploCrud.Repositorios;
using Aula2ExemploCrud.Services;
using Aula2ExemploCrud.UseCase.Medico;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Aula2ExemploCrud
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

            services.AddEntityFrameworkNpgsql().AddDbContext<ContextData>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("bancoClinica")));

            #region Implementação de Interfaces de Medico

            services.AddScoped<IMedicoService, MedicoService>();

            services.AddScoped<IRepositorioMedicos, RepositorioMedicos>();

            services.AddScoped<IAdicionarMedicoUseCase, AdicionarMedicoUseCase>();
            services.AddScoped<IAtualizarMedicoUseCases, AtualizarMedicoUseCases>();
            services.AddScoped<IDeletarMedicoUseCase, DeletarMedicoUseCase>();
            services.AddScoped<IRetornaListaMedicosUseCase, RetornaListaMedicosUseCase>();
            services.AddScoped<IRetornaMedicoIdUseCase, RetornaMedicoIdUseCase>();

            services.AddScoped<IAdicionarMedicoAdapter, AdicionarMedicoAdapter>();

            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Clínica Médica", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Clínica Médica v1"));
            }

      


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
