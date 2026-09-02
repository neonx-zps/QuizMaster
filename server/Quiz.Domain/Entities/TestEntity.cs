namespace Quiz.Domain.Entities;

public class TestEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<TestResultEntity> Results { get; set; } = new();
}
