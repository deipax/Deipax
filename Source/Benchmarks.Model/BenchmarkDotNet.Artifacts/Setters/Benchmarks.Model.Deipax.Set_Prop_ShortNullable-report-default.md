
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9969 ns | 0.2672 ns | 0.0146 ns |  1.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.7370 ns | 0.0359 ns | 0.0020 ns |  0.7380 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.0827 ns | 0.5008 ns | 0.0275 ns |  1.0952 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.5576 ns | 0.8802 ns | 0.0482 ns |  1.5374 ns |  1.44 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.6979 ns | 0.2312 ns | 0.0127 ns |  0.6991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7377 ns | 0.5563 ns | 0.0305 ns |  0.7322 ns |  1.06 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.3163 ns | 1.4251 ns | 0.0781 ns |  1.3527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2259 ns | 0.7179 ns | 0.0394 ns |  1.2165 ns |  0.93 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.4023 ns | 0.1035 ns | 0.0057 ns |  0.4009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.6901 ns | 0.1737 ns | 0.0095 ns |  0.6882 ns |  1.72 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0160 ns | 0.3631 ns | 0.0199 ns |  1.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1416 ns | 0.6403 ns | 0.0351 ns |  1.1273 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.5823 ns | 0.4671 ns | 0.0256 ns |  0.5753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6844 ns | 0.1221 ns | 0.0067 ns |  0.6873 ns |  1.18 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0470 ns | 0.6028 ns | 0.0330 ns |  1.0527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.1297 ns | 1.3421 ns | 0.0736 ns |  1.1161 ns |  1.08 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.5798 ns | 0.2676 ns | 0.0147 ns |  0.5799 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.6522 ns | 0.3450 ns | 0.0189 ns |  0.6552 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  0.7535 ns | 0.3922 ns | 0.0215 ns |  0.7594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  0.6381 ns | 0.3139 ns | 0.0172 ns |  0.6473 ns |  0.85 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.6782 ns | 0.2878 ns | 0.0158 ns |  0.6813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7314 ns | 0.7254 ns | 0.0398 ns |  0.7229 ns |  1.08 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.4350 ns | 1.6462 ns | 0.0902 ns |  1.3915 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2109 ns | 0.0953 ns | 0.0052 ns |  1.2136 ns |  0.85 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  2.2413 ns | 0.5965 ns | 0.0327 ns |  2.2276 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  2.0392 ns | 0.1073 ns | 0.0059 ns |  2.0400 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.4270 ns | 0.9650 ns | 0.0529 ns |  2.4366 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  2.4853 ns | 1.0908 ns | 0.0598 ns |  2.4824 ns |  1.02 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  1.8665 ns | 0.9925 ns | 0.0544 ns |  1.8644 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.8658 ns | 1.0838 ns | 0.0594 ns |  0.8848 ns |  0.46 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  2.5147 ns | 0.9175 ns | 0.0503 ns |  2.5041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2653 ns | 0.6121 ns | 0.0336 ns |  1.2665 ns |  0.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.8356 ns | 1.0430 ns | 0.0572 ns |  1.8058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.7914 ns | 0.3543 ns | 0.0194 ns |  1.7818 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.2104 ns | 1.6930 ns | 0.0928 ns |  3.2027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  3.0286 ns | 0.0603 ns | 0.0033 ns |  3.0293 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.7224 ns | 0.5919 ns | 0.0324 ns |  1.7090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.7360 ns | 0.0669 ns | 0.0037 ns |  1.7354 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.8420 ns | 1.3921 ns | 0.0763 ns |  2.8752 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  3.3153 ns | 0.6680 ns | 0.0366 ns |  3.3218 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.5583 ns | 3.9637 ns | 0.2173 ns |  4.6696 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  4.6645 ns | 1.1591 ns | 0.0635 ns |  4.6944 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.5901 ns | 1.9366 ns | 0.1062 ns |  4.5317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  4.5529 ns | 0.0480 ns | 0.0026 ns |  4.5520 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  4.4547 ns | 1.5853 ns | 0.0869 ns |  4.4512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  4.6281 ns | 1.6360 ns | 0.0897 ns |  4.5782 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.0790 ns | 0.0505 ns | 0.0028 ns |  5.0798 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  5.2726 ns | 1.5002 ns | 0.0822 ns |  5.2361 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  9.1814 ns | 2.7704 ns | 0.1519 ns |  9.2534 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  9.0497 ns | 0.3785 ns | 0.0207 ns |  9.0475 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 14.2963 ns | 3.1137 ns | 0.1707 ns | 14.3461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.6325 ns | 0.8990 ns | 0.0493 ns | 10.6099 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.6977 ns | 0.0615 ns | 0.0034 ns |  0.6962 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7475 ns | 0.3543 ns | 0.0194 ns |  0.7366 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5793 ns | 0.0950 ns | 0.0052 ns |  1.5771 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2223 ns | 0.6132 ns | 0.0336 ns |  1.2082 ns |  0.77 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.1804 ns | 2.9233 ns | 0.1602 ns | 12.0943 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.4946 ns | 5.2008 ns | 0.2851 ns | 11.3347 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.5313 ns | 6.2612 ns | 0.3432 ns |  9.5750 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.5224 ns | 8.5603 ns | 0.4692 ns |  8.5196 ns |  0.90 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.8708 ns | 1.6556 ns | 0.0907 ns |  1.8490 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  1.8940 ns | 0.8372 ns | 0.0459 ns |  1.9133 ns |  1.01 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.4888 ns | 2.9129 ns | 0.1597 ns |  2.5180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  2.4114 ns | 0.3516 ns | 0.0193 ns |  2.4099 ns |  0.97 |    0.07 |     - |     - |     - |         - |
