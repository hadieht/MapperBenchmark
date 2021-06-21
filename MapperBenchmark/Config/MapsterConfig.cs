using Mapster;

namespace MapperBenchmark.Config
{
    public static class MapsterConfig
    {
        private static readonly TypeAdapterConfig  typeAdapterConfig = GetTypeAdapterConfig();

        public static TypeAdapterConfig GetTypeAdapterConfig()
        {
            var config = new TypeAdapterConfig();
            config.NewConfig<DataModel.Entities.Person, DataModel.Dto.PersonDto>();
            return config;
        }


    }
}
