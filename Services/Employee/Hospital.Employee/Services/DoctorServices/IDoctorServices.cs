using Hospital.Employee.Dtos.DoctorDtos;

namespace Hospital.Employee.Services.DoctorServices
{
    public interface IDoctorServices
    {
        Task<List<ResultDoctorDto>> GetAllDoctorsAsync();
        Task CreateDoctorAsync(CreateDoctorDto createDoctorDto);
        Task UpdateDoctorAsync(UpdateDoctorDto updateDoctorDto);
        Task DeleteDoctorAsync(int id);
        Task<GetByIdDoctorDto> GetByIdDoctorAsync(int id);

    }
}
