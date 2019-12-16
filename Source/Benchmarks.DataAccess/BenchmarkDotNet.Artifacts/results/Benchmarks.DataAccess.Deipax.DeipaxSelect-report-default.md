
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.17763.914 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-OKOYOA : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), X64 RyuJIT
  Job-DFCQWD : .NET Core 2.2.7 (CoreCLR 4.6.28008.02, CoreFX 4.6.28008.03), X64 RyuJIT
  Job-IGAHNC : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


               Method | Platform |     Toolchain |      Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |--------- |-------------- |----------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
 CreateFromConnection |      X64 | .NET Core 2.0 | 194.24 ns | 1.625 ns | 1.520 ns |  1.00 |    0.00 | 0.0801 |     - |     - |     504 B |
 CreateFromConnection |      X64 | .NET Core 2.2 | 199.08 ns | 2.361 ns | 2.093 ns |  1.02 |    0.02 | 0.0799 |     - |     - |     504 B |
 CreateFromConnection |      X64 | .NET Core 3.0 | 196.75 ns | 1.479 ns | 1.383 ns |  1.01 |    0.01 | 0.0789 |     - |     - |     496 B |
 CreateFromConnection |      X64 |         net48 |        NA |       NA |       NA |     ? |       ? |      - |     - |     - |         - |
 CreateFromConnection |      X86 |        net462 |        NA |       NA |       NA |     ? |       ? |      - |     - |     - |         - |
 CreateFromConnection |      X86 |        net472 |        NA |       NA |       NA |     ? |       ? |      - |     - |     - |         - |
                      |          |               |           |          |          |       |         |        |       |       |           |
    CreateFromCommand |      X64 | .NET Core 2.0 |  10.30 ns | 0.075 ns | 0.067 ns |  1.00 |    0.00 | 0.0114 |     - |     - |      72 B |
    CreateFromCommand |      X64 | .NET Core 2.2 |  10.91 ns | 0.069 ns | 0.061 ns |  1.06 |    0.01 | 0.0114 |     - |     - |      72 B |
    CreateFromCommand |      X64 | .NET Core 3.0 |  10.04 ns | 0.094 ns | 0.083 ns |  0.97 |    0.01 | 0.0115 |     - |     - |      72 B |
    CreateFromCommand |      X64 |         net48 |        NA |       NA |       NA |     ? |       ? |      - |     - |     - |         - |
    CreateFromCommand |      X86 |        net462 |        NA |       NA |       NA |     ? |       ? |      - |     - |     - |         - |
    CreateFromCommand |      X86 |        net472 |        NA |       NA |       NA |     ? |       ? |      - |     - |     - |         - |

Benchmarks with issues:
  DeipaxSelect.CreateFromConnection: Job-FNGHBO(Toolchain=net48)
  DeipaxSelect.CreateFromConnection: Job-ZHRZEB(Platform=X86, Toolchain=net462)
  DeipaxSelect.CreateFromConnection: Job-YIKDJQ(Platform=X86, Toolchain=net472)
  DeipaxSelect.CreateFromCommand: Job-FNGHBO(Toolchain=net48)
  DeipaxSelect.CreateFromCommand: Job-ZHRZEB(Platform=X86, Toolchain=net462)
  DeipaxSelect.CreateFromCommand: Job-YIKDJQ(Platform=X86, Toolchain=net472)
