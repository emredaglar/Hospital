using Hospital.Patient.Dtos.PatientAdultDto;
using Hospital.Patient.Dtos.PatientChildDto;

namespace Hospital.Patient.Services.PatinetChildServices
{
    public interface IPatientChildService
    {
        Task<List<ResultPatientChildDto>> GetAllPatientChildAsync();
        Task CreatePatientChildAsync(CreatePatientChildDto createPatientChildDto);
        Task UpdatePatientChildAsync(UpdatePatientChildDto updatePatientChildDto);
        Task DeletePatientChildAsync(string id);
        Task<GetByIdPatientChildDto> GetByIdPatientChildAsync(string id);
    }
}
