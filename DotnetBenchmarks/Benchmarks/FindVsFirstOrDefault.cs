using AutoFixture;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DotnetBenchmarks.Benchmarks
{
    [KeepBenchmarkFiles]
    [HtmlExporter]
    [MarkdownExporter]
    [SimpleJob(RuntimeMoniker.Net472)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.NetCoreApp21)]
    public class FindVsFirstOrDefault
    {
        private IEnumerable<string> EnumString;
        private IList<string> IListString;
        private List<string> ListString;
        private ICollection<string> ICollectionString;
        private Collection<string> CollectionString;
        private string[] StringArray;

        private string StringToSearch;


        [Params(10, 100, 1000)]
        public int Size;

        [GlobalSetup]
        public void Setup()
        {
            var fixture = new Fixture();
            EnumString = fixture.CreateMany<string>(Size);

            StringToSearch = EnumString.First();

            IListString = EnumString.ToList();
            ListString = EnumString.ToList();
            ICollectionString = IListString.ToList();
            CollectionString = new Collection<string>(IListString);
            StringArray = EnumString.ToArray();
        }

        [Benchmark]
        public string EnumFirstOrDefault()
        {
            return EnumString.FirstOrDefault(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string ICollectionFirstOrDefault()
        {
            return ICollectionString.FirstOrDefault(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string CollectionFirstOrDefault()
        {
            return CollectionString.FirstOrDefault(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string IListFirstOrDefault()
        {
            return IListString.FirstOrDefault(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string ListFirstOrDefault()
        {
            return ListString.FirstOrDefault(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string ListFind()
        {
            return ListString.Find(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string ArrayFirstOrDefault()
        {
            return StringArray.FirstOrDefault(f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }

        [Benchmark]
        public string ArrayFind()
        {
            return Array.Find(StringArray, f => f.Equals(StringToSearch, StringComparison.OrdinalIgnoreCase));
        }
    }
}
