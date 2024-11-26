using StudentProject.DataAccess.Dtos;

namespace StudentProject.DataAccess.Interface
{
    public interface IStudentRepository
    {
        ValueTask<ResponseBase> RegisterAsync(StudentDto studentDto);
    }
}
