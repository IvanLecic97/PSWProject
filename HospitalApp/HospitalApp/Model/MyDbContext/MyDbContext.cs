using HospitalApp.Model.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Model.MyDbContext
{
    public class MyDbContext : DbContext 
    {
        
        public DbSet<RegUser> RegUsers { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin
                {
                    Id = 1,
                    Email = "admin@gmail.com",
                    Address = "Njegoseva 2",
                    Birthday = new DateTime(1938, 11, 08),
                    City = "Ljubinje",
                    Name = "Kosa",
                    Password = "123",
                    Phone = "059621610",
                    Surname = "Pesut"
                }
                 );
        } */
               
        }
    }

