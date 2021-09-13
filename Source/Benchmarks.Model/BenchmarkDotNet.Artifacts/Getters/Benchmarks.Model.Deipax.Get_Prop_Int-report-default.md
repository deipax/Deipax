
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |  1.2047 ns | 0.1395 ns | 0.0076 ns |  1.2047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |  0.9528 ns | 0.1955 ns | 0.0107 ns |  0.9490 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |  3.9474 ns | 1.4275 ns | 0.0782 ns |  3.9026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |  3.7907 ns | 0.3626 ns | 0.0199 ns |  3.7961 ns |  0.96 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |  2.4736 ns | 0.0899 ns | 0.0049 ns |  2.4727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |  1.1974 ns | 0.4006 ns | 0.0220 ns |  1.1906 ns |  0.48 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |  4.3881 ns | 0.1675 ns | 0.0092 ns |  4.3829 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |  3.7838 ns | 0.3392 ns | 0.0186 ns |  3.7884 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |  2.4754 ns | 0.3675 ns | 0.0201 ns |  2.4860 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |  2.1975 ns | 0.1730 ns | 0.0095 ns |  2.1940 ns |  0.89 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |  4.4331 ns | 0.2986 ns | 0.0164 ns |  4.4314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |  4.2761 ns | 1.0342 ns | 0.0567 ns |  4.2704 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |  2.2213 ns | 1.8489 ns | 0.1013 ns |  2.1858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |  1.0336 ns | 0.1071 ns | 0.0059 ns |  1.0346 ns |  0.47 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |  4.4435 ns | 0.6014 ns | 0.0330 ns |  4.4619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |  3.7688 ns | 0.5529 ns | 0.0303 ns |  3.7787 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |  2.1540 ns | 0.0812 ns | 0.0045 ns |  2.1531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |  1.9460 ns | 0.0889 ns | 0.0049 ns |  1.9440 ns |  0.90 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |  4.4557 ns | 0.3735 ns | 0.0205 ns |  4.4586 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |  4.3520 ns | 3.1324 ns | 0.1717 ns |  4.2808 ns |  0.98 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |  2.2677 ns | 0.6587 ns | 0.0361 ns |  2.2622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |  1.1814 ns | 0.1579 ns | 0.0087 ns |  1.1797 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |  4.4537 ns | 0.2112 ns | 0.0116 ns |  4.4554 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |  3.7820 ns | 0.3045 ns | 0.0167 ns |  3.7870 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |  1.1185 ns | 0.1094 ns | 0.0060 ns |  1.1164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |  0.9415 ns | 0.2563 ns | 0.0140 ns |  0.9362 ns |  0.84 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |  4.1910 ns | 0.6909 ns | 0.0379 ns |  4.2039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |  3.5635 ns | 0.1262 ns | 0.0069 ns |  3.5608 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |  1.0419 ns | 0.7599 ns | 0.0417 ns |  1.0277 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |  1.1933 ns | 0.5611 ns | 0.0308 ns |  1.2087 ns |  1.15 |    0.07 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |  3.8005 ns | 0.3096 ns | 0.0170 ns |  3.7984 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |  3.5893 ns | 0.1802 ns | 0.0099 ns |  3.5840 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |  0.9626 ns | 0.2627 ns | 0.0144 ns |  0.9582 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |  0.9506 ns | 0.3007 ns | 0.0165 ns |  0.9414 ns |  0.99 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |  1.8756 ns | 0.6890 ns | 0.0378 ns |  1.8612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |  1.8615 ns | 0.1670 ns | 0.0092 ns |  1.8636 ns |  0.99 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |  1.0072 ns | 0.0838 ns | 0.0046 ns |  1.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |  1.0564 ns | 1.3816 ns | 0.0757 ns |  1.0472 ns |  1.05 |    0.08 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |  1.9053 ns | 0.7560 ns | 0.0414 ns |  1.8889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |  1.8305 ns | 0.5370 ns | 0.0294 ns |  1.8254 ns |  0.96 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |  1.2098 ns | 0.1528 ns | 0.0084 ns |  1.2101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |  1.1819 ns | 0.1324 ns | 0.0073 ns |  1.1794 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |  4.2567 ns | 0.1542 ns | 0.0085 ns |  4.2580 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |  3.9965 ns | 0.2752 ns | 0.0151 ns |  3.9970 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |  1.3079 ns | 1.2406 ns | 0.0680 ns |  1.2821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |  1.1343 ns | 0.6788 ns | 0.0372 ns |  1.1279 ns |  0.87 |    0.06 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |  1.9086 ns | 0.7476 ns | 0.0410 ns |  1.8853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |  1.7286 ns | 0.7007 ns | 0.0384 ns |  1.7425 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |  5.8644 ns | 0.2771 ns | 0.0152 ns |  5.8697 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |  1.9012 ns | 0.5735 ns | 0.0314 ns |  1.8845 ns |  0.32 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 12.8294 ns | 0.3847 ns | 0.0211 ns | 12.8315 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |  7.5326 ns | 0.4914 ns | 0.0269 ns |  7.5437 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |  1.9737 ns | 0.1829 ns | 0.0100 ns |  1.9713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |  1.9950 ns | 0.3491 ns | 0.0191 ns |  1.9942 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |  2.0052 ns | 0.3147 ns | 0.0172 ns |  1.9964 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |  1.6064 ns | 0.1320 ns | 0.0072 ns |  1.6085 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |  3.7533 ns | 0.5110 ns | 0.0280 ns |  3.7651 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |  3.5332 ns | 0.8178 ns | 0.0448 ns |  3.5081 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 13.1451 ns | 9.7470 ns | 0.5343 ns | 13.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 5.0 |  3.2468 ns | 0.6133 ns | 0.0336 ns |  3.2339 ns |  0.25 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |  7.9842 ns | 1.2113 ns | 0.0664 ns |  8.0212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |  7.4996 ns | 0.3978 ns | 0.0218 ns |  7.4880 ns |  0.94 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 12.4519 ns | 0.9638 ns | 0.0528 ns | 12.4414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 11.3672 ns | 1.8266 ns | 0.1001 ns | 11.4066 ns |  0.91 |    0.01 |      - |     - |     - |         - |
