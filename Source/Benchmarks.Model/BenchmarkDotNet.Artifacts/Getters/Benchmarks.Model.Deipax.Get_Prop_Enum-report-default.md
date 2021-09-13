
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.259 ns | 0.7319 ns | 0.0401 ns |  1.276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.214 ns | 0.4169 ns | 0.0229 ns |  1.204 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.931 ns | 0.0127 ns | 0.0007 ns |  3.931 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.828 ns | 1.0830 ns | 0.0594 ns |  3.803 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.501 ns | 1.0711 ns | 0.0587 ns |  2.503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.424 ns | 0.1533 ns | 0.0084 ns |  1.426 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.887 ns | 4.2558 ns | 0.2333 ns |  4.766 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.773 ns | 0.6601 ns | 0.0362 ns |  3.763 ns |  0.77 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.780 ns | 0.4127 ns | 0.0226 ns |  2.788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  2.404 ns | 0.2678 ns | 0.0147 ns |  2.397 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.416 ns | 0.3638 ns | 0.0199 ns |  4.419 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.241 ns | 0.3633 ns | 0.0199 ns |  4.252 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.791 ns | 2.4953 ns | 0.1368 ns |  2.737 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.221 ns | 0.0792 ns | 0.0043 ns |  1.222 ns |  0.44 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.737 ns | 8.5017 ns | 0.4660 ns |  4.530 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.786 ns | 0.2699 ns | 0.0148 ns |  3.790 ns |  0.80 |    0.08 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.440 ns | 0.3894 ns | 0.0213 ns |  2.444 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  2.543 ns | 1.6971 ns | 0.0930 ns |  2.552 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.458 ns | 0.0484 ns | 0.0027 ns |  4.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.231 ns | 0.4894 ns | 0.0268 ns |  4.228 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.799 ns | 0.1789 ns | 0.0098 ns |  2.797 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.459 ns | 0.6229 ns | 0.0341 ns |  1.444 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.470 ns | 1.1327 ns | 0.0621 ns |  4.434 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.773 ns | 0.7908 ns | 0.0433 ns |  3.791 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.203 ns | 0.4271 ns | 0.0234 ns |  1.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.204 ns | 0.4412 ns | 0.0242 ns |  1.192 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.971 ns | 0.2836 ns | 0.0155 ns |  3.974 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.790 ns | 0.0857 ns | 0.0047 ns |  3.792 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.206 ns | 0.4580 ns | 0.0251 ns |  1.203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.224 ns | 0.1641 ns | 0.0090 ns |  1.219 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.108 ns | 8.0833 ns | 0.4431 ns |  3.896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.784 ns | 5.8232 ns | 0.3192 ns |  3.672 ns |  0.93 |    0.15 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.158 ns | 0.3649 ns | 0.0200 ns |  1.168 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.212 ns | 0.0598 ns | 0.0033 ns |  1.211 ns |  1.05 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.678 ns | 0.9036 ns | 0.0495 ns |  1.673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.691 ns | 0.4769 ns | 0.0261 ns |  1.705 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.179 ns | 0.2283 ns | 0.0125 ns |  1.172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.218 ns | 0.3129 ns | 0.0171 ns |  1.209 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.877 ns | 0.0770 ns | 0.0042 ns |  1.876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.921 ns | 0.4620 ns | 0.0253 ns |  1.909 ns |  1.02 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.218 ns | 0.2829 ns | 0.0155 ns |  1.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.228 ns | 0.0490 ns | 0.0027 ns |  1.229 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.203 ns | 0.2405 ns | 0.0132 ns |  4.211 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.005 ns | 0.6146 ns | 0.0337 ns |  4.015 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.235 ns | 0.4925 ns | 0.0270 ns |  1.246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.235 ns | 0.1261 ns | 0.0069 ns |  1.237 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.765 ns | 1.5030 ns | 0.0824 ns |  1.798 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.936 ns | 0.6201 ns | 0.0340 ns |  1.916 ns |  1.10 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.826 ns | 0.2474 ns | 0.0136 ns |  5.825 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.952 ns | 0.9799 ns | 0.0537 ns |  1.947 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.828 ns | 1.5939 ns | 0.0874 ns | 12.782 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.473 ns | 0.1084 ns | 0.0059 ns |  7.472 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.674 ns | 0.1355 ns | 0.0074 ns |  2.677 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.232 ns | 0.5405 ns | 0.0296 ns |  2.216 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.030 ns | 0.5198 ns | 0.0285 ns |  2.039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  2.026 ns | 4.1932 ns | 0.2298 ns |  1.899 ns |  1.00 |    0.13 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.657 ns | 1.4576 ns | 0.0799 ns |  3.703 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.557 ns | 0.1790 ns | 0.0098 ns |  3.556 ns |  0.97 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 22.982 ns | 1.6832 ns | 0.0923 ns | 23.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 | 18.772 ns | 0.8271 ns | 0.0453 ns | 18.780 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  1.195 ns | 0.2264 ns | 0.0124 ns |  1.194 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  1.226 ns | 0.8728 ns | 0.0478 ns |  1.211 ns |  1.03 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |  4.208 ns | 0.4342 ns | 0.0238 ns |  4.212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |  3.525 ns | 0.1871 ns | 0.0103 ns |  3.523 ns |  0.84 |    0.01 |      - |     - |     - |         - |
