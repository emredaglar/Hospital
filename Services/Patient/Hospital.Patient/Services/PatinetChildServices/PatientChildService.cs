using AutoMapper;
using Hospital.Patient.Dtos.PatientChildDto;
using Hospital.Patient.Entities;
using Hospital.Patient.Settings;
using MongoDB.Driver;

namespace Hospital.Patient.Services.PatinetChildServices
{
    public class PatientChildService : IPatientChildService
    {
        private readonly IMongoCollection<PatientChild> _patientChildCollection;
        private readonly IMapper _mapper;

        public PatientChildService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client=new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _patientChildCollection=database.GetCollection<PatientChild>(_databaseSettings.PatientChildCollectionName);
            _mapper = mapper;
        }

        public Task CreatePatientChildAsync(CreatePatientChildDto createPatientChildDto)
        {
            throw new NotImplementedException();
        }

        public Task DeletePatientChildAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultPatientChildDto>> GetAllPatientChildAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdPatientChildDto> GetByIdPatientChildAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatientChildAsync(UpdatePatientChildDto updatePatientChildDto)
        {
            throw new NotImplementedException();
        }
    }
}
