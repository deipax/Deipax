
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.2545 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.7360 ns | 0.0068 ns | 0.0063 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.5959 ns | 0.0048 ns | 0.0040 ns |  1.27 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.0044 ns | 0.0121 ns | 0.0113 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  1.0003 ns | 0.0043 ns | 0.0040 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0199 ns | 0.0147 ns | 0.0138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2158 ns | 0.0128 ns | 0.0120 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0170 ns | 0.0317 ns | 0.0248 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2192 ns | 0.0221 ns | 0.0207 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2099 ns | 0.0151 ns | 0.0134 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.2930 ns | 0.0062 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5112 ns | 0.0037 ns | 0.0033 ns |  1.17 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4245 ns | 0.0038 ns | 0.0032 ns |  1.10 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9996 ns | 0.0060 ns | 0.0053 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.0039 ns | 0.0041 ns | 0.0036 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2573 ns | 0.0085 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2121 ns | 0.0073 ns | 0.0065 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9923 ns | 0.0092 ns | 0.0086 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4051 ns | 0.0044 ns | 0.0034 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4087 ns | 0.0153 ns | 0.0135 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2446 ns | 0.0102 ns | 0.0095 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.5693 ns | 0.0047 ns | 0.0044 ns |  1.26 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.3014 ns | 0.0037 ns | 0.0035 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.0013 ns | 0.0055 ns | 0.0051 ns |  0.80 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.0022 ns | 0.0059 ns | 0.0049 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2567 ns | 0.0125 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2449 ns | 0.0195 ns | 0.0182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9965 ns | 0.0172 ns | 0.0152 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4348 ns | 0.0300 ns | 0.0280 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4087 ns | 0.0100 ns | 0.0093 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.3113 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4781 ns | 0.0043 ns | 0.0036 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4455 ns | 0.0119 ns | 0.0111 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  1.0020 ns | 0.0060 ns | 0.0053 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  1.0069 ns | 0.0119 ns | 0.0111 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2495 ns | 0.0045 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2081 ns | 0.0100 ns | 0.0083 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0120 ns | 0.0295 ns | 0.0276 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4098 ns | 0.0076 ns | 0.0067 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4063 ns | 0.0091 ns | 0.0080 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.2509 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5749 ns | 0.0041 ns | 0.0038 ns |  1.26 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2992 ns | 0.0033 ns | 0.0031 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  1.1949 ns | 0.0028 ns | 0.0026 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.1836 ns | 0.0045 ns | 0.0040 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2556 ns | 0.0060 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2012 ns | 0.0063 ns | 0.0059 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0261 ns | 0.0125 ns | 0.0111 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4127 ns | 0.0094 ns | 0.0083 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4055 ns | 0.0101 ns | 0.0095 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.4367 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5536 ns | 0.0035 ns | 0.0031 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.2483 ns | 0.0043 ns | 0.0041 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.3617 ns | 0.0030 ns | 0.0027 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.0003 ns | 0.0015 ns | 0.0012 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2595 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2039 ns | 0.0049 ns | 0.0044 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0171 ns | 0.0254 ns | 0.0238 ns |  0.94 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4033 ns | 0.0079 ns | 0.0066 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4479 ns | 0.0187 ns | 0.0175 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.3958 ns | 0.0073 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7358 ns | 0.0093 ns | 0.0087 ns |  1.24 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4764 ns | 0.0032 ns | 0.0029 ns |  1.06 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  1.1937 ns | 0.0034 ns | 0.0032 ns |  0.86 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  1.1841 ns | 0.0034 ns | 0.0032 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  0.9565 ns | 0.0041 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  1.1901 ns | 0.0031 ns | 0.0029 ns |  1.24 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  1.1176 ns | 0.0034 ns | 0.0032 ns |  1.17 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  1.1399 ns | 0.0032 ns | 0.0030 ns |  1.19 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  1.1343 ns | 0.0030 ns | 0.0025 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4238 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4879 ns | 0.0116 ns | 0.0109 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4387 ns | 0.0043 ns | 0.0038 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.2234 ns | 0.0061 ns | 0.0054 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.2046 ns | 0.0032 ns | 0.0027 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4843 ns | 0.0078 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4415 ns | 0.0101 ns | 0.0095 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9907 ns | 0.0058 ns | 0.0054 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4066 ns | 0.0076 ns | 0.0071 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4129 ns | 0.0154 ns | 0.0144 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2662 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4923 ns | 0.0055 ns | 0.0049 ns |  1.18 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3041 ns | 0.0037 ns | 0.0035 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.0023 ns | 0.0054 ns | 0.0047 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0021 ns | 0.0035 ns | 0.0031 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1163 ns | 0.0048 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0401 ns | 0.0107 ns | 0.0095 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8805 ns | 0.0054 ns | 0.0048 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1039 ns | 0.0131 ns | 0.0122 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.0736 ns | 0.0056 ns | 0.0053 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4313 ns | 0.0101 ns | 0.0089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5177 ns | 0.0074 ns | 0.0070 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5264 ns | 0.0092 ns | 0.0086 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9775 ns | 0.0119 ns | 0.0111 ns |  0.68 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9847 ns | 0.0091 ns | 0.0085 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1143 ns | 0.0091 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2883 ns | 0.0046 ns | 0.0039 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1144 ns | 0.0039 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.0593 ns | 0.0041 ns | 0.0039 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.1811 ns | 0.0106 ns | 0.0094 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4166 ns | 0.0040 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4828 ns | 0.0034 ns | 0.0032 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4293 ns | 0.0062 ns | 0.0055 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1993 ns | 0.0039 ns | 0.0035 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1914 ns | 0.0045 ns | 0.0042 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2633 ns | 0.0113 ns | 0.0105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4468 ns | 0.0106 ns | 0.0099 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2097 ns | 0.0084 ns | 0.0079 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6401 ns | 0.0093 ns | 0.0087 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6352 ns | 0.0059 ns | 0.0050 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6621 ns | 0.0111 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6629 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5285 ns | 0.0044 ns | 0.0041 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.2231 ns | 0.0069 ns | 0.0061 ns |  0.74 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.2052 ns | 0.0059 ns | 0.0049 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1387 ns | 0.0179 ns | 0.0167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.1752 ns | 0.0049 ns | 0.0046 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0681 ns | 0.0049 ns | 0.0043 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1085 ns | 0.0166 ns | 0.0147 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1275 ns | 0.0171 ns | 0.0160 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3450 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.6412 ns | 0.0153 ns | 0.0136 ns |  1.13 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1166 ns | 0.0071 ns | 0.0063 ns |  0.90 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0437 ns | 0.0103 ns | 0.0091 ns |  2.58 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0442 ns | 0.0107 ns | 0.0101 ns |  2.58 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0735 ns | 0.0161 ns | 0.0134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7789 ns | 0.0217 ns | 0.0203 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.1401 ns | 0.0034 ns | 0.0031 ns |  0.21 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7204 ns | 0.0517 ns | 0.0458 ns |  1.06 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 12.3270 ns | 0.0180 ns | 0.0169 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3505 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3861 ns | 0.0062 ns | 0.0058 ns |  1.02 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1148 ns | 0.0091 ns | 0.0085 ns |  0.90 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1498 ns | 0.0124 ns | 0.0116 ns |  0.49 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1258 ns | 0.0054 ns | 0.0050 ns |  0.48 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2133 ns | 0.0211 ns | 0.0165 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2198 ns | 0.0186 ns | 0.0174 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9047 ns | 0.0064 ns | 0.0060 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4611 ns | 0.0224 ns | 0.0187 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.5542 ns | 0.0485 ns | 0.0453 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2673 ns | 0.0175 ns | 0.0163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4992 ns | 0.0047 ns | 0.0044 ns |  1.18 |    0.02 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.5641 ns | 0.0144 ns | 0.0135 ns |  1.23 |    0.02 |     - |     - |     - |         - |
           ToObject |        net461 |  1.0754 ns | 0.0084 ns | 0.0075 ns |  0.85 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9898 ns | 0.0061 ns | 0.0048 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4648 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  2.2566 ns | 0.0049 ns | 0.0043 ns |  1.54 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.5772 ns | 0.0054 ns | 0.0048 ns |  1.08 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.6512 ns | 0.0052 ns | 0.0049 ns |  1.13 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.4153 ns | 0.0051 ns | 0.0042 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.5257 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6619 ns | 0.0061 ns | 0.0057 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.7590 ns | 0.0059 ns | 0.0055 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2812 ns | 0.0048 ns | 0.0043 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2843 ns | 0.0150 ns | 0.0133 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2545 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4450 ns | 0.0086 ns | 0.0071 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  3.9896 ns | 0.0073 ns | 0.0065 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6376 ns | 0.0047 ns | 0.0044 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6313 ns | 0.0107 ns | 0.0100 ns |  1.09 |    0.00 |     - |     - |     - |         - |
