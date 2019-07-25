
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.6459 ns | 0.0135 ns | 0.0119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9383 ns | 0.0121 ns | 0.0113 ns |  1.45 |    0.03 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9171 ns | 0.0035 ns | 0.0033 ns |  1.42 |    0.03 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6846 ns | 0.0153 ns | 0.0143 ns |  1.06 |    0.03 |     - |     - |     - |         - |
             FromBool |        net472 |  0.7008 ns | 0.0024 ns | 0.0021 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9625 ns | 0.0047 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1677 ns | 0.0020 ns | 0.0018 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1314 ns | 0.0062 ns | 0.0058 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0265 ns | 0.0356 ns | 0.0333 ns |  2.11 |    0.03 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9567 ns | 0.0043 ns | 0.0038 ns |  2.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.4606 ns | 0.0151 ns | 0.0141 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.3872 ns | 0.0040 ns | 0.0035 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7028 ns | 0.0049 ns | 0.0043 ns |  0.48 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7896 ns | 0.0118 ns | 0.0105 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7773 ns | 0.0037 ns | 0.0031 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.9238 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7881 ns | 0.0162 ns | 0.0152 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1641 ns | 0.0031 ns | 0.0029 ns |  0.61 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9212 ns | 0.0081 ns | 0.0072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9356 ns | 0.0272 ns | 0.0255 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2959 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3951 ns | 0.0078 ns | 0.0073 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.9166 ns | 0.0046 ns | 0.0039 ns |  0.71 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7773 ns | 0.0058 ns | 0.0048 ns |  1.37 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7751 ns | 0.0053 ns | 0.0047 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7696 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7668 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9340 ns | 0.0026 ns | 0.0022 ns |  0.53 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9601 ns | 0.0101 ns | 0.0094 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9598 ns | 0.0319 ns | 0.0299 ns |  1.11 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6485 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7164 ns | 0.0018 ns | 0.0016 ns |  1.10 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6988 ns | 0.0042 ns | 0.0038 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5601 ns | 0.0082 ns | 0.0072 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5567 ns | 0.0040 ns | 0.0037 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.6175 ns | 0.0113 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.7078 ns | 0.0042 ns | 0.0039 ns |  1.15 |    0.02 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9320 ns | 0.0037 ns | 0.0031 ns |  1.51 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  0.5720 ns | 0.0032 ns | 0.0028 ns |  0.93 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  0.5629 ns | 0.0036 ns | 0.0028 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8246 ns | 0.0029 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  2.1178 ns | 0.0052 ns | 0.0046 ns |  1.16 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  2.1550 ns | 0.0068 ns | 0.0060 ns |  1.18 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8775 ns | 0.0154 ns | 0.0137 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8975 ns | 0.0205 ns | 0.0192 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8122 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.8977 ns | 0.0042 ns | 0.0037 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.7194 ns | 0.0074 ns | 0.0069 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0579 ns | 0.0057 ns | 0.0050 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9180 ns | 0.0041 ns | 0.0038 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.2934 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3901 ns | 0.0051 ns | 0.0045 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.8611 ns | 0.0019 ns | 0.0017 ns |  0.67 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  2.4838 ns | 0.0054 ns | 0.0045 ns |  1.92 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7767 ns | 0.0063 ns | 0.0055 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.8156 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.7843 ns | 0.0049 ns | 0.0041 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1730 ns | 0.0028 ns | 0.0025 ns |  0.65 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9208 ns | 0.0060 ns | 0.0053 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9186 ns | 0.0070 ns | 0.0062 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.7894 ns | 0.0146 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8143 ns | 0.0054 ns | 0.0048 ns |  1.01 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.8326 ns | 0.0027 ns | 0.0025 ns |  1.02 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7488 ns | 0.0302 ns | 0.0252 ns |  0.98 |    0.02 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7560 ns | 0.0255 ns | 0.0238 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8219 ns | 0.0119 ns | 0.0111 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7490 ns | 0.0031 ns | 0.0026 ns |  0.96 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.7065 ns | 0.0019 ns | 0.0017 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.0492 ns | 0.0088 ns | 0.0073 ns |  1.13 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.1620 ns | 0.0113 ns | 0.0100 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4520 ns | 0.0035 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4448 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9132 ns | 0.0029 ns | 0.0025 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.8474 ns | 0.0238 ns | 0.0223 ns |  1.27 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.9236 ns | 0.0059 ns | 0.0050 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.8971 ns | 0.0065 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9135 ns | 0.0068 ns | 0.0063 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0562 ns | 0.0047 ns | 0.0042 ns |  0.56 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9197 ns | 0.0076 ns | 0.0071 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9865 ns | 0.0147 ns | 0.0130 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8178 ns | 0.0034 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8516 ns | 0.0053 ns | 0.0047 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  2.0573 ns | 0.0043 ns | 0.0036 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7496 ns | 0.0068 ns | 0.0063 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7797 ns | 0.0187 ns | 0.0175 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.8831 ns | 0.0066 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7135 ns | 0.0050 ns | 0.0045 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7680 ns | 0.0051 ns | 0.0045 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0343 ns | 0.0113 ns | 0.0100 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.7424 ns | 0.0038 ns | 0.0033 ns |  1.46 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.7995 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7114 ns | 0.0061 ns | 0.0054 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6150 ns | 0.0038 ns | 0.0036 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7715 ns | 0.0047 ns | 0.0044 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8138 ns | 0.0276 ns | 0.0258 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9871 ns | 0.0084 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7907 ns | 0.0057 ns | 0.0050 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7806 ns | 0.0026 ns | 0.0023 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9474 ns | 0.0137 ns | 0.0128 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9364 ns | 0.0073 ns | 0.0065 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8045 ns | 0.0241 ns | 0.0225 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9739 ns | 0.0164 ns | 0.0145 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.4648 ns | 0.0068 ns | 0.0061 ns |  1.17 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.0238 ns | 0.0218 ns | 0.0193 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.1686 ns | 0.0306 ns | 0.0287 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8618 ns | 0.0040 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7733 ns | 0.0045 ns | 0.0042 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.6881 ns | 0.0036 ns | 0.0034 ns |  0.91 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9343 ns | 0.0160 ns | 0.0150 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9622 ns | 0.0151 ns | 0.0141 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.5473 ns | 0.0092 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.8193 ns | 0.0131 ns | 0.0123 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.7411 ns | 0.0064 ns | 0.0057 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4343 ns | 0.0416 ns | 0.0347 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4446 ns | 0.0086 ns | 0.0080 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9348 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9237 ns | 0.0048 ns | 0.0042 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9287 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1451 ns | 0.0140 ns | 0.0125 ns |  1.11 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1433 ns | 0.0045 ns | 0.0038 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.7058 ns | 0.0644 ns | 0.0571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.7380 ns | 0.0305 ns | 0.0286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.7224 ns | 0.0155 ns | 0.0145 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.4305 ns | 0.1874 ns | 0.1661 ns |  1.05 |    0.02 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.2667 ns | 0.1249 ns | 0.1169 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.4355 ns | 0.0179 ns | 0.0158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.6973 ns | 0.0196 ns | 0.0174 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5845 ns | 0.0176 ns | 0.0156 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.3691 ns | 0.2527 ns | 0.2808 ns |  1.12 |    0.04 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.1812 ns | 0.0165 ns | 0.0155 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6698 ns | 0.0022 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7319 ns | 0.0075 ns | 0.0066 ns |  1.09 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6902 ns | 0.0046 ns | 0.0039 ns |  1.03 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7031 ns | 0.0132 ns | 0.0124 ns |  1.05 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9581 ns | 0.0081 ns | 0.0068 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4837 ns | 0.0150 ns | 0.0140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6370 ns | 0.0026 ns | 0.0023 ns |  1.10 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4836 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6926 ns | 0.0109 ns | 0.0102 ns |  1.14 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.7065 ns | 0.0186 ns | 0.0174 ns |  1.15 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0347 ns | 0.0193 ns | 0.0181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8434 ns | 0.0052 ns | 0.0046 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7036 ns | 0.0085 ns | 0.0075 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8845 ns | 0.0100 ns | 0.0089 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  3.0182 ns | 0.0091 ns | 0.0081 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.7958 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.9124 ns | 0.0039 ns | 0.0037 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9166 ns | 0.0023 ns | 0.0021 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.9059 ns | 0.0685 ns | 0.0914 ns |  1.07 |    0.06 |     - |     - |     - |         - |
           FromString |        net472 |  1.8510 ns | 0.0143 ns | 0.0134 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8179 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8669 ns | 0.0036 ns | 0.0032 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.9016 ns | 0.0871 ns | 0.0772 ns |  1.05 |    0.04 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7445 ns | 0.0041 ns | 0.0038 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.9610 ns | 0.0059 ns | 0.0055 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8143 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7788 ns | 0.0081 ns | 0.0076 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.7692 ns | 0.0631 ns | 0.0648 ns |  0.98 |    0.04 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9287 ns | 0.0161 ns | 0.0151 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9461 ns | 0.0055 ns | 0.0051 ns |  1.07 |    0.00 |     - |     - |     - |         - |
