
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
             ToBool | .NET Core 2.0 |  1.2290 ns | 0.0065 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4946 ns | 0.0074 ns | 0.0065 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2495 ns | 0.0120 ns | 0.0112 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.6938 ns | 0.0055 ns | 0.0052 ns |  0.56 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9441 ns | 0.0043 ns | 0.0038 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.2570 ns | 0.0089 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4323 ns | 0.0070 ns | 0.0066 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2674 ns | 0.0132 ns | 0.0124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.4402 ns | 0.0089 ns | 0.0079 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.4397 ns | 0.0106 ns | 0.0099 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  0.9391 ns | 0.0085 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1871 ns | 0.0098 ns | 0.0082 ns |  1.27 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0433 ns | 0.0060 ns | 0.0053 ns |  1.11 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.6831 ns | 0.0089 ns | 0.0074 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9547 ns | 0.0047 ns | 0.0044 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0322 ns | 0.0091 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4339 ns | 0.0092 ns | 0.0086 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2351 ns | 0.0117 ns | 0.0098 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4501 ns | 0.0120 ns | 0.0113 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4808 ns | 0.0079 ns | 0.0070 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2118 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4554 ns | 0.0065 ns | 0.0061 ns |  1.20 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2355 ns | 0.0064 ns | 0.0057 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9098 ns | 0.0124 ns | 0.0110 ns |  0.75 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.1753 ns | 0.0059 ns | 0.0052 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.4949 ns | 0.0063 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4387 ns | 0.0086 ns | 0.0076 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.2334 ns | 0.0073 ns | 0.0065 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.6763 ns | 0.0105 ns | 0.0098 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.7013 ns | 0.0414 ns | 0.0387 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.4241 ns | 0.0050 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4929 ns | 0.0051 ns | 0.0048 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.2807 ns | 0.0072 ns | 0.0067 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.7216 ns | 0.0079 ns | 0.0070 ns |  0.51 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9229 ns | 0.0078 ns | 0.0073 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.4932 ns | 0.0096 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4759 ns | 0.0254 ns | 0.0225 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.2409 ns | 0.0127 ns | 0.0119 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6809 ns | 0.0109 ns | 0.0102 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6706 ns | 0.0117 ns | 0.0098 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.2275 ns | 0.0052 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4505 ns | 0.0045 ns | 0.0035 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.2496 ns | 0.0138 ns | 0.0129 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.7008 ns | 0.0055 ns | 0.0051 ns |  0.57 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9475 ns | 0.0058 ns | 0.0055 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.5034 ns | 0.0317 ns | 0.0297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4345 ns | 0.0166 ns | 0.0155 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2412 ns | 0.0207 ns | 0.0183 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.7129 ns | 0.0072 ns | 0.0067 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.6838 ns | 0.0285 ns | 0.0266 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.4008 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6197 ns | 0.0039 ns | 0.0033 ns |  1.16 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3157 ns | 0.0097 ns | 0.0091 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.6957 ns | 0.0048 ns | 0.0043 ns |  0.50 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9522 ns | 0.0086 ns | 0.0081 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.4905 ns | 0.0090 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4326 ns | 0.0118 ns | 0.0098 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2510 ns | 0.0259 ns | 0.0243 ns |  0.95 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6721 ns | 0.0077 ns | 0.0068 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6711 ns | 0.0075 ns | 0.0070 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.2130 ns | 0.0104 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7461 ns | 0.0031 ns | 0.0026 ns |  1.44 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.5065 ns | 0.0129 ns | 0.0121 ns |  1.24 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9093 ns | 0.0040 ns | 0.0035 ns |  0.75 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.1910 ns | 0.0064 ns | 0.0056 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.5036 ns | 0.0195 ns | 0.0173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4385 ns | 0.0204 ns | 0.0181 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.2359 ns | 0.0126 ns | 0.0112 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6758 ns | 0.0088 ns | 0.0078 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6764 ns | 0.0113 ns | 0.0106 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4235 ns | 0.0056 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6275 ns | 0.0051 ns | 0.0040 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.3351 ns | 0.0064 ns | 0.0050 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9114 ns | 0.0075 ns | 0.0062 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.1758 ns | 0.0061 ns | 0.0057 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.5304 ns | 0.0152 ns | 0.0143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4289 ns | 0.0077 ns | 0.0072 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2339 ns | 0.0144 ns | 0.0128 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6763 ns | 0.0076 ns | 0.0071 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.5260 ns | 0.0101 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2353 ns | 0.0051 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6383 ns | 0.0058 ns | 0.0051 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3966 ns | 0.0071 ns | 0.0063 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9120 ns | 0.0041 ns | 0.0037 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.2210 ns | 0.0140 ns | 0.0124 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.3495 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.1125 ns | 0.0063 ns | 0.0059 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9140 ns | 0.0098 ns | 0.0082 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1343 ns | 0.0080 ns | 0.0071 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2681 ns | 0.0045 ns | 0.0040 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4287 ns | 0.0109 ns | 0.0097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4501 ns | 0.0056 ns | 0.0047 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.3986 ns | 0.0056 ns | 0.0050 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.7090 ns | 0.0064 ns | 0.0060 ns |  0.50 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9571 ns | 0.0158 ns | 0.0148 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9390 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3037 ns | 0.0082 ns | 0.0073 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9150 ns | 0.0040 ns | 0.0034 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.1360 ns | 0.0040 ns | 0.0035 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.2868 ns | 0.0054 ns | 0.0048 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6680 ns | 0.0228 ns | 0.0213 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6347 ns | 0.0030 ns | 0.0025 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2162 ns | 0.0054 ns | 0.0050 ns |  0.73 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9661 ns | 0.0039 ns | 0.0031 ns |  0.58 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1812 ns | 0.0157 ns | 0.0147 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  1.1913 ns | 0.0088 ns | 0.0083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  1.1593 ns | 0.0033 ns | 0.0029 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  0.9602 ns | 0.0073 ns | 0.0064 ns |  0.81 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  1.1677 ns | 0.0038 ns | 0.0032 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  1.2304 ns | 0.0084 ns | 0.0079 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6646 ns | 0.0066 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6071 ns | 0.0069 ns | 0.0058 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2579 ns | 0.0059 ns | 0.0055 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9124 ns | 0.0069 ns | 0.0064 ns |  0.55 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.1550 ns | 0.0138 ns | 0.0129 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1284 ns | 0.0048 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8465 ns | 0.0050 ns | 0.0045 ns |  0.87 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7587 ns | 0.0137 ns | 0.0121 ns |  0.83 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6169 ns | 0.0062 ns | 0.0055 ns |  1.23 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5519 ns | 0.0075 ns | 0.0067 ns |  1.20 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.1722 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1285 ns | 0.0057 ns | 0.0053 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1485 ns | 0.0061 ns | 0.0054 ns |  0.99 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0807 ns | 0.0121 ns | 0.0101 ns |  2.80 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.1128 ns | 0.0426 ns | 0.0398 ns |  2.81 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0903 ns | 0.0172 ns | 0.0161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7250 ns | 0.0434 ns | 0.0406 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3879 ns | 0.0176 ns | 0.0165 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7363 ns | 0.0248 ns | 0.0220 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.8697 ns | 0.0173 ns | 0.0161 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3736 ns | 0.0211 ns | 0.0198 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1112 ns | 0.0064 ns | 0.0053 ns |  0.89 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.0564 ns | 0.0041 ns | 0.0034 ns |  0.87 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.4320 ns | 0.0051 ns | 0.0045 ns |  0.60 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.4469 ns | 0.0174 ns | 0.0163 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3057 ns | 0.0232 ns | 0.0206 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5239 ns | 0.0303 ns | 0.0284 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9141 ns | 0.0043 ns | 0.0036 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4139 ns | 0.0181 ns | 0.0151 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4212 ns | 0.0171 ns | 0.0152 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2713 ns | 0.0134 ns | 0.0119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4378 ns | 0.0046 ns | 0.0043 ns |  1.13 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.6288 ns | 0.0047 ns | 0.0039 ns |  1.28 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9662 ns | 0.0044 ns | 0.0037 ns |  0.76 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9869 ns | 0.0133 ns | 0.0111 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4316 ns | 0.0125 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.8491 ns | 0.0077 ns | 0.0069 ns |  1.29 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.2370 ns | 0.0108 ns | 0.0101 ns |  0.86 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.1947 ns | 0.0062 ns | 0.0058 ns |  0.83 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.4128 ns | 0.0033 ns | 0.0028 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4238 ns | 0.0064 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6131 ns | 0.0062 ns | 0.0058 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.4226 ns | 0.0052 ns | 0.0049 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.1939 ns | 0.0038 ns | 0.0035 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2109 ns | 0.0047 ns | 0.0044 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.5344 ns | 0.0184 ns | 0.0172 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.6673 ns | 0.0151 ns | 0.0141 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.2539 ns | 0.0380 ns | 0.0355 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.9105 ns | 0.0165 ns | 0.0154 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.9443 ns | 0.0377 ns | 0.0352 ns |  1.09 |    0.01 |     - |     - |     - |         - |
