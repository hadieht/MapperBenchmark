using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using MapperBenchmark.Config;
using MapperBenchmark.DataGenrate;
using MapperBenchmark.DataModel.Dto;
using MapperBenchmark.DataModel.Entities;
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

        [Params(1, 10, 100, 1000, 10000, 100000, 1000000)]
        public int PersonCount;

        private List<PersonDto> _personDtos;

        public Mapper()
        {
            AutoMapperConfig.SetUp();
        }

        [GlobalSetup]
        public void Setup()
        {
            _personDtos = Genrator.GetPersonGenratedData(PersonCount);
        }

        [Benchmark(Baseline = true)]
        public List<Person> ManualMapping()
        {
            return _personDtos.ToPersonList();
        }

        [Benchmark]
        public List<Person> Mapster()
        {
            return _personDtos.Adapt<List<Person>>();
        }

        [Benchmark]
        public List<Person> AutoMapper()
        {
            return AutoMapperConfig.AutoMapper.Map<List<Person>>(_personDtos);
        }
    }
}
