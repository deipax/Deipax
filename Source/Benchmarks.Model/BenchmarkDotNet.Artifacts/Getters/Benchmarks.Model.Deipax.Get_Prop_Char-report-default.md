
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.2100 ns | 0.4236 ns | 0.0232 ns |  1.2125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  0.9305 ns | 0.1334 ns | 0.0073 ns |  0.9328 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.3199 ns | 5.9360 ns | 0.3254 ns |  4.3965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7544 ns | 0.3747 ns | 0.0205 ns |  3.7485 ns |  0.87 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.1539 ns | 0.3894 ns | 0.0213 ns |  1.1520 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  0.9115 ns | 0.5340 ns | 0.0293 ns |  0.8961 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.2183 ns | 0.5882 ns | 0.0322 ns |  4.2065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.5727 ns | 0.4845 ns | 0.0266 ns |  3.5624 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.2025 ns | 0.6729 ns | 0.0369 ns |  1.2191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.0074 ns | 0.9001 ns | 0.0493 ns |  0.9935 ns |  0.84 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  3.9925 ns | 0.2605 ns | 0.0143 ns |  3.9964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.0789 ns | 4.9976 ns | 0.2739 ns |  4.0001 ns |  1.02 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.4177 ns | 0.8116 ns | 0.0445 ns |  1.4289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.0336 ns | 0.2160 ns | 0.0118 ns |  1.0287 ns |  0.73 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  3.9717 ns | 0.4390 ns | 0.0241 ns |  3.9825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.7608 ns | 0.2586 ns | 0.0142 ns |  3.7594 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.4141 ns | 0.7698 ns | 0.0422 ns |  1.3942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.0233 ns | 0.0470 ns | 0.0026 ns |  1.0246 ns |  0.72 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.0007 ns | 0.1575 ns | 0.0086 ns |  3.9984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.7824 ns | 0.4703 ns | 0.0258 ns |  3.7791 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.1322 ns | 0.5666 ns | 0.0311 ns |  1.1178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  0.9512 ns | 0.3288 ns | 0.0180 ns |  0.9413 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  3.9988 ns | 0.2587 ns | 0.0142 ns |  4.0028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.7448 ns | 0.6161 ns | 0.0338 ns |  3.7498 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.1101 ns | 0.0499 ns | 0.0027 ns |  1.1098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  0.9162 ns | 0.3584 ns | 0.0196 ns |  0.9137 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.9859 ns | 0.3748 ns | 0.0205 ns |  3.9825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.7658 ns | 0.1754 ns | 0.0096 ns |  3.7661 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.1445 ns | 0.4950 ns | 0.0271 ns |  1.1316 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  0.9245 ns | 0.1362 ns | 0.0075 ns |  0.9215 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.9691 ns | 0.4507 ns | 0.0247 ns |  3.9583 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.7549 ns | 0.2365 ns | 0.0130 ns |  3.7611 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.2032 ns | 0.6189 ns | 0.0339 ns |  1.2010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  0.9338 ns | 0.2404 ns | 0.0132 ns |  0.9407 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.7113 ns | 0.3482 ns | 0.0191 ns |  1.7118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.8583 ns | 0.2311 ns | 0.0127 ns |  1.8635 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.1149 ns | 0.0555 ns | 0.0030 ns |  1.1133 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  0.9175 ns | 0.4832 ns | 0.0265 ns |  0.9077 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.8861 ns | 0.0500 ns | 0.0027 ns |  1.8859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.5997 ns | 0.0772 ns | 0.0042 ns |  1.6011 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.1402 ns | 0.0461 ns | 0.0025 ns |  1.1402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  0.9435 ns | 0.3343 ns | 0.0183 ns |  0.9378 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  3.9809 ns | 0.3550 ns | 0.0195 ns |  3.9903 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  3.7977 ns | 0.7016 ns | 0.0385 ns |  3.7868 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.1952 ns | 0.3174 ns | 0.0174 ns |  1.1854 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  0.9967 ns | 0.4897 ns | 0.0268 ns |  0.9925 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.7240 ns | 0.7876 ns | 0.0432 ns |  1.7434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.6402 ns | 0.2352 ns | 0.0129 ns |  1.6449 ns |  0.95 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.5132 ns | 0.1032 ns | 0.0057 ns |  6.5136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.6507 ns | 0.2431 ns | 0.0133 ns |  2.6532 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  1.8860 ns | 0.0283 ns | 0.0016 ns |  1.8869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  1.5336 ns | 0.5785 ns | 0.0317 ns |  1.5209 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.1548 ns | 0.1683 ns | 0.0092 ns |  2.1540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1249 ns | 0.0180 ns | 0.0010 ns |  2.1245 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0441 ns | 0.5552 ns | 0.0304 ns |  2.0358 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.9388 ns | 2.0810 ns | 0.1141 ns |  1.9345 ns |  0.95 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.7025 ns | 1.4507 ns | 0.0795 ns |  3.6573 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.6206 ns | 0.5064 ns | 0.0278 ns |  3.6243 ns |  0.98 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 |  3.8582 ns | 2.0222 ns | 0.1108 ns |  3.8052 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 |  3.9395 ns | 1.4836 ns | 0.0813 ns |  3.9057 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.4129 ns | 1.1897 ns | 0.0652 ns |  8.4419 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.7211 ns | 0.3723 ns | 0.0204 ns |  7.7259 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.6963 ns | 0.4063 ns | 0.0223 ns | 12.6919 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.6415 ns | 0.1037 ns | 0.0057 ns | 11.6436 ns |  0.92 |    0.00 |      - |     - |     - |         - |
