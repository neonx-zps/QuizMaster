using Xunit;
using Quiz.Engine;
using Quiz.Core.Models;

namespace Quiz.Engine.Tests;

public class ScoringEngineTests
{
    [Fact]
    public void CalculateResult_WithCorrectAnswers_ShouldReturnPassedStatus()
    {
        // Arrange
        var engine = new ScoringEngine();
        var test = new Test { Id = "test1", Name = "Test 1" };
        test.Questions.Add(new Question { Id = "q1", Text = "Question 1", Points = 10 });
        
        var answers = new List<QuestionResult>
        {
            new QuestionResult { QuestionId = "q1", IsCorrect = true, Points = 10 }
        };

        // Act
        var result = engine.CalculateResult(test, answers);

        // Assert
        Assert.True(result.Passed);
        Assert.Equal(10, result.TotalPoints);
    }
}
