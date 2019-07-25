
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
             ToBool | .NET Core 2.0 |   0.8692 ns | 0.0041 ns | 0.0039 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   0.9478 ns | 0.0052 ns | 0.0046 ns |  1.09 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.1702 ns | 0.0042 ns | 0.0037 ns |  1.35 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |   0.4461 ns | 0.0031 ns | 0.0025 ns |  0.51 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |   0.7370 ns | 0.0055 ns | 0.0049 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   3.9961 ns | 0.0087 ns | 0.0081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.2027 ns | 0.0111 ns | 0.0092 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.0352 ns | 0.0057 ns | 0.0050 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.2093 ns | 0.0092 ns | 0.0081 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.2345 ns | 0.0158 ns | 0.0147 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   0.8780 ns | 0.0058 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   0.9660 ns | 0.0037 ns | 0.0031 ns |  1.10 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.1731 ns | 0.0052 ns | 0.0043 ns |  1.34 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |   0.4506 ns | 0.0017 ns | 0.0015 ns |  0.51 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |   0.7256 ns | 0.0052 ns | 0.0043 ns |  0.83 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   3.9910 ns | 0.0065 ns | 0.0058 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.2025 ns | 0.0122 ns | 0.0114 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.0405 ns | 0.0061 ns | 0.0057 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.2105 ns | 0.0078 ns | 0.0073 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.2221 ns | 0.0336 ns | 0.0315 ns |  1.06 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   0.8733 ns | 0.0022 ns | 0.0019 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   0.9673 ns | 0.0152 ns | 0.0143 ns |  1.11 |    0.02 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   1.1859 ns | 0.0083 ns | 0.0073 ns |  1.36 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |   0.4508 ns | 0.0146 ns | 0.0136 ns |  0.52 |    0.02 |      - |     - |     - |         - |
            ToSByte |        net472 |   0.7067 ns | 0.0029 ns | 0.0023 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   4.0329 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   4.2012 ns | 0.0093 ns | 0.0087 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   4.0402 ns | 0.0071 ns | 0.0063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   4.2080 ns | 0.0101 ns | 0.0090 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   4.1994 ns | 0.0106 ns | 0.0099 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   0.8632 ns | 0.0097 ns | 0.0086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   0.9596 ns | 0.0039 ns | 0.0034 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   1.1771 ns | 0.0046 ns | 0.0043 ns |  1.36 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |   0.4504 ns | 0.0057 ns | 0.0051 ns |  0.52 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |   0.7105 ns | 0.0078 ns | 0.0073 ns |  0.82 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   3.9943 ns | 0.0077 ns | 0.0068 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   4.2053 ns | 0.0114 ns | 0.0107 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   4.0572 ns | 0.0271 ns | 0.0240 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   4.2114 ns | 0.0076 ns | 0.0071 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   4.1963 ns | 0.0071 ns | 0.0063 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   0.8623 ns | 0.0028 ns | 0.0023 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   0.9471 ns | 0.0038 ns | 0.0034 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   1.1750 ns | 0.0085 ns | 0.0075 ns |  1.36 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |   0.4501 ns | 0.0051 ns | 0.0045 ns |  0.52 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   0.7397 ns | 0.0251 ns | 0.0234 ns |  0.86 |    0.03 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   3.9947 ns | 0.0081 ns | 0.0072 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   4.1961 ns | 0.0066 ns | 0.0059 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   4.0358 ns | 0.0080 ns | 0.0071 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   4.2066 ns | 0.0117 ns | 0.0110 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   4.1986 ns | 0.0082 ns | 0.0077 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   1.2189 ns | 0.0102 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   0.9512 ns | 0.0058 ns | 0.0054 ns |  0.78 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   1.1835 ns | 0.0130 ns | 0.0122 ns |  0.97 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |   0.4453 ns | 0.0062 ns | 0.0052 ns |  0.37 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |   0.7270 ns | 0.0042 ns | 0.0035 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   3.9990 ns | 0.0078 ns | 0.0065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   4.2057 ns | 0.0095 ns | 0.0089 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   4.0416 ns | 0.0124 ns | 0.0110 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   4.2108 ns | 0.0102 ns | 0.0095 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   4.1964 ns | 0.0073 ns | 0.0068 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   0.8766 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   0.9606 ns | 0.0043 ns | 0.0038 ns |  1.10 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   1.1766 ns | 0.0044 ns | 0.0041 ns |  1.34 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   0.4577 ns | 0.0032 ns | 0.0029 ns |  0.52 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |   0.7053 ns | 0.0040 ns | 0.0035 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   3.9956 ns | 0.0091 ns | 0.0081 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   4.2407 ns | 0.0222 ns | 0.0208 ns |  1.06 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   4.0392 ns | 0.0099 ns | 0.0092 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   4.2110 ns | 0.0077 ns | 0.0064 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   4.1948 ns | 0.0101 ns | 0.0084 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   0.9575 ns | 0.0032 ns | 0.0027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   0.9633 ns | 0.0038 ns | 0.0035 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   1.1851 ns | 0.0037 ns | 0.0033 ns |  1.24 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |   0.4492 ns | 0.0030 ns | 0.0027 ns |  0.47 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |   0.7044 ns | 0.0107 ns | 0.0100 ns |  0.73 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   4.0336 ns | 0.0111 ns | 0.0103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   4.2033 ns | 0.0108 ns | 0.0101 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   4.0381 ns | 0.0114 ns | 0.0095 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   4.2097 ns | 0.0054 ns | 0.0048 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   4.1995 ns | 0.0073 ns | 0.0068 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   0.9550 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   0.9495 ns | 0.0044 ns | 0.0041 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   1.1727 ns | 0.0054 ns | 0.0051 ns |  1.23 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |   0.4433 ns | 0.0031 ns | 0.0026 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |   0.7262 ns | 0.0034 ns | 0.0032 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   1.8770 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   1.6210 ns | 0.0052 ns | 0.0046 ns |  0.86 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   1.7370 ns | 0.0040 ns | 0.0033 ns |  0.93 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   1.8583 ns | 0.0042 ns | 0.0035 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   1.7146 ns | 0.0066 ns | 0.0061 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   0.9441 ns | 0.0099 ns | 0.0088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   0.9662 ns | 0.0033 ns | 0.0030 ns |  1.02 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   1.1695 ns | 0.0029 ns | 0.0022 ns |  1.24 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |   0.4520 ns | 0.0042 ns | 0.0035 ns |  0.48 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |   0.7259 ns | 0.0040 ns | 0.0034 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   1.4355 ns | 0.0067 ns | 0.0063 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   1.8857 ns | 0.0094 ns | 0.0088 ns |  1.31 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   1.9506 ns | 0.0049 ns | 0.0044 ns |  1.36 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   1.8603 ns | 0.0056 ns | 0.0047 ns |  1.30 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   2.0531 ns | 0.0070 ns | 0.0059 ns |  1.43 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.1614 ns | 0.0051 ns | 0.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.4334 ns | 0.0068 ns | 0.0060 ns |  1.23 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.1694 ns | 0.0038 ns | 0.0036 ns |  1.01 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.4430 ns | 0.0033 ns | 0.0031 ns |  0.38 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.7123 ns | 0.0024 ns | 0.0021 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.2290 ns | 0.0096 ns | 0.0090 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.4791 ns | 0.0247 ns | 0.0219 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.0420 ns | 0.0121 ns | 0.0107 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.4434 ns | 0.0075 ns | 0.0070 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.4483 ns | 0.0123 ns | 0.0115 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   0.9430 ns | 0.0033 ns | 0.0030 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.1792 ns | 0.0027 ns | 0.0024 ns |  1.25 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.1735 ns | 0.0024 ns | 0.0019 ns |  1.24 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.4427 ns | 0.0046 ns | 0.0041 ns |  0.47 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.7178 ns | 0.0055 ns | 0.0052 ns |  0.76 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.5624 ns | 0.0113 ns | 0.0106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.6187 ns | 0.0040 ns | 0.0037 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.7964 ns | 0.0048 ns | 0.0043 ns |  1.15 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.6507 ns | 0.0033 ns | 0.0030 ns |  1.06 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.7248 ns | 0.0109 ns | 0.0102 ns |  1.10 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |   2.7888 ns | 0.0117 ns | 0.0109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |   2.8330 ns | 0.0068 ns | 0.0064 ns |  1.02 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |   3.0754 ns | 0.0246 ns | 0.0218 ns |  1.10 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |   5.8826 ns | 0.0376 ns | 0.0352 ns |  2.11 |    0.02 |      - |     - |     - |         - |
          ToDecimal |        net472 |   5.8457 ns | 0.0125 ns | 0.0117 ns |  2.10 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |   1.6629 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |   1.6186 ns | 0.0030 ns | 0.0027 ns |  0.97 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |   1.6807 ns | 0.0088 ns | 0.0073 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |   1.8956 ns | 0.0065 ns | 0.0054 ns |  1.14 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |   1.9323 ns | 0.0036 ns | 0.0030 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   0.9297 ns | 0.0053 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   1.1789 ns | 0.0140 ns | 0.0124 ns |  1.27 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   1.1814 ns | 0.0188 ns | 0.0176 ns |  1.27 |    0.02 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.1941 ns | 0.0032 ns | 0.0027 ns |  1.28 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.2006 ns | 0.0078 ns | 0.0073 ns |  1.29 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   6.3128 ns | 0.0204 ns | 0.0181 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   5.1337 ns | 0.0095 ns | 0.0084 ns |  0.81 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   5.1849 ns | 0.0107 ns | 0.0100 ns |  0.82 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |   6.3208 ns | 0.0166 ns | 0.0155 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  12.8581 ns | 0.0465 ns | 0.0435 ns |  2.04 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.1957 ns | 0.0122 ns | 0.0114 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   3.7882 ns | 0.0099 ns | 0.0083 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   3.8979 ns | 0.0278 ns | 0.0260 ns |  1.22 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   2.7155 ns | 0.0128 ns | 0.0113 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   2.9972 ns | 0.0095 ns | 0.0084 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 310.8557 ns | 0.5561 ns | 0.4930 ns |  1.00 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 2.2 | 275.2213 ns | 0.6187 ns | 0.5485 ns |  0.89 |    0.00 | 0.0262 |     - |     - |     168 B |
          To_String | .NET Core 3.0 | 219.6193 ns | 0.3687 ns | 0.3268 ns |  0.71 |    0.00 | 0.0100 |     - |     - |      64 B |
          To_String |        net461 | 331.1452 ns | 1.8117 ns | 1.5129 ns |  1.07 |    0.01 | 0.0300 |     - |     - |     192 B |
          To_String |        net472 | 326.6246 ns | 0.6817 ns | 0.6043 ns |  1.05 |    0.00 | 0.0300 |     - |     - |     192 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |   9.4248 ns | 0.0233 ns | 0.0218 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |   9.3519 ns | 0.0235 ns | 0.0220 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |   7.1387 ns | 0.0167 ns | 0.0139 ns |  0.76 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  11.6081 ns | 0.0167 ns | 0.0148 ns |  1.23 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  11.4384 ns | 0.0300 ns | 0.0251 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |   9.8104 ns | 0.0193 ns | 0.0180 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |   9.8830 ns | 0.0201 ns | 0.0188 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |   7.3919 ns | 0.0235 ns | 0.0220 ns |  0.75 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  11.9224 ns | 0.0213 ns | 0.0199 ns |  1.22 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  11.9617 ns | 0.0211 ns | 0.0197 ns |  1.22 |    0.00 |      - |     - |     - |         - |
