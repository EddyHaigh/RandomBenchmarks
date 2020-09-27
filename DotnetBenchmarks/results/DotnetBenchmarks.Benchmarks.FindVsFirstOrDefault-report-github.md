``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]        : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  .NET 4.7.2    : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 2.1 : .NET Core 2.1.21 (CoreCLR 4.6.29130.01, CoreFX 4.6.29130.02), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|                    Method |           Job |       Runtime | Size |      Mean |     Error |    StdDev |    Median |
|-------------------------- |-------------- |-------------- |----- |----------:|----------:|----------:|----------:|
|        **EnumFirstOrDefault** |    **.NET 4.7.2** |    **.NET 4.7.2** |   **10** | **59.833 ns** | **1.2371 ns** | **2.4128 ns** | **58.896 ns** |
| ICollectionFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |   10 | 27.282 ns | 0.2591 ns | 0.2423 ns | 27.260 ns |
|  CollectionFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |   10 | 30.112 ns | 0.6256 ns | 0.5852 ns | 30.066 ns |
|       IListFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |   10 | 28.269 ns | 0.6049 ns | 1.5287 ns | 27.503 ns |
|        ListFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |   10 | 27.293 ns | 0.3625 ns | 0.3213 ns | 27.259 ns |
|                  ListFind |    .NET 4.7.2 |    .NET 4.7.2 |   10 |  8.880 ns | 0.1631 ns | 0.1362 ns |  8.870 ns |
|       ArrayFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |   10 | 23.068 ns | 0.1883 ns | 0.1761 ns | 23.019 ns |
|                 ArrayFind |    .NET 4.7.2 |    .NET 4.7.2 |   10 |  8.965 ns | 0.0838 ns | 0.0700 ns |  8.958 ns |
|        EnumFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |   10 | 89.667 ns | 0.3237 ns | 0.2869 ns | 89.651 ns |
| ICollectionFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |   10 | 43.747 ns | 0.5372 ns | 0.4762 ns | 43.664 ns |
|  CollectionFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |   10 | 45.007 ns | 0.3519 ns | 0.2939 ns | 44.939 ns |
|       IListFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |   10 | 43.801 ns | 0.5157 ns | 0.4824 ns | 43.634 ns |
|        ListFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |   10 | 43.516 ns | 0.2134 ns | 0.1996 ns | 43.566 ns |
|                  ListFind | .NET Core 2.1 | .NET Core 2.1 |   10 | 16.038 ns | 0.2493 ns | 0.2210 ns | 16.033 ns |
|       ArrayFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |   10 | 36.232 ns | 0.3285 ns | 0.2743 ns | 36.141 ns |
|                 ArrayFind | .NET Core 2.1 | .NET Core 2.1 |   10 | 15.794 ns | 0.1279 ns | 0.1134 ns | 15.767 ns |
|        EnumFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |   10 | 58.436 ns | 0.9932 ns | 0.9291 ns | 58.361 ns |
| ICollectionFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |   10 | 32.126 ns | 0.2297 ns | 0.1918 ns | 32.090 ns |
|  CollectionFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |   10 | 34.019 ns | 0.3330 ns | 0.3115 ns | 33.986 ns |
|       IListFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |   10 | 31.952 ns | 0.3246 ns | 0.2877 ns | 31.891 ns |
|        ListFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |   10 | 33.149 ns | 0.3932 ns | 0.3485 ns | 33.095 ns |
|                  ListFind | .NET Core 3.1 | .NET Core 3.1 |   10 | 10.336 ns | 0.1342 ns | 0.1256 ns | 10.341 ns |
|       ArrayFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |   10 | 27.834 ns | 0.4479 ns | 0.4189 ns | 27.737 ns |
|                 ArrayFind | .NET Core 3.1 | .NET Core 3.1 |   10 | 10.236 ns | 0.1463 ns | 0.1297 ns | 10.216 ns |
|        **EnumFirstOrDefault** |    **.NET 4.7.2** |    **.NET 4.7.2** |  **100** | **58.190 ns** | **0.7227 ns** | **0.6760 ns** | **58.044 ns** |
| ICollectionFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |  100 | 27.376 ns | 0.2112 ns | 0.1976 ns | 27.389 ns |
|  CollectionFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |  100 | 29.323 ns | 0.1902 ns | 0.1686 ns | 29.323 ns |
|       IListFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |  100 | 27.450 ns | 0.2946 ns | 0.2755 ns | 27.469 ns |
|        ListFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |  100 | 27.523 ns | 0.3959 ns | 0.3091 ns | 27.486 ns |
|                  ListFind |    .NET 4.7.2 |    .NET 4.7.2 |  100 |  8.876 ns | 0.1476 ns | 0.1308 ns |  8.797 ns |
|       ArrayFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 |  100 | 23.214 ns | 0.1719 ns | 0.1608 ns | 23.228 ns |
|                 ArrayFind |    .NET 4.7.2 |    .NET 4.7.2 |  100 |  8.983 ns | 0.0676 ns | 0.0633 ns |  8.968 ns |
|        EnumFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |  100 | 88.601 ns | 0.9748 ns | 0.8641 ns | 88.197 ns |
| ICollectionFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |  100 | 43.780 ns | 0.3123 ns | 0.2768 ns | 43.770 ns |
|  CollectionFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |  100 | 45.693 ns | 0.2880 ns | 0.2405 ns | 45.806 ns |
|       IListFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |  100 | 44.549 ns | 0.7170 ns | 0.8805 ns | 44.180 ns |
|        ListFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |  100 | 44.069 ns | 0.4495 ns | 0.4205 ns | 43.965 ns |
|                  ListFind | .NET Core 2.1 | .NET Core 2.1 |  100 | 16.079 ns | 0.2244 ns | 0.1989 ns | 16.028 ns |
|       ArrayFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 |  100 | 36.536 ns | 0.2434 ns | 0.2158 ns | 36.509 ns |
|                 ArrayFind | .NET Core 2.1 | .NET Core 2.1 |  100 | 15.579 ns | 0.1264 ns | 0.1121 ns | 15.597 ns |
|        EnumFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |  100 | 57.282 ns | 0.5494 ns | 0.5139 ns | 57.369 ns |
| ICollectionFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |  100 | 32.256 ns | 0.6026 ns | 0.5342 ns | 32.369 ns |
|  CollectionFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |  100 | 33.394 ns | 0.3970 ns | 0.3714 ns | 33.269 ns |
|       IListFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |  100 | 31.760 ns | 0.3202 ns | 0.2995 ns | 31.795 ns |
|        ListFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |  100 | 31.851 ns | 0.3316 ns | 0.2940 ns | 31.758 ns |
|                  ListFind | .NET Core 3.1 | .NET Core 3.1 |  100 | 10.143 ns | 0.2237 ns | 0.2092 ns | 10.089 ns |
|       ArrayFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 |  100 | 27.275 ns | 0.2396 ns | 0.2241 ns | 27.309 ns |
|                 ArrayFind | .NET Core 3.1 | .NET Core 3.1 |  100 |  9.643 ns | 0.1105 ns | 0.1033 ns |  9.617 ns |
|        **EnumFirstOrDefault** |    **.NET 4.7.2** |    **.NET 4.7.2** | **1000** | **58.783 ns** | **0.7234 ns** | **0.6767 ns** | **58.651 ns** |
| ICollectionFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 | 1000 | 27.074 ns | 0.1934 ns | 0.1715 ns | 27.043 ns |
|  CollectionFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 | 1000 | 29.508 ns | 0.3386 ns | 0.3168 ns | 29.497 ns |
|       IListFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 | 1000 | 27.578 ns | 0.3773 ns | 0.3151 ns | 27.546 ns |
|        ListFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 | 1000 | 27.361 ns | 0.2178 ns | 0.2037 ns | 27.403 ns |
|                  ListFind |    .NET 4.7.2 |    .NET 4.7.2 | 1000 |  9.128 ns | 0.2142 ns | 0.3002 ns |  9.007 ns |
|       ArrayFirstOrDefault |    .NET 4.7.2 |    .NET 4.7.2 | 1000 | 23.076 ns | 0.1514 ns | 0.1416 ns | 23.057 ns |
|                 ArrayFind |    .NET 4.7.2 |    .NET 4.7.2 | 1000 |  8.976 ns | 0.1090 ns | 0.0851 ns |  8.967 ns |
|        EnumFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 | 1000 | 89.041 ns | 0.3841 ns | 0.3592 ns | 89.111 ns |
| ICollectionFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 | 1000 | 43.789 ns | 0.1752 ns | 0.1553 ns | 43.770 ns |
|  CollectionFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 | 1000 | 45.612 ns | 0.1831 ns | 0.1529 ns | 45.576 ns |
|       IListFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 | 1000 | 44.579 ns | 0.9226 ns | 0.9872 ns | 44.239 ns |
|        ListFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 | 1000 | 45.784 ns | 0.9687 ns | 1.3259 ns | 45.634 ns |
|                  ListFind | .NET Core 2.1 | .NET Core 2.1 | 1000 | 16.085 ns | 0.0935 ns | 0.0829 ns | 16.082 ns |
|       ArrayFirstOrDefault | .NET Core 2.1 | .NET Core 2.1 | 1000 | 36.476 ns | 0.2653 ns | 0.2215 ns | 36.477 ns |
|                 ArrayFind | .NET Core 2.1 | .NET Core 2.1 | 1000 | 15.895 ns | 0.1403 ns | 0.1171 ns | 15.912 ns |
|        EnumFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 | 1000 | 58.252 ns | 0.5239 ns | 0.4900 ns | 58.215 ns |
| ICollectionFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 | 1000 | 32.166 ns | 0.3681 ns | 0.3443 ns | 32.181 ns |
|  CollectionFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 | 1000 | 33.095 ns | 0.4255 ns | 0.3980 ns | 33.026 ns |
|       IListFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 | 1000 | 32.177 ns | 0.2873 ns | 0.2688 ns | 32.147 ns |
|        ListFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 | 1000 | 32.357 ns | 0.4839 ns | 0.4527 ns | 32.286 ns |
|                  ListFind | .NET Core 3.1 | .NET Core 3.1 | 1000 | 10.340 ns | 0.1019 ns | 0.0953 ns | 10.344 ns |
|       ArrayFirstOrDefault | .NET Core 3.1 | .NET Core 3.1 | 1000 | 27.124 ns | 0.3818 ns | 0.3572 ns | 27.136 ns |
|                 ArrayFind | .NET Core 3.1 | .NET Core 3.1 | 1000 |  9.810 ns | 0.1530 ns | 0.1431 ns |  9.846 ns |
