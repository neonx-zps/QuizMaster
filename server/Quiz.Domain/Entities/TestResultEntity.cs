namespace Quiz.Domain.Entities;

public class TestResultEntity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string TestId { get; set; } = string.Empty;
    public string ParticipantName { get; set; } = string.Empty;
    public int Score { get; set; }
    public int MaxScore { get; set; }
    public DateTime CompletedAt { get; set; } = DateTime.UtcNow;
    public bool Passed { get; set; }
}
