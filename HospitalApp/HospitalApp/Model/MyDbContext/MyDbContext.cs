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

<<<<<<< HEAD
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<AppointmentHistory> AppointmentHistory { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Savo",
                    Surname = "Naokmet",
                    Type = DoctorType.Family
                }
                );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 2,
                    Name = "Simo",
                    Surname = "Samardzic",
                    Type = DoctorType.Specalist
                }
                );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 3,
                    Name = "Nikola",
                    Surname = "Kosjerina",
                    Type = DoctorType.Family
                }
                );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 4,
                    Name = "Milorad Miko Messi",
                    Surname = "Medan",
                    Type = DoctorType.Specalist
                }
                );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    Date = new DateTime(2022, 09, 23, 10, 30, 50),
                    IsTaken = false,
                    DoctorId = 1
                   
                }
                   );

            modelBuilder.Entity<Appointment>().HasData(
               new Appointment
               {
                   Id = 2,
                   Date = new DateTime(2022, 09, 27, 11, 30, 00),
                   IsTaken = false,
                   DoctorId = 2
               }
                  );

            modelBuilder.Entity<Appointment>().HasData(
               new Appointment
               {
                   Id = 3,
                   Date = new DateTime(2022, 08, 30, 17, 00, 00),
                   IsTaken = false,
                   DoctorId = 3
                  
               }
                  );

            modelBuilder.Entity<Appointment>().HasData(
               new Appointment
               {
                   Id = 4,
                   Date = new DateTime(2022, 09, 05, 18, 00, 00),
                   IsTaken = false,
                   DoctorId = 4
                 
               }
                  );

            modelBuilder.Entity<Appointment>().HasData(
               new Appointment
               {
                   Id = 5,
                   Date = new DateTime(2022, 10, 02, 13, 30, 00),
                   IsTaken = false,
                   DoctorId = 1
                   
               }
                  );
        } 
=======
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
>>>>>>> 9894c3d50cfc14ee4b72c0f682c249a5534d1354
               
        }
    }

