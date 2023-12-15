using Microsoft.AspNetCore.Mvc;
using Healthcare.Domain.Patients;

namespace Healthcare.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientAppService _appService;

        public PatientController(IPatientAppService appService)
            => _appService = appService;

        // GET: api/<PatientController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/<PatientController>
        [HttpPost]
        public IActionResult Post(ProblemDetails problemDetails)
        {
            return CreatedAtAction("api/Patient/", problemDetails);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
