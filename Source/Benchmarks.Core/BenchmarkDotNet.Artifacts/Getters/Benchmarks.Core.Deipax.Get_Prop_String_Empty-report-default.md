
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
             ToBool | .NET Core 2.0 |  1.2107 ns | 0.0039 ns | 0.0034 ns |  1.2107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.3523 ns | 0.0073 ns | 0.0068 ns |  1.3525 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3988 ns | 0.0023 ns | 0.0018 ns |  1.3986 ns |  1.15 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9884 ns | 0.0034 ns | 0.0032 ns |  0.9885 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.1809 ns | 0.0015 ns | 0.0012 ns |  1.1807 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2141 ns | 0.0311 ns | 0.0291 ns |  4.1992 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4123 ns | 0.0052 ns | 0.0048 ns |  4.4125 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9564 ns | 0.0086 ns | 0.0080 ns |  3.9543 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.4420 ns | 0.0159 ns | 0.0149 ns |  4.4471 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.4011 ns | 0.0051 ns | 0.0045 ns |  4.4014 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.3634 ns | 0.0089 ns | 0.0083 ns |  1.3645 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.3961 ns | 0.0027 ns | 0.0024 ns |  1.3961 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.5634 ns | 0.0015 ns | 0.0013 ns |  1.5635 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9775 ns | 0.0025 ns | 0.0024 ns |  0.9776 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.1664 ns | 0.0021 ns | 0.0020 ns |  1.1657 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.6600 ns | 0.0066 ns | 0.0058 ns |  4.6592 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4121 ns | 0.0046 ns | 0.0043 ns |  4.4108 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0373 ns | 0.0106 ns | 0.0099 ns |  4.0402 ns |  0.87 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4108 ns | 0.0056 ns | 0.0053 ns |  4.4112 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3987 ns | 0.0051 ns | 0.0048 ns |  4.3986 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4046 ns | 0.0464 ns | 0.0434 ns |  1.3781 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6877 ns | 0.0024 ns | 0.0023 ns |  1.6871 ns |  1.20 |    0.04 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6613 ns | 0.0028 ns | 0.0025 ns |  1.6615 ns |  1.18 |    0.04 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.1766 ns | 0.0016 ns | 0.0013 ns |  1.1766 ns |  0.84 |    0.03 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.1964 ns | 0.0023 ns | 0.0022 ns |  1.1963 ns |  0.85 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4291 ns | 0.0052 ns | 0.0048 ns |  4.4269 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  9.7125 ns | 0.0171 ns | 0.0160 ns |  9.7105 ns |  2.19 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  5.1207 ns | 0.0242 ns | 0.0226 ns |  5.1063 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8628 ns | 0.0032 ns | 0.0030 ns |  4.8636 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8634 ns | 0.0068 ns | 0.0060 ns |  4.8624 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.3132 ns | 0.0155 ns | 0.0145 ns |  1.3057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.7172 ns | 0.0056 ns | 0.0052 ns |  1.7164 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.6658 ns | 0.0139 ns | 0.0130 ns |  1.6594 ns |  1.27 |    0.02 |     - |     - |     - |         - |
             ToByte |        net461 |  1.1730 ns | 0.0015 ns | 0.0013 ns |  1.1732 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  1.2252 ns | 0.0088 ns | 0.0078 ns |  1.2263 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4249 ns | 0.0058 ns | 0.0045 ns |  4.4262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  9.6960 ns | 0.0098 ns | 0.0092 ns |  9.6950 ns |  2.19 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  5.1625 ns | 0.0047 ns | 0.0042 ns |  5.1623 ns |  1.17 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8631 ns | 0.0043 ns | 0.0038 ns |  4.8635 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8993 ns | 0.0200 ns | 0.0187 ns |  4.9068 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.3147 ns | 0.0019 ns | 0.0018 ns |  1.3144 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6929 ns | 0.0030 ns | 0.0025 ns |  1.6924 ns |  1.29 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6655 ns | 0.0136 ns | 0.0128 ns |  1.6688 ns |  1.27 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  1.1859 ns | 0.0071 ns | 0.0067 ns |  1.1871 ns |  0.90 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  1.2049 ns | 0.0056 ns | 0.0050 ns |  1.2039 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4269 ns | 0.0062 ns | 0.0058 ns |  4.4254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  9.7107 ns | 0.0122 ns | 0.0114 ns |  9.7119 ns |  2.19 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  5.1085 ns | 0.0057 ns | 0.0051 ns |  5.1084 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8628 ns | 0.0076 ns | 0.0072 ns |  4.8623 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8750 ns | 0.0053 ns | 0.0049 ns |  4.8745 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.3193 ns | 0.0023 ns | 0.0021 ns |  1.3197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.7300 ns | 0.0044 ns | 0.0039 ns |  1.7300 ns |  1.31 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7225 ns | 0.0033 ns | 0.0031 ns |  1.7212 ns |  1.31 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.1766 ns | 0.0058 ns | 0.0051 ns |  1.1747 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.1998 ns | 0.0016 ns | 0.0013 ns |  1.1997 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4715 ns | 0.0170 ns | 0.0159 ns |  4.4747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  9.7837 ns | 0.0642 ns | 0.0601 ns |  9.8132 ns |  2.19 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  5.1030 ns | 0.0048 ns | 0.0044 ns |  5.1024 ns |  1.14 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8649 ns | 0.0068 ns | 0.0060 ns |  4.8640 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.8866 ns | 0.0074 ns | 0.0069 ns |  4.8869 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.3590 ns | 0.0102 ns | 0.0091 ns |  1.3609 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7000 ns | 0.0044 ns | 0.0041 ns |  1.7013 ns |  1.25 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6740 ns | 0.0135 ns | 0.0127 ns |  1.6674 ns |  1.23 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  1.1645 ns | 0.0091 ns | 0.0081 ns |  1.1662 ns |  0.86 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.1648 ns | 0.0123 ns | 0.0115 ns |  1.1588 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4267 ns | 0.0073 ns | 0.0065 ns |  4.4265 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  9.7017 ns | 0.0159 ns | 0.0141 ns |  9.6999 ns |  2.19 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.8776 ns | 0.0064 ns | 0.0060 ns |  4.8780 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.8652 ns | 0.0045 ns | 0.0042 ns |  4.8654 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.9067 ns | 0.0192 ns | 0.0179 ns |  4.9121 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.3149 ns | 0.0038 ns | 0.0035 ns |  1.3137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.7282 ns | 0.0025 ns | 0.0023 ns |  1.7272 ns |  1.31 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6291 ns | 0.0025 ns | 0.0022 ns |  1.6286 ns |  1.24 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.1348 ns | 0.0023 ns | 0.0021 ns |  1.1349 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.1751 ns | 0.0028 ns | 0.0026 ns |  1.1746 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4278 ns | 0.0050 ns | 0.0047 ns |  4.4274 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  9.7116 ns | 0.0181 ns | 0.0169 ns |  9.7078 ns |  2.19 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.8720 ns | 0.0039 ns | 0.0035 ns |  4.8722 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.8671 ns | 0.0049 ns | 0.0043 ns |  4.8675 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.8858 ns | 0.0237 ns | 0.0221 ns |  4.8744 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.3994 ns | 0.0021 ns | 0.0019 ns |  1.3995 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.7188 ns | 0.0073 ns | 0.0065 ns |  1.7193 ns |  1.23 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  2.4370 ns | 0.0743 ns | 0.0763 ns |  2.4306 ns |  1.74 |    0.06 |     - |     - |     - |         - |
             ToLong |        net461 |  1.3991 ns | 0.0022 ns | 0.0021 ns |  1.3988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.1852 ns | 0.0019 ns | 0.0018 ns |  1.1852 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1079 ns | 0.0024 ns | 0.0021 ns |  2.1077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.2247 ns | 0.0034 ns | 0.0032 ns |  2.2249 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1690 ns | 0.0020 ns | 0.0019 ns |  2.1686 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3272 ns | 0.0034 ns | 0.0029 ns |  2.3284 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1856 ns | 0.0024 ns | 0.0023 ns |  2.1845 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.3216 ns | 0.0084 ns | 0.0079 ns |  1.3230 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.7170 ns | 0.0029 ns | 0.0024 ns |  1.7161 ns |  1.30 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.7099 ns | 0.0041 ns | 0.0036 ns |  1.7109 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  1.1434 ns | 0.0067 ns | 0.0063 ns |  1.1448 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  1.1836 ns | 0.0026 ns | 0.0024 ns |  1.1839 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1095 ns | 0.0025 ns | 0.0023 ns |  2.1092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1280 ns | 0.0038 ns | 0.0036 ns |  2.1285 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1140 ns | 0.0180 ns | 0.0168 ns |  2.1039 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.3035 ns | 0.0040 ns | 0.0035 ns |  2.3024 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.1786 ns | 0.0021 ns | 0.0019 ns |  2.1778 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7676 ns | 0.0157 ns | 0.0147 ns |  1.7614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.7481 ns | 0.0021 ns | 0.0020 ns |  1.7482 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.5689 ns | 0.0034 ns | 0.0031 ns |  1.5694 ns |  0.89 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1411 ns | 0.0029 ns | 0.0027 ns |  1.1406 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1671 ns | 0.0089 ns | 0.0084 ns |  1.1719 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.6590 ns | 0.0050 ns | 0.0047 ns |  4.6578 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 10.0273 ns | 0.0302 ns | 0.0283 ns | 10.0334 ns |  2.15 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.8724 ns | 0.0065 ns | 0.0054 ns |  4.8712 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.0761 ns | 0.0047 ns | 0.0042 ns |  5.0766 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.1112 ns | 0.0065 ns | 0.0061 ns |  5.1118 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4509 ns | 0.0022 ns | 0.0021 ns |  1.4509 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.7648 ns | 0.0026 ns | 0.0024 ns |  1.7654 ns |  1.22 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5445 ns | 0.0102 ns | 0.0095 ns |  1.5486 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.1392 ns | 0.0024 ns | 0.0022 ns |  1.1395 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.1742 ns | 0.0118 ns | 0.0110 ns |  1.1684 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.3366 ns | 0.0032 ns | 0.0030 ns |  2.3374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.5838 ns | 0.0204 ns | 0.0191 ns |  2.5760 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.3343 ns | 0.0028 ns | 0.0025 ns |  2.3339 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.4705 ns | 0.0124 ns | 0.0110 ns |  2.4718 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.3697 ns | 0.0019 ns | 0.0018 ns |  2.3697 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3534 ns | 0.0035 ns | 0.0031 ns |  2.3530 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.3671 ns | 0.0065 ns | 0.0061 ns |  2.3673 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.2062 ns | 0.0208 ns | 0.0195 ns |  2.1978 ns |  0.94 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.2641 ns | 0.0055 ns | 0.0049 ns |  6.2652 ns |  2.66 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.1373 ns | 0.0062 ns | 0.0058 ns |  6.1341 ns |  2.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0138 ns | 0.0077 ns | 0.0072 ns | 10.0121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  8.6785 ns | 0.0100 ns | 0.0078 ns |  8.6765 ns |  0.87 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3736 ns | 0.0025 ns | 0.0023 ns |  2.3741 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6800 ns | 0.0067 ns | 0.0060 ns | 10.6802 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7945 ns | 0.0468 ns | 0.0438 ns | 10.7764 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2748 ns | 0.0064 ns | 0.0060 ns |  2.2747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.7319 ns | 0.0042 ns | 0.0039 ns |  2.7313 ns |  1.20 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.6493 ns | 0.0057 ns | 0.0050 ns |  2.6496 ns |  1.16 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  2.2155 ns | 0.0048 ns | 0.0043 ns |  2.2147 ns |  0.97 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.5014 ns | 0.0017 ns | 0.0014 ns |  1.5016 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.5900 ns | 0.0346 ns | 0.0306 ns |  8.5968 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.6346 ns | 0.0112 ns | 0.0105 ns |  8.6317 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.3624 ns | 0.0076 ns | 0.0067 ns |  2.3649 ns |  0.28 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.6246 ns | 0.0118 ns | 0.0105 ns |  8.6240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.8647 ns | 0.0111 ns | 0.0103 ns |  8.8647 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  2.1403 ns | 0.0028 ns | 0.0025 ns |  2.1400 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  0.9563 ns | 0.0031 ns | 0.0026 ns |  0.9561 ns |  0.45 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2587 ns | 0.0029 ns | 0.0027 ns |  1.2593 ns |  0.59 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  1.6616 ns | 0.0024 ns | 0.0022 ns |  1.6614 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.9502 ns | 0.0025 ns | 0.0024 ns |  1.9495 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  0.9227 ns | 0.0021 ns | 0.0019 ns |  0.9224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  0.9607 ns | 0.0086 ns | 0.0081 ns |  0.9583 ns |  1.04 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.0991 ns | 0.0026 ns | 0.0021 ns |  1.0987 ns |  1.19 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  0.4389 ns | 0.0013 ns | 0.0011 ns |  0.4388 ns |  0.48 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  0.6996 ns | 0.0025 ns | 0.0023 ns |  0.6992 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.2961 ns | 0.0032 ns | 0.0030 ns |  1.2959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4229 ns | 0.0106 ns | 0.0094 ns |  1.4264 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.3743 ns | 0.0022 ns | 0.0021 ns |  1.3744 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.1636 ns | 0.0110 ns | 0.0103 ns |  1.1665 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.1687 ns | 0.0058 ns | 0.0048 ns |  1.1699 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2365 ns | 0.0092 ns | 0.0086 ns |  4.2363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4216 ns | 0.0059 ns | 0.0055 ns |  4.4227 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9975 ns | 0.0044 ns | 0.0041 ns |  3.9977 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.8651 ns | 0.0066 ns | 0.0062 ns |  4.8653 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.8759 ns | 0.0059 ns | 0.0055 ns |  4.8760 ns |  1.15 |    0.00 |     - |     - |     - |         - |
