``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|           Method | Size |       Mean |     Error |    StdDev |     Median |
|----------------- |----- |-----------:|----------:|----------:|-----------:|
|         **IEnumAny** |   **10** | **41.8218 ns** | **0.6777 ns** | **0.6008 ns** | **41.9566 ns** |
|   ICollectionAny |   10 | 15.8556 ns | 0.3339 ns | 0.3845 ns | 15.8163 ns |
| ICollectionCount |   10 |  1.3490 ns | 0.0222 ns | 0.0197 ns |  1.3427 ns |
|    CollectionAny |   10 | 17.1247 ns | 0.1879 ns | 0.1665 ns | 17.1593 ns |
|  CollectionCount |   10 |  1.5836 ns | 0.0189 ns | 0.0167 ns |  1.5801 ns |
|         IListAny |   10 | 15.2904 ns | 0.1615 ns | 0.1349 ns | 15.2888 ns |
|       IListCount |   10 |  1.3730 ns | 0.0145 ns | 0.0136 ns |  1.3686 ns |
|          ListAny |   10 | 16.1121 ns | 0.3483 ns | 0.4767 ns | 16.0159 ns |
|        ListCount |   10 |  0.0016 ns | 0.0051 ns | 0.0045 ns |  0.0000 ns |
|         ArrayAny |   10 | 11.4833 ns | 0.1799 ns | 0.1502 ns | 11.5060 ns |
|      ArrayLength |   10 |  0.0060 ns | 0.0120 ns | 0.0112 ns |  0.0000 ns |
|         **IEnumAny** |  **100** | **40.8559 ns** | **0.7013 ns** | **0.6560 ns** | **40.7089 ns** |
|   ICollectionAny |  100 | 16.1724 ns | 0.3423 ns | 0.4329 ns | 16.1189 ns |
| ICollectionCount |  100 |  1.5659 ns | 0.0159 ns | 0.0141 ns |  1.5654 ns |
|    CollectionAny |  100 | 17.1498 ns | 0.3680 ns | 0.4519 ns | 17.0036 ns |
|  CollectionCount |  100 |  1.5468 ns | 0.0132 ns | 0.0117 ns |  1.5470 ns |
|         IListAny |  100 | 15.2114 ns | 0.2989 ns | 0.2649 ns | 15.2383 ns |
|       IListCount |  100 |  1.5180 ns | 0.0090 ns | 0.0070 ns |  1.5175 ns |
|          ListAny |  100 | 15.7562 ns | 0.3290 ns | 0.2747 ns | 15.7154 ns |
|        ListCount |  100 |  0.0116 ns | 0.0129 ns | 0.0120 ns |  0.0144 ns |
|         ArrayAny |  100 | 11.9019 ns | 0.2543 ns | 0.3027 ns | 11.8230 ns |
|      ArrayLength |  100 |  0.0019 ns | 0.0044 ns | 0.0036 ns |  0.0001 ns |
|         **IEnumAny** | **1000** | **42.4432 ns** | **0.8588 ns** | **0.9889 ns** | **42.6030 ns** |
|   ICollectionAny | 1000 | 16.0147 ns | 0.3314 ns | 0.3403 ns | 15.9518 ns |
| ICollectionCount | 1000 |  1.5925 ns | 0.0243 ns | 0.0227 ns |  1.5897 ns |
|    CollectionAny | 1000 | 17.0185 ns | 0.3655 ns | 0.3910 ns | 16.8546 ns |
|  CollectionCount | 1000 |  1.3856 ns | 0.0442 ns | 0.0413 ns |  1.3718 ns |
|         IListAny | 1000 | 15.7248 ns | 0.3066 ns | 0.2868 ns | 15.7612 ns |
|       IListCount | 1000 |  1.5165 ns | 0.0166 ns | 0.0147 ns |  1.5144 ns |
|          ListAny | 1000 | 16.4612 ns | 0.3229 ns | 0.5569 ns | 16.2983 ns |
|        ListCount | 1000 |  0.0306 ns | 0.0190 ns | 0.0169 ns |  0.0301 ns |
|         ArrayAny | 1000 | 12.0297 ns | 0.1210 ns | 0.1132 ns | 12.0243 ns |
|      ArrayLength | 1000 |  0.0065 ns | 0.0080 ns | 0.0075 ns |  0.0057 ns |
