using AutoMapper;
using PretWorks.Helpers.Result.AutoMapper;
using Xunit;

namespace PretWorks.Helpers.Result.Tests
{
    public class Model1
    {
        public string Name { get; set; }
    }
    public class Model2
    {
        public string Name { get; set; }
    }

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Model1, Model2>();
        }
    }

    public class AutoMapperTests
    {
        [Fact]
        public void AutomapperTestSuccess()
        {
            Mapper.Initialize(c => c.AddProfile(typeof(AutoMapperProfile)));
            Mapper.AssertConfigurationIsValid();

            var model1 = new Model1
            {
                Name = "Test model 1"
            };

            var result = ResultHelper.Success<Model2>()
                                     .WithMappedValue(model1);

            Assert.NotNull(result);
            Assert.NotNull(result.Value);
            Assert.Equal(typeof(Model2), result.Value.GetType());
            Assert.Equal("Test model 1", result.Value.Name);
        }
    }
}