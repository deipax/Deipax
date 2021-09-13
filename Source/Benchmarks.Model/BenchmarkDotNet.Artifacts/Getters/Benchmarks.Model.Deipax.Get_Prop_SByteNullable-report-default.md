
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.5475 ns | 0.8190 ns | 0.0449 ns |  1.5537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.3444 ns | 0.3221 ns | 0.0177 ns |  1.3347 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.2047 ns | 0.2104 ns | 0.0115 ns |  4.2105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.0181 ns | 0.2228 ns | 0.0122 ns |  4.0144 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.5085 ns | 0.1290 ns | 0.0071 ns |  1.5079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.3577 ns | 0.2686 ns | 0.0147 ns |  1.3617 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.4759 ns | 0.5587 ns | 0.0306 ns |  4.4916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.0023 ns | 0.2236 ns | 0.0123 ns |  4.0007 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.7276 ns | 2.4878 ns | 0.1364 ns |  1.8011 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.3281 ns | 1.4619 ns | 0.0801 ns |  1.3678 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  1.1222 ns | 0.1107 ns | 0.0061 ns |  1.1235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  0.9704 ns | 0.3497 ns | 0.0192 ns |  0.9727 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.8162 ns | 1.0296 ns | 0.0564 ns |  1.8207 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.5659 ns | 0.1265 ns | 0.0069 ns |  1.5697 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.2371 ns | 0.0772 ns | 0.0042 ns |  4.2365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.0243 ns | 0.3550 ns | 0.0195 ns |  4.0242 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  1.8018 ns | 1.1903 ns | 0.0652 ns |  1.7771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.4460 ns | 0.2074 ns | 0.0114 ns |  1.4524 ns |  0.80 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.1923 ns | 0.4404 ns | 0.0241 ns |  4.1995 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.2430 ns | 0.0287 ns | 0.0016 ns |  4.2437 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.8001 ns | 0.7164 ns | 0.0393 ns |  1.8156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.3263 ns | 0.0827 ns | 0.0045 ns |  1.3248 ns |  0.74 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.4422 ns | 0.5394 ns | 0.0296 ns |  4.4500 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.0002 ns | 0.2307 ns | 0.0126 ns |  4.0053 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.4898 ns | 0.2727 ns | 0.0149 ns |  1.4962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.4235 ns | 1.0886 ns | 0.0597 ns |  1.4393 ns |  0.96 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  3.9620 ns | 0.6535 ns | 0.0358 ns |  3.9670 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.1588 ns | 5.5643 ns | 0.3050 ns |  3.9951 ns |  1.05 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.6720 ns | 0.1444 ns | 0.0079 ns |  1.6759 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.4611 ns | 0.7799 ns | 0.0427 ns |  1.4388 ns |  0.87 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  4.2098 ns | 0.1499 ns | 0.0082 ns |  4.2089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  4.2450 ns | 0.1146 ns | 0.0063 ns |  4.2453 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.4852 ns | 0.9353 ns | 0.0513 ns |  1.4957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.3833 ns | 1.2111 ns | 0.0664 ns |  1.3549 ns |  0.93 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.1478 ns | 0.1960 ns | 0.0107 ns |  2.1431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.8638 ns | 1.6096 ns | 0.0882 ns |  1.8407 ns |  0.87 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.3495 ns | 0.3010 ns | 0.0165 ns |  1.3458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.4428 ns | 0.1677 ns | 0.0092 ns |  1.4474 ns |  1.07 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.1498 ns | 0.6183 ns | 0.0339 ns |  2.1342 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  2.0182 ns | 0.3307 ns | 0.0181 ns |  2.0085 ns |  0.94 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.5677 ns | 0.2981 ns | 0.0163 ns |  1.5661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.5733 ns | 2.3202 ns | 0.1272 ns |  1.5436 ns |  1.00 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.4434 ns | 0.2406 ns | 0.0132 ns |  4.4429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.2653 ns | 1.1954 ns | 0.0655 ns |  4.2296 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.7327 ns | 0.3677 ns | 0.0202 ns |  1.7409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.4768 ns | 0.2333 ns | 0.0128 ns |  1.4839 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  2.2553 ns | 0.7493 ns | 0.0411 ns |  2.2474 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.1331 ns | 0.3978 ns | 0.0218 ns |  2.1264 ns |  0.95 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.2918 ns | 0.2413 ns | 0.0132 ns |  6.2877 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  2.0687 ns | 0.5563 ns | 0.0305 ns |  2.0727 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 13.0973 ns | 1.4870 ns | 0.0815 ns | 13.0927 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.4367 ns | 0.5435 ns | 0.0298 ns |  8.4475 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.3680 ns | 0.3364 ns | 0.0184 ns |  2.3575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1633 ns | 0.6055 ns | 0.0332 ns |  2.1460 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0427 ns | 0.3973 ns | 0.0218 ns |  2.0367 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.6011 ns | 0.0142 ns | 0.0008 ns |  1.6012 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.2657 ns | 0.9669 ns | 0.0530 ns |  4.2393 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.8688 ns | 0.8263 ns | 0.0453 ns |  3.8801 ns |  0.91 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.7408 ns | 1.4408 ns | 0.0790 ns | 13.6964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  4.0553 ns | 2.7659 ns | 0.1516 ns |  4.0031 ns |  0.30 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.5588 ns | 0.3166 ns | 0.0174 ns |  8.5552 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.8467 ns | 1.1032 ns | 0.0605 ns |  7.8602 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 13.1035 ns | 1.1097 ns | 0.0608 ns | 13.0916 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.8633 ns | 1.0610 ns | 0.0582 ns | 11.8650 ns |  0.91 |    0.00 |      - |     - |     - |         - |
