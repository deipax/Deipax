
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
             ToBool | .NET Core 2.0 |  1.4870 ns | 0.0074 ns | 0.0065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4365 ns | 0.0043 ns | 0.0040 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4433 ns | 0.0062 ns | 0.0058 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  1.2129 ns | 0.0052 ns | 0.0048 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.0281 ns | 0.0039 ns | 0.0032 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.5501 ns | 0.0559 ns | 0.0523 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4451 ns | 0.0084 ns | 0.0079 ns |  0.98 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2643 ns | 0.0074 ns | 0.0062 ns |  0.94 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.6792 ns | 0.0112 ns | 0.0093 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6586 ns | 0.0076 ns | 0.0067 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.7775 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6252 ns | 0.0036 ns | 0.0034 ns |  0.91 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.6302 ns | 0.0041 ns | 0.0036 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.2032 ns | 0.0125 ns | 0.0117 ns |  0.68 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.9980 ns | 0.0042 ns | 0.0037 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.3327 ns | 0.0171 ns | 0.0160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4498 ns | 0.0063 ns | 0.0059 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0374 ns | 0.0076 ns | 0.0071 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4519 ns | 0.0088 ns | 0.0082 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4535 ns | 0.0244 ns | 0.0217 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.7182 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.9521 ns | 0.0057 ns | 0.0050 ns |  1.14 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4877 ns | 0.0050 ns | 0.0047 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.3001 ns | 0.0067 ns | 0.0056 ns |  1.34 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.0650 ns | 0.0766 ns | 0.0640 ns |  1.20 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.5382 ns | 0.0388 ns | 0.0363 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4726 ns | 0.0296 ns | 0.0277 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.5171 ns | 0.0093 ns | 0.0082 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3874 ns | 0.0126 ns | 0.0118 ns |  1.19 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3585 ns | 0.0080 ns | 0.0075 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.0064 ns | 0.0042 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.0038 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5544 ns | 0.0116 ns | 0.0108 ns |  0.78 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.3437 ns | 0.0049 ns | 0.0046 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3037 ns | 0.0049 ns | 0.0044 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.5303 ns | 0.0221 ns | 0.0206 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.6730 ns | 0.0088 ns | 0.0078 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.5107 ns | 0.0123 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.4332 ns | 0.0060 ns | 0.0053 ns |  1.20 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3605 ns | 0.0103 ns | 0.0096 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.7307 ns | 0.0113 ns | 0.0106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6626 ns | 0.0070 ns | 0.0065 ns |  0.96 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6275 ns | 0.0048 ns | 0.0042 ns |  0.94 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.5979 ns | 0.0059 ns | 0.0056 ns |  1.50 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  2.3043 ns | 0.0023 ns | 0.0020 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.5182 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4549 ns | 0.0142 ns | 0.0133 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.5116 ns | 0.0093 ns | 0.0083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3793 ns | 0.0096 ns | 0.0085 ns |  1.19 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3707 ns | 0.0314 ns | 0.0294 ns |  1.19 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.4432 ns | 0.0051 ns | 0.0040 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6679 ns | 0.0053 ns | 0.0045 ns |  1.16 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5841 ns | 0.0099 ns | 0.0088 ns |  1.10 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.8902 ns | 0.0070 ns | 0.0058 ns |  1.31 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.0303 ns | 0.0182 ns | 0.0162 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  1.1790 ns | 0.0037 ns | 0.0033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  1.1633 ns | 0.0052 ns | 0.0046 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  0.9699 ns | 0.0049 ns | 0.0041 ns |  0.82 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  1.1877 ns | 0.0047 ns | 0.0039 ns |  1.01 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  0.9400 ns | 0.0060 ns | 0.0056 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.5565 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7792 ns | 0.0137 ns | 0.0121 ns |  1.14 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2693 ns | 0.0057 ns | 0.0051 ns |  0.82 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.4371 ns | 0.0053 ns | 0.0049 ns |  0.92 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.1606 ns | 0.0054 ns | 0.0045 ns |  0.75 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2907 ns | 0.0098 ns | 0.0086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4341 ns | 0.0069 ns | 0.0062 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0436 ns | 0.0052 ns | 0.0046 ns |  0.94 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4593 ns | 0.0104 ns | 0.0092 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4198 ns | 0.0065 ns | 0.0050 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6439 ns | 0.0054 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6220 ns | 0.0038 ns | 0.0034 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2703 ns | 0.0036 ns | 0.0030 ns |  0.77 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.4088 ns | 0.0092 ns | 0.0082 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.1425 ns | 0.0055 ns | 0.0049 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2886 ns | 0.0100 ns | 0.0078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4400 ns | 0.0087 ns | 0.0072 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0502 ns | 0.0257 ns | 0.0240 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4504 ns | 0.0073 ns | 0.0065 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4279 ns | 0.0104 ns | 0.0093 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4881 ns | 0.0067 ns | 0.0059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4302 ns | 0.0052 ns | 0.0046 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5521 ns | 0.0045 ns | 0.0038 ns |  1.04 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.3517 ns | 0.0054 ns | 0.0045 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |  0.9769 ns | 0.0098 ns | 0.0092 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9609 ns | 0.0059 ns | 0.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8295 ns | 0.0044 ns | 0.0041 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.2278 ns | 0.0066 ns | 0.0058 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.4237 ns | 0.0132 ns | 0.0110 ns |  1.24 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1322 ns | 0.0190 ns | 0.0178 ns |  1.09 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.6490 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4520 ns | 0.0107 ns | 0.0095 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4689 ns | 0.0052 ns | 0.0046 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.4327 ns | 0.0083 ns | 0.0073 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.1494 ns | 0.0044 ns | 0.0036 ns |  0.70 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0451 ns | 0.0040 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8281 ns | 0.0052 ns | 0.0049 ns |  0.89 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9199 ns | 0.0067 ns | 0.0059 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.6727 ns | 0.0068 ns | 0.0060 ns |  1.31 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.6667 ns | 0.0098 ns | 0.0091 ns |  1.30 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7486 ns | 0.0059 ns | 0.0056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6031 ns | 0.0052 ns | 0.0049 ns |  0.92 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.7375 ns | 0.0104 ns | 0.0097 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1762 ns | 0.0052 ns | 0.0048 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.0207 ns | 0.0049 ns | 0.0038 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.5194 ns | 0.0088 ns | 0.0073 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.7137 ns | 0.0185 ns | 0.0173 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4994 ns | 0.0071 ns | 0.0067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.9228 ns | 0.0244 ns | 0.0228 ns |  1.09 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.9275 ns | 0.0233 ns | 0.0218 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6621 ns | 0.0092 ns | 0.0086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4147 ns | 0.0042 ns | 0.0040 ns |  0.85 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3875 ns | 0.0031 ns | 0.0026 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.4097 ns | 0.0070 ns | 0.0066 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.1404 ns | 0.0036 ns | 0.0032 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9157 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8839 ns | 0.0044 ns | 0.0041 ns |  0.98 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8982 ns | 0.0034 ns | 0.0030 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.6052 ns | 0.0063 ns | 0.0053 ns |  1.36 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.8396 ns | 0.0141 ns | 0.0132 ns |  1.48 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.1707 ns | 0.0528 ns | 0.0494 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0835 ns | 0.0272 ns | 0.0241 ns |  0.99 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.9005 ns | 0.0106 ns | 0.0088 ns |  0.96 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.3898 ns | 0.0209 ns | 0.0186 ns |  1.04 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.5320 ns | 0.0152 ns | 0.0142 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.7989 ns | 0.0369 ns | 0.0327 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.1929 ns | 0.0443 ns | 0.0393 ns |  0.97 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.7289 ns | 0.1151 ns | 0.1077 ns |  0.68 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.6797 ns | 0.0309 ns | 0.0289 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.3805 ns | 0.0270 ns | 0.0226 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3490 ns | 0.0047 ns | 0.0039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1505 ns | 0.0127 ns | 0.0119 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3292 ns | 0.0044 ns | 0.0039 ns |  0.99 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1984 ns | 0.0043 ns | 0.0040 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.0197 ns | 0.0097 ns | 0.0091 ns |  0.43 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1032 ns | 0.0413 ns | 0.0386 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5477 ns | 0.0230 ns | 0.0216 ns |  1.05 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9485 ns | 0.0053 ns | 0.0047 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.6108 ns | 0.0315 ns | 0.0295 ns |  1.06 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3596 ns | 0.0225 ns | 0.0200 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.9566 ns | 0.0168 ns | 0.0140 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.6188 ns | 0.0202 ns | 0.0189 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.6565 ns | 0.0298 ns | 0.0279 ns |  1.18 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8899 ns | 0.0126 ns | 0.0112 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7830 ns | 0.0102 ns | 0.0090 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 27.2002 ns | 0.0684 ns | 0.0640 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.4840 ns | 0.0524 ns | 0.0409 ns |  0.64 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.9026 ns | 0.0617 ns | 0.0547 ns |  0.47 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.0635 ns | 0.1606 ns | 0.1503 ns |  1.14 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 32.2659 ns | 0.0869 ns | 0.0813 ns |  1.19 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.6312 ns | 0.0525 ns | 0.0491 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.5130 ns | 0.0137 ns | 0.0129 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.5566 ns | 0.0289 ns | 0.0270 ns |  0.68 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.3202 ns | 0.0396 ns | 0.0330 ns |  1.21 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.9391 ns | 0.1421 ns | 0.1329 ns |  1.26 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.8175 ns | 0.0376 ns | 0.0334 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.9426 ns | 0.0800 ns | 0.0748 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2732 ns | 0.0194 ns | 0.0181 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.9229 ns | 0.0331 ns | 0.0294 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.9290 ns | 0.0503 ns | 0.0471 ns |  1.19 |    0.00 |      - |     - |     - |         - |
