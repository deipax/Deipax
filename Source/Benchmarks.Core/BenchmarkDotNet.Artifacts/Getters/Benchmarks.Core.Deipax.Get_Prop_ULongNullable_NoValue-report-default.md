
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
             ToBool | .NET Core 2.0 |  1.1656 ns | 0.0046 ns | 0.0043 ns |  1.1655 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6109 ns | 0.0038 ns | 0.0032 ns |  1.6113 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3841 ns | 0.0026 ns | 0.0023 ns |  1.3843 ns |  1.19 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  1.6096 ns | 0.0045 ns | 0.0038 ns |  1.6091 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9906 ns | 0.0028 ns | 0.0023 ns |  0.9903 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9759 ns | 0.0064 ns | 0.0057 ns |  3.9756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2265 ns | 0.0045 ns | 0.0042 ns |  4.2266 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0411 ns | 0.0170 ns | 0.0159 ns |  4.0425 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1704 ns | 0.0275 ns | 0.0257 ns |  4.1563 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1482 ns | 0.0059 ns | 0.0053 ns |  4.1487 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.2870 ns | 0.0090 ns | 0.0084 ns |  1.2891 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4803 ns | 0.0039 ns | 0.0037 ns |  1.4806 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2627 ns | 0.0046 ns | 0.0038 ns |  1.2621 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9659 ns | 0.0029 ns | 0.0027 ns |  0.9662 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9990 ns | 0.0110 ns | 0.0097 ns |  0.9953 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2051 ns | 0.0055 ns | 0.0046 ns |  4.2050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1705 ns | 0.0071 ns | 0.0063 ns |  4.1680 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0072 ns | 0.0168 ns | 0.0157 ns |  4.0118 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3799 ns | 0.0059 ns | 0.0055 ns |  4.3821 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3839 ns | 0.0066 ns | 0.0052 ns |  4.3847 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1867 ns | 0.0027 ns | 0.0025 ns |  1.1870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4128 ns | 0.0030 ns | 0.0025 ns |  1.4136 ns |  1.19 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2389 ns | 0.0046 ns | 0.0043 ns |  1.2388 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9654 ns | 0.0038 ns | 0.0036 ns |  0.9641 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9919 ns | 0.0032 ns | 0.0030 ns |  0.9925 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.3759 ns | 0.0073 ns | 0.0069 ns |  4.3750 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.3981 ns | 0.0049 ns | 0.0044 ns |  4.3989 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9985 ns | 0.0057 ns | 0.0048 ns |  3.9995 ns |  0.91 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.3848 ns | 0.0072 ns | 0.0067 ns |  4.3839 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.3750 ns | 0.0049 ns | 0.0046 ns |  4.3730 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.2539 ns | 0.0041 ns | 0.0037 ns |  1.2531 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4101 ns | 0.0040 ns | 0.0035 ns |  1.4111 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3854 ns | 0.0038 ns | 0.0034 ns |  1.3847 ns |  1.10 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9614 ns | 0.0051 ns | 0.0047 ns |  0.9594 ns |  0.77 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  1.0034 ns | 0.0035 ns | 0.0029 ns |  1.0037 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.1845 ns | 0.0039 ns | 0.0035 ns |  4.1843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1691 ns | 0.0068 ns | 0.0057 ns |  4.1697 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0010 ns | 0.0076 ns | 0.0071 ns |  4.0001 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.3788 ns | 0.0068 ns | 0.0064 ns |  4.3779 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.3795 ns | 0.0057 ns | 0.0051 ns |  4.3801 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.1661 ns | 0.0026 ns | 0.0021 ns |  1.1657 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5358 ns | 0.0027 ns | 0.0024 ns |  1.5365 ns |  1.32 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2429 ns | 0.0039 ns | 0.0036 ns |  1.2426 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9640 ns | 0.0029 ns | 0.0027 ns |  0.9641 ns |  0.83 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9934 ns | 0.0038 ns | 0.0032 ns |  0.9938 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2507 ns | 0.0167 ns | 0.0157 ns |  4.2546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1720 ns | 0.0075 ns | 0.0067 ns |  4.1714 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  3.9776 ns | 0.0077 ns | 0.0065 ns |  3.9770 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.3795 ns | 0.0101 ns | 0.0079 ns |  4.3789 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.3811 ns | 0.0035 ns | 0.0033 ns |  4.3811 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.2690 ns | 0.0036 ns | 0.0033 ns |  1.2680 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4054 ns | 0.0041 ns | 0.0036 ns |  1.4058 ns |  1.11 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4121 ns | 0.0021 ns | 0.0019 ns |  1.4117 ns |  1.11 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9625 ns | 0.0031 ns | 0.0029 ns |  0.9620 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.0025 ns | 0.0088 ns | 0.0078 ns |  1.0036 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2045 ns | 0.0032 ns | 0.0026 ns |  4.2053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1721 ns | 0.0078 ns | 0.0070 ns |  4.1696 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9736 ns | 0.0069 ns | 0.0061 ns |  3.9715 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.3807 ns | 0.0071 ns | 0.0063 ns |  4.3797 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3720 ns | 0.0078 ns | 0.0069 ns |  4.3717 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.1838 ns | 0.0047 ns | 0.0044 ns |  1.1836 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5415 ns | 0.0039 ns | 0.0037 ns |  1.5410 ns |  1.30 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2554 ns | 0.0031 ns | 0.0028 ns |  1.2554 ns |  1.06 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9503 ns | 0.0209 ns | 0.0195 ns |  0.9553 ns |  0.80 |    0.02 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9586 ns | 0.0025 ns | 0.0022 ns |  0.9583 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2037 ns | 0.0045 ns | 0.0038 ns |  4.2050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1916 ns | 0.0323 ns | 0.0302 ns |  4.1748 ns |  1.00 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9757 ns | 0.0071 ns | 0.0066 ns |  3.9780 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.3878 ns | 0.0078 ns | 0.0069 ns |  4.3872 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3760 ns | 0.0076 ns | 0.0071 ns |  4.3743 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.3402 ns | 0.0088 ns | 0.0078 ns |  1.3406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4138 ns | 0.0045 ns | 0.0040 ns |  1.4131 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4134 ns | 0.0049 ns | 0.0038 ns |  1.4142 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9288 ns | 0.0019 ns | 0.0017 ns |  0.9291 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9953 ns | 0.0018 ns | 0.0015 ns |  0.9959 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4327 ns | 0.0053 ns | 0.0049 ns |  4.4312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4398 ns | 0.0256 ns | 0.0214 ns |  4.4479 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9593 ns | 0.0045 ns | 0.0040 ns |  3.9599 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.3790 ns | 0.0060 ns | 0.0056 ns |  4.3788 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.3727 ns | 0.0057 ns | 0.0051 ns |  4.3737 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2580 ns | 0.0192 ns | 0.0180 ns |  1.2461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4785 ns | 0.0034 ns | 0.0032 ns |  1.4778 ns |  1.18 |    0.02 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4111 ns | 0.0032 ns | 0.0030 ns |  1.4117 ns |  1.12 |    0.02 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9315 ns | 0.0041 ns | 0.0036 ns |  0.9311 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9583 ns | 0.0031 ns | 0.0027 ns |  0.9595 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9014 ns | 0.0088 ns | 0.0083 ns |  1.9009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3079 ns | 0.0134 ns | 0.0119 ns |  2.3104 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9733 ns | 0.0091 ns | 0.0085 ns |  1.9763 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.2140 ns | 0.0096 ns | 0.0085 ns |  2.2157 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2608 ns | 0.0020 ns | 0.0017 ns |  2.2610 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4228 ns | 0.0021 ns | 0.0018 ns |  1.4227 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4173 ns | 0.0034 ns | 0.0028 ns |  1.4173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.6723 ns | 0.0580 ns | 0.0621 ns |  1.6853 ns |  1.17 |    0.05 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9503 ns | 0.0041 ns | 0.0038 ns |  0.9507 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  1.1751 ns | 0.0030 ns | 0.0027 ns |  1.1754 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6910 ns | 0.0045 ns | 0.0040 ns |  1.6904 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.6077 ns | 0.0035 ns | 0.0029 ns |  1.6070 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.5282 ns | 0.0023 ns | 0.0022 ns |  1.5280 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5002 ns | 0.0038 ns | 0.0033 ns |  1.5009 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.5999 ns | 0.0106 ns | 0.0094 ns |  1.6034 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4013 ns | 0.0048 ns | 0.0043 ns |  1.4009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3466 ns | 0.0015 ns | 0.0013 ns |  1.3466 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2309 ns | 0.0048 ns | 0.0043 ns |  1.2319 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9851 ns | 0.0038 ns | 0.0036 ns |  0.9846 ns |  0.70 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0386 ns | 0.0099 ns | 0.0088 ns |  1.0400 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2217 ns | 0.0334 ns | 0.0313 ns |  4.2027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4012 ns | 0.0084 ns | 0.0066 ns |  4.4015 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2333 ns | 0.0326 ns | 0.0305 ns |  4.2214 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6802 ns | 0.0221 ns | 0.0207 ns |  4.6717 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6132 ns | 0.0086 ns | 0.0080 ns |  4.6111 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4448 ns | 0.0050 ns | 0.0047 ns |  1.4447 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3511 ns | 0.0051 ns | 0.0045 ns |  1.3523 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2313 ns | 0.0026 ns | 0.0022 ns |  1.2317 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9852 ns | 0.0022 ns | 0.0018 ns |  0.9848 ns |  0.68 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.2191 ns | 0.0069 ns | 0.0064 ns |  1.2197 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1784 ns | 0.0106 ns | 0.0089 ns |  2.1806 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.3038 ns | 0.0257 ns | 0.0240 ns |  2.2879 ns |  1.06 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1011 ns | 0.0070 ns | 0.0065 ns |  2.0986 ns |  0.96 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1028 ns | 0.0148 ns | 0.0138 ns |  2.1105 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.2661 ns | 0.0111 ns | 0.0104 ns |  2.2620 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.9440 ns | 0.0162 ns | 0.0151 ns |  1.9379 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.0570 ns | 0.0030 ns | 0.0026 ns |  2.0575 ns |  1.06 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.9869 ns | 0.0034 ns | 0.0030 ns |  1.9880 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0552 ns | 0.0085 ns | 0.0075 ns |  6.0566 ns |  3.11 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  5.9989 ns | 0.0075 ns | 0.0071 ns |  5.9979 ns |  3.09 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0125 ns | 0.0143 ns | 0.0134 ns | 10.0160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7076 ns | 0.0192 ns | 0.0160 ns | 10.7077 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.1822 ns | 0.0044 ns | 0.0039 ns |  2.1827 ns |  0.22 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6286 ns | 0.0116 ns | 0.0097 ns | 10.6274 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6282 ns | 0.0185 ns | 0.0173 ns | 10.6261 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  1.8399 ns | 0.0057 ns | 0.0051 ns |  1.8388 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3041 ns | 0.0048 ns | 0.0045 ns |  2.3031 ns |  1.25 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2013 ns | 0.0803 ns | 0.0824 ns |  2.1645 ns |  1.20 |    0.05 |     - |     - |     - |         - |
         ToDateTime |        net461 |  0.9937 ns | 0.0039 ns | 0.0035 ns |  0.9937 ns |  0.54 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1451 ns | 0.0090 ns | 0.0084 ns |  1.1469 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0171 ns | 0.0263 ns | 0.0233 ns |  8.0210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4863 ns | 0.0190 ns | 0.0178 ns |  8.4904 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9119 ns | 0.0104 ns | 0.0087 ns |  1.9154 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1672 ns | 0.0165 ns | 0.0154 ns |  8.1649 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.6093 ns | 0.0144 ns | 0.0128 ns |  8.6052 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2299 ns | 0.0040 ns | 0.0038 ns |  1.2297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4809 ns | 0.0038 ns | 0.0033 ns |  1.4811 ns |  1.20 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2296 ns | 0.0030 ns | 0.0025 ns |  1.2299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9581 ns | 0.0098 ns | 0.0092 ns |  0.9611 ns |  0.78 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9809 ns | 0.0025 ns | 0.0022 ns |  0.9811 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.3949 ns | 0.0153 ns | 0.0143 ns |  1.3842 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4671 ns | 0.0038 ns | 0.0036 ns |  1.4665 ns |  1.05 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.3867 ns | 0.0036 ns | 0.0032 ns |  1.3875 ns |  0.99 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.2390 ns | 0.0023 ns | 0.0020 ns |  1.2392 ns |  0.89 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2643 ns | 0.0036 ns | 0.0032 ns |  1.2641 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4099 ns | 0.0038 ns | 0.0031 ns |  1.4098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6255 ns | 0.0039 ns | 0.0031 ns |  1.6259 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.4237 ns | 0.0149 ns | 0.0139 ns |  1.4177 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.3017 ns | 0.0137 ns | 0.0128 ns |  1.2954 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.3210 ns | 0.0047 ns | 0.0039 ns |  1.3212 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2090 ns | 0.0151 ns | 0.0134 ns |  4.2055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4101 ns | 0.0088 ns | 0.0083 ns |  4.4105 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9764 ns | 0.0074 ns | 0.0066 ns |  3.9747 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6124 ns | 0.0073 ns | 0.0065 ns |  4.6120 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6131 ns | 0.0110 ns | 0.0097 ns |  4.6121 ns |  1.10 |    0.00 |     - |     - |     - |         - |
