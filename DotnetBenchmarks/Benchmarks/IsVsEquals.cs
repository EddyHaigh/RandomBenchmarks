using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace DotnetBenchmarks.Benchmarks
{
    [KeepBenchmarkFiles]
    [HtmlExporter]
    [MarkdownExporter]
    [SimpleJob(RuntimeMoniker.Net472)]
    [MemoryDiagnoser]
    public class IsVsEquals
    {
        private object SomeObject = null;

        [Benchmark]
        public bool IsNull()
        {
            return SomeObject is null;
        }

        [Benchmark]
        public bool EqualToNull()
        {
            return SomeObject == null;
        }

        [Benchmark]
        public bool Equals()
        {
            return Equals(SomeObject, null);
        }
    }
}
