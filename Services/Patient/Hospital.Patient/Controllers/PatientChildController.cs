using Hospital.Patient.Dtos.PatientChildDto;
using Hospital.Patient.Services.PatinetChildServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Hospital.Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientChildController : ControllerBase
    {
        private readonly IPatientChildService _patientChildService;

        public PatientChildController(IPatientChildService patientChildService)
        {
            _patientChildService = patientChildService;
        }
        [HttpGet]
        public async Task<IActionResult> PatientChildList()
        {
            var value = await _patientChildService.GetAllPatientChildAsync();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePatientChild(CreatePatientChildDto createPatientChildDto)
        {
            await _patientChildService.CreatePatientChildAsync(createPatientChildDto);
            return Ok("Ekleme Başarılı");
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePatientChild(string id)
        {
            await _patientChildService.DeletePatientChildAsync(id);
            return Ok("Silme Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePatientChild(UpdatePatientChildDto updatePatientChildDto)
        {
            await _patientChildService.UpdatePatientChildAsync(updatePatientChildDto);
            return Ok("Güncelleme Başarılı");
        }
        [HttpGet("GetPatientChild")]
        public async Task<IActionResult> GetPatientChild(string id)
        {
            var value=await _patientChildService.GetByIdPatientChildAsync(id);
            return Ok(value);
        }
    }
}
