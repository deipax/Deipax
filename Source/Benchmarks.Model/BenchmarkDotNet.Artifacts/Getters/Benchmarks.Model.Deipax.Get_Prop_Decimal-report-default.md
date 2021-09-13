
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  4.781 ns | 2.3895 ns | 0.1310 ns |  4.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  6.927 ns | 5.6474 ns | 0.3096 ns |  6.943 ns |  1.45 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  7.266 ns | 1.0446 ns | 0.0573 ns |  7.236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 10.476 ns | 1.7937 ns | 0.0983 ns | 10.427 ns |  1.44 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.179 ns | 0.3504 ns | 0.0192 ns |  1.184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.165 ns | 0.1012 ns | 0.0055 ns |  1.166 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  3.883 ns | 0.5590 ns | 0.0306 ns |  3.873 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.755 ns | 0.1706 ns | 0.0094 ns |  3.754 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  7.891 ns | 1.3973 ns | 0.0766 ns |  7.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  8.036 ns | 0.6883 ns | 0.0377 ns |  8.057 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  8.906 ns | 0.7606 ns | 0.0417 ns |  8.885 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 11.339 ns | 1.4096 ns | 0.0773 ns | 11.330 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  7.031 ns | 0.6419 ns | 0.0352 ns |  7.021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  8.014 ns | 0.8898 ns | 0.0488 ns |  8.000 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  9.206 ns | 3.0784 ns | 0.1687 ns |  9.201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 11.213 ns | 0.5155 ns | 0.0283 ns | 11.200 ns |  1.22 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  7.230 ns | 2.1651 ns | 0.1187 ns |  7.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  8.507 ns | 3.8537 ns | 0.2112 ns |  8.415 ns |  1.18 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  9.007 ns | 1.3398 ns | 0.0734 ns |  9.035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 11.299 ns | 1.0454 ns | 0.0573 ns | 11.275 ns |  1.25 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  7.691 ns | 1.5121 ns | 0.0829 ns |  7.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  8.408 ns | 8.0264 ns | 0.4400 ns |  8.223 ns |  1.09 |    0.07 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  8.836 ns | 0.5650 ns | 0.0310 ns |  8.844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 11.331 ns | 0.3828 ns | 0.0210 ns | 11.324 ns |  1.28 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  6.265 ns | 3.5637 ns | 0.1953 ns |  6.155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  7.769 ns | 2.2403 ns | 0.1228 ns |  7.706 ns |  1.24 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  7.919 ns | 0.4388 ns | 0.0241 ns |  7.908 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 10.986 ns | 4.3615 ns | 0.2391 ns | 10.926 ns |  1.39 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  5.768 ns | 0.6568 ns | 0.0360 ns |  5.763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  7.668 ns | 0.2027 ns | 0.0111 ns |  7.662 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  7.881 ns | 1.1167 ns | 0.0612 ns |  7.850 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 10.870 ns | 1.3034 ns | 0.0714 ns | 10.874 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  5.594 ns | 0.2012 ns | 0.0110 ns |  5.590 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  7.450 ns | 0.4380 ns | 0.0240 ns |  7.456 ns |  1.33 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  6.490 ns | 6.0889 ns | 0.3338 ns |  6.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  8.435 ns | 2.0161 ns | 0.1105 ns |  8.378 ns |  1.30 |    0.09 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  5.697 ns | 1.8730 ns | 0.1027 ns |  5.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  7.475 ns | 1.5618 ns | 0.0856 ns |  7.451 ns |  1.31 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  6.366 ns | 1.6681 ns | 0.0914 ns |  6.332 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  8.209 ns | 1.0012 ns | 0.0549 ns |  8.223 ns |  1.29 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  5.293 ns | 1.8703 ns | 0.1025 ns |  5.243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  4.107 ns | 0.3153 ns | 0.0173 ns |  4.106 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  6.957 ns | 0.6290 ns | 0.0345 ns |  6.966 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  6.522 ns | 0.1672 ns | 0.0092 ns |  6.522 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  5.033 ns | 0.2193 ns | 0.0120 ns |  5.036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  3.945 ns | 0.8686 ns | 0.0476 ns |  3.923 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  5.995 ns | 4.2980 ns | 0.2356 ns |  5.933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  4.470 ns | 1.0034 ns | 0.0550 ns |  4.488 ns |  0.75 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  1.881 ns | 0.2598 ns | 0.0142 ns |  1.881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.661 ns | 0.8045 ns | 0.0441 ns |  1.649 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  5.802 ns | 0.8872 ns | 0.0486 ns |  5.815 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  5.806 ns | 0.9305 ns | 0.0510 ns |  5.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.124 ns | 0.0901 ns | 0.0049 ns |  2.123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.145 ns | 0.2243 ns | 0.0123 ns |  2.146 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.108 ns | 5.6615 ns | 0.3103 ns |  1.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.884 ns | 0.2172 ns | 0.0119 ns |  1.878 ns |  0.91 |    0.13 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.036 ns | 0.7058 ns | 0.0387 ns |  4.049 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 5.0 |  4.000 ns | 3.1434 ns | 0.1723 ns |  3.934 ns |  0.99 |    0.04 | 0.0051 |     - |     - |      32 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 48.358 ns | 0.7274 ns | 0.0399 ns | 48.341 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 | 35.899 ns | 0.7587 ns | 0.0416 ns | 35.891 ns |  0.74 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 | 12.499 ns | 3.9365 ns | 0.2158 ns | 12.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 15.370 ns | 0.4786 ns | 0.0262 ns | 15.355 ns |  1.23 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 22.112 ns | 4.0081 ns | 0.2197 ns | 21.992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 19.151 ns | 1.3851 ns | 0.0759 ns | 19.126 ns |  0.87 |    0.01 |      - |     - |     - |         - |
