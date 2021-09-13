
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.333 ns | 0.1759 ns | 0.0096 ns | 1.338 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.520 ns | 0.2355 ns | 0.0129 ns | 1.513 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.213 ns | 0.2609 ns | 0.0143 ns | 4.211 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 4.004 ns | 0.4022 ns | 0.0220 ns | 4.014 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.317 ns | 2.0439 ns | 0.1120 ns | 1.374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.181 ns | 0.6373 ns | 0.0349 ns | 1.163 ns |  0.90 |    0.07 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.226 ns | 0.5132 ns | 0.0281 ns | 4.239 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.791 ns | 0.2740 ns | 0.0150 ns | 3.795 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.296 ns | 0.1074 ns | 0.0059 ns | 1.294 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.567 ns | 0.5367 ns | 0.0294 ns | 1.552 ns |  1.21 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.211 ns | 0.4083 ns | 0.0224 ns | 4.214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 4.044 ns | 1.0681 ns | 0.0585 ns | 4.034 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.485 ns | 2.1486 ns | 0.1178 ns | 1.549 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.551 ns | 0.1256 ns | 0.0069 ns | 1.550 ns |  1.05 |    0.09 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.174 ns | 0.2503 ns | 0.0137 ns | 4.175 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.992 ns | 0.0472 ns | 0.0026 ns | 3.992 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.421 ns | 0.4363 ns | 0.0239 ns | 1.413 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.715 ns | 0.8741 ns | 0.0479 ns | 1.740 ns |  1.21 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 4.234 ns | 0.0964 ns | 0.0053 ns | 4.233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 4.029 ns | 0.1577 ns | 0.0086 ns | 4.025 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.290 ns | 0.2047 ns | 0.0112 ns | 1.291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.716 ns | 0.9421 ns | 0.0516 ns | 1.697 ns |  1.33 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.234 ns | 0.3919 ns | 0.0215 ns | 4.234 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.982 ns | 1.0168 ns | 0.0557 ns | 4.004 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.326 ns | 0.9487 ns | 0.0520 ns | 1.297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.720 ns | 0.4503 ns | 0.0247 ns | 1.728 ns |  1.30 |    0.07 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.275 ns | 0.3199 ns | 0.0175 ns | 4.280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 4.006 ns | 1.3094 ns | 0.0718 ns | 3.992 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.448 ns | 0.1170 ns | 0.0064 ns | 1.447 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.723 ns | 0.5877 ns | 0.0322 ns | 1.733 ns |  1.19 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.225 ns | 0.5503 ns | 0.0302 ns | 4.231 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 4.005 ns | 0.4899 ns | 0.0269 ns | 3.993 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.470 ns | 0.5508 ns | 0.0302 ns | 1.477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.576 ns | 0.7315 ns | 0.0401 ns | 1.558 ns |  1.07 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.075 ns | 0.6410 ns | 0.0351 ns | 2.059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.450 ns | 1.0468 ns | 0.0574 ns | 2.463 ns |  1.18 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.495 ns | 0.4992 ns | 0.0274 ns | 1.485 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.556 ns | 0.1364 ns | 0.0075 ns | 1.557 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.211 ns | 1.2562 ns | 0.0689 ns | 2.174 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.511 ns | 0.2238 ns | 0.0123 ns | 2.510 ns |  1.14 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.497 ns | 0.3918 ns | 0.0215 ns | 1.509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.750 ns | 0.1256 ns | 0.0069 ns | 1.749 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.282 ns | 0.5743 ns | 0.0315 ns | 4.282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 3.979 ns | 0.4214 ns | 0.0231 ns | 3.973 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.361 ns | 0.4623 ns | 0.0253 ns | 1.357 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.766 ns | 0.7905 ns | 0.0433 ns | 1.774 ns |  1.30 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 1.827 ns | 0.5170 ns | 0.0283 ns | 1.819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 1.864 ns | 0.2561 ns | 0.0140 ns | 1.858 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.379 ns | 2.8761 ns | 0.1577 ns | 2.298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.617 ns | 0.8221 ns | 0.0451 ns | 2.619 ns |  1.10 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.552 ns | 0.7561 ns | 0.0414 ns | 2.574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.447 ns | 0.2649 ns | 0.0145 ns | 2.453 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.462 ns | 2.6513 ns | 0.1453 ns | 2.427 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.255 ns | 0.6399 ns | 0.0351 ns | 2.238 ns |  0.92 |    0.07 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 1.995 ns | 0.0886 ns | 0.0049 ns | 1.993 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.658 ns | 0.0515 ns | 0.0028 ns | 1.657 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.380 ns | 0.4754 ns | 0.0261 ns | 1.378 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.521 ns | 0.6036 ns | 0.0331 ns | 1.527 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.456 ns | 0.3997 ns | 0.0219 ns | 1.449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.522 ns | 0.5419 ns | 0.0297 ns | 1.507 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.337 ns | 0.7519 ns | 0.0412 ns | 1.324 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.662 ns | 0.0553 ns | 0.0030 ns | 1.663 ns |  1.24 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.240 ns | 0.2304 ns | 0.0126 ns | 4.245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 3.994 ns | 0.2527 ns | 0.0139 ns | 3.991 ns |  0.94 |    0.01 |     - |     - |     - |         - |
