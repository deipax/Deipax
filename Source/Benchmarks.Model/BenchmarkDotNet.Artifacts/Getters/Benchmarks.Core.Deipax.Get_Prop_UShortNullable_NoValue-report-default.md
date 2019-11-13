
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
             ToBool | .NET Core 2.0 |  1.1739 ns | 0.0224 ns | 0.0210 ns |  1.1698 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2302 ns | 0.0038 ns | 0.0034 ns |  1.2294 ns |  1.05 |    0.02 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2557 ns | 0.0030 ns | 0.0025 ns |  1.2554 ns |  1.07 |    0.02 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9905 ns | 0.0029 ns | 0.0024 ns |  0.9905 ns |  0.84 |    0.02 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9654 ns | 0.0026 ns | 0.0023 ns |  0.9652 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9676 ns | 0.0126 ns | 0.0105 ns |  3.9652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1763 ns | 0.0085 ns | 0.0080 ns |  4.1728 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0106 ns | 0.0056 ns | 0.0047 ns |  4.0096 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1655 ns | 0.0281 ns | 0.0263 ns |  4.1519 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1668 ns | 0.0104 ns | 0.0092 ns |  4.1627 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.2599 ns | 0.0041 ns | 0.0039 ns |  1.2594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.3991 ns | 0.0070 ns | 0.0066 ns |  1.3970 ns |  1.11 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.6323 ns | 0.0030 ns | 0.0028 ns |  1.6329 ns |  1.30 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9934 ns | 0.0047 ns | 0.0042 ns |  0.9936 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9602 ns | 0.0025 ns | 0.0022 ns |  0.9603 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0219 ns | 0.0088 ns | 0.0083 ns |  4.0236 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1762 ns | 0.0086 ns | 0.0076 ns |  4.1764 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0127 ns | 0.0067 ns | 0.0059 ns |  4.0123 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3773 ns | 0.0108 ns | 0.0101 ns |  4.3761 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4315 ns | 0.0092 ns | 0.0086 ns |  4.4296 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1790 ns | 0.0035 ns | 0.0031 ns |  1.1796 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.2869 ns | 0.0044 ns | 0.0041 ns |  1.2868 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5019 ns | 0.0112 ns | 0.0105 ns |  1.5069 ns |  1.27 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9994 ns | 0.0098 ns | 0.0087 ns |  1.0027 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9638 ns | 0.0057 ns | 0.0051 ns |  0.9629 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2006 ns | 0.0055 ns | 0.0046 ns |  4.2019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4578 ns | 0.0063 ns | 0.0056 ns |  4.4582 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0244 ns | 0.0072 ns | 0.0067 ns |  4.0230 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.3778 ns | 0.0060 ns | 0.0054 ns |  4.3781 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4040 ns | 0.0293 ns | 0.0274 ns |  4.3903 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.2462 ns | 0.0041 ns | 0.0039 ns |  1.2449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4989 ns | 0.0039 ns | 0.0032 ns |  1.4981 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3214 ns | 0.0110 ns | 0.0103 ns |  1.3235 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9978 ns | 0.0138 ns | 0.0129 ns |  0.9902 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9621 ns | 0.0029 ns | 0.0024 ns |  0.9622 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2496 ns | 0.0051 ns | 0.0048 ns |  4.2510 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4121 ns | 0.0075 ns | 0.0063 ns |  4.4109 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0116 ns | 0.0067 ns | 0.0060 ns |  4.0096 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.3840 ns | 0.0060 ns | 0.0053 ns |  4.3846 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4207 ns | 0.0357 ns | 0.0334 ns |  4.4291 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.1676 ns | 0.0040 ns | 0.0035 ns |  1.1661 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.2392 ns | 0.0030 ns | 0.0025 ns |  1.2386 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.4132 ns | 0.0021 ns | 0.0017 ns |  1.4133 ns |  1.21 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9908 ns | 0.0026 ns | 0.0023 ns |  0.9905 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9639 ns | 0.0035 ns | 0.0033 ns |  0.9638 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2021 ns | 0.0067 ns | 0.0059 ns |  4.2021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4084 ns | 0.0069 ns | 0.0058 ns |  4.4072 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0076 ns | 0.0045 ns | 0.0040 ns |  4.0085 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4213 ns | 0.0167 ns | 0.0148 ns |  4.4258 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.3831 ns | 0.0066 ns | 0.0062 ns |  4.3831 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.3896 ns | 0.0034 ns | 0.0028 ns |  1.3904 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2317 ns | 0.0097 ns | 0.0091 ns |  1.2293 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5333 ns | 0.0061 ns | 0.0051 ns |  1.5336 ns |  1.10 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9778 ns | 0.0027 ns | 0.0024 ns |  0.9778 ns |  0.70 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9521 ns | 0.0020 ns | 0.0018 ns |  0.9524 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  0.9335 ns | 0.0023 ns | 0.0022 ns |  0.9333 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  0.9761 ns | 0.0039 ns | 0.0035 ns |  0.9770 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  0.9621 ns | 0.0092 ns | 0.0086 ns |  0.9575 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  1.1375 ns | 0.0151 ns | 0.0142 ns |  1.1307 ns |  1.22 |    0.02 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  0.9402 ns | 0.0045 ns | 0.0040 ns |  0.9400 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.1845 ns | 0.0035 ns | 0.0031 ns |  1.1847 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.3395 ns | 0.0055 ns | 0.0043 ns |  1.3403 ns |  1.13 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4484 ns | 0.0021 ns | 0.0018 ns |  1.4484 ns |  1.22 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9918 ns | 0.0037 ns | 0.0033 ns |  0.9911 ns |  0.84 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9614 ns | 0.0024 ns | 0.0021 ns |  0.9610 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9702 ns | 0.0094 ns | 0.0088 ns |  3.9715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1759 ns | 0.0048 ns | 0.0042 ns |  4.1763 ns |  1.05 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0108 ns | 0.0075 ns | 0.0070 ns |  4.0102 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.3727 ns | 0.0082 ns | 0.0064 ns |  4.3716 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4034 ns | 0.0282 ns | 0.0264 ns |  4.3934 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4137 ns | 0.0025 ns | 0.0024 ns |  1.4138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4196 ns | 0.0037 ns | 0.0032 ns |  1.4190 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5667 ns | 0.0577 ns | 0.0995 ns |  1.5682 ns |  1.11 |    0.09 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.2079 ns | 0.0022 ns | 0.0021 ns |  1.2077 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9720 ns | 0.0033 ns | 0.0029 ns |  0.9722 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0168 ns | 0.0145 ns | 0.0136 ns |  4.0179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1718 ns | 0.0050 ns | 0.0042 ns |  4.1709 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0235 ns | 0.0072 ns | 0.0063 ns |  4.0224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.3779 ns | 0.0091 ns | 0.0081 ns |  4.3747 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.3897 ns | 0.0067 ns | 0.0056 ns |  4.3895 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2487 ns | 0.0133 ns | 0.0124 ns |  1.2417 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4489 ns | 0.0018 ns | 0.0016 ns |  1.4490 ns |  1.16 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3038 ns | 0.0032 ns | 0.0025 ns |  1.3032 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9893 ns | 0.0040 ns | 0.0037 ns |  0.9896 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9624 ns | 0.0025 ns | 0.0023 ns |  0.9622 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7598 ns | 0.0027 ns | 0.0025 ns |  1.7593 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8764 ns | 0.0105 ns | 0.0093 ns |  1.8791 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8929 ns | 0.0088 ns | 0.0078 ns |  1.8945 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.0458 ns | 0.0029 ns | 0.0025 ns |  2.0458 ns |  1.16 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8618 ns | 0.0053 ns | 0.0050 ns |  1.8610 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4441 ns | 0.0085 ns | 0.0079 ns |  1.4455 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2303 ns | 0.0036 ns | 0.0030 ns |  1.2298 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2709 ns | 0.0026 ns | 0.0023 ns |  1.2709 ns |  0.88 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9891 ns | 0.0028 ns | 0.0026 ns |  0.9885 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9626 ns | 0.0020 ns | 0.0016 ns |  0.9629 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7887 ns | 0.0114 ns | 0.0107 ns |  1.7903 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.9085 ns | 0.0087 ns | 0.0081 ns |  1.9071 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0300 ns | 0.0055 ns | 0.0049 ns |  2.0300 ns |  1.14 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.2663 ns | 0.0058 ns | 0.0048 ns |  2.2655 ns |  1.27 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.4247 ns | 0.0036 ns | 0.0032 ns |  2.4251 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.2374 ns | 0.0050 ns | 0.0044 ns |  1.2368 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4086 ns | 0.0053 ns | 0.0044 ns |  1.4093 ns |  1.14 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2900 ns | 0.0033 ns | 0.0030 ns |  1.2893 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0383 ns | 0.0088 ns | 0.0082 ns |  1.0394 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  0.9885 ns | 0.0052 ns | 0.0046 ns |  0.9878 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2502 ns | 0.0211 ns | 0.0197 ns |  4.2537 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4108 ns | 0.0052 ns | 0.0049 ns |  4.4104 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2578 ns | 0.0074 ns | 0.0069 ns |  4.2582 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6036 ns | 0.0078 ns | 0.0073 ns |  4.6029 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6664 ns | 0.0175 ns | 0.0155 ns |  4.6683 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3988 ns | 0.0034 ns | 0.0030 ns |  1.3986 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4194 ns | 0.0050 ns | 0.0045 ns |  1.4178 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2230 ns | 0.0030 ns | 0.0026 ns |  1.2228 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.2108 ns | 0.0134 ns | 0.0126 ns |  1.2049 ns |  0.86 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.9991 ns | 0.0090 ns | 0.0080 ns |  0.9956 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9344 ns | 0.0029 ns | 0.0024 ns |  1.9343 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0919 ns | 0.0078 ns | 0.0066 ns |  2.0930 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1114 ns | 0.0058 ns | 0.0052 ns |  2.1096 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1241 ns | 0.0151 ns | 0.0134 ns |  2.1270 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.9565 ns | 0.0048 ns | 0.0042 ns |  1.9558 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.0190 ns | 0.0053 ns | 0.0050 ns |  2.0183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1135 ns | 0.0159 ns | 0.0124 ns |  2.1167 ns |  1.05 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.3383 ns | 0.0036 ns | 0.0030 ns |  2.3379 ns |  1.16 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0091 ns | 0.0075 ns | 0.0071 ns |  6.0093 ns |  2.98 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0285 ns | 0.0199 ns | 0.0186 ns |  6.0238 ns |  2.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.9782 ns | 0.0086 ns | 0.0081 ns |  9.9760 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.6864 ns | 0.0120 ns | 0.0112 ns | 10.6833 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.8919 ns | 0.0840 ns | 0.0862 ns |  2.9141 ns |  0.29 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6583 ns | 0.0264 ns | 0.0247 ns | 10.6530 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 12.3703 ns | 0.0772 ns | 0.0722 ns | 12.4006 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0764 ns | 0.0049 ns | 0.0046 ns |  2.0747 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3312 ns | 0.0082 ns | 0.0077 ns |  2.3288 ns |  1.12 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3291 ns | 0.0039 ns | 0.0032 ns |  2.3298 ns |  1.12 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1291 ns | 0.0032 ns | 0.0029 ns |  1.1290 ns |  0.54 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  0.9966 ns | 0.0027 ns | 0.0025 ns |  0.9955 ns |  0.48 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8998 ns | 0.0190 ns | 0.0159 ns |  7.8938 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4655 ns | 0.0107 ns | 0.0100 ns |  8.4665 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9288 ns | 0.0046 ns | 0.0043 ns |  1.9280 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4200 ns | 0.0107 ns | 0.0095 ns |  8.4238 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1473 ns | 0.0118 ns | 0.0092 ns |  8.1450 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2303 ns | 0.0043 ns | 0.0040 ns |  1.2298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.2684 ns | 0.0029 ns | 0.0026 ns |  1.2681 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.5327 ns | 0.0029 ns | 0.0024 ns |  1.5334 ns |  1.25 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9760 ns | 0.0026 ns | 0.0022 ns |  0.9762 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9512 ns | 0.0026 ns | 0.0023 ns |  0.9504 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4099 ns | 0.0090 ns | 0.0075 ns |  1.4115 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4093 ns | 0.0027 ns | 0.0026 ns |  1.4094 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.3110 ns | 0.0085 ns | 0.0080 ns |  1.3134 ns |  0.93 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.3180 ns | 0.0035 ns | 0.0033 ns |  1.3180 ns |  0.93 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2930 ns | 0.0036 ns | 0.0033 ns |  1.2934 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4176 ns | 0.0028 ns | 0.0025 ns |  1.4179 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.5249 ns | 0.0040 ns | 0.0035 ns |  1.5247 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.4508 ns | 0.0066 ns | 0.0058 ns |  1.4491 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2644 ns | 0.0024 ns | 0.0021 ns |  1.2638 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2376 ns | 0.0029 ns | 0.0026 ns |  1.2375 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2524 ns | 0.0065 ns | 0.0058 ns |  4.2526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4358 ns | 0.0242 ns | 0.0226 ns |  4.4286 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0180 ns | 0.0073 ns | 0.0068 ns |  4.0166 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6074 ns | 0.0058 ns | 0.0054 ns |  4.6068 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6198 ns | 0.0069 ns | 0.0061 ns |  4.6177 ns |  1.09 |    0.00 |     - |     - |     - |         - |
