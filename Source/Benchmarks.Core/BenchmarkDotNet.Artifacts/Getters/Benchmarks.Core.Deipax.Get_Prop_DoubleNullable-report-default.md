
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
             ToBool | .NET Core 2.0 |   1.4760 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.3123 ns | 0.0047 ns | 0.0041 ns |  0.89 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.4425 ns | 0.0099 ns | 0.0093 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   1.4277 ns | 0.0067 ns | 0.0060 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   1.4178 ns | 0.0067 ns | 0.0062 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.9717 ns | 0.0073 ns | 0.0068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   5.0772 ns | 0.0067 ns | 0.0059 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.7201 ns | 0.0107 ns | 0.0094 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   5.1221 ns | 0.0291 ns | 0.0243 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   5.0954 ns | 0.0101 ns | 0.0090 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.2060 ns | 0.0045 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.1146 ns | 0.0060 ns | 0.0056 ns |  0.92 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.4215 ns | 0.0271 ns | 0.0254 ns |  1.18 |    0.02 |      - |     - |     - |         - |
             ToChar |        net461 |   0.7205 ns | 0.0038 ns | 0.0035 ns |  0.60 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |   0.7163 ns | 0.0028 ns | 0.0026 ns |  0.59 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.0382 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.3875 ns | 0.0096 ns | 0.0090 ns |  1.09 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.2595 ns | 0.0129 ns | 0.0121 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.4114 ns | 0.0126 ns | 0.0118 ns |  1.09 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.4058 ns | 0.0088 ns | 0.0082 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.5249 ns | 0.0076 ns | 0.0067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.6912 ns | 0.0580 ns | 0.0543 ns |  1.04 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   5.1099 ns | 0.0130 ns | 0.0122 ns |  1.13 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.9081 ns | 0.0150 ns | 0.0133 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   4.1630 ns | 0.0225 ns | 0.0211 ns |  0.92 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   7.0651 ns | 0.0175 ns | 0.0164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.9432 ns | 0.0116 ns | 0.0103 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   7.0445 ns | 0.0162 ns | 0.0144 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   7.2059 ns | 0.0122 ns | 0.0102 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   7.2209 ns | 0.0328 ns | 0.0291 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.3293 ns | 0.0114 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   4.9401 ns | 0.0113 ns | 0.0106 ns |  1.14 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   4.8869 ns | 0.0137 ns | 0.0128 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |   3.9053 ns | 0.0225 ns | 0.0211 ns |  0.90 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   3.9357 ns | 0.0101 ns | 0.0089 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   7.1324 ns | 0.0485 ns | 0.0405 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.9506 ns | 0.0223 ns | 0.0209 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   7.0442 ns | 0.0124 ns | 0.0097 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   7.2253 ns | 0.0332 ns | 0.0277 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   7.1920 ns | 0.0178 ns | 0.0149 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   5.3530 ns | 0.0161 ns | 0.0143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.6609 ns | 0.0118 ns | 0.0098 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.5690 ns | 0.0143 ns | 0.0127 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |   4.0959 ns | 0.0220 ns | 0.0206 ns |  0.77 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   3.9144 ns | 0.0123 ns | 0.0103 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   7.1564 ns | 0.0343 ns | 0.0321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.9443 ns | 0.0148 ns | 0.0138 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   7.0425 ns | 0.0119 ns | 0.0112 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   7.1998 ns | 0.0122 ns | 0.0108 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   7.2004 ns | 0.0156 ns | 0.0138 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.5489 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   4.6719 ns | 0.0102 ns | 0.0091 ns |  1.03 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   4.7204 ns | 0.0111 ns | 0.0104 ns |  1.04 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.9666 ns | 0.0148 ns | 0.0123 ns |  0.87 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.9661 ns | 0.0126 ns | 0.0111 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   7.0861 ns | 0.0213 ns | 0.0188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   7.0373 ns | 0.0141 ns | 0.0110 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   7.0534 ns | 0.0243 ns | 0.0203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   7.2111 ns | 0.0175 ns | 0.0164 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   7.2065 ns | 0.0133 ns | 0.0118 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   3.0428 ns | 0.0334 ns | 0.0279 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.5325 ns | 0.0098 ns | 0.0091 ns |  1.16 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.4234 ns | 0.0100 ns | 0.0094 ns |  1.13 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   2.7451 ns | 0.0131 ns | 0.0122 ns |  0.90 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   2.7335 ns | 0.0104 ns | 0.0097 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   6.3705 ns | 0.0182 ns | 0.0171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   6.2472 ns | 0.0172 ns | 0.0160 ns |  0.98 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.3501 ns | 0.0096 ns | 0.0080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   6.5019 ns | 0.0210 ns | 0.0186 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   6.5180 ns | 0.0221 ns | 0.0207 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   2.9758 ns | 0.0089 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.2792 ns | 0.0104 ns | 0.0098 ns |  1.10 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.6960 ns | 0.0109 ns | 0.0102 ns |  1.24 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |   2.9081 ns | 0.0130 ns | 0.0122 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   2.8391 ns | 0.0076 ns | 0.0071 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   6.3656 ns | 0.0150 ns | 0.0140 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.2367 ns | 0.0165 ns | 0.0154 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.4139 ns | 0.0122 ns | 0.0108 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.5013 ns | 0.0153 ns | 0.0143 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.5106 ns | 0.0104 ns | 0.0092 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   3.7792 ns | 0.0102 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.7293 ns | 0.0094 ns | 0.0078 ns |  0.72 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.8370 ns | 0.0065 ns | 0.0058 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   4.2509 ns | 0.0140 ns | 0.0131 ns |  1.12 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   4.2221 ns | 0.0254 ns | 0.0237 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.7760 ns | 0.0155 ns | 0.0137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   3.2410 ns | 0.0138 ns | 0.0122 ns |  0.68 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.4326 ns | 0.0090 ns | 0.0084 ns |  0.72 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   5.5945 ns | 0.0094 ns | 0.0088 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   5.5393 ns | 0.0499 ns | 0.0467 ns |  1.16 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   3.6567 ns | 0.0160 ns | 0.0142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.6141 ns | 0.0077 ns | 0.0072 ns |  0.71 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.7125 ns | 0.0625 ns | 0.0584 ns |  0.74 |    0.02 |      - |     - |     - |         - |
            ToULong |        net461 |   3.9531 ns | 0.0086 ns | 0.0072 ns |  1.08 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |   3.9502 ns | 0.0094 ns | 0.0088 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.3608 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.2817 ns | 0.0098 ns | 0.0082 ns |  0.75 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   3.3775 ns | 0.0108 ns | 0.0096 ns |  0.77 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   4.9944 ns | 0.0152 ns | 0.0135 ns |  1.15 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   5.0010 ns | 0.0120 ns | 0.0112 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.4550 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.3435 ns | 0.0040 ns | 0.0038 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.6553 ns | 0.0053 ns | 0.0045 ns |  1.14 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |   1.4025 ns | 0.0040 ns | 0.0033 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   1.3979 ns | 0.0036 ns | 0.0032 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.7388 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.8506 ns | 0.0087 ns | 0.0072 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.4856 ns | 0.0078 ns | 0.0073 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.8741 ns | 0.0089 ns | 0.0074 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.8775 ns | 0.0133 ns | 0.0111 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.4605 ns | 0.0046 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.6682 ns | 0.0038 ns | 0.0034 ns |  1.14 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.5847 ns | 0.0027 ns | 0.0023 ns |  1.08 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |   1.8929 ns | 0.0095 ns | 0.0089 ns |  1.30 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |   1.8909 ns | 0.0057 ns | 0.0053 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.7089 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.5681 ns | 0.0038 ns | 0.0035 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.7876 ns | 0.0053 ns | 0.0047 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.5747 ns | 0.0039 ns | 0.0035 ns |  0.92 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.5862 ns | 0.0055 ns | 0.0052 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  54.7149 ns | 0.0435 ns | 0.0363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  54.7124 ns | 0.1341 ns | 0.1188 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  12.6652 ns | 0.0135 ns | 0.0106 ns |  0.23 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  55.4347 ns | 0.0796 ns | 0.0664 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  55.3980 ns | 0.0614 ns | 0.0544 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  66.0648 ns | 0.2049 ns | 0.1917 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  65.3704 ns | 0.1252 ns | 0.1171 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  18.0715 ns | 0.1130 ns | 0.1002 ns |  0.27 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  65.8290 ns | 0.1852 ns | 0.1733 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  66.6845 ns | 0.2266 ns | 0.1769 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3448 ns | 0.0048 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.1068 ns | 0.0029 ns | 0.0023 ns |  0.90 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.2980 ns | 0.0056 ns | 0.0053 ns |  0.98 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.3515 ns | 0.0033 ns | 0.0026 ns |  0.58 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.3535 ns | 0.0053 ns | 0.0050 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.0525 ns | 0.0193 ns | 0.0171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.4215 ns | 0.0318 ns | 0.0297 ns |  1.05 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   2.0669 ns | 0.0319 ns | 0.0298 ns |  0.26 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.7875 ns | 0.0322 ns | 0.0302 ns |  1.09 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.4896 ns | 0.0301 ns | 0.0267 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.9249 ns | 0.0130 ns | 0.0115 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.5632 ns | 0.0762 ns | 0.0713 ns |  1.16 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.6192 ns | 0.0294 ns | 0.0275 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.8179 ns | 0.0202 ns | 0.0179 ns |  0.97 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   4.1889 ns | 0.0153 ns | 0.0143 ns |  1.07 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 191.6385 ns | 0.4250 ns | 0.3976 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 109.7645 ns | 0.2053 ns | 0.1714 ns |  0.57 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 111.4199 ns | 0.2557 ns | 0.2135 ns |  0.58 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 298.3916 ns | 0.7049 ns | 0.6249 ns |  1.56 |    0.00 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 297.8951 ns | 0.6071 ns | 0.5678 ns |  1.55 |    0.00 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  14.3942 ns | 0.0340 ns | 0.0284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  14.3867 ns | 0.0492 ns | 0.0436 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.6860 ns | 0.0195 ns | 0.0163 ns |  0.74 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  17.5362 ns | 0.0725 ns | 0.0678 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 |  17.4476 ns | 0.0312 ns | 0.0277 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  18.9856 ns | 0.1308 ns | 0.1021 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  18.7657 ns | 0.0274 ns | 0.0256 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  15.1753 ns | 0.0410 ns | 0.0384 ns |  0.80 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  22.2380 ns | 0.0375 ns | 0.0332 ns |  1.17 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  22.0052 ns | 0.0376 ns | 0.0333 ns |  1.16 |    0.01 |      - |     - |     - |         - |
