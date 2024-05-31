using api_dotnet.Entities;

namespace api_dotnet.Repositories.Interfaces;

public interface IStudentRepository : IBaseRepository<Student>
{
    Task<int> GetCareers(Guid idStudent);
}