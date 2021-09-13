
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 4.200 ns | 1.1830 ns | 0.0648 ns | 4.223 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 5.0 | 4.252 ns | 1.6859 ns | 0.0924 ns | 4.257 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.384 ns | 6.9990 ns | 0.3836 ns | 1.190 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.110 ns | 0.2750 ns | 0.0151 ns | 1.104 ns |  0.84 |    0.21 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromChar | .NET Core 3.1 | 5.010 ns | 2.1990 ns | 0.1205 ns | 4.965 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 5.0 | 4.186 ns | 1.3350 ns | 0.0732 ns | 4.176 ns |  0.84 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.377 ns | 0.6687 ns | 0.0367 ns | 1.365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.363 ns | 0.1334 ns | 0.0073 ns | 1.362 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromSByte | .NET Core 3.1 | 4.155 ns | 0.9806 ns | 0.0537 ns | 4.158 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 5.0 | 4.170 ns | 0.3605 ns | 0.0198 ns | 4.169 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.123 ns | 0.3948 ns | 0.0216 ns | 1.115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.104 ns | 0.0413 ns | 0.0023 ns | 1.104 ns |  0.98 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromByte | .NET Core 3.1 | 4.102 ns | 0.4014 ns | 0.0220 ns | 4.095 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 5.0 | 4.212 ns | 1.2842 ns | 0.0704 ns | 4.229 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.123 ns | 0.2439 ns | 0.0134 ns | 1.120 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.250 ns | 0.6230 ns | 0.0342 ns | 1.234 ns |  1.11 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromShort | .NET Core 3.1 | 4.119 ns | 1.1618 ns | 0.0637 ns | 4.154 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 5.0 | 4.146 ns | 1.5603 ns | 0.0855 ns | 4.184 ns |  1.01 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.380 ns | 0.4626 ns | 0.0254 ns | 1.369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.329 ns | 0.2722 ns | 0.0149 ns | 1.329 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromUShort | .NET Core 3.1 | 4.172 ns | 2.8264 ns | 0.1549 ns | 4.086 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 5.0 | 4.200 ns | 1.5541 ns | 0.0852 ns | 4.222 ns |  1.01 |    0.04 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.642 ns | 2.9605 ns | 0.1623 ns | 1.734 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.348 ns | 0.0868 ns | 0.0048 ns | 1.348 ns |  0.83 |    0.08 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
              FromInt | .NET Core 3.1 | 4.239 ns | 0.4283 ns | 0.0235 ns | 4.246 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 5.0 | 4.365 ns | 2.2524 ns | 0.1235 ns | 4.299 ns |  1.03 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.374 ns | 0.3243 ns | 0.0178 ns | 1.366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.387 ns | 0.9327 ns | 0.0511 ns | 1.359 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromUInt | .NET Core 3.1 | 4.138 ns | 0.9151 ns | 0.0502 ns | 4.150 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 5.0 | 4.168 ns | 0.7931 ns | 0.0435 ns | 4.143 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.475 ns | 0.9487 ns | 0.0520 ns | 1.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.441 ns | 1.5301 ns | 0.0839 ns | 1.415 ns |  0.98 |    0.08 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromLong | .NET Core 3.1 | 4.368 ns | 4.9892 ns | 0.2735 ns | 4.332 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 5.0 | 4.225 ns | 2.2086 ns | 0.1211 ns | 4.206 ns |  0.97 |    0.05 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.777 ns | 0.1968 ns | 0.0108 ns | 1.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.801 ns | 0.8015 ns | 0.0439 ns | 1.780 ns |  1.01 |    0.03 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromULong | .NET Core 3.1 | 4.102 ns | 0.1863 ns | 0.0102 ns | 4.105 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 5.0 | 4.238 ns | 0.4302 ns | 0.0236 ns | 4.241 ns |  1.03 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.751 ns | 0.2152 ns | 0.0118 ns | 1.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.805 ns | 0.3804 ns | 0.0209 ns | 1.798 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromFloat | .NET Core 3.1 | 4.319 ns | 0.8871 ns | 0.0486 ns | 4.296 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 5.0 | 4.960 ns | 0.3949 ns | 0.0216 ns | 4.955 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.313 ns | 0.0434 ns | 0.0024 ns | 1.313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.317 ns | 0.1527 ns | 0.0084 ns | 1.313 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromDouble | .NET Core 3.1 | 4.351 ns | 2.0002 ns | 0.1096 ns | 4.345 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 5.0 | 4.630 ns | 5.5743 ns | 0.3055 ns | 4.778 ns |  1.06 |    0.05 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.141 ns | 2.3379 ns | 0.1281 ns | 2.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.705 ns | 0.4897 ns | 0.0268 ns | 1.696 ns |  0.80 |    0.04 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
          FromDecimal | .NET Core 3.1 | 5.473 ns | 1.0497 ns | 0.0575 ns | 5.504 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 5.0 | 5.570 ns | 0.6428 ns | 0.0352 ns | 5.558 ns |  1.02 |    0.01 | 0.0051 |     - |     - |      32 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.173 ns | 4.7141 ns | 0.2584 ns | 2.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 1.758 ns | 0.6949 ns | 0.0381 ns | 1.746 ns |  0.82 |    0.10 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
         FromDateTime | .NET Core 3.1 | 4.105 ns | 0.4904 ns | 0.0269 ns | 4.112 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 5.0 | 4.176 ns | 0.8433 ns | 0.0462 ns | 4.150 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.779 ns | 0.1204 ns | 0.0066 ns | 1.777 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.595 ns | 0.1284 ns | 0.0070 ns | 1.591 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromObject | .NET Core 3.1 | 1.467 ns | 0.2430 ns | 0.0133 ns | 1.468 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 1.877 ns | 0.1782 ns | 0.0098 ns | 1.873 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromString | .NET Core 3.1 | 1.664 ns | 1.1948 ns | 0.0655 ns | 1.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.687 ns | 0.1401 ns | 0.0077 ns | 1.690 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromEnum | .NET Core 3.1 | 4.110 ns | 0.5009 ns | 0.0275 ns | 4.103 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 5.0 | 4.268 ns | 2.1853 ns | 0.1198 ns | 4.305 ns |  1.04 |    0.04 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.387 ns | 0.3550 ns | 0.0195 ns | 1.378 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.375 ns | 0.5885 ns | 0.0323 ns | 1.360 ns |  0.99 |    0.01 |      - |     - |     - |         - |
