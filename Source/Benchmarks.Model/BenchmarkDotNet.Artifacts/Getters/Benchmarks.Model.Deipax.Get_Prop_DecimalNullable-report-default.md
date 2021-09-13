
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |      Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  9.404 ns |  1.3256 ns | 0.0727 ns |  9.445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  7.533 ns |  1.2003 ns | 0.0658 ns |  7.506 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 13.551 ns |  0.5176 ns | 0.0284 ns | 13.558 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 11.331 ns |  1.7859 ns | 0.0979 ns | 11.358 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.130 ns |  0.3953 ns | 0.0217 ns |  1.118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.171 ns |  0.1135 ns | 0.0062 ns |  1.170 ns |  1.04 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.014 ns |  3.5062 ns | 0.1922 ns |  3.905 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.804 ns |  0.3242 ns | 0.0178 ns |  3.813 ns |  0.95 |    0.04 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 | 12.071 ns |  1.8749 ns | 0.1028 ns | 12.081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  9.069 ns |  1.0194 ns | 0.0559 ns |  9.076 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 15.544 ns |  0.9408 ns | 0.0516 ns | 15.532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 12.079 ns |  2.0930 ns | 0.1147 ns | 12.049 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 | 11.890 ns |  2.5406 ns | 0.1393 ns | 11.821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  8.917 ns |  1.6670 ns | 0.0914 ns |  8.892 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 | 15.565 ns |  1.0730 ns | 0.0588 ns | 15.569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 12.103 ns |  1.5252 ns | 0.0836 ns | 12.139 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 | 12.050 ns |  0.3602 ns | 0.0197 ns | 12.057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  8.945 ns |  0.5460 ns | 0.0299 ns |  8.933 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 | 15.468 ns |  1.7555 ns | 0.0962 ns | 15.518 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 12.237 ns |  1.8079 ns | 0.0991 ns | 12.197 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 | 13.236 ns | 23.3368 ns | 1.2792 ns | 12.612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  8.954 ns |  1.0918 ns | 0.0598 ns |  8.988 ns |  0.68 |    0.06 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 15.379 ns |  0.8336 ns | 0.0457 ns | 15.401 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 12.372 ns |  0.6657 ns | 0.0365 ns | 12.389 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 | 11.308 ns |  0.4469 ns | 0.0245 ns | 11.298 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  8.460 ns |  0.4842 ns | 0.0265 ns |  8.450 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 | 15.139 ns |  0.9795 ns | 0.0537 ns | 15.111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 11.712 ns |  3.0985 ns | 0.1698 ns | 11.632 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 | 11.238 ns |  0.7451 ns | 0.0408 ns | 11.226 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  8.671 ns |  6.1615 ns | 0.3377 ns |  8.500 ns |  0.77 |    0.03 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 15.035 ns |  0.8144 ns | 0.0446 ns | 15.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 11.856 ns |  0.5435 ns | 0.0298 ns | 11.870 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 | 11.291 ns |  0.4828 ns | 0.0265 ns | 11.277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  8.489 ns |  1.2563 ns | 0.0689 ns |  8.453 ns |  0.75 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 | 13.051 ns |  8.2528 ns | 0.4524 ns | 12.855 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 10.056 ns |  0.4808 ns | 0.0264 ns | 10.059 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 | 11.051 ns |  0.5158 ns | 0.0283 ns | 11.051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  8.251 ns |  0.3065 ns | 0.0168 ns |  8.251 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 | 12.687 ns |  1.8222 ns | 0.0999 ns | 12.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  9.957 ns |  1.2541 ns | 0.0687 ns |  9.962 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 | 17.186 ns |  0.8683 ns | 0.0476 ns | 17.163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  4.677 ns |  1.8410 ns | 0.1009 ns |  4.626 ns |  0.27 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 20.426 ns |  1.0582 ns | 0.0580 ns | 20.403 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  7.037 ns |  1.3489 ns | 0.0739 ns |  7.052 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 | 16.391 ns |  1.9190 ns | 0.1052 ns | 16.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  4.480 ns |  0.4611 ns | 0.0253 ns |  4.493 ns |  0.27 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 17.606 ns |  1.3604 ns | 0.0746 ns | 17.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  5.336 ns |  1.0651 ns | 0.0584 ns |  5.331 ns |  0.30 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  2.036 ns |  0.4552 ns | 0.0250 ns |  2.027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.958 ns |  1.0535 ns | 0.0577 ns |  1.932 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |  1.760 ns |  0.2563 ns | 0.0141 ns |  1.752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  1.919 ns |  0.5687 ns | 0.0312 ns |  1.926 ns |  1.09 |    0.02 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.290 ns |  0.0985 ns | 0.0054 ns |  2.289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.169 ns |  0.5655 ns | 0.0310 ns |  2.156 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  1.955 ns |  0.1311 ns | 0.0072 ns |  1.955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.666 ns |  0.2762 ns | 0.0151 ns |  1.659 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.596 ns |  0.8888 ns | 0.0487 ns |  4.605 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 5.0 |  4.199 ns |  1.0435 ns | 0.0572 ns |  4.180 ns |  0.91 |    0.02 | 0.0051 |     - |     - |      32 B |
                    |               |           |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 51.039 ns |  1.6211 ns | 0.0889 ns | 51.039 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 5.0 | 37.241 ns |  6.5487 ns | 0.3590 ns | 37.050 ns |  0.73 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |           |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 | 24.305 ns |  0.9374 ns | 0.0514 ns | 24.319 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 16.360 ns |  2.7511 ns | 0.1508 ns | 16.441 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |           |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 27.810 ns |  2.7497 ns | 0.1507 ns | 27.818 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 20.019 ns |  1.3558 ns | 0.0743 ns | 20.002 ns |  0.72 |    0.00 |      - |     - |     - |         - |
