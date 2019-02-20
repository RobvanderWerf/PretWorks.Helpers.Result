using Xunit;

namespace PretWorks.Helpers.Result.Tests
{
    public class FailureTests
    {
        [Fact]
        public void IsFailure()
        {
            var result = ResultHelper.Failed();

            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Messages);
            Assert.Empty(result.Keys);
        }

        [Fact]
        public void IsFailure_WithMessage()
        {
            var result = ResultHelper.Failed()
                .WithMessage("Test");

            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Keys);
            Assert.Equal("Test",result.ToString());
        }
    }
}