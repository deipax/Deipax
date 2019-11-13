
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
             ToBool | .NET Core 2.0 |  1.4545 ns | 0.0111 ns | 0.0093 ns |  1.4557 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4732 ns | 0.0046 ns | 0.0041 ns |  1.4720 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4472 ns | 0.0041 ns | 0.0038 ns |  1.4477 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9688 ns | 0.0021 ns | 0.0019 ns |  0.9683 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.0043 ns | 0.0116 ns | 0.0109 ns |  1.0007 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9520 ns | 0.0066 ns | 0.0052 ns |  3.9523 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1786 ns | 0.0089 ns | 0.0079 ns |  4.1795 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9706 ns | 0.0047 ns | 0.0036 ns |  3.9702 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1837 ns | 0.0050 ns | 0.0045 ns |  4.1827 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1944 ns | 0.0185 ns | 0.0173 ns |  4.1975 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5450 ns | 0.0036 ns | 0.0032 ns |  1.5446 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5136 ns | 0.0045 ns | 0.0040 ns |  1.5132 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4428 ns | 0.0035 ns | 0.0029 ns |  1.4418 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9700 ns | 0.0018 ns | 0.0016 ns |  0.9705 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.0049 ns | 0.0039 ns | 0.0037 ns |  1.0045 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.1824 ns | 0.0072 ns | 0.0060 ns |  4.1817 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4082 ns | 0.0059 ns | 0.0052 ns |  4.4069 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0569 ns | 0.0169 ns | 0.0150 ns |  4.0615 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4182 ns | 0.0044 ns | 0.0039 ns |  4.4181 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4236 ns | 0.0238 ns | 0.0211 ns |  4.4282 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4431 ns | 0.0023 ns | 0.0021 ns |  1.4437 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4719 ns | 0.0034 ns | 0.0032 ns |  1.4717 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4460 ns | 0.0026 ns | 0.0023 ns |  1.4455 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9690 ns | 0.0028 ns | 0.0026 ns |  0.9684 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.0022 ns | 0.0021 ns | 0.0020 ns |  1.0021 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.1776 ns | 0.0071 ns | 0.0066 ns |  4.1764 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1765 ns | 0.0043 ns | 0.0040 ns |  4.1770 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0131 ns | 0.0130 ns | 0.0121 ns |  4.0147 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4628 ns | 0.0094 ns | 0.0083 ns |  4.4610 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4389 ns | 0.0079 ns | 0.0074 ns |  4.4405 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5461 ns | 0.0098 ns | 0.0091 ns |  1.5418 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4746 ns | 0.0045 ns | 0.0037 ns |  1.4753 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4441 ns | 0.0062 ns | 0.0052 ns |  1.4427 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9682 ns | 0.0020 ns | 0.0016 ns |  0.9675 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.2164 ns | 0.0026 ns | 0.0023 ns |  1.2174 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.1838 ns | 0.0039 ns | 0.0032 ns |  4.1848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1751 ns | 0.0048 ns | 0.0043 ns |  4.1743 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0562 ns | 0.0168 ns | 0.0149 ns |  4.0591 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4151 ns | 0.0115 ns | 0.0107 ns |  4.4136 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.3773 ns | 0.0053 ns | 0.0044 ns |  4.3774 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.6276 ns | 0.0036 ns | 0.0034 ns |  1.6271 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5406 ns | 0.0029 ns | 0.0024 ns |  1.5408 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2409 ns | 0.0042 ns | 0.0035 ns |  1.2402 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9631 ns | 0.0087 ns | 0.0081 ns |  0.9587 ns |  0.59 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.0005 ns | 0.0097 ns | 0.0091 ns |  1.0027 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  1.1071 ns | 0.0018 ns | 0.0016 ns |  1.1071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  1.1760 ns | 0.0041 ns | 0.0036 ns |  1.1760 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  1.1670 ns | 0.0043 ns | 0.0034 ns |  1.1681 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  0.9760 ns | 0.0033 ns | 0.0029 ns |  0.9762 ns |  0.88 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  1.1336 ns | 0.0041 ns | 0.0032 ns |  1.1348 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6302 ns | 0.0020 ns | 0.0019 ns |  1.6302 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5387 ns | 0.0066 ns | 0.0061 ns |  1.5366 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4806 ns | 0.0030 ns | 0.0028 ns |  1.4818 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9687 ns | 0.0022 ns | 0.0020 ns |  0.9689 ns |  0.59 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.0034 ns | 0.0022 ns | 0.0019 ns |  1.0038 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.1840 ns | 0.0060 ns | 0.0047 ns |  4.1848 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4030 ns | 0.0053 ns | 0.0047 ns |  4.4036 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0546 ns | 0.0110 ns | 0.0103 ns |  4.0551 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4175 ns | 0.0061 ns | 0.0057 ns |  4.4161 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3813 ns | 0.0097 ns | 0.0091 ns |  4.3781 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.5004 ns | 0.0028 ns | 0.0025 ns |  1.5005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5134 ns | 0.0031 ns | 0.0027 ns |  1.5135 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.5022 ns | 0.0043 ns | 0.0038 ns |  1.5029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9984 ns | 0.0060 ns | 0.0050 ns |  0.9964 ns |  0.67 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  1.0034 ns | 0.0032 ns | 0.0030 ns |  1.0035 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9305 ns | 0.0068 ns | 0.0064 ns |  3.9293 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1750 ns | 0.0058 ns | 0.0054 ns |  4.1734 ns |  1.06 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0173 ns | 0.0077 ns | 0.0068 ns |  4.0166 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4176 ns | 0.0052 ns | 0.0044 ns |  4.4170 ns |  1.12 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4317 ns | 0.0126 ns | 0.0118 ns |  4.4358 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5716 ns | 0.0072 ns | 0.0060 ns |  1.5720 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6689 ns | 0.0037 ns | 0.0033 ns |  1.6697 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.3908 ns | 0.0040 ns | 0.0035 ns |  1.3902 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9381 ns | 0.0040 ns | 0.0035 ns |  0.9376 ns |  0.60 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9798 ns | 0.0027 ns | 0.0024 ns |  0.9796 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.1816 ns | 0.0052 ns | 0.0046 ns |  4.1809 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4097 ns | 0.0041 ns | 0.0035 ns |  4.4099 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0142 ns | 0.0059 ns | 0.0055 ns |  4.0136 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4172 ns | 0.0049 ns | 0.0046 ns |  4.4186 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4416 ns | 0.0071 ns | 0.0066 ns |  4.4413 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4221 ns | 0.0058 ns | 0.0051 ns |  1.4220 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6377 ns | 0.0051 ns | 0.0046 ns |  1.6381 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6537 ns | 0.0039 ns | 0.0037 ns |  1.6536 ns |  1.16 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9687 ns | 0.0037 ns | 0.0031 ns |  0.9692 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0037 ns | 0.0030 ns | 0.0026 ns |  1.0038 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0378 ns | 0.0042 ns | 0.0040 ns |  2.0378 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3353 ns | 0.0034 ns | 0.0030 ns |  2.3352 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1544 ns | 0.0039 ns | 0.0034 ns |  2.1543 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3401 ns | 0.0041 ns | 0.0036 ns |  2.3404 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2562 ns | 0.0035 ns | 0.0029 ns |  2.2567 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.5679 ns | 0.0033 ns | 0.0031 ns |  1.5681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4972 ns | 0.0031 ns | 0.0029 ns |  1.4969 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4453 ns | 0.0050 ns | 0.0039 ns |  1.4443 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9334 ns | 0.0045 ns | 0.0043 ns |  0.9323 ns |  0.60 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  1.3077 ns | 0.0026 ns | 0.0023 ns |  1.3080 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.8875 ns | 0.0069 ns | 0.0061 ns |  2.8870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2831 ns | 0.0052 ns | 0.0049 ns |  2.2835 ns |  0.79 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7148 ns | 0.0048 ns | 0.0043 ns |  1.7157 ns |  0.59 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.3075 ns | 0.0027 ns | 0.0024 ns |  2.3080 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.2797 ns | 0.0049 ns | 0.0044 ns |  2.2796 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3408 ns | 0.0021 ns | 0.0020 ns |  1.3405 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4760 ns | 0.0036 ns | 0.0032 ns |  1.4754 ns |  1.10 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6852 ns | 0.0301 ns | 0.0267 ns |  1.6701 ns |  1.26 |    0.02 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9886 ns | 0.0041 ns | 0.0034 ns |  0.9891 ns |  0.74 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0254 ns | 0.0036 ns | 0.0030 ns |  1.0257 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.1833 ns | 0.0104 ns | 0.0092 ns |  4.1839 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4106 ns | 0.0073 ns | 0.0065 ns |  4.4096 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2015 ns | 0.0052 ns | 0.0046 ns |  4.2015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6468 ns | 0.0041 ns | 0.0035 ns |  4.6466 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6115 ns | 0.0067 ns | 0.0056 ns |  4.6117 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5454 ns | 0.0046 ns | 0.0039 ns |  1.5444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6333 ns | 0.0063 ns | 0.0056 ns |  1.6334 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2439 ns | 0.0109 ns | 0.0102 ns |  1.2468 ns |  0.80 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9864 ns | 0.0035 ns | 0.0031 ns |  0.9871 ns |  0.64 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0225 ns | 0.0029 ns | 0.0026 ns |  1.0230 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0183 ns | 0.0028 ns | 0.0026 ns |  2.0180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9394 ns | 0.0060 ns | 0.0054 ns |  1.9385 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.2139 ns | 0.0167 ns | 0.0148 ns |  2.2209 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1190 ns | 0.0045 ns | 0.0037 ns |  2.1187 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.0885 ns | 0.0055 ns | 0.0051 ns |  2.0904 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.0122 ns | 0.0040 ns | 0.0037 ns |  2.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1740 ns | 0.0042 ns | 0.0040 ns |  2.1738 ns |  1.08 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.4457 ns | 0.0069 ns | 0.0061 ns |  2.4460 ns |  1.22 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.3288 ns | 0.0203 ns | 0.0189 ns |  6.3354 ns |  3.15 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.2540 ns | 0.0124 ns | 0.0116 ns |  6.2545 ns |  3.11 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.9533 ns | 0.0182 ns | 0.0161 ns |  9.9489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7055 ns | 0.0284 ns | 0.0266 ns | 10.6967 ns |  1.08 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3697 ns | 0.0051 ns | 0.0047 ns |  2.3697 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6508 ns | 0.0117 ns | 0.0109 ns | 10.6486 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6489 ns | 0.0133 ns | 0.0124 ns | 10.6486 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2649 ns | 0.0059 ns | 0.0055 ns |  2.2640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1628 ns | 0.0118 ns | 0.0105 ns |  2.1647 ns |  0.95 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3348 ns | 0.0051 ns | 0.0048 ns |  2.3335 ns |  1.03 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1848 ns | 0.0037 ns | 0.0035 ns |  1.1835 ns |  0.52 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1343 ns | 0.0035 ns | 0.0033 ns |  1.1337 ns |  0.50 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8885 ns | 0.0102 ns | 0.0095 ns |  7.8871 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3984 ns | 0.0419 ns | 0.0372 ns |  8.4072 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9440 ns | 0.0045 ns | 0.0035 ns |  1.9431 ns |  0.25 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2111 ns | 0.0245 ns | 0.0217 ns |  8.2041 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4166 ns | 0.0083 ns | 0.0074 ns |  8.4186 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4361 ns | 0.0030 ns | 0.0024 ns |  1.4354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.6450 ns | 0.0043 ns | 0.0038 ns |  1.6445 ns |  1.15 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4892 ns | 0.0077 ns | 0.0072 ns |  1.4903 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9541 ns | 0.0049 ns | 0.0041 ns |  0.9539 ns |  0.66 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9932 ns | 0.0043 ns | 0.0041 ns |  0.9915 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.5510 ns | 0.0036 ns | 0.0033 ns |  1.5508 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6543 ns | 0.0123 ns | 0.0115 ns |  1.6572 ns |  1.07 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.5015 ns | 0.0022 ns | 0.0019 ns |  1.5015 ns |  0.97 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.2371 ns | 0.0029 ns | 0.0027 ns |  1.2366 ns |  0.80 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2728 ns | 0.0039 ns | 0.0036 ns |  1.2729 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.5594 ns | 0.0112 ns | 0.0099 ns |  1.5626 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4713 ns | 0.0036 ns | 0.0034 ns |  1.4701 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5729 ns | 0.0084 ns | 0.0078 ns |  1.5736 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2397 ns | 0.0038 ns | 0.0035 ns |  1.2398 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2723 ns | 0.0024 ns | 0.0023 ns |  1.2722 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.1847 ns | 0.0049 ns | 0.0041 ns |  4.1857 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4088 ns | 0.0070 ns | 0.0065 ns |  4.4118 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0080 ns | 0.0049 ns | 0.0043 ns |  4.0063 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6935 ns | 0.0237 ns | 0.0210 ns |  4.6958 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6175 ns | 0.0063 ns | 0.0052 ns |  4.6166 ns |  1.10 |    0.00 |     - |     - |     - |         - |
