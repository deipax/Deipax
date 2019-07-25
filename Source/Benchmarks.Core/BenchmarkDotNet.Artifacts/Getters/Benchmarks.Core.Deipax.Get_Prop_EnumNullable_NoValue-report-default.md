
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
             ToBool | .NET Core 2.0 |  1.2593 ns | 0.0063 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6520 ns | 0.0235 ns | 0.0220 ns |  1.31 |    0.02 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4347 ns | 0.0150 ns | 0.0141 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9944 ns | 0.0043 ns | 0.0036 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.0065 ns | 0.0155 ns | 0.0145 ns |  0.80 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0278 ns | 0.0150 ns | 0.0126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2010 ns | 0.0080 ns | 0.0067 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0245 ns | 0.0063 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1873 ns | 0.0139 ns | 0.0130 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2192 ns | 0.0357 ns | 0.0334 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.3064 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4970 ns | 0.0071 ns | 0.0063 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2534 ns | 0.0071 ns | 0.0063 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9986 ns | 0.0052 ns | 0.0048 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9990 ns | 0.0046 ns | 0.0043 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2566 ns | 0.0127 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2592 ns | 0.0346 ns | 0.0307 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0473 ns | 0.0058 ns | 0.0054 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4228 ns | 0.0042 ns | 0.0040 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4378 ns | 0.0081 ns | 0.0076 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2460 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.5673 ns | 0.0039 ns | 0.0034 ns |  1.26 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.3073 ns | 0.0048 ns | 0.0040 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9938 ns | 0.0040 ns | 0.0033 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.0299 ns | 0.0054 ns | 0.0050 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2561 ns | 0.0102 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2410 ns | 0.0482 ns | 0.0450 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0207 ns | 0.0266 ns | 0.0222 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4529 ns | 0.0126 ns | 0.0118 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4382 ns | 0.0092 ns | 0.0086 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.3174 ns | 0.0063 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4784 ns | 0.0057 ns | 0.0051 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.2495 ns | 0.0058 ns | 0.0054 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9969 ns | 0.0050 ns | 0.0044 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.0103 ns | 0.0172 ns | 0.0161 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2592 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2177 ns | 0.0403 ns | 0.0377 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0232 ns | 0.0068 ns | 0.0056 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4189 ns | 0.0091 ns | 0.0080 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4349 ns | 0.0095 ns | 0.0089 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.2783 ns | 0.0214 ns | 0.0200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5696 ns | 0.0051 ns | 0.0048 ns |  1.23 |    0.02 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.3122 ns | 0.0050 ns | 0.0047 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9972 ns | 0.0052 ns | 0.0048 ns |  0.78 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  1.1749 ns | 0.0105 ns | 0.0093 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2889 ns | 0.0392 ns | 0.0367 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2060 ns | 0.0095 ns | 0.0079 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0209 ns | 0.0159 ns | 0.0141 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4223 ns | 0.0082 ns | 0.0073 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4887 ns | 0.0249 ns | 0.0221 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.2924 ns | 0.0065 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5252 ns | 0.0105 ns | 0.0093 ns |  1.18 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.2696 ns | 0.0036 ns | 0.0033 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9959 ns | 0.0058 ns | 0.0049 ns |  0.77 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.0000 ns | 0.0071 ns | 0.0063 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2598 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2050 ns | 0.0109 ns | 0.0102 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0225 ns | 0.0070 ns | 0.0059 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4242 ns | 0.0080 ns | 0.0071 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4923 ns | 0.0213 ns | 0.0199 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.2492 ns | 0.0114 ns | 0.0107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.8006 ns | 0.0073 ns | 0.0068 ns |  1.44 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6167 ns | 0.0101 ns | 0.0094 ns |  1.29 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9995 ns | 0.0047 ns | 0.0041 ns |  0.80 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.1915 ns | 0.0047 ns | 0.0039 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0315 ns | 0.0115 ns | 0.0108 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2053 ns | 0.0110 ns | 0.0098 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0388 ns | 0.0241 ns | 0.0226 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4221 ns | 0.0123 ns | 0.0115 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4955 ns | 0.0516 ns | 0.0482 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.3230 ns | 0.0193 ns | 0.0180 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.5058 ns | 0.0202 ns | 0.0189 ns |  1.14 |    0.02 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2497 ns | 0.0060 ns | 0.0056 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9629 ns | 0.0041 ns | 0.0038 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.1723 ns | 0.0031 ns | 0.0029 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4899 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4364 ns | 0.0080 ns | 0.0075 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9963 ns | 0.0084 ns | 0.0075 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4225 ns | 0.0106 ns | 0.0088 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4405 ns | 0.0122 ns | 0.0102 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2462 ns | 0.0046 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4828 ns | 0.0065 ns | 0.0051 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.3075 ns | 0.0058 ns | 0.0051 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9972 ns | 0.0027 ns | 0.0024 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0157 ns | 0.0042 ns | 0.0038 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.1567 ns | 0.0059 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.9368 ns | 0.0065 ns | 0.0060 ns |  0.90 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9146 ns | 0.0060 ns | 0.0057 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9055 ns | 0.0078 ns | 0.0073 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.2230 ns | 0.0053 ns | 0.0047 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.3082 ns | 0.0068 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4989 ns | 0.0090 ns | 0.0080 ns |  1.15 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5125 ns | 0.0043 ns | 0.0040 ns |  1.16 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9654 ns | 0.0063 ns | 0.0059 ns |  0.74 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9738 ns | 0.0185 ns | 0.0173 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9811 ns | 0.0036 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2637 ns | 0.0051 ns | 0.0046 ns |  1.14 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1289 ns | 0.0607 ns | 0.0568 ns |  1.07 |    0.03 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.8953 ns | 0.0045 ns | 0.0035 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.1859 ns | 0.0072 ns | 0.0067 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4423 ns | 0.0053 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4830 ns | 0.0047 ns | 0.0042 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.2477 ns | 0.0072 ns | 0.0067 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0211 ns | 0.0050 ns | 0.0044 ns |  0.71 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.2102 ns | 0.0146 ns | 0.0122 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2578 ns | 0.0075 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4948 ns | 0.0229 ns | 0.0214 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2526 ns | 0.0121 ns | 0.0095 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6544 ns | 0.0089 ns | 0.0074 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6728 ns | 0.0141 ns | 0.0132 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6596 ns | 0.0066 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.7362 ns | 0.0581 ns | 0.0544 ns |  1.05 |    0.03 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5064 ns | 0.0041 ns | 0.0036 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0213 ns | 0.0055 ns | 0.0049 ns |  0.62 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.1545 ns | 0.0041 ns | 0.0036 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8851 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.3198 ns | 0.0206 ns | 0.0192 ns |  1.23 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0439 ns | 0.0069 ns | 0.0058 ns |  1.08 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1085 ns | 0.0030 ns | 0.0025 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1316 ns | 0.0058 ns | 0.0054 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3588 ns | 0.0173 ns | 0.0162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.3914 ns | 0.0092 ns | 0.0082 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1245 ns | 0.0032 ns | 0.0029 ns |  0.90 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0734 ns | 0.0274 ns | 0.0243 ns |  2.57 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.1145 ns | 0.0692 ns | 0.0613 ns |  2.59 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.2161 ns | 0.0220 ns | 0.0195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 12.8515 ns | 0.0298 ns | 0.0249 ns |  1.26 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.2984 ns | 0.0092 ns | 0.0077 ns |  0.23 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7297 ns | 0.0203 ns | 0.0190 ns |  1.05 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7379 ns | 0.0180 ns | 0.0159 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1198 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3700 ns | 0.0136 ns | 0.0127 ns |  1.12 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1758 ns | 0.0048 ns | 0.0037 ns |  1.03 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.0046 ns | 0.0045 ns | 0.0037 ns |  0.47 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1732 ns | 0.0070 ns | 0.0055 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3792 ns | 0.0236 ns | 0.0197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2263 ns | 0.0275 ns | 0.0244 ns |  0.98 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9403 ns | 0.0039 ns | 0.0034 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.5622 ns | 0.0320 ns | 0.0299 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3575 ns | 0.0157 ns | 0.0131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4225 ns | 0.0057 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.9190 ns | 0.0045 ns | 0.0040 ns |  1.35 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2814 ns | 0.0038 ns | 0.0036 ns |  0.90 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9842 ns | 0.0059 ns | 0.0055 ns |  0.69 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.3311 ns | 0.0143 ns | 0.0134 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.9183 ns | 0.0043 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6326 ns | 0.0074 ns | 0.0066 ns |  0.85 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.5786 ns | 0.0061 ns | 0.0051 ns |  0.82 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.2744 ns | 0.0035 ns | 0.0032 ns |  0.66 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2871 ns | 0.0244 ns | 0.0228 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4412 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.5670 ns | 0.0068 ns | 0.0060 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.2737 ns | 0.0148 ns | 0.0123 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  0.9815 ns | 0.0026 ns | 0.0023 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  0.9956 ns | 0.0175 ns | 0.0156 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  1.1914 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  1.6070 ns | 0.0033 ns | 0.0027 ns |  1.35 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  1.1830 ns | 0.0046 ns | 0.0041 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  0.9362 ns | 0.0044 ns | 0.0037 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  1.1957 ns | 0.0096 ns | 0.0085 ns |  1.00 |    0.01 |     - |     - |     - |         - |
