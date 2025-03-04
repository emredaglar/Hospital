using Hospital.Employee.Dtos.NurseDtos;

namespace Hospital.Employee.Services.NurseServices
{
    public interface INurseServices
    {
        Task<List<ResultNurseDto>> GetAllNursesAsync();
        Task CreateNurseAsync(CreateNurseDto createNurseDto);
        Task UpdateNurseAsync(UpdateNurseDto updateNurseDto);
        Task DeleteNurseAsync(int id);
        Task<GetByIdNurseDto> GetByIdNurseAsync(int id);
    }
}
