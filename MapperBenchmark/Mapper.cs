using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using MapperBenchmark.Config;
using MapperBenchmark.DataGenrate;
using Mapster;

namespace MapperBenchmark
{
    [ThreadingDiagnoser]
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [HtmlExporter, CsvExporter, PlainExporter, JsonExporter]
    public class Mapper
    {
        [Params(1, 10, 100, 1000, 10000, 100000)]
        public int PersonCount;

        private List<DataModel.Entities.Person> _personEntities;

        public Mapper()
        {
            AutoMapperConfig.SetUp();
        }

        [GlobalSetup]
        public void Setup()
        {
            _personEntities = Genrator.GetPersonGenratedData(PersonCount);
        }

        [Benchmark(Baseline = true)]
        public List<DataModel.Dto.PersonDto> ManualMapping()
        {
            return _personEntities.ToPersonDtoList();
        }

        [Benchmark]
        public List<DataModel.Dto.PersonDto> AutoMapper()
        {
            return AutoMapperConfig.AutoMapper.Map<List<DataModel.Dto.PersonDto>>(_personEntities);
        }

        [Benchmark]
        public List<DataModel.Dto.PersonDto> Mapster()
        {
            return _personEntities.Adapt<List<DataModel.Dto.PersonDto>>();
        }

        //[Benchmark]
        //public List<DataModel.Dto.PersonDto> MapsterWithConfig()
        //{
        //    var config = MapsterConfig.GetTypeAdapterConfig();
        //    return _personEntities.Adapt<List<DataModel.Dto.PersonDto>>(config);
        //}

        //[Benchmark]
        //public List<DataModel.Dto.PersonDto> MapsterWithAdaptToType()
        //{
        //    var mapper = new MapsterMapper.Mapper();
        //    return mapper.From(_personEntities).AdaptToType<List<DataModel.Dto.PersonDto>>();
        //}
    }
}
