using AutoMapper;
using MapperBenchmark.DataModel.Dto;
using MapperBenchmark.DataModel.Entities;

namespace MapperBenchmark.Config
{
    public static class AutoMapperConfig
    {
        public static IMapper AutoMapper { get; private set; }

        public static void SetUp()
        {
            AutoMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<AddressDto, Address>();
                config.CreateMap<EducationDto, Education>();
                config.CreateMap<EmailDto, Email>();
                config.CreateMap<PersonDto, Person>();
            }).CreateMapper();
        }
    }
}
