
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.177 ns | 0.4593 ns | 0.0252 ns |  1.185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.160 ns | 0.0327 ns | 0.0018 ns |  1.159 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.195 ns | 0.1007 ns | 0.0055 ns |  4.193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.515 ns | 0.4328 ns | 0.0237 ns |  3.524 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.138 ns | 0.4257 ns | 0.0233 ns |  1.130 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.174 ns | 0.1132 ns | 0.0062 ns |  1.171 ns |  1.03 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  3.997 ns | 0.2966 ns | 0.0163 ns |  3.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.755 ns | 0.3705 ns | 0.0203 ns |  3.754 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.664 ns | 3.0592 ns | 0.1677 ns |  1.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.481 ns | 0.4156 ns | 0.0228 ns |  1.478 ns |  0.90 |    0.09 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  3.977 ns | 0.5589 ns | 0.0306 ns |  3.979 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  3.755 ns | 0.1665 ns | 0.0091 ns |  3.760 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.498 ns | 0.2005 ns | 0.0110 ns |  1.494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.581 ns | 0.7705 ns | 0.0422 ns |  1.566 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  3.972 ns | 0.4326 ns | 0.0237 ns |  3.962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.760 ns | 0.2229 ns | 0.0122 ns |  3.759 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.483 ns | 0.2161 ns | 0.0118 ns |  1.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.448 ns | 0.3446 ns | 0.0189 ns |  1.439 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  3.974 ns | 0.4587 ns | 0.0251 ns |  3.988 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  3.761 ns | 0.1062 ns | 0.0058 ns |  3.760 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.517 ns | 1.4755 ns | 0.0809 ns |  1.487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.534 ns | 0.0873 ns | 0.0048 ns |  1.533 ns |  1.01 |    0.06 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  3.997 ns | 0.1157 ns | 0.0063 ns |  3.999 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.763 ns | 0.0679 ns | 0.0037 ns |  3.763 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.463 ns | 0.3013 ns | 0.0165 ns |  1.457 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.524 ns | 1.2000 ns | 0.0658 ns |  1.490 ns |  1.04 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.988 ns | 0.2482 ns | 0.0136 ns |  3.983 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.752 ns | 0.3988 ns | 0.0219 ns |  3.753 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.488 ns | 0.2643 ns | 0.0145 ns |  1.491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.476 ns | 0.4312 ns | 0.0236 ns |  1.472 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.332 ns | 0.1561 ns | 0.0086 ns |  4.329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.738 ns | 0.2117 ns | 0.0116 ns |  3.734 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.733 ns | 0.4316 ns | 0.0237 ns |  1.721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.503 ns | 1.0833 ns | 0.0594 ns |  1.509 ns |  0.87 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.919 ns | 1.4994 ns | 0.0822 ns |  1.882 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.161 ns | 0.3831 ns | 0.0210 ns |  2.150 ns |  1.13 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.452 ns | 0.0914 ns | 0.0050 ns |  1.450 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.468 ns | 0.3291 ns | 0.0180 ns |  1.477 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.019 ns | 0.3587 ns | 0.0197 ns |  2.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.958 ns | 0.0727 ns | 0.0040 ns |  1.958 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.473 ns | 0.5151 ns | 0.0282 ns |  1.477 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.513 ns | 0.3933 ns | 0.0216 ns |  1.513 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.233 ns | 0.2866 ns | 0.0157 ns |  4.240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  3.980 ns | 0.0906 ns | 0.0050 ns |  3.982 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.503 ns | 0.8267 ns | 0.0453 ns |  1.478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.490 ns | 0.2143 ns | 0.0117 ns |  1.495 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.418 ns | 2.1651 ns | 0.1187 ns |  2.412 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.230 ns | 0.6761 ns | 0.0371 ns |  2.215 ns |  0.92 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.806 ns | 0.1959 ns | 0.0107 ns |  5.800 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.222 ns | 0.8766 ns | 0.0480 ns |  2.240 ns |  0.38 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.769 ns | 0.3875 ns | 0.0212 ns | 12.774 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.734 ns | 0.8745 ns | 0.0479 ns |  7.706 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.345 ns | 0.9703 ns | 0.0532 ns |  2.317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.362 ns | 0.7311 ns | 0.0401 ns |  2.347 ns |  1.01 |    0.04 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.067 ns | 2.0417 ns | 0.1119 ns |  2.015 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  2.164 ns | 0.0889 ns | 0.0049 ns |  2.166 ns |  1.05 |    0.05 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.744 ns | 0.7165 ns | 0.0393 ns |  3.752 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.822 ns | 1.6164 ns | 0.0886 ns |  3.771 ns |  1.02 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 |  2.648 ns | 0.2319 ns | 0.0127 ns |  2.641 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.060 ns | 0.0328 ns | 0.0018 ns |  3.059 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.298 ns | 0.2448 ns | 0.0134 ns |  8.301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.658 ns | 0.0628 ns | 0.0034 ns |  7.660 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |           |           |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.687 ns | 1.8997 ns | 0.1041 ns | 12.656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.605 ns | 0.9307 ns | 0.0510 ns | 11.633 ns |  0.91 |    0.01 |      - |     - |     - |         - |
