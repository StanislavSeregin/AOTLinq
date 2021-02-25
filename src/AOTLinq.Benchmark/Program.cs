using BenchmarkDotNet.Running;

namespace AOTLinq.Benchmark
{
    class Program
    {
        static void Main(string[] _)
        {
            BenchmarkRunner.Run<Benchmark1>();
        }
    }
}
