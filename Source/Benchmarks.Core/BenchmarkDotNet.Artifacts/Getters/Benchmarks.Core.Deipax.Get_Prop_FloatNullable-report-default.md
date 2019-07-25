
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |   1.2494 ns | 0.0040 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.7268 ns | 0.0044 ns | 0.0041 ns |  1.38 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.4555 ns | 0.0048 ns | 0.0045 ns |  1.16 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   1.1329 ns | 0.0046 ns | 0.0040 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   1.4353 ns | 0.0073 ns | 0.0069 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.9717 ns | 0.0119 ns | 0.0093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   5.1428 ns | 0.0121 ns | 0.0101 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.7215 ns | 0.0286 ns | 0.0267 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   5.1350 ns | 0.0088 ns | 0.0082 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   5.1853 ns | 0.0061 ns | 0.0057 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   0.9293 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.1620 ns | 0.0046 ns | 0.0041 ns |  1.25 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.0402 ns | 0.0028 ns | 0.0023 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |   0.6762 ns | 0.0073 ns | 0.0068 ns |  0.73 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |   0.9554 ns | 0.0062 ns | 0.0058 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.0317 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.4420 ns | 0.0097 ns | 0.0091 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.2303 ns | 0.0091 ns | 0.0085 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.4460 ns | 0.0089 ns | 0.0083 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.4447 ns | 0.0086 ns | 0.0081 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.7198 ns | 0.0155 ns | 0.0145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   5.0867 ns | 0.0156 ns | 0.0146 ns |  1.08 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.9188 ns | 0.0080 ns | 0.0071 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.9063 ns | 0.0127 ns | 0.0112 ns |  0.83 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.9809 ns | 0.0109 ns | 0.0102 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   7.5869 ns | 0.0245 ns | 0.0229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   7.0021 ns | 0.0090 ns | 0.0075 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   7.2585 ns | 0.0235 ns | 0.0208 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   7.2987 ns | 0.0291 ns | 0.0272 ns |  0.96 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   7.3080 ns | 0.0376 ns | 0.0352 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.6408 ns | 0.0096 ns | 0.0090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   5.0646 ns | 0.0141 ns | 0.0118 ns |  1.09 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.9762 ns | 0.0135 ns | 0.0120 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   3.7734 ns | 0.0086 ns | 0.0076 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   3.8735 ns | 0.0116 ns | 0.0108 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   7.5255 ns | 0.0160 ns | 0.0142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.9854 ns | 0.0136 ns | 0.0127 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   7.2503 ns | 0.0220 ns | 0.0195 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   7.2453 ns | 0.0218 ns | 0.0204 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   7.2550 ns | 0.0484 ns | 0.0429 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   4.7462 ns | 0.0169 ns | 0.0150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   5.0334 ns | 0.0120 ns | 0.0112 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   5.0387 ns | 0.0332 ns | 0.0310 ns |  1.06 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |   3.8979 ns | 0.0099 ns | 0.0088 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   4.0017 ns | 0.0246 ns | 0.0218 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   7.5254 ns | 0.0119 ns | 0.0112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   7.0574 ns | 0.0420 ns | 0.0393 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   7.2514 ns | 0.0167 ns | 0.0156 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   7.3057 ns | 0.0285 ns | 0.0253 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   7.2421 ns | 0.0145 ns | 0.0128 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.6886 ns | 0.0099 ns | 0.0088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   5.1038 ns | 0.0087 ns | 0.0072 ns |  1.09 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   4.9887 ns | 0.0340 ns | 0.0318 ns |  1.06 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.8921 ns | 0.0115 ns | 0.0096 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.9936 ns | 0.0141 ns | 0.0118 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   7.5266 ns | 0.0235 ns | 0.0220 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   8.1777 ns | 0.0210 ns | 0.0196 ns |  1.09 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   7.2527 ns | 0.0178 ns | 0.0166 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   7.2331 ns | 0.0195 ns | 0.0182 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   7.2457 ns | 0.0219 ns | 0.0171 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   3.2258 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   4.1490 ns | 0.0135 ns | 0.0126 ns |  1.29 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.6235 ns | 0.0298 ns | 0.0279 ns |  1.12 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   3.5042 ns | 0.0212 ns | 0.0177 ns |  1.09 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   3.4558 ns | 0.0088 ns | 0.0082 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   6.3946 ns | 0.0293 ns | 0.0274 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   6.2825 ns | 0.0147 ns | 0.0130 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.6582 ns | 0.0760 ns | 0.0674 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   6.5529 ns | 0.0282 ns | 0.0250 ns |  1.03 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   6.6167 ns | 0.0238 ns | 0.0223 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   3.5161 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.6008 ns | 0.0317 ns | 0.0297 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.5750 ns | 0.0082 ns | 0.0076 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   3.5585 ns | 0.0318 ns | 0.0297 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   3.4272 ns | 0.0134 ns | 0.0112 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   6.4048 ns | 0.0250 ns | 0.0222 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.2819 ns | 0.0151 ns | 0.0141 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.5518 ns | 0.0181 ns | 0.0151 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.5391 ns | 0.0138 ns | 0.0123 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.5337 ns | 0.0171 ns | 0.0151 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.7877 ns | 0.0180 ns | 0.0150 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.9576 ns | 0.0070 ns | 0.0058 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.9326 ns | 0.0099 ns | 0.0088 ns |  0.77 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   3.9388 ns | 0.0122 ns | 0.0108 ns |  1.04 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |   4.2659 ns | 0.0089 ns | 0.0070 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.7280 ns | 0.0127 ns | 0.0113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   3.4517 ns | 0.0121 ns | 0.0108 ns |  0.73 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.4395 ns | 0.0087 ns | 0.0072 ns |  0.73 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   5.8460 ns | 0.0097 ns | 0.0090 ns |  1.24 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   5.5707 ns | 0.0339 ns | 0.0317 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   3.7760 ns | 0.0099 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.8853 ns | 0.0296 ns | 0.0277 ns |  0.76 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.8108 ns | 0.0106 ns | 0.0099 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   3.7383 ns | 0.0163 ns | 0.0153 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |   4.0262 ns | 0.0245 ns | 0.0229 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.5812 ns | 0.0131 ns | 0.0123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.5404 ns | 0.0106 ns | 0.0099 ns |  0.77 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   3.4647 ns | 0.0201 ns | 0.0188 ns |  0.76 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   5.3000 ns | 0.0095 ns | 0.0079 ns |  1.16 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   5.2549 ns | 0.0099 ns | 0.0087 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.4475 ns | 0.0045 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   2.0494 ns | 0.0051 ns | 0.0045 ns |  1.42 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.5668 ns | 0.0046 ns | 0.0038 ns |  1.08 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   1.8706 ns | 0.0064 ns | 0.0057 ns |  1.29 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |   1.9156 ns | 0.0166 ns | 0.0147 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   1.1934 ns | 0.0024 ns | 0.0021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   1.1566 ns | 0.0025 ns | 0.0022 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   0.9593 ns | 0.0051 ns | 0.0045 ns |  0.80 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   1.1693 ns | 0.0069 ns | 0.0061 ns |  0.98 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   1.1838 ns | 0.0073 ns | 0.0065 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.6826 ns | 0.0100 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.3749 ns | 0.0132 ns | 0.0123 ns |  0.82 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.2960 ns | 0.0058 ns | 0.0054 ns |  0.77 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |   1.1511 ns | 0.0040 ns | 0.0037 ns |  0.68 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   1.4282 ns | 0.0059 ns | 0.0049 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   2.2318 ns | 0.0704 ns | 0.0753 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   2.0791 ns | 0.0268 ns | 0.0251 ns |  0.94 |    0.04 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.9686 ns | 0.0064 ns | 0.0050 ns |  0.89 |    0.03 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   3.1778 ns | 0.0169 ns | 0.0141 ns |  1.44 |    0.05 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   3.1444 ns | 0.0079 ns | 0.0070 ns |  1.42 |    0.05 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  24.0686 ns | 0.0428 ns | 0.0380 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  23.9808 ns | 0.0585 ns | 0.0547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  11.7146 ns | 0.0377 ns | 0.0334 ns |  0.49 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  24.2531 ns | 0.0455 ns | 0.0425 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  24.2723 ns | 0.0359 ns | 0.0300 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  33.9702 ns | 0.0662 ns | 0.0587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  34.1049 ns | 0.1062 ns | 0.0994 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  16.8862 ns | 0.1374 ns | 0.1218 ns |  0.50 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  35.1076 ns | 0.1939 ns | 0.1619 ns |  1.03 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  34.5882 ns | 0.0634 ns | 0.0562 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3567 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.1068 ns | 0.0070 ns | 0.0062 ns |  0.89 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.0629 ns | 0.0082 ns | 0.0069 ns |  0.88 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.4276 ns | 0.0057 ns | 0.0051 ns |  0.61 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.4109 ns | 0.0050 ns | 0.0047 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.3743 ns | 0.0390 ns | 0.0365 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.4983 ns | 0.0259 ns | 0.0229 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.9217 ns | 0.0069 ns | 0.0057 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.4359 ns | 0.0233 ns | 0.0207 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.4466 ns | 0.0402 ns | 0.0336 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.9311 ns | 0.0288 ns | 0.0269 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.5959 ns | 0.0269 ns | 0.0239 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.6935 ns | 0.0339 ns | 0.0317 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.7853 ns | 0.0240 ns | 0.0224 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.8156 ns | 0.0113 ns | 0.0100 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 165.9725 ns | 0.2502 ns | 0.2218 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 106.1461 ns | 0.1812 ns | 0.1695 ns |  0.64 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 112.1740 ns | 0.4127 ns | 0.3659 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 282.3639 ns | 0.4947 ns | 0.4131 ns |  1.70 |    0.00 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 291.8947 ns | 4.1729 ns | 3.9034 ns |  1.76 |    0.02 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  14.6985 ns | 0.0300 ns | 0.0280 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  14.8121 ns | 0.0550 ns | 0.0487 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.7290 ns | 0.0214 ns | 0.0189 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  17.7273 ns | 0.0578 ns | 0.0541 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  17.3289 ns | 0.0579 ns | 0.0513 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  19.0561 ns | 0.0696 ns | 0.0651 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  18.7430 ns | 0.0338 ns | 0.0300 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  15.2522 ns | 0.0561 ns | 0.0525 ns |  0.80 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  22.1052 ns | 0.0554 ns | 0.0518 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  22.1676 ns | 0.1302 ns | 0.1218 ns |  1.16 |    0.01 |      - |     - |     - |         - |
