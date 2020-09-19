using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts;

namespace PatientRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IRegistrationInterface _registration;

        public PatientController(IRegistrationInterface registration)
        {
            _registration = registration;
        }

        [HttpGet("GetAllSates")]
        public IActionResult GetAllSates()
        {
            return Ok(_registration.GetAllSates());
        }

        [HttpGet("GetCities")]
        public IActionResult GetCities(int stateId)
        {
            return Ok(_registration.GetCities(stateId));
        }

        [HttpGet("GetAllPatients")]
        public IActionResult GetAllPatients()
        {
            return Ok(_registration.GetAllPatients());
        }

        [HttpPost("SavePatientDetails")]
        public IActionResult SavePatientDetails(List<iMedOneDB.Models.TBLPATIENT> patientList)
        {
            return Ok(_registration.SavePatientDetails(patientList));
        }
    }
}
