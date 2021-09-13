
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.4462 ns |  0.5027 ns | 0.0276 ns |  1.4611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.1809 ns |  0.3576 ns | 0.0196 ns |  1.1843 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.9878 ns |  0.2859 ns | 0.0157 ns |  3.9956 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7116 ns |  1.2294 ns | 0.0674 ns |  3.6886 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.5814 ns |  1.0885 ns | 0.0597 ns |  2.5582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.9643 ns |  0.9489 ns | 0.0520 ns |  1.9476 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.5977 ns |  5.3944 ns | 0.2957 ns |  4.4338 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.8712 ns |  7.0952 ns | 0.3889 ns |  4.7640 ns |  1.06 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.4143 ns |  0.4321 ns | 0.0237 ns |  2.4239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.9042 ns |  0.4948 ns | 0.0271 ns |  1.8999 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.8533 ns |  7.8057 ns | 0.4279 ns |  4.9194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.2023 ns |  0.2548 ns | 0.0140 ns |  4.2070 ns |  0.87 |    0.08 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.4209 ns |  1.2523 ns | 0.0686 ns |  2.4602 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  2.0182 ns |  0.1341 ns | 0.0074 ns |  2.0213 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.4417 ns |  0.1584 ns | 0.0087 ns |  4.4436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.2614 ns |  1.6199 ns | 0.0888 ns |  4.2557 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.4271 ns |  0.4737 ns | 0.0260 ns |  2.4271 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.9595 ns |  0.2669 ns | 0.0146 ns |  1.9511 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.4490 ns |  0.0363 ns | 0.0020 ns |  4.4496 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.2258 ns |  0.6291 ns | 0.0345 ns |  4.2361 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.5160 ns |  0.3880 ns | 0.0213 ns |  2.5186 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.9108 ns |  0.4115 ns | 0.0226 ns |  1.9055 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.5424 ns |  1.5079 ns | 0.0827 ns |  4.5825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.2253 ns |  0.2069 ns | 0.0113 ns |  4.2238 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  2.4215 ns |  0.2196 ns | 0.0120 ns |  2.4244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  2.2067 ns |  0.2328 ns | 0.0128 ns |  2.2103 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.4520 ns |  0.0984 ns | 0.0054 ns |  4.4531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.2115 ns |  0.9476 ns | 0.0519 ns |  4.2211 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  2.5311 ns |  0.3099 ns | 0.0170 ns |  2.5322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  0.9965 ns |  0.4814 ns | 0.0264 ns |  0.9984 ns |  0.39 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.4444 ns |  0.2736 ns | 0.0150 ns |  4.4437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.8047 ns |  0.1135 ns | 0.0062 ns |  3.8020 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.1562 ns |  0.0524 ns | 0.0029 ns |  1.1547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  0.9180 ns |  0.1557 ns | 0.0085 ns |  0.9172 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.6480 ns |  0.4501 ns | 0.0247 ns |  1.6347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.6192 ns |  0.0388 ns | 0.0021 ns |  1.6199 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.2102 ns |  0.2346 ns | 0.0129 ns |  1.2117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.0104 ns |  0.3190 ns | 0.0175 ns |  1.0017 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.6972 ns |  0.2605 ns | 0.0143 ns |  1.6952 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.6153 ns |  0.2479 ns | 0.0136 ns |  1.6109 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.2531 ns |  0.5693 ns | 0.0312 ns |  1.2612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.1513 ns |  0.2341 ns | 0.0128 ns |  1.1472 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.2492 ns |  0.6254 ns | 0.0343 ns |  4.2509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  3.9549 ns |  0.6361 ns | 0.0349 ns |  3.9730 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.2326 ns |  0.3102 ns | 0.0170 ns |  1.2347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.0888 ns |  0.2783 ns | 0.0153 ns |  1.0898 ns |  0.88 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.5113 ns | 16.0725 ns | 0.8810 ns |  2.0855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.8840 ns |  0.2777 ns | 0.0152 ns |  1.8878 ns |  0.80 |    0.23 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.6782 ns |  1.2916 ns | 0.0708 ns |  5.6655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.7514 ns |  0.3171 ns | 0.0174 ns |  1.7469 ns |  0.31 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.5605 ns | 21.5066 ns | 1.1789 ns | 12.9492 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.0300 ns |  0.5562 ns | 0.0305 ns |  8.0274 ns |  0.60 |    0.05 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.3248 ns |  0.2458 ns | 0.0135 ns |  2.3196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.0938 ns |  0.4692 ns | 0.0257 ns |  2.0795 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0334 ns |  0.6592 ns | 0.0361 ns |  2.0525 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.8257 ns |  0.3639 ns | 0.0199 ns |  1.8148 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.3149 ns |  0.8755 ns | 0.0480 ns |  3.2893 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.4952 ns |  1.1359 ns | 0.0623 ns |  3.4804 ns |  1.05 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 14.2784 ns |  7.7547 ns | 0.4251 ns | 14.3818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  4.2792 ns |  4.1081 ns | 0.2252 ns |  4.2989 ns |  0.30 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  9.1688 ns | 12.0790 ns | 0.6621 ns |  8.8209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.9916 ns |  0.2785 ns | 0.0153 ns |  7.9922 ns |  0.87 |    0.06 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.0484 ns |  2.1995 ns | 0.1206 ns | 13.0169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 12.0184 ns |  0.5276 ns | 0.0289 ns | 12.0341 ns |  0.92 |    0.01 |      - |     - |     - |         - |
