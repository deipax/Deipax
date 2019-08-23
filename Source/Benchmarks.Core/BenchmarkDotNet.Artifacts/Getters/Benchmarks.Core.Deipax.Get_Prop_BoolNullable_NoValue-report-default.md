
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.3196 ns | 0.0081 ns | 0.0068 ns |  1.3216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2839 ns | 0.0026 ns | 0.0023 ns |  1.2839 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2886 ns | 0.0185 ns | 0.0173 ns |  1.2928 ns |  0.98 |    0.02 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9916 ns | 0.0131 ns | 0.0122 ns |  0.9966 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9552 ns | 0.0029 ns | 0.0026 ns |  0.9552 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  0.9171 ns | 0.0026 ns | 0.0023 ns |  0.9167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  0.9633 ns | 0.0025 ns | 0.0022 ns |  0.9638 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  0.9399 ns | 0.0042 ns | 0.0037 ns |  0.9401 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  1.1808 ns | 0.0021 ns | 0.0019 ns |  1.1805 ns |  1.29 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  0.9748 ns | 0.0046 ns | 0.0041 ns |  0.9740 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  0.8779 ns | 0.0021 ns | 0.0020 ns |  0.8773 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.0285 ns | 0.0090 ns | 0.0080 ns |  1.0315 ns |  1.17 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0199 ns | 0.0029 ns | 0.0024 ns |  1.0197 ns |  1.16 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.7229 ns | 0.0035 ns | 0.0031 ns |  0.7231 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.5322 ns | 0.0025 ns | 0.0023 ns |  0.5319 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9618 ns | 0.0053 ns | 0.0044 ns |  3.9613 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1699 ns | 0.0047 ns | 0.0044 ns |  4.1703 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9679 ns | 0.0055 ns | 0.0046 ns |  3.9681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1746 ns | 0.0063 ns | 0.0053 ns |  4.1732 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1783 ns | 0.0095 ns | 0.0089 ns |  4.1759 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1950 ns | 0.0029 ns | 0.0027 ns |  1.1945 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4173 ns | 0.0067 ns | 0.0059 ns |  1.4168 ns |  1.19 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.3861 ns | 0.0024 ns | 0.0022 ns |  1.3867 ns |  1.16 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.1723 ns | 0.0026 ns | 0.0023 ns |  1.1719 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9684 ns | 0.0041 ns | 0.0038 ns |  0.9675 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9969 ns | 0.0146 ns | 0.0130 ns |  3.9994 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1710 ns | 0.0054 ns | 0.0051 ns |  4.1714 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9682 ns | 0.0048 ns | 0.0045 ns |  3.9687 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4061 ns | 0.0078 ns | 0.0069 ns |  4.4076 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4360 ns | 0.0226 ns | 0.0200 ns |  4.4402 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.3128 ns | 0.0040 ns | 0.0037 ns |  1.3128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.2345 ns | 0.0032 ns | 0.0029 ns |  1.2345 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.2434 ns | 0.0040 ns | 0.0035 ns |  1.2430 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9984 ns | 0.0053 ns | 0.0050 ns |  0.9997 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9667 ns | 0.0030 ns | 0.0027 ns |  0.9673 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  3.9653 ns | 0.0063 ns | 0.0056 ns |  3.9658 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1701 ns | 0.0084 ns | 0.0074 ns |  4.1691 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  3.9644 ns | 0.0087 ns | 0.0077 ns |  3.9634 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4024 ns | 0.0059 ns | 0.0052 ns |  4.4021 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4023 ns | 0.0073 ns | 0.0068 ns |  4.4030 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.1681 ns | 0.0030 ns | 0.0026 ns |  1.1675 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.2715 ns | 0.0056 ns | 0.0052 ns |  1.2699 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2145 ns | 0.0032 ns | 0.0028 ns |  1.2149 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  1.1821 ns | 0.0032 ns | 0.0028 ns |  1.1822 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9710 ns | 0.0045 ns | 0.0040 ns |  0.9706 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  3.9679 ns | 0.0044 ns | 0.0041 ns |  3.9680 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1657 ns | 0.0044 ns | 0.0039 ns |  4.1660 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  3.9995 ns | 0.0101 ns | 0.0090 ns |  3.9975 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4003 ns | 0.0062 ns | 0.0055 ns |  4.3997 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4311 ns | 0.0242 ns | 0.0202 ns |  4.4393 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.3515 ns | 0.0080 ns | 0.0075 ns |  1.3527 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.3240 ns | 0.0019 ns | 0.0018 ns |  1.3246 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3056 ns | 0.0026 ns | 0.0024 ns |  1.3055 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9987 ns | 0.0064 ns | 0.0060 ns |  1.0001 ns |  0.74 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9663 ns | 0.0029 ns | 0.0027 ns |  0.9666 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  3.9654 ns | 0.0068 ns | 0.0060 ns |  3.9656 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1707 ns | 0.0059 ns | 0.0055 ns |  4.1681 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9994 ns | 0.0098 ns | 0.0091 ns |  3.9995 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4027 ns | 0.0077 ns | 0.0072 ns |  4.4041 ns |  1.11 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3995 ns | 0.0039 ns | 0.0030 ns |  4.3999 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.2132 ns | 0.0032 ns | 0.0029 ns |  1.2127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4123 ns | 0.0040 ns | 0.0036 ns |  1.4124 ns |  1.16 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4118 ns | 0.0029 ns | 0.0027 ns |  1.4119 ns |  1.16 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.1713 ns | 0.0091 ns | 0.0085 ns |  1.1686 ns |  0.97 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9650 ns | 0.0026 ns | 0.0023 ns |  0.9651 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9583 ns | 0.0073 ns | 0.0069 ns |  3.9572 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1719 ns | 0.0070 ns | 0.0065 ns |  4.1700 ns |  1.05 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9685 ns | 0.0077 ns | 0.0068 ns |  3.9690 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.3994 ns | 0.0057 ns | 0.0053 ns |  4.4007 ns |  1.11 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4074 ns | 0.0046 ns | 0.0043 ns |  4.4085 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4169 ns | 0.0026 ns | 0.0022 ns |  1.4167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.2363 ns | 0.0040 ns | 0.0037 ns |  1.2372 ns |  0.87 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2550 ns | 0.0155 ns | 0.0145 ns |  1.2600 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9897 ns | 0.0033 ns | 0.0030 ns |  0.9897 ns |  0.70 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9695 ns | 0.0040 ns | 0.0037 ns |  0.9701 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9606 ns | 0.0028 ns | 0.0023 ns |  3.9606 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1699 ns | 0.0069 ns | 0.0061 ns |  4.1695 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9647 ns | 0.0062 ns | 0.0055 ns |  3.9652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4101 ns | 0.0145 ns | 0.0136 ns |  4.4057 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4515 ns | 0.0179 ns | 0.0168 ns |  4.4563 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2357 ns | 0.0035 ns | 0.0032 ns |  1.2357 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2518 ns | 0.0017 ns | 0.0015 ns |  1.2520 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.2135 ns | 0.0044 ns | 0.0039 ns |  1.2139 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.1841 ns | 0.0026 ns | 0.0022 ns |  1.1836 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9685 ns | 0.0027 ns | 0.0025 ns |  0.9683 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6734 ns | 0.0032 ns | 0.0027 ns |  1.6744 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8725 ns | 0.0041 ns | 0.0039 ns |  1.8724 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8761 ns | 0.0038 ns | 0.0035 ns |  1.8755 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3986 ns | 0.0033 ns | 0.0029 ns |  2.3982 ns |  1.43 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.3223 ns | 0.0084 ns | 0.0079 ns |  2.3194 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.3883 ns | 0.0031 ns | 0.0029 ns |  1.3884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2317 ns | 0.0070 ns | 0.0062 ns |  1.2318 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2474 ns | 0.0047 ns | 0.0039 ns |  1.2468 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9902 ns | 0.0031 ns | 0.0029 ns |  0.9903 ns |  0.71 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9683 ns | 0.0043 ns | 0.0040 ns |  0.9685 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6894 ns | 0.0032 ns | 0.0028 ns |  1.6895 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8650 ns | 0.0051 ns | 0.0047 ns |  1.8643 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7946 ns | 0.0249 ns | 0.0208 ns |  1.7925 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.2803 ns | 0.0043 ns | 0.0038 ns |  2.2795 ns |  1.35 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.4544 ns | 0.0050 ns | 0.0042 ns |  2.4535 ns |  1.45 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.2281 ns | 0.0019 ns | 0.0017 ns |  1.2280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6581 ns | 0.0185 ns | 0.0173 ns |  1.6608 ns |  1.35 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3869 ns | 0.0059 ns | 0.0056 ns |  1.3854 ns |  1.13 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.3858 ns | 0.0029 ns | 0.0026 ns |  1.3851 ns |  1.13 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1286 ns | 0.0022 ns | 0.0019 ns |  1.1295 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.1916 ns | 0.0072 ns | 0.0067 ns |  4.1919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4046 ns | 0.0033 ns | 0.0026 ns |  4.4045 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2385 ns | 0.0191 ns | 0.0169 ns |  4.2359 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6345 ns | 0.0047 ns | 0.0044 ns |  4.6339 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6418 ns | 0.0077 ns | 0.0064 ns |  4.6442 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3953 ns | 0.0024 ns | 0.0020 ns |  1.3956 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4056 ns | 0.0032 ns | 0.0028 ns |  1.4055 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4581 ns | 0.0055 ns | 0.0049 ns |  1.4567 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0128 ns | 0.0030 ns | 0.0026 ns |  1.0123 ns |  0.73 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.9966 ns | 0.0078 ns | 0.0061 ns |  0.9974 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9245 ns | 0.0078 ns | 0.0073 ns |  1.9230 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.3117 ns | 0.0730 ns | 0.1458 ns |  2.2817 ns |  1.23 |    0.08 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.6521 ns | 0.0039 ns | 0.0035 ns |  1.6520 ns |  0.86 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.4237 ns | 0.0083 ns | 0.0078 ns |  2.4191 ns |  1.26 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.3255 ns | 0.0023 ns | 0.0020 ns |  2.3255 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.6152 ns | 0.0036 ns | 0.0032 ns |  2.6147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.0793 ns | 0.0038 ns | 0.0034 ns |  2.0806 ns |  0.80 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.8939 ns | 0.0052 ns | 0.0046 ns |  1.8934 ns |  0.72 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0816 ns | 0.0312 ns | 0.0277 ns |  6.0890 ns |  2.33 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0337 ns | 0.0081 ns | 0.0076 ns |  6.0323 ns |  2.31 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.9698 ns | 0.0163 ns | 0.0153 ns |  9.9657 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 12.2752 ns | 0.0138 ns | 0.0130 ns | 12.2731 ns |  1.23 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.2267 ns | 0.0032 ns | 0.0028 ns |  2.2267 ns |  0.22 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6544 ns | 0.0179 ns | 0.0149 ns | 10.6492 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6582 ns | 0.0135 ns | 0.0120 ns | 10.6543 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0656 ns | 0.0040 ns | 0.0037 ns |  2.0647 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3255 ns | 0.0080 ns | 0.0075 ns |  2.3254 ns |  1.13 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1403 ns | 0.0120 ns | 0.0113 ns |  2.1407 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.4089 ns | 0.0035 ns | 0.0029 ns |  1.4083 ns |  0.68 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.4148 ns | 0.0025 ns | 0.0022 ns |  1.4154 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9855 ns | 0.0107 ns | 0.0100 ns |  7.9842 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5001 ns | 0.0303 ns | 0.0253 ns |  8.5051 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8932 ns | 0.0046 ns | 0.0041 ns |  1.8938 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.3141 ns | 0.0105 ns | 0.0093 ns |  8.3138 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1307 ns | 0.0113 ns | 0.0094 ns |  8.1269 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2404 ns | 0.0046 ns | 0.0040 ns |  1.2406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.3145 ns | 0.0020 ns | 0.0019 ns |  1.3143 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2443 ns | 0.0141 ns | 0.0118 ns |  1.2485 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  1.3962 ns | 0.0014 ns | 0.0013 ns |  1.3963 ns |  1.13 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.1460 ns | 0.0045 ns | 0.0042 ns |  1.1467 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.3837 ns | 0.0050 ns | 0.0045 ns |  1.3826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4299 ns | 0.0061 ns | 0.0057 ns |  1.4286 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.2967 ns | 0.0049 ns | 0.0043 ns |  1.2960 ns |  0.94 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.3896 ns | 0.0027 ns | 0.0024 ns |  1.3899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2428 ns | 0.0042 ns | 0.0039 ns |  1.2425 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4090 ns | 0.0031 ns | 0.0028 ns |  1.4088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4098 ns | 0.0025 ns | 0.0023 ns |  1.4099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.3177 ns | 0.0048 ns | 0.0042 ns |  1.3170 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2747 ns | 0.0031 ns | 0.0029 ns |  1.2747 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2419 ns | 0.0036 ns | 0.0030 ns |  1.2408 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.1963 ns | 0.0071 ns | 0.0067 ns |  4.1937 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4112 ns | 0.0079 ns | 0.0066 ns |  4.4100 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9914 ns | 0.0062 ns | 0.0055 ns |  3.9917 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6357 ns | 0.0039 ns | 0.0036 ns |  4.6354 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6403 ns | 0.0079 ns | 0.0074 ns |  4.6397 ns |  1.11 |    0.00 |     - |     - |     - |         - |
