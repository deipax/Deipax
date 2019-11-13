
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
             ToBool | .NET Core 2.0 |   1.1776 ns | 0.0057 ns | 0.0051 ns |   1.1757 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.1826 ns | 0.0045 ns | 0.0042 ns |   1.1817 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.1862 ns | 0.0047 ns | 0.0042 ns |   1.1848 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.9495 ns | 0.0031 ns | 0.0028 ns |   0.9494 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   0.9472 ns | 0.0066 ns | 0.0058 ns |   0.9451 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.7140 ns | 0.0117 ns | 0.0110 ns |   4.7162 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.8739 ns | 0.0060 ns | 0.0056 ns |   4.8753 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.5025 ns | 0.0305 ns | 0.0285 ns |   4.4839 ns |  0.96 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.8708 ns | 0.0051 ns | 0.0045 ns |   4.8717 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   5.0191 ns | 0.0694 ns | 0.0579 ns |   5.0281 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.1802 ns | 0.0034 ns | 0.0032 ns |   1.1807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   0.9758 ns | 0.0039 ns | 0.0035 ns |   0.9749 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.1715 ns | 0.0031 ns | 0.0025 ns |   1.1713 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |   0.7201 ns | 0.0029 ns | 0.0025 ns |   0.7199 ns |  0.61 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |   0.7750 ns | 0.0425 ns | 0.0472 ns |   0.7747 ns |  0.67 |    0.04 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.2438 ns | 0.0062 ns | 0.0052 ns |   4.2417 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.4161 ns | 0.0045 ns | 0.0042 ns |   4.4158 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.0195 ns | 0.0050 ns | 0.0047 ns |   4.0196 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.4449 ns | 0.0182 ns | 0.0161 ns |   4.4486 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.3941 ns | 0.0403 ns | 0.0377 ns |   4.3732 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.4691 ns | 0.0112 ns | 0.0104 ns |   4.4685 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.9986 ns | 0.0440 ns | 0.0412 ns |   5.0169 ns |  1.12 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.8203 ns | 0.0391 ns | 0.0365 ns |   4.8433 ns |  1.08 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.5957 ns | 0.0080 ns | 0.0071 ns |   3.5949 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.6286 ns | 0.0471 ns | 0.0417 ns |   3.6152 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   6.5662 ns | 0.0135 ns | 0.0113 ns |   6.5648 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.7400 ns | 0.0141 ns | 0.0125 ns |   6.7407 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   7.0406 ns | 0.0289 ns | 0.0270 ns |   7.0370 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   6.7101 ns | 0.0102 ns | 0.0090 ns |   6.7126 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   6.7009 ns | 0.0166 ns | 0.0139 ns |   6.6980 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   5.2793 ns | 0.0114 ns | 0.0101 ns |   5.2811 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   4.9443 ns | 0.0068 ns | 0.0063 ns |   4.9445 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.9585 ns | 0.0080 ns | 0.0071 ns |   4.9580 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   3.5623 ns | 0.0053 ns | 0.0049 ns |   3.5626 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   3.5768 ns | 0.0063 ns | 0.0056 ns |   3.5768 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   6.5685 ns | 0.0092 ns | 0.0082 ns |   6.5672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.7868 ns | 0.0074 ns | 0.0061 ns |   6.7860 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   7.0225 ns | 0.0085 ns | 0.0066 ns |   7.0214 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   6.7209 ns | 0.0108 ns | 0.0101 ns |   6.7224 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   6.7006 ns | 0.0093 ns | 0.0087 ns |   6.7043 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   4.5071 ns | 0.0060 ns | 0.0053 ns |   4.5071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.9235 ns | 0.0078 ns | 0.0069 ns |   4.9229 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.9073 ns | 0.0076 ns | 0.0071 ns |   4.9068 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   4.7710 ns | 0.0153 ns | 0.0135 ns |   4.7669 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   3.6106 ns | 0.0113 ns | 0.0100 ns |   3.6103 ns |  0.80 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   6.6328 ns | 0.0178 ns | 0.0158 ns |   6.6327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.7900 ns | 0.0369 ns | 0.0345 ns |   6.8055 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   7.0851 ns | 0.0280 ns | 0.0248 ns |   7.0917 ns |  1.07 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   6.7122 ns | 0.0105 ns | 0.0093 ns |   6.7138 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   6.7708 ns | 0.0168 ns | 0.0140 ns |   6.7676 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.6282 ns | 0.0074 ns | 0.0069 ns |   4.6279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   5.0080 ns | 0.0067 ns | 0.0063 ns |   5.0070 ns |  1.08 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   5.1491 ns | 0.0066 ns | 0.0062 ns |   5.1498 ns |  1.11 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.6085 ns | 0.0095 ns | 0.0089 ns |   3.6071 ns |  0.78 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.6109 ns | 0.0072 ns | 0.0067 ns |   3.6111 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   6.5767 ns | 0.0095 ns | 0.0088 ns |   6.5776 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   6.7232 ns | 0.0118 ns | 0.0105 ns |   6.7216 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   7.0125 ns | 0.0097 ns | 0.0081 ns |   7.0155 ns |  1.07 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   6.7278 ns | 0.0128 ns | 0.0113 ns |   6.7250 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   6.7906 ns | 0.0365 ns | 0.0341 ns |   6.7872 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   3.0606 ns | 0.0225 ns | 0.0199 ns |   3.0569 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.5413 ns | 0.0228 ns | 0.0213 ns |   3.5493 ns |  1.16 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.4183 ns | 0.0319 ns | 0.0298 ns |   3.4267 ns |  1.12 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   2.8260 ns | 0.0063 ns | 0.0049 ns |   2.8260 ns |  0.92 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   2.3523 ns | 0.0237 ns | 0.0221 ns |   2.3423 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   5.8682 ns | 0.0140 ns | 0.0131 ns |   5.8645 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   6.0730 ns | 0.0361 ns | 0.0337 ns |   6.0819 ns |  1.03 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.3320 ns | 0.0125 ns | 0.0111 ns |   6.3313 ns |  1.08 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   6.0694 ns | 0.0284 ns | 0.0237 ns |   6.0774 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   5.9944 ns | 0.0099 ns | 0.0083 ns |   5.9953 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   3.0163 ns | 0.0108 ns | 0.0095 ns |   3.0153 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.5746 ns | 0.0078 ns | 0.0070 ns |   3.5738 ns |  1.19 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.4757 ns | 0.0087 ns | 0.0073 ns |   3.4726 ns |  1.15 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   2.2373 ns | 0.0030 ns | 0.0025 ns |   2.2375 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |   2.2437 ns | 0.0041 ns | 0.0034 ns |   2.2427 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   5.8666 ns | 0.0093 ns | 0.0082 ns |   5.8690 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.0653 ns | 0.0446 ns | 0.0417 ns |   6.0392 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.3334 ns | 0.0095 ns | 0.0089 ns |   6.3351 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.0243 ns | 0.0143 ns | 0.0126 ns |   6.0211 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   5.9964 ns | 0.0080 ns | 0.0067 ns |   5.9975 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.9002 ns | 0.0177 ns | 0.0157 ns |   3.9031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.6542 ns | 0.0045 ns | 0.0040 ns |   2.6549 ns |  0.68 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.7084 ns | 0.0064 ns | 0.0060 ns |   2.7086 ns |  0.69 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   3.6553 ns | 0.0150 ns | 0.0133 ns |   3.6503 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |   3.6415 ns | 0.0066 ns | 0.0061 ns |   3.6414 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.5398 ns | 0.0081 ns | 0.0072 ns |   4.5386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   3.1750 ns | 0.0070 ns | 0.0062 ns |   3.1730 ns |  0.70 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.2411 ns | 0.0235 ns | 0.0208 ns |   3.2478 ns |  0.71 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   4.9935 ns | 0.0076 ns | 0.0071 ns |   4.9943 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   5.0112 ns | 0.0075 ns | 0.0066 ns |   5.0110 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   4.2045 ns | 0.0123 ns | 0.0115 ns |   4.2048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.7863 ns | 0.0218 ns | 0.0204 ns |   2.7851 ns |  0.66 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.8084 ns | 0.0058 ns | 0.0055 ns |   2.8093 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   3.6221 ns | 0.0062 ns | 0.0052 ns |   3.6224 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   3.5975 ns | 0.0061 ns | 0.0054 ns |   3.5979 ns |  0.86 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.6093 ns | 0.0353 ns | 0.0331 ns |   4.6222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.2469 ns | 0.0086 ns | 0.0081 ns |   3.2451 ns |  0.70 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   3.3063 ns | 0.0260 ns | 0.0203 ns |   3.3136 ns |  0.72 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   4.8846 ns | 0.0053 ns | 0.0049 ns |   4.8828 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   4.8921 ns | 0.0055 ns | 0.0049 ns |   4.8919 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.1693 ns | 0.0032 ns | 0.0030 ns |   1.1691 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.2922 ns | 0.0036 ns | 0.0032 ns |   1.2925 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.1750 ns | 0.0029 ns | 0.0027 ns |   1.1736 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.7062 ns | 0.0032 ns | 0.0028 ns |   0.7059 ns |  0.60 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.7151 ns | 0.0025 ns | 0.0021 ns |   0.7147 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.0204 ns | 0.0076 ns | 0.0071 ns |   4.0184 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.4173 ns | 0.0063 ns | 0.0056 ns |   4.4163 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.2649 ns | 0.0295 ns | 0.0276 ns |   4.2476 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.1771 ns | 0.0084 ns | 0.0074 ns |   4.1769 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.1518 ns | 0.0050 ns | 0.0044 ns |   4.1522 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.5273 ns | 0.0182 ns | 0.0142 ns |   1.5247 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.2170 ns | 0.0035 ns | 0.0027 ns |   1.2163 ns |  0.80 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.1963 ns | 0.0041 ns | 0.0036 ns |   1.1967 ns |  0.78 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.7249 ns | 0.0176 ns | 0.0165 ns |   0.7266 ns |  0.47 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.7413 ns | 0.0024 ns | 0.0021 ns |   0.7415 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.9419 ns | 0.0055 ns | 0.0049 ns |   1.9421 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.8603 ns | 0.0036 ns | 0.0032 ns |   1.8607 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.6180 ns | 0.0052 ns | 0.0043 ns |   1.6170 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.6650 ns | 0.0046 ns | 0.0041 ns |   1.6638 ns |  0.86 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.6305 ns | 0.0039 ns | 0.0036 ns |   1.6295 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  23.8039 ns | 0.1233 ns | 0.1154 ns |  23.8786 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  23.6512 ns | 0.1202 ns | 0.1124 ns |  23.5978 ns |  0.99 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  11.4357 ns | 0.0125 ns | 0.0111 ns |  11.4336 ns |  0.48 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  23.5000 ns | 0.0254 ns | 0.0237 ns |  23.5005 ns |  0.99 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  23.4485 ns | 0.0642 ns | 0.0601 ns |  23.4630 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  33.7853 ns | 0.0477 ns | 0.0423 ns |  33.7783 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  33.5907 ns | 0.0509 ns | 0.0476 ns |  33.5853 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  16.6554 ns | 0.1493 ns | 0.1396 ns |  16.7462 ns |  0.49 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  33.6655 ns | 0.0443 ns | 0.0415 ns |  33.6607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  33.9710 ns | 0.0500 ns | 0.0443 ns |  33.9581 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3272 ns | 0.0029 ns | 0.0027 ns |   2.3283 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.3190 ns | 0.0052 ns | 0.0048 ns |   2.3201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.2727 ns | 0.0242 ns | 0.0226 ns |   2.2768 ns |  0.98 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.1717 ns | 0.0024 ns | 0.0020 ns |   1.1724 ns |  0.50 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.1211 ns | 0.0020 ns | 0.0019 ns |   1.1211 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   7.9823 ns | 0.0124 ns | 0.0116 ns |   7.9833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.4136 ns | 0.0244 ns | 0.0229 ns |   8.4049 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.9416 ns | 0.0039 ns | 0.0036 ns |   1.9414 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.0609 ns | 0.0475 ns | 0.0444 ns |   8.0562 ns |  1.01 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   7.9502 ns | 0.0194 ns | 0.0181 ns |   7.9499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.6294 ns | 0.0119 ns | 0.0106 ns |   3.6297 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   3.8752 ns | 0.0121 ns | 0.0101 ns |   3.8714 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.0082 ns | 0.0284 ns | 0.0266 ns |   4.0130 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   2.7584 ns | 0.0153 ns | 0.0143 ns |   2.7559 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   2.7609 ns | 0.0105 ns | 0.0098 ns |   2.7592 ns |  0.76 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 163.1483 ns | 1.0359 ns | 0.9690 ns | 162.5648 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 104.4998 ns | 0.4560 ns | 0.4042 ns | 104.6778 ns |  0.64 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 109.1822 ns | 0.1750 ns | 0.1551 ns | 109.1703 ns |  0.67 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 278.6686 ns | 0.5823 ns | 0.5162 ns | 278.4992 ns |  1.71 |    0.01 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 278.4710 ns | 0.4302 ns | 0.3592 ns | 278.3914 ns |  1.71 |    0.01 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |             |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  12.2629 ns | 0.0292 ns | 0.0273 ns |  12.2599 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  12.2115 ns | 0.0082 ns | 0.0073 ns |  12.2136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.5451 ns | 0.0647 ns | 0.0574 ns |  10.5701 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 |  14.2915 ns | 0.0285 ns | 0.0253 ns |  14.2885 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  14.3496 ns | 0.0186 ns | 0.0165 ns |  14.3529 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |             |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  17.0080 ns | 0.0959 ns | 0.0897 ns |  17.0509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  17.1369 ns | 0.0898 ns | 0.0840 ns |  17.1764 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  14.8593 ns | 0.0170 ns | 0.0142 ns |  14.8535 ns |  0.87 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  19.1875 ns | 0.0199 ns | 0.0186 ns |  19.1893 ns |  1.13 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  19.3571 ns | 0.0664 ns | 0.0621 ns |  19.3599 ns |  1.14 |    0.01 |      - |     - |     - |         - |
