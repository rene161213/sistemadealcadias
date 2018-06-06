using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration; //extension que se utiliza con IConfigurationRoot
using Microsoft.EntityFrameworkCore; //extension para conexion con SQLServer
using paragit.Models;

namespace paragit
{
    public class Startup
    {
        //propiedad para administrar la conexion con el DBMS
        private IConfigurationRoot _configurationRoot;
        //agregacion del metodo constructor de la clase StartUp para instacia de la conexion
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

        }//fin del constructor
        
        public void ConfigureServices(IServiceCollection services)
        {
            //registrar el AppDBContext para interctuar con la conexion al DBMS
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //Regisrando nuestras clases interfaces y repositorio
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IEmpleadoRepositorio, EmpleadoRepositorio>();
            services.AddTransient<IDespachoSolicitudes, DespachoSolicitudRepositorio>();
            services.AddTransient<ISolicitudRepositorio, SolicitudRepositorio>();
            services.AddTransient<IArchivoRepositorio, ArchivoRepositorio>();
            services.AddTransient<IOcupacionRepositorio, OcupacionRepositorio>();
            services.AddTransient<IEstadoRepositorio, EstadoRepositorio>();
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<INacionalidadRepositorio, NacionalidadRepositorio>();
            services.AddTransient<ITipoArchivoRepositorio, TipoArchivoRepositorio>();
            services.AddTransient<INivelAcademicoRepositorio, NivelAcademicoRepositorio>();
            services.AddTransient<ICatModoInformacionRepositorio, CatModoInformacionRepositorio>();
            services.AddTransient<ICatModoNotificacionRepositorio, CatModoNotiRepositorio>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(
                ruta => { ruta.MapRoute(name: "default", 
                template: "{controller=Home}/{action=Index}/{id?}"); }
                );
            app.UseDeveloperExceptionPage();
            loggerFactory.AddConsole();
            DataInicio.AgregarDataInicio(app);
        }
    }
}
