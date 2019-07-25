
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
             ToBool | .NET Core 2.0 |  1.1785 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  0.9606 ns | 0.0055 ns | 0.0052 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9649 ns | 0.0031 ns | 0.0029 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4440 ns | 0.0065 ns | 0.0060 ns |  0.38 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7388 ns | 0.0032 ns | 0.0030 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9946 ns | 0.0147 ns | 0.0131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1966 ns | 0.0255 ns | 0.0226 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0363 ns | 0.0093 ns | 0.0082 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1946 ns | 0.0077 ns | 0.0072 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2184 ns | 0.0119 ns | 0.0099 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.5375 ns | 0.0136 ns | 0.0127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1636 ns | 0.0047 ns | 0.0041 ns |  0.76 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0187 ns | 0.0058 ns | 0.0048 ns |  0.66 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  1.4221 ns | 0.0047 ns | 0.0039 ns |  0.93 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  1.3869 ns | 0.0097 ns | 0.0086 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9913 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1677 ns | 0.0093 ns | 0.0087 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0330 ns | 0.0100 ns | 0.0094 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8912 ns | 0.0072 ns | 0.0067 ns |  1.23 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.9154 ns | 0.0111 ns | 0.0087 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.1746 ns | 0.0064 ns | 0.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.0527 ns | 0.0089 ns | 0.0083 ns |  0.94 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.1262 ns | 0.0011 ns | 0.0009 ns |  0.98 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6182 ns | 0.0102 ns | 0.0096 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6100 ns | 0.0021 ns | 0.0019 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.7177 ns | 0.0270 ns | 0.0253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.8799 ns | 0.0379 ns | 0.0355 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.7633 ns | 0.0231 ns | 0.0205 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8924 ns | 0.0080 ns | 0.0071 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.9506 ns | 0.0251 ns | 0.0235 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.4678 ns | 0.0231 ns | 0.0205 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.1547 ns | 0.0185 ns | 0.0154 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.2777 ns | 0.0110 ns | 0.0103 ns |  0.92 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6019 ns | 0.0058 ns | 0.0046 ns |  0.65 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6012 ns | 0.0034 ns | 0.0030 ns |  0.65 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7022 ns | 0.0196 ns | 0.0163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.8548 ns | 0.0058 ns | 0.0051 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7708 ns | 0.0252 ns | 0.0236 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8924 ns | 0.0099 ns | 0.0093 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.9588 ns | 0.0162 ns | 0.0151 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.1799 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  0.9169 ns | 0.0101 ns | 0.0095 ns |  0.78 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  0.9672 ns | 0.0070 ns | 0.0062 ns |  0.82 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  0.4358 ns | 0.0132 ns | 0.0124 ns |  0.37 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  0.4423 ns | 0.0018 ns | 0.0015 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0213 ns | 0.0169 ns | 0.0158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.3923 ns | 0.0124 ns | 0.0116 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2831 ns | 0.0282 ns | 0.0250 ns |  1.07 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.1955 ns | 0.0079 ns | 0.0074 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.2416 ns | 0.0287 ns | 0.0268 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6496 ns | 0.0067 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.3510 ns | 0.0081 ns | 0.0071 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.0167 ns | 0.0053 ns | 0.0050 ns |  0.62 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.3917 ns | 0.0229 ns | 0.0214 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.3684 ns | 0.0033 ns | 0.0031 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0169 ns | 0.0245 ns | 0.0217 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1552 ns | 0.0116 ns | 0.0103 ns |  1.03 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0319 ns | 0.0113 ns | 0.0100 ns |  1.00 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.9350 ns | 0.0107 ns | 0.0095 ns |  1.23 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.9072 ns | 0.0078 ns | 0.0069 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1842 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  0.8881 ns | 0.0031 ns | 0.0028 ns |  0.75 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9626 ns | 0.0129 ns | 0.0120 ns |  0.81 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4500 ns | 0.0150 ns | 0.0141 ns |  0.38 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  0.4379 ns | 0.0033 ns | 0.0028 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9951 ns | 0.0107 ns | 0.0089 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1966 ns | 0.0274 ns | 0.0243 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0355 ns | 0.0055 ns | 0.0049 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1954 ns | 0.0073 ns | 0.0069 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.2190 ns | 0.0250 ns | 0.0222 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6883 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.1828 ns | 0.0051 ns | 0.0047 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.0198 ns | 0.0238 ns | 0.0222 ns |  0.60 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6077 ns | 0.0033 ns | 0.0031 ns |  0.95 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.4699 ns | 0.0045 ns | 0.0038 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9911 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1691 ns | 0.0309 ns | 0.0289 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.8085 ns | 0.0123 ns | 0.0109 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.7040 ns | 0.0058 ns | 0.0054 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6767 ns | 0.0097 ns | 0.0091 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.1049 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.9051 ns | 0.0099 ns | 0.0088 ns |  0.82 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9646 ns | 0.0049 ns | 0.0046 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4389 ns | 0.0046 ns | 0.0041 ns |  0.40 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4477 ns | 0.0025 ns | 0.0022 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.5983 ns | 0.0170 ns | 0.0159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.6808 ns | 0.0058 ns | 0.0054 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8231 ns | 0.0556 ns | 0.0520 ns |  1.14 |    0.04 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.6486 ns | 0.0042 ns | 0.0037 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8989 ns | 0.0051 ns | 0.0045 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.5906 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.3455 ns | 0.0054 ns | 0.0051 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.0168 ns | 0.0046 ns | 0.0043 ns |  0.64 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.6062 ns | 0.0058 ns | 0.0054 ns |  1.01 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  1.6099 ns | 0.0099 ns | 0.0088 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0656 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.6299 ns | 0.0059 ns | 0.0052 ns |  0.79 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6631 ns | 0.0062 ns | 0.0048 ns |  0.80 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.9553 ns | 0.0317 ns | 0.0297 ns |  1.43 |    0.02 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.0602 ns | 0.0151 ns | 0.0126 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1226 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1075 ns | 0.0054 ns | 0.0050 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1386 ns | 0.0049 ns | 0.0046 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4466 ns | 0.0052 ns | 0.0049 ns |  0.40 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4350 ns | 0.0034 ns | 0.0032 ns |  0.39 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2238 ns | 0.0071 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3966 ns | 0.0112 ns | 0.0099 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2663 ns | 0.0054 ns | 0.0048 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4729 ns | 0.0058 ns | 0.0054 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4673 ns | 0.0326 ns | 0.0305 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3399 ns | 0.0050 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1053 ns | 0.0043 ns | 0.0040 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1435 ns | 0.0108 ns | 0.0101 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4534 ns | 0.0118 ns | 0.0111 ns |  0.34 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4366 ns | 0.0021 ns | 0.0018 ns |  0.33 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8049 ns | 0.0091 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.5019 ns | 0.0058 ns | 0.0051 ns |  0.83 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.6632 ns | 0.0042 ns | 0.0037 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.4725 ns | 0.0050 ns | 0.0044 ns |  0.82 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6498 ns | 0.0052 ns | 0.0046 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0711 ns | 0.0106 ns | 0.0099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.7873 ns | 0.0059 ns | 0.0055 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.9205 ns | 0.0346 ns | 0.0323 ns |  0.98 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8217 ns | 0.0126 ns | 0.0098 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8411 ns | 0.0070 ns | 0.0066 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.6598 ns | 0.0335 ns | 0.0313 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.7762 ns | 0.0721 ns | 0.0675 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.7160 ns | 0.1209 ns | 0.1131 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.6309 ns | 0.0410 ns | 0.0384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.6564 ns | 0.0347 ns | 0.0290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2850 ns | 0.0065 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  1.9871 ns | 0.0065 ns | 0.0058 ns |  0.87 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1274 ns | 0.0060 ns | 0.0047 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9249 ns | 0.0135 ns | 0.0127 ns |  0.40 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1973 ns | 0.0045 ns | 0.0038 ns |  0.52 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9619 ns | 0.0232 ns | 0.0206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1882 ns | 0.0085 ns | 0.0071 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9469 ns | 0.0060 ns | 0.0053 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.9825 ns | 0.0125 ns | 0.0111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4067 ns | 0.0280 ns | 0.0262 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.3411 ns | 0.0271 ns | 0.0240 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7717 ns | 0.0110 ns | 0.0097 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8558 ns | 0.0244 ns | 0.0228 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.9572 ns | 0.0186 ns | 0.0174 ns |  0.89 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7570 ns | 0.0126 ns | 0.0105 ns |  0.83 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.8751 ns | 0.1394 ns | 0.1304 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.4815 ns | 0.0550 ns | 0.0488 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.6785 ns | 0.0299 ns | 0.0249 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.1325 ns | 0.1715 ns | 0.1605 ns |  1.04 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.7967 ns | 0.1730 ns | 0.1619 ns |  1.03 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  9.9045 ns | 0.0153 ns | 0.0128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.3988 ns | 0.0651 ns | 0.0609 ns |  1.05 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.4065 ns | 0.0187 ns | 0.0165 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.4173 ns | 0.0225 ns | 0.0211 ns |  1.25 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.3622 ns | 0.0400 ns | 0.0374 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.5327 ns | 0.0239 ns | 0.0200 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.0321 ns | 0.0312 ns | 0.0292 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.7956 ns | 0.0220 ns | 0.0195 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.1029 ns | 0.1207 ns | 0.1129 ns |  1.18 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.0200 ns | 0.0516 ns | 0.0483 ns |  1.17 |    0.00 |      - |     - |     - |         - |
