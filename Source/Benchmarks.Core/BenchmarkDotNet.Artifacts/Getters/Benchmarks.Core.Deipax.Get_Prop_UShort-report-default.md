
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
             ToBool | .NET Core 2.0 |  0.9494 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1937 ns | 0.0039 ns | 0.0034 ns |  1.26 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9381 ns | 0.0067 ns | 0.0056 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4408 ns | 0.0040 ns | 0.0034 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4348 ns | 0.0024 ns | 0.0021 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0360 ns | 0.0100 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2218 ns | 0.0099 ns | 0.0082 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0087 ns | 0.0069 ns | 0.0065 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1944 ns | 0.0088 ns | 0.0069 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1952 ns | 0.0258 ns | 0.0241 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  0.9342 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2179 ns | 0.0051 ns | 0.0040 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  0.9313 ns | 0.0057 ns | 0.0053 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4389 ns | 0.0043 ns | 0.0040 ns |  0.47 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.4363 ns | 0.0034 ns | 0.0032 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0593 ns | 0.0201 ns | 0.0188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2328 ns | 0.0196 ns | 0.0183 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0167 ns | 0.0130 ns | 0.0121 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1887 ns | 0.0077 ns | 0.0064 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2038 ns | 0.0329 ns | 0.0308 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2371 ns | 0.0050 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6617 ns | 0.0048 ns | 0.0045 ns |  1.34 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4138 ns | 0.0051 ns | 0.0048 ns |  1.14 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.3810 ns | 0.0043 ns | 0.0040 ns |  1.12 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3955 ns | 0.0027 ns | 0.0025 ns |  1.13 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.0384 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2228 ns | 0.0136 ns | 0.0120 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0036 ns | 0.0070 ns | 0.0062 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8882 ns | 0.0059 ns | 0.0055 ns |  1.21 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8803 ns | 0.0063 ns | 0.0056 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.5343 ns | 0.0054 ns | 0.0047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6645 ns | 0.0065 ns | 0.0060 ns |  1.08 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  0.9743 ns | 0.0050 ns | 0.0044 ns |  0.64 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6376 ns | 0.0590 ns | 0.0767 ns |  1.06 |    0.05 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3678 ns | 0.0048 ns | 0.0037 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.0683 ns | 0.0178 ns | 0.0167 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2265 ns | 0.0066 ns | 0.0062 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0064 ns | 0.0086 ns | 0.0076 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8875 ns | 0.0088 ns | 0.0082 ns |  1.20 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8865 ns | 0.0081 ns | 0.0075 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.2603 ns | 0.0044 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4860 ns | 0.0057 ns | 0.0048 ns |  1.18 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.1383 ns | 0.0040 ns | 0.0036 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6177 ns | 0.0124 ns | 0.0116 ns |  1.28 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  1.6074 ns | 0.0073 ns | 0.0061 ns |  1.28 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0591 ns | 0.0250 ns | 0.0234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2229 ns | 0.0085 ns | 0.0071 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0377 ns | 0.0285 ns | 0.0266 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8900 ns | 0.0057 ns | 0.0053 ns |  1.20 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.8842 ns | 0.0103 ns | 0.0096 ns |  1.20 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  0.9344 ns | 0.0026 ns | 0.0022 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2712 ns | 0.0121 ns | 0.0107 ns |  1.36 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.1166 ns | 0.0049 ns | 0.0044 ns |  1.19 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.4350 ns | 0.0012 ns | 0.0011 ns |  0.47 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.4363 ns | 0.0031 ns | 0.0028 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0381 ns | 0.0086 ns | 0.0080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4539 ns | 0.0078 ns | 0.0061 ns |  1.10 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.2421 ns | 0.0090 ns | 0.0079 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.1873 ns | 0.0097 ns | 0.0076 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.2331 ns | 0.0222 ns | 0.0207 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  0.9350 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1951 ns | 0.0048 ns | 0.0043 ns |  1.28 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.1175 ns | 0.0049 ns | 0.0044 ns |  1.19 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4384 ns | 0.0059 ns | 0.0053 ns |  0.47 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  1.0216 ns | 0.0022 ns | 0.0019 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0423 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2196 ns | 0.0053 ns | 0.0047 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0189 ns | 0.0223 ns | 0.0198 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.2363 ns | 0.0073 ns | 0.0064 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.1903 ns | 0.0298 ns | 0.0279 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.2802 ns | 0.0030 ns | 0.0026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.1978 ns | 0.0059 ns | 0.0055 ns |  0.94 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.1394 ns | 0.0030 ns | 0.0023 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.4390 ns | 0.0019 ns | 0.0017 ns |  0.34 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.4373 ns | 0.0027 ns | 0.0025 ns |  0.34 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0702 ns | 0.0215 ns | 0.0201 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2629 ns | 0.0149 ns | 0.0132 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9902 ns | 0.0066 ns | 0.0061 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1980 ns | 0.0115 ns | 0.0096 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1868 ns | 0.0097 ns | 0.0091 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  0.9648 ns | 0.0042 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2004 ns | 0.0086 ns | 0.0081 ns |  1.24 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9226 ns | 0.0047 ns | 0.0041 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4408 ns | 0.0047 ns | 0.0041 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4385 ns | 0.0068 ns | 0.0063 ns |  0.45 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6593 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7476 ns | 0.0043 ns | 0.0038 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8558 ns | 0.0153 ns | 0.0144 ns |  1.12 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.5250 ns | 0.0030 ns | 0.0027 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.5267 ns | 0.0056 ns | 0.0053 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  0.9654 ns | 0.0071 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2210 ns | 0.0084 ns | 0.0079 ns |  1.27 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1175 ns | 0.0028 ns | 0.0024 ns |  1.16 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  0.4412 ns | 0.0030 ns | 0.0027 ns |  0.46 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.6039 ns | 0.0058 ns | 0.0051 ns |  0.63 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6620 ns | 0.0084 ns | 0.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.7258 ns | 0.0092 ns | 0.0086 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.8419 ns | 0.0143 ns | 0.0134 ns |  1.11 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5241 ns | 0.0096 ns | 0.0080 ns |  0.92 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.5146 ns | 0.0251 ns | 0.0235 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1876 ns | 0.0055 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.2208 ns | 0.0046 ns | 0.0038 ns |  1.03 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1476 ns | 0.0045 ns | 0.0035 ns |  0.97 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4389 ns | 0.0030 ns | 0.0027 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4370 ns | 0.0022 ns | 0.0020 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2723 ns | 0.0087 ns | 0.0081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4569 ns | 0.0117 ns | 0.0104 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2388 ns | 0.0085 ns | 0.0075 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4252 ns | 0.0081 ns | 0.0068 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4376 ns | 0.0398 ns | 0.0372 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4416 ns | 0.0099 ns | 0.0092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2226 ns | 0.0046 ns | 0.0041 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1609 ns | 0.0100 ns | 0.0089 ns |  0.81 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4421 ns | 0.0087 ns | 0.0082 ns |  0.31 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4338 ns | 0.0041 ns | 0.0036 ns |  0.30 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8969 ns | 0.0041 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6937 ns | 0.0061 ns | 0.0051 ns |  0.89 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.7807 ns | 0.0056 ns | 0.0050 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.4213 ns | 0.0061 ns | 0.0054 ns |  0.75 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.4142 ns | 0.0044 ns | 0.0039 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8833 ns | 0.0129 ns | 0.0114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8611 ns | 0.0133 ns | 0.0118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8549 ns | 0.0122 ns | 0.0101 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8242 ns | 0.0145 ns | 0.0128 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8294 ns | 0.0390 ns | 0.0365 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.7126 ns | 0.0454 ns | 0.0425 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.4328 ns | 0.0648 ns | 0.0606 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.6132 ns | 0.0136 ns | 0.0114 ns |  0.67 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.2801 ns | 0.0338 ns | 0.0316 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.2422 ns | 0.0316 ns | 0.0296 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1272 ns | 0.0024 ns | 0.0021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3891 ns | 0.0066 ns | 0.0058 ns |  1.12 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.2854 ns | 0.0086 ns | 0.0081 ns |  1.07 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9271 ns | 0.0163 ns | 0.0152 ns |  0.44 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  0.9148 ns | 0.0062 ns | 0.0055 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3549 ns | 0.0516 ns | 0.0483 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.0094 ns | 0.0193 ns | 0.0171 ns |  0.96 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9175 ns | 0.0059 ns | 0.0049 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1834 ns | 0.0209 ns | 0.0185 ns |  0.98 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2685 ns | 0.0565 ns | 0.0472 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.3439 ns | 0.0407 ns | 0.0381 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7336 ns | 0.0134 ns | 0.0125 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8322 ns | 0.0300 ns | 0.0281 ns |  1.15 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7538 ns | 0.0125 ns | 0.0117 ns |  0.82 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7373 ns | 0.0137 ns | 0.0128 ns |  0.82 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.9011 ns | 0.1677 ns | 0.1569 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.1383 ns | 0.0911 ns | 0.0852 ns |  0.64 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.2145 ns | 0.0460 ns | 0.0430 ns |  0.45 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.0276 ns | 0.1516 ns | 0.1344 ns |  1.15 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.6150 ns | 0.0778 ns | 0.0650 ns |  1.14 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.2663 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.4284 ns | 0.0547 ns | 0.0511 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3970 ns | 0.0055 ns | 0.0043 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.3174 ns | 0.0258 ns | 0.0241 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.5185 ns | 0.0238 ns | 0.0223 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.7013 ns | 0.0152 ns | 0.0127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.0401 ns | 0.0175 ns | 0.0147 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.7588 ns | 0.0150 ns | 0.0140 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.9931 ns | 0.1321 ns | 0.1236 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.9596 ns | 0.0714 ns | 0.0668 ns |  1.15 |    0.00 |      - |     - |     - |         - |
