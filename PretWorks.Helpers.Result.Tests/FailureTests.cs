using System;
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
        public void IsFailure_WithValue()
        {
            var result = Result.Failed<string>()
                               .WithValue("Test");

            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.Equal("Test", result.Value);
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
            Assert.Equal("Test", result.ToString());
        }

        [Fact]
        public void IsFailure_WithValue_WithMessage()
        {
            var result = Result.Failed<string>()
                               .WithValue("Test")
                               .WithMessage("Something failed");

            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.Equal("Test", result.Value);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Keys);
            Assert.Equal("Something failed", result.ToString());
        }

        [Fact]
        public void IsFailure_WithException()
        {
            var result = Result.Failed()
                .WithException(new Exception("Test"));

            Assert.NotNull(result);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Keys);
            Assert.Equal("System.Exception: Test", result.ToString());
        }

        [Fact]
        public void IsFailure_WithValue_WithException()
        {
            var result = Result.Failed<string>()
                               .WithValue("Test")
                               .WithException(new Exception("Test"));

            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.Equal("Test", result.Value);
            Assert.False(result.Success);
            Assert.True(result.Failed);
            Assert.Empty(result.Keys);
            Assert.Equal("System.Exception: Test", result.ToString());
        }
    }
}