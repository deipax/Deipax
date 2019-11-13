
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |        Mean |     Error |    StdDev |      Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|----------:|----------:|------------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |   1.4720 ns | 0.0022 ns | 0.0021 ns |   1.4720 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.4599 ns | 0.0024 ns | 0.0020 ns |   1.4607 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.3917 ns | 0.0016 ns | 0.0015 ns |   1.3916 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |   1.4308 ns | 0.0039 ns | 0.0037 ns |   1.4313 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   1.1383 ns | 0.0035 ns | 0.0031 ns |   1.1386 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.9296 ns | 0.0072 ns | 0.0067 ns |   4.9301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   5.1027 ns | 0.0050 ns | 0.0046 ns |   5.1032 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.6301 ns | 0.0049 ns | 0.0043 ns |   4.6313 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   5.0682 ns | 0.0076 ns | 0.0067 ns |   5.0680 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   5.1126 ns | 0.0068 ns | 0.0053 ns |   5.1108 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.1831 ns | 0.0028 ns | 0.0026 ns |   1.1827 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.4310 ns | 0.0029 ns | 0.0026 ns |   1.4314 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.3202 ns | 0.0112 ns | 0.0105 ns |   1.3241 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |   0.7217 ns | 0.0025 ns | 0.0023 ns |   0.7217 ns |  0.61 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |   0.5332 ns | 0.0020 ns | 0.0018 ns |   0.5334 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.0494 ns | 0.0053 ns | 0.0047 ns |   4.0499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.4382 ns | 0.0140 ns | 0.0131 ns |   4.4438 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.1741 ns | 0.0073 ns | 0.0068 ns |   4.1726 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.3735 ns | 0.0047 ns | 0.0041 ns |   4.3731 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.4087 ns | 0.0044 ns | 0.0041 ns |   4.4092 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.4968 ns | 0.0087 ns | 0.0081 ns |   4.4962 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.6632 ns | 0.0057 ns | 0.0051 ns |   4.6638 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.5168 ns | 0.0094 ns | 0.0078 ns |   4.5169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.8448 ns | 0.0070 ns | 0.0062 ns |   3.8466 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.7642 ns | 0.0049 ns | 0.0045 ns |   3.7644 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   7.0270 ns | 0.0163 ns | 0.0136 ns |   7.0301 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.9900 ns | 0.0253 ns | 0.0236 ns |   6.9955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   6.9583 ns | 0.0136 ns | 0.0127 ns |   6.9588 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   7.1393 ns | 0.0067 ns | 0.0059 ns |   7.1404 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   7.1821 ns | 0.0084 ns | 0.0074 ns |   7.1805 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.2716 ns | 0.0073 ns | 0.0064 ns |   4.2695 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   4.6861 ns | 0.0102 ns | 0.0096 ns |   4.6851 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.9244 ns | 0.0061 ns | 0.0057 ns |   4.9247 ns |  1.15 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   3.8618 ns | 0.0202 ns | 0.0189 ns |   3.8558 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   3.8092 ns | 0.0056 ns | 0.0052 ns |   3.8102 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   7.0851 ns | 0.0096 ns | 0.0089 ns |   7.0844 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.9412 ns | 0.0070 ns | 0.0062 ns |   6.9404 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   6.9764 ns | 0.0369 ns | 0.0345 ns |   6.9956 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   7.1353 ns | 0.0085 ns | 0.0079 ns |   7.1345 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   7.1810 ns | 0.0106 ns | 0.0094 ns |   7.1805 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   4.7673 ns | 0.0068 ns | 0.0060 ns |   4.7685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.7056 ns | 0.0215 ns | 0.0201 ns |   4.7099 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.5061 ns | 0.0061 ns | 0.0057 ns |   4.5061 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   3.8373 ns | 0.0049 ns | 0.0044 ns |   3.8369 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   3.7688 ns | 0.0062 ns | 0.0058 ns |   3.7671 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   7.1732 ns | 0.0129 ns | 0.0121 ns |   7.1740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.9397 ns | 0.0111 ns | 0.0098 ns |   6.9405 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   6.9598 ns | 0.0366 ns | 0.0343 ns |   6.9502 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   7.1469 ns | 0.0106 ns | 0.0089 ns |   7.1439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   7.1808 ns | 0.0071 ns | 0.0067 ns |   7.1805 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.5182 ns | 0.0162 ns | 0.0144 ns |   4.5123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   4.6332 ns | 0.0060 ns | 0.0053 ns |   4.6324 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   4.6647 ns | 0.0299 ns | 0.0279 ns |   4.6660 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.9075 ns | 0.0240 ns | 0.0213 ns |   3.9173 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.7725 ns | 0.0059 ns | 0.0049 ns |   3.7710 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   7.0620 ns | 0.0116 ns | 0.0109 ns |   7.0643 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   6.9453 ns | 0.0246 ns | 0.0206 ns |   6.9398 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   6.9479 ns | 0.0123 ns | 0.0115 ns |   6.9437 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   7.1445 ns | 0.0094 ns | 0.0083 ns |   7.1463 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   7.1784 ns | 0.0075 ns | 0.0070 ns |   7.1775 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   3.0270 ns | 0.0074 ns | 0.0061 ns |   3.0256 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.3077 ns | 0.0336 ns | 0.0314 ns |   3.3102 ns |  1.09 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.2084 ns | 0.0183 ns | 0.0171 ns |   3.2163 ns |  1.06 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   2.7190 ns | 0.0064 ns | 0.0060 ns |   2.7180 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |   2.6810 ns | 0.0039 ns | 0.0035 ns |   2.6815 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   6.3340 ns | 0.0072 ns | 0.0064 ns |   6.3356 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   6.2465 ns | 0.0101 ns | 0.0094 ns |   6.2447 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.2630 ns | 0.0076 ns | 0.0071 ns |   6.2609 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   6.4461 ns | 0.0083 ns | 0.0078 ns |   6.4461 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   6.5434 ns | 0.0074 ns | 0.0069 ns |   6.5458 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   3.6091 ns | 0.0046 ns | 0.0043 ns |   3.6085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.4069 ns | 0.0159 ns | 0.0148 ns |   3.4107 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.6403 ns | 0.0056 ns | 0.0047 ns |   3.6402 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   2.7292 ns | 0.0111 ns | 0.0104 ns |   2.7314 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |   2.6629 ns | 0.0065 ns | 0.0061 ns |   2.6630 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   6.3332 ns | 0.0096 ns | 0.0085 ns |   6.3329 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.2456 ns | 0.0111 ns | 0.0103 ns |   6.2486 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.2961 ns | 0.0084 ns | 0.0078 ns |   6.2972 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.5037 ns | 0.0300 ns | 0.0250 ns |   6.5118 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.4772 ns | 0.0085 ns | 0.0080 ns |   6.4765 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.7613 ns | 0.0044 ns | 0.0042 ns |   3.7626 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.8608 ns | 0.0055 ns | 0.0048 ns |   2.8624 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.7563 ns | 0.0072 ns | 0.0067 ns |   2.7582 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   3.7736 ns | 0.0122 ns | 0.0114 ns |   3.7717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   3.6776 ns | 0.0090 ns | 0.0080 ns |   3.6776 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.6916 ns | 0.0063 ns | 0.0053 ns |   4.6917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   3.4790 ns | 0.0085 ns | 0.0079 ns |   3.4783 ns |  0.74 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.3794 ns | 0.0137 ns | 0.0129 ns |   3.3814 ns |  0.72 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   5.0947 ns | 0.0138 ns | 0.0115 ns |   5.0943 ns |  1.09 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   5.1746 ns | 0.0053 ns | 0.0047 ns |   5.1735 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   3.6508 ns | 0.0162 ns | 0.0144 ns |   3.6563 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.6788 ns | 0.0186 ns | 0.0174 ns |   2.6710 ns |  0.73 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.7158 ns | 0.0038 ns | 0.0036 ns |   2.7169 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   3.4894 ns | 0.0052 ns | 0.0049 ns |   3.4899 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   3.3615 ns | 0.0175 ns | 0.0164 ns |   3.3540 ns |  0.92 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.3838 ns | 0.0064 ns | 0.0060 ns |   4.3831 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.3107 ns | 0.0089 ns | 0.0074 ns |   3.3100 ns |  0.76 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   3.2386 ns | 0.0131 ns | 0.0122 ns |   3.2349 ns |  0.74 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   5.1330 ns | 0.0067 ns | 0.0062 ns |   5.1337 ns |  1.17 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   5.0977 ns | 0.0057 ns | 0.0053 ns |   5.0979 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.4490 ns | 0.0023 ns | 0.0021 ns |   1.4483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.6349 ns | 0.0174 ns | 0.0163 ns |   1.6435 ns |  1.13 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.6283 ns | 0.0220 ns | 0.0205 ns |   1.6286 ns |  1.12 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |   1.3895 ns | 0.0023 ns | 0.0021 ns |   1.3899 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   1.1267 ns | 0.0024 ns | 0.0020 ns |   1.1262 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.7163 ns | 0.0042 ns | 0.0039 ns |   4.7169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.8600 ns | 0.0053 ns | 0.0050 ns |   4.8591 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.4407 ns | 0.0054 ns | 0.0048 ns |   4.4403 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.8402 ns | 0.0075 ns | 0.0070 ns |   4.8416 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.8707 ns | 0.0026 ns | 0.0025 ns |   4.8705 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   2.3217 ns | 0.0039 ns | 0.0035 ns |   2.3214 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.7024 ns | 0.0117 ns | 0.0110 ns |   1.7063 ns |  0.73 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.5323 ns | 0.0046 ns | 0.0038 ns |   1.5310 ns |  0.66 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |   1.8756 ns | 0.0034 ns | 0.0030 ns |   1.8767 ns |  0.81 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   1.8429 ns | 0.0039 ns | 0.0032 ns |   1.8437 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.8740 ns | 0.0105 ns | 0.0098 ns |   1.8787 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.8493 ns | 0.0026 ns | 0.0025 ns |   1.8494 ns |  0.99 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.6599 ns | 0.0089 ns | 0.0083 ns |   1.6610 ns |  0.89 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.5784 ns | 0.0026 ns | 0.0024 ns |   1.5787 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.6526 ns | 0.0027 ns | 0.0026 ns |   1.6528 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  54.5651 ns | 0.0586 ns | 0.0548 ns |  54.5479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  54.3994 ns | 0.0567 ns | 0.0530 ns |  54.3971 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  12.4884 ns | 0.0156 ns | 0.0146 ns |  12.4909 ns |  0.23 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  55.0302 ns | 0.0481 ns | 0.0426 ns |  55.0171 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  59.3161 ns | 0.0661 ns | 0.0586 ns |  59.3116 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  65.6596 ns | 0.2251 ns | 0.2105 ns |  65.7600 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  65.2309 ns | 0.0749 ns | 0.0701 ns |  65.2463 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  17.8308 ns | 0.1775 ns | 0.1660 ns |  17.8955 ns |  0.27 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  65.6341 ns | 0.0450 ns | 0.0421 ns |  65.6322 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  65.8756 ns | 0.0766 ns | 0.0640 ns |  65.8664 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3301 ns | 0.0041 ns | 0.0036 ns |   2.3305 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.3474 ns | 0.0030 ns | 0.0028 ns |   2.3475 ns |  1.01 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.2352 ns | 0.0025 ns | 0.0022 ns |   2.2350 ns |  0.96 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.3450 ns | 0.0022 ns | 0.0020 ns |   1.3452 ns |  0.58 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.4126 ns | 0.0031 ns | 0.0029 ns |   1.4131 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   7.9480 ns | 0.0055 ns | 0.0051 ns |   7.9461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.3954 ns | 0.0303 ns | 0.0283 ns |   8.4023 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.8646 ns | 0.0032 ns | 0.0029 ns |   1.8636 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.1778 ns | 0.0083 ns | 0.0065 ns |   8.1791 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.1071 ns | 0.0094 ns | 0.0078 ns |   8.1076 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.8817 ns | 0.0085 ns | 0.0076 ns |   3.8827 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.6615 ns | 0.0107 ns | 0.0101 ns |   4.6636 ns |  1.20 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.5004 ns | 0.0333 ns | 0.0311 ns |   4.5197 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.7323 ns | 0.0094 ns | 0.0084 ns |   3.7305 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.7096 ns | 0.0082 ns | 0.0077 ns |   3.7122 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 191.2848 ns | 0.2472 ns | 0.2312 ns | 191.3023 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 109.4162 ns | 0.1380 ns | 0.1291 ns | 109.4245 ns |  0.57 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 111.2385 ns | 0.1777 ns | 0.1484 ns | 111.2247 ns |  0.58 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 296.2747 ns | 0.2935 ns | 0.2451 ns | 296.2005 ns |  1.55 |    0.00 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 295.7129 ns | 0.2895 ns | 0.2417 ns | 295.6405 ns |  1.55 |    0.00 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  14.4308 ns | 0.0136 ns | 0.0127 ns |  14.4267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  14.1062 ns | 0.0138 ns | 0.0129 ns |  14.1087 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.5219 ns | 0.0121 ns | 0.0107 ns |  10.5216 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  18.5237 ns | 0.0225 ns | 0.0211 ns |  18.5184 ns |  1.28 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  17.1825 ns | 0.0211 ns | 0.0165 ns |  17.1819 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  18.6910 ns | 0.0187 ns | 0.0166 ns |  18.6942 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  18.6056 ns | 0.0268 ns | 0.0209 ns |  18.6003 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  14.9251 ns | 0.0245 ns | 0.0205 ns |  14.9183 ns |  0.80 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  21.8852 ns | 0.0323 ns | 0.0302 ns |  21.8827 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  21.9735 ns | 0.0228 ns | 0.0202 ns |  21.9755 ns |  1.18 |    0.00 |      - |     - |     - |         - |
