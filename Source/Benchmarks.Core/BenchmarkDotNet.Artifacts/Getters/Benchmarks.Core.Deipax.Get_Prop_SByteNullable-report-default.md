
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
             ToBool | .NET Core 2.0 |  1.1695 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4305 ns | 0.0083 ns | 0.0073 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.3141 ns | 0.0084 ns | 0.0074 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  1.2251 ns | 0.0210 ns | 0.0197 ns |  1.05 |    0.02 |      - |     - |     - |         - |
             ToBool |        net472 |  1.0309 ns | 0.0118 ns | 0.0104 ns |  0.88 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4745 ns | 0.0091 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4526 ns | 0.0133 ns | 0.0124 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2841 ns | 0.0060 ns | 0.0056 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.7336 ns | 0.0165 ns | 0.0155 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6998 ns | 0.0204 ns | 0.0181 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7295 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6872 ns | 0.0174 ns | 0.0162 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2881 ns | 0.0150 ns | 0.0140 ns |  0.75 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  2.3908 ns | 0.0089 ns | 0.0083 ns |  1.38 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  2.0712 ns | 0.0652 ns | 0.0578 ns |  1.20 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.4873 ns | 0.0073 ns | 0.0068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4463 ns | 0.0073 ns | 0.0069 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.5136 ns | 0.0066 ns | 0.0058 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.4543 ns | 0.0276 ns | 0.0258 ns |  1.22 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.4442 ns | 0.0133 ns | 0.0125 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.3763 ns | 0.0125 ns | 0.0111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6689 ns | 0.0052 ns | 0.0044 ns |  1.21 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5847 ns | 0.0058 ns | 0.0052 ns |  1.15 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.8964 ns | 0.0063 ns | 0.0059 ns |  1.38 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.8655 ns | 0.0044 ns | 0.0039 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  0.9349 ns | 0.0058 ns | 0.0049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  1.1635 ns | 0.0059 ns | 0.0055 ns |  1.24 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  1.1697 ns | 0.0074 ns | 0.0058 ns |  1.25 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  1.2061 ns | 0.0056 ns | 0.0052 ns |  1.29 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  0.9943 ns | 0.0196 ns | 0.0183 ns |  1.06 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.5667 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.0088 ns | 0.0050 ns | 0.0042 ns |  1.28 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5576 ns | 0.0155 ns | 0.0137 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.3500 ns | 0.0055 ns | 0.0049 ns |  1.50 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  2.0725 ns | 0.0043 ns | 0.0040 ns |  1.32 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7623 ns | 0.0203 ns | 0.0180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4473 ns | 0.0110 ns | 0.0103 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2910 ns | 0.0078 ns | 0.0069 ns |  0.90 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.4474 ns | 0.0247 ns | 0.0231 ns |  1.14 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.4269 ns | 0.0397 ns | 0.0371 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.1685 ns | 0.0053 ns | 0.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.7666 ns | 0.0034 ns | 0.0030 ns |  1.51 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5516 ns | 0.0041 ns | 0.0034 ns |  1.33 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  1.7841 ns | 0.0033 ns | 0.0029 ns |  1.53 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  1.7710 ns | 0.0056 ns | 0.0047 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.4756 ns | 0.0074 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.6933 ns | 0.0098 ns | 0.0086 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2912 ns | 0.0063 ns | 0.0058 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.7186 ns | 0.0324 ns | 0.0303 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.7330 ns | 0.0206 ns | 0.0182 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5896 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.9481 ns | 0.0062 ns | 0.0058 ns |  1.23 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7341 ns | 0.0087 ns | 0.0077 ns |  1.09 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.1252 ns | 0.0066 ns | 0.0062 ns |  1.34 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8379 ns | 0.0208 ns | 0.0194 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.7098 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4489 ns | 0.0111 ns | 0.0104 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.5215 ns | 0.0082 ns | 0.0077 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3922 ns | 0.0077 ns | 0.0065 ns |  1.14 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3908 ns | 0.0089 ns | 0.0079 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1883 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4799 ns | 0.0063 ns | 0.0056 ns |  1.25 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2836 ns | 0.0042 ns | 0.0037 ns |  1.08 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  1.1855 ns | 0.0075 ns | 0.0067 ns |  1.00 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  0.9754 ns | 0.0053 ns | 0.0044 ns |  0.82 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2861 ns | 0.0170 ns | 0.0151 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4550 ns | 0.0145 ns | 0.0128 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0448 ns | 0.0092 ns | 0.0077 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4832 ns | 0.0382 ns | 0.0357 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4530 ns | 0.0113 ns | 0.0105 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6668 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.8455 ns | 0.0072 ns | 0.0060 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6427 ns | 0.0120 ns | 0.0112 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.1018 ns | 0.0055 ns | 0.0052 ns |  1.26 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.1073 ns | 0.0102 ns | 0.0095 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4836 ns | 0.0137 ns | 0.0128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4435 ns | 0.0102 ns | 0.0090 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.3127 ns | 0.0137 ns | 0.0115 ns |  0.96 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.1719 ns | 0.0210 ns | 0.0196 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.1879 ns | 0.0432 ns | 0.0404 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4756 ns | 0.0071 ns | 0.0059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6455 ns | 0.0107 ns | 0.0089 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4609 ns | 0.0170 ns | 0.0159 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.2162 ns | 0.0164 ns | 0.0154 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  0.9639 ns | 0.0061 ns | 0.0051 ns |  0.65 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9401 ns | 0.0069 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0779 ns | 0.0054 ns | 0.0048 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.2002 ns | 0.0489 ns | 0.0457 ns |  1.13 |    0.02 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.5425 ns | 0.0051 ns | 0.0048 ns |  1.31 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.3517 ns | 0.0058 ns | 0.0051 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.6493 ns | 0.0196 ns | 0.0174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6417 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2905 ns | 0.0053 ns | 0.0047 ns |  0.78 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  2.1264 ns | 0.0050 ns | 0.0042 ns |  1.29 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  1.8444 ns | 0.0028 ns | 0.0024 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1381 ns | 0.0066 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.0854 ns | 0.0176 ns | 0.0165 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1882 ns | 0.0388 ns | 0.0303 ns |  1.02 |    0.02 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.5859 ns | 0.0069 ns | 0.0061 ns |  1.68 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.5301 ns | 0.0271 ns | 0.0254 ns |  1.65 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4720 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4125 ns | 0.0047 ns | 0.0039 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4081 ns | 0.0048 ns | 0.0040 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.4198 ns | 0.0072 ns | 0.0064 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1401 ns | 0.0036 ns | 0.0031 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4783 ns | 0.0105 ns | 0.0098 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6739 ns | 0.0059 ns | 0.0052 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.5210 ns | 0.0086 ns | 0.0080 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.9300 ns | 0.0110 ns | 0.0097 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.9554 ns | 0.0418 ns | 0.0391 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4269 ns | 0.0141 ns | 0.0117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6182 ns | 0.0118 ns | 0.0110 ns |  1.13 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5093 ns | 0.0041 ns | 0.0036 ns |  1.06 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.4061 ns | 0.0180 ns | 0.0159 ns |  0.98 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.1555 ns | 0.0042 ns | 0.0037 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8115 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0764 ns | 0.0043 ns | 0.0034 ns |  1.15 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1882 ns | 0.0085 ns | 0.0075 ns |  1.21 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6956 ns | 0.0163 ns | 0.0152 ns |  1.49 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.6089 ns | 0.0232 ns | 0.0217 ns |  1.44 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.1049 ns | 0.0099 ns | 0.0087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0849 ns | 0.0167 ns | 0.0156 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.2868 ns | 0.1151 ns | 0.1077 ns |  1.03 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.3960 ns | 0.0262 ns | 0.0233 ns |  1.05 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.5700 ns | 0.0139 ns | 0.0130 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.5188 ns | 0.0368 ns | 0.0307 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.9022 ns | 0.0335 ns | 0.0313 ns |  1.02 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.7318 ns | 0.1390 ns | 0.1300 ns |  0.74 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.7498 ns | 0.0273 ns | 0.0228 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.7416 ns | 0.0423 ns | 0.0375 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1269 ns | 0.0312 ns | 0.0292 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1597 ns | 0.0063 ns | 0.0056 ns |  1.01 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3394 ns | 0.0048 ns | 0.0043 ns |  1.10 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.2031 ns | 0.0059 ns | 0.0050 ns |  0.56 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1990 ns | 0.0072 ns | 0.0064 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9988 ns | 0.0174 ns | 0.0163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3154 ns | 0.0128 ns | 0.0113 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0462 ns | 0.0197 ns | 0.0185 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.6434 ns | 0.0162 ns | 0.0144 ns |  1.08 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.6487 ns | 0.0358 ns | 0.0335 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8803 ns | 0.0299 ns | 0.0250 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.8124 ns | 0.0127 ns | 0.0113 ns |  1.24 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.8982 ns | 0.0269 ns | 0.0239 ns |  1.26 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.9184 ns | 0.0380 ns | 0.0337 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.8679 ns | 0.0310 ns | 0.0290 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.5477 ns | 0.0574 ns | 0.0479 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.8913 ns | 0.1050 ns | 0.0982 ns |  0.61 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.8786 ns | 0.0238 ns | 0.0186 ns |  0.47 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.3707 ns | 0.1267 ns | 0.1123 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.5086 ns | 0.1643 ns | 0.1537 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.8371 ns | 0.0239 ns | 0.0224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.6188 ns | 0.0513 ns | 0.0428 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5913 ns | 0.0268 ns | 0.0251 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.7030 ns | 0.0807 ns | 0.0715 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.4366 ns | 0.0345 ns | 0.0306 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.8134 ns | 0.0243 ns | 0.0227 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.9326 ns | 0.0292 ns | 0.0273 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2350 ns | 0.0647 ns | 0.0605 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.9849 ns | 0.0347 ns | 0.0324 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.0033 ns | 0.0339 ns | 0.0317 ns |  1.19 |    0.00 |      - |     - |     - |         - |
