
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 | 1.1606 ns | 0.0033 ns | 0.0031 ns | 1.1599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 | 1.0263 ns | 0.0061 ns | 0.0051 ns | 1.0274 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 | 1.0079 ns | 0.0055 ns | 0.0052 ns | 1.0070 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 | 0.7181 ns | 0.0024 ns | 0.0021 ns | 0.7178 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 | 0.5286 ns | 0.0025 ns | 0.0023 ns | 0.5278 ns |  0.46 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 | 3.9427 ns | 0.0063 ns | 0.0059 ns | 3.9406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 4.1770 ns | 0.0079 ns | 0.0070 ns | 4.1772 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 | 3.9626 ns | 0.0052 ns | 0.0046 ns | 3.9630 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 | 4.1681 ns | 0.0038 ns | 0.0035 ns | 4.1682 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 | 4.1705 ns | 0.0068 ns | 0.0060 ns | 4.1722 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 | 1.6793 ns | 0.0046 ns | 0.0041 ns | 1.6787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 | 1.4989 ns | 0.0143 ns | 0.0133 ns | 1.5055 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 | 1.3872 ns | 0.0013 ns | 0.0011 ns | 1.3874 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 | 1.3346 ns | 0.0033 ns | 0.0030 ns | 1.3355 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 | 0.9485 ns | 0.0049 ns | 0.0045 ns | 0.9474 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 | 1.0978 ns | 0.0042 ns | 0.0035 ns | 1.0988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 | 0.9786 ns | 0.0026 ns | 0.0022 ns | 0.9787 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 | 0.9452 ns | 0.0024 ns | 0.0021 ns | 0.9446 ns |  0.86 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 | 1.1778 ns | 0.0053 ns | 0.0049 ns | 1.1767 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 | 0.9679 ns | 0.0069 ns | 0.0061 ns | 0.9693 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 | 1.4985 ns | 0.0032 ns | 0.0030 ns | 1.4986 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 1.4237 ns | 0.0123 ns | 0.0115 ns | 1.4183 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 | 1.3809 ns | 0.0028 ns | 0.0026 ns | 1.3821 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 | 1.1712 ns | 0.0067 ns | 0.0063 ns | 1.1709 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 | 0.9616 ns | 0.0023 ns | 0.0019 ns | 0.9618 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 4.2101 ns | 0.0074 ns | 0.0066 ns | 4.2081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 4.4075 ns | 0.0038 ns | 0.0033 ns | 4.4079 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 | 3.9400 ns | 0.0060 ns | 0.0056 ns | 3.9389 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 4.4072 ns | 0.0145 ns | 0.0135 ns | 4.4022 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 4.3977 ns | 0.0058 ns | 0.0054 ns | 4.3963 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 | 1.6394 ns | 0.0057 ns | 0.0050 ns | 1.6381 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 1.2499 ns | 0.0027 ns | 0.0025 ns | 1.2501 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 | 1.3982 ns | 0.0026 ns | 0.0023 ns | 1.3977 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 | 0.9903 ns | 0.0033 ns | 0.0031 ns | 0.9897 ns |  0.60 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 | 0.9612 ns | 0.0029 ns | 0.0027 ns | 0.9614 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 | 4.1745 ns | 0.0079 ns | 0.0062 ns | 4.1725 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 4.4141 ns | 0.0074 ns | 0.0066 ns | 4.4144 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 | 3.9404 ns | 0.0104 ns | 0.0098 ns | 3.9396 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 4.4419 ns | 0.0129 ns | 0.0121 ns | 4.4401 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 4.4344 ns | 0.0246 ns | 0.0206 ns | 4.4425 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 | 1.4991 ns | 0.0038 ns | 0.0034 ns | 1.4988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 1.3248 ns | 0.0040 ns | 0.0038 ns | 1.3250 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 | 1.4421 ns | 0.0119 ns | 0.0100 ns | 1.4463 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 | 0.9914 ns | 0.0022 ns | 0.0020 ns | 0.9914 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 | 0.9610 ns | 0.0015 ns | 0.0013 ns | 0.9612 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 | 4.1674 ns | 0.0070 ns | 0.0066 ns | 4.1683 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 4.4065 ns | 0.0095 ns | 0.0089 ns | 4.4052 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 | 3.9530 ns | 0.0078 ns | 0.0069 ns | 3.9507 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 4.4103 ns | 0.0050 ns | 0.0042 ns | 4.4089 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 4.4016 ns | 0.0056 ns | 0.0050 ns | 4.4034 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 | 1.6243 ns | 0.0034 ns | 0.0031 ns | 1.6246 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 1.4095 ns | 0.0165 ns | 0.0154 ns | 1.4032 ns |  0.87 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 | 1.2407 ns | 0.0070 ns | 0.0062 ns | 1.2393 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 | 1.1912 ns | 0.0030 ns | 0.0026 ns | 1.1910 ns |  0.73 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 | 1.2822 ns | 0.0020 ns | 0.0018 ns | 1.2823 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 3.9395 ns | 0.0071 ns | 0.0063 ns | 3.9401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 4.1850 ns | 0.0075 ns | 0.0070 ns | 4.1839 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 | 3.9676 ns | 0.0057 ns | 0.0053 ns | 3.9675 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 4.4444 ns | 0.0061 ns | 0.0054 ns | 4.4448 ns |  1.13 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 4.4029 ns | 0.0083 ns | 0.0078 ns | 4.4039 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 | 1.4941 ns | 0.0028 ns | 0.0024 ns | 1.4942 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 1.3437 ns | 0.0020 ns | 0.0018 ns | 1.3440 ns |  0.90 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 | 1.2771 ns | 0.0037 ns | 0.0032 ns | 1.2771 ns |  0.85 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 | 0.9902 ns | 0.0017 ns | 0.0014 ns | 0.9896 ns |  0.66 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 | 0.9644 ns | 0.0041 ns | 0.0039 ns | 0.9644 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 | 3.9352 ns | 0.0055 ns | 0.0048 ns | 3.9360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 4.1730 ns | 0.0045 ns | 0.0042 ns | 4.1735 ns |  1.06 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 | 3.9643 ns | 0.0054 ns | 0.0048 ns | 3.9640 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 4.4142 ns | 0.0068 ns | 0.0064 ns | 4.4124 ns |  1.12 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 4.4020 ns | 0.0054 ns | 0.0048 ns | 4.4023 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 | 1.5443 ns | 0.0032 ns | 0.0030 ns | 1.5442 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 1.4205 ns | 0.0018 ns | 0.0015 ns | 1.4204 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 | 1.5605 ns | 0.0043 ns | 0.0036 ns | 1.5600 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 | 1.1724 ns | 0.0022 ns | 0.0019 ns | 1.1724 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 | 0.9650 ns | 0.0029 ns | 0.0026 ns | 0.9650 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 3.9381 ns | 0.0112 ns | 0.0105 ns | 3.9352 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 4.2077 ns | 0.0199 ns | 0.0176 ns | 4.2158 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 | 3.9396 ns | 0.0046 ns | 0.0043 ns | 3.9401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 4.4118 ns | 0.0038 ns | 0.0034 ns | 4.4122 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 4.4043 ns | 0.0069 ns | 0.0061 ns | 4.4048 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 | 1.4084 ns | 0.0039 ns | 0.0037 ns | 1.4083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 1.2264 ns | 0.0032 ns | 0.0028 ns | 1.2267 ns |  0.87 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 | 1.2178 ns | 0.0021 ns | 0.0020 ns | 1.2187 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 | 0.9914 ns | 0.0037 ns | 0.0035 ns | 0.9913 ns |  0.70 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 | 0.9745 ns | 0.0090 ns | 0.0085 ns | 0.9768 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 | 1.7915 ns | 0.0029 ns | 0.0027 ns | 1.7922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 1.8453 ns | 0.0031 ns | 0.0028 ns | 1.8454 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 | 2.0043 ns | 0.0050 ns | 0.0045 ns | 2.0041 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 | 1.9446 ns | 0.0051 ns | 0.0047 ns | 1.9442 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 | 1.8818 ns | 0.0040 ns | 0.0036 ns | 1.8819 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 | 1.5614 ns | 0.0030 ns | 0.0028 ns | 1.5621 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 1.2261 ns | 0.0053 ns | 0.0049 ns | 1.2263 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 | 1.5594 ns | 0.0124 ns | 0.0116 ns | 1.5625 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 | 0.9900 ns | 0.0022 ns | 0.0021 ns | 0.9901 ns |  0.63 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 | 0.9625 ns | 0.0031 ns | 0.0029 ns | 0.9620 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 | 1.7938 ns | 0.0033 ns | 0.0027 ns | 1.7932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 2.1029 ns | 0.0044 ns | 0.0039 ns | 2.1036 ns |  1.17 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 | 1.7751 ns | 0.0081 ns | 0.0076 ns | 1.7723 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 | 2.3981 ns | 0.0052 ns | 0.0049 ns | 2.3965 ns |  1.34 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 | 2.3165 ns | 0.0038 ns | 0.0034 ns | 2.3161 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 | 1.1144 ns | 0.0138 ns | 0.0129 ns | 1.1070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 1.1770 ns | 0.0034 ns | 0.0030 ns | 1.1763 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 | 1.1192 ns | 0.0149 ns | 0.0140 ns | 1.1212 ns |  1.00 |    0.02 |     - |     - |     - |         - |
            ToFloat |        net461 | 0.7076 ns | 0.0033 ns | 0.0030 ns | 0.7077 ns |  0.63 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 | 0.6377 ns | 0.0017 ns | 0.0016 ns | 0.6378 ns |  0.57 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 3.9554 ns | 0.0087 ns | 0.0081 ns | 3.9532 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 4.4099 ns | 0.0111 ns | 0.0104 ns | 4.4077 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 | 4.1916 ns | 0.0056 ns | 0.0053 ns | 4.1927 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 4.4114 ns | 0.0052 ns | 0.0049 ns | 4.4109 ns |  1.12 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 4.4028 ns | 0.0065 ns | 0.0058 ns | 4.4017 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 | 1.0831 ns | 0.0028 ns | 0.0026 ns | 1.0838 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 1.1743 ns | 0.0026 ns | 0.0024 ns | 1.1743 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 | 1.0155 ns | 0.0025 ns | 0.0022 ns | 1.0155 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 | 0.7072 ns | 0.0026 ns | 0.0025 ns | 0.7061 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 | 0.6414 ns | 0.0021 ns | 0.0019 ns | 0.6411 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 | 1.7719 ns | 0.0029 ns | 0.0026 ns | 1.7716 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 | 1.8385 ns | 0.0018 ns | 0.0015 ns | 1.8386 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 | 1.7934 ns | 0.0031 ns | 0.0027 ns | 1.7929 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 | 1.7004 ns | 0.0055 ns | 0.0048 ns | 1.6996 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 | 1.6810 ns | 0.0029 ns | 0.0026 ns | 1.6809 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 | 1.7946 ns | 0.0141 ns | 0.0132 ns | 1.8030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 | 1.8741 ns | 0.0014 ns | 0.0012 ns | 1.8743 ns |  1.04 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 | 1.8542 ns | 0.0062 ns | 0.0058 ns | 1.8539 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 | 6.0743 ns | 0.0062 ns | 0.0058 ns | 6.0755 ns |  3.38 |    0.03 |     - |     - |     - |         - |
          ToDecimal |        net472 | 5.7841 ns | 0.0054 ns | 0.0048 ns | 5.7845 ns |  3.22 |    0.02 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 1.5590 ns | 0.0026 ns | 0.0021 ns | 1.5592 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 1.8537 ns | 0.0045 ns | 0.0040 ns | 1.8540 ns |  1.19 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 1.5464 ns | 0.0019 ns | 0.0018 ns | 1.5466 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 1.9331 ns | 0.0094 ns | 0.0088 ns | 1.9359 ns |  1.24 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 1.8705 ns | 0.0039 ns | 0.0035 ns | 1.8699 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 | 2.2593 ns | 0.0021 ns | 0.0020 ns | 2.2596 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 | 2.1175 ns | 0.0042 ns | 0.0037 ns | 2.1167 ns |  0.94 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 | 2.2342 ns | 0.0048 ns | 0.0040 ns | 2.2340 ns |  0.99 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 | 1.1782 ns | 0.0027 ns | 0.0025 ns | 1.1792 ns |  0.52 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 | 1.1791 ns | 0.0071 ns | 0.0060 ns | 1.1772 ns |  0.52 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 | 7.9182 ns | 0.0383 ns | 0.0358 ns | 7.9361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 | 8.3884 ns | 0.0144 ns | 0.0135 ns | 8.3860 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 | 1.8660 ns | 0.0022 ns | 0.0020 ns | 1.8653 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 8.4124 ns | 0.0138 ns | 0.0116 ns | 8.4105 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 8.3114 ns | 0.0147 ns | 0.0138 ns | 8.3123 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 | 1.4112 ns | 0.0029 ns | 0.0027 ns | 1.4102 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 | 1.4177 ns | 0.0027 ns | 0.0023 ns | 1.4178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 | 1.3903 ns | 0.0025 ns | 0.0024 ns | 1.3909 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 | 0.9784 ns | 0.0029 ns | 0.0027 ns | 0.9785 ns |  0.69 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 | 0.9527 ns | 0.0020 ns | 0.0016 ns | 0.9523 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 | 1.5466 ns | 0.0145 ns | 0.0135 ns | 1.5379 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 | 1.4170 ns | 0.0025 ns | 0.0022 ns | 1.4173 ns |  0.92 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 | 1.4382 ns | 0.0099 ns | 0.0092 ns | 1.4428 ns |  0.93 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 | 1.2676 ns | 0.0021 ns | 0.0019 ns | 1.2670 ns |  0.82 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 | 1.8259 ns | 0.0025 ns | 0.0021 ns | 1.8257 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 | 1.5456 ns | 0.0028 ns | 0.0026 ns | 1.5457 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 1.4260 ns | 0.0048 ns | 0.0045 ns | 1.4264 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 1.3822 ns | 0.0033 ns | 0.0029 ns | 1.3828 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 1.3318 ns | 0.0026 ns | 0.0023 ns | 1.3325 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 | 1.2891 ns | 0.0028 ns | 0.0027 ns | 1.2898 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 4.1684 ns | 0.0050 ns | 0.0047 ns | 4.1675 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 4.4186 ns | 0.0293 ns | 0.0274 ns | 4.4303 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 3.9632 ns | 0.0052 ns | 0.0046 ns | 3.9645 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 4.6375 ns | 0.0050 ns | 0.0047 ns | 4.6373 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 4.6246 ns | 0.0059 ns | 0.0053 ns | 4.6231 ns |  1.11 |    0.00 |     - |     - |     - |         - |
