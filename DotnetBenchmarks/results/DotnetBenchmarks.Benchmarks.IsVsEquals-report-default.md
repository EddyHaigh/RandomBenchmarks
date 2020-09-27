
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  .NET 4.7.2 : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT

Job=.NET 4.7.2  Runtime=.NET 4.7.2  

      Method |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------ |----------:|----------:|----------:|------:|------:|------:|----------:|
      IsNull | 0.0000 ns | 0.0000 ns | 0.0000 ns |     - |     - |     - |         - |
 EqualToNull | 0.0000 ns | 0.0000 ns | 0.0000 ns |     - |     - |     - |         - |
      Equals | 0.6898 ns | 0.0045 ns | 0.0038 ns |     - |     - |     - |         - |
