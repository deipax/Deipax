
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
             ToBool | .NET Core 2.0 |  1.1697 ns | 0.0091 ns | 0.0086 ns |  1.1679 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.0197 ns | 0.0030 ns | 0.0025 ns |  1.0199 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.0858 ns | 0.0036 ns | 0.0030 ns |  1.0855 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7195 ns | 0.0027 ns | 0.0025 ns |  0.7197 ns |  0.62 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.5286 ns | 0.0038 ns | 0.0034 ns |  0.5275 ns |  0.45 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9327 ns | 0.0076 ns | 0.0067 ns |  3.9337 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1768 ns | 0.0034 ns | 0.0030 ns |  4.1769 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9421 ns | 0.0064 ns | 0.0060 ns |  3.9426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2052 ns | 0.0200 ns | 0.0187 ns |  4.2133 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2086 ns | 0.0135 ns | 0.0126 ns |  4.2099 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.4586 ns | 0.0139 ns | 0.0130 ns |  1.4532 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6583 ns | 0.0048 ns | 0.0043 ns |  1.6576 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.5317 ns | 0.0039 ns | 0.0036 ns |  1.5308 ns |  1.05 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  1.8665 ns | 0.0051 ns | 0.0048 ns |  1.8660 ns |  1.28 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  1.8377 ns | 0.0034 ns | 0.0032 ns |  1.8385 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  1.1412 ns | 0.0021 ns | 0.0018 ns |  1.1409 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  1.1979 ns | 0.0042 ns | 0.0037 ns |  1.1974 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  1.0831 ns | 0.0019 ns | 0.0018 ns |  1.0839 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  1.1796 ns | 0.0032 ns | 0.0030 ns |  1.1799 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  0.9625 ns | 0.0027 ns | 0.0024 ns |  0.9621 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.9386 ns | 0.0034 ns | 0.0032 ns |  1.9380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6601 ns | 0.0044 ns | 0.0037 ns |  1.6592 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5902 ns | 0.0079 ns | 0.0074 ns |  1.5916 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.3195 ns | 0.0050 ns | 0.0047 ns |  2.3190 ns |  1.20 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.0339 ns | 0.0029 ns | 0.0027 ns |  2.0341 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4415 ns | 0.0054 ns | 0.0048 ns |  4.4424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4145 ns | 0.0067 ns | 0.0059 ns |  4.4148 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4012 ns | 0.0053 ns | 0.0047 ns |  4.4021 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3343 ns | 0.0129 ns | 0.0108 ns |  5.3330 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3123 ns | 0.0066 ns | 0.0058 ns |  5.3140 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.8580 ns | 0.0038 ns | 0.0036 ns |  1.8566 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4739 ns | 0.0046 ns | 0.0041 ns |  1.4732 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4024 ns | 0.0037 ns | 0.0031 ns |  1.4029 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.6331 ns | 0.0061 ns | 0.0054 ns |  2.6319 ns |  1.42 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3978 ns | 0.0047 ns | 0.0042 ns |  2.3979 ns |  1.29 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4033 ns | 0.0074 ns | 0.0069 ns |  4.4037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4103 ns | 0.0063 ns | 0.0056 ns |  4.4091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.3982 ns | 0.0063 ns | 0.0055 ns |  4.3977 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3242 ns | 0.0056 ns | 0.0052 ns |  5.3240 ns |  1.21 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3211 ns | 0.0070 ns | 0.0054 ns |  5.3232 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.7105 ns | 0.0058 ns | 0.0048 ns |  1.7094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.7734 ns | 0.0025 ns | 0.0022 ns |  1.7734 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.4343 ns | 0.0026 ns | 0.0023 ns |  1.4338 ns |  0.84 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  2.3340 ns | 0.0022 ns | 0.0018 ns |  2.3337 ns |  1.36 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.0468 ns | 0.0043 ns | 0.0040 ns |  2.0460 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4061 ns | 0.0104 ns | 0.0097 ns |  4.4059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4147 ns | 0.0061 ns | 0.0057 ns |  4.4144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4464 ns | 0.0130 ns | 0.0122 ns |  4.4488 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3183 ns | 0.0056 ns | 0.0052 ns |  5.3197 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3721 ns | 0.0056 ns | 0.0053 ns |  5.3717 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6399 ns | 0.0097 ns | 0.0091 ns |  1.6418 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.3947 ns | 0.0028 ns | 0.0024 ns |  1.3951 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3865 ns | 0.0037 ns | 0.0031 ns |  1.3863 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.4120 ns | 0.0026 ns | 0.0024 ns |  1.4112 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.1404 ns | 0.0032 ns | 0.0025 ns |  1.1410 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.1760 ns | 0.0054 ns | 0.0050 ns |  4.1763 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4457 ns | 0.0222 ns | 0.0207 ns |  4.4470 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9447 ns | 0.0048 ns | 0.0043 ns |  3.9446 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4045 ns | 0.0074 ns | 0.0069 ns |  4.4022 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4030 ns | 0.0120 ns | 0.0106 ns |  4.4039 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4645 ns | 0.0032 ns | 0.0030 ns |  1.4642 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5462 ns | 0.0033 ns | 0.0028 ns |  1.5464 ns |  1.06 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6900 ns | 0.0037 ns | 0.0029 ns |  1.6898 ns |  1.15 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.4186 ns | 0.0162 ns | 0.0151 ns |  1.4193 ns |  0.97 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  1.1265 ns | 0.0046 ns | 0.0039 ns |  1.1271 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.1669 ns | 0.0047 ns | 0.0044 ns |  4.1678 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4082 ns | 0.0087 ns | 0.0072 ns |  4.4089 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9392 ns | 0.0034 ns | 0.0030 ns |  3.9394 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4028 ns | 0.0075 ns | 0.0066 ns |  4.4024 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4396 ns | 0.0235 ns | 0.0219 ns |  4.4417 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5421 ns | 0.0049 ns | 0.0043 ns |  1.5416 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4197 ns | 0.0025 ns | 0.0022 ns |  1.4194 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4774 ns | 0.0039 ns | 0.0034 ns |  1.4767 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.9693 ns | 0.0665 ns | 0.1403 ns |  1.9779 ns |  1.28 |    0.12 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.1319 ns | 0.0019 ns | 0.0017 ns |  1.1324 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.1666 ns | 0.0078 ns | 0.0069 ns |  4.1657 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4015 ns | 0.0064 ns | 0.0060 ns |  4.4003 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9646 ns | 0.0081 ns | 0.0072 ns |  3.9643 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4046 ns | 0.0058 ns | 0.0054 ns |  4.4047 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4482 ns | 0.0188 ns | 0.0167 ns |  4.4509 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3845 ns | 0.0031 ns | 0.0026 ns |  1.3836 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2335 ns | 0.0026 ns | 0.0024 ns |  1.2336 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3975 ns | 0.0087 ns | 0.0082 ns |  1.3986 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1813 ns | 0.0023 ns | 0.0021 ns |  1.1812 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.0380 ns | 0.0030 ns | 0.0028 ns |  1.0383 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7935 ns | 0.0055 ns | 0.0049 ns |  1.7922 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8502 ns | 0.0049 ns | 0.0046 ns |  1.8489 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.0049 ns | 0.0038 ns | 0.0035 ns |  2.0054 ns |  1.12 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.5402 ns | 0.0040 ns | 0.0038 ns |  2.5396 ns |  1.42 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.3227 ns | 0.0043 ns | 0.0040 ns |  2.3234 ns |  1.30 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.5725 ns | 0.0144 ns | 0.0135 ns |  1.5770 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2701 ns | 0.0025 ns | 0.0023 ns |  1.2701 ns |  0.81 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.3972 ns | 0.0016 ns | 0.0014 ns |  1.3972 ns |  0.89 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  1.4113 ns | 0.0023 ns | 0.0021 ns |  1.4110 ns |  0.90 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  1.1266 ns | 0.0035 ns | 0.0031 ns |  1.1257 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7955 ns | 0.0042 ns | 0.0037 ns |  1.7958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1012 ns | 0.0039 ns | 0.0034 ns |  2.1020 ns |  1.17 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7684 ns | 0.0033 ns | 0.0029 ns |  1.7689 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.5903 ns | 0.0040 ns | 0.0035 ns |  2.5900 ns |  1.44 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.5564 ns | 0.0050 ns | 0.0047 ns |  2.5574 ns |  1.42 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1144 ns | 0.0050 ns | 0.0047 ns |  1.1137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1872 ns | 0.0020 ns | 0.0016 ns |  1.1876 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.0289 ns | 0.0019 ns | 0.0017 ns |  1.0286 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.7176 ns | 0.0040 ns | 0.0031 ns |  0.7181 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.6390 ns | 0.0044 ns | 0.0039 ns |  0.6376 ns |  0.57 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  3.9536 ns | 0.0055 ns | 0.0048 ns |  3.9541 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4102 ns | 0.0102 ns | 0.0095 ns |  4.4073 ns |  1.12 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2082 ns | 0.0172 ns | 0.0161 ns |  4.2126 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4006 ns | 0.0057 ns | 0.0053 ns |  4.3992 ns |  1.11 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.3931 ns | 0.0044 ns | 0.0041 ns |  4.3931 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.0794 ns | 0.0028 ns | 0.0025 ns |  1.0793 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1778 ns | 0.0025 ns | 0.0021 ns |  1.1774 ns |  1.09 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.0266 ns | 0.0033 ns | 0.0029 ns |  1.0257 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.7057 ns | 0.0026 ns | 0.0025 ns |  0.7059 ns |  0.65 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.6394 ns | 0.0036 ns | 0.0034 ns |  0.6398 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7760 ns | 0.0044 ns | 0.0039 ns |  1.7752 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8400 ns | 0.0034 ns | 0.0032 ns |  1.8390 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7927 ns | 0.0025 ns | 0.0023 ns |  1.7922 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6625 ns | 0.0034 ns | 0.0032 ns |  1.6627 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6356 ns | 0.0037 ns | 0.0033 ns |  1.6359 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.7831 ns | 0.0033 ns | 0.0031 ns |  1.7832 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.8765 ns | 0.0035 ns | 0.0031 ns |  1.8766 ns |  1.05 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.8531 ns | 0.0025 ns | 0.0024 ns |  1.8528 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.0703 ns | 0.0126 ns | 0.0112 ns |  6.0684 ns |  3.41 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.0779 ns | 0.0073 ns | 0.0061 ns |  6.0771 ns |  3.41 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.5657 ns | 0.0025 ns | 0.0023 ns |  1.5656 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.8530 ns | 0.0048 ns | 0.0043 ns |  1.8523 ns |  1.18 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.5476 ns | 0.0032 ns | 0.0028 ns |  1.5474 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.9260 ns | 0.0126 ns | 0.0118 ns |  1.9261 ns |  1.23 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.8746 ns | 0.0119 ns | 0.0111 ns |  1.8693 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2845 ns | 0.0123 ns | 0.0115 ns |  2.2866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1158 ns | 0.0035 ns | 0.0031 ns |  2.1165 ns |  0.93 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3988 ns | 0.0051 ns | 0.0048 ns |  2.3985 ns |  1.05 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1774 ns | 0.0040 ns | 0.0035 ns |  1.1778 ns |  0.52 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1778 ns | 0.0033 ns | 0.0031 ns |  1.1784 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8893 ns | 0.0096 ns | 0.0085 ns |  7.8866 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4198 ns | 0.0098 ns | 0.0092 ns |  8.4175 ns |  1.07 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8800 ns | 0.0025 ns | 0.0023 ns |  1.8804 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.3966 ns | 0.0180 ns | 0.0159 ns |  8.3985 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2661 ns | 0.0108 ns | 0.0090 ns |  8.2679 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8644 ns | 0.0120 ns | 0.0112 ns |  3.8671 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5144 ns | 0.0087 ns | 0.0081 ns |  4.5139 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.4841 ns | 0.0260 ns | 0.0243 ns |  4.4772 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8039 ns | 0.0103 ns | 0.0097 ns |  3.8052 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7655 ns | 0.0133 ns | 0.0124 ns |  3.7641 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  4.7827 ns | 0.0204 ns | 0.0181 ns |  4.7775 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 |  4.8321 ns | 0.0089 ns | 0.0079 ns |  4.8317 ns |  1.01 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 |  4.5041 ns | 0.0444 ns | 0.0371 ns |  4.5076 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 |  6.0305 ns | 0.0198 ns | 0.0185 ns |  6.0270 ns |  1.26 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 |  5.9975 ns | 0.0118 ns | 0.0110 ns |  5.9978 ns |  1.25 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.7832 ns | 0.0272 ns | 0.0241 ns | 12.7713 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.3422 ns | 0.0209 ns | 0.0185 ns | 12.3405 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5113 ns | 0.0420 ns | 0.0393 ns |  8.5130 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.1788 ns | 0.0238 ns | 0.0222 ns | 15.1770 ns |  1.19 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.3453 ns | 0.0170 ns | 0.0150 ns | 15.3435 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.6941 ns | 0.0159 ns | 0.0133 ns | 16.6881 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.8641 ns | 0.0191 ns | 0.0179 ns | 16.8660 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.0406 ns | 0.0135 ns | 0.0126 ns | 13.0379 ns |  0.78 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.7544 ns | 0.0199 ns | 0.0166 ns | 19.7552 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.7193 ns | 0.0211 ns | 0.0197 ns | 19.7191 ns |  1.18 |    0.00 |      - |     - |     - |         - |
