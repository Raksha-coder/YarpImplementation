using Microsoft.AspNetCore.Mvc;
using PatientApplication.Entities;

namespace PatientApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static readonly List<Patient> patients = new List<Patient>
        {
            new Patient { Id = 1, Name = "Mayra shah", Age = 20, Address = "120 oak street" },
            new Patient { Id = 2, Name = "Neha Mishra", Age = 25, Address = "12 dong joe street" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Patient>> GetPatients()
        {
            return Ok(patients);
        }
    }
}
