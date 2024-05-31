namespace api_dotnet.Entities;

public class Career: IEntitiesBase
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}