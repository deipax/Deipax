
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |        Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|----------:|----------:|------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |   1.1841 ns | 0.0088 ns | 0.0082 ns |  1.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.3911 ns | 0.0150 ns | 0.0140 ns |  1.17 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.1985 ns | 0.0051 ns | 0.0047 ns |  1.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.6672 ns | 0.0079 ns | 0.0074 ns |  0.56 |      - |     - |     - |         - |
             ToBool |        net472 |   0.6761 ns | 0.0023 ns | 0.0020 ns |  0.57 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.7297 ns | 0.0079 ns | 0.0070 ns |  1.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.8813 ns | 0.0070 ns | 0.0066 ns |  1.03 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.4882 ns | 0.0084 ns | 0.0078 ns |  0.95 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.8952 ns | 0.0120 ns | 0.0106 ns |  1.03 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.9030 ns | 0.0071 ns | 0.0059 ns |  1.04 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.2080 ns | 0.0038 ns | 0.0036 ns |  1.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.1530 ns | 0.0109 ns | 0.0091 ns |  0.95 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.1898 ns | 0.0059 ns | 0.0049 ns |  0.98 |      - |     - |     - |         - |
             ToChar |        net461 |   0.4406 ns | 0.0111 ns | 0.0104 ns |  0.36 |      - |     - |     - |         - |
             ToChar |        net472 |   0.3055 ns | 0.0032 ns | 0.0030 ns |  0.25 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.2749 ns | 0.0148 ns | 0.0131 ns |  1.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.4227 ns | 0.0090 ns | 0.0084 ns |  1.03 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.0167 ns | 0.0117 ns | 0.0098 ns |  0.94 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.4268 ns | 0.0074 ns | 0.0069 ns |  1.04 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.4818 ns | 0.0154 ns | 0.0136 ns |  1.05 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.4047 ns | 0.0086 ns | 0.0080 ns |  1.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.4929 ns | 0.0065 ns | 0.0055 ns |  1.02 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.6677 ns | 0.0157 ns | 0.0139 ns |  1.06 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.7054 ns | 0.0145 ns | 0.0129 ns |  0.84 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.6549 ns | 0.0125 ns | 0.0117 ns |  0.83 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   6.5972 ns | 0.0220 ns | 0.0205 ns |  1.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.8391 ns | 0.0214 ns | 0.0200 ns |  1.04 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   6.8153 ns | 0.0134 ns | 0.0119 ns |  1.03 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   6.7661 ns | 0.0320 ns | 0.0299 ns |  1.03 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   6.7823 ns | 0.0233 ns | 0.0218 ns |  1.03 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.5340 ns | 0.0094 ns | 0.0088 ns |  1.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   4.8108 ns | 0.0107 ns | 0.0100 ns |  1.06 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.6313 ns | 0.0078 ns | 0.0069 ns |  1.02 |      - |     - |     - |         - |
             ToByte |        net461 |   4.2758 ns | 0.0100 ns | 0.0093 ns |  0.94 |      - |     - |     - |         - |
             ToByte |        net472 |   3.3171 ns | 0.0073 ns | 0.0069 ns |  0.73 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   6.5955 ns | 0.0226 ns | 0.0188 ns |  1.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.8074 ns | 0.0673 ns | 0.0630 ns |  1.03 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   6.8843 ns | 0.0291 ns | 0.0272 ns |  1.04 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   6.7614 ns | 0.0260 ns | 0.0243 ns |  1.03 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   6.7651 ns | 0.0118 ns | 0.0104 ns |  1.03 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
            ToShort | .NET Core 2.0 |   4.8319 ns | 0.0095 ns | 0.0080 ns |  1.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.7939 ns | 0.0152 ns | 0.0135 ns |  0.99 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.5748 ns | 0.0177 ns | 0.0148 ns |  0.95 |      - |     - |     - |         - |
            ToShort |        net461 |   3.3717 ns | 0.0384 ns | 0.0360 ns |  0.70 |      - |     - |     - |         - |
            ToShort |        net472 |   3.4045 ns | 0.0106 ns | 0.0089 ns |  0.70 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   6.5983 ns | 0.0133 ns | 0.0118 ns |  1.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.7409 ns | 0.0136 ns | 0.0121 ns |  1.02 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   6.8191 ns | 0.0230 ns | 0.0204 ns |  1.03 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   6.7509 ns | 0.0121 ns | 0.0101 ns |  1.02 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   6.7746 ns | 0.0180 ns | 0.0151 ns |  1.03 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.6387 ns | 0.0337 ns | 0.0299 ns |  1.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   4.5391 ns | 0.0155 ns | 0.0130 ns |  0.98 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   4.9113 ns | 0.0089 ns | 0.0079 ns |  1.06 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.7100 ns | 0.0251 ns | 0.0210 ns |  0.80 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.7048 ns | 0.0074 ns | 0.0066 ns |  0.80 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   6.5948 ns | 0.0139 ns | 0.0130 ns |  1.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   6.8288 ns | 0.0276 ns | 0.0245 ns |  1.04 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   6.8783 ns | 0.0268 ns | 0.0238 ns |  1.04 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   6.8396 ns | 0.0400 ns | 0.0374 ns |  1.04 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   6.7728 ns | 0.0090 ns | 0.0080 ns |  1.03 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
              ToInt | .NET Core 2.0 |   2.8127 ns | 0.0181 ns | 0.0151 ns |  1.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.1248 ns | 0.0133 ns | 0.0118 ns |  1.11 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.2534 ns | 0.0090 ns | 0.0075 ns |  1.16 |      - |     - |     - |         - |
              ToInt |        net461 |   2.0177 ns | 0.0077 ns | 0.0072 ns |  0.72 |      - |     - |     - |         - |
              ToInt |        net472 |   1.9820 ns | 0.0071 ns | 0.0066 ns |  0.70 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   5.7357 ns | 0.0069 ns | 0.0062 ns |  1.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   5.9437 ns | 0.0069 ns | 0.0057 ns |  1.04 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.1692 ns | 0.0241 ns | 0.0214 ns |  1.08 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   5.8267 ns | 0.0081 ns | 0.0068 ns |  1.02 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   5.8449 ns | 0.0182 ns | 0.0162 ns |  1.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
             ToUInt | .NET Core 2.0 |   2.8491 ns | 0.0098 ns | 0.0086 ns |  1.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.2248 ns | 0.0099 ns | 0.0093 ns |  1.13 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.2310 ns | 0.0091 ns | 0.0081 ns |  1.13 |      - |     - |     - |         - |
             ToUInt |        net461 |   1.9885 ns | 0.0065 ns | 0.0058 ns |  0.70 |      - |     - |     - |         - |
             ToUInt |        net472 |   1.9794 ns | 0.0062 ns | 0.0058 ns |  0.69 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   5.9182 ns | 0.0473 ns | 0.0442 ns |  1.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.0735 ns | 0.0466 ns | 0.0436 ns |  1.03 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.1197 ns | 0.0237 ns | 0.0198 ns |  1.04 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.0574 ns | 0.0132 ns | 0.0117 ns |  1.02 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.0692 ns | 0.0103 ns | 0.0096 ns |  1.03 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.6131 ns | 0.0101 ns | 0.0089 ns |  1.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.4438 ns | 0.0143 ns | 0.0134 ns |  0.68 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.5078 ns | 0.0148 ns | 0.0132 ns |  0.69 |      - |     - |     - |         - |
             ToLong |        net461 |   3.3798 ns | 0.0088 ns | 0.0083 ns |  0.94 |      - |     - |     - |         - |
             ToLong |        net472 |   3.3993 ns | 0.0087 ns | 0.0082 ns |  0.94 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.1357 ns | 0.0113 ns | 0.0094 ns |  1.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   2.9573 ns | 0.0364 ns | 0.0340 ns |  0.72 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.0180 ns | 0.0117 ns | 0.0104 ns |  0.73 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   4.4699 ns | 0.0086 ns | 0.0071 ns |  1.08 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   4.5004 ns | 0.0166 ns | 0.0155 ns |  1.09 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
            ToULong | .NET Core 2.0 |   3.7620 ns | 0.0160 ns | 0.0125 ns |  1.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.5042 ns | 0.0100 ns | 0.0084 ns |  0.67 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.4652 ns | 0.0106 ns | 0.0099 ns |  0.66 |      - |     - |     - |         - |
            ToULong |        net461 |   3.3434 ns | 0.0324 ns | 0.0303 ns |  0.89 |      - |     - |     - |         - |
            ToULong |        net472 |   3.3022 ns | 0.0090 ns | 0.0075 ns |  0.88 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.0709 ns | 0.0187 ns | 0.0166 ns |  1.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.0319 ns | 0.0308 ns | 0.0288 ns |  0.74 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   2.9948 ns | 0.0084 ns | 0.0079 ns |  0.74 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   4.4993 ns | 0.0114 ns | 0.0107 ns |  1.11 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   4.5150 ns | 0.0089 ns | 0.0074 ns |  1.11 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.1989 ns | 0.0042 ns | 0.0040 ns |  1.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.3637 ns | 0.0034 ns | 0.0031 ns |  1.14 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.1957 ns | 0.0056 ns | 0.0049 ns |  1.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.6652 ns | 0.0038 ns | 0.0032 ns |  0.55 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.6823 ns | 0.0059 ns | 0.0055 ns |  0.57 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.2687 ns | 0.0065 ns | 0.0054 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.4196 ns | 0.0080 ns | 0.0071 ns |  1.04 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.2596 ns | 0.0144 ns | 0.0127 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.4827 ns | 0.0082 ns | 0.0072 ns |  1.05 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.4463 ns | 0.0140 ns | 0.0124 ns |  1.04 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.1743 ns | 0.0062 ns | 0.0055 ns |  1.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.1381 ns | 0.0048 ns | 0.0043 ns |  0.97 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.1942 ns | 0.0108 ns | 0.0101 ns |  1.02 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.4308 ns | 0.0034 ns | 0.0030 ns |  0.37 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.4461 ns | 0.0032 ns | 0.0030 ns |  0.38 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.6824 ns | 0.0036 ns | 0.0030 ns |  1.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.8156 ns | 0.0048 ns | 0.0042 ns |  1.08 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   2.1229 ns | 0.0075 ns | 0.0066 ns |  1.26 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.8882 ns | 0.0132 ns | 0.0111 ns |  1.12 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.9181 ns | 0.0084 ns | 0.0075 ns |  1.14 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  54.5719 ns | 0.0938 ns | 0.0877 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  54.9721 ns | 0.2265 ns | 0.2118 ns |  1.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  12.3998 ns | 0.0235 ns | 0.0208 ns |  0.23 |      - |     - |     - |         - |
          ToDecimal |        net461 |  54.8404 ns | 0.1108 ns | 0.1037 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  54.9857 ns | 0.0974 ns | 0.0911 ns |  1.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  66.0334 ns | 0.2057 ns | 0.1824 ns |  1.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  65.5690 ns | 0.1813 ns | 0.1607 ns |  0.99 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  17.6130 ns | 0.1624 ns | 0.1519 ns |  0.27 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  65.7456 ns | 0.1309 ns | 0.1160 ns |  1.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  66.3098 ns | 0.3388 ns | 0.3169 ns |  1.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3380 ns | 0.0100 ns | 0.0089 ns |  1.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.0550 ns | 0.0050 ns | 0.0042 ns |  0.88 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.2253 ns | 0.0098 ns | 0.0092 ns |  0.95 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.1880 ns | 0.0060 ns | 0.0056 ns |  0.51 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.1974 ns | 0.0047 ns | 0.0044 ns |  0.51 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.3118 ns | 0.0300 ns | 0.0281 ns |  1.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.0159 ns | 0.0176 ns | 0.0165 ns |  0.96 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.9524 ns | 0.0069 ns | 0.0064 ns |  0.23 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.0772 ns | 0.0476 ns | 0.0445 ns |  0.97 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  12.3596 ns | 0.0252 ns | 0.0211 ns |  1.49 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.3621 ns | 0.0109 ns | 0.0097 ns |  1.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   3.7645 ns | 0.0248 ns | 0.0220 ns |  1.12 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   3.9746 ns | 0.0351 ns | 0.0311 ns |  1.18 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   2.7619 ns | 0.0098 ns | 0.0092 ns |  0.82 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   2.7672 ns | 0.0078 ns | 0.0065 ns |  0.82 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |        |       |       |           |
          To_String | .NET Core 2.0 | 193.5315 ns | 1.3175 ns | 1.2324 ns |  1.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 110.0968 ns | 0.2918 ns | 0.2587 ns |  0.57 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 111.3700 ns | 0.7087 ns | 0.6629 ns |  0.58 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 296.4480 ns | 0.5540 ns | 0.4911 ns |  1.53 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 297.0151 ns | 0.5312 ns | 0.4969 ns |  1.53 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |       |        |       |       |           |
             ToEnum | .NET Core 2.0 |  12.0886 ns | 0.0355 ns | 0.0314 ns |  1.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  12.3233 ns | 0.0334 ns | 0.0296 ns |  1.02 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.2918 ns | 0.0233 ns | 0.0182 ns |  0.85 |      - |     - |     - |         - |
             ToEnum |        net461 |  14.2812 ns | 0.0334 ns | 0.0312 ns |  1.18 |      - |     - |     - |         - |
             ToEnum |        net472 |  14.4908 ns | 0.0932 ns | 0.0826 ns |  1.20 |      - |     - |     - |         - |
                    |               |             |           |           |       |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  16.5346 ns | 0.0291 ns | 0.0272 ns |  1.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  17.0542 ns | 0.0462 ns | 0.0433 ns |  1.03 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  14.8205 ns | 0.0487 ns | 0.0455 ns |  0.90 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  19.2921 ns | 0.0331 ns | 0.0293 ns |  1.17 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  19.4850 ns | 0.1047 ns | 0.0817 ns |  1.18 |      - |     - |     - |         - |
