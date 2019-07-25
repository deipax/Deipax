
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
             ToBool | .NET Core 2.0 |  0.8594 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1956 ns | 0.0106 ns | 0.0099 ns |  1.39 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9644 ns | 0.0038 ns | 0.0033 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7330 ns | 0.0099 ns | 0.0093 ns |  0.85 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4362 ns | 0.0027 ns | 0.0024 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0016 ns | 0.0316 ns | 0.0296 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2065 ns | 0.0097 ns | 0.0081 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0271 ns | 0.0112 ns | 0.0099 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2101 ns | 0.0226 ns | 0.0200 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1830 ns | 0.0031 ns | 0.0029 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.4568 ns | 0.0039 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6847 ns | 0.0171 ns | 0.0160 ns |  1.16 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1888 ns | 0.0070 ns | 0.0062 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.1073 ns | 0.0041 ns | 0.0032 ns |  1.45 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  1.8360 ns | 0.0044 ns | 0.0041 ns |  1.26 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9726 ns | 0.0079 ns | 0.0074 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2125 ns | 0.0137 ns | 0.0128 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0175 ns | 0.0070 ns | 0.0065 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.6375 ns | 0.0090 ns | 0.0084 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.6499 ns | 0.0076 ns | 0.0071 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2583 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6745 ns | 0.0042 ns | 0.0039 ns |  1.33 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.0284 ns | 0.0143 ns | 0.0134 ns |  0.82 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.8847 ns | 0.0057 ns | 0.0050 ns |  1.50 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.6017 ns | 0.0032 ns | 0.0030 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9694 ns | 0.0099 ns | 0.0093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2096 ns | 0.0107 ns | 0.0095 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0228 ns | 0.0104 ns | 0.0093 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8755 ns | 0.0127 ns | 0.0112 ns |  1.23 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8815 ns | 0.0092 ns | 0.0081 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.4477 ns | 0.0138 ns | 0.0123 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6579 ns | 0.0111 ns | 0.0104 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.0125 ns | 0.0048 ns | 0.0043 ns |  0.70 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.9149 ns | 0.0066 ns | 0.0058 ns |  1.32 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.6055 ns | 0.0038 ns | 0.0036 ns |  1.11 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  3.9647 ns | 0.0101 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2023 ns | 0.0076 ns | 0.0068 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0216 ns | 0.0093 ns | 0.0087 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.6378 ns | 0.0093 ns | 0.0082 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.6499 ns | 0.0067 ns | 0.0063 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.8929 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.5215 ns | 0.0121 ns | 0.0113 ns |  1.33 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.2648 ns | 0.0061 ns | 0.0051 ns |  1.20 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6421 ns | 0.0047 ns | 0.0044 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3710 ns | 0.0047 ns | 0.0042 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.6963 ns | 0.0234 ns | 0.0219 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.8950 ns | 0.0056 ns | 0.0049 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.4897 ns | 0.0132 ns | 0.0110 ns |  0.96 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.8747 ns | 0.0090 ns | 0.0084 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.9105 ns | 0.0208 ns | 0.0194 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.4578 ns | 0.0103 ns | 0.0091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4972 ns | 0.0052 ns | 0.0048 ns |  1.03 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3695 ns | 0.0529 ns | 0.0869 ns |  0.94 |    0.07 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.1170 ns | 0.0077 ns | 0.0069 ns |  1.45 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8401 ns | 0.0067 ns | 0.0063 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  3.9631 ns | 0.0077 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2221 ns | 0.0274 ns | 0.0256 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0234 ns | 0.0146 ns | 0.0137 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.6389 ns | 0.0083 ns | 0.0069 ns |  1.17 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.6795 ns | 0.0099 ns | 0.0083 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1864 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4800 ns | 0.0047 ns | 0.0042 ns |  1.25 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9992 ns | 0.0081 ns | 0.0076 ns |  0.84 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  1.6522 ns | 0.0053 ns | 0.0049 ns |  1.39 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  1.3691 ns | 0.0046 ns | 0.0039 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9861 ns | 0.0295 ns | 0.0276 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1949 ns | 0.0090 ns | 0.0080 ns |  1.05 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.7895 ns | 0.0068 ns | 0.0060 ns |  0.95 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.6764 ns | 0.0212 ns | 0.0199 ns |  1.17 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.6548 ns | 0.0133 ns | 0.0111 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  0.8572 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.2346 ns | 0.0060 ns | 0.0057 ns |  1.44 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9619 ns | 0.0035 ns | 0.0033 ns |  1.12 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.7514 ns | 0.0051 ns | 0.0045 ns |  0.88 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.4333 ns | 0.0034 ns | 0.0030 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9615 ns | 0.0102 ns | 0.0085 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4415 ns | 0.0127 ns | 0.0118 ns |  1.12 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2491 ns | 0.0057 ns | 0.0051 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.1890 ns | 0.0249 ns | 0.0233 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.1851 ns | 0.0073 ns | 0.0068 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  0.8582 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1859 ns | 0.0135 ns | 0.0127 ns |  1.38 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9699 ns | 0.0166 ns | 0.0155 ns |  1.13 |    0.02 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7164 ns | 0.0047 ns | 0.0044 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4347 ns | 0.0013 ns | 0.0012 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.4111 ns | 0.0158 ns | 0.0148 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7118 ns | 0.0066 ns | 0.0062 ns |  1.21 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6471 ns | 0.0058 ns | 0.0054 ns |  1.17 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.6438 ns | 0.0039 ns | 0.0036 ns |  1.16 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.5157 ns | 0.0079 ns | 0.0073 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  0.8726 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.1978 ns | 0.0049 ns | 0.0046 ns |  1.37 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9603 ns | 0.0033 ns | 0.0029 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  0.7202 ns | 0.0043 ns | 0.0040 ns |  0.83 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |  0.4357 ns | 0.0023 ns | 0.0020 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.4210 ns | 0.0121 ns | 0.0113 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8171 ns | 0.0079 ns | 0.0070 ns |  1.28 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6512 ns | 0.0050 ns | 0.0042 ns |  1.16 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.5898 ns | 0.0132 ns | 0.0124 ns |  1.12 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.4544 ns | 0.0036 ns | 0.0032 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.0453 ns | 0.0054 ns | 0.0051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3828 ns | 0.0034 ns | 0.0032 ns |  1.32 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2557 ns | 0.0049 ns | 0.0044 ns |  1.20 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.9556 ns | 0.0051 ns | 0.0046 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.6577 ns | 0.0029 ns | 0.0026 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.6607 ns | 0.0063 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.9040 ns | 0.0106 ns | 0.0094 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2567 ns | 0.0145 ns | 0.0128 ns |  0.91 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8770 ns | 0.0063 ns | 0.0059 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8835 ns | 0.0085 ns | 0.0079 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.0907 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2395 ns | 0.0050 ns | 0.0045 ns |  1.14 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2110 ns | 0.0042 ns | 0.0037 ns |  1.11 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.0277 ns | 0.0042 ns | 0.0040 ns |  0.94 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4333 ns | 0.0030 ns | 0.0026 ns |  0.40 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6312 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.7129 ns | 0.0097 ns | 0.0091 ns |  1.05 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8883 ns | 0.0072 ns | 0.0064 ns |  1.16 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.5917 ns | 0.0048 ns | 0.0045 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.4221 ns | 0.0081 ns | 0.0072 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0484 ns | 0.0175 ns | 0.0164 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0649 ns | 0.0098 ns | 0.0082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8749 ns | 0.0138 ns | 0.0129 ns |  0.97 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8531 ns | 0.0153 ns | 0.0143 ns |  0.97 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8524 ns | 0.0159 ns | 0.0149 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.7351 ns | 0.0859 ns | 0.0804 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 17.8942 ns | 0.0350 ns | 0.0310 ns |  0.95 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.2829 ns | 0.1301 ns | 0.1217 ns |  0.71 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.6188 ns | 0.0301 ns | 0.0282 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 19.5776 ns | 0.0534 ns | 0.0446 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0352 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2378 ns | 0.0052 ns | 0.0046 ns |  1.10 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1333 ns | 0.0246 ns | 0.0230 ns |  1.05 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1413 ns | 0.0131 ns | 0.0122 ns |  0.56 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  0.9180 ns | 0.0036 ns | 0.0034 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0412 ns | 0.0346 ns | 0.0324 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1691 ns | 0.0252 ns | 0.0236 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9346 ns | 0.0060 ns | 0.0054 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2538 ns | 0.0148 ns | 0.0131 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 12.3321 ns | 0.0208 ns | 0.0185 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.4254 ns | 0.0118 ns | 0.0111 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7555 ns | 0.0164 ns | 0.0146 ns |  1.10 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.8657 ns | 0.0226 ns | 0.0212 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.9949 ns | 0.0192 ns | 0.0160 ns |  0.87 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7446 ns | 0.0175 ns | 0.0164 ns |  0.80 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 26.8208 ns | 0.0569 ns | 0.0532 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.0844 ns | 0.0488 ns | 0.0433 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.0388 ns | 0.0215 ns | 0.0180 ns |  0.45 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 29.5727 ns | 0.0807 ns | 0.0754 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 29.5344 ns | 0.0821 ns | 0.0728 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.0499 ns | 0.0567 ns | 0.0531 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.3321 ns | 0.0135 ns | 0.0126 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.0324 ns | 0.0221 ns | 0.0207 ns |  0.80 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.7137 ns | 0.0102 ns | 0.0090 ns |  1.27 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.7540 ns | 0.0156 ns | 0.0131 ns |  1.27 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.2245 ns | 0.0433 ns | 0.0384 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 14.9908 ns | 0.0359 ns | 0.0335 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.4472 ns | 0.0182 ns | 0.0170 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.6588 ns | 0.0745 ns | 0.0622 ns |  1.24 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.3862 ns | 0.0416 ns | 0.0347 ns |  1.22 |    0.00 |      - |     - |     - |         - |
