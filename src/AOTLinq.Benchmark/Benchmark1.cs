using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace AOTLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Benchmark1
    {
        [Benchmark]
        public void For()
        {
            var list = new List<int>();
            for (var i = 0; i < 10000; i++)
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void Enumerable_Range_Foreach()
        {
            var list = new List<int>();
            foreach (var i in Enumerable.Range(0, 10000))
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void Enumerable_Range_Select()
        {
            _ = Enumerable.Range(0, 10000).Select(i => i).ToArray();
        }

        [Benchmark]
        public void AotEnumerable_Range_Foreach()
        {
            var list = new List<int>();
            foreach (var i in AotEnumerable.Range(0, 10000))
            {
                list.Add(i);
            }
        }

        [Benchmark]
        public void AotEnumerable_Range_Select()
        {
            _ = AotEnumerable.Range(0, 10000).Select(i => i).ToArray();
        }
    }
}
