
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |        Mean |      Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|-----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 |   1.1931 ns |  0.4493 ns | 0.0246 ns |   1.1969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 5.0 |   0.9817 ns |  0.4000 ns | 0.0219 ns |   0.9718 ns |  0.82 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 3.1 |   4.7702 ns |  0.2643 ns | 0.0145 ns |   4.7753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 |   3.8001 ns |  0.3244 ns | 0.0178 ns |   3.7994 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 3.1 |   1.1720 ns |  0.2439 ns | 0.0134 ns |   1.1721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 5.0 |   1.0323 ns |  1.2805 ns | 0.0702 ns |   0.9933 ns |  0.88 |    0.07 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 3.1 |   4.7708 ns |  0.2702 ns | 0.0148 ns |   4.7655 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 |   3.7761 ns |  0.2801 ns | 0.0154 ns |   3.7684 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 3.1 |   1.2742 ns |  0.6085 ns | 0.0334 ns |   1.2622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 5.0 |   0.9711 ns |  0.4757 ns | 0.0261 ns |   0.9774 ns |  0.76 |    0.04 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 3.1 |   4.7318 ns |  0.3378 ns | 0.0185 ns |   4.7340 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 |   3.7642 ns |  0.2995 ns | 0.0164 ns |   3.7646 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 3.1 |   1.2757 ns |  0.6146 ns | 0.0337 ns |   1.2606 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 5.0 |   0.9645 ns |  0.0640 ns | 0.0035 ns |   0.9634 ns |  0.76 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 3.1 |   4.7483 ns |  0.1112 ns | 0.0061 ns |   4.7514 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 |   3.7737 ns |  0.3916 ns | 0.0215 ns |   3.7811 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 3.1 |   1.1975 ns |  0.2434 ns | 0.0133 ns |   1.2007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 5.0 |   0.9620 ns |  0.0869 ns | 0.0048 ns |   0.9645 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 3.1 |   4.9450 ns |  0.4519 ns | 0.0248 ns |   4.9526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 |   3.7865 ns |  0.4985 ns | 0.0273 ns |   3.8013 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 3.1 |   1.3460 ns |  0.1758 ns | 0.0096 ns |   1.3431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 5.0 |   0.9786 ns |  0.2781 ns | 0.0152 ns |   0.9707 ns |  0.73 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 3.1 |   4.7348 ns |  0.3252 ns | 0.0178 ns |   4.7349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 |   3.7901 ns |  0.2487 ns | 0.0136 ns |   3.7947 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 3.1 |   1.3081 ns |  1.2487 ns | 0.0684 ns |   1.2828 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 5.0 |   0.9759 ns |  0.6302 ns | 0.0345 ns |   0.9756 ns |  0.75 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 3.1 |   4.7257 ns |  0.8812 ns | 0.0483 ns |   4.7290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 |   3.7882 ns |  0.0720 ns | 0.0039 ns |   3.7876 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 3.1 |   1.2933 ns |  0.7377 ns | 0.0404 ns |   1.2871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 5.0 |   0.9785 ns |  0.4833 ns | 0.0265 ns |   0.9672 ns |  0.76 |    0.04 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 3.1 |   4.7639 ns |  0.3198 ns | 0.0175 ns |   4.7556 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 |   3.7613 ns |  0.5490 ns | 0.0301 ns |   3.7473 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 3.1 |   1.1671 ns |  0.2220 ns | 0.0122 ns |   1.1601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 5.0 |   0.9952 ns |  0.7791 ns | 0.0427 ns |   0.9884 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 3.1 |   1.7864 ns |  0.6391 ns | 0.0350 ns |   1.7723 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 |   1.6615 ns |  0.1933 ns | 0.0106 ns |   1.6560 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 3.1 |   1.1637 ns |  0.1986 ns | 0.0109 ns |   1.1585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 5.0 |   0.9689 ns |  0.0303 ns | 0.0017 ns |   0.9691 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 3.1 |   1.7841 ns |  0.0697 ns | 0.0038 ns |   1.7861 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 |   1.6627 ns |  0.6424 ns | 0.0352 ns |   1.6452 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 3.1 |   1.1794 ns |  0.7197 ns | 0.0394 ns |   1.1808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 5.0 |   1.1905 ns |  0.3533 ns | 0.0194 ns |   1.1831 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 3.1 |   4.7559 ns |  0.2436 ns | 0.0134 ns |   4.7622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 |   3.7969 ns |  0.2244 ns | 0.0123 ns |   3.7908 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 3.1 |   1.3456 ns |  0.0197 ns | 0.0011 ns |   1.3455 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 5.0 |   0.9766 ns |  0.0789 ns | 0.0043 ns |   0.9788 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 3.1 |   1.7973 ns |  0.0610 ns | 0.0033 ns |   1.7992 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 |   1.7242 ns |  1.8294 ns | 0.1003 ns |   1.6841 ns |  0.96 |    0.06 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 3.1 |   3.0030 ns |  0.1177 ns | 0.0064 ns |   3.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 |   2.7063 ns |  0.2477 ns | 0.0136 ns |   2.7008 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 3.1 |   1.8401 ns |  0.2810 ns | 0.0154 ns |   1.8372 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 |   1.6880 ns |  0.0848 ns | 0.0046 ns |   1.6888 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 3.1 |   1.7776 ns |  0.9973 ns | 0.0547 ns |   1.7497 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 |   1.2758 ns |  0.2847 ns | 0.0156 ns |   1.2724 ns |  0.72 |    0.03 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 |   1.5358 ns |  0.4657 ns | 0.0255 ns |   1.5235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 |   1.6721 ns |  0.3155 ns | 0.0173 ns |   1.6712 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 3.1 |   4.4484 ns |  1.0171 ns | 0.0558 ns |   4.4658 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 5.0 |   3.9083 ns |  1.2940 ns | 0.0709 ns |   3.9148 ns |  0.88 |    0.03 | 0.0038 |     - |     - |      24 B |
                    |               |             |            |           |             |       |         |        |       |       |           |
          To_String | .NET Core 3.1 | 227.4053 ns | 92.1725 ns | 5.0523 ns | 225.3287 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
          To_String | .NET Core 5.0 | 222.8986 ns | 17.6453 ns | 0.9672 ns | 223.3468 ns |  0.98 |    0.03 | 0.0100 |     - |     - |      64 B |
                    |               |             |            |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 3.1 |   7.9312 ns |  1.3774 ns | 0.0755 ns |   7.9306 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 5.0 |   4.6093 ns |  1.2160 ns | 0.0667 ns |   4.5784 ns |  0.58 |    0.01 |      - |     - |     - |         - |
                    |               |             |            |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 3.1 |   8.1342 ns |  0.5394 ns | 0.0296 ns |   8.1208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 |   4.8852 ns |  0.2307 ns | 0.0126 ns |   4.8892 ns |  0.60 |    0.00 |      - |     - |     - |         - |
