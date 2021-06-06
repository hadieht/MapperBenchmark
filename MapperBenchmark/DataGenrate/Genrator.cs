using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using MapperBenchmark.DataModel.Dto;

namespace MapperBenchmark.DataGenrate
{
    public static class Genrator
    {
        public static List<PersonDto> GetPersonGenratedData(int count)
        {
            var fixture = new Fixture();
            return fixture.CreateMany<PersonDto>(count).ToList();
        }

    }
}
