
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
             ToBool | .NET Core 2.0 |  1.3710 ns | 0.0028 ns | 0.0025 ns |  1.3707 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6516 ns | 0.0032 ns | 0.0030 ns |  1.6525 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.5624 ns | 0.0025 ns | 0.0022 ns |  1.5626 ns |  1.14 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.8632 ns | 0.0021 ns | 0.0019 ns |  1.8634 ns |  1.36 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.8427 ns | 0.0034 ns | 0.0030 ns |  1.8417 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  0.9180 ns | 0.0027 ns | 0.0024 ns |  0.9181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  0.9751 ns | 0.0066 ns | 0.0062 ns |  0.9765 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  0.9632 ns | 0.0022 ns | 0.0019 ns |  0.9631 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  1.1826 ns | 0.0034 ns | 0.0030 ns |  1.1823 ns |  1.29 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  0.9752 ns | 0.0028 ns | 0.0026 ns |  0.9756 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  0.8670 ns | 0.0035 ns | 0.0033 ns |  0.8676 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.0196 ns | 0.0032 ns | 0.0030 ns |  1.0203 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0164 ns | 0.0033 ns | 0.0028 ns |  1.0161 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  0.7199 ns | 0.0041 ns | 0.0034 ns |  0.7188 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.5308 ns | 0.0033 ns | 0.0031 ns |  0.5300 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9782 ns | 0.0213 ns | 0.0199 ns |  3.9698 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1735 ns | 0.0062 ns | 0.0051 ns |  4.1738 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9965 ns | 0.0114 ns | 0.0107 ns |  3.9962 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2040 ns | 0.0192 ns | 0.0179 ns |  4.2093 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1777 ns | 0.0111 ns | 0.0099 ns |  4.1751 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.6661 ns | 0.0040 ns | 0.0038 ns |  1.6665 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6401 ns | 0.0029 ns | 0.0027 ns |  1.6394 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6465 ns | 0.0033 ns | 0.0027 ns |  1.6463 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6189 ns | 0.0030 ns | 0.0028 ns |  1.6197 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3497 ns | 0.0040 ns | 0.0035 ns |  1.3502 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.1894 ns | 0.0072 ns | 0.0067 ns |  4.1896 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4024 ns | 0.0095 ns | 0.0089 ns |  4.4024 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.4573 ns | 0.0072 ns | 0.0068 ns |  4.4570 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6259 ns | 0.0056 ns | 0.0050 ns |  4.6278 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.6302 ns | 0.0052 ns | 0.0043 ns |  4.6296 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.5495 ns | 0.0168 ns | 0.0157 ns |  1.5598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4667 ns | 0.0050 ns | 0.0045 ns |  1.4670 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4597 ns | 0.0038 ns | 0.0034 ns |  1.4605 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6233 ns | 0.0025 ns | 0.0023 ns |  1.6242 ns |  1.05 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3586 ns | 0.0031 ns | 0.0028 ns |  1.3583 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.1932 ns | 0.0051 ns | 0.0045 ns |  4.1930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3988 ns | 0.0054 ns | 0.0042 ns |  4.3980 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.4566 ns | 0.0072 ns | 0.0067 ns |  4.4569 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6294 ns | 0.0040 ns | 0.0035 ns |  4.6294 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6301 ns | 0.0046 ns | 0.0043 ns |  4.6292 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.6081 ns | 0.0041 ns | 0.0036 ns |  1.6079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.7162 ns | 0.0037 ns | 0.0033 ns |  1.7169 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.7226 ns | 0.0028 ns | 0.0026 ns |  1.7233 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6389 ns | 0.0030 ns | 0.0028 ns |  1.6394 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3429 ns | 0.0031 ns | 0.0027 ns |  1.3421 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2068 ns | 0.0059 ns | 0.0055 ns |  4.2053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.3987 ns | 0.0065 ns | 0.0061 ns |  4.3991 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4241 ns | 0.0056 ns | 0.0052 ns |  4.4237 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6312 ns | 0.0051 ns | 0.0047 ns |  4.6302 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6781 ns | 0.0125 ns | 0.0116 ns |  4.6757 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5717 ns | 0.0033 ns | 0.0031 ns |  1.5716 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.7635 ns | 0.0057 ns | 0.0053 ns |  1.7639 ns |  1.12 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7534 ns | 0.0065 ns | 0.0061 ns |  1.7510 ns |  1.12 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6641 ns | 0.0055 ns | 0.0052 ns |  1.6629 ns |  1.06 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.3706 ns | 0.0043 ns | 0.0038 ns |  1.3697 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.1976 ns | 0.0063 ns | 0.0056 ns |  4.1975 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.3994 ns | 0.0066 ns | 0.0061 ns |  4.3994 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2004 ns | 0.0046 ns | 0.0041 ns |  4.2005 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6346 ns | 0.0077 ns | 0.0069 ns |  4.6346 ns |  1.10 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6307 ns | 0.0068 ns | 0.0057 ns |  4.6299 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.6331 ns | 0.0033 ns | 0.0031 ns |  1.6333 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.6622 ns | 0.0055 ns | 0.0046 ns |  1.6636 ns |  1.02 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6191 ns | 0.0041 ns | 0.0032 ns |  1.6190 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.6179 ns | 0.0049 ns | 0.0046 ns |  1.6183 ns |  0.99 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.3385 ns | 0.0032 ns | 0.0028 ns |  1.3377 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.1924 ns | 0.0116 ns | 0.0103 ns |  4.1912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.3994 ns | 0.0062 ns | 0.0058 ns |  4.3976 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.4261 ns | 0.0066 ns | 0.0062 ns |  4.4264 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6366 ns | 0.0098 ns | 0.0092 ns |  4.6350 ns |  1.11 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6347 ns | 0.0040 ns | 0.0037 ns |  4.6341 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6334 ns | 0.0029 ns | 0.0027 ns |  1.6334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4679 ns | 0.0037 ns | 0.0031 ns |  1.4674 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4712 ns | 0.0051 ns | 0.0046 ns |  1.4721 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6205 ns | 0.0041 ns | 0.0038 ns |  1.6201 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.3607 ns | 0.0042 ns | 0.0037 ns |  1.3607 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.1951 ns | 0.0117 ns | 0.0098 ns |  4.1920 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4450 ns | 0.0153 ns | 0.0127 ns |  4.4483 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.4278 ns | 0.0057 ns | 0.0047 ns |  4.4298 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6722 ns | 0.0172 ns | 0.0161 ns |  4.6776 ns |  1.11 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6341 ns | 0.0075 ns | 0.0066 ns |  4.6327 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.7043 ns | 0.0040 ns | 0.0036 ns |  1.7038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.7216 ns | 0.0048 ns | 0.0045 ns |  1.7208 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6709 ns | 0.0044 ns | 0.0039 ns |  1.6696 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.6353 ns | 0.0028 ns | 0.0026 ns |  1.6341 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.3478 ns | 0.0024 ns | 0.0021 ns |  1.3473 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1720 ns | 0.0192 ns | 0.0180 ns |  2.1813 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.1252 ns | 0.0034 ns | 0.0030 ns |  2.1252 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9537 ns | 0.0057 ns | 0.0053 ns |  1.9524 ns |  0.90 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  3.3684 ns | 0.0052 ns | 0.0049 ns |  3.3674 ns |  1.55 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  3.3335 ns | 0.0055 ns | 0.0049 ns |  3.3335 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.6125 ns | 0.0029 ns | 0.0028 ns |  1.6123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4790 ns | 0.0053 ns | 0.0050 ns |  1.4789 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4760 ns | 0.0089 ns | 0.0079 ns |  1.4730 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.6410 ns | 0.0033 ns | 0.0027 ns |  1.6405 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.4006 ns | 0.0022 ns | 0.0019 ns |  1.4005 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9314 ns | 0.0037 ns | 0.0031 ns |  1.9320 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3242 ns | 0.0038 ns | 0.0034 ns |  2.3245 ns |  1.20 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0024 ns | 0.0022 ns | 0.0021 ns |  2.0027 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.8422 ns | 0.0084 ns | 0.0070 ns |  2.8411 ns |  1.47 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.7953 ns | 0.0070 ns | 0.0062 ns |  2.7938 ns |  1.45 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4427 ns | 0.0032 ns | 0.0028 ns |  1.4427 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.8765 ns | 0.0055 ns | 0.0052 ns |  1.8763 ns |  1.30 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6529 ns | 0.0037 ns | 0.0034 ns |  1.6520 ns |  1.15 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.8621 ns | 0.0034 ns | 0.0030 ns |  1.8615 ns |  1.29 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.5772 ns | 0.0030 ns | 0.0028 ns |  1.5764 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.6567 ns | 0.0045 ns | 0.0040 ns |  4.6560 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.9074 ns | 0.0061 ns | 0.0054 ns |  4.9079 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.6645 ns | 0.0062 ns | 0.0055 ns |  4.6644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.1407 ns | 0.0208 ns | 0.0195 ns |  5.1420 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.0982 ns | 0.0065 ns | 0.0058 ns |  5.0996 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6417 ns | 0.0137 ns | 0.0128 ns |  1.6488 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.8650 ns | 0.0031 ns | 0.0028 ns |  1.8656 ns |  1.14 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6800 ns | 0.0040 ns | 0.0037 ns |  1.6795 ns |  1.02 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.4440 ns | 0.0132 ns | 0.0123 ns |  1.4434 ns |  0.88 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.7756 ns | 0.0674 ns | 0.1987 ns |  1.7882 ns |  1.04 |    0.11 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9061 ns | 0.0051 ns | 0.0048 ns |  1.9052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.5372 ns | 0.0050 ns | 0.0044 ns |  2.5355 ns |  1.33 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1194 ns | 0.0033 ns | 0.0031 ns |  2.1188 ns |  1.11 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.7907 ns | 0.0072 ns | 0.0067 ns |  2.7897 ns |  1.46 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.7934 ns | 0.0040 ns | 0.0036 ns |  2.7933 ns |  1.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.2575 ns | 0.0083 ns | 0.0078 ns |  6.2579 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.2521 ns | 0.0241 ns | 0.0226 ns |  6.2464 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0875 ns | 0.0325 ns | 0.0288 ns |  6.1005 ns |  0.97 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.7197 ns | 0.0077 ns | 0.0068 ns |  6.7205 ns |  1.07 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.7251 ns | 0.0135 ns | 0.0113 ns |  6.7239 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.2407 ns | 0.0248 ns | 0.0220 ns | 18.2373 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.9503 ns | 0.0286 ns | 0.0253 ns | 18.9539 ns |  1.04 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.8591 ns | 0.1193 ns | 0.1116 ns | 12.9247 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.4730 ns | 0.0275 ns | 0.0257 ns | 18.4741 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.8684 ns | 0.0697 ns | 0.0652 ns | 18.8883 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0673 ns | 0.0036 ns | 0.0034 ns |  2.0673 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3460 ns | 0.0084 ns | 0.0078 ns |  2.3477 ns |  1.13 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1339 ns | 0.0040 ns | 0.0036 ns |  2.1336 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.4079 ns | 0.0021 ns | 0.0018 ns |  1.4083 ns |  0.68 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.4171 ns | 0.0083 ns | 0.0078 ns |  1.4134 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9852 ns | 0.0101 ns | 0.0090 ns |  7.9841 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4280 ns | 0.0096 ns | 0.0085 ns |  8.4263 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9276 ns | 0.0041 ns | 0.0036 ns |  1.9272 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.5198 ns | 0.0106 ns | 0.0099 ns |  8.5193 ns |  1.07 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 12.2491 ns | 0.0188 ns | 0.0176 ns | 12.2403 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8147 ns | 0.0137 ns | 0.0128 ns |  3.8130 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5461 ns | 0.0086 ns | 0.0080 ns |  4.5475 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5825 ns | 0.0533 ns | 0.0499 ns |  4.5781 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8124 ns | 0.0111 ns | 0.0099 ns |  3.8111 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7227 ns | 0.0205 ns | 0.0171 ns |  3.7164 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  3.4724 ns | 0.0063 ns | 0.0056 ns |  3.4722 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 2.2 |  3.0389 ns | 0.0065 ns | 0.0057 ns |  3.0380 ns |  0.88 |    0.00 |      - |     - |     - |         - |
          To_String | .NET Core 3.0 |  3.1206 ns | 0.0053 ns | 0.0050 ns |  3.1210 ns |  0.90 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 |  3.2554 ns | 0.0200 ns | 0.0178 ns |  3.2630 ns |  0.94 |    0.01 |      - |     - |     - |         - |
          To_String |        net472 |  3.0037 ns | 0.0072 ns | 0.0068 ns |  3.0030 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.7077 ns | 0.0669 ns | 0.0625 ns | 12.6771 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.3481 ns | 0.0109 ns | 0.0097 ns | 12.3496 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.4862 ns | 0.0090 ns | 0.0084 ns |  8.4864 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.4164 ns | 0.0267 ns | 0.0223 ns | 15.4185 ns |  1.21 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.1072 ns | 0.0203 ns | 0.0169 ns | 15.1035 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.6088 ns | 0.0229 ns | 0.0214 ns | 16.5982 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.6556 ns | 0.0280 ns | 0.0249 ns | 16.6549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.1427 ns | 0.0133 ns | 0.0125 ns | 13.1402 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.6231 ns | 0.0193 ns | 0.0171 ns | 19.6203 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.7831 ns | 0.0238 ns | 0.0222 ns | 19.7773 ns |  1.19 |    0.00 |      - |     - |     - |         - |
