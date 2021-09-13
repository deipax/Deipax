
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |   1.290 ns |  1.6602 ns | 0.0910 ns |   1.255 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |   1.282 ns |  0.1600 ns | 0.0088 ns |   1.279 ns |  1.00 |    0.06 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |   4.480 ns |  0.4168 ns | 0.0228 ns |   4.481 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |   4.260 ns |  1.0770 ns | 0.0590 ns |   4.232 ns |  0.95 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |   1.199 ns |  0.5053 ns | 0.0277 ns |   1.189 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |   1.238 ns |  0.5413 ns | 0.0297 ns |   1.224 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |   4.017 ns |  0.3154 ns | 0.0173 ns |   4.008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |   3.812 ns |  0.9504 ns | 0.0521 ns |   3.793 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |   4.672 ns |  0.2619 ns | 0.0144 ns |   4.677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |   4.816 ns |  0.6734 ns | 0.0369 ns |   4.818 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |   7.314 ns |  2.4725 ns | 0.1355 ns |   7.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |   7.475 ns |  6.9857 ns | 0.3829 ns |   7.352 ns |  1.02 |    0.06 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |   5.339 ns |  9.8924 ns | 0.5422 ns |   5.142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |   3.286 ns |  1.2893 ns | 0.0707 ns |   3.269 ns |  0.62 |    0.07 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |   6.908 ns |  0.9825 ns | 0.0539 ns |   6.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |   5.903 ns |  0.1942 ns | 0.0106 ns |   5.897 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |   4.728 ns |  0.8038 ns | 0.0441 ns |   4.714 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |   4.631 ns |  1.0762 ns | 0.0590 ns |   4.649 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |   6.853 ns |  1.1143 ns | 0.0611 ns |   6.859 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |   6.626 ns |  1.1586 ns | 0.0635 ns |   6.638 ns |  0.97 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |   4.578 ns |  0.3383 ns | 0.0185 ns |   4.588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |   3.309 ns |  0.2377 ns | 0.0130 ns |   3.303 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |   6.972 ns |  4.4978 ns | 0.2465 ns |   6.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |   5.883 ns |  0.3329 ns | 0.0182 ns |   5.886 ns |  0.84 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |   3.154 ns |  0.5829 ns | 0.0320 ns |   3.165 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |   3.317 ns |  0.4945 ns | 0.0271 ns |   3.328 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |   6.050 ns |  0.5589 ns | 0.0306 ns |   6.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |   6.418 ns | 13.2382 ns | 0.7256 ns |   6.078 ns |  1.06 |    0.12 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |   3.319 ns |  0.3759 ns | 0.0206 ns |   3.326 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |   3.403 ns |  0.1936 ns | 0.0106 ns |   3.403 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |   6.206 ns |  0.3983 ns | 0.0218 ns |   6.214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |   5.966 ns |  0.2529 ns | 0.0139 ns |   5.971 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |   2.619 ns |  0.5016 ns | 0.0275 ns |   2.620 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |   2.828 ns |  3.2061 ns | 0.1757 ns |   2.862 ns |  1.08 |    0.07 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |   3.245 ns |  0.3634 ns | 0.0199 ns |   3.234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |   3.205 ns |  0.0576 ns | 0.0032 ns |   3.204 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |   2.553 ns |  0.2831 ns | 0.0155 ns |   2.554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |   2.588 ns |  0.4515 ns | 0.0247 ns |   2.579 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |   3.150 ns |  0.5878 ns | 0.0322 ns |   3.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |   3.189 ns |  0.5038 ns | 0.0276 ns |   3.175 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |   1.685 ns |  0.1752 ns | 0.0096 ns |   1.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |   1.275 ns |  0.6402 ns | 0.0351 ns |   1.261 ns |  0.76 |    0.03 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |   4.289 ns |  1.3603 ns | 0.0746 ns |   4.254 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |   4.035 ns |  0.6376 ns | 0.0350 ns |   4.052 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |   1.259 ns |  0.2804 ns | 0.0154 ns |   1.256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |   1.245 ns |  0.0195 ns | 0.0011 ns |   1.245 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |   2.105 ns |  0.2048 ns | 0.0112 ns |   2.099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |   2.002 ns |  0.3249 ns | 0.0178 ns |   1.995 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  12.466 ns |  2.6206 ns | 0.1436 ns |  12.533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  11.664 ns |  1.0773 ns | 0.0590 ns |  11.667 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  17.871 ns |  6.3652 ns | 0.3489 ns |  17.671 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  13.954 ns |  1.5856 ns | 0.0869 ns |  13.913 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |   2.234 ns |  0.2031 ns | 0.0111 ns |   2.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |   2.151 ns |  0.6860 ns | 0.0376 ns |   2.147 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |   2.025 ns |  0.4042 ns | 0.0222 ns |   2.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |   1.671 ns |  0.7465 ns | 0.0409 ns |   1.680 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |   3.792 ns |  1.2215 ns | 0.0670 ns |   3.808 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |   3.744 ns |  0.9723 ns | 0.0533 ns |   3.728 ns |  0.99 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 114.716 ns |  5.9244 ns | 0.3247 ns | 114.600 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 |  93.770 ns | 48.1550 ns | 2.6395 ns |  95.109 ns |  0.82 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |            |            |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  10.550 ns |  2.0903 ns | 0.1146 ns |  10.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  10.127 ns |  2.6337 ns | 0.1444 ns |  10.147 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                    |               |            |            |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  16.106 ns | 16.0391 ns | 0.8792 ns |  16.446 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  13.566 ns |  1.4641 ns | 0.0803 ns |  13.528 ns |  0.84 |    0.05 |      - |     - |     - |         - |
