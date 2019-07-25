
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
             ToBool | .NET Core 2.0 |  1.2564 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6611 ns | 0.0043 ns | 0.0038 ns |  1.32 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4202 ns | 0.0052 ns | 0.0049 ns |  1.13 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  1.1911 ns | 0.0065 ns | 0.0061 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  1.1800 ns | 0.0043 ns | 0.0040 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2652 ns | 0.0075 ns | 0.0067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4482 ns | 0.0073 ns | 0.0068 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.4950 ns | 0.0066 ns | 0.0062 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.8716 ns | 0.0126 ns | 0.0118 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.8710 ns | 0.0106 ns | 0.0094 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.4482 ns | 0.0108 ns | 0.0101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.7518 ns | 0.0051 ns | 0.0045 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.2004 ns | 0.0079 ns | 0.0066 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.3514 ns | 0.0062 ns | 0.0055 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.3457 ns | 0.0091 ns | 0.0081 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.2288 ns | 0.0258 ns | 0.0242 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.1438 ns | 0.0132 ns | 0.0124 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7217 ns | 0.0194 ns | 0.0162 ns |  0.90 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3300 ns | 0.0122 ns | 0.0102 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3727 ns | 0.0322 ns | 0.0286 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.3966 ns | 0.0039 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.7467 ns | 0.0156 ns | 0.0146 ns |  1.15 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.4828 ns | 0.0136 ns | 0.0127 ns |  1.04 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.3523 ns | 0.0048 ns | 0.0043 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.3722 ns | 0.0160 ns | 0.0150 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.1894 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.1454 ns | 0.0065 ns | 0.0061 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.7406 ns | 0.0126 ns | 0.0111 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3331 ns | 0.0123 ns | 0.0109 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3283 ns | 0.0100 ns | 0.0089 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.9312 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.6495 ns | 0.0086 ns | 0.0072 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.8400 ns | 0.0073 ns | 0.0061 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.3774 ns | 0.0099 ns | 0.0092 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3607 ns | 0.0156 ns | 0.0130 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.1934 ns | 0.0077 ns | 0.0072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.1493 ns | 0.0102 ns | 0.0090 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7265 ns | 0.0071 ns | 0.0066 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3565 ns | 0.0393 ns | 0.0368 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3399 ns | 0.0089 ns | 0.0079 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  3.1184 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.7380 ns | 0.0069 ns | 0.0054 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  3.2548 ns | 0.0645 ns | 0.0603 ns |  1.04 |    0.02 |      - |     - |     - |         - |
            ToShort |        net461 |  2.3336 ns | 0.0046 ns | 0.0043 ns |  0.75 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.3241 ns | 0.0058 ns | 0.0051 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.2039 ns | 0.0136 ns | 0.0127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.1724 ns | 0.0202 ns | 0.0189 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.6969 ns | 0.0085 ns | 0.0076 ns |  0.90 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3701 ns | 0.0366 ns | 0.0342 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3366 ns | 0.0117 ns | 0.0110 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.6813 ns | 0.0093 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.7167 ns | 0.0075 ns | 0.0070 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.8182 ns | 0.0069 ns | 0.0064 ns |  1.05 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.5973 ns | 0.0091 ns | 0.0085 ns |  0.97 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.5770 ns | 0.0079 ns | 0.0074 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.1931 ns | 0.0111 ns | 0.0098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.1544 ns | 0.0139 ns | 0.0130 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.6996 ns | 0.0092 ns | 0.0081 ns |  0.90 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3361 ns | 0.0156 ns | 0.0146 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3899 ns | 0.0066 ns | 0.0055 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.3923 ns | 0.0061 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.6803 ns | 0.0024 ns | 0.0020 ns |  1.21 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.5389 ns | 0.0040 ns | 0.0037 ns |  1.11 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  1.8904 ns | 0.0041 ns | 0.0037 ns |  1.36 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  1.8973 ns | 0.0211 ns | 0.0198 ns |  1.36 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  0.9628 ns | 0.0037 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  1.2617 ns | 0.0066 ns | 0.0062 ns |  1.31 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  1.1270 ns | 0.0075 ns | 0.0070 ns |  1.17 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  1.1424 ns | 0.0070 ns | 0.0062 ns |  1.19 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  1.1424 ns | 0.0051 ns | 0.0045 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6685 ns | 0.0146 ns | 0.0137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.7187 ns | 0.0062 ns | 0.0055 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4445 ns | 0.0048 ns | 0.0044 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.3722 ns | 0.0124 ns | 0.0116 ns |  1.42 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.3478 ns | 0.0057 ns | 0.0050 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4986 ns | 0.0064 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4532 ns | 0.0133 ns | 0.0124 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0017 ns | 0.0120 ns | 0.0113 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.0964 ns | 0.0054 ns | 0.0048 ns |  1.13 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.1533 ns | 0.0161 ns | 0.0150 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.2673 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4854 ns | 0.0048 ns | 0.0045 ns |  1.17 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.7338 ns | 0.0048 ns | 0.0045 ns |  1.37 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.4486 ns | 0.0044 ns | 0.0036 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  1.4315 ns | 0.0080 ns | 0.0075 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1279 ns | 0.0082 ns | 0.0073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0417 ns | 0.0090 ns | 0.0080 ns |  0.96 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1301 ns | 0.0127 ns | 0.0118 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1118 ns | 0.0062 ns | 0.0052 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1274 ns | 0.0172 ns | 0.0161 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.7453 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.7486 ns | 0.0137 ns | 0.0128 ns |  1.00 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.7187 ns | 0.0061 ns | 0.0057 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  2.1333 ns | 0.0086 ns | 0.0080 ns |  1.22 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  2.1373 ns | 0.0050 ns | 0.0044 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1760 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2981 ns | 0.0070 ns | 0.0066 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0495 ns | 0.0097 ns | 0.0086 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.9824 ns | 0.0137 ns | 0.0121 ns |  1.37 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.9947 ns | 0.0107 ns | 0.0101 ns |  1.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6700 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4853 ns | 0.0043 ns | 0.0040 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3308 ns | 0.0028 ns | 0.0026 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.4288 ns | 0.0124 ns | 0.0110 ns |  0.86 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.4544 ns | 0.0097 ns | 0.0091 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4950 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.7109 ns | 0.0215 ns | 0.0201 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.6879 ns | 0.0146 ns | 0.0129 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.1027 ns | 0.0134 ns | 0.0126 ns |  1.14 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.1001 ns | 0.0107 ns | 0.0089 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.7077 ns | 0.0119 ns | 0.0106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.5740 ns | 0.0027 ns | 0.0026 ns |  0.92 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5161 ns | 0.0028 ns | 0.0026 ns |  0.89 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.2195 ns | 0.0045 ns | 0.0035 ns |  0.71 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.2056 ns | 0.0027 ns | 0.0023 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9481 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.1866 ns | 0.0136 ns | 0.0127 ns |  1.12 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0721 ns | 0.0048 ns | 0.0042 ns |  1.06 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5935 ns | 0.0149 ns | 0.0139 ns |  1.33 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5951 ns | 0.0119 ns | 0.0111 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.1138 ns | 0.0138 ns | 0.0129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0773 ns | 0.0123 ns | 0.0115 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.1444 ns | 0.1186 ns | 0.1110 ns |  1.01 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 | 10.3244 ns | 0.0472 ns | 0.0394 ns |  1.69 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2931 ns | 0.0274 ns | 0.0243 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.9089 ns | 0.0304 ns | 0.0270 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.2941 ns | 0.0897 ns | 0.0839 ns |  0.97 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.7968 ns | 0.1134 ns | 0.1061 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.6318 ns | 0.0294 ns | 0.0275 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.7050 ns | 0.1262 ns | 0.1181 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3549 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3899 ns | 0.0095 ns | 0.0080 ns |  1.01 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2335 ns | 0.0038 ns | 0.0029 ns |  0.95 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1431 ns | 0.0076 ns | 0.0067 ns |  0.49 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1286 ns | 0.0040 ns | 0.0037 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2736 ns | 0.0394 ns | 0.0369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2452 ns | 0.0383 ns | 0.0339 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9396 ns | 0.0063 ns | 0.0056 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4604 ns | 0.0129 ns | 0.0121 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.5598 ns | 0.0449 ns | 0.0420 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.9129 ns | 0.0128 ns | 0.0113 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5803 ns | 0.0065 ns | 0.0058 ns |  1.17 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.6180 ns | 0.0335 ns | 0.0313 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.7955 ns | 0.0123 ns | 0.0109 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7778 ns | 0.0099 ns | 0.0092 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.8596 ns | 0.0733 ns | 0.0685 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 18.1563 ns | 0.0611 ns | 0.0571 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.1154 ns | 0.0236 ns | 0.0221 ns |  0.44 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 32.3874 ns | 0.0925 ns | 0.0865 ns |  1.08 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 32.3486 ns | 0.2509 ns | 0.2347 ns |  1.08 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.7662 ns | 0.0194 ns | 0.0182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4870 ns | 0.0568 ns | 0.0532 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3632 ns | 0.0325 ns | 0.0304 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.5232 ns | 0.0543 ns | 0.0508 ns |  1.22 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.3067 ns | 0.0461 ns | 0.0409 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.8164 ns | 0.0279 ns | 0.0248 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.8326 ns | 0.0628 ns | 0.0524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.8733 ns | 0.0276 ns | 0.0245 ns |  0.77 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.9418 ns | 0.1394 ns | 0.1304 ns |  1.19 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.7694 ns | 0.0247 ns | 0.0219 ns |  1.18 |    0.00 |      - |     - |     - |         - |
