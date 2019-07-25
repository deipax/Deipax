
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4603 ns | 0.0044 ns | 0.0039 ns |  1.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4810 ns | 0.0050 ns | 0.0046 ns |  1.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4447 ns | 0.0038 ns | 0.0034 ns |  0.99 |      - |     - |     - |         - |
             ToBool |        net461 |  1.2068 ns | 0.0058 ns | 0.0055 ns |  0.83 |      - |     - |     - |         - |
             ToBool |        net472 |  1.0310 ns | 0.0050 ns | 0.0047 ns |  0.71 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4963 ns | 0.0075 ns | 0.0062 ns |  1.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4457 ns | 0.0113 ns | 0.0100 ns |  0.99 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2667 ns | 0.0070 ns | 0.0062 ns |  0.95 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.5328 ns | 0.0092 ns | 0.0077 ns |  1.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6795 ns | 0.0077 ns | 0.0064 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.0248 ns | 0.0048 ns | 0.0040 ns |  1.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.7302 ns | 0.0061 ns | 0.0054 ns |  0.85 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4384 ns | 0.0031 ns | 0.0028 ns |  0.71 |      - |     - |     - |         - |
             ToChar |        net461 |  2.3829 ns | 0.0181 ns | 0.0170 ns |  1.18 |      - |     - |     - |         - |
             ToChar |        net472 |  2.0828 ns | 0.0050 ns | 0.0047 ns |  1.03 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.4634 ns | 0.0269 ns | 0.0251 ns |  1.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.3278 ns | 0.0061 ns | 0.0054 ns |  0.97 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.4891 ns | 0.0137 ns | 0.0121 ns |  1.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3846 ns | 0.0086 ns | 0.0080 ns |  1.21 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.4260 ns | 0.0200 ns | 0.0187 ns |  1.22 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.6301 ns | 0.0090 ns | 0.0080 ns |  1.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.7228 ns | 0.0261 ns | 0.0232 ns |  1.04 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.6354 ns | 0.0111 ns | 0.0098 ns |  1.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.5751 ns | 0.0080 ns | 0.0071 ns |  0.98 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.3057 ns | 0.0047 ns | 0.0036 ns |  0.88 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.1958 ns | 0.0092 ns | 0.0081 ns |  1.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.1419 ns | 0.0106 ns | 0.0094 ns |  0.99 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.9678 ns | 0.0090 ns | 0.0070 ns |  0.96 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3891 ns | 0.0103 ns | 0.0097 ns |  1.04 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3955 ns | 0.0307 ns | 0.0287 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.9688 ns | 0.0086 ns | 0.0080 ns |  1.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.6641 ns | 0.0094 ns | 0.0088 ns |  0.90 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.6977 ns | 0.0449 ns | 0.0420 ns |  0.91 |      - |     - |     - |         - |
             ToByte |        net461 |  2.5743 ns | 0.0046 ns | 0.0041 ns |  0.87 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3199 ns | 0.0073 ns | 0.0057 ns |  0.78 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.1778 ns | 0.0406 ns | 0.0380 ns |  1.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.1459 ns | 0.0099 ns | 0.0093 ns |  0.99 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.9646 ns | 0.0097 ns | 0.0091 ns |  0.96 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3809 ns | 0.0099 ns | 0.0092 ns |  1.04 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3914 ns | 0.0109 ns | 0.0091 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4415 ns | 0.0026 ns | 0.0023 ns |  1.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6751 ns | 0.0034 ns | 0.0028 ns |  1.16 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5724 ns | 0.0047 ns | 0.0041 ns |  1.09 |      - |     - |     - |         - |
            ToShort |        net461 |  1.8955 ns | 0.0083 ns | 0.0078 ns |  1.31 |      - |     - |     - |         - |
            ToShort |        net472 |  1.8713 ns | 0.0039 ns | 0.0032 ns |  1.30 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  1.1141 ns | 0.0037 ns | 0.0032 ns |  1.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  1.1896 ns | 0.0036 ns | 0.0032 ns |  1.07 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  1.1617 ns | 0.0055 ns | 0.0046 ns |  1.04 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  1.1958 ns | 0.0043 ns | 0.0040 ns |  1.07 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  0.9859 ns | 0.0081 ns | 0.0068 ns |  0.89 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.8844 ns | 0.0056 ns | 0.0047 ns |  1.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.0060 ns | 0.0025 ns | 0.0021 ns |  1.06 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.6819 ns | 0.0060 ns | 0.0056 ns |  0.89 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.3938 ns | 0.0069 ns | 0.0065 ns |  1.27 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.2812 ns | 0.0061 ns | 0.0057 ns |  1.21 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.6867 ns | 0.0088 ns | 0.0082 ns |  1.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4557 ns | 0.0226 ns | 0.0201 ns |  0.95 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.5251 ns | 0.0285 ns | 0.0267 ns |  0.97 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3774 ns | 0.0112 ns | 0.0100 ns |  1.15 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3851 ns | 0.0078 ns | 0.0065 ns |  1.15 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.5198 ns | 0.0026 ns | 0.0025 ns |  1.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5074 ns | 0.0049 ns | 0.0043 ns |  0.99 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4819 ns | 0.0036 ns | 0.0034 ns |  0.98 |      - |     - |     - |         - |
              ToInt |        net461 |  1.4124 ns | 0.0057 ns | 0.0051 ns |  0.93 |      - |     - |     - |         - |
              ToInt |        net472 |  1.1551 ns | 0.0076 ns | 0.0071 ns |  0.76 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2164 ns | 0.0049 ns | 0.0044 ns |  1.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4460 ns | 0.0080 ns | 0.0075 ns |  1.05 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0396 ns | 0.0110 ns | 0.0103 ns |  0.96 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4543 ns | 0.0112 ns | 0.0099 ns |  1.06 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4494 ns | 0.0094 ns | 0.0088 ns |  1.06 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.7982 ns | 0.0057 ns | 0.0053 ns |  1.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.8923 ns | 0.0146 ns | 0.0136 ns |  1.05 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5822 ns | 0.0037 ns | 0.0034 ns |  0.88 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.5797 ns | 0.0070 ns | 0.0059 ns |  1.43 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.3077 ns | 0.0042 ns | 0.0035 ns |  1.28 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4593 ns | 0.0093 ns | 0.0087 ns |  1.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4506 ns | 0.0075 ns | 0.0071 ns |  1.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2916 ns | 0.0298 ns | 0.0279 ns |  0.96 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.1460 ns | 0.0115 ns | 0.0108 ns |  1.15 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.1475 ns | 0.0094 ns | 0.0078 ns |  1.15 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4043 ns | 0.0053 ns | 0.0049 ns |  1.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6603 ns | 0.0073 ns | 0.0064 ns |  1.18 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6253 ns | 0.0045 ns | 0.0042 ns |  1.16 |      - |     - |     - |         - |
             ToLong |        net461 |  1.4551 ns | 0.0037 ns | 0.0031 ns |  1.04 |      - |     - |     - |         - |
             ToLong |        net472 |  1.1579 ns | 0.0040 ns | 0.0037 ns |  0.82 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0796 ns | 0.0133 ns | 0.0111 ns |  1.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.2847 ns | 0.0047 ns | 0.0044 ns |  1.10 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1632 ns | 0.0036 ns | 0.0034 ns |  1.04 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.7603 ns | 0.0122 ns | 0.0114 ns |  1.33 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.6509 ns | 0.0105 ns | 0.0098 ns |  1.27 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.8187 ns | 0.0109 ns | 0.0096 ns |  1.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.7246 ns | 0.0052 ns | 0.0044 ns |  0.95 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4368 ns | 0.0049 ns | 0.0046 ns |  0.79 |      - |     - |     - |         - |
            ToULong |        net461 |  2.6042 ns | 0.0180 ns | 0.0169 ns |  1.43 |      - |     - |     - |         - |
            ToULong |        net472 |  2.3128 ns | 0.0069 ns | 0.0061 ns |  1.27 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1156 ns | 0.0055 ns | 0.0052 ns |  1.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2291 ns | 0.0193 ns | 0.0180 ns |  1.05 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0775 ns | 0.0049 ns | 0.0043 ns |  0.98 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.8192 ns | 0.0110 ns | 0.0103 ns |  1.81 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.7537 ns | 0.0051 ns | 0.0045 ns |  1.77 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5891 ns | 0.0055 ns | 0.0043 ns |  1.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4940 ns | 0.0060 ns | 0.0053 ns |  0.94 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.5458 ns | 0.0127 ns | 0.0113 ns |  0.97 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.3831 ns | 0.0047 ns | 0.0042 ns |  0.87 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.0288 ns | 0.0070 ns | 0.0058 ns |  0.65 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4648 ns | 0.0102 ns | 0.0096 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6873 ns | 0.0095 ns | 0.0079 ns |  1.05 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4646 ns | 0.0083 ns | 0.0078 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.9701 ns | 0.0125 ns | 0.0111 ns |  1.11 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.9556 ns | 0.0146 ns | 0.0136 ns |  1.11 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5806 ns | 0.0166 ns | 0.0155 ns |  1.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6353 ns | 0.0040 ns | 0.0035 ns |  1.03 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6704 ns | 0.0046 ns | 0.0036 ns |  1.06 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.4100 ns | 0.0070 ns | 0.0059 ns |  0.89 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.1460 ns | 0.0033 ns | 0.0030 ns |  0.72 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7988 ns | 0.0036 ns | 0.0032 ns |  1.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.1768 ns | 0.0066 ns | 0.0059 ns |  1.21 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.2526 ns | 0.0032 ns | 0.0030 ns |  1.25 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6193 ns | 0.0066 ns | 0.0058 ns |  1.46 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5954 ns | 0.0097 ns | 0.0091 ns |  1.44 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0678 ns | 0.0203 ns | 0.0190 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0809 ns | 0.0079 ns | 0.0074 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.1142 ns | 0.0095 ns | 0.0079 ns |  1.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.5726 ns | 0.0163 ns | 0.0153 ns |  1.08 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.3253 ns | 0.0111 ns | 0.0093 ns |  1.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 19.1077 ns | 0.0456 ns | 0.0426 ns |  1.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.9197 ns | 0.0332 ns | 0.0310 ns |  0.99 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.4390 ns | 0.2469 ns | 0.2309 ns |  0.70 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.4309 ns | 0.0302 ns | 0.0283 ns |  0.96 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.6747 ns | 0.0392 ns | 0.0347 ns |  0.98 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2826 ns | 0.0066 ns | 0.0055 ns |  1.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2245 ns | 0.0062 ns | 0.0055 ns |  0.97 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3256 ns | 0.0070 ns | 0.0062 ns |  1.02 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1974 ns | 0.0043 ns | 0.0038 ns |  0.52 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.2077 ns | 0.0068 ns | 0.0061 ns |  0.53 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9682 ns | 0.0184 ns | 0.0153 ns |  1.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4306 ns | 0.0627 ns | 0.0586 ns |  1.06 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9550 ns | 0.0239 ns | 0.0224 ns |  0.25 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4870 ns | 0.0129 ns | 0.0114 ns |  1.07 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 12.3781 ns | 0.0146 ns | 0.0129 ns |  1.55 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.8227 ns | 0.0147 ns | 0.0137 ns |  1.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5635 ns | 0.0113 ns | 0.0105 ns |  1.19 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.6708 ns | 0.0581 ns | 0.0543 ns |  1.22 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8949 ns | 0.0156 ns | 0.0138 ns |  1.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7972 ns | 0.0189 ns | 0.0158 ns |  0.99 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |        |       |       |           |
          To_String | .NET Core 2.0 | 29.7898 ns | 0.0900 ns | 0.0798 ns |  1.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 18.5468 ns | 0.0499 ns | 0.0467 ns |  0.62 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.0402 ns | 0.0226 ns | 0.0176 ns |  0.44 |      - |     - |     - |         - |
          To_String |        net461 | 32.3496 ns | 0.1032 ns | 0.0965 ns |  1.09 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.8046 ns | 0.2240 ns | 0.1986 ns |  1.07 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.7313 ns | 0.0634 ns | 0.0593 ns |  1.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4795 ns | 0.0192 ns | 0.0170 ns |  0.98 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5209 ns | 0.0113 ns | 0.0095 ns |  0.67 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.4151 ns | 0.0383 ns | 0.0320 ns |  1.21 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.7721 ns | 0.0568 ns | 0.0503 ns |  1.24 |      - |     - |     - |         - |
                    |               |            |           |           |       |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.9329 ns | 0.0619 ns | 0.0579 ns |  1.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.8974 ns | 0.0389 ns | 0.0325 ns |  1.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2319 ns | 0.0631 ns | 0.0590 ns |  0.78 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.0939 ns | 0.0295 ns | 0.0276 ns |  1.19 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.9240 ns | 0.0319 ns | 0.0283 ns |  1.18 |      - |     - |     - |         - |
