
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.0153 ns |  0.3008 ns | 0.0165 ns |  1.0233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.1864 ns |  0.2895 ns | 0.0159 ns |  1.1800 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.5252 ns |  0.6682 ns | 0.0366 ns |  1.5079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.5561 ns |  0.8593 ns | 0.0471 ns |  1.5820 ns |  1.02 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7653 ns |  0.3982 ns | 0.0218 ns |  0.7672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7544 ns |  0.2727 ns | 0.0149 ns |  0.7496 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.8784 ns |  0.6775 ns | 0.0371 ns |  0.8699 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.7969 ns |  0.3518 ns | 0.0193 ns |  0.8074 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.7925 ns |  0.6184 ns | 0.0339 ns |  0.7901 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.8117 ns |  0.2727 ns | 0.0149 ns |  0.8066 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.2079 ns |  1.2089 ns | 0.0663 ns |  1.2369 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.2187 ns |  0.0749 ns | 0.0041 ns |  1.2176 ns |  1.01 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7077 ns |  0.3778 ns | 0.0207 ns |  0.6989 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  1.0337 ns |  0.2448 ns | 0.0134 ns |  1.0312 ns |  1.46 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2830 ns |  0.5611 ns | 0.0308 ns |  1.3001 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.5015 ns |  0.7535 ns | 0.0413 ns |  1.4996 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.6948 ns |  0.1357 ns | 0.0074 ns |  0.6922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.9699 ns |  0.1152 ns | 0.0063 ns |  0.9715 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2797 ns |  0.7941 ns | 0.0435 ns |  1.2685 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.3496 ns |  0.2304 ns | 0.0126 ns |  1.3426 ns |  1.06 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.7988 ns |  1.0572 ns | 0.0580 ns |  0.7814 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7953 ns |  0.3625 ns | 0.0199 ns |  0.7844 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.3083 ns |  0.3370 ns | 0.0185 ns |  1.3077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.3254 ns |  0.7847 ns | 0.0430 ns |  1.3071 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.7695 ns |  0.1143 ns | 0.0063 ns |  0.7704 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.8620 ns |  0.8607 ns | 0.0472 ns |  0.8694 ns |  1.12 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.2614 ns |  0.6188 ns | 0.0339 ns |  1.2450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.3416 ns |  0.5557 ns | 0.0305 ns |  1.3257 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.9697 ns |  0.4647 ns | 0.0255 ns |  0.9611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.8323 ns |  0.3265 ns | 0.0179 ns |  0.8370 ns |  0.86 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2787 ns |  0.9336 ns | 0.0512 ns |  1.2828 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.3046 ns |  0.1364 ns | 0.0075 ns |  1.3039 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.9094 ns |  0.1933 ns | 0.0106 ns |  0.9155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.8788 ns |  0.1678 ns | 0.0092 ns |  0.8746 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.8600 ns |  0.5626 ns | 0.0308 ns |  1.8584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.9818 ns |  0.9559 ns | 0.0524 ns |  1.9594 ns |  1.07 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.9619 ns |  0.4785 ns | 0.0262 ns |  0.9549 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.0064 ns |  0.4463 ns | 0.0245 ns |  0.9960 ns |  1.05 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.0829 ns |  0.4766 ns | 0.0261 ns |  2.0694 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.9441 ns |  0.2488 ns | 0.0136 ns |  1.9442 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.7324 ns |  0.1488 ns | 0.0082 ns |  0.7368 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  0.8449 ns |  0.4298 ns | 0.0236 ns |  0.8378 ns |  1.15 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  1.2468 ns |  0.5850 ns | 0.0321 ns |  1.2428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  1.2331 ns |  0.8337 ns | 0.0457 ns |  1.2076 ns |  0.99 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  0.6814 ns |  0.2182 ns | 0.0120 ns |  0.6868 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.7810 ns |  0.5530 ns | 0.0303 ns |  0.7952 ns |  1.15 |    0.06 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.2834 ns |  0.9870 ns | 0.0541 ns |  1.2567 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.2212 ns |  0.0792 ns | 0.0043 ns |  1.2197 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.4778 ns |  1.3584 ns | 0.0745 ns |  5.4362 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  4.5427 ns |  1.4833 ns | 0.0813 ns |  4.4993 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 18.2070 ns |  1.6308 ns | 0.0894 ns | 18.1834 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  5.4887 ns |  1.1172 ns | 0.0612 ns |  5.4575 ns |  0.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.9228 ns |  0.1153 ns | 0.0063 ns |  0.9224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.8246 ns |  0.5314 ns | 0.0291 ns |  0.8129 ns |  0.89 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6884 ns |  1.5483 ns | 0.0849 ns |  1.7297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2333 ns |  0.4078 ns | 0.0224 ns |  1.2325 ns |  0.73 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.3199 ns |  0.1775 ns | 0.0097 ns | 12.3171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.8822 ns |  2.7254 ns | 0.1494 ns | 11.8141 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 46.5780 ns |  1.4246 ns | 0.0781 ns | 46.5829 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 42.4788 ns | 18.7215 ns | 1.0262 ns | 41.9056 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7308 ns |  0.0958 ns | 0.0053 ns |  0.7302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7847 ns |  0.0740 ns | 0.0041 ns |  0.7825 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.1784 ns |  0.2302 ns | 0.0126 ns |  1.1813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.3612 ns |  0.2369 ns | 0.0130 ns |  1.3537 ns |  1.16 |    0.01 |     - |     - |     - |         - |
