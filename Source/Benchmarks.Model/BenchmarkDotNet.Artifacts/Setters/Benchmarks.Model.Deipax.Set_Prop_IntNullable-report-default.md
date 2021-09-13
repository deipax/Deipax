
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.7765 ns | 0.2271 ns | 0.0124 ns |  0.7725 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9534 ns | 0.5809 ns | 0.0318 ns |  0.9675 ns |  1.23 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.1120 ns | 0.1529 ns | 0.0084 ns |  1.1125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.7599 ns | 2.1214 ns | 0.1163 ns |  1.7014 ns |  1.58 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5864 ns | 0.0407 ns | 0.0022 ns |  0.5865 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.9170 ns | 0.0883 ns | 0.0048 ns |  0.9167 ns |  1.56 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.1836 ns | 1.1018 ns | 0.0604 ns |  1.1638 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2319 ns | 0.0342 ns | 0.0019 ns |  1.2324 ns |  1.04 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.7289 ns | 0.5614 ns | 0.0308 ns |  0.7461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7386 ns | 0.3297 ns | 0.0181 ns |  0.7408 ns |  1.02 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.1688 ns | 0.0747 ns | 0.0041 ns |  1.1706 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0428 ns | 0.2066 ns | 0.0113 ns |  1.0492 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.6585 ns | 0.3278 ns | 0.0180 ns |  0.6507 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7237 ns | 0.4479 ns | 0.0245 ns |  0.7180 ns |  1.10 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.1424 ns | 0.4941 ns | 0.0271 ns |  1.1318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2169 ns | 0.2546 ns | 0.0140 ns |  1.2246 ns |  1.07 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.8692 ns | 0.5191 ns | 0.0285 ns |  0.8565 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7233 ns | 0.1885 ns | 0.0103 ns |  0.7260 ns |  0.83 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.1701 ns | 0.7638 ns | 0.0419 ns |  1.1499 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2576 ns | 0.2842 ns | 0.0156 ns |  1.2523 ns |  1.08 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.6450 ns | 0.5228 ns | 0.0287 ns |  0.6340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.9396 ns | 0.2739 ns | 0.0150 ns |  0.9473 ns |  1.46 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.0824 ns | 0.1828 ns | 0.0100 ns |  1.0858 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2411 ns | 0.1862 ns | 0.0102 ns |  1.2383 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.6805 ns | 0.2947 ns | 0.0162 ns |  0.6723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.9421 ns | 0.3263 ns | 0.0179 ns |  0.9331 ns |  1.39 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  0.5679 ns | 0.2046 ns | 0.0112 ns |  0.5670 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  0.6961 ns | 0.4269 ns | 0.0234 ns |  0.6890 ns |  1.23 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.9316 ns | 0.6793 ns | 0.0372 ns |  0.9242 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7974 ns | 0.2483 ns | 0.0136 ns |  0.7902 ns |  0.86 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2042 ns | 0.7070 ns | 0.0388 ns |  1.1867 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2860 ns | 1.4406 ns | 0.0790 ns |  1.2606 ns |  1.07 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.9187 ns | 0.7966 ns | 0.0437 ns |  1.9439 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.7077 ns | 0.1895 ns | 0.0104 ns |  1.7049 ns |  0.89 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.0216 ns | 1.0384 ns | 0.0569 ns |  3.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.7941 ns | 0.3761 ns | 0.0206 ns |  2.8060 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.7069 ns | 0.9107 ns | 0.0499 ns |  1.7069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.7974 ns | 0.9791 ns | 0.0537 ns |  1.7793 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  3.0235 ns | 1.2415 ns | 0.0681 ns |  2.9889 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  3.1655 ns | 3.6629 ns | 0.2008 ns |  3.0983 ns |  1.05 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  3.5333 ns | 1.2538 ns | 0.0687 ns |  3.4938 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.5524 ns | 0.0235 ns | 0.0013 ns |  3.5522 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  3.7135 ns | 1.1922 ns | 0.0653 ns |  3.7219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.7783 ns | 1.6426 ns | 0.0900 ns |  3.7820 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  3.6785 ns | 0.8919 ns | 0.0489 ns |  3.6829 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  2.9858 ns | 0.3415 ns | 0.0187 ns |  2.9918 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.9521 ns | 1.1037 ns | 0.0605 ns |  3.9396 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  4.1010 ns | 0.1274 ns | 0.0070 ns |  4.1022 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.4588 ns | 3.9385 ns | 0.2159 ns |  6.5277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.4962 ns | 1.8802 ns | 0.1031 ns |  8.4470 ns |  1.32 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.9273 ns | 1.4453 ns | 0.0792 ns | 13.9246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.9493 ns | 2.6711 ns | 0.1464 ns | 10.0233 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.6994 ns | 0.4500 ns | 0.0247 ns |  0.6990 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7338 ns | 0.2647 ns | 0.0145 ns |  0.7298 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6460 ns | 0.5930 ns | 0.0325 ns |  1.6575 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2460 ns | 0.2070 ns | 0.0113 ns |  1.2410 ns |  0.76 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.6978 ns | 0.5897 ns | 0.0323 ns | 12.6852 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.8179 ns | 1.1015 ns | 0.0604 ns | 11.8156 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 11.1064 ns | 6.8359 ns | 0.3747 ns | 11.1573 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 10.0867 ns | 0.5776 ns | 0.0317 ns | 10.0985 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.6936 ns | 0.3971 ns | 0.0218 ns |  0.6821 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.6983 ns | 0.1071 ns | 0.0059 ns |  0.6968 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.1466 ns | 0.0660 ns | 0.0036 ns |  1.1486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.1619 ns | 0.4964 ns | 0.0272 ns |  1.1571 ns |  1.01 |    0.03 |     - |     - |     - |         - |
