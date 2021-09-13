
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.539 ns | 0.6494 ns | 0.0356 ns |  1.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.604 ns | 0.9776 ns | 0.0536 ns |  1.619 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.153 ns | 0.0403 ns | 0.0022 ns |  4.153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.994 ns | 0.1472 ns | 0.0081 ns |  3.997 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.646 ns | 0.3157 ns | 0.0173 ns |  1.645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.513 ns | 0.7556 ns | 0.0414 ns |  1.517 ns |  0.92 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  3.990 ns | 0.4107 ns | 0.0225 ns |  4.001 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.997 ns | 0.2745 ns | 0.0150 ns |  3.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.761 ns | 0.8314 ns | 0.0456 ns |  1.742 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.810 ns | 0.8586 ns | 0.0471 ns |  1.786 ns |  1.03 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.453 ns | 0.2605 ns | 0.0143 ns |  4.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.006 ns | 0.2116 ns | 0.0116 ns |  4.008 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.764 ns | 0.1112 ns | 0.0061 ns |  1.762 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.763 ns | 0.1563 ns | 0.0086 ns |  1.767 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.453 ns | 0.3542 ns | 0.0194 ns |  4.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.976 ns | 0.4096 ns | 0.0225 ns |  3.978 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.670 ns | 0.1834 ns | 0.0101 ns |  1.666 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.536 ns | 0.6980 ns | 0.0383 ns |  1.555 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.453 ns | 0.1949 ns | 0.0107 ns |  4.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.966 ns | 0.3691 ns | 0.0202 ns |  3.960 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.584 ns | 0.8385 ns | 0.0460 ns |  1.560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.419 ns | 0.0830 ns | 0.0046 ns |  1.417 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  1.191 ns | 0.4215 ns | 0.0231 ns |  1.199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  1.189 ns | 0.9404 ns | 0.0515 ns |  1.161 ns |  1.00 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.528 ns | 0.1252 ns | 0.0069 ns |  1.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.645 ns | 0.4803 ns | 0.0263 ns |  1.630 ns |  1.08 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.994 ns | 0.0730 ns | 0.0040 ns |  3.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.227 ns | 0.0815 ns | 0.0045 ns |  4.225 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.604 ns | 0.4762 ns | 0.0261 ns |  1.603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.830 ns | 0.5891 ns | 0.0323 ns |  1.849 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.994 ns | 0.2739 ns | 0.0150 ns |  4.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.979 ns | 0.2078 ns | 0.0114 ns |  3.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.761 ns | 0.1091 ns | 0.0060 ns |  1.764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.504 ns | 0.6457 ns | 0.0354 ns |  1.484 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.147 ns | 1.0189 ns | 0.0558 ns |  2.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.200 ns | 0.2188 ns | 0.0120 ns |  2.197 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.468 ns | 0.1449 ns | 0.0079 ns |  1.472 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.515 ns | 0.9648 ns | 0.0529 ns |  1.484 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.998 ns | 3.2030 ns | 0.1756 ns |  1.921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.296 ns | 0.6702 ns | 0.0367 ns |  2.303 ns |  1.16 |    0.11 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.900 ns | 2.3955 ns | 0.1313 ns |  1.951 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.538 ns | 0.7241 ns | 0.0397 ns |  1.530 ns |  0.81 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.454 ns | 0.0551 ns | 0.0030 ns |  4.453 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.239 ns | 0.2297 ns | 0.0126 ns |  4.238 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.526 ns | 0.5099 ns | 0.0280 ns |  1.515 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.664 ns | 2.0086 ns | 0.1101 ns |  1.663 ns |  1.09 |    0.07 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.948 ns | 0.1616 ns | 0.0089 ns |  1.952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.084 ns | 0.5183 ns | 0.0284 ns |  2.096 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.887 ns | 2.8196 ns | 0.1546 ns |  5.801 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.072 ns | 0.6289 ns | 0.0345 ns |  2.084 ns |  0.35 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.559 ns | 0.1894 ns | 0.0104 ns | 12.557 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.699 ns | 0.5241 ns | 0.0287 ns |  7.713 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.389 ns | 0.2130 ns | 0.0117 ns |  2.390 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.311 ns | 1.1092 ns | 0.0608 ns |  2.298 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.008 ns | 0.1157 ns | 0.0063 ns |  2.011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.760 ns | 0.6302 ns | 0.0345 ns |  1.748 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.366 ns | 0.1912 ns | 0.0105 ns |  4.361 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.842 ns | 1.3972 ns | 0.0766 ns |  3.874 ns |  0.88 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 12.923 ns | 2.1299 ns | 0.1167 ns | 12.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.516 ns | 0.3806 ns | 0.0209 ns |  3.511 ns |  0.27 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.679 ns | 0.3018 ns | 0.0165 ns |  8.670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.808 ns | 0.8876 ns | 0.0487 ns |  7.805 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.089 ns | 1.6792 ns | 0.0920 ns | 13.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.044 ns | 0.8586 ns | 0.0471 ns | 12.047 ns |  0.92 |    0.01 |      - |     - |     - |         - |
