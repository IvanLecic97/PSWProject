using HospitalApp.Model.MyDbContext;
using HospitalApp.Repository;
using HospitalApp.Repository.Users;
using HospitalApp.Repository.Users.PatientRepo;
using HospitalApp.Service.AppointmentService;
using HospitalApp.Service.UserService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp
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

            services.AddDbContext<MyDbContext>(options =>
             options.UseMySql(Configuration.GetConnectionString("MyDbContextConnectionString"), new MySqlServerVersion(new Version())).UseLazyLoadingProxies());

            services.AddScoped<IPatientRepository, PatientRepoBase>();
            services.AddScoped<IDoctorRepository, DoctorRepoBase>();
            services.AddScoped<IAppointmentRepository, AppointmentRepoBase>();



            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IAppointmentService, AppointmentService>();

            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options =>
            options.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod());


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
