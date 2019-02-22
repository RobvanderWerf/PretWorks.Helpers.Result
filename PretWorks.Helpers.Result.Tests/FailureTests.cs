using Xunit;

namespace PretWorks.Helpers.Result.Tests
{
    public class FailureTests
    {
        [Fact]
        public void IsFailure()
        {
            var result = Result.Failed();

            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Messages);
            Assert.Empty(result.Keys);
        }

        [Fact]
        public void IsFailure_WithMessage()
        {
            var result = Result.Failed()
                .WithMessage("Test");

            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Keys);
            Assert.Equal("Test",result.ToString());
        }
    }
}