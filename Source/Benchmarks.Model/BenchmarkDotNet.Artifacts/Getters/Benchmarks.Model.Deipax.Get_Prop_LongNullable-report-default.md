
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.486 ns |  0.1419 ns | 0.0078 ns |  1.486 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.492 ns |  1.3856 ns | 0.0760 ns |  1.464 ns |  1.00 |    0.05 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.464 ns |  0.7765 ns | 0.0426 ns |  4.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.002 ns |  0.4197 ns | 0.0230 ns |  4.009 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  3.055 ns |  8.5739 ns | 0.4700 ns |  3.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  2.193 ns |  0.0716 ns | 0.0039 ns |  2.192 ns |  0.73 |    0.11 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.718 ns |  0.4631 ns | 0.0254 ns |  4.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.695 ns |  0.1543 ns | 0.0085 ns |  4.698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.751 ns |  0.6187 ns | 0.0339 ns |  2.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  2.566 ns |  0.4265 ns | 0.0234 ns |  2.570 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.709 ns |  0.4590 ns | 0.0252 ns |  4.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  5.268 ns | 15.8881 ns | 0.8709 ns |  4.822 ns |  1.12 |    0.18 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.897 ns |  0.4950 ns | 0.0271 ns |  2.895 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  2.282 ns |  0.3843 ns | 0.0211 ns |  2.271 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.698 ns |  0.4128 ns | 0.0226 ns |  4.709 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.716 ns |  0.4719 ns | 0.0259 ns |  4.705 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.747 ns |  0.0318 ns | 0.0017 ns |  2.747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  2.795 ns |  2.7266 ns | 0.1495 ns |  2.748 ns |  1.02 |    0.05 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.710 ns |  0.2237 ns | 0.0123 ns |  4.713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.678 ns |  0.2876 ns | 0.0158 ns |  4.670 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.888 ns |  0.2830 ns | 0.0155 ns |  2.889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  2.954 ns |  3.8703 ns | 0.2121 ns |  2.858 ns |  1.02 |    0.08 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.677 ns |  0.2786 ns | 0.0153 ns |  4.675 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.815 ns |  2.1026 ns | 0.1152 ns |  4.752 ns |  1.03 |    0.03 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  2.699 ns |  0.2081 ns | 0.0114 ns |  2.699 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  2.707 ns |  0.2782 ns | 0.0153 ns |  2.710 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.945 ns |  0.7124 ns | 0.0390 ns |  4.941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.740 ns |  0.0970 ns | 0.0053 ns |  4.743 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  2.456 ns |  0.0914 ns | 0.0050 ns |  2.454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.591 ns |  0.1682 ns | 0.0092 ns |  1.589 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.713 ns |  0.2991 ns | 0.0164 ns |  4.717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.503 ns | 10.8244 ns | 0.5933 ns |  4.309 ns |  0.96 |    0.13 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.590 ns |  0.4031 ns | 0.0221 ns |  1.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.305 ns |  0.1242 ns | 0.0068 ns |  1.303 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.537 ns |  0.1886 ns | 0.0103 ns |  1.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.744 ns |  0.2074 ns | 0.0114 ns |  1.748 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.462 ns |  1.1763 ns | 0.0645 ns |  1.435 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.323 ns |  0.0653 ns | 0.0036 ns |  1.325 ns |  0.91 |    0.04 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.986 ns |  0.1066 ns | 0.0058 ns |  1.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.011 ns |  0.4134 ns | 0.0227 ns |  2.001 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.551 ns |  0.1780 ns | 0.0098 ns |  1.552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.486 ns |  0.1425 ns | 0.0078 ns |  1.490 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.481 ns |  0.1316 ns | 0.0072 ns |  4.480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.267 ns |  0.1417 ns | 0.0078 ns |  4.264 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.735 ns |  0.0502 ns | 0.0028 ns |  1.736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.500 ns |  0.1705 ns | 0.0093 ns |  1.499 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.989 ns |  0.1499 ns | 0.0082 ns |  1.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.132 ns |  0.5204 ns | 0.0285 ns |  2.119 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.156 ns |  0.1578 ns | 0.0087 ns |  6.154 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.222 ns |  0.2250 ns | 0.0123 ns |  2.218 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.563 ns |  0.4655 ns | 0.0255 ns | 13.565 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.692 ns |  1.0254 ns | 0.0562 ns |  7.677 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.164 ns |  0.4206 ns | 0.0231 ns |  2.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.180 ns |  0.5074 ns | 0.0278 ns |  2.183 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.002 ns |  0.1155 ns | 0.0063 ns |  2.005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.587 ns |  0.2048 ns | 0.0112 ns |  1.588 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.369 ns |  3.3997 ns | 0.1863 ns |  4.267 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.922 ns |  0.8822 ns | 0.0484 ns |  3.902 ns |  0.90 |    0.04 | 0.0038 |     - |     - |      24 B |
                    |               |           |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 14.228 ns |  1.0174 ns | 0.0558 ns | 14.197 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  4.330 ns |  0.7779 ns | 0.0426 ns |  4.348 ns |  0.30 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.811 ns |  0.5907 ns | 0.0324 ns |  8.822 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  8.478 ns |  5.5191 ns | 0.3025 ns |  8.357 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.505 ns |  0.7919 ns | 0.0434 ns | 13.512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.530 ns |  1.8803 ns | 0.1031 ns | 12.484 ns |  0.93 |    0.01 |      - |     - |     - |         - |
