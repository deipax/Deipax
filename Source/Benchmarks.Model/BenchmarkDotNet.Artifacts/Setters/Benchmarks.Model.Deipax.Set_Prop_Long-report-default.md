
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.2351 ns | 1.4443 ns | 0.0792 ns |  1.2285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9267 ns | 0.2765 ns | 0.0152 ns |  0.9282 ns |  0.75 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.4841 ns | 0.7440 ns | 0.0408 ns |  1.4846 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  0.9866 ns | 0.3272 ns | 0.0179 ns |  0.9781 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5039 ns | 0.2919 ns | 0.0160 ns |  0.5032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.6970 ns | 0.1554 ns | 0.0085 ns |  0.6922 ns |  1.38 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.2171 ns | 0.6286 ns | 0.0345 ns |  1.2239 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.9153 ns | 0.8402 ns | 0.0461 ns |  0.9225 ns |  0.75 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.4482 ns | 0.5842 ns | 0.0320 ns |  0.4640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.4563 ns | 0.5631 ns | 0.0309 ns |  0.4400 ns |  1.02 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0159 ns | 0.4872 ns | 0.0267 ns |  1.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  0.8519 ns | 0.1895 ns | 0.0104 ns |  0.8487 ns |  0.84 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.4304 ns | 0.0500 ns | 0.0027 ns |  0.4316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.4390 ns | 0.0392 ns | 0.0021 ns |  0.4393 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0472 ns | 0.5267 ns | 0.0289 ns |  1.0608 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  0.8572 ns | 0.5635 ns | 0.0309 ns |  0.8487 ns |  0.82 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.5066 ns | 0.0411 ns | 0.0023 ns |  0.5065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.4657 ns | 0.2515 ns | 0.0138 ns |  0.4697 ns |  0.92 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.0224 ns | 0.9561 ns | 0.0524 ns |  0.9962 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  0.9093 ns | 0.0871 ns | 0.0048 ns |  0.9084 ns |  0.89 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.4408 ns | 0.3187 ns | 0.0175 ns |  0.4352 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.4705 ns | 0.2976 ns | 0.0163 ns |  0.4684 ns |  1.07 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  0.9446 ns | 0.0877 ns | 0.0048 ns |  0.9443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  0.9820 ns | 0.1994 ns | 0.0109 ns |  0.9788 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.5003 ns | 0.0285 ns | 0.0016 ns |  0.5005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.5031 ns | 0.1769 ns | 0.0097 ns |  0.5031 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.0287 ns | 0.4112 ns | 0.0225 ns |  1.0182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.0676 ns | 4.0355 ns | 0.2212 ns |  0.9702 ns |  1.04 |    0.23 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.5145 ns | 0.2667 ns | 0.0146 ns |  0.5225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.5446 ns | 0.9561 ns | 0.0524 ns |  0.5285 ns |  1.06 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.0056 ns | 0.3305 ns | 0.0181 ns |  1.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.9236 ns | 0.2826 ns | 0.0155 ns |  0.9186 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.7272 ns | 0.3287 ns | 0.0180 ns |  0.7171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.5005 ns | 0.4110 ns | 0.0225 ns |  0.5010 ns |  0.69 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.6872 ns | 1.5677 ns | 0.0859 ns |  1.6673 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.6017 ns | 0.3687 ns | 0.0202 ns |  1.5926 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.7618 ns | 0.0563 ns | 0.0031 ns |  0.7631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.5121 ns | 0.2086 ns | 0.0114 ns |  0.5107 ns |  0.67 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8280 ns | 0.8340 ns | 0.0457 ns |  1.8400 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.5449 ns | 0.8085 ns | 0.0443 ns |  1.5250 ns |  0.85 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  2.2526 ns | 0.3611 ns | 0.0198 ns |  2.2416 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  2.2642 ns | 1.1285 ns | 0.0619 ns |  2.2900 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  2.6209 ns | 0.2196 ns | 0.0120 ns |  2.6153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  2.3981 ns | 1.3597 ns | 0.0745 ns |  2.3707 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  2.2922 ns | 0.8225 ns | 0.0451 ns |  2.3113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  1.9456 ns | 1.4082 ns | 0.0772 ns |  1.9129 ns |  0.85 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.2525 ns | 0.4484 ns | 0.0246 ns |  3.2522 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.2936 ns | 1.2991 ns | 0.0712 ns |  3.2927 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.0151 ns | 1.5242 ns | 0.0835 ns |  6.0491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.0613 ns | 2.0283 ns | 0.1112 ns |  8.0694 ns |  1.34 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 12.6705 ns | 0.3107 ns | 0.0170 ns | 12.6746 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.1605 ns | 0.4474 ns | 0.0245 ns |  9.1735 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.5416 ns | 0.3171 ns | 0.0174 ns |  0.5496 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.5362 ns | 0.6533 ns | 0.0358 ns |  0.5209 ns |  0.99 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5717 ns | 0.8993 ns | 0.0493 ns |  1.5940 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2501 ns | 0.6148 ns | 0.0337 ns |  1.2600 ns |  0.80 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.2858 ns | 1.7350 ns | 0.0951 ns |  2.2315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0707 ns | 0.5584 ns | 0.0306 ns |  2.0729 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 11.3593 ns | 1.1962 ns | 0.0656 ns | 11.3611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  9.9283 ns | 8.5641 ns | 0.4694 ns | 10.0151 ns |  0.87 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7941 ns | 1.8240 ns | 0.1000 ns |  0.7617 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.5091 ns | 0.5015 ns | 0.0275 ns |  0.4971 ns |  0.65 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  0.9864 ns | 0.1546 ns | 0.0085 ns |  0.9838 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  0.9663 ns | 0.6101 ns | 0.0334 ns |  0.9823 ns |  0.98 |    0.03 |     - |     - |     - |         - |
