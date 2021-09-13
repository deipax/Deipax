
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  1.2671 ns | 1.5009 ns | 0.0823 ns |  1.2574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.1519 ns | 0.4852 ns | 0.0266 ns |  1.1372 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.4648 ns | 0.6579 ns | 0.0361 ns |  1.4444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.1812 ns | 0.2133 ns | 0.0117 ns |  1.1842 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.6970 ns | 0.2648 ns | 0.0145 ns |  0.6899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.4734 ns | 0.3482 ns | 0.0191 ns |  0.4828 ns |  0.68 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.3205 ns | 3.7700 ns | 0.2066 ns |  1.2146 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.9813 ns | 0.2372 ns | 0.0130 ns |  0.9771 ns |  0.75 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.6856 ns | 0.0339 ns | 0.0019 ns |  0.6862 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.4466 ns | 0.1565 ns | 0.0086 ns |  0.4443 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.1988 ns | 0.3106 ns | 0.0170 ns |  1.2054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1947 ns | 0.1271 ns | 0.0070 ns |  1.1924 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7174 ns | 0.2942 ns | 0.0161 ns |  0.7087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6911 ns | 0.1568 ns | 0.0086 ns |  0.6884 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2018 ns | 0.1489 ns | 0.0082 ns |  1.1983 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.1965 ns | 0.1347 ns | 0.0074 ns |  1.1936 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7424 ns | 0.2889 ns | 0.0158 ns |  0.7485 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.4716 ns | 0.2640 ns | 0.0145 ns |  0.4654 ns |  0.64 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2031 ns | 0.5684 ns | 0.0312 ns |  1.1879 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2201 ns | 0.4917 ns | 0.0269 ns |  1.2094 ns |  1.01 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.6933 ns | 0.4921 ns | 0.0270 ns |  0.6864 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.5141 ns | 0.3954 ns | 0.0217 ns |  0.5225 ns |  0.74 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2096 ns | 0.6664 ns | 0.0365 ns |  1.1890 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  0.9702 ns | 0.0085 ns | 0.0005 ns |  0.9702 ns |  0.80 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.5647 ns | 0.8691 ns | 0.0476 ns |  0.5833 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.4896 ns | 0.1716 ns | 0.0094 ns |  0.4921 ns |  0.87 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  0.9713 ns | 0.2547 ns | 0.0140 ns |  0.9643 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  0.9428 ns | 0.0869 ns | 0.0048 ns |  0.9424 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.5207 ns | 0.1179 ns | 0.0065 ns |  0.5179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.4920 ns | 0.0584 ns | 0.0032 ns |  0.4938 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  0.9336 ns | 1.5203 ns | 0.0833 ns |  0.8907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  0.9190 ns | 0.3834 ns | 0.0210 ns |  0.9078 ns |  0.99 |    0.10 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.6202 ns | 0.1964 ns | 0.0108 ns |  1.6210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.6427 ns | 1.8569 ns | 0.1018 ns |  1.5847 ns |  1.01 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  2.6605 ns | 1.3707 ns | 0.0751 ns |  2.7030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.7354 ns | 1.0733 ns | 0.0588 ns |  2.7175 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.4973 ns | 0.3525 ns | 0.0193 ns |  1.4864 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.4754 ns | 0.4620 ns | 0.0253 ns |  1.4713 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.8308 ns | 1.0481 ns | 0.0575 ns |  2.8526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  3.0699 ns | 0.0452 ns | 0.0025 ns |  3.0686 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  3.7224 ns | 0.8014 ns | 0.0439 ns |  3.7174 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.5199 ns | 0.0803 ns | 0.0044 ns |  3.5174 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  3.4663 ns | 3.5610 ns | 0.1952 ns |  3.3820 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.4135 ns | 1.2785 ns | 0.0701 ns |  3.4537 ns |  0.99 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  2.9843 ns | 0.1155 ns | 0.0063 ns |  2.9809 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  3.0007 ns | 0.7963 ns | 0.0436 ns |  3.0092 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.7947 ns | 1.1472 ns | 0.0629 ns |  3.7703 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.7221 ns | 0.2917 ns | 0.0160 ns |  3.7186 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.0423 ns | 0.5364 ns | 0.0294 ns |  6.0489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.2429 ns | 2.2879 ns | 0.1254 ns |  8.1806 ns |  1.36 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 12.4058 ns | 0.5037 ns | 0.0276 ns | 12.3979 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.4247 ns | 1.3563 ns | 0.0743 ns |  9.3824 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.8322 ns | 3.5081 ns | 0.1923 ns |  0.9394 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.4805 ns | 0.3100 ns | 0.0170 ns |  0.4716 ns |  0.60 |    0.15 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.3203 ns | 0.1218 ns | 0.0067 ns |  1.3185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2428 ns | 0.8401 ns | 0.0460 ns |  1.2561 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.2088 ns | 0.5280 ns | 0.0289 ns |  2.1935 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0240 ns | 0.9652 ns | 0.0529 ns |  2.0504 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 10.3320 ns | 0.9477 ns | 0.0519 ns | 10.3225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 10.3062 ns | 2.0388 ns | 0.1118 ns | 10.3482 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.4377 ns | 0.1355 ns | 0.0074 ns |  0.4361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.4838 ns | 0.2843 ns | 0.0156 ns |  0.4916 ns |  1.11 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.0118 ns | 0.4139 ns | 0.0227 ns |  0.9996 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.0036 ns | 0.3062 ns | 0.0168 ns |  0.9953 ns |  0.99 |    0.03 |     - |     - |     - |         - |
