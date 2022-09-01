﻿using HospitalApp.DTO;
using HospitalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Service.AppointmentService
{
   public interface IAppointmentService
    {

        public Appointment FindById(int id);

        public List<Appointment> FindSuitableAppointments(String DoctorName, String DateLower, String DateUpper);

        public List<Appointment> GetByDoctorId(int id);

        public List<Appointment> FindByDate(String DateLower, String DateUpper, List<Appointment> appointments);

        public List<Appointment> FindDateByPriority(String priority, String name, String DateLower, String DateUpper);

        public List<Appointment> GetForTimeInterval(List<Appointment> appointments, String DateLower, String DateUpper, String name);

        public String MakeAppointment(AppointmentDTO appointmentDTO);

        public List<Appointment> GetPatientsAppointments(String email);

        public String CancelAppointment(String email, int AppointmentId);
    }
}
