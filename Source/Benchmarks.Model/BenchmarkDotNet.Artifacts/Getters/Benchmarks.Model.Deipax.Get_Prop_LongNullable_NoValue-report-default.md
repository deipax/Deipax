
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.445 ns | 0.1297 ns | 0.0071 ns | 1.446 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.461 ns | 0.0405 ns | 0.0022 ns | 1.462 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.016 ns | 1.0557 ns | 0.0579 ns | 3.995 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.750 ns | 0.1868 ns | 0.0102 ns | 3.755 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.339 ns | 0.2664 ns | 0.0146 ns | 1.347 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.428 ns | 3.4900 ns | 0.1913 ns | 1.350 ns |  1.07 |    0.14 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.058 ns | 0.4899 ns | 0.0269 ns | 4.058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.796 ns | 0.4004 ns | 0.0219 ns | 3.791 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.618 ns | 3.4093 ns | 0.1869 ns | 1.539 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.360 ns | 0.0562 ns | 0.0031 ns | 1.361 ns |  0.85 |    0.09 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 3.983 ns | 0.0975 ns | 0.0053 ns | 3.983 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.804 ns | 0.2430 ns | 0.0133 ns | 3.801 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.464 ns | 0.5888 ns | 0.0323 ns | 1.455 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.375 ns | 0.2469 ns | 0.0135 ns | 1.370 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 3.984 ns | 0.2575 ns | 0.0141 ns | 3.980 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.735 ns | 0.2695 ns | 0.0148 ns | 3.737 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.511 ns | 0.4255 ns | 0.0233 ns | 1.512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.461 ns | 0.3736 ns | 0.0205 ns | 1.454 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.047 ns | 0.8425 ns | 0.0462 ns | 4.068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.855 ns | 1.2406 ns | 0.0680 ns | 3.825 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.384 ns | 0.3843 ns | 0.0211 ns | 1.379 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.375 ns | 0.9630 ns | 0.0528 ns | 1.400 ns |  0.99 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.103 ns | 0.7893 ns | 0.0433 ns | 4.102 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.781 ns | 0.9497 ns | 0.0521 ns | 3.753 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.658 ns | 3.0397 ns | 0.1666 ns | 1.690 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.522 ns | 1.7207 ns | 0.0943 ns | 1.543 ns |  0.93 |    0.14 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.044 ns | 0.9082 ns | 0.0498 ns | 4.023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.806 ns | 0.1766 ns | 0.0097 ns | 3.801 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.365 ns | 0.5912 ns | 0.0324 ns | 1.358 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.564 ns | 0.3513 ns | 0.0193 ns | 1.555 ns |  1.15 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.046 ns | 1.7818 ns | 0.0977 ns | 4.001 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.812 ns | 0.7144 ns | 0.0392 ns | 3.801 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.328 ns | 0.1592 ns | 0.0087 ns | 1.327 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.444 ns | 0.3964 ns | 0.0217 ns | 1.452 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 1.558 ns | 0.1628 ns | 0.0089 ns | 1.562 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 1.800 ns | 0.1204 ns | 0.0066 ns | 1.800 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.426 ns | 0.2020 ns | 0.0111 ns | 1.425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.316 ns | 0.0284 ns | 0.0016 ns | 1.316 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.959 ns | 1.1754 ns | 0.0644 ns | 1.936 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 1.759 ns | 0.4693 ns | 0.0257 ns | 1.747 ns |  0.90 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.703 ns | 1.0991 ns | 0.0602 ns | 1.728 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.528 ns | 2.2850 ns | 0.1252 ns | 1.471 ns |  0.90 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.257 ns | 0.1459 ns | 0.0080 ns | 4.254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.048 ns | 0.3538 ns | 0.0194 ns | 4.046 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.977 ns | 0.1391 ns | 0.0076 ns | 1.977 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.480 ns | 0.1177 ns | 0.0065 ns | 1.480 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.163 ns | 2.3861 ns | 0.1308 ns | 2.124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.062 ns | 0.2098 ns | 0.0115 ns | 2.064 ns |  0.96 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.086 ns | 0.8058 ns | 0.0442 ns | 2.070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.361 ns | 2.8990 ns | 0.1589 ns | 2.279 ns |  1.13 |    0.09 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.299 ns | 0.1302 ns | 0.0071 ns | 2.298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.365 ns | 0.2520 ns | 0.0138 ns | 2.364 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.419 ns | 0.3558 ns | 0.0195 ns | 2.416 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.175 ns | 0.2417 ns | 0.0132 ns | 2.172 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.050 ns | 0.4288 ns | 0.0235 ns | 2.064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.595 ns | 0.2741 ns | 0.0150 ns | 1.592 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.339 ns | 0.1852 ns | 0.0102 ns | 1.336 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.435 ns | 0.5471 ns | 0.0300 ns | 1.428 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.926 ns | 0.0808 ns | 0.0044 ns | 1.927 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.391 ns | 0.4244 ns | 0.0233 ns | 1.380 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.524 ns | 0.1644 ns | 0.0090 ns | 1.521 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.461 ns | 0.0896 ns | 0.0049 ns | 1.459 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.072 ns | 1.4529 ns | 0.0796 ns | 4.031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.008 ns | 0.3045 ns | 0.0167 ns | 4.017 ns |  0.98 |    0.02 |     - |     - |     - |         - |
