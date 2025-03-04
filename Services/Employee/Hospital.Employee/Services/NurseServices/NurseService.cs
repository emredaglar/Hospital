using AutoMapper;
using Hospital.Employee.Context;
using Hospital.Employee.Dtos.NurseDtos;
using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Services.NurseServices
{
    public class NurseService:INurseService
    {
        private readonly EmployeeContext _context;
        private readonly IMapper _mapper;

        public NurseService(EmployeeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateNurseAsync(CreateNurseDto createNurseDto)
        {
            var values = _mapper.Map<Nurse>(createNurseDto);
            await _context.Nurses.AddAsync(values);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNurseAsync(int id)
        {
            var values = await _context.Nurses.FindAsync(id);
            if (values != null)
            {
                _context.Nurses.Remove(values);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ResultNurseDto>> GetAllNursesAsync()
        {
            var values = await _context.Nurses.ToListAsync();
            return _mapper.Map<List<ResultNurseDto>>(values);
        }

        public async Task<GetByIdNurseDto> GetByIdNurseAsync(int id)
        {
            var values = await _context.Nurses.FindAsync(id);
            return _mapper.Map<GetByIdNurseDto>(values);
        }

        public async Task UpdateNurseAsync(UpdateNurseDto updateNurseDto)
        {
            var values = _mapper.Map<Nurse>(updateNurseDto);
            _context.Nurses.Update(values);
            await _context.SaveChangesAsync();
        }

    }
}
