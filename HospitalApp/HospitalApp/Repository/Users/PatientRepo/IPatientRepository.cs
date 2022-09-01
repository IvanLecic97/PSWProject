using HospitalApp.Model.Users;
using HospitalApp.Repository.CRUDRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Repository.Users.PatientRepo
{
  public interface IPatientRepository : ICRUDRepository<Patient, int>
    {
        Patient FindByEmailAndPassword(string email, string password);

        Patient FindByEmail(string email);

        IEnumerable<Patient> FindBlockedAndBlockablePatients();
    }
}
