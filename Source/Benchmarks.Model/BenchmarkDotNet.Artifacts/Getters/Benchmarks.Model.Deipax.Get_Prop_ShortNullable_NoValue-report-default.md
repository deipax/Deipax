
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.515 ns | 0.1410 ns | 0.0077 ns | 1.514 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.499 ns | 0.4386 ns | 0.0240 ns | 1.493 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 3.950 ns | 0.4795 ns | 0.0263 ns | 3.962 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.772 ns | 0.0798 ns | 0.0044 ns | 3.771 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.548 ns | 0.5695 ns | 0.0312 ns | 1.542 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.549 ns | 0.3900 ns | 0.0214 ns | 1.538 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 3.975 ns | 0.7024 ns | 0.0385 ns | 3.962 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.766 ns | 0.1815 ns | 0.0100 ns | 3.764 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.726 ns | 4.0589 ns | 0.2225 ns | 1.692 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.246 ns | 0.1390 ns | 0.0076 ns | 1.248 ns |  0.73 |    0.09 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.009 ns | 0.0873 ns | 0.0048 ns | 4.008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.754 ns | 0.3742 ns | 0.0205 ns | 3.764 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.504 ns | 0.2620 ns | 0.0144 ns | 1.501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.583 ns | 0.0212 ns | 0.0012 ns | 1.582 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 3.987 ns | 0.3200 ns | 0.0175 ns | 3.988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.771 ns | 0.2273 ns | 0.0125 ns | 3.770 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.494 ns | 0.0580 ns | 0.0032 ns | 1.492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.520 ns | 0.3640 ns | 0.0200 ns | 1.526 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 1.161 ns | 0.0695 ns | 0.0038 ns | 1.161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 1.160 ns | 0.1045 ns | 0.0057 ns | 1.162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.708 ns | 0.0537 ns | 0.0029 ns | 1.709 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.554 ns | 0.0477 ns | 0.0026 ns | 1.553 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 4.003 ns | 0.0849 ns | 0.0047 ns | 4.005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.821 ns | 0.5448 ns | 0.0299 ns | 3.837 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.481 ns | 0.0776 ns | 0.0043 ns | 1.480 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.299 ns | 0.6339 ns | 0.0347 ns | 1.306 ns |  0.88 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 3.992 ns | 0.2070 ns | 0.0113 ns | 3.987 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.764 ns | 0.1982 ns | 0.0109 ns | 3.765 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.711 ns | 0.9444 ns | 0.0518 ns | 1.712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.776 ns | 0.2297 ns | 0.0126 ns | 1.773 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.001 ns | 0.2053 ns | 0.0113 ns | 3.997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.746 ns | 0.0282 ns | 0.0015 ns | 3.747 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.670 ns | 0.1666 ns | 0.0091 ns | 1.672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.651 ns | 0.3289 ns | 0.0180 ns | 1.641 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.116 ns | 0.2198 ns | 0.0120 ns | 2.111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.198 ns | 0.5723 ns | 0.0314 ns | 2.213 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.565 ns | 0.8848 ns | 0.0485 ns | 1.548 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.726 ns | 0.1615 ns | 0.0089 ns | 1.725 ns |  1.10 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 2.028 ns | 0.0951 ns | 0.0052 ns | 2.029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.212 ns | 0.2261 ns | 0.0124 ns | 2.207 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.621 ns | 0.1644 ns | 0.0090 ns | 1.623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.407 ns | 1.5723 ns | 0.0862 ns | 1.365 ns |  0.87 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.226 ns | 0.2782 ns | 0.0152 ns | 4.224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.042 ns | 0.5955 ns | 0.0326 ns | 4.058 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.496 ns | 0.4557 ns | 0.0250 ns | 1.489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.329 ns | 0.2806 ns | 0.0154 ns | 1.326 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.270 ns | 0.9508 ns | 0.0521 ns | 2.245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.141 ns | 1.0995 ns | 0.0603 ns | 2.112 ns |  0.94 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.422 ns | 0.6650 ns | 0.0364 ns | 2.401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.341 ns | 1.9672 ns | 0.1078 ns | 2.360 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.460 ns | 1.2162 ns | 0.0667 ns | 2.438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.348 ns | 0.6735 ns | 0.0369 ns | 2.343 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.358 ns | 0.2690 ns | 0.0147 ns | 2.361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.378 ns | 0.3425 ns | 0.0188 ns | 2.381 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.041 ns | 1.1744 ns | 0.0644 ns | 2.018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.790 ns | 0.9634 ns | 0.0528 ns | 1.781 ns |  0.88 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.470 ns | 0.4204 ns | 0.0230 ns | 1.459 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.729 ns | 0.5635 ns | 0.0309 ns | 1.715 ns |  1.18 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.525 ns | 0.9118 ns | 0.0500 ns | 1.513 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.675 ns | 0.6467 ns | 0.0354 ns | 1.659 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.571 ns | 0.9862 ns | 0.0541 ns | 1.545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.548 ns | 1.5917 ns | 0.0872 ns | 1.498 ns |  0.99 |    0.08 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 4.001 ns | 0.0763 ns | 0.0042 ns | 4.002 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.034 ns | 0.9819 ns | 0.0538 ns | 4.045 ns |  1.01 |    0.01 |     - |     - |     - |         - |
