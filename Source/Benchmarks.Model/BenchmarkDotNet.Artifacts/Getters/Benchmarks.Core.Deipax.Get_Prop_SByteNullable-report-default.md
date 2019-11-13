
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4655 ns | 0.0039 ns | 0.0036 ns |  1.4646 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4282 ns | 0.0060 ns | 0.0053 ns |  1.4290 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4462 ns | 0.0042 ns | 0.0037 ns |  1.4454 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.0306 ns | 0.0148 ns | 0.0139 ns |  1.0354 ns |  0.70 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  1.1857 ns | 0.0036 ns | 0.0034 ns |  1.1867 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4682 ns | 0.0070 ns | 0.0062 ns |  4.4674 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4105 ns | 0.0069 ns | 0.0064 ns |  4.4105 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2510 ns | 0.0056 ns | 0.0050 ns |  4.2498 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.6340 ns | 0.0070 ns | 0.0065 ns |  4.6315 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6099 ns | 0.0056 ns | 0.0052 ns |  4.6108 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.9834 ns | 0.0043 ns | 0.0038 ns |  1.9834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6448 ns | 0.0189 ns | 0.0177 ns |  1.6509 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2785 ns | 0.0033 ns | 0.0031 ns |  1.2779 ns |  0.64 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.0382 ns | 0.0026 ns | 0.0024 ns |  2.0384 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.3523 ns | 0.0084 ns | 0.0075 ns |  2.3540 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.5188 ns | 0.0049 ns | 0.0046 ns |  4.5185 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4040 ns | 0.0069 ns | 0.0064 ns |  4.4054 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.4628 ns | 0.0040 ns | 0.0035 ns |  4.4629 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3648 ns | 0.0266 ns | 0.0249 ns |  5.3749 ns |  1.19 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3096 ns | 0.0097 ns | 0.0091 ns |  5.3068 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4162 ns | 0.0035 ns | 0.0033 ns |  1.4150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6485 ns | 0.0034 ns | 0.0028 ns |  1.6480 ns |  1.16 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5785 ns | 0.0036 ns | 0.0034 ns |  1.5780 ns |  1.11 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.8396 ns | 0.0043 ns | 0.0038 ns |  1.8392 ns |  1.30 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.8797 ns | 0.0160 ns | 0.0149 ns |  1.8709 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  1.1646 ns | 0.0036 ns | 0.0034 ns |  1.1637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  1.1504 ns | 0.0014 ns | 0.0014 ns |  1.1502 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  1.1765 ns | 0.0175 ns | 0.0163 ns |  1.1802 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  0.9718 ns | 0.0103 ns | 0.0096 ns |  0.9769 ns |  0.83 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  1.1306 ns | 0.0023 ns | 0.0021 ns |  1.1308 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.8635 ns | 0.0031 ns | 0.0029 ns |  1.8638 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.9868 ns | 0.0043 ns | 0.0040 ns |  1.9855 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5306 ns | 0.0022 ns | 0.0018 ns |  1.5305 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.3289 ns | 0.0143 ns | 0.0119 ns |  2.3231 ns |  1.25 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3547 ns | 0.0100 ns | 0.0084 ns |  2.3568 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7501 ns | 0.0153 ns | 0.0143 ns |  4.7547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4073 ns | 0.0061 ns | 0.0057 ns |  4.4075 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2502 ns | 0.0105 ns | 0.0093 ns |  4.2464 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3255 ns | 0.0046 ns | 0.0043 ns |  5.3238 ns |  1.12 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.2975 ns | 0.0032 ns | 0.0030 ns |  5.2971 ns |  1.12 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4843 ns | 0.0036 ns | 0.0034 ns |  1.4847 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.7517 ns | 0.0029 ns | 0.0024 ns |  1.7521 ns |  1.18 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5327 ns | 0.0027 ns | 0.0025 ns |  1.5327 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  0.9466 ns | 0.0027 ns | 0.0025 ns |  0.9478 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.1788 ns | 0.0030 ns | 0.0027 ns |  1.1786 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4741 ns | 0.0078 ns | 0.0073 ns |  4.4740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.6343 ns | 0.0060 ns | 0.0056 ns |  4.6328 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2328 ns | 0.0061 ns | 0.0051 ns |  4.2312 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6554 ns | 0.0286 ns | 0.0267 ns |  4.6722 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6311 ns | 0.0292 ns | 0.0274 ns |  4.6415 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.9066 ns | 0.0055 ns | 0.0046 ns |  1.9060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.9309 ns | 0.0088 ns | 0.0082 ns |  1.9271 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5012 ns | 0.0113 ns | 0.0094 ns |  1.5041 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.1690 ns | 0.0037 ns | 0.0035 ns |  2.1695 ns |  1.14 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.4221 ns | 0.0032 ns | 0.0029 ns |  2.4227 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.7028 ns | 0.0061 ns | 0.0057 ns |  4.7027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4043 ns | 0.0053 ns | 0.0045 ns |  4.4035 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.4667 ns | 0.0065 ns | 0.0061 ns |  4.4677 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3397 ns | 0.0339 ns | 0.0317 ns |  5.3233 ns |  1.14 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3080 ns | 0.0151 ns | 0.0134 ns |  5.3055 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4825 ns | 0.0046 ns | 0.0043 ns |  1.4821 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4692 ns | 0.0046 ns | 0.0043 ns |  1.4681 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2659 ns | 0.0042 ns | 0.0039 ns |  1.2662 ns |  0.85 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.9589 ns | 0.0029 ns | 0.0026 ns |  0.9582 ns |  0.65 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.1785 ns | 0.0022 ns | 0.0021 ns |  1.1780 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2850 ns | 0.0075 ns | 0.0067 ns |  4.2833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4094 ns | 0.0123 ns | 0.0103 ns |  4.4076 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0101 ns | 0.0183 ns | 0.0171 ns |  4.0029 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4029 ns | 0.0076 ns | 0.0067 ns |  4.4012 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3759 ns | 0.0079 ns | 0.0074 ns |  4.3740 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  2.0207 ns | 0.0036 ns | 0.0033 ns |  2.0200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.8341 ns | 0.0065 ns | 0.0061 ns |  1.8331 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4202 ns | 0.0055 ns | 0.0052 ns |  1.4191 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.0796 ns | 0.0039 ns | 0.0036 ns |  2.0791 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.4108 ns | 0.0148 ns | 0.0139 ns |  2.4153 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4753 ns | 0.0057 ns | 0.0053 ns |  4.4750 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4054 ns | 0.0054 ns | 0.0050 ns |  4.4055 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2507 ns | 0.0062 ns | 0.0055 ns |  4.2502 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.1011 ns | 0.0055 ns | 0.0049 ns |  5.0998 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.0719 ns | 0.0070 ns | 0.0062 ns |  5.0695 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4839 ns | 0.0054 ns | 0.0050 ns |  1.4841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6139 ns | 0.0022 ns | 0.0021 ns |  1.6136 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4259 ns | 0.0028 ns | 0.0026 ns |  1.4262 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.9536 ns | 0.0121 ns | 0.0113 ns |  0.9579 ns |  0.64 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  1.1863 ns | 0.0131 ns | 0.0122 ns |  1.1812 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.2399 ns | 0.0122 ns | 0.0114 ns |  2.2417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0414 ns | 0.0028 ns | 0.0023 ns |  2.0413 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1086 ns | 0.0022 ns | 0.0019 ns |  2.1081 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3194 ns | 0.0041 ns | 0.0036 ns |  2.3189 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2714 ns | 0.0039 ns | 0.0037 ns |  2.2701 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.8591 ns | 0.0024 ns | 0.0023 ns |  1.8593 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6512 ns | 0.0109 ns | 0.0102 ns |  1.6542 ns |  0.89 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2667 ns | 0.0036 ns | 0.0032 ns |  1.2663 ns |  0.68 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  2.0977 ns | 0.0041 ns | 0.0034 ns |  2.0976 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  2.3828 ns | 0.0154 ns | 0.0144 ns |  2.3883 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1718 ns | 0.0029 ns | 0.0027 ns |  2.1725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.4873 ns | 0.0134 ns | 0.0125 ns |  2.4898 ns |  1.15 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1694 ns | 0.0019 ns | 0.0015 ns |  2.1690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.6026 ns | 0.0259 ns | 0.0242 ns |  3.5892 ns |  1.66 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.5456 ns | 0.0049 ns | 0.0046 ns |  3.5457 ns |  1.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7273 ns | 0.0028 ns | 0.0026 ns |  1.7266 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.8852 ns | 0.0092 ns | 0.0081 ns |  1.8831 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.5400 ns | 0.0031 ns | 0.0029 ns |  1.5393 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.3176 ns | 0.0024 ns | 0.0021 ns |  1.3182 ns |  0.76 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.4113 ns | 0.0024 ns | 0.0022 ns |  1.4110 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4770 ns | 0.0054 ns | 0.0050 ns |  4.4769 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6365 ns | 0.0058 ns | 0.0051 ns |  4.6356 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4695 ns | 0.0066 ns | 0.0062 ns |  4.4696 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8893 ns | 0.0244 ns | 0.0229 ns |  4.8862 ns |  1.09 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8393 ns | 0.0055 ns | 0.0051 ns |  4.8407 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6368 ns | 0.0046 ns | 0.0043 ns |  1.6359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6088 ns | 0.0039 ns | 0.0035 ns |  1.6076 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.7253 ns | 0.0046 ns | 0.0041 ns |  1.7239 ns |  1.05 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.1275 ns | 0.0024 ns | 0.0022 ns |  1.1271 ns |  0.69 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.4326 ns | 0.0028 ns | 0.0026 ns |  1.4316 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0371 ns | 0.0088 ns | 0.0078 ns |  2.0381 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0835 ns | 0.0046 ns | 0.0043 ns |  2.0835 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1885 ns | 0.0074 ns | 0.0062 ns |  2.1861 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6541 ns | 0.0141 ns | 0.0125 ns |  2.6545 ns |  1.30 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5481 ns | 0.0161 ns | 0.0150 ns |  2.5557 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0822 ns | 0.0083 ns | 0.0074 ns |  6.0806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0203 ns | 0.0079 ns | 0.0074 ns |  6.0196 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0738 ns | 0.0269 ns | 0.0210 ns |  6.0652 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.4921 ns | 0.0083 ns | 0.0074 ns |  6.4927 ns |  1.07 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2394 ns | 0.0145 ns | 0.0135 ns |  6.2406 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.1625 ns | 0.0442 ns | 0.0414 ns | 18.1503 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.0870 ns | 0.0569 ns | 0.0532 ns | 18.0668 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.0552 ns | 0.0174 ns | 0.0154 ns | 13.0517 ns |  0.72 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.5071 ns | 0.0158 ns | 0.0140 ns | 18.5077 ns |  1.02 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.2137 ns | 0.0213 ns | 0.0189 ns | 18.2134 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3293 ns | 0.0040 ns | 0.0035 ns |  2.3295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1092 ns | 0.0039 ns | 0.0037 ns |  2.1087 ns |  0.91 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3286 ns | 0.0044 ns | 0.0039 ns |  2.3279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1966 ns | 0.0068 ns | 0.0057 ns |  1.1974 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1211 ns | 0.0099 ns | 0.0092 ns |  1.1260 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9588 ns | 0.0087 ns | 0.0078 ns |  7.9581 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3776 ns | 0.0164 ns | 0.0145 ns |  8.3816 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9221 ns | 0.0040 ns | 0.0034 ns |  1.9225 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2208 ns | 0.0188 ns | 0.0166 ns |  8.2192 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.5667 ns | 0.0157 ns | 0.0139 ns |  8.5694 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8487 ns | 0.0097 ns | 0.0086 ns |  3.8499 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5251 ns | 0.0192 ns | 0.0170 ns |  4.5197 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5728 ns | 0.0267 ns | 0.0250 ns |  4.5758 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.7313 ns | 0.0059 ns | 0.0046 ns |  3.7322 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7962 ns | 0.0097 ns | 0.0081 ns |  3.7953 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.3451 ns | 0.0659 ns | 0.0584 ns | 29.3322 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.6302 ns | 0.0437 ns | 0.0365 ns | 17.6319 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.7835 ns | 0.0372 ns | 0.0330 ns | 13.7867 ns |  0.47 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.4062 ns | 0.0659 ns | 0.0584 ns | 31.3873 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.0748 ns | 0.0407 ns | 0.0318 ns | 31.0830 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.4999 ns | 0.0185 ns | 0.0173 ns | 12.4957 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4486 ns | 0.0375 ns | 0.0332 ns | 12.4387 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3678 ns | 0.0126 ns | 0.0118 ns |  8.3684 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.1723 ns | 0.0216 ns | 0.0202 ns | 15.1660 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.1427 ns | 0.0147 ns | 0.0131 ns | 15.1427 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.6942 ns | 0.0297 ns | 0.0277 ns | 16.6933 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.7442 ns | 0.0220 ns | 0.0184 ns | 16.7475 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.0476 ns | 0.0123 ns | 0.0102 ns | 13.0490 ns |  0.78 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.7950 ns | 0.0978 ns | 0.0915 ns | 19.8560 ns |  1.19 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.8683 ns | 0.1105 ns | 0.1033 ns | 19.9139 ns |  1.19 |    0.01 |      - |     - |     - |         - |
