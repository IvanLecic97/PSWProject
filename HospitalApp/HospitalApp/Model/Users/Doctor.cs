using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Model.Users
{
    public class Doctor
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Surname { get; set; }

        public DoctorType Type { get; set; }



    }
}
