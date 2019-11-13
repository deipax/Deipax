
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |   0.9248 ns | 0.0030 ns | 0.0028 ns |   0.9244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.1260 ns | 0.0112 ns | 0.0105 ns |   1.1228 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.0462 ns | 0.0026 ns | 0.0024 ns |   1.0461 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |   0.6556 ns | 0.0024 ns | 0.0022 ns |   0.6563 ns |  0.71 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   0.9042 ns | 0.0142 ns | 0.0133 ns |   0.9082 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.6841 ns | 0.0067 ns | 0.0062 ns |   4.6841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.8478 ns | 0.0155 ns | 0.0145 ns |   4.8518 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.4102 ns | 0.0068 ns | 0.0063 ns |   4.4101 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.8342 ns | 0.0046 ns | 0.0041 ns |   4.8339 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.8757 ns | 0.0232 ns | 0.0217 ns |   4.8847 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   0.9203 ns | 0.0022 ns | 0.0019 ns |   0.9204 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   0.8980 ns | 0.0039 ns | 0.0034 ns |   0.8978 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   0.8855 ns | 0.0032 ns | 0.0030 ns |   0.8853 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |   0.4226 ns | 0.0011 ns | 0.0011 ns |   0.4225 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |   0.7088 ns | 0.0031 ns | 0.0029 ns |   0.7095 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.2240 ns | 0.0044 ns | 0.0039 ns |   4.2239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.3473 ns | 0.0053 ns | 0.0049 ns |   4.3477 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   3.9416 ns | 0.0044 ns | 0.0037 ns |   3.9417 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.3787 ns | 0.0056 ns | 0.0053 ns |   4.3771 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.3724 ns | 0.0057 ns | 0.0053 ns |   4.3709 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.3469 ns | 0.0057 ns | 0.0051 ns |   4.3463 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.5459 ns | 0.0261 ns | 0.0244 ns |   4.5376 ns |  1.05 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.4280 ns | 0.0064 ns | 0.0057 ns |   4.4280 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.6732 ns | 0.0158 ns | 0.0148 ns |   3.6778 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.6823 ns | 0.0057 ns | 0.0051 ns |   3.6827 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   6.5924 ns | 0.0078 ns | 0.0069 ns |   6.5899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.6680 ns | 0.0099 ns | 0.0087 ns |   6.6685 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   6.7588 ns | 0.0220 ns | 0.0205 ns |   6.7608 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   6.6916 ns | 0.0085 ns | 0.0079 ns |   6.6917 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   6.7145 ns | 0.0369 ns | 0.0345 ns |   6.7335 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.3502 ns | 0.0079 ns | 0.0073 ns |   4.3484 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   4.8017 ns | 0.0218 ns | 0.0193 ns |   4.8090 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.7053 ns | 0.0080 ns | 0.0075 ns |   4.7056 ns |  1.08 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   3.2734 ns | 0.0045 ns | 0.0042 ns |   3.2736 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   3.3500 ns | 0.0042 ns | 0.0039 ns |   3.3500 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   6.5902 ns | 0.0195 ns | 0.0182 ns |   6.5921 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.6550 ns | 0.0075 ns | 0.0067 ns |   6.6550 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   6.7179 ns | 0.0085 ns | 0.0080 ns |   6.7178 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   6.6870 ns | 0.0109 ns | 0.0096 ns |   6.6886 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   6.6719 ns | 0.0106 ns | 0.0100 ns |   6.6722 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   4.3490 ns | 0.0059 ns | 0.0055 ns |   4.3487 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.8774 ns | 0.0239 ns | 0.0212 ns |   4.8844 ns |  1.12 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.7526 ns | 0.0050 ns | 0.0044 ns |   4.7533 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   3.3037 ns | 0.0068 ns | 0.0064 ns |   3.3028 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   3.3605 ns | 0.0062 ns | 0.0058 ns |   3.3599 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   6.5335 ns | 0.0083 ns | 0.0074 ns |   6.5299 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.6508 ns | 0.0097 ns | 0.0081 ns |   6.6521 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   6.7156 ns | 0.0094 ns | 0.0083 ns |   6.7155 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   6.6831 ns | 0.0125 ns | 0.0111 ns |   6.6816 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   6.6826 ns | 0.0083 ns | 0.0078 ns |   6.6863 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.3879 ns | 0.0107 ns | 0.0100 ns |   4.3869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   4.5331 ns | 0.0086 ns | 0.0081 ns |   4.5334 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   4.4244 ns | 0.0059 ns | 0.0052 ns |   4.4262 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.6976 ns | 0.0057 ns | 0.0053 ns |   3.6969 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.7259 ns | 0.0171 ns | 0.0152 ns |   3.7309 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   6.5199 ns | 0.0065 ns | 0.0057 ns |   6.5199 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   6.6478 ns | 0.0102 ns | 0.0096 ns |   6.6496 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   6.7130 ns | 0.0092 ns | 0.0082 ns |   6.7155 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   6.6818 ns | 0.0073 ns | 0.0064 ns |   6.6801 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   6.6772 ns | 0.0105 ns | 0.0099 ns |   6.6751 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   2.7537 ns | 0.0047 ns | 0.0042 ns |   2.7535 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.0725 ns | 0.0078 ns | 0.0073 ns |   3.0731 ns |  1.12 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.1054 ns | 0.0071 ns | 0.0066 ns |   3.1072 ns |  1.13 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |   1.9662 ns | 0.0208 ns | 0.0195 ns |   1.9783 ns |  0.71 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   1.9736 ns | 0.0028 ns | 0.0025 ns |   1.9734 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   5.6595 ns | 0.0123 ns | 0.0109 ns |   5.6603 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   5.7299 ns | 0.0068 ns | 0.0064 ns |   5.7291 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.0700 ns | 0.0064 ns | 0.0057 ns |   6.0698 ns |  1.07 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   5.7582 ns | 0.0057 ns | 0.0051 ns |   5.7582 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   5.8017 ns | 0.0267 ns | 0.0250 ns |   5.8140 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   2.8093 ns | 0.0039 ns | 0.0034 ns |   2.8101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.1480 ns | 0.0098 ns | 0.0092 ns |   3.1516 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.1934 ns | 0.0073 ns | 0.0065 ns |   3.1915 ns |  1.14 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   1.9946 ns | 0.0146 ns | 0.0137 ns |   1.9981 ns |  0.71 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |   2.0175 ns | 0.0041 ns | 0.0038 ns |   2.0175 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   5.8428 ns | 0.0039 ns | 0.0037 ns |   5.8436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   5.9630 ns | 0.0041 ns | 0.0039 ns |   5.9613 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.0306 ns | 0.0117 ns | 0.0110 ns |   6.0305 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.0011 ns | 0.0337 ns | 0.0263 ns |   5.9938 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.0061 ns | 0.0182 ns | 0.0162 ns |   6.0012 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.6055 ns | 0.0071 ns | 0.0066 ns |   3.6071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.3679 ns | 0.0023 ns | 0.0021 ns |   2.3682 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.4046 ns | 0.0060 ns | 0.0056 ns |   2.4042 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   3.3159 ns | 0.0157 ns | 0.0147 ns |   3.3195 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   3.4812 ns | 0.0037 ns | 0.0032 ns |   3.4815 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.0570 ns | 0.0059 ns | 0.0052 ns |   4.0579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   2.9360 ns | 0.0062 ns | 0.0058 ns |   2.9386 ns |  0.72 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   2.9405 ns | 0.0074 ns | 0.0062 ns |   2.9398 ns |  0.72 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   4.3654 ns | 0.0063 ns | 0.0056 ns |   4.3643 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   4.8123 ns | 0.0039 ns | 0.0034 ns |   4.8123 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   3.6560 ns | 0.0060 ns | 0.0053 ns |   3.6548 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.4688 ns | 0.0047 ns | 0.0044 ns |   2.4688 ns |  0.68 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.4313 ns | 0.0109 ns | 0.0091 ns |   2.4330 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   3.3914 ns | 0.0288 ns | 0.0270 ns |   3.4065 ns |  0.93 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |   3.3571 ns | 0.0124 ns | 0.0110 ns |   3.3619 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   3.9977 ns | 0.0054 ns | 0.0050 ns |   3.9990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   2.8909 ns | 0.0051 ns | 0.0045 ns |   2.8919 ns |  0.72 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   2.8916 ns | 0.0051 ns | 0.0048 ns |   2.8921 ns |  0.72 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   4.5026 ns | 0.0084 ns | 0.0079 ns |   4.5051 ns |  1.13 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   4.3704 ns | 0.0055 ns | 0.0052 ns |   4.3699 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.1762 ns | 0.0123 ns | 0.0115 ns |   1.1836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.1743 ns | 0.0159 ns | 0.0148 ns |   1.1803 ns |  1.00 |    0.02 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.0446 ns | 0.0019 ns | 0.0018 ns |   1.0445 ns |  0.89 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.6507 ns | 0.0034 ns | 0.0031 ns |   0.6512 ns |  0.55 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.9362 ns | 0.0015 ns | 0.0013 ns |   0.9364 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.2270 ns | 0.0054 ns | 0.0050 ns |   4.2265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.3454 ns | 0.0043 ns | 0.0041 ns |   4.3440 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.1809 ns | 0.0054 ns | 0.0048 ns |   4.1821 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.4148 ns | 0.0146 ns | 0.0137 ns |   4.4169 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.3850 ns | 0.0035 ns | 0.0033 ns |   4.3853 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.1726 ns | 0.0033 ns | 0.0026 ns |   1.1721 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.2040 ns | 0.0114 ns | 0.0089 ns |   1.2068 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   0.8994 ns | 0.0030 ns | 0.0026 ns |   0.8999 ns |  0.77 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.4186 ns | 0.0023 ns | 0.0020 ns |   0.4178 ns |  0.36 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.7354 ns | 0.0013 ns | 0.0011 ns |   0.7359 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.6414 ns | 0.0025 ns | 0.0021 ns |   1.6417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.6003 ns | 0.0025 ns | 0.0023 ns |   1.6005 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.7111 ns | 0.0026 ns | 0.0025 ns |   1.7105 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.7729 ns | 0.0031 ns | 0.0029 ns |   1.7720 ns |  1.08 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.7986 ns | 0.0104 ns | 0.0097 ns |   1.8040 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  54.0177 ns | 0.0432 ns | 0.0383 ns |  54.0215 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  53.9096 ns | 0.0553 ns | 0.0518 ns |  53.8889 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  12.2564 ns | 0.0167 ns | 0.0156 ns |  12.2596 ns |  0.23 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  54.5357 ns | 0.0602 ns | 0.0563 ns |  54.5537 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  54.8419 ns | 0.0855 ns | 0.0758 ns |  54.8316 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  65.3588 ns | 0.0671 ns | 0.0628 ns |  65.3414 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  64.6253 ns | 0.1048 ns | 0.0980 ns |  64.6173 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  17.4807 ns | 0.1241 ns | 0.1161 ns |  17.5382 ns |  0.27 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  65.3832 ns | 0.2669 ns | 0.2496 ns |  65.2824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  65.2834 ns | 0.2630 ns | 0.2460 ns |  65.1838 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3622 ns | 0.0051 ns | 0.0045 ns |   2.3610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.0458 ns | 0.0023 ns | 0.0021 ns |   2.0463 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.0855 ns | 0.0028 ns | 0.0026 ns |   2.0854 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   0.9180 ns | 0.0022 ns | 0.0019 ns |   0.9183 ns |  0.39 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.1229 ns | 0.0016 ns | 0.0015 ns |   1.1230 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.1603 ns | 0.0108 ns | 0.0101 ns |   8.1601 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.2841 ns | 0.0259 ns | 0.0242 ns |   8.2893 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.8758 ns | 0.0067 ns | 0.0056 ns |   1.8756 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   7.8927 ns | 0.0074 ns | 0.0066 ns |   7.8923 ns |  0.97 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.4214 ns | 0.0158 ns | 0.0140 ns |   8.4209 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.2406 ns | 0.0229 ns | 0.0214 ns |   3.2316 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   3.7056 ns | 0.0123 ns | 0.0115 ns |   3.7034 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   3.8230 ns | 0.0342 ns | 0.0320 ns |   3.8282 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   2.7209 ns | 0.0092 ns | 0.0077 ns |   2.7220 ns |  0.84 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   2.7514 ns | 0.0097 ns | 0.0090 ns |   2.7530 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 188.6664 ns | 0.1100 ns | 0.0975 ns | 188.6801 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 108.5629 ns | 0.1326 ns | 0.1240 ns | 108.5521 ns |  0.58 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 108.3610 ns | 0.0995 ns | 0.0882 ns | 108.3580 ns |  0.57 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 294.2917 ns | 0.4192 ns | 0.3501 ns | 294.2132 ns |  1.56 |    0.00 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 295.5226 ns | 0.4759 ns | 0.4218 ns | 295.5606 ns |  1.57 |    0.00 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  12.0024 ns | 0.0071 ns | 0.0066 ns |  12.0033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  12.1090 ns | 0.0216 ns | 0.0192 ns |  12.1116 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.2879 ns | 0.0134 ns | 0.0118 ns |  10.2876 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  14.3334 ns | 0.0813 ns | 0.0760 ns |  14.3653 ns |  1.19 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 |  14.3723 ns | 0.0268 ns | 0.0224 ns |  14.3714 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  16.4348 ns | 0.0285 ns | 0.0266 ns |  16.4426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  16.8788 ns | 0.0202 ns | 0.0189 ns |  16.8741 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  15.0055 ns | 0.0193 ns | 0.0162 ns |  14.9984 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  19.1231 ns | 0.0268 ns | 0.0250 ns |  19.1185 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  19.1655 ns | 0.0161 ns | 0.0143 ns |  19.1674 ns |  1.17 |    0.00 |      - |     - |     - |         - |
