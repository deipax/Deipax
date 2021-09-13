
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.7458 ns | 0.7020 ns | 0.0385 ns |  1.7546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  1.4506 ns | 0.8951 ns | 0.0491 ns |  1.4288 ns |  0.83 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  4.4258 ns | 0.6162 ns | 0.0338 ns |  4.4103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  4.0206 ns | 0.1208 ns | 0.0066 ns |  4.0204 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  1.5129 ns | 2.6219 ns | 0.1437 ns |  1.5709 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.5455 ns | 0.7966 ns | 0.0437 ns |  1.5686 ns |  1.03 |    0.12 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.2432 ns | 0.1254 ns | 0.0069 ns |  4.2400 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  4.2578 ns | 0.1242 ns | 0.0068 ns |  4.2540 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  1.5561 ns | 0.3717 ns | 0.0204 ns |  1.5458 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  1.3784 ns | 0.5234 ns | 0.0287 ns |  1.3688 ns |  0.89 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.4284 ns | 0.4613 ns | 0.0253 ns |  4.4152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.2814 ns | 0.2222 ns | 0.0122 ns |  4.2858 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  1.4471 ns | 0.7666 ns | 0.0420 ns |  1.4327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.4547 ns | 0.8585 ns | 0.0471 ns |  1.4414 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.2225 ns | 0.6883 ns | 0.0377 ns |  4.2017 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  4.2552 ns | 0.1914 ns | 0.0105 ns |  4.2537 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.6796 ns | 0.3526 ns | 0.0193 ns |  2.6812 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.5759 ns | 0.3354 ns | 0.0184 ns |  1.5859 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.7796 ns | 2.2440 ns | 0.1230 ns |  4.7275 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.2311 ns | 0.2419 ns | 0.0133 ns |  4.2374 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  1.7747 ns | 0.3870 ns | 0.0212 ns |  1.7672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.5868 ns | 1.1669 ns | 0.0640 ns |  1.5991 ns |  0.89 |    0.05 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.2502 ns | 0.3568 ns | 0.0196 ns |  4.2593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  4.2420 ns | 0.1478 ns | 0.0081 ns |  4.2380 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.4588 ns | 0.7142 ns | 0.0392 ns |  1.4439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  1.4288 ns | 0.5071 ns | 0.0278 ns |  1.4173 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.0323 ns | 0.1479 ns | 0.0081 ns |  4.0347 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  4.0339 ns | 0.1856 ns | 0.0102 ns |  4.0348 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.5682 ns | 0.1656 ns | 0.0091 ns |  1.5667 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.2665 ns | 0.6016 ns | 0.0330 ns |  1.2520 ns |  0.81 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  1.1599 ns | 0.0523 ns | 0.0029 ns |  1.1593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  0.9555 ns | 0.4586 ns | 0.0251 ns |  0.9528 ns |  0.82 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  1.3085 ns | 0.3051 ns | 0.0167 ns |  1.3132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  1.3375 ns | 0.8220 ns | 0.0451 ns |  1.3214 ns |  1.02 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  2.1475 ns | 0.4455 ns | 0.0244 ns |  2.1365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  2.1249 ns | 0.5860 ns | 0.0321 ns |  2.1066 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.5572 ns | 0.3498 ns | 0.0192 ns |  1.5511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.5766 ns | 0.2960 ns | 0.0162 ns |  1.5688 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  2.1426 ns | 0.8632 ns | 0.0473 ns |  2.1160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.9728 ns | 0.7876 ns | 0.0432 ns |  1.9592 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.6917 ns | 1.1455 ns | 0.0628 ns |  1.6564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.6166 ns | 0.2267 ns | 0.0124 ns |  1.6106 ns |  0.96 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.6853 ns | 0.2501 ns | 0.0137 ns |  4.6928 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  4.7145 ns | 0.1373 ns | 0.0075 ns |  4.7149 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.4739 ns | 1.6474 ns | 0.0903 ns |  1.4460 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.6419 ns | 0.5243 ns | 0.0287 ns |  1.6545 ns |  1.12 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.8865 ns | 0.6130 ns | 0.0336 ns |  1.8694 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  2.0530 ns | 0.4173 ns | 0.0229 ns |  2.0614 ns |  1.09 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  6.0665 ns | 0.2238 ns | 0.0123 ns |  6.0733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.7376 ns | 0.1855 ns | 0.0102 ns |  1.7429 ns |  0.29 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.8411 ns | 0.5389 ns | 0.0295 ns | 12.8286 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  8.1935 ns | 0.3143 ns | 0.0172 ns |  8.2021 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  2.1914 ns | 0.2157 ns | 0.0118 ns |  2.1939 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  2.1564 ns | 0.5320 ns | 0.0292 ns |  2.1467 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.3331 ns | 0.9786 ns | 0.0536 ns |  2.3366 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.7543 ns | 0.1560 ns | 0.0086 ns |  1.7502 ns |  0.75 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  4.5556 ns | 1.6455 ns | 0.0902 ns |  4.5592 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.8770 ns | 0.9766 ns | 0.0535 ns |  3.9007 ns |  0.85 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 12.7889 ns | 2.0828 ns | 0.1142 ns | 12.8505 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.7665 ns | 1.3803 ns | 0.0757 ns |  3.7734 ns |  0.29 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  8.2778 ns | 0.1033 ns | 0.0057 ns |  8.2787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.6803 ns | 0.3650 ns | 0.0200 ns |  7.6869 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.9672 ns | 0.4881 ns | 0.0268 ns | 12.9621 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.9859 ns | 2.1828 ns | 0.1196 ns | 11.9905 ns |  0.92 |    0.01 |      - |     - |     - |         - |
