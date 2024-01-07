using Microsoft.AspNetCore.Mvc;
using Healthcare.Domain.Patients;
using Healthcare.Domain.Dtos;

namespace Healthcare.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientAppService _appService;

        public PatientController(IPatientAppService appService)
            => _appService = appService;

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _appService.GetAsync());

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _appService.GetPatientDtoAsync(id));

        // POST api/<PatientController>
        [HttpPost]
        public async Task<IActionResult> Post(PatientCreate request)
        {
            var id = await _appService.CreateAsync(request);
            return CreatedAtAction("api/Patient/", id);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _appService.DeleteAsync(id);
            return Ok();
        }
    }
}
