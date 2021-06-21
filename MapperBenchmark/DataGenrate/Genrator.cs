using System.Collections.Generic;
using System.Linq;
using AutoFixture;

namespace MapperBenchmark.DataGenrate
{
    public static class Genrator
    {
        public static List<DataModel.Entities.Person> GetPersonGenratedData(int count)
        {
            var fixture = new Fixture();
            return fixture.CreateMany<DataModel.Entities.Person>(count).ToList();
        }

    }
}
