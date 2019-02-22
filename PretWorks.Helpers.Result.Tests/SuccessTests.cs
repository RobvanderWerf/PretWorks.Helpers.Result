using Xunit;

namespace PretWorks.Helpers.Result.Tests
{
    public class SuccessTests
    {
        [Fact]
        public void IsSuccess()
        {
            var result = Result.Success();

            Assert.NotNull(result);
            Assert.True(result.Success);
            Assert.False(result.Failed);
            Assert.Empty(result.Messages);
            Assert.Empty(result.Keys);
        }

        [Fact]
        public void IsSuccess_value_empty()
        {
            var result = Result.Success<string>();

            Assert.NotNull(result);
            Assert.Null(result.Value);
            Assert.True(result.Success);
            Assert.False(result.Failed);
            Assert.Empty(result.Messages);
            Assert.Empty(result.Keys);
        }

        [Fact]
        public void IsSuccess_value_set()
        {
            var result = Result.Success<string>("test");

            Assert.NotNull(result);
            Assert.Equal("test",result.Value);
            Assert.True(result.Success);
            Assert.False(result.Failed);
            Assert.Empty(result.Messages);
            Assert.Empty(result.Keys);
        }

        [Fact]
        public void IsSuccess_value_set_withValue()
        {
            var result = Result.Success<string>()
                                     .WithValue("test");

            Assert.NotNull(result);
            Assert.Equal("test", result.Value);
            Assert.True(result.Success);
            Assert.False(result.Failed);
            Assert.Empty(result.Messages);
            Assert.Empty(result.Keys);
        }
    }
}