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
                config.CreateMap<Address, AddressDto>();
                config.CreateMap<Education, EducationDto>();
                config.CreateMap<Email, EmailDto>();
                config.CreateMap<Person, PersonDto>();
            }).CreateMapper();
        }
    }
}
