using BenchmarkDotNet.Attributes;

namespace AOTLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Benchmark1
    {
        [Benchmark]
        public void Some()
        {
        }
    }
}
