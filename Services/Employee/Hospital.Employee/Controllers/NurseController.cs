using Hospital.Employee.Dtos.NurseDtos;
using Hospital.Employee.Services.NurseServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseService _nurseService;

        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService;
        }

        [HttpGet]
        public async Task<IActionResult> NurseList()
        {
            var value = await _nurseService.GetAllNursesAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNurse(CreateNurseDto createNurseDto)
        {
            await _nurseService.CreateNurseAsync(createNurseDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteNurse(int id)
        {
            await _nurseService.DeleteNurseAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNurse(UpdateNurseDto updateNurseDto)
        {
            await _nurseService.UpdateNurseAsync(updateNurseDto);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("GetNurse")]
        public async Task<IActionResult> GetNurse(int id)
        {
            var value = await _nurseService.GetByIdNurseAsync(id);
            return Ok(value);
        }

    }
}
