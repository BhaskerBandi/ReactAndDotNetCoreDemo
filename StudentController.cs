using DemoCoreAndReactProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreAndReactProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IActionResult GetStudents()
        {

            List<StudentDetails> studentDetails = new List<StudentDetails>() {

            new StudentDetails()
            {
                Id = "101",
                StudentName = "Test1",
                Marks = 87
            },
            new StudentDetails()
            {
                Id = "102",
                StudentName = "Test2",
                Marks = 75
            },
            new StudentDetails()
            {
                Id = "103",
                StudentName = "Test3",
                Marks = 90
            }
            };

            return StatusCode(StatusCodes.Status200OK, studentDetails);
        //    return View(studentDetails);
        }

        //public List<StudentDetails> GetStudentDetails()
        //{
        //    List<StudentDetails> studentDetails = new List<StudentDetails>() {

        //    new StudentDetails()
        //    {
        //        Id = "101",
        //        StudentName = "Test1",
        //        Marks = 87
        //    },
        //    new StudentDetails()
        //    {
        //        Id = "102",
        //        StudentName = "Test2",
        //        Marks = 75
        //    },
        //    new StudentDetails()
        //    {
        //        Id = "103",
        //        StudentName = "Test3",
        //        Marks = 90
        //    }
        //    };

        //    return studentDetails;
        //}
    }
}
