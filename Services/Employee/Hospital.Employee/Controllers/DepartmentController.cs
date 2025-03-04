using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Services.DepartmentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> DepartmentList()
        {
            var value = await _departmentService.GetAllDepartmentsAsync();
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(CreateDepartmentDto createDepartmentDto)
        {
            await _departmentService.CreateDepartmentAsync(createDepartmentDto);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            await _departmentService.DeleteDepartmentAsync(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment(UpdateDepartmentDto updateDepartmentDto)
        {
            await _departmentService.UpdateDepartmentAsync(updateDepartmentDto);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("GetDepartment")]
        public async Task<IActionResult> GetDepartment(int id)
        {
            var value = await _departmentService.GetByIdDepartmentAsync(id);
            return Ok(value);
        }

    }
}
