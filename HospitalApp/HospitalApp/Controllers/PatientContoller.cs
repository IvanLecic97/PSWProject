using HospitalApp.DTO;
using HospitalApp.Model.Users;
using HospitalApp.Service.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalApp.Controllers
{

    [Produces("application/json")]
    [Route("patients")]
    [ApiController]
    public class PatientContoller : ControllerBase
    {
        private readonly IPatientService patientService;


        public PatientContoller(IPatientService patientService)
        {
            this.patientService = patientService;
        }


        [HttpPost("register")]
        public IActionResult Register([FromBody] PatientDTO patientDTO)
        {
            patientService.AddPatient(patientDTO);
            return Ok();
        }

        [HttpGet("getUsers")]
        public List<Patient> getAll()
        {
            return patientService.FindAll().ToList();
        }





    }
}
