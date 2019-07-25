
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
             ToBool | .NET Core 2.0 |   0.8570 ns | 0.0065 ns | 0.0061 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.1827 ns | 0.0068 ns | 0.0064 ns |  1.38 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   0.9314 ns | 0.0065 ns | 0.0061 ns |  1.09 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.7355 ns | 0.0069 ns | 0.0065 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |   0.4377 ns | 0.0100 ns | 0.0093 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.0026 ns | 0.0084 ns | 0.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.2558 ns | 0.0271 ns | 0.0254 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   3.9876 ns | 0.0082 ns | 0.0072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.2391 ns | 0.0417 ns | 0.0390 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.1799 ns | 0.0081 ns | 0.0076 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   1.9829 ns | 0.0074 ns | 0.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   2.6027 ns | 0.0250 ns | 0.0234 ns |  1.31 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   2.2617 ns | 0.0196 ns | 0.0183 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |   1.9331 ns | 0.0079 ns | 0.0074 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |   1.6048 ns | 0.0111 ns | 0.0087 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.6954 ns | 0.0124 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.9105 ns | 0.0097 ns | 0.0091 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.4597 ns | 0.0106 ns | 0.0100 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.9566 ns | 0.0226 ns | 0.0211 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.8781 ns | 0.0106 ns | 0.0094 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   2.2283 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   2.6816 ns | 0.0079 ns | 0.0062 ns |  1.20 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   2.2643 ns | 0.0090 ns | 0.0080 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |   1.6311 ns | 0.0069 ns | 0.0062 ns |  0.73 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   1.3599 ns | 0.0040 ns | 0.0035 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   4.6903 ns | 0.0097 ns | 0.0086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   4.9031 ns | 0.0118 ns | 0.0104 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   4.4615 ns | 0.0113 ns | 0.0100 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   4.9029 ns | 0.0119 ns | 0.0106 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   4.8817 ns | 0.0088 ns | 0.0082 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   2.1501 ns | 0.0121 ns | 0.0107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   2.5377 ns | 0.0121 ns | 0.0113 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   1.9138 ns | 0.0209 ns | 0.0196 ns |  0.89 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |   1.6285 ns | 0.0052 ns | 0.0046 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |   1.3673 ns | 0.0043 ns | 0.0033 ns |  0.64 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   4.6916 ns | 0.0105 ns | 0.0093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   4.9406 ns | 0.0378 ns | 0.0353 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   4.4498 ns | 0.0097 ns | 0.0091 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   4.9115 ns | 0.0210 ns | 0.0175 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   4.8797 ns | 0.0079 ns | 0.0070 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   2.3371 ns | 0.0155 ns | 0.0145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   2.1658 ns | 0.0054 ns | 0.0048 ns |  0.93 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   1.9262 ns | 0.0053 ns | 0.0047 ns |  0.82 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |   1.6808 ns | 0.0052 ns | 0.0048 ns |  0.72 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   1.3744 ns | 0.0120 ns | 0.0112 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   4.6973 ns | 0.0106 ns | 0.0100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   4.9052 ns | 0.0091 ns | 0.0085 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   4.4529 ns | 0.0076 ns | 0.0068 ns |  0.95 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   4.8980 ns | 0.0109 ns | 0.0085 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   4.8852 ns | 0.0129 ns | 0.0121 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   2.5561 ns | 0.0109 ns | 0.0097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   2.4763 ns | 0.0077 ns | 0.0065 ns |  0.97 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   1.9465 ns | 0.0072 ns | 0.0067 ns |  0.76 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |   2.1519 ns | 0.0049 ns | 0.0046 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   1.8285 ns | 0.0050 ns | 0.0044 ns |  0.72 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   4.6945 ns | 0.0088 ns | 0.0082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   4.9307 ns | 0.0479 ns | 0.0448 ns |  1.05 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   4.4613 ns | 0.0118 ns | 0.0098 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   4.9067 ns | 0.0165 ns | 0.0146 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   4.8686 ns | 0.0052 ns | 0.0046 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   1.3524 ns | 0.0186 ns | 0.0174 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   1.1963 ns | 0.0052 ns | 0.0046 ns |  0.89 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   0.9498 ns | 0.0036 ns | 0.0032 ns |  0.70 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   0.7074 ns | 0.0044 ns | 0.0041 ns |  0.52 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |   0.4468 ns | 0.0097 ns | 0.0090 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   3.9989 ns | 0.0098 ns | 0.0082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   4.2114 ns | 0.0109 ns | 0.0102 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   3.9946 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   4.2043 ns | 0.0081 ns | 0.0064 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   4.1889 ns | 0.0131 ns | 0.0122 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   1.2805 ns | 0.0068 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   1.8402 ns | 0.0070 ns | 0.0066 ns |  1.44 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   0.9736 ns | 0.0045 ns | 0.0040 ns |  0.76 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |   1.6427 ns | 0.0116 ns | 0.0103 ns |  1.28 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   1.3696 ns | 0.0052 ns | 0.0049 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   3.9965 ns | 0.0106 ns | 0.0099 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   4.2538 ns | 0.0320 ns | 0.0299 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   3.7987 ns | 0.0285 ns | 0.0266 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   4.6729 ns | 0.0126 ns | 0.0118 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   4.6447 ns | 0.0092 ns | 0.0081 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   0.9640 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   1.1807 ns | 0.0048 ns | 0.0045 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   0.9341 ns | 0.0059 ns | 0.0053 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |   0.7255 ns | 0.0046 ns | 0.0041 ns |  0.75 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   0.4415 ns | 0.0123 ns | 0.0115 ns |  0.46 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   1.6972 ns | 0.0065 ns | 0.0060 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   1.8002 ns | 0.0097 ns | 0.0086 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   1.4458 ns | 0.0066 ns | 0.0055 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   1.7373 ns | 0.0185 ns | 0.0173 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   1.4498 ns | 0.0277 ns | 0.0259 ns |  0.85 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   1.2554 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   1.5055 ns | 0.0097 ns | 0.0086 ns |  1.20 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   0.9716 ns | 0.0044 ns | 0.0036 ns |  0.77 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |   1.6545 ns | 0.0060 ns | 0.0056 ns |  1.32 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |   1.3999 ns | 0.0051 ns | 0.0047 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   1.6859 ns | 0.0065 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   2.3892 ns | 0.0079 ns | 0.0074 ns |  1.42 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   1.7083 ns | 0.0107 ns | 0.0100 ns |  1.01 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   2.7294 ns | 0.0082 ns | 0.0072 ns |  1.62 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   2.4879 ns | 0.0189 ns | 0.0167 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.3296 ns | 0.0061 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.2160 ns | 0.0038 ns | 0.0031 ns |  0.91 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.1085 ns | 0.0188 ns | 0.0176 ns |  0.83 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.7154 ns | 0.0072 ns | 0.0064 ns |  0.54 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.4399 ns | 0.0041 ns | 0.0036 ns |  0.33 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.2353 ns | 0.0140 ns | 0.0131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.4439 ns | 0.0087 ns | 0.0078 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.2353 ns | 0.0115 ns | 0.0102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.4919 ns | 0.0187 ns | 0.0175 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.4146 ns | 0.0074 ns | 0.0069 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   0.9587 ns | 0.0037 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.2236 ns | 0.0194 ns | 0.0182 ns |  1.28 |    0.02 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.1019 ns | 0.0102 ns | 0.0095 ns |  1.15 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.7158 ns | 0.0041 ns | 0.0034 ns |  0.75 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.4366 ns | 0.0026 ns | 0.0023 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.6637 ns | 0.0124 ns | 0.0116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.8693 ns | 0.0049 ns | 0.0045 ns |  1.12 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.4611 ns | 0.0082 ns | 0.0073 ns |  0.88 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.9326 ns | 0.0058 ns | 0.0054 ns |  1.16 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.6452 ns | 0.0060 ns | 0.0053 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |   5.8342 ns | 0.0083 ns | 0.0078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |   6.1218 ns | 0.0452 ns | 0.0423 ns |  1.05 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |   6.1087 ns | 0.0697 ns | 0.0652 ns |  1.05 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |   6.0696 ns | 0.0236 ns | 0.0209 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |   5.8772 ns | 0.0329 ns | 0.0291 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  18.6448 ns | 0.0240 ns | 0.0213 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  18.2524 ns | 0.0390 ns | 0.0364 ns |  0.98 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  12.6950 ns | 0.1441 ns | 0.1348 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  18.6700 ns | 0.0929 ns | 0.0869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  18.2352 ns | 0.0708 ns | 0.0592 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.0091 ns | 0.0059 ns | 0.0052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.3481 ns | 0.0125 ns | 0.0105 ns |  1.17 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   1.9310 ns | 0.0064 ns | 0.0057 ns |  0.96 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.1746 ns | 0.0044 ns | 0.0039 ns |  0.58 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   0.9097 ns | 0.0052 ns | 0.0046 ns |  0.45 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.0874 ns | 0.0218 ns | 0.0204 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.0716 ns | 0.0194 ns | 0.0182 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   1.9090 ns | 0.0038 ns | 0.0032 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   8.2374 ns | 0.0224 ns | 0.0198 ns |  1.02 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.0723 ns | 0.0195 ns | 0.0183 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.6335 ns | 0.0136 ns | 0.0121 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   3.8392 ns | 0.0159 ns | 0.0141 ns |  1.06 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   3.8128 ns | 0.0412 ns | 0.0386 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   2.9132 ns | 0.0101 ns | 0.0089 ns |  0.80 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   2.8886 ns | 0.0202 ns | 0.0179 ns |  0.79 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  50.8403 ns | 0.1130 ns | 0.1057 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 2.2 |  49.3148 ns | 0.3557 ns | 0.3327 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
          To_String | .NET Core 3.0 |  31.3926 ns | 0.0946 ns | 0.0838 ns |  0.62 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 301.7790 ns | 1.3268 ns | 1.2411 ns |  5.94 |    0.02 | 0.0114 |     - |     - |      72 B |
          To_String |        net472 | 302.9297 ns | 1.8531 ns | 1.6427 ns |  5.96 |    0.04 | 0.0114 |     - |     - |      72 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |   0.9566 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |   1.1943 ns | 0.0040 ns | 0.0038 ns |  1.25 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |   0.9317 ns | 0.0047 ns | 0.0044 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 |   0.7221 ns | 0.0150 ns | 0.0133 ns |  0.75 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 |   0.4411 ns | 0.0044 ns | 0.0037 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |   4.0004 ns | 0.0146 ns | 0.0122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |   4.4472 ns | 0.0117 ns | 0.0110 ns |  1.11 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |   4.2293 ns | 0.0103 ns | 0.0081 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |   4.2667 ns | 0.0127 ns | 0.0112 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |   4.1784 ns | 0.0028 ns | 0.0023 ns |  1.04 |    0.00 |      - |     - |     - |         - |
