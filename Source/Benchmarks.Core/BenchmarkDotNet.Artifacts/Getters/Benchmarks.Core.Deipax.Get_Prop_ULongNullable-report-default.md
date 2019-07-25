
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
             ToBool | .NET Core 2.0 |  1.4800 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6432 ns | 0.0046 ns | 0.0038 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.5989 ns | 0.0061 ns | 0.0057 ns |  1.08 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  1.0091 ns | 0.0085 ns | 0.0076 ns |  0.68 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.9811 ns | 0.0044 ns | 0.0042 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2833 ns | 0.0073 ns | 0.0065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4792 ns | 0.0063 ns | 0.0056 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.4967 ns | 0.0212 ns | 0.0199 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.9471 ns | 0.0232 ns | 0.0206 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.9007 ns | 0.0067 ns | 0.0056 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  3.0868 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.7809 ns | 0.0260 ns | 0.0243 ns |  0.90 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.5996 ns | 0.0070 ns | 0.0062 ns |  0.84 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.8134 ns | 0.0040 ns | 0.0038 ns |  0.59 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.8214 ns | 0.0175 ns | 0.0164 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.3944 ns | 0.0149 ns | 0.0117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.1382 ns | 0.0142 ns | 0.0126 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.6907 ns | 0.0102 ns | 0.0091 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3467 ns | 0.0114 ns | 0.0095 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3559 ns | 0.0069 ns | 0.0065 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.7126 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6931 ns | 0.0061 ns | 0.0051 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4345 ns | 0.0159 ns | 0.0149 ns |  0.84 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.3353 ns | 0.0064 ns | 0.0057 ns |  1.36 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.8121 ns | 0.0039 ns | 0.0032 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.5161 ns | 0.0096 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4378 ns | 0.0085 ns | 0.0079 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.2114 ns | 0.0098 ns | 0.0087 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3770 ns | 0.0278 ns | 0.0260 ns |  1.19 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3675 ns | 0.0051 ns | 0.0045 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.9360 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.9144 ns | 0.0081 ns | 0.0071 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.3648 ns | 0.0249 ns | 0.0233 ns |  0.81 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.0962 ns | 0.0114 ns | 0.0107 ns |  0.71 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.0950 ns | 0.0057 ns | 0.0050 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.4585 ns | 0.0418 ns | 0.0391 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.1832 ns | 0.0091 ns | 0.0081 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.8029 ns | 0.0478 ns | 0.0447 ns |  0.88 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3661 ns | 0.0092 ns | 0.0082 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3985 ns | 0.0346 ns | 0.0323 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.6512 ns | 0.0085 ns | 0.0076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.7213 ns | 0.0048 ns | 0.0042 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.5499 ns | 0.0112 ns | 0.0105 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.1011 ns | 0.0038 ns | 0.0036 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.0626 ns | 0.0035 ns | 0.0031 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.4377 ns | 0.0085 ns | 0.0075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.1296 ns | 0.0088 ns | 0.0083 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.6955 ns | 0.0096 ns | 0.0089 ns |  0.86 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3664 ns | 0.0108 ns | 0.0101 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3987 ns | 0.0509 ns | 0.0476 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.9684 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.7155 ns | 0.0113 ns | 0.0094 ns |  0.91 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.7438 ns | 0.0104 ns | 0.0092 ns |  0.92 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.0881 ns | 0.0231 ns | 0.0216 ns |  0.70 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.0668 ns | 0.0099 ns | 0.0093 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.4347 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.1631 ns | 0.0427 ns | 0.0400 ns |  0.95 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.7357 ns | 0.0156 ns | 0.0146 ns |  0.87 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3684 ns | 0.0125 ns | 0.0117 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3646 ns | 0.0096 ns | 0.0085 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.6595 ns | 0.0250 ns | 0.0233 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.7264 ns | 0.0077 ns | 0.0072 ns |  1.03 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  3.0489 ns | 0.0087 ns | 0.0082 ns |  1.15 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  2.3251 ns | 0.0085 ns | 0.0075 ns |  0.87 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  2.2902 ns | 0.0050 ns | 0.0047 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  5.2309 ns | 0.0343 ns | 0.0321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  5.1656 ns | 0.0315 ns | 0.0294 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.6854 ns | 0.0068 ns | 0.0064 ns |  0.90 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  5.1347 ns | 0.0098 ns | 0.0087 ns |  0.98 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  5.1431 ns | 0.0116 ns | 0.0090 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  2.0194 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.7055 ns | 0.0167 ns | 0.0156 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5809 ns | 0.0047 ns | 0.0041 ns |  0.78 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.0828 ns | 0.0123 ns | 0.0115 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.0707 ns | 0.0069 ns | 0.0064 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.5095 ns | 0.0104 ns | 0.0093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4392 ns | 0.0080 ns | 0.0071 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2665 ns | 0.0064 ns | 0.0060 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.3627 ns | 0.0098 ns | 0.0087 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.3656 ns | 0.0100 ns | 0.0088 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.6887 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.8441 ns | 0.0081 ns | 0.0072 ns |  1.09 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6010 ns | 0.0094 ns | 0.0088 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  2.0904 ns | 0.0217 ns | 0.0203 ns |  1.24 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  2.0690 ns | 0.0056 ns | 0.0052 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.4310 ns | 0.0088 ns | 0.0082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.6833 ns | 0.0124 ns | 0.0110 ns |  1.10 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.0672 ns | 0.0052 ns | 0.0046 ns |  0.85 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  3.5566 ns | 0.0065 ns | 0.0058 ns |  1.46 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  3.5805 ns | 0.0144 ns | 0.0135 ns |  1.47 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.4584 ns | 0.0051 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6710 ns | 0.0048 ns | 0.0043 ns |  1.15 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5381 ns | 0.0043 ns | 0.0040 ns |  1.05 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  1.8781 ns | 0.0054 ns | 0.0050 ns |  1.29 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  1.8602 ns | 0.0059 ns | 0.0052 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0074 ns | 0.0033 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.7184 ns | 0.0182 ns | 0.0170 ns |  0.86 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6168 ns | 0.0181 ns | 0.0169 ns |  0.81 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.6349 ns | 0.0044 ns | 0.0041 ns |  0.81 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.6187 ns | 0.0052 ns | 0.0048 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7891 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.9690 ns | 0.0046 ns | 0.0043 ns |  1.10 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.9044 ns | 0.0067 ns | 0.0060 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1694 ns | 0.0142 ns | 0.0133 ns |  0.65 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1591 ns | 0.0131 ns | 0.0122 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.9755 ns | 0.0058 ns | 0.0052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  5.1400 ns | 0.0120 ns | 0.0100 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.7211 ns | 0.0060 ns | 0.0050 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.1264 ns | 0.0061 ns | 0.0057 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.1287 ns | 0.0098 ns | 0.0092 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.9350 ns | 0.0216 ns | 0.0202 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.9572 ns | 0.0055 ns | 0.0052 ns |  1.01 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.7397 ns | 0.0062 ns | 0.0055 ns |  0.90 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.3700 ns | 0.0046 ns | 0.0039 ns |  0.71 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.3646 ns | 0.0053 ns | 0.0047 ns |  0.71 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.8059 ns | 0.0062 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.1984 ns | 0.0062 ns | 0.0058 ns |  0.78 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1237 ns | 0.0069 ns | 0.0061 ns |  0.76 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6248 ns | 0.0058 ns | 0.0051 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5925 ns | 0.0083 ns | 0.0078 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.1367 ns | 0.0345 ns | 0.0323 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.2994 ns | 0.0076 ns | 0.0071 ns |  1.03 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.1285 ns | 0.0179 ns | 0.0168 ns |  1.00 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.3167 ns | 0.0142 ns | 0.0133 ns |  1.03 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.3078 ns | 0.0123 ns | 0.0115 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.5266 ns | 0.0389 ns | 0.0345 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.1615 ns | 0.0257 ns | 0.0215 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.5712 ns | 0.0184 ns | 0.0144 ns |  0.68 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.7012 ns | 0.1119 ns | 0.1047 ns |  1.01 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.8064 ns | 0.1119 ns | 0.1046 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1738 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3998 ns | 0.0141 ns | 0.0118 ns |  1.10 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3054 ns | 0.0174 ns | 0.0163 ns |  1.06 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.0738 ns | 0.0063 ns | 0.0049 ns |  0.49 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1850 ns | 0.0050 ns | 0.0047 ns |  0.55 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0061 ns | 0.0268 ns | 0.0250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2093 ns | 0.0089 ns | 0.0079 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9346 ns | 0.0073 ns | 0.0068 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2652 ns | 0.0171 ns | 0.0160 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2847 ns | 0.0157 ns | 0.0131 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.9360 ns | 0.0106 ns | 0.0099 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.6533 ns | 0.0420 ns | 0.0393 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5270 ns | 0.0310 ns | 0.0290 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  4.3469 ns | 0.0200 ns | 0.0187 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.8871 ns | 0.0962 ns | 0.0853 ns |  0.99 |    0.02 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 31.1397 ns | 0.1543 ns | 0.1444 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 19.5333 ns | 0.0623 ns | 0.0583 ns |  0.63 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.3663 ns | 0.0991 ns | 0.0927 ns |  0.40 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.1661 ns | 0.1865 ns | 0.1653 ns |  1.00 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 32.5660 ns | 1.3785 ns | 1.5322 ns |  1.05 |    0.05 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.9728 ns | 0.0236 ns | 0.0209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.7087 ns | 0.0212 ns | 0.0177 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.8008 ns | 0.0173 ns | 0.0162 ns |  0.68 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 17.9117 ns | 0.0509 ns | 0.0476 ns |  1.38 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 16.0057 ns | 0.2250 ns | 0.1879 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 17.1073 ns | 0.0529 ns | 0.0469 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 17.2802 ns | 0.0401 ns | 0.0375 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.4121 ns | 0.0203 ns | 0.0159 ns |  0.78 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.2169 ns | 0.0377 ns | 0.0334 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.4230 ns | 0.1856 ns | 0.1737 ns |  1.19 |    0.01 |      - |     - |     - |         - |
