
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.199 ns | 0.7446 ns | 0.0408 ns |  1.188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.215 ns | 0.0803 ns | 0.0044 ns |  1.216 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.962 ns | 0.4234 ns | 0.0232 ns |  3.965 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.782 ns | 0.6554 ns | 0.0359 ns |  3.762 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.155 ns | 0.6140 ns | 0.0337 ns |  1.170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.199 ns | 0.2558 ns | 0.0140 ns |  1.193 ns |  1.04 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.284 ns | 5.2019 ns | 0.2851 ns |  4.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.803 ns | 0.2055 ns | 0.0113 ns |  3.804 ns |  0.89 |    0.06 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.601 ns | 4.6876 ns | 0.2569 ns |  1.535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.226 ns | 0.2920 ns | 0.0160 ns |  1.218 ns |  0.78 |    0.13 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.006 ns | 0.1472 ns | 0.0081 ns |  4.009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.767 ns | 0.0868 ns | 0.0048 ns |  3.764 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.615 ns | 0.0451 ns | 0.0025 ns |  1.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.228 ns | 0.5568 ns | 0.0305 ns |  1.211 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  3.998 ns | 0.1629 ns | 0.0089 ns |  3.994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.778 ns | 0.3205 ns | 0.0176 ns |  3.786 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.167 ns | 0.2968 ns | 0.0163 ns |  1.158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.254 ns | 0.8781 ns | 0.0481 ns |  1.248 ns |  1.08 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.073 ns | 1.4598 ns | 0.0800 ns |  4.030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.778 ns | 0.1843 ns | 0.0101 ns |  3.781 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.139 ns | 0.2594 ns | 0.0142 ns |  1.134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.415 ns | 3.4948 ns | 0.1916 ns |  1.476 ns |  1.24 |    0.18 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.255 ns | 0.3769 ns | 0.0207 ns |  4.248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.547 ns | 0.0461 ns | 0.0025 ns |  3.548 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.240 ns | 0.7334 ns | 0.0402 ns |  1.219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.200 ns | 0.3135 ns | 0.0172 ns |  1.195 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.988 ns | 0.0720 ns | 0.0039 ns |  3.986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.792 ns | 0.1723 ns | 0.0094 ns |  3.797 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.120 ns | 0.2831 ns | 0.0155 ns |  1.114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.193 ns | 0.0949 ns | 0.0052 ns |  1.192 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.001 ns | 0.1933 ns | 0.0106 ns |  4.000 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.866 ns | 2.3971 ns | 0.1314 ns |  3.798 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.131 ns | 0.0465 ns | 0.0026 ns |  1.132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.191 ns | 0.0379 ns | 0.0021 ns |  1.190 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.895 ns | 0.0413 ns | 0.0023 ns |  1.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.986 ns | 0.7022 ns | 0.0385 ns |  2.006 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.206 ns | 0.9991 ns | 0.0548 ns |  1.237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.173 ns | 0.3797 ns | 0.0208 ns |  1.162 ns |  0.97 |    0.06 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.940 ns | 0.0816 ns | 0.0045 ns |  1.939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.731 ns | 1.9311 ns | 0.1058 ns |  1.676 ns |  0.89 |    0.06 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.666 ns | 0.3027 ns | 0.0166 ns |  1.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.254 ns | 0.4481 ns | 0.0246 ns |  1.258 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.246 ns | 0.2796 ns | 0.0153 ns |  4.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.014 ns | 0.7951 ns | 0.0436 ns |  3.992 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.191 ns | 0.5250 ns | 0.0288 ns |  1.206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.225 ns | 0.0848 ns | 0.0046 ns |  1.222 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.959 ns | 0.0075 ns | 0.0004 ns |  1.959 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.703 ns | 0.4052 ns | 0.0222 ns |  1.697 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.077 ns | 0.2763 ns | 0.0151 ns |  6.069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.685 ns | 0.5089 ns | 0.0279 ns |  1.670 ns |  0.28 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.248 ns | 0.6857 ns | 0.0376 ns | 13.242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.559 ns | 0.7601 ns | 0.0417 ns |  7.540 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.391 ns | 0.8485 ns | 0.0465 ns |  2.407 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.252 ns | 0.8583 ns | 0.0470 ns |  2.241 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.044 ns | 1.4955 ns | 0.0820 ns |  2.024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.679 ns | 0.6748 ns | 0.0370 ns |  1.666 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.707 ns | 0.7472 ns | 0.0410 ns |  3.711 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.692 ns | 0.9624 ns | 0.0528 ns |  3.690 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 12.586 ns | 1.9757 ns | 0.1083 ns | 12.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.212 ns | 0.7516 ns | 0.0412 ns |  3.200 ns |  0.26 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.320 ns | 0.2098 ns | 0.0115 ns |  8.323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.613 ns | 0.2734 ns | 0.0150 ns |  7.618 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.744 ns | 0.5269 ns | 0.0289 ns | 12.739 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.549 ns | 1.2188 ns | 0.0668 ns | 11.579 ns |  0.91 |    0.01 |      - |     - |     - |         - |
