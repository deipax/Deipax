
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.7649 ns | 0.2956 ns | 0.0162 ns | 0.7699 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.6089 ns | 0.2855 ns | 0.0156 ns | 0.6143 ns |  0.80 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.0208 ns | 0.1299 ns | 0.0071 ns | 1.0177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 0.8208 ns | 1.3192 ns | 0.0723 ns | 0.7879 ns |  0.80 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.9744 ns | 0.1548 ns | 0.0085 ns | 0.9773 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.7500 ns | 0.1903 ns | 0.0104 ns | 0.7500 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 0.7680 ns | 0.2933 ns | 0.0161 ns | 0.7761 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 0.7514 ns | 1.2395 ns | 0.0679 ns | 0.7375 ns |  0.98 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 1.0074 ns | 0.3099 ns | 0.0170 ns | 1.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.7203 ns | 0.0994 ns | 0.0054 ns | 0.7215 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.3066 ns | 0.7417 ns | 0.0407 ns | 1.3008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.0007 ns | 0.4728 ns | 0.0259 ns | 0.9936 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.7659 ns | 0.2437 ns | 0.0134 ns | 0.7583 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.6638 ns | 0.4255 ns | 0.0233 ns | 0.6744 ns |  0.87 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.4841 ns | 3.2531 ns | 0.1783 ns | 1.5635 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.0571 ns | 0.9880 ns | 0.0542 ns | 1.0288 ns |  0.72 |    0.13 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.8176 ns | 0.2016 ns | 0.0110 ns | 0.8121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.7331 ns | 1.5661 ns | 0.0858 ns | 0.7264 ns |  0.90 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.2894 ns | 0.1211 ns | 0.0066 ns | 1.2880 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.1572 ns | 0.1479 ns | 0.0081 ns | 1.1589 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7486 ns | 0.0831 ns | 0.0046 ns | 0.7488 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.6834 ns | 0.5100 ns | 0.0280 ns | 0.6868 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.4801 ns | 3.3794 ns | 0.1852 ns | 1.5833 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.1448 ns | 0.2015 ns | 0.0110 ns | 1.1474 ns |  0.78 |    0.11 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 2.2139 ns | 0.2105 ns | 0.0115 ns | 2.2084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.7901 ns | 0.2172 ns | 0.0119 ns | 0.7963 ns |  0.36 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.8336 ns | 1.1483 ns | 0.0629 ns | 1.8070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.1516 ns | 0.1820 ns | 0.0100 ns | 1.1548 ns |  0.63 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.7901 ns | 0.2248 ns | 0.0123 ns | 0.7862 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.9382 ns | 2.4296 ns | 0.1332 ns | 0.8675 ns |  1.19 |    0.18 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.2198 ns | 0.2487 ns | 0.0136 ns | 1.2238 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.1754 ns | 1.0994 ns | 0.0603 ns | 1.1473 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 1.9300 ns | 1.5063 ns | 0.0826 ns | 1.8848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 1.7863 ns | 0.1582 ns | 0.0087 ns | 1.7861 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 2.1490 ns | 5.7063 ns | 0.3128 ns | 2.0370 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.9612 ns | 0.2766 ns | 0.0152 ns | 1.9659 ns |  0.92 |    0.13 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 1.7906 ns | 0.1601 ns | 0.0088 ns | 1.7901 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 1.8366 ns | 0.7020 ns | 0.0385 ns | 1.8451 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.8966 ns | 0.3764 ns | 0.0206 ns | 1.8933 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.8479 ns | 0.1147 ns | 0.0063 ns | 1.8496 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 0.7253 ns | 0.1591 ns | 0.0087 ns | 0.7289 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 1.1531 ns | 2.8357 ns | 0.1554 ns | 1.1164 ns |  1.59 |    0.20 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 0.8418 ns | 0.0857 ns | 0.0047 ns | 0.8391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 0.8042 ns | 0.7463 ns | 0.0409 ns | 0.7897 ns |  0.96 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 0.9951 ns | 3.5441 ns | 0.1943 ns | 0.9000 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 0.8040 ns | 0.0623 ns | 0.0034 ns | 0.8026 ns |  0.83 |    0.14 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 1.2070 ns | 0.1849 ns | 0.0101 ns | 1.2052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.5199 ns | 0.1195 ns | 0.0065 ns | 1.5172 ns |  1.26 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 1.2475 ns | 0.5860 ns | 0.0321 ns | 1.2374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 1.4270 ns | 4.1646 ns | 0.2283 ns | 1.2997 ns |  1.14 |    0.15 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 1.4803 ns | 0.4057 ns | 0.0222 ns | 1.4731 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 1.3593 ns | 0.0873 ns | 0.0048 ns | 1.3584 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.8069 ns | 0.3010 ns | 0.0165 ns | 0.7976 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7276 ns | 0.2670 ns | 0.0146 ns | 0.7246 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6574 ns | 1.4874 ns | 0.0815 ns | 1.6147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2765 ns | 0.2389 ns | 0.0131 ns | 1.2775 ns |  0.77 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.9682 ns | 1.9170 ns | 0.1051 ns | 2.9318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.8990 ns | 3.8638 ns | 0.2118 ns | 2.7918 ns |  0.98 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.8156 ns | 0.1453 ns | 0.0080 ns | 1.8135 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.8022 ns | 0.6817 ns | 0.0374 ns | 1.7817 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 1.9104 ns | 0.1781 ns | 0.0098 ns | 1.9159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.8374 ns | 0.1663 ns | 0.0091 ns | 0.8354 ns |  0.44 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 2.0151 ns | 3.6767 ns | 0.2015 ns | 1.9908 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.1566 ns | 0.3478 ns | 0.0191 ns | 1.1592 ns |  0.58 |    0.07 |     - |     - |     - |         - |
