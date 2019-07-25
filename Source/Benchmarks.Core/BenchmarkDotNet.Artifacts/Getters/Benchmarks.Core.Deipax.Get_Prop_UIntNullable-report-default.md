
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
             ToBool | .NET Core 2.0 |  1.1856 ns | 0.0099 ns | 0.0087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4087 ns | 0.0042 ns | 0.0039 ns |  1.19 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.6337 ns | 0.0194 ns | 0.0181 ns |  1.38 |    0.02 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9815 ns | 0.0055 ns | 0.0052 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  1.1930 ns | 0.0039 ns | 0.0035 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2360 ns | 0.0105 ns | 0.0093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4930 ns | 0.0389 ns | 0.0364 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.4741 ns | 0.0177 ns | 0.0166 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.9133 ns | 0.0204 ns | 0.0191 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.9456 ns | 0.0276 ns | 0.0259 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7156 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.7255 ns | 0.0026 ns | 0.0024 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4603 ns | 0.0159 ns | 0.0149 ns |  0.85 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  2.2955 ns | 0.0074 ns | 0.0069 ns |  1.34 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.5847 ns | 0.0056 ns | 0.0046 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.4691 ns | 0.0111 ns | 0.0099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4403 ns | 0.0169 ns | 0.0141 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2378 ns | 0.0122 ns | 0.0114 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3661 ns | 0.0103 ns | 0.0096 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3634 ns | 0.0066 ns | 0.0058 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4414 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.7893 ns | 0.0025 ns | 0.0023 ns |  1.24 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.7309 ns | 0.0066 ns | 0.0055 ns |  1.20 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.2948 ns | 0.0088 ns | 0.0078 ns |  1.59 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.5710 ns | 0.0042 ns | 0.0037 ns |  1.78 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.6974 ns | 0.0090 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4414 ns | 0.0096 ns | 0.0080 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.5008 ns | 0.0283 ns | 0.0265 ns |  0.96 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3654 ns | 0.0088 ns | 0.0082 ns |  1.14 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3660 ns | 0.0081 ns | 0.0068 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6892 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6969 ns | 0.0082 ns | 0.0069 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5881 ns | 0.0049 ns | 0.0041 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.2916 ns | 0.0038 ns | 0.0032 ns |  1.36 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  2.5934 ns | 0.0171 ns | 0.0160 ns |  1.54 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4675 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4734 ns | 0.0094 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2475 ns | 0.0161 ns | 0.0151 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.4158 ns | 0.0082 ns | 0.0077 ns |  1.21 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3719 ns | 0.0064 ns | 0.0060 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.3605 ns | 0.0169 ns | 0.0132 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.8033 ns | 0.0067 ns | 0.0062 ns |  1.19 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.6805 ns | 0.0110 ns | 0.0103 ns |  1.14 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.0926 ns | 0.0090 ns | 0.0080 ns |  0.89 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  2.3552 ns | 0.0081 ns | 0.0072 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.1642 ns | 0.0079 ns | 0.0074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.1851 ns | 0.0212 ns | 0.0188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.7417 ns | 0.0098 ns | 0.0087 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3765 ns | 0.0162 ns | 0.0151 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3612 ns | 0.0074 ns | 0.0062 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.7158 ns | 0.0055 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.7820 ns | 0.0067 ns | 0.0059 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7404 ns | 0.0058 ns | 0.0052 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.2966 ns | 0.0040 ns | 0.0037 ns |  1.34 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.5869 ns | 0.0107 ns | 0.0100 ns |  1.51 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4664 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4803 ns | 0.0142 ns | 0.0126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2720 ns | 0.0207 ns | 0.0173 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3582 ns | 0.0077 ns | 0.0060 ns |  1.20 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.4185 ns | 0.0200 ns | 0.0187 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4284 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.6719 ns | 0.0159 ns | 0.0148 ns |  1.17 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.3969 ns | 0.0042 ns | 0.0037 ns |  0.98 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  2.0594 ns | 0.0029 ns | 0.0028 ns |  1.44 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  2.3409 ns | 0.0111 ns | 0.0104 ns |  1.64 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.4653 ns | 0.0060 ns | 0.0057 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4609 ns | 0.0121 ns | 0.0107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0044 ns | 0.0061 ns | 0.0054 ns |  0.90 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  5.1681 ns | 0.0410 ns | 0.0384 ns |  1.16 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  5.1347 ns | 0.0088 ns | 0.0069 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4234 ns | 0.0030 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6825 ns | 0.0097 ns | 0.0091 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5468 ns | 0.0175 ns | 0.0164 ns |  1.08 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.9146 ns | 0.0126 ns | 0.0118 ns |  1.34 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.8835 ns | 0.0043 ns | 0.0040 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  0.9493 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  1.1803 ns | 0.0089 ns | 0.0074 ns |  1.24 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  1.1231 ns | 0.0051 ns | 0.0047 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  1.1916 ns | 0.0057 ns | 0.0051 ns |  1.26 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  1.2103 ns | 0.0056 ns | 0.0049 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.2592 ns | 0.0081 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2521 ns | 0.0097 ns | 0.0086 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.2425 ns | 0.0034 ns | 0.0032 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1369 ns | 0.0032 ns | 0.0029 ns |  0.90 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  1.4245 ns | 0.0060 ns | 0.0053 ns |  1.13 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9833 ns | 0.0034 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8711 ns | 0.0062 ns | 0.0058 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9355 ns | 0.0070 ns | 0.0058 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1365 ns | 0.0048 ns | 0.0043 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2581 ns | 0.0053 ns | 0.0042 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.3929 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4044 ns | 0.0034 ns | 0.0030 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5140 ns | 0.0032 ns | 0.0030 ns |  1.09 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  1.1399 ns | 0.0040 ns | 0.0035 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.4474 ns | 0.0075 ns | 0.0070 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9444 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1279 ns | 0.0068 ns | 0.0061 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0748 ns | 0.0068 ns | 0.0064 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.3555 ns | 0.0181 ns | 0.0169 ns |  1.21 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.4863 ns | 0.0141 ns | 0.0132 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.8293 ns | 0.0039 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.7264 ns | 0.0124 ns | 0.0116 ns |  0.94 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6978 ns | 0.0046 ns | 0.0038 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.0384 ns | 0.0046 ns | 0.0043 ns |  0.57 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1523 ns | 0.0059 ns | 0.0055 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.9833 ns | 0.0364 ns | 0.0341 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  5.1427 ns | 0.0075 ns | 0.0067 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.6983 ns | 0.0075 ns | 0.0070 ns |  0.94 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.1366 ns | 0.0163 ns | 0.0136 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.1801 ns | 0.0257 ns | 0.0240 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4153 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4920 ns | 0.0064 ns | 0.0060 ns |  1.05 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3560 ns | 0.0047 ns | 0.0041 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.0095 ns | 0.0036 ns | 0.0034 ns |  0.71 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.1497 ns | 0.0061 ns | 0.0057 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6846 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0980 ns | 0.0074 ns | 0.0065 ns |  1.25 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8174 ns | 0.0068 ns | 0.0064 ns |  1.08 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5856 ns | 0.0110 ns | 0.0097 ns |  1.53 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5823 ns | 0.0062 ns | 0.0058 ns |  1.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8479 ns | 0.0059 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8527 ns | 0.0181 ns | 0.0170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0688 ns | 0.0066 ns | 0.0059 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.3653 ns | 0.0305 ns | 0.0285 ns |  1.09 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.3178 ns | 0.0157 ns | 0.0139 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.8855 ns | 0.0369 ns | 0.0346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.1686 ns | 0.0283 ns | 0.0265 ns |  0.96 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.1881 ns | 0.2657 ns | 0.2485 ns |  0.70 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.8462 ns | 0.0369 ns | 0.0327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.8212 ns | 0.0332 ns | 0.0294 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1218 ns | 0.0206 ns | 0.0193 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3610 ns | 0.0118 ns | 0.0104 ns |  1.11 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1286 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1920 ns | 0.0042 ns | 0.0035 ns |  0.56 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1823 ns | 0.0045 ns | 0.0038 ns |  0.56 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9709 ns | 0.0123 ns | 0.0115 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5732 ns | 0.0312 ns | 0.0277 ns |  1.08 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0734 ns | 0.0029 ns | 0.0025 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2754 ns | 0.0253 ns | 0.0224 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4739 ns | 0.0124 ns | 0.0116 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8991 ns | 0.0151 ns | 0.0134 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.6036 ns | 0.0126 ns | 0.0118 ns |  1.18 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5939 ns | 0.0275 ns | 0.0257 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8132 ns | 0.0185 ns | 0.0164 ns |  0.98 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.8478 ns | 0.0100 ns | 0.0093 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.9198 ns | 0.0597 ns | 0.0558 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.5162 ns | 0.1211 ns | 0.1132 ns |  0.65 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.6059 ns | 0.0129 ns | 0.0114 ns |  0.47 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.2816 ns | 0.0860 ns | 0.0804 ns |  1.16 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.5114 ns | 0.1333 ns | 0.1247 ns |  1.17 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.7803 ns | 0.0162 ns | 0.0144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4585 ns | 0.0191 ns | 0.0179 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3346 ns | 0.0451 ns | 0.0421 ns |  0.65 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.6918 ns | 0.0421 ns | 0.0394 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.6043 ns | 0.0743 ns | 0.0659 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.8506 ns | 0.0235 ns | 0.0208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 17.2043 ns | 0.0949 ns | 0.0841 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.9351 ns | 0.0191 ns | 0.0179 ns |  0.77 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.2471 ns | 0.1038 ns | 0.0971 ns |  1.20 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.3205 ns | 0.0257 ns | 0.0241 ns |  1.21 |    0.00 |      - |     - |     - |         - |
