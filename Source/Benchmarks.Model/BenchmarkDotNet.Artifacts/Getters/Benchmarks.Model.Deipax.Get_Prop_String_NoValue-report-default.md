
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.7135 ns | 0.5754 ns | 0.0315 ns | 1.6982 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.7109 ns | 0.6674 ns | 0.0366 ns | 1.7174 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.0360 ns | 0.1135 ns | 0.0062 ns | 4.0393 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.9884 ns | 0.4856 ns | 0.0266 ns | 4.0001 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.8668 ns | 0.0621 ns | 0.0034 ns | 1.8649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.7080 ns | 0.8179 ns | 0.0448 ns | 1.7072 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.0211 ns | 0.4880 ns | 0.0267 ns | 4.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 4.1617 ns | 6.9684 ns | 0.3820 ns | 3.9424 ns |  1.04 |    0.10 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 2.0284 ns | 3.0451 ns | 0.1669 ns | 2.1056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.6939 ns | 0.6481 ns | 0.0355 ns | 1.7074 ns |  0.84 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 5.2095 ns | 0.2672 ns | 0.0146 ns | 5.2019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 4.6916 ns | 0.1362 ns | 0.0075 ns | 4.6937 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.6263 ns | 0.1471 ns | 0.0081 ns | 1.6230 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.5641 ns | 0.0973 ns | 0.0053 ns | 1.5659 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 5.2209 ns | 0.2269 ns | 0.0124 ns | 5.2153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 4.6634 ns | 0.3519 ns | 0.0193 ns | 4.6585 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.7186 ns | 0.0997 ns | 0.0055 ns | 1.7185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.7596 ns | 1.2960 ns | 0.0710 ns | 1.7392 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 5.1518 ns | 0.1014 ns | 0.0056 ns | 5.1501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 4.7178 ns | 0.4785 ns | 0.0262 ns | 4.7281 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.8691 ns | 0.4701 ns | 0.0258 ns | 1.8690 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.7052 ns | 0.0638 ns | 0.0035 ns | 1.7049 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 5.1669 ns | 0.1551 ns | 0.0085 ns | 5.1636 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 4.7107 ns | 0.0650 ns | 0.0036 ns | 4.7094 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 2.1278 ns | 3.2127 ns | 0.1761 ns | 2.2080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.8097 ns | 0.6724 ns | 0.0369 ns | 1.8200 ns |  0.85 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.9069 ns | 0.2236 ns | 0.0123 ns | 4.9137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 4.4309 ns | 0.4620 ns | 0.0253 ns | 4.4209 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.8260 ns | 0.2288 ns | 0.0125 ns | 1.8296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.6076 ns | 0.9123 ns | 0.0500 ns | 1.5824 ns |  0.88 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.8911 ns | 0.3092 ns | 0.0169 ns | 4.8826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 4.4671 ns | 0.4492 ns | 0.0246 ns | 4.4575 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.7433 ns | 0.0983 ns | 0.0054 ns | 1.7425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.9495 ns | 1.7764 ns | 0.0974 ns | 1.9345 ns |  1.12 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.4922 ns | 1.1037 ns | 0.0605 ns | 2.4706 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.9848 ns | 4.3140 ns | 0.2365 ns | 2.8916 ns |  1.20 |    0.07 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.9294 ns | 0.2299 ns | 0.0126 ns | 1.9228 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.5298 ns | 0.6912 ns | 0.0379 ns | 1.5437 ns |  0.79 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.4570 ns | 0.9384 ns | 0.0514 ns | 2.4285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.5279 ns | 0.3768 ns | 0.0207 ns | 2.5330 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.7937 ns | 0.2123 ns | 0.0116 ns | 1.7994 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.8138 ns | 1.6543 ns | 0.0907 ns | 1.8320 ns |  1.01 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 5.1098 ns | 5.9793 ns | 0.3277 ns | 4.9260 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.6989 ns | 0.5413 ns | 0.0297 ns | 4.7025 ns |  0.92 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.9324 ns | 0.0740 ns | 0.0041 ns | 1.9321 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.7553 ns | 0.1707 ns | 0.0094 ns | 1.7581 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.5360 ns | 0.9109 ns | 0.0499 ns | 2.5551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.5010 ns | 0.5745 ns | 0.0315 ns | 2.5040 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.5287 ns | 0.4898 ns | 0.0268 ns | 2.5319 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.3686 ns | 1.3076 ns | 0.0717 ns | 2.3690 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.3463 ns | 0.6953 ns | 0.0381 ns | 2.3596 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.5396 ns | 0.9038 ns | 0.0495 ns | 2.5470 ns |  1.08 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.7654 ns | 0.1526 ns | 0.0084 ns | 2.7616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.5433 ns | 0.6134 ns | 0.0336 ns | 2.5605 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.7579 ns | 0.1926 ns | 0.0106 ns | 2.7606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 2.4484 ns | 0.0581 ns | 0.0032 ns | 2.4466 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 0.9511 ns | 0.1343 ns | 0.0074 ns | 0.9506 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 0.9362 ns | 0.2524 ns | 0.0138 ns | 0.9306 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 0.9746 ns | 0.8947 ns | 0.0490 ns | 0.9472 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 0.9476 ns | 0.7197 ns | 0.0395 ns | 0.9487 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.7303 ns | 0.7005 ns | 0.0384 ns | 1.7124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.6734 ns | 0.6989 ns | 0.0383 ns | 1.6536 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.0105 ns | 0.4824 ns | 0.0264 ns | 4.0179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.0512 ns | 1.1433 ns | 0.0627 ns | 4.0158 ns |  1.01 |    0.01 |     - |     - |     - |         - |
