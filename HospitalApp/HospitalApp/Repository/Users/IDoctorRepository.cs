using HospitalApp.Model.Users;
using HospitalApp.Repository.CRUDRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Repository.Users
{
   public interface IDoctorRepository : ICRUDRepository<Doctor, int>
    {
        public Doctor FindByDoctorName(String name);


       //  public Doctor GetBranchFromId(int id);
    }
}
