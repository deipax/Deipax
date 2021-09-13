
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.0411 ns | 0.1649 ns | 0.0090 ns |  1.0395 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  0.9924 ns | 0.8359 ns | 0.0458 ns |  1.0153 ns |  0.95 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.9807 ns | 0.4858 ns | 0.0266 ns |  3.9955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7479 ns | 0.5433 ns | 0.0298 ns |  3.7616 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.1954 ns | 0.1498 ns | 0.0082 ns |  1.2000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  0.9316 ns | 0.4964 ns | 0.0272 ns |  0.9417 ns |  0.78 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.0068 ns | 0.3765 ns | 0.0206 ns |  3.9980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.7766 ns | 0.3869 ns | 0.0212 ns |  3.7716 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.2449 ns | 0.3454 ns | 0.0189 ns |  1.2394 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  0.9985 ns | 0.0579 ns | 0.0032 ns |  0.9975 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  3.9905 ns | 0.3495 ns | 0.0192 ns |  3.9805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.7456 ns | 0.1232 ns | 0.0068 ns |  3.7485 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.3069 ns | 1.9325 ns | 0.1059 ns |  1.3382 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  0.9570 ns | 0.5245 ns | 0.0288 ns |  0.9466 ns |  0.74 |    0.08 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.2364 ns | 0.3628 ns | 0.0199 ns |  4.2469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.5232 ns | 0.0901 ns | 0.0049 ns |  3.5231 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.1917 ns | 1.1032 ns | 0.0605 ns |  1.1581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  0.9166 ns | 0.2050 ns | 0.0112 ns |  0.9108 ns |  0.77 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  3.9877 ns | 0.2866 ns | 0.0157 ns |  3.9901 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.7402 ns | 0.2668 ns | 0.0146 ns |  3.7454 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.1862 ns | 0.1975 ns | 0.0108 ns |  1.1837 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  0.9456 ns | 0.9043 ns | 0.0496 ns |  0.9348 ns |  0.80 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.0057 ns | 0.1105 ns | 0.0061 ns |  4.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.7637 ns | 0.1559 ns | 0.0085 ns |  3.7658 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.2366 ns | 0.8934 ns | 0.0490 ns |  1.2550 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  0.9206 ns | 0.4365 ns | 0.0239 ns |  0.9257 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.3881 ns | 8.4241 ns | 0.4618 ns |  4.2432 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.7601 ns | 0.7969 ns | 0.0437 ns |  3.7609 ns |  0.86 |    0.08 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.1642 ns | 0.1406 ns | 0.0077 ns |  1.1654 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  0.9227 ns | 0.0541 ns | 0.0030 ns |  0.9236 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.9966 ns | 0.5910 ns | 0.0324 ns |  4.0067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.7808 ns | 0.9233 ns | 0.0506 ns |  3.7806 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.1720 ns | 0.5323 ns | 0.0292 ns |  1.1591 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.1633 ns | 0.2978 ns | 0.0163 ns |  1.1623 ns |  0.99 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.6376 ns | 0.0852 ns | 0.0047 ns |  1.6385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.4928 ns | 0.4123 ns | 0.0226 ns |  1.4921 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  3.1133 ns | 0.1857 ns | 0.0102 ns |  3.1080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.1551 ns | 3.5939 ns | 0.1970 ns |  1.2304 ns |  0.37 |    0.06 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.7470 ns | 1.2293 ns | 0.0674 ns |  1.7178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.5008 ns | 0.3901 ns | 0.0214 ns |  1.4966 ns |  0.86 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.2137 ns | 0.3888 ns | 0.0213 ns |  1.2022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.2087 ns | 0.4039 ns | 0.0221 ns |  1.2014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.2292 ns | 0.2820 ns | 0.0155 ns |  4.2206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.0017 ns | 0.0517 ns | 0.0028 ns |  4.0009 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.2717 ns | 0.5343 ns | 0.0293 ns |  1.2691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.0912 ns | 0.3148 ns | 0.0173 ns |  1.0814 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.9041 ns | 0.1736 ns | 0.0095 ns |  1.9064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.8264 ns | 1.3276 ns | 0.0728 ns |  1.8608 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.8307 ns | 0.0821 ns | 0.0045 ns |  5.8320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.5367 ns | 0.8402 ns | 0.0461 ns |  1.5268 ns |  0.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.8225 ns | 0.7007 ns | 0.0384 ns | 12.8084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.0158 ns | 0.2651 ns | 0.0145 ns |  7.0202 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.2159 ns | 1.1488 ns | 0.0630 ns |  2.2048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.3506 ns | 0.9024 ns | 0.0495 ns |  2.3727 ns |  1.06 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0356 ns | 1.2347 ns | 0.0677 ns |  2.0151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.5475 ns | 0.0828 ns | 0.0045 ns |  1.5462 ns |  0.76 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.2238 ns | 2.1419 ns | 0.1174 ns |  4.2022 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.5406 ns | 1.5919 ns | 0.0873 ns |  3.4906 ns |  0.84 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 12.5143 ns | 5.7896 ns | 0.3173 ns | 12.6634 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.1636 ns | 0.5483 ns | 0.0301 ns |  3.1570 ns |  0.25 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.2434 ns | 0.3681 ns | 0.0202 ns |  8.2430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.5569 ns | 0.6979 ns | 0.0383 ns |  7.5578 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.7045 ns | 0.4973 ns | 0.0273 ns | 12.7191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.4423 ns | 1.1270 ns | 0.0618 ns | 11.4268 ns |  0.90 |    0.01 |      - |     - |     - |         - |
