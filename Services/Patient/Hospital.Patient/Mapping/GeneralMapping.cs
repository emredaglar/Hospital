using AutoMapper;
using Hospital.Patient.Dtos.PatientAdultDto;
using Hospital.Patient.Dtos.PatientChildDto;
using Hospital.Patient.Entities;

namespace Hospital.Patient.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultPatientAdultDto,PatientAdult>().ReverseMap();
            CreateMap<CreatePatientAdultDto,PatientAdult>().ReverseMap();
            CreateMap<GetByIdPatientAdultDto,PatientAdult>().ReverseMap();
            CreateMap<UpdatePatientAdultDto,PatientAdult>().ReverseMap();

            CreateMap<ResultPatientChildDto,PatientChild>().ReverseMap();
            CreateMap<CreatePatientChildDto,PatientChild>().ReverseMap();
            CreateMap<GetByIdPatientChildDto,PatientChild>().ReverseMap();
            CreateMap<UpdatePatientChildDto,PatientChild>().ReverseMap();
        }
    }
}
