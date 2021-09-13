
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.1532 ns | 0.4594 ns | 0.0252 ns |  1.1611 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.2361 ns | 1.6594 ns | 0.0910 ns |  1.1956 ns |  1.07 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.1975 ns | 0.1949 ns | 0.0107 ns |  1.1921 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.5195 ns | 1.0037 ns | 0.0550 ns |  1.5058 ns |  1.27 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7063 ns | 0.4578 ns | 0.0251 ns |  0.6989 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7713 ns | 0.7393 ns | 0.0405 ns |  0.7528 ns |  1.09 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.2138 ns | 0.3112 ns | 0.0171 ns |  1.2194 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.2538 ns | 0.2445 ns | 0.0134 ns |  1.2590 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.6877 ns | 0.2173 ns | 0.0119 ns |  0.6907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.8275 ns | 1.8389 ns | 0.1008 ns |  0.7730 ns |  1.20 |    0.14 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.3241 ns | 0.6194 ns | 0.0339 ns |  1.3081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0406 ns | 0.3281 ns | 0.0180 ns |  1.0333 ns |  0.79 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.6682 ns | 0.1048 ns | 0.0057 ns |  0.6681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7255 ns | 0.1041 ns | 0.0057 ns |  0.7256 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0859 ns | 0.6408 ns | 0.0351 ns |  1.0660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  0.8469 ns | 0.3929 ns | 0.0215 ns |  0.8360 ns |  0.78 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  1.7224 ns | 0.3583 ns | 0.0196 ns |  1.7212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.9525 ns | 0.0292 ns | 0.0016 ns |  0.9525 ns |  0.55 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  2.4781 ns | 0.0486 ns | 0.0027 ns |  2.4771 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.0321 ns | 0.0180 ns | 0.0010 ns |  1.0317 ns |  0.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  1.0073 ns | 5.4825 ns | 0.3005 ns |  1.1737 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.5346 ns | 0.4140 ns | 0.0227 ns |  0.5368 ns |  0.57 |    0.21 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.1745 ns | 0.4165 ns | 0.0228 ns |  1.1746 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.0579 ns | 0.0369 ns | 0.0020 ns |  1.0590 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  1.7186 ns | 3.0243 ns | 0.1658 ns |  1.6249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.9574 ns | 0.1783 ns | 0.0098 ns |  0.9558 ns |  0.56 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.9375 ns | 1.1574 ns | 0.0634 ns |  1.9158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  0.9161 ns | 0.1534 ns | 0.0084 ns |  0.9204 ns |  0.47 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.9594 ns | 0.0637 ns | 0.0035 ns |  0.9574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7585 ns | 0.2032 ns | 0.0111 ns |  0.7550 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2325 ns | 0.5251 ns | 0.0288 ns |  1.2225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2215 ns | 3.4374 ns | 0.1884 ns |  1.1362 ns |  0.99 |    0.13 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  2.0530 ns | 0.3361 ns | 0.0184 ns |  2.0442 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.7412 ns | 0.4806 ns | 0.0263 ns |  1.7489 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.5015 ns | 1.0863 ns | 0.0595 ns |  3.4723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.7345 ns | 0.9988 ns | 0.0547 ns |  2.7236 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  2.0422 ns | 0.5424 ns | 0.0297 ns |  2.0468 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.9313 ns | 0.4759 ns | 0.0261 ns |  1.9414 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.9225 ns | 0.2980 ns | 0.0163 ns |  2.9240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  3.0072 ns | 0.5556 ns | 0.0305 ns |  2.9906 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.0379 ns | 1.9345 ns | 0.1060 ns |  4.0548 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.7050 ns | 1.2613 ns | 0.0691 ns |  3.6924 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.4791 ns | 1.9569 ns | 0.1073 ns |  4.4808 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.7503 ns | 6.1262 ns | 0.3358 ns |  3.6847 ns |  0.84 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  3.8994 ns | 0.1896 ns | 0.0104 ns |  3.9030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  3.0347 ns | 1.3151 ns | 0.0721 ns |  2.9942 ns |  0.78 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.3359 ns | 2.3764 ns | 0.1303 ns |  5.2659 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.7986 ns | 1.1045 ns | 0.0605 ns |  3.7689 ns |  0.71 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  7.1040 ns | 0.8637 ns | 0.0473 ns |  7.0831 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.8834 ns | 2.2994 ns | 0.1260 ns |  8.9484 ns |  1.25 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.0420 ns | 2.0243 ns | 0.1110 ns | 13.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.0303 ns | 1.5854 ns | 0.0869 ns | 10.0076 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.7371 ns | 0.2799 ns | 0.0153 ns |  0.7289 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.6889 ns | 0.1256 ns | 0.0069 ns |  0.6872 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.4377 ns | 0.4063 ns | 0.0223 ns |  1.4348 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2175 ns | 0.4103 ns | 0.0225 ns |  1.2199 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.1836 ns | 1.0561 ns | 0.0579 ns |  2.1517 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.1011 ns | 0.3290 ns | 0.0180 ns |  2.0916 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.1315 ns | 1.1736 ns | 0.0643 ns |  9.1596 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.4441 ns | 2.8067 ns | 0.1538 ns |  8.4412 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.9073 ns | 0.7995 ns | 0.0438 ns |  1.8838 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7172 ns | 0.1813 ns | 0.0099 ns |  0.7132 ns |  0.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.2465 ns | 0.9527 ns | 0.0522 ns |  2.2188 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2299 ns | 0.6851 ns | 0.0376 ns |  1.2083 ns |  0.55 |    0.03 |     - |     - |     - |         - |
