using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StudentController: ControllerBase
{
   [HttpGet] 
   public async Task<IActionResult> GetStudents()
   {
        var i = 0;
        var j = 0;
        var x = i/j;
        var response = new List<Student>
        {
            new Student
            {
                Name = "Hugo",
                LastName = "Oropeza",
                BirthDate = new DateTime(2004, 08, 20),
                Id = Guid.NewGuid()
            }
            
        };
        return Ok(response); 
   }
}