
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
             ToBool | .NET Core 2.0 |  1.1915 ns | 0.0090 ns | 0.0084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1930 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9534 ns | 0.0098 ns | 0.0087 ns |  0.80 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4412 ns | 0.0105 ns | 0.0098 ns |  0.37 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4508 ns | 0.0047 ns | 0.0044 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9843 ns | 0.0113 ns | 0.0105 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2668 ns | 0.0065 ns | 0.0061 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0111 ns | 0.0065 ns | 0.0051 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2106 ns | 0.0145 ns | 0.0121 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2232 ns | 0.0056 ns | 0.0053 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7846 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5415 ns | 0.0048 ns | 0.0040 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  0.9897 ns | 0.0070 ns | 0.0066 ns |  0.55 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6540 ns | 0.0337 ns | 0.0299 ns |  0.93 |    0.02 |      - |     - |     - |         - |
             ToChar |        net472 |  1.3874 ns | 0.0051 ns | 0.0048 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9867 ns | 0.0106 ns | 0.0094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2251 ns | 0.0108 ns | 0.0090 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0095 ns | 0.0069 ns | 0.0057 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.9074 ns | 0.0085 ns | 0.0075 ns |  1.23 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.9939 ns | 0.0327 ns | 0.0306 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.1951 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.2120 ns | 0.0197 ns | 0.0184 ns |  1.01 |    0.02 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  0.9554 ns | 0.0031 ns | 0.0029 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  0.4450 ns | 0.0040 ns | 0.0037 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  0.4495 ns | 0.0027 ns | 0.0025 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  3.9904 ns | 0.0066 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4584 ns | 0.0119 ns | 0.0105 ns |  1.12 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.2497 ns | 0.0052 ns | 0.0046 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.2036 ns | 0.0054 ns | 0.0050 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.2260 ns | 0.0103 ns | 0.0091 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6658 ns | 0.0140 ns | 0.0131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.5079 ns | 0.0099 ns | 0.0092 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  0.9976 ns | 0.0090 ns | 0.0085 ns |  0.60 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3763 ns | 0.0048 ns | 0.0042 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3850 ns | 0.0024 ns | 0.0020 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  3.9849 ns | 0.0080 ns | 0.0075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2249 ns | 0.0070 ns | 0.0065 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0149 ns | 0.0099 ns | 0.0088 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.7795 ns | 0.0211 ns | 0.0197 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.9229 ns | 0.0080 ns | 0.0075 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.1889 ns | 0.0066 ns | 0.0059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.1929 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  0.9400 ns | 0.0055 ns | 0.0051 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  0.4380 ns | 0.0032 ns | 0.0029 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  0.4471 ns | 0.0024 ns | 0.0021 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  3.9890 ns | 0.0098 ns | 0.0082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2309 ns | 0.0079 ns | 0.0074 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0511 ns | 0.0252 ns | 0.0236 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.2374 ns | 0.0124 ns | 0.0116 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.2234 ns | 0.0120 ns | 0.0106 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6514 ns | 0.0036 ns | 0.0033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6841 ns | 0.0045 ns | 0.0042 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9757 ns | 0.0064 ns | 0.0057 ns |  0.59 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6088 ns | 0.0064 ns | 0.0056 ns |  0.97 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.6167 ns | 0.0029 ns | 0.0027 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  3.9907 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2543 ns | 0.0319 ns | 0.0283 ns |  1.07 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0149 ns | 0.0095 ns | 0.0089 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.9102 ns | 0.0090 ns | 0.0084 ns |  1.23 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.9245 ns | 0.0090 ns | 0.0080 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.1824 ns | 0.0059 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.2053 ns | 0.0196 ns | 0.0183 ns |  1.02 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9590 ns | 0.0114 ns | 0.0101 ns |  0.81 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4353 ns | 0.0046 ns | 0.0043 ns |  0.37 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.4497 ns | 0.0019 ns | 0.0017 ns |  0.38 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9873 ns | 0.0084 ns | 0.0079 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2205 ns | 0.0074 ns | 0.0069 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0172 ns | 0.0165 ns | 0.0146 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.2197 ns | 0.0159 ns | 0.0148 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.2287 ns | 0.0072 ns | 0.0068 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5890 ns | 0.0118 ns | 0.0111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.5134 ns | 0.0192 ns | 0.0180 ns |  0.95 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9739 ns | 0.0037 ns | 0.0035 ns |  0.61 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.4919 ns | 0.0063 ns | 0.0055 ns |  0.94 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.6247 ns | 0.0033 ns | 0.0031 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9899 ns | 0.0143 ns | 0.0119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2310 ns | 0.0092 ns | 0.0086 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.7796 ns | 0.0139 ns | 0.0116 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6915 ns | 0.0197 ns | 0.0184 ns |  1.18 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6923 ns | 0.0083 ns | 0.0073 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.0952 ns | 0.0050 ns | 0.0039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1939 ns | 0.0049 ns | 0.0041 ns |  1.09 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9407 ns | 0.0056 ns | 0.0047 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4374 ns | 0.0040 ns | 0.0037 ns |  0.40 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4463 ns | 0.0017 ns | 0.0014 ns |  0.41 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6304 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7883 ns | 0.0062 ns | 0.0055 ns |  1.10 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.4915 ns | 0.0042 ns | 0.0038 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.7449 ns | 0.0040 ns | 0.0035 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8901 ns | 0.0045 ns | 0.0035 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.5806 ns | 0.0068 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5112 ns | 0.0045 ns | 0.0042 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9767 ns | 0.0040 ns | 0.0033 ns |  0.62 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.3846 ns | 0.0048 ns | 0.0043 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.3846 ns | 0.0047 ns | 0.0044 ns |  0.88 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0590 ns | 0.0068 ns | 0.0053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1992 ns | 0.0070 ns | 0.0062 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7507 ns | 0.0074 ns | 0.0062 ns |  0.85 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.6568 ns | 0.0117 ns | 0.0104 ns |  1.29 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.8029 ns | 0.0088 ns | 0.0074 ns |  1.36 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3471 ns | 0.0539 ns | 0.0662 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.2222 ns | 0.0041 ns | 0.0038 ns |  0.91 |    0.05 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1039 ns | 0.0056 ns | 0.0053 ns |  0.82 |    0.04 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.6561 ns | 0.0040 ns | 0.0036 ns |  0.49 |    0.03 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.6817 ns | 0.0070 ns | 0.0066 ns |  0.51 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2249 ns | 0.0239 ns | 0.0212 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4666 ns | 0.0083 ns | 0.0078 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2465 ns | 0.0082 ns | 0.0077 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4609 ns | 0.0324 ns | 0.0303 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4552 ns | 0.0041 ns | 0.0037 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.3440 ns | 0.0152 ns | 0.0135 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2252 ns | 0.0082 ns | 0.0073 ns |  0.91 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.0975 ns | 0.0055 ns | 0.0043 ns |  0.82 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4386 ns | 0.0073 ns | 0.0068 ns |  0.33 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4397 ns | 0.0029 ns | 0.0026 ns |  0.33 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8036 ns | 0.0153 ns | 0.0143 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9272 ns | 0.0438 ns | 0.0409 ns |  1.07 |    0.02 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.4877 ns | 0.0055 ns | 0.0051 ns |  0.82 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.8381 ns | 0.0234 ns | 0.0207 ns |  1.02 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.8891 ns | 0.0084 ns | 0.0074 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.1438 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.9112 ns | 0.0250 ns | 0.0208 ns |  0.96 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.9329 ns | 0.0285 ns | 0.0266 ns |  0.97 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8438 ns | 0.0090 ns | 0.0080 ns |  0.95 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8538 ns | 0.0112 ns | 0.0105 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 17.9746 ns | 0.0395 ns | 0.0369 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.7003 ns | 0.0319 ns | 0.0266 ns |  1.04 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.0037 ns | 0.2214 ns | 0.2071 ns |  0.72 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.0222 ns | 0.0385 ns | 0.0360 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.2290 ns | 0.0433 ns | 0.0405 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2867 ns | 0.0068 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3908 ns | 0.0058 ns | 0.0048 ns |  1.05 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.0962 ns | 0.0059 ns | 0.0049 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9218 ns | 0.0058 ns | 0.0048 ns |  0.40 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.2063 ns | 0.0133 ns | 0.0104 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1653 ns | 0.0221 ns | 0.0196 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.1872 ns | 0.0206 ns | 0.0182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9242 ns | 0.0041 ns | 0.0038 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.0733 ns | 0.0627 ns | 0.0586 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.0828 ns | 0.0257 ns | 0.0241 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2386 ns | 0.0222 ns | 0.0208 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.9841 ns | 0.0113 ns | 0.0105 ns |  1.23 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7964 ns | 0.0285 ns | 0.0267 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6080 ns | 0.0234 ns | 0.0207 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6350 ns | 0.0110 ns | 0.0092 ns |  0.81 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.3384 ns | 0.1158 ns | 0.1084 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.4427 ns | 0.1539 ns | 0.1439 ns |  0.59 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.3684 ns | 0.0497 ns | 0.0465 ns |  0.46 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.8236 ns | 0.1167 ns | 0.1035 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.9126 ns | 0.0702 ns | 0.0622 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  9.9422 ns | 0.0195 ns | 0.0152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.4753 ns | 0.0483 ns | 0.0452 ns |  1.05 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.2571 ns | 0.0197 ns | 0.0164 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.2622 ns | 0.0193 ns | 0.0171 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.4737 ns | 0.0179 ns | 0.0159 ns |  1.25 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.6050 ns | 0.0548 ns | 0.0512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.0822 ns | 0.1272 ns | 0.1190 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.8200 ns | 0.0166 ns | 0.0147 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 17.1030 ns | 0.0507 ns | 0.0474 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.9788 ns | 0.0387 ns | 0.0343 ns |  1.16 |    0.00 |      - |     - |     - |         - |
