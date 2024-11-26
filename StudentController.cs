using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentProject.DataAccess.Dtos;
using StudentProject.DataAccess.Interface;

namespace StudentProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [Route("RegisterStudent")]
        [HttpPost]
        public async ValueTask<IActionResult> RegisterAsync(StudentDto studentDto)
        {
            var result = await _studentRepository.RegisterAsync(studentDto);
            return Ok(result);
        }
    }

   
}
