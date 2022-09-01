using HospitalApp.Model;
using HospitalApp.Repository.CRUDRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Repository
{
    public interface IAppointmentHistoryRepository : ICRUDRepository<AppointmentHistory, int>
    {

    }
}
