
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
             ToBool | .NET Core 2.0 |  0.9685 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1944 ns | 0.0025 ns | 0.0021 ns |  1.23 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1621 ns | 0.0036 ns | 0.0032 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4502 ns | 0.0095 ns | 0.0089 ns |  0.46 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4509 ns | 0.0021 ns | 0.0019 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0471 ns | 0.0070 ns | 0.0065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2205 ns | 0.0055 ns | 0.0049 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0439 ns | 0.0099 ns | 0.0093 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2443 ns | 0.0280 ns | 0.0262 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2247 ns | 0.0098 ns | 0.0092 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.9904 ns | 0.0040 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.5928 ns | 0.0131 ns | 0.0110 ns |  1.30 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.1993 ns | 0.0049 ns | 0.0038 ns |  1.11 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6061 ns | 0.0048 ns | 0.0042 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.6083 ns | 0.0041 ns | 0.0036 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.7439 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.9199 ns | 0.0052 ns | 0.0046 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.5231 ns | 0.0182 ns | 0.0170 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.9159 ns | 0.0065 ns | 0.0061 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.9180 ns | 0.0094 ns | 0.0088 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.1052 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.5139 ns | 0.0070 ns | 0.0062 ns |  1.19 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.4882 ns | 0.0045 ns | 0.0042 ns |  1.18 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.8921 ns | 0.0057 ns | 0.0051 ns |  0.90 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3909 ns | 0.0131 ns | 0.0123 ns |  0.66 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.7864 ns | 0.0087 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.9281 ns | 0.0117 ns | 0.0109 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.5114 ns | 0.0053 ns | 0.0044 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.9196 ns | 0.0087 ns | 0.0081 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.9234 ns | 0.0064 ns | 0.0053 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.2233 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.5069 ns | 0.0086 ns | 0.0080 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.7953 ns | 0.0041 ns | 0.0034 ns |  1.26 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  1.3887 ns | 0.0136 ns | 0.0121 ns |  0.62 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3802 ns | 0.0125 ns | 0.0110 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.7478 ns | 0.0067 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.9539 ns | 0.0176 ns | 0.0165 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.5104 ns | 0.0119 ns | 0.0112 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.9213 ns | 0.0073 ns | 0.0065 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.9046 ns | 0.0086 ns | 0.0081 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.4637 ns | 0.0083 ns | 0.0078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.1816 ns | 0.0050 ns | 0.0044 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.1412 ns | 0.0042 ns | 0.0039 ns |  0.87 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.3786 ns | 0.0044 ns | 0.0041 ns |  0.56 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.3772 ns | 0.0042 ns | 0.0040 ns |  0.56 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.7805 ns | 0.0157 ns | 0.0139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.9258 ns | 0.0104 ns | 0.0097 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.5048 ns | 0.0057 ns | 0.0053 ns |  0.94 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.9164 ns | 0.0057 ns | 0.0047 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.9049 ns | 0.0058 ns | 0.0051 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.1941 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.4963 ns | 0.0081 ns | 0.0076 ns |  1.14 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.5717 ns | 0.0315 ns | 0.0294 ns |  1.17 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.8448 ns | 0.0061 ns | 0.0054 ns |  0.84 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.8433 ns | 0.0049 ns | 0.0044 ns |  0.84 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.7488 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.9225 ns | 0.0067 ns | 0.0056 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.5058 ns | 0.0100 ns | 0.0089 ns |  0.95 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.9177 ns | 0.0099 ns | 0.0092 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.9358 ns | 0.0377 ns | 0.0353 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  0.9399 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1910 ns | 0.0036 ns | 0.0034 ns |  1.27 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.1610 ns | 0.0043 ns | 0.0038 ns |  1.24 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4455 ns | 0.0024 ns | 0.0022 ns |  0.47 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  0.4522 ns | 0.0028 ns | 0.0025 ns |  0.48 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0451 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4542 ns | 0.0082 ns | 0.0073 ns |  1.10 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.2793 ns | 0.0071 ns | 0.0063 ns |  1.06 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.2210 ns | 0.0082 ns | 0.0073 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.2063 ns | 0.0083 ns | 0.0077 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.3511 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.5227 ns | 0.0037 ns | 0.0033 ns |  1.13 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.1670 ns | 0.0143 ns | 0.0133 ns |  0.86 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.3815 ns | 0.0045 ns | 0.0042 ns |  1.02 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.3818 ns | 0.0037 ns | 0.0033 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0502 ns | 0.0075 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2260 ns | 0.0054 ns | 0.0051 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.8090 ns | 0.0053 ns | 0.0050 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6847 ns | 0.0084 ns | 0.0074 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6674 ns | 0.0081 ns | 0.0076 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  0.9687 ns | 0.0020 ns | 0.0019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1941 ns | 0.0099 ns | 0.0087 ns |  1.23 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1589 ns | 0.0033 ns | 0.0027 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4445 ns | 0.0026 ns | 0.0024 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4468 ns | 0.0016 ns | 0.0015 ns |  0.46 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6683 ns | 0.0049 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0547 ns | 0.0022 ns | 0.0020 ns |  1.23 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9040 ns | 0.0047 ns | 0.0044 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9015 ns | 0.0040 ns | 0.0035 ns |  1.14 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.9061 ns | 0.0197 ns | 0.0185 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.7256 ns | 0.0578 ns | 0.0568 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5552 ns | 0.0054 ns | 0.0051 ns |  0.90 |    0.03 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1596 ns | 0.0035 ns | 0.0029 ns |  0.67 |    0.02 |      - |     - |     - |         - |
            ToULong |        net461 |  1.3784 ns | 0.0035 ns | 0.0031 ns |  0.80 |    0.03 |      - |     - |     - |         - |
            ToULong |        net472 |  1.3756 ns | 0.0024 ns | 0.0020 ns |  0.80 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1458 ns | 0.0090 ns | 0.0075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1692 ns | 0.0055 ns | 0.0046 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0275 ns | 0.0098 ns | 0.0087 ns |  0.94 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.6045 ns | 0.0065 ns | 0.0061 ns |  1.21 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.6034 ns | 0.0113 ns | 0.0100 ns |  1.21 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.2042 ns | 0.0119 ns | 0.0111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4278 ns | 0.0096 ns | 0.0090 ns |  1.19 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3933 ns | 0.0033 ns | 0.0030 ns |  1.16 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4404 ns | 0.0039 ns | 0.0033 ns |  0.37 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4461 ns | 0.0027 ns | 0.0025 ns |  0.37 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2813 ns | 0.0059 ns | 0.0049 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4528 ns | 0.0087 ns | 0.0081 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2787 ns | 0.0290 ns | 0.0271 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4756 ns | 0.0402 ns | 0.0376 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4367 ns | 0.0111 ns | 0.0099 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4342 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4249 ns | 0.0056 ns | 0.0053 ns |  0.99 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3923 ns | 0.0042 ns | 0.0040 ns |  0.97 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4403 ns | 0.0046 ns | 0.0040 ns |  0.31 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.8419 ns | 0.0082 ns | 0.0077 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.9027 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0398 ns | 0.0046 ns | 0.0043 ns |  1.07 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.9270 ns | 0.0168 ns | 0.0157 ns |  1.01 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6804 ns | 0.0077 ns | 0.0069 ns |  0.88 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6633 ns | 0.0062 ns | 0.0052 ns |  0.87 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8953 ns | 0.0086 ns | 0.0080 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.8532 ns | 0.0122 ns | 0.0114 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0207 ns | 0.1295 ns | 0.1211 ns |  1.02 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8558 ns | 0.0132 ns | 0.0117 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.0617 ns | 0.0167 ns | 0.0148 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.1686 ns | 0.0512 ns | 0.0478 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.3204 ns | 0.0857 ns | 0.0801 ns |  1.01 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.0228 ns | 0.2521 ns | 0.2358 ns |  0.72 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.3822 ns | 0.1170 ns | 0.1095 ns |  1.01 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 19.0038 ns | 0.0288 ns | 0.0241 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.4181 ns | 0.0044 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3181 ns | 0.0047 ns | 0.0042 ns |  0.96 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.1959 ns | 0.0071 ns | 0.0066 ns |  0.91 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.2006 ns | 0.0061 ns | 0.0054 ns |  0.50 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1966 ns | 0.0035 ns | 0.0031 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2919 ns | 0.0476 ns | 0.0445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.0785 ns | 0.0103 ns | 0.0091 ns |  0.97 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0272 ns | 0.0227 ns | 0.0213 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.0729 ns | 0.0272 ns | 0.0254 ns |  0.97 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.0480 ns | 0.0301 ns | 0.0252 ns |  0.97 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.2506 ns | 0.0142 ns | 0.0119 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.9004 ns | 0.0106 ns | 0.0099 ns |  1.20 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.9008 ns | 0.0306 ns | 0.0287 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.7808 ns | 0.0137 ns | 0.0128 ns |  0.86 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.2299 ns | 0.0118 ns | 0.0099 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.7294 ns | 0.0708 ns | 0.0591 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.4902 ns | 0.0418 ns | 0.0349 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.6539 ns | 0.0310 ns | 0.0275 ns |  0.43 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.2174 ns | 0.0948 ns | 0.0841 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 30.6995 ns | 0.1003 ns | 0.0889 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.4186 ns | 0.0460 ns | 0.0408 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.0495 ns | 0.0411 ns | 0.0364 ns |  0.97 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.0590 ns | 0.0488 ns | 0.0456 ns |  0.65 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 | 14.6523 ns | 0.0379 ns | 0.0354 ns |  1.18 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 14.6122 ns | 0.0314 ns | 0.0293 ns |  1.18 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.7105 ns | 0.0308 ns | 0.0273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.7145 ns | 0.0183 ns | 0.0171 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.5008 ns | 0.0116 ns | 0.0108 ns |  0.75 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.4400 ns | 0.0726 ns | 0.0643 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.2705 ns | 0.0336 ns | 0.0281 ns |  1.15 |    0.00 |      - |     - |     - |         - |
