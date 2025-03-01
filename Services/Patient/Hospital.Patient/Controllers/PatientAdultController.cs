﻿using Hospital.Patient.Dtos.PatientAdultDto;
using Hospital.Patient.Services.PatientAdultServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Patient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientAdultController : ControllerBase
    {
        private readonly IPatientAdultService _patientAdultService;

        public PatientAdultController(IPatientAdultService patientAdultService)
        {
            _patientAdultService = patientAdultService;
        }

        [HttpGet]
        public async Task<IActionResult> PatientAdultList()
        {
            var value = await _patientAdultService.GetAllPatientAdultAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatientAdult(CreatePatientAdultDto createPatientAdultDto)
        {
            await _patientAdultService.CreatePatientAdultAsync(createPatientAdultDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePatientAdult(string id)
        {
            await _patientAdultService.DeletePatientAdultAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePatientAdult(UpdatePatientAdultDto updatePatientAdultDto)
        {
            await _patientAdultService.UpdatePatientAdultAsync(updatePatientAdultDto);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("GetPatientAdult")]
        public async Task<IActionResult> GetPatientAdult(string id)
        {
            var value = await _patientAdultService.GetByIdPatientAdultAsync(id);
            return Ok(value);
        }
    }
}
