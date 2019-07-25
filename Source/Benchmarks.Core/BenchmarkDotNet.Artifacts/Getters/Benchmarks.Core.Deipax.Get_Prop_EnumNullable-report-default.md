
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
             ToBool | .NET Core 2.0 |   1.2583 ns | 0.0050 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.6412 ns | 0.0051 ns | 0.0048 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.6056 ns | 0.0098 ns | 0.0087 ns |  1.28 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.9994 ns | 0.0068 ns | 0.0057 ns |  0.79 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |   1.1853 ns | 0.0046 ns | 0.0038 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.2617 ns | 0.0166 ns | 0.0147 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.4576 ns | 0.0322 ns | 0.0301 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.4650 ns | 0.0124 ns | 0.0110 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.8632 ns | 0.0085 ns | 0.0071 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.9580 ns | 0.0190 ns | 0.0168 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   2.4444 ns | 0.0090 ns | 0.0084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   2.7220 ns | 0.0136 ns | 0.0127 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   2.2358 ns | 0.0133 ns | 0.0104 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |   2.1132 ns | 0.0205 ns | 0.0171 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |   2.3537 ns | 0.0032 ns | 0.0028 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   5.1867 ns | 0.0148 ns | 0.0138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   5.1359 ns | 0.0101 ns | 0.0094 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.7194 ns | 0.0083 ns | 0.0077 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   5.3309 ns | 0.0087 ns | 0.0077 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   5.4447 ns | 0.0096 ns | 0.0090 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   2.4269 ns | 0.0119 ns | 0.0105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   2.7292 ns | 0.0073 ns | 0.0064 ns |  1.12 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   3.2551 ns | 0.0103 ns | 0.0091 ns |  1.34 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |   2.0853 ns | 0.0060 ns | 0.0056 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   2.3522 ns | 0.0043 ns | 0.0038 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   5.1988 ns | 0.0102 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   5.1291 ns | 0.0130 ns | 0.0122 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   4.7440 ns | 0.0100 ns | 0.0088 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   5.3511 ns | 0.0225 ns | 0.0211 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   5.3647 ns | 0.0105 ns | 0.0093 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   2.9355 ns | 0.0088 ns | 0.0078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   2.6488 ns | 0.0112 ns | 0.0099 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   2.8158 ns | 0.0085 ns | 0.0080 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   2.1187 ns | 0.0084 ns | 0.0079 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   2.3135 ns | 0.0067 ns | 0.0059 ns |  0.79 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   5.1887 ns | 0.0123 ns | 0.0109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   5.1318 ns | 0.0134 ns | 0.0112 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   4.7421 ns | 0.0474 ns | 0.0370 ns |  0.91 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   5.3459 ns | 0.0119 ns | 0.0111 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   5.4408 ns | 0.0080 ns | 0.0075 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   3.1292 ns | 0.0149 ns | 0.0132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   2.7315 ns | 0.0095 ns | 0.0084 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   2.5416 ns | 0.0070 ns | 0.0062 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   2.0985 ns | 0.0264 ns | 0.0247 ns |  0.67 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |   2.3274 ns | 0.0056 ns | 0.0053 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   5.1861 ns | 0.0093 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   5.1274 ns | 0.0090 ns | 0.0080 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   4.7191 ns | 0.0129 ns | 0.0108 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   5.3322 ns | 0.0101 ns | 0.0079 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   5.3744 ns | 0.0293 ns | 0.0260 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   2.6669 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   2.6600 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   2.1947 ns | 0.0055 ns | 0.0049 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |   2.3226 ns | 0.0063 ns | 0.0053 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   2.5863 ns | 0.0105 ns | 0.0098 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   5.1864 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   5.1402 ns | 0.0137 ns | 0.0128 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   4.7233 ns | 0.0095 ns | 0.0089 ns |  0.91 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   5.3935 ns | 0.0402 ns | 0.0376 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   5.3703 ns | 0.0092 ns | 0.0077 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   1.2472 ns | 0.0137 ns | 0.0121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   1.7863 ns | 0.0072 ns | 0.0060 ns |  1.43 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   1.7497 ns | 0.0229 ns | 0.0214 ns |  1.40 |    0.03 |      - |     - |     - |         - |
              ToInt |        net461 |   1.1516 ns | 0.0038 ns | 0.0036 ns |  0.92 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   1.4371 ns | 0.0106 ns | 0.0099 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   4.2571 ns | 0.0101 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   4.2079 ns | 0.0092 ns | 0.0082 ns |  0.99 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   4.0200 ns | 0.0107 ns | 0.0100 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   4.4584 ns | 0.0431 ns | 0.0403 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   4.4370 ns | 0.0099 ns | 0.0092 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   1.7679 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   1.6945 ns | 0.0041 ns | 0.0039 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   1.2664 ns | 0.0058 ns | 0.0052 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   2.0773 ns | 0.0070 ns | 0.0062 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |   2.3583 ns | 0.0031 ns | 0.0028 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   4.4895 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   4.5008 ns | 0.0209 ns | 0.0174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   4.0301 ns | 0.0097 ns | 0.0091 ns |  0.90 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   5.1136 ns | 0.0276 ns | 0.0230 ns |  1.14 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   5.1323 ns | 0.0099 ns | 0.0093 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   1.2648 ns | 0.0117 ns | 0.0098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   1.4721 ns | 0.0052 ns | 0.0048 ns |  1.16 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   1.7289 ns | 0.0053 ns | 0.0045 ns |  1.37 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |   1.1589 ns | 0.0052 ns | 0.0049 ns |  0.92 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |   1.4065 ns | 0.0209 ns | 0.0196 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   2.1227 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   1.9433 ns | 0.0300 ns | 0.0281 ns |  0.92 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   2.1264 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   2.1040 ns | 0.0147 ns | 0.0131 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   2.2219 ns | 0.0049 ns | 0.0046 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   1.7730 ns | 0.0040 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   1.7136 ns | 0.0041 ns | 0.0036 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   1.7264 ns | 0.0057 ns | 0.0053 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   1.8279 ns | 0.0051 ns | 0.0048 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   2.1431 ns | 0.0348 ns | 0.0325 ns |  1.21 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   2.3594 ns | 0.0071 ns | 0.0066 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   2.2722 ns | 0.0071 ns | 0.0067 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   2.1465 ns | 0.0186 ns | 0.0165 ns |  0.91 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   2.8467 ns | 0.0380 ns | 0.0355 ns |  1.21 |    0.02 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   3.5406 ns | 0.0953 ns | 0.0891 ns |  1.50 |    0.04 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.4214 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.4867 ns | 0.0039 ns | 0.0031 ns |  1.05 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.4130 ns | 0.0051 ns | 0.0048 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   1.1559 ns | 0.0038 ns | 0.0035 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   1.4249 ns | 0.0056 ns | 0.0052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.4973 ns | 0.0140 ns | 0.0117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.6818 ns | 0.0151 ns | 0.0134 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.7293 ns | 0.0109 ns | 0.0102 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   5.0999 ns | 0.0077 ns | 0.0072 ns |  1.13 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   5.1331 ns | 0.0099 ns | 0.0093 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.4190 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.5712 ns | 0.0039 ns | 0.0035 ns |  1.11 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.3594 ns | 0.0049 ns | 0.0046 ns |  0.96 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.9882 ns | 0.0097 ns | 0.0086 ns |  0.70 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |   1.1889 ns | 0.0283 ns | 0.0251 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   2.1482 ns | 0.0189 ns | 0.0158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   2.3246 ns | 0.0031 ns | 0.0028 ns |  1.08 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   2.0922 ns | 0.0245 ns | 0.0205 ns |  0.97 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   2.5566 ns | 0.0086 ns | 0.0077 ns |  1.19 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   2.6369 ns | 0.0206 ns | 0.0193 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |   6.1003 ns | 0.0123 ns | 0.0109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |   6.0585 ns | 0.0106 ns | 0.0100 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |   6.1081 ns | 0.0162 ns | 0.0135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |   6.3233 ns | 0.0558 ns | 0.0522 ns |  1.04 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |   6.5971 ns | 0.0880 ns | 0.0823 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  18.9474 ns | 0.0420 ns | 0.0392 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  18.4044 ns | 0.0444 ns | 0.0415 ns |  0.97 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  12.8444 ns | 0.1676 ns | 0.1568 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  18.6422 ns | 0.0349 ns | 0.0309 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  18.6521 ns | 0.0541 ns | 0.0506 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.1236 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.3628 ns | 0.0077 ns | 0.0072 ns |  1.11 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.1803 ns | 0.0038 ns | 0.0034 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   0.9976 ns | 0.0024 ns | 0.0020 ns |  0.47 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.1794 ns | 0.0048 ns | 0.0043 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.3946 ns | 0.0267 ns | 0.0237 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.2303 ns | 0.0278 ns | 0.0260 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.9412 ns | 0.0082 ns | 0.0077 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.5461 ns | 0.0198 ns | 0.0185 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.2187 ns | 0.0185 ns | 0.0154 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.9267 ns | 0.0137 ns | 0.0128 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.6481 ns | 0.0207 ns | 0.0183 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.6553 ns | 0.0172 ns | 0.0144 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.7882 ns | 0.0078 ns | 0.0070 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.9263 ns | 0.0544 ns | 0.0508 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  52.3323 ns | 0.2636 ns | 0.2201 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 2.2 |  50.3907 ns | 0.1247 ns | 0.1166 ns |  0.96 |    0.01 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 3.0 |  31.4483 ns | 0.5737 ns | 0.5367 ns |  0.60 |    0.01 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 282.0978 ns | 2.0924 ns | 1.9572 ns |  5.39 |    0.04 | 0.0114 |     - |     - |      72 B |
          To_String |        net472 | 284.2777 ns | 0.9513 ns | 0.8433 ns |  5.43 |    0.03 | 0.0114 |     - |     - |      72 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |   1.4449 ns | 0.0070 ns | 0.0065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |   1.6704 ns | 0.0056 ns | 0.0049 ns |  1.16 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |   1.5920 ns | 0.0101 ns | 0.0085 ns |  1.10 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 |   1.8768 ns | 0.0045 ns | 0.0040 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 |   1.8947 ns | 0.0209 ns | 0.0196 ns |  1.31 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |   1.2028 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |   1.1821 ns | 0.0035 ns | 0.0032 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |   1.1170 ns | 0.0072 ns | 0.0067 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |   0.9318 ns | 0.0043 ns | 0.0033 ns |  0.78 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |   1.1867 ns | 0.0035 ns | 0.0029 ns |  0.99 |    0.01 |      - |     - |     - |         - |
