using AutoMapper;
using StudentProject.DataAccess.Dtos;
using StudentProject.DataAccess.Interface;
using StudentProject.DataAccess.Model;

namespace StudentProject.DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IMapper _mapper;
        private StudentDbContext _dbContext;
        public StudentRepository(IMapper mapper, StudentDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public async ValueTask<ResponseBase> RegisterAsync(StudentDto studentDto)
        {
            var record = _mapper.Map<Student>(studentDto);
            await _dbContext.AddAsync(record);
            await _dbContext.SaveChangesAsync();
            return new SuccessResponse();
        }
    }
}
