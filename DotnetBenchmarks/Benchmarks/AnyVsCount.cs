using AutoFixture;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Exporters;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DotnetBenchmarks.Benchmarks
{
    [MarkdownExporterAttribute.GitHub]
    [HtmlExporter]
    public class AnyVsCount
    {
        private IEnumerable<string> EnumString;
        private IList<string> IListString;
        private List<string> ListString;
        private ICollection<string> ICollectionString;
        private Collection<string> CollectionString;
        private string[] StringArray;


        [Params(10, 100, 1000)]
        public int Size;

        [GlobalSetup]
        public void Setup()
        {
            var fixture = new Fixture();
            EnumString = fixture.CreateMany<string>(Size);

            IListString = EnumString.ToList();
            ListString = EnumString.ToList();
            ICollectionString = IListString.ToList();
            CollectionString = new Collection<string>(IListString);
            StringArray = EnumString.ToArray();
        }

        [Benchmark]
        public bool IEnumAny()
        {
            return EnumString.Any();
        }

        [Benchmark]
        public bool ICollectionAny()
        {
            return ICollectionString.Any();
        }

        [Benchmark]
        public bool ICollectionCount()
        {
            return ICollectionString.Count > 0;
        }

        [Benchmark]
        public bool CollectionAny()
        {
            return CollectionString.Any();
        }

        [Benchmark]
        public bool CollectionCount()
        {
            return CollectionString.Count > 0;
        }

        [Benchmark]
        public bool IListAny()
        {
            return IListString.Any();
        }

        [Benchmark]
        public bool IListCount()
        {
            return IListString.Count > 0;
        }

        [Benchmark]
        public bool ListAny()
        {
            return ListString.Any();
        }

        [Benchmark]
        public bool ListCount()
        {
            return ListString.Count > 0;
        }

        [Benchmark]
        public bool ArrayAny()
        {
            return StringArray.Any();
        }

        [Benchmark]
        public bool ArrayLength()
        {
            return StringArray.Length > 0;
        }
    }
}
