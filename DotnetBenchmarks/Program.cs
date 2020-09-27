
using BenchmarkDotNet.Running;

using DotnetBenchmarks.Benchmarks;

namespace DotnetBenchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<FindVsFirstOrDefault>();
            BenchmarkRunner.Run<AnyVsCount>();
            BenchmarkRunner.Run<IsVsEquals>();
        }
    }
}
