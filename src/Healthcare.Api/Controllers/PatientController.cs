using Microsoft.AspNetCore.Mvc;
using Healthcare.Domain.Patients;
using Healthcare.Domain.Dtos;
using System.Net;
using Microsoft.AspNetCore.Http.HttpResults;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)            
        {
            var result = await _appService.GetPatientDtoAsync(id);
            
            if (result is null)
               return NotFound();
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PatientCreate request)
        {
            if (ModelState.IsValid)
            {
                var id = await _appService.CreateAsync(request);
                return CreatedAtAction("api/Patient/", id);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, PatientUpdate request)
        {
            if (ModelState.IsValid)
            {
                await _appService.UpdateAsync(request, id);
                return Ok();
            }
            return BadRequest(ModelState);
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
