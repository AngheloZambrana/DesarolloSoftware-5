using api_dotnet.Entities;
using api_dotnet.Repositories.Interfaces;

namespace api_dotnet.Repositories.Concretes;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
    public StudentRepository(PostgresContext context) : base(context)
    {
        
    }

    public Task<int> GetCareers(Guid idStudent)
    {
        throw new NotImplementedException();
    }
}