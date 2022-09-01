using HospitalApp.Model;
using HospitalApp.Repository.CRUDRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Repository
{
 public   interface IAppointmentRepository : ICRUDRepository<Appointment, int>
    {
        public Appointment FindByDoctorId(int id);
        public void UpdateAppointment(Appointment a);

        public List<Appointment> FindByPatientsId(int id);
        
    }
}
