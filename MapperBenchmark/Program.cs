using BenchmarkDotNet.Running;

namespace MapperBenchmark
{


    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Mapper>();
        }


    }
}
