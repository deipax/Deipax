
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.864 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-KLVCBK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-PCVUGF : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-DFATGP : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


                   Method |     Toolchain |     Mean |    Error |   StdDev | Ratio | RatioSD |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
------------------------- |-------------- |---------:|---------:|---------:|------:|--------:|----------:|----------:|----------:|-----------:|
  AllFieldsAsClass_Deipax | .NET Core 2.0 | 38.78 ms | 0.262 ms | 0.245 ms |  1.00 |    0.00 | 2153.8462 | 1000.0000 |  153.8462 | 13573886 B |
  AllFieldsAsClass_Deipax | .NET Core 2.2 | 37.99 ms | 0.279 ms | 0.261 ms |  0.98 |    0.01 | 2142.8571 |  928.5714 |  142.8571 | 13573881 B |
  AllFieldsAsClass_Deipax | .NET Core 3.0 | 35.13 ms | 0.515 ms | 0.482 ms |  0.91 |    0.01 | 2066.6667 |  933.3333 |  200.0000 | 13166073 B |
  AllFieldsAsClass_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
  AllFieldsAsClass_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                          |               |          |          |          |       |         |           |           |           |            |
 AllFieldsAsStruct_Deipax | .NET Core 2.0 | 49.78 ms | 0.336 ms | 0.314 ms |  1.00 |    0.00 | 2818.1818 | 1909.0909 |  909.0909 | 16662413 B |
 AllFieldsAsStruct_Deipax | .NET Core 2.2 | 46.15 ms | 0.242 ms | 0.202 ms |  0.93 |    0.01 | 2818.1818 | 1909.0909 |  909.0909 | 16662761 B |
 AllFieldsAsStruct_Deipax | .NET Core 3.0 | 39.16 ms | 0.180 ms | 0.168 ms |  0.79 |    0.01 | 2846.1538 | 1923.0769 | 1000.0000 | 16255276 B |
 AllFieldsAsStruct_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
 AllFieldsAsStruct_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
                          |               |          |          |          |       |         |           |           |           |            |
       DynamicList_Deipax | .NET Core 2.0 | 42.08 ms | 0.237 ms | 0.222 ms |  1.00 |    0.00 | 2416.6667 | 1000.0000 |  416.6667 | 13808173 B |
       DynamicList_Deipax | .NET Core 2.2 | 40.99 ms | 0.500 ms | 0.468 ms |  0.97 |    0.01 | 2384.6154 | 1000.0000 |  384.6154 | 13807326 B |
       DynamicList_Deipax | .NET Core 3.0 | 37.05 ms | 0.394 ms | 0.369 ms |  0.88 |    0.01 | 2214.2857 |  928.5714 |  285.7143 | 13399682 B |
       DynamicList_Deipax |        net462 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Deipax |        net472 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |
       DynamicList_Deipax |         net48 |       NA |       NA |       NA |     ? |       ? |         - |         - |         - |          - |

Benchmarks with issues:
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-ASXZQV(Toolchain=net462)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-LPKDOL(Toolchain=net472)
  DeipaxSelect.AllFieldsAsClass_Deipax: Job-PFGKBT(Toolchain=net48)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-ASXZQV(Toolchain=net462)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-LPKDOL(Toolchain=net472)
  DeipaxSelect.AllFieldsAsStruct_Deipax: Job-PFGKBT(Toolchain=net48)
  DeipaxSelect.DynamicList_Deipax: Job-ASXZQV(Toolchain=net462)
  DeipaxSelect.DynamicList_Deipax: Job-LPKDOL(Toolchain=net472)
  DeipaxSelect.DynamicList_Deipax: Job-PFGKBT(Toolchain=net48)
