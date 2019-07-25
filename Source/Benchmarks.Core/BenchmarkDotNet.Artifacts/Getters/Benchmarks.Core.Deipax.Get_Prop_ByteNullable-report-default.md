
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4558 ns | 0.0051 ns | 0.0047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2432 ns | 0.0063 ns | 0.0052 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3187 ns | 0.0045 ns | 0.0043 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.0316 ns | 0.0028 ns | 0.0026 ns |  0.71 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.0436 ns | 0.0155 ns | 0.0145 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4546 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4153 ns | 0.0093 ns | 0.0082 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2826 ns | 0.0226 ns | 0.0211 ns |  0.96 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.6842 ns | 0.0075 ns | 0.0070 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6802 ns | 0.0083 ns | 0.0073 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7784 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.3600 ns | 0.0043 ns | 0.0038 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.3987 ns | 0.0088 ns | 0.0078 ns |  0.79 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  0.9913 ns | 0.0073 ns | 0.0065 ns |  0.56 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.9705 ns | 0.0014 ns | 0.0011 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.4884 ns | 0.0141 ns | 0.0125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.6464 ns | 0.0082 ns | 0.0064 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2714 ns | 0.0121 ns | 0.0113 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.6850 ns | 0.0069 ns | 0.0065 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.6787 ns | 0.0081 ns | 0.0072 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.6945 ns | 0.0055 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.7326 ns | 0.0043 ns | 0.0038 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5149 ns | 0.0041 ns | 0.0039 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.8265 ns | 0.0034 ns | 0.0029 ns |  1.08 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.8647 ns | 0.0165 ns | 0.0147 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4658 ns | 0.0281 ns | 0.0249 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.6485 ns | 0.0047 ns | 0.0042 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.5473 ns | 0.0076 ns | 0.0067 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3805 ns | 0.0044 ns | 0.0034 ns |  1.21 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.4451 ns | 0.0293 ns | 0.0274 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.4427 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6380 ns | 0.0060 ns | 0.0053 ns |  1.14 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5446 ns | 0.0049 ns | 0.0044 ns |  1.07 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.8703 ns | 0.0036 ns | 0.0034 ns |  1.30 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  1.9051 ns | 0.0250 ns | 0.0221 ns |  1.32 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  1.0912 ns | 0.0028 ns | 0.0022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  0.9270 ns | 0.0051 ns | 0.0045 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  0.9710 ns | 0.0095 ns | 0.0089 ns |  0.89 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  0.9982 ns | 0.0103 ns | 0.0096 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  0.9914 ns | 0.0170 ns | 0.0151 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4888 ns | 0.0051 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6400 ns | 0.0040 ns | 0.0037 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.3945 ns | 0.0045 ns | 0.0040 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.1501 ns | 0.0046 ns | 0.0041 ns |  0.77 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.1672 ns | 0.0155 ns | 0.0145 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4548 ns | 0.0116 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.6728 ns | 0.0221 ns | 0.0185 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2371 ns | 0.0082 ns | 0.0073 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.6900 ns | 0.0101 ns | 0.0079 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.7727 ns | 0.0410 ns | 0.0383 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6522 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2025 ns | 0.0033 ns | 0.0029 ns |  0.73 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.2319 ns | 0.0039 ns | 0.0034 ns |  0.75 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.1547 ns | 0.0045 ns | 0.0042 ns |  0.70 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.1823 ns | 0.0239 ns | 0.0224 ns |  0.72 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4464 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.6445 ns | 0.0103 ns | 0.0086 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2696 ns | 0.0094 ns | 0.0084 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6793 ns | 0.0084 ns | 0.0079 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.7363 ns | 0.0244 ns | 0.0228 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.5056 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.3594 ns | 0.0040 ns | 0.0037 ns |  0.90 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.3988 ns | 0.0065 ns | 0.0058 ns |  0.93 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.9811 ns | 0.0041 ns | 0.0038 ns |  0.65 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.0012 ns | 0.0150 ns | 0.0117 ns |  0.67 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2145 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4070 ns | 0.0049 ns | 0.0043 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0062 ns | 0.0075 ns | 0.0066 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4792 ns | 0.0246 ns | 0.0218 ns |  1.06 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4959 ns | 0.0287 ns | 0.0255 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5668 ns | 0.0134 ns | 0.0126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.2122 ns | 0.0122 ns | 0.0102 ns |  0.77 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2611 ns | 0.0037 ns | 0.0033 ns |  0.80 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.1510 ns | 0.0043 ns | 0.0038 ns |  0.73 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.2010 ns | 0.0521 ns | 0.0579 ns |  0.77 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2236 ns | 0.0242 ns | 0.0202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4143 ns | 0.0086 ns | 0.0076 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0383 ns | 0.0059 ns | 0.0049 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4691 ns | 0.0283 ns | 0.0251 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4941 ns | 0.0177 ns | 0.0166 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4018 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2450 ns | 0.0088 ns | 0.0082 ns |  0.89 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.2713 ns | 0.0036 ns | 0.0034 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1298 ns | 0.0055 ns | 0.0049 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.1780 ns | 0.0263 ns | 0.0246 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.8480 ns | 0.0066 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.9731 ns | 0.0223 ns | 0.0209 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.7205 ns | 0.0056 ns | 0.0049 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.6187 ns | 0.0153 ns | 0.0143 ns |  1.42 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.6972 ns | 0.0463 ns | 0.0433 ns |  1.46 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.5821 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2132 ns | 0.0054 ns | 0.0045 ns |  0.77 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2667 ns | 0.0020 ns | 0.0019 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  0.9709 ns | 0.0039 ns | 0.0037 ns |  0.61 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.9900 ns | 0.0227 ns | 0.0201 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.8190 ns | 0.0151 ns | 0.0141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0115 ns | 0.0074 ns | 0.0066 ns |  1.11 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1322 ns | 0.0042 ns | 0.0040 ns |  1.17 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.3377 ns | 0.0069 ns | 0.0057 ns |  1.28 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.4141 ns | 0.0364 ns | 0.0341 ns |  1.33 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5876 ns | 0.0056 ns | 0.0049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3905 ns | 0.0088 ns | 0.0078 ns |  0.88 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3453 ns | 0.0027 ns | 0.0024 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1508 ns | 0.0050 ns | 0.0039 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1670 ns | 0.0137 ns | 0.0114 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4506 ns | 0.0118 ns | 0.0099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8765 ns | 0.0073 ns | 0.0065 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.5059 ns | 0.0104 ns | 0.0098 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.9095 ns | 0.0111 ns | 0.0104 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.9569 ns | 0.0208 ns | 0.0195 ns |  1.11 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5988 ns | 0.0083 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4840 ns | 0.0085 ns | 0.0080 ns |  0.93 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4669 ns | 0.0043 ns | 0.0040 ns |  0.92 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.0307 ns | 0.0080 ns | 0.0075 ns |  0.64 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.0569 ns | 0.0370 ns | 0.0328 ns |  0.66 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8006 ns | 0.0137 ns | 0.0128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9234 ns | 0.0037 ns | 0.0032 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.3611 ns | 0.0058 ns | 0.0048 ns |  1.31 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6132 ns | 0.0056 ns | 0.0052 ns |  1.45 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.6639 ns | 0.0347 ns | 0.0308 ns |  1.48 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.3018 ns | 0.0160 ns | 0.0142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0838 ns | 0.0200 ns | 0.0187 ns |  0.97 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0558 ns | 0.1306 ns | 0.1221 ns |  0.96 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.5629 ns | 0.0141 ns | 0.0125 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.3981 ns | 0.0451 ns | 0.0422 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.4161 ns | 0.0441 ns | 0.0413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.1958 ns | 0.0272 ns | 0.0241 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.8915 ns | 0.0323 ns | 0.0252 ns |  0.70 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.7329 ns | 0.0856 ns | 0.0801 ns |  1.02 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.8635 ns | 0.0756 ns | 0.0708 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2789 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0578 ns | 0.0040 ns | 0.0031 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3635 ns | 0.0062 ns | 0.0055 ns |  1.04 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.4310 ns | 0.0043 ns | 0.0036 ns |  0.63 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.4564 ns | 0.0212 ns | 0.0199 ns |  0.64 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2916 ns | 0.0304 ns | 0.0284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5234 ns | 0.0203 ns | 0.0180 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9482 ns | 0.0050 ns | 0.0041 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4080 ns | 0.0137 ns | 0.0121 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.5339 ns | 0.1362 ns | 0.1274 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8915 ns | 0.0390 ns | 0.0365 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5546 ns | 0.0147 ns | 0.0130 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.6585 ns | 0.0529 ns | 0.0495 ns |  1.20 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8780 ns | 0.0134 ns | 0.0119 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.9034 ns | 0.0515 ns | 0.0457 ns |  1.00 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.9970 ns | 0.0943 ns | 0.0882 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.6395 ns | 0.0480 ns | 0.0449 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.5929 ns | 0.0156 ns | 0.0146 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.5850 ns | 0.0948 ns | 0.0791 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 32.4731 ns | 0.5819 ns | 0.5443 ns |  1.08 |    0.02 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.9138 ns | 0.0657 ns | 0.0614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4543 ns | 0.0231 ns | 0.0205 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.4736 ns | 0.0191 ns | 0.0169 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.3836 ns | 0.0848 ns | 0.0751 ns |  1.19 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.4616 ns | 0.1424 ns | 0.1332 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.8380 ns | 0.0167 ns | 0.0157 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.9505 ns | 0.0266 ns | 0.0249 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.1425 ns | 0.0200 ns | 0.0156 ns |  0.78 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.9201 ns | 0.0229 ns | 0.0203 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.3004 ns | 0.1515 ns | 0.1417 ns |  1.21 |    0.01 |      - |     - |     - |         - |
