using Microsoft.AspNetCore.Mvc;
using ProviderApplication.Entities;

namespace ProviderApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //this controller will serve Http apis
    public class ProviderController : ControllerBase //without view support 
    {
        private static readonly List<Provider> providers = new List<Provider>
        {
            new Provider { Id = 1, Name = "Dr. Anita", Age = 45, Address = "20 opp. asha lawn", Designation = "Cardiologist" },
            new Provider { Id = 2, Name = "Dr. Shubham", Age = 50, Address = "101 opp. main street", Designation = "Dermatologist" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Provider>> GetProviders()
        {
            return Ok(providers);
        }
    }
}
