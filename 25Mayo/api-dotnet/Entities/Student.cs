namespace api_dotnet.Entities;

public class Student: IEntitiesBase
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public DateTime Birthday { get; set; }
    
}