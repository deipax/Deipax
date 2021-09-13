
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.623 ns | 2.1589 ns | 0.1183 ns | 1.571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.486 ns | 0.1650 ns | 0.0090 ns | 1.484 ns |  0.92 |    0.06 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 4.012 ns | 0.2916 ns | 0.0160 ns | 4.009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.827 ns | 0.5875 ns | 0.0322 ns | 3.821 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.166 ns | 0.5701 ns | 0.0312 ns | 1.152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.568 ns | 4.5081 ns | 0.2471 ns | 1.469 ns |  1.35 |    0.23 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 4.027 ns | 0.4416 ns | 0.0242 ns | 4.022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.693 ns | 0.2905 ns | 0.0159 ns | 3.687 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.508 ns | 0.2304 ns | 0.0126 ns | 1.503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.358 ns | 0.6591 ns | 0.0361 ns | 1.340 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 4.344 ns | 2.7525 ns | 0.1509 ns | 4.385 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 3.767 ns | 0.3633 ns | 0.0199 ns | 3.768 ns |  0.87 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.684 ns | 0.2145 ns | 0.0118 ns | 1.685 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.279 ns | 0.4109 ns | 0.0225 ns | 1.272 ns |  0.76 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.013 ns | 0.6191 ns | 0.0339 ns | 3.994 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.824 ns | 1.7056 ns | 0.0935 ns | 3.771 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.542 ns | 0.2402 ns | 0.0132 ns | 1.540 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.403 ns | 0.2586 ns | 0.0142 ns | 1.403 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 3.999 ns | 0.2888 ns | 0.0158 ns | 3.997 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.892 ns | 2.5492 ns | 0.1397 ns | 3.912 ns |  0.97 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 2.054 ns | 2.5179 ns | 0.1380 ns | 2.014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.403 ns | 0.5447 ns | 0.0299 ns | 1.398 ns |  0.69 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 3.974 ns | 1.3180 ns | 0.0722 ns | 3.953 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.778 ns | 0.5587 ns | 0.0306 ns | 3.764 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.428 ns | 0.1210 ns | 0.0066 ns | 1.428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.407 ns | 0.3868 ns | 0.0212 ns | 1.395 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 4.024 ns | 0.3504 ns | 0.0192 ns | 4.016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.784 ns | 0.2758 ns | 0.0151 ns | 3.780 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.629 ns | 0.2875 ns | 0.0158 ns | 1.629 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.598 ns | 1.2117 ns | 0.0664 ns | 1.564 ns |  0.98 |    0.05 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 4.003 ns | 1.0150 ns | 0.0556 ns | 3.980 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.737 ns | 0.2596 ns | 0.0142 ns | 3.733 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.674 ns | 0.2542 ns | 0.0139 ns | 1.667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.319 ns | 0.3224 ns | 0.0177 ns | 1.327 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.265 ns | 0.1900 ns | 0.0104 ns | 2.265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 1.925 ns | 0.2352 ns | 0.0129 ns | 1.929 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.520 ns | 0.1752 ns | 0.0096 ns | 1.516 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.263 ns | 0.3525 ns | 0.0193 ns | 1.267 ns |  0.83 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.768 ns | 1.2203 ns | 0.0669 ns | 1.751 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 1.655 ns | 0.2521 ns | 0.0138 ns | 1.654 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.543 ns | 0.8939 ns | 0.0490 ns | 1.537 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.308 ns | 0.0915 ns | 0.0050 ns | 1.307 ns |  0.85 |    0.03 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.246 ns | 0.3319 ns | 0.0182 ns | 4.237 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.036 ns | 0.3229 ns | 0.0177 ns | 4.035 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.508 ns | 0.4354 ns | 0.0239 ns | 1.499 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.351 ns | 0.5342 ns | 0.0293 ns | 1.339 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.336 ns | 0.1760 ns | 0.0096 ns | 2.334 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.447 ns | 1.5857 ns | 0.0869 ns | 2.486 ns |  1.05 |    0.04 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.465 ns | 0.0547 ns | 0.0030 ns | 2.465 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 1.986 ns | 0.7522 ns | 0.0412 ns | 1.966 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.568 ns | 0.9977 ns | 0.0547 ns | 2.582 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.306 ns | 0.3353 ns | 0.0184 ns | 2.307 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.452 ns | 0.5580 ns | 0.0306 ns | 2.436 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.166 ns | 0.6299 ns | 0.0345 ns | 2.181 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.142 ns | 0.2785 ns | 0.0153 ns | 2.141 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.600 ns | 0.2754 ns | 0.0151 ns | 1.595 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.489 ns | 0.1114 ns | 0.0061 ns | 1.491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.329 ns | 0.2495 ns | 0.0137 ns | 1.331 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.988 ns | 0.3442 ns | 0.0189 ns | 1.981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.347 ns | 0.1472 ns | 0.0081 ns | 1.344 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.802 ns | 3.1819 ns | 0.1744 ns | 1.803 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.518 ns | 2.9585 ns | 0.1622 ns | 1.440 ns |  0.85 |    0.17 |     - |     - |     - |         - |
                    |               |          |           |           |          |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 3.977 ns | 0.3132 ns | 0.0172 ns | 3.987 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.021 ns | 0.2337 ns | 0.0128 ns | 4.014 ns |  1.01 |    0.00 |     - |     - |     - |         - |
