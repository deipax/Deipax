
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 3.1 | 1.5118 ns | 0.9870 ns | 0.0541 ns | 1.4837 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 5.0 | 1.2884 ns | 0.2574 ns | 0.0141 ns | 1.2841 ns |  0.85 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 3.1 | 3.9981 ns | 0.0549 ns | 0.0030 ns | 3.9986 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 5.0 | 3.7915 ns | 0.1111 ns | 0.0061 ns | 3.7916 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 3.1 | 1.4636 ns | 0.3303 ns | 0.0181 ns | 1.4586 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 5.0 | 1.3527 ns | 0.0065 ns | 0.0004 ns | 1.3528 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 3.1 | 3.9516 ns | 0.1455 ns | 0.0080 ns | 3.9545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 5.0 | 3.8018 ns | 0.3724 ns | 0.0204 ns | 3.8102 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 3.1 | 1.6236 ns | 0.9217 ns | 0.0505 ns | 1.6044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 5.0 | 1.4117 ns | 0.1232 ns | 0.0068 ns | 1.4122 ns |  0.87 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 3.1 | 1.1090 ns | 0.1351 ns | 0.0074 ns | 1.1087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 5.0 | 0.9994 ns | 1.0240 ns | 0.0561 ns | 0.9977 ns |  0.90 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 3.1 | 1.8782 ns | 1.5915 ns | 0.0872 ns | 1.9044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 5.0 | 1.5741 ns | 1.0205 ns | 0.0559 ns | 1.5515 ns |  0.84 |    0.07 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 3.1 | 4.0005 ns | 0.2265 ns | 0.0124 ns | 4.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 5.0 | 3.7837 ns | 0.3938 ns | 0.0216 ns | 3.7927 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 3.1 | 1.5677 ns | 0.4612 ns | 0.0253 ns | 1.5736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 5.0 | 1.4851 ns | 0.3211 ns | 0.0176 ns | 1.4894 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 3.1 | 3.9796 ns | 0.3160 ns | 0.0173 ns | 3.9814 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 5.0 | 3.7884 ns | 0.3809 ns | 0.0209 ns | 3.7862 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 3.1 | 1.7299 ns | 0.0644 ns | 0.0035 ns | 1.7280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 5.0 | 1.2884 ns | 0.5365 ns | 0.0294 ns | 1.2801 ns |  0.74 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 3.1 | 3.9750 ns | 0.0986 ns | 0.0054 ns | 3.9731 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 5.0 | 3.7691 ns | 0.1642 ns | 0.0090 ns | 3.7657 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 3.1 | 1.4799 ns | 0.0914 ns | 0.0050 ns | 1.4780 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 5.0 | 1.3806 ns | 0.7941 ns | 0.0435 ns | 1.3584 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 3.1 | 3.9866 ns | 0.1436 ns | 0.0079 ns | 3.9897 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 5.0 | 3.7965 ns | 0.1814 ns | 0.0099 ns | 3.8022 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 3.1 | 1.6274 ns | 0.4738 ns | 0.0260 ns | 1.6160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 5.0 | 1.4703 ns | 0.9662 ns | 0.0530 ns | 1.4736 ns |  0.90 |    0.05 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 3.1 | 3.9817 ns | 0.3831 ns | 0.0210 ns | 3.9720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 5.0 | 3.7890 ns | 0.2009 ns | 0.0110 ns | 3.7831 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 3.1 | 1.6267 ns | 0.6296 ns | 0.0345 ns | 1.6258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 5.0 | 1.3316 ns | 0.2106 ns | 0.0115 ns | 1.3375 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 3.1 | 2.1704 ns | 0.8559 ns | 0.0469 ns | 2.1754 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 5.0 | 2.0645 ns | 0.9628 ns | 0.0528 ns | 2.0349 ns |  0.95 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 3.1 | 1.4579 ns | 0.3640 ns | 0.0200 ns | 1.4515 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 5.0 | 1.4962 ns | 0.4921 ns | 0.0270 ns | 1.4909 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 3.1 | 1.9483 ns | 0.7251 ns | 0.0397 ns | 1.9288 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 5.0 | 2.0270 ns | 0.9162 ns | 0.0502 ns | 2.0120 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 3.1 | 1.6190 ns | 0.1113 ns | 0.0061 ns | 1.6210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 5.0 | 1.4929 ns | 0.5715 ns | 0.0313 ns | 1.5062 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 3.1 | 4.2451 ns | 0.1762 ns | 0.0097 ns | 4.2456 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 5.0 | 4.0246 ns | 0.0839 ns | 0.0046 ns | 4.0265 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 3.1 | 1.4899 ns | 0.4132 ns | 0.0226 ns | 1.4818 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 5.0 | 1.4875 ns | 1.5501 ns | 0.0850 ns | 1.4429 ns |  1.00 |    0.06 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 3.1 | 2.1788 ns | 0.1573 ns | 0.0086 ns | 2.1774 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 5.0 | 2.0744 ns | 0.5993 ns | 0.0329 ns | 2.0578 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 3.1 | 2.5947 ns | 2.6028 ns | 0.1427 ns | 2.6161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 5.0 | 2.0686 ns | 0.6499 ns | 0.0356 ns | 2.0554 ns |  0.80 |    0.03 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 3.1 | 2.5297 ns | 1.1466 ns | 0.0628 ns | 2.5029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 5.0 | 2.3567 ns | 0.7939 ns | 0.0435 ns | 2.3784 ns |  0.93 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 3.1 | 2.3375 ns | 0.2410 ns | 0.0132 ns | 2.3379 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 5.0 | 2.1392 ns | 0.3769 ns | 0.0207 ns | 2.1359 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 3.1 | 2.0094 ns | 0.4076 ns | 0.0223 ns | 2.0098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 5.0 | 1.6035 ns | 0.4379 ns | 0.0240 ns | 1.5992 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 3.1 | 1.4528 ns | 0.6539 ns | 0.0358 ns | 1.4402 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 5.0 | 1.3716 ns | 0.0714 ns | 0.0039 ns | 1.3696 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 3.1 | 1.5330 ns | 0.5883 ns | 0.0322 ns | 1.5226 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 5.0 | 1.3920 ns | 0.9115 ns | 0.0500 ns | 1.3732 ns |  0.91 |    0.04 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 3.1 | 1.5525 ns | 0.6293 ns | 0.0345 ns | 1.5385 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 5.0 | 1.5366 ns | 2.2090 ns | 0.1211 ns | 1.5000 ns |  0.99 |    0.08 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 3.1 | 3.9811 ns | 0.2872 ns | 0.0157 ns | 3.9858 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 5.0 | 4.0166 ns | 0.0856 ns | 0.0047 ns | 4.0176 ns |  1.01 |    0.00 |     - |     - |     - |         - |
