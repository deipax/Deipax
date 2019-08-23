
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
             ToBool | .NET Core 2.0 |  1.3931 ns | 0.0033 ns | 0.0029 ns |  1.3931 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.7052 ns | 0.0179 ns | 0.0150 ns |  1.7102 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.8158 ns | 0.0017 ns | 0.0015 ns |  1.8163 ns |  1.30 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  1.1284 ns | 0.0030 ns | 0.0028 ns |  1.1283 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.4287 ns | 0.0021 ns | 0.0020 ns |  1.4288 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0021 ns | 0.0161 ns | 0.0135 ns |  4.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1780 ns | 0.0075 ns | 0.0071 ns |  4.1796 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9392 ns | 0.0071 ns | 0.0067 ns |  3.9371 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1755 ns | 0.0038 ns | 0.0036 ns |  4.1749 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1683 ns | 0.0037 ns | 0.0035 ns |  4.1691 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.4513 ns | 0.0040 ns | 0.0037 ns |  1.4501 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4677 ns | 0.0032 ns | 0.0030 ns |  1.4685 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.0200 ns | 0.0034 ns | 0.0029 ns |  2.0198 ns |  1.39 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9361 ns | 0.0107 ns | 0.0101 ns |  0.9398 ns |  0.65 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  1.1827 ns | 0.0040 ns | 0.0037 ns |  1.1813 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.1979 ns | 0.0052 ns | 0.0049 ns |  4.1988 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4087 ns | 0.0049 ns | 0.0046 ns |  4.4100 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0038 ns | 0.0063 ns | 0.0059 ns |  4.0041 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1857 ns | 0.0095 ns | 0.0089 ns |  4.1849 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2008 ns | 0.0150 ns | 0.0141 ns |  4.2041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4096 ns | 0.0041 ns | 0.0038 ns |  1.4084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4663 ns | 0.0047 ns | 0.0042 ns |  1.4667 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.7569 ns | 0.0039 ns | 0.0035 ns |  1.7578 ns |  1.25 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.3679 ns | 0.0105 ns | 0.0099 ns |  1.3635 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.6378 ns | 0.0022 ns | 0.0021 ns |  1.6371 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4611 ns | 0.0226 ns | 0.0211 ns |  4.4696 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  9.5652 ns | 0.0384 ns | 0.0299 ns |  9.5725 ns |  2.15 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  5.1866 ns | 0.0194 ns | 0.0181 ns |  5.1935 ns |  1.16 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4043 ns | 0.0058 ns | 0.0051 ns |  4.4041 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.3987 ns | 0.0063 ns | 0.0056 ns |  4.3989 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.4072 ns | 0.0043 ns | 0.0040 ns |  1.4067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.8716 ns | 0.0036 ns | 0.0032 ns |  1.8715 ns |  1.33 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.8061 ns | 0.0033 ns | 0.0031 ns |  1.8068 ns |  1.28 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.8861 ns | 0.0030 ns | 0.0028 ns |  0.8849 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.8837 ns | 0.0150 ns | 0.0140 ns |  1.8762 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4662 ns | 0.0182 ns | 0.0152 ns |  4.4709 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  9.4807 ns | 0.0069 ns | 0.0061 ns |  9.4794 ns |  2.12 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  5.0889 ns | 0.0059 ns | 0.0055 ns |  5.0901 ns |  1.14 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4389 ns | 0.0191 ns | 0.0179 ns |  4.4459 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4139 ns | 0.0085 ns | 0.0080 ns |  4.4122 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4395 ns | 0.0041 ns | 0.0038 ns |  1.4393 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4442 ns | 0.0047 ns | 0.0044 ns |  1.4440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6457 ns | 0.0025 ns | 0.0023 ns |  1.6454 ns |  1.14 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9784 ns | 0.0026 ns | 0.0023 ns |  0.9790 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.0423 ns | 0.0020 ns | 0.0019 ns |  1.0425 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4248 ns | 0.0078 ns | 0.0073 ns |  4.4249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  9.4829 ns | 0.0101 ns | 0.0095 ns |  9.4850 ns |  2.14 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  5.0936 ns | 0.0125 ns | 0.0111 ns |  5.0894 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4034 ns | 0.0060 ns | 0.0047 ns |  4.4029 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4455 ns | 0.0066 ns | 0.0061 ns |  4.4465 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5447 ns | 0.0018 ns | 0.0016 ns |  1.5446 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.8523 ns | 0.0036 ns | 0.0034 ns |  1.8532 ns |  1.20 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7562 ns | 0.0031 ns | 0.0027 ns |  1.7562 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.3909 ns | 0.0030 ns | 0.0027 ns |  1.3906 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.6423 ns | 0.0030 ns | 0.0028 ns |  1.6414 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4220 ns | 0.0042 ns | 0.0039 ns |  4.4215 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  9.4854 ns | 0.0082 ns | 0.0077 ns |  9.4867 ns |  2.15 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  5.1556 ns | 0.0065 ns | 0.0061 ns |  5.1561 ns |  1.17 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4046 ns | 0.0051 ns | 0.0048 ns |  4.4036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3963 ns | 0.0057 ns | 0.0044 ns |  4.3967 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4694 ns | 0.0052 ns | 0.0049 ns |  1.4679 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7006 ns | 0.0043 ns | 0.0038 ns |  1.7010 ns |  1.16 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.0205 ns | 0.0029 ns | 0.0025 ns |  2.0199 ns |  1.37 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.1303 ns | 0.0019 ns | 0.0018 ns |  1.1308 ns |  0.77 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  1.3910 ns | 0.0028 ns | 0.0025 ns |  1.3912 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4639 ns | 0.0208 ns | 0.0185 ns |  4.4694 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  9.5900 ns | 0.0134 ns | 0.0125 ns |  9.5932 ns |  2.15 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.8595 ns | 0.0053 ns | 0.0047 ns |  4.8610 ns |  1.09 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4042 ns | 0.0028 ns | 0.0027 ns |  4.4039 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3977 ns | 0.0029 ns | 0.0025 ns |  4.3974 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4826 ns | 0.0025 ns | 0.0023 ns |  1.4832 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.8714 ns | 0.0031 ns | 0.0029 ns |  1.8707 ns |  1.26 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.9175 ns | 0.0092 ns | 0.0086 ns |  1.9188 ns |  1.29 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9044 ns | 0.0024 ns | 0.0022 ns |  0.9044 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.1599 ns | 0.0033 ns | 0.0031 ns |  1.1598 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4260 ns | 0.0073 ns | 0.0068 ns |  4.4232 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  9.4904 ns | 0.0166 ns | 0.0139 ns |  9.4928 ns |  2.14 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.8592 ns | 0.0088 ns | 0.0074 ns |  4.8581 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4383 ns | 0.0317 ns | 0.0296 ns |  4.4521 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4568 ns | 0.0081 ns | 0.0076 ns |  4.4582 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.5008 ns | 0.0032 ns | 0.0030 ns |  1.5007 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.7542 ns | 0.0036 ns | 0.0032 ns |  1.7543 ns |  1.17 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.8158 ns | 0.0018 ns | 0.0015 ns |  1.8156 ns |  1.21 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.3621 ns | 0.0026 ns | 0.0025 ns |  1.3630 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.6434 ns | 0.0021 ns | 0.0018 ns |  1.6437 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.3817 ns | 0.0072 ns | 0.0067 ns |  2.3811 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3195 ns | 0.0040 ns | 0.0035 ns |  2.3193 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.2302 ns | 0.0037 ns | 0.0029 ns |  2.2295 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.5748 ns | 0.0047 ns | 0.0041 ns |  2.5746 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.6776 ns | 0.0050 ns | 0.0041 ns |  2.6781 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4712 ns | 0.0021 ns | 0.0019 ns |  1.4712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6783 ns | 0.0018 ns | 0.0017 ns |  1.6781 ns |  1.14 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  2.0325 ns | 0.0203 ns | 0.0180 ns |  2.0243 ns |  1.38 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  1.3600 ns | 0.0033 ns | 0.0031 ns |  1.3597 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  1.6437 ns | 0.0034 ns | 0.0030 ns |  1.6447 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.5175 ns | 0.0034 ns | 0.0032 ns |  2.5169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3489 ns | 0.0050 ns | 0.0047 ns |  2.3478 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.3247 ns | 0.0226 ns | 0.0200 ns |  2.3209 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.5544 ns | 0.0042 ns | 0.0035 ns |  2.5543 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.8232 ns | 0.0192 ns | 0.0179 ns |  2.8148 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4943 ns | 0.0034 ns | 0.0030 ns |  1.4948 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.8801 ns | 0.0043 ns | 0.0040 ns |  1.8795 ns |  1.26 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6748 ns | 0.0023 ns | 0.0020 ns |  1.6747 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9040 ns | 0.0032 ns | 0.0029 ns |  0.9036 ns |  0.61 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1429 ns | 0.0023 ns | 0.0020 ns |  1.1435 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4274 ns | 0.0057 ns | 0.0054 ns |  4.4267 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  9.7189 ns | 0.0115 ns | 0.0096 ns |  9.7138 ns |  2.20 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.8966 ns | 0.0290 ns | 0.0271 ns |  4.9077 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6385 ns | 0.0076 ns | 0.0071 ns |  4.6385 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6313 ns | 0.0075 ns | 0.0066 ns |  4.6317 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4658 ns | 0.0042 ns | 0.0039 ns |  1.4662 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  2.0938 ns | 0.0106 ns | 0.0094 ns |  2.0957 ns |  1.43 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.8860 ns | 0.0031 ns | 0.0029 ns |  1.8863 ns |  1.29 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.1272 ns | 0.0080 ns | 0.0067 ns |  1.1295 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.3968 ns | 0.0062 ns | 0.0058 ns |  1.3986 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.5583 ns | 0.0153 ns | 0.0135 ns |  2.5642 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.5447 ns | 0.0045 ns | 0.0040 ns |  2.5455 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.3275 ns | 0.0050 ns | 0.0047 ns |  2.3282 ns |  0.91 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.3395 ns | 0.0035 ns | 0.0033 ns |  2.3403 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.3567 ns | 0.0032 ns | 0.0030 ns |  2.3574 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2005 ns | 0.0025 ns | 0.0023 ns |  2.2009 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.5513 ns | 0.0053 ns | 0.0047 ns |  2.5503 ns |  1.16 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.2293 ns | 0.0034 ns | 0.0030 ns |  2.2286 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0304 ns | 0.0049 ns | 0.0043 ns |  6.0293 ns |  2.74 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0468 ns | 0.0346 ns | 0.0323 ns |  6.0293 ns |  2.75 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.9548 ns | 0.0104 ns | 0.0097 ns |  9.9547 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  8.6088 ns | 0.0154 ns | 0.0144 ns |  8.6090 ns |  0.86 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.5914 ns | 0.0310 ns | 0.0290 ns |  2.5952 ns |  0.26 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6420 ns | 0.0083 ns | 0.0077 ns | 10.6437 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6390 ns | 0.0101 ns | 0.0095 ns | 10.6357 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3749 ns | 0.0020 ns | 0.0018 ns |  2.3753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.7769 ns | 0.0050 ns | 0.0045 ns |  2.7769 ns |  1.17 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.7665 ns | 0.0050 ns | 0.0047 ns |  2.7662 ns |  1.16 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.6467 ns | 0.0047 ns | 0.0044 ns |  1.6467 ns |  0.69 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.6927 ns | 0.0038 ns | 0.0036 ns |  1.6925 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8937 ns | 0.0127 ns | 0.0119 ns |  7.8965 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4861 ns | 0.0202 ns | 0.0169 ns |  8.4879 ns |  1.08 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.5673 ns | 0.0047 ns | 0.0044 ns |  2.5674 ns |  0.33 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2413 ns | 0.0102 ns | 0.0096 ns |  8.2408 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3996 ns | 0.0067 ns | 0.0063 ns |  8.3983 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2247 ns | 0.0031 ns | 0.0029 ns |  1.2239 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  0.9538 ns | 0.0023 ns | 0.0021 ns |  0.9538 ns |  0.78 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  0.9629 ns | 0.0157 ns | 0.0147 ns |  0.9616 ns |  0.79 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9006 ns | 0.0021 ns | 0.0020 ns |  0.9006 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.1613 ns | 0.0019 ns | 0.0017 ns |  1.1616 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  0.9234 ns | 0.0042 ns | 0.0039 ns |  0.9224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  0.9527 ns | 0.0021 ns | 0.0019 ns |  0.9525 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.0991 ns | 0.0033 ns | 0.0029 ns |  1.0994 ns |  1.19 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  0.4384 ns | 0.0016 ns | 0.0015 ns |  0.4382 ns |  0.47 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  0.6965 ns | 0.0029 ns | 0.0023 ns |  0.6962 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4601 ns | 0.0073 ns | 0.0069 ns |  1.4633 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4964 ns | 0.0033 ns | 0.0029 ns |  1.4970 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.7027 ns | 0.0030 ns | 0.0027 ns |  1.7030 ns |  1.17 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  0.9042 ns | 0.0040 ns | 0.0036 ns |  0.9039 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.1603 ns | 0.0033 ns | 0.0029 ns |  1.1601 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  3.9652 ns | 0.0087 ns | 0.0081 ns |  3.9660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4089 ns | 0.0063 ns | 0.0052 ns |  4.4082 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9388 ns | 0.0066 ns | 0.0062 ns |  3.9385 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.4033 ns | 0.0070 ns | 0.0062 ns |  4.4023 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.3959 ns | 0.0064 ns | 0.0060 ns |  4.3956 ns |  1.11 |    0.00 |     - |     - |     - |         - |
