using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Services.DoctorServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<IActionResult> DoctorList()
        {
            var value = await _doctorService.GetAllDoctorsAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDoctor(CreateDoctorDto createDoctorDto)
        {
            await _doctorService.CreateDoctorAsync(createDoctorDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            await _doctorService.DeleteDoctorAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDoctor(UpdateDoctorDto updateDoctorDto)
        {
            await _doctorService.UpdateDoctorAsync(updateDoctorDto);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("GetDoctor")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            var value = await _doctorService.GetByIdDoctorAsync(id);
            return Ok(value);
        }

    }
}
