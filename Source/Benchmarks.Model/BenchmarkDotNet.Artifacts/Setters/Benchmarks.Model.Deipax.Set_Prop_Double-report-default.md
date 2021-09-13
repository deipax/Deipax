
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.0198 ns |  0.8620 ns | 0.0472 ns |  0.9976 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.7492 ns |  0.1784 ns | 0.0098 ns |  0.7544 ns |  0.74 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.3000 ns |  0.3011 ns | 0.0165 ns |  1.3028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.3007 ns |  1.5834 ns | 0.0868 ns |  1.3080 ns |  1.00 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5349 ns |  0.1729 ns | 0.0095 ns |  0.5359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7016 ns |  0.6751 ns | 0.0370 ns |  0.6908 ns |  1.31 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.1942 ns |  8.0062 ns | 0.4388 ns |  1.4433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.5207 ns |  0.3124 ns | 0.0171 ns |  0.5134 ns |  0.50 |    0.25 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9441 ns |  0.3502 ns | 0.0192 ns |  0.9348 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.5089 ns |  0.1249 ns | 0.0068 ns |  0.5085 ns |  0.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.1966 ns |  0.5896 ns | 0.0323 ns |  1.2085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1784 ns |  0.0645 ns | 0.0035 ns |  1.1790 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7754 ns |  0.8177 ns | 0.0448 ns |  0.7830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6826 ns |  0.4011 ns | 0.0220 ns |  0.6716 ns |  0.88 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2574 ns |  0.5621 ns | 0.0308 ns |  1.2539 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2337 ns |  0.8388 ns | 0.0460 ns |  1.2602 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.9337 ns |  0.9317 ns | 0.0511 ns |  0.9608 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.6933 ns |  0.1845 ns | 0.0101 ns |  0.6968 ns |  0.74 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2047 ns |  0.3991 ns | 0.0219 ns |  1.1964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2198 ns |  0.0274 ns | 0.0015 ns |  1.2189 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.8736 ns |  0.1379 ns | 0.0076 ns |  0.8762 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.5264 ns |  0.4420 ns | 0.0242 ns |  0.5154 ns |  0.60 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.1391 ns |  0.9502 ns | 0.0521 ns |  1.1167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.0611 ns |  0.3634 ns | 0.0199 ns |  1.0613 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.8773 ns |  0.0441 ns | 0.0024 ns |  0.8765 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7156 ns |  0.3521 ns | 0.0193 ns |  0.7182 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.0120 ns |  0.2998 ns | 0.0164 ns |  1.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2226 ns |  0.3823 ns | 0.0210 ns |  1.2248 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.7403 ns |  0.5388 ns | 0.0295 ns |  0.7263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.5890 ns |  0.5675 ns | 0.0311 ns |  0.5911 ns |  0.80 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  0.9328 ns |  0.3811 ns | 0.0209 ns |  0.9446 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.1191 ns |  1.0641 ns | 0.0583 ns |  1.1484 ns |  1.20 |    0.08 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.5216 ns |  0.2367 ns | 0.0130 ns |  0.5217 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.5518 ns |  0.1983 ns | 0.0109 ns |  0.5560 ns |  1.06 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.9228 ns |  0.7342 ns | 0.0402 ns |  1.9158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.7516 ns |  1.0291 ns | 0.0564 ns |  1.7467 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.9996 ns |  0.7444 ns | 0.0408 ns |  0.9974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.7539 ns |  0.6098 ns | 0.0334 ns |  0.7367 ns |  0.76 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8862 ns |  0.6571 ns | 0.0360 ns |  1.8928 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.9935 ns |  1.2373 ns | 0.0678 ns |  1.9782 ns |  1.06 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.6895 ns |  0.2090 ns | 0.0115 ns |  0.6857 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  0.5441 ns |  0.3322 ns | 0.0182 ns |  0.5380 ns |  0.79 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  0.8832 ns |  0.1032 ns | 0.0057 ns |  0.8850 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  0.9882 ns |  0.0733 ns | 0.0040 ns |  0.9883 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  0.6679 ns |  0.1655 ns | 0.0091 ns |  0.6659 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.7363 ns |  0.0246 ns | 0.0013 ns |  0.7360 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.8393 ns |  0.4053 ns | 0.0222 ns |  1.8310 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.5583 ns |  2.9814 ns | 0.1634 ns |  1.4711 ns |  0.85 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.7424 ns |  2.7540 ns | 0.1510 ns |  5.7325 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  3.9575 ns |  0.5668 ns | 0.0311 ns |  3.9529 ns |  0.69 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 17.3566 ns |  1.6588 ns | 0.0909 ns | 17.3219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  5.3545 ns |  0.4165 ns | 0.0228 ns |  5.3476 ns |  0.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.7551 ns |  0.4593 ns | 0.0252 ns |  0.7487 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.5417 ns |  0.3789 ns | 0.0208 ns |  0.5324 ns |  0.72 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.4967 ns |  0.5139 ns | 0.0282 ns |  1.5016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2094 ns |  0.3418 ns | 0.0187 ns |  1.2050 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.2256 ns |  0.4127 ns | 0.0226 ns |  2.2130 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0499 ns |  0.6368 ns | 0.0349 ns |  2.0331 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 48.5135 ns | 33.4465 ns | 1.8333 ns | 47.9345 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 41.1739 ns |  6.9925 ns | 0.3833 ns | 41.0087 ns |  0.85 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7090 ns |  0.0383 ns | 0.0021 ns |  0.7097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7592 ns |  1.1261 ns | 0.0617 ns |  0.7268 ns |  1.07 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  0.9767 ns |  0.7972 ns | 0.0437 ns |  0.9935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.0069 ns |  1.0477 ns | 0.0574 ns |  0.9901 ns |  1.03 |    0.07 |     - |     - |     - |         - |
