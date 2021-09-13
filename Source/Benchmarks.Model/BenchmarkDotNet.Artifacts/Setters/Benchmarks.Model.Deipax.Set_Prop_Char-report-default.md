
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.5409 ns | 0.2140 ns | 0.0117 ns | 0.5390 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.5009 ns | 0.4458 ns | 0.0244 ns | 0.5001 ns |  0.93 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 0.7852 ns | 0.2254 ns | 0.0124 ns | 0.7920 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 0.5423 ns | 0.0412 ns | 0.0023 ns | 0.5433 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.5244 ns | 0.0927 ns | 0.0051 ns | 0.5238 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.5556 ns | 0.2295 ns | 0.0126 ns | 0.5571 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.0191 ns | 0.5274 ns | 0.0289 ns | 1.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.0023 ns | 0.5094 ns | 0.0279 ns | 0.9963 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.5560 ns | 0.9927 ns | 0.0544 ns | 0.5395 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.5076 ns | 0.0542 ns | 0.0030 ns | 0.5079 ns |  0.92 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 0.8373 ns | 0.2207 ns | 0.0121 ns | 0.8359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.0872 ns | 1.4953 ns | 0.0820 ns | 1.0492 ns |  1.30 |    0.10 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.5583 ns | 0.1601 ns | 0.0088 ns | 0.5592 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.5352 ns | 0.0457 ns | 0.0025 ns | 0.5352 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0374 ns | 0.3675 ns | 0.0201 ns | 1.0263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.0251 ns | 0.0801 ns | 0.0044 ns | 1.0271 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.7692 ns | 0.1566 ns | 0.0086 ns | 0.7693 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.7393 ns | 0.0464 ns | 0.0025 ns | 0.7407 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.0588 ns | 0.0399 ns | 0.0022 ns | 1.0576 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.0778 ns | 0.5070 ns | 0.0278 ns | 1.0832 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.5503 ns | 0.1584 ns | 0.0087 ns | 0.5546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.5254 ns | 0.3614 ns | 0.0198 ns | 0.5273 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.1358 ns | 1.1961 ns | 0.0656 ns | 1.1027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 0.9215 ns | 0.6373 ns | 0.0349 ns | 0.9035 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 1.6213 ns | 0.0211 ns | 0.0012 ns | 1.6216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.5970 ns | 0.2109 ns | 0.0116 ns | 0.5982 ns |  0.37 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 2.2304 ns | 0.2743 ns | 0.0150 ns | 2.2306 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 0.9448 ns | 0.2341 ns | 0.0128 ns | 0.9506 ns |  0.42 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.5952 ns | 0.3462 ns | 0.0190 ns | 0.5857 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.7864 ns | 0.3556 ns | 0.0195 ns | 0.7871 ns |  1.32 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 0.9118 ns | 0.4015 ns | 0.0220 ns | 0.9005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2911 ns | 2.8399 ns | 0.1557 ns | 1.2584 ns |  1.41 |    0.14 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.6708 ns | 0.9426 ns | 0.0517 ns | 1.6946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 1.7730 ns | 0.2180 ns | 0.0120 ns | 1.7785 ns |  1.06 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 3.2023 ns | 0.2691 ns | 0.0147 ns | 3.1964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 2.9245 ns | 0.2587 ns | 0.0142 ns | 2.9286 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 1.5518 ns | 0.1132 ns | 0.0062 ns | 1.5536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 1.8530 ns | 0.3159 ns | 0.0173 ns | 1.8462 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 2.8306 ns | 0.3488 ns | 0.0191 ns | 2.8291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 3.1132 ns | 0.8258 ns | 0.0453 ns | 3.0926 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 0.7798 ns | 0.0627 ns | 0.0034 ns | 0.7811 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 0.9682 ns | 2.5444 ns | 0.1395 ns | 1.0252 ns |  1.24 |    0.18 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 0.7089 ns | 0.1746 ns | 0.0096 ns | 0.7129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 0.5382 ns | 0.1057 ns | 0.0058 ns | 0.5404 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 0.7656 ns | 0.0520 ns | 0.0029 ns | 0.7653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 0.7516 ns | 0.0997 ns | 0.0055 ns | 0.7487 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 1.3109 ns | 0.5707 ns | 0.0313 ns | 1.2983 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.2187 ns | 0.1782 ns | 0.0098 ns | 1.2232 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 1.2988 ns | 0.2510 ns | 0.0138 ns | 1.3039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 1.2439 ns | 0.1049 ns | 0.0058 ns | 1.2413 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 1.2875 ns | 0.2783 ns | 0.0153 ns | 1.2787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 1.2953 ns | 0.2781 ns | 0.0152 ns | 1.2946 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.5978 ns | 0.5046 ns | 0.0277 ns | 0.5834 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.5463 ns | 0.3050 ns | 0.0167 ns | 0.5458 ns |  0.92 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.3751 ns | 0.2577 ns | 0.0141 ns | 1.3800 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2611 ns | 0.2124 ns | 0.0116 ns | 1.2588 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.3936 ns | 1.6568 ns | 0.0908 ns | 2.3757 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.1408 ns | 0.4169 ns | 0.0228 ns | 2.1280 ns |  0.90 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 2.8097 ns | 0.2488 ns | 0.0136 ns | 2.8110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 3.0279 ns | 0.7964 ns | 0.0437 ns | 3.0406 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 1.6731 ns | 0.2222 ns | 0.0122 ns | 1.6702 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 1.0448 ns | 0.7800 ns | 0.0428 ns | 1.0206 ns |  0.62 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.9983 ns | 0.3305 ns | 0.0181 ns | 2.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.4095 ns | 2.1220 ns | 0.1163 ns | 1.3568 ns |  0.71 |    0.05 |     - |     - |     - |         - |
