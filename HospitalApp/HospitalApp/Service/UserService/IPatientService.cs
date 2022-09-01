﻿using HospitalApp.DTO;
using HospitalApp.Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Service.UserService
{
   public interface IPatientService
    {
        public Patient FindById(int id);

        public Patient FindByEmail(string email);

        public void SavePatient(Patient patient);
        public Patient PatientLogin(string email, string password);

        public bool AddPatient(PatientDTO patientDTOForRegistration);

        public List<Patient> FindAll();
    }
}
