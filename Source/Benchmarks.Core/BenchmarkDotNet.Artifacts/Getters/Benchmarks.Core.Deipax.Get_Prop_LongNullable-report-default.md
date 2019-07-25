
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.453 ns | 0.0047 ns | 0.0044 ns |  1.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.619 ns | 0.0117 ns | 0.0098 ns |  1.11 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.624 ns | 0.0049 ns | 0.0044 ns |  1.12 |      - |     - |     - |         - |
             ToBool |        net461 |  1.198 ns | 0.0071 ns | 0.0063 ns |  0.82 |      - |     - |     - |         - |
             ToBool |        net472 |  1.190 ns | 0.0031 ns | 0.0026 ns |  0.82 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.274 ns | 0.0101 ns | 0.0095 ns |  1.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.422 ns | 0.0079 ns | 0.0066 ns |  1.03 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.485 ns | 0.0106 ns | 0.0099 ns |  1.05 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.907 ns | 0.0088 ns | 0.0082 ns |  1.15 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.868 ns | 0.0082 ns | 0.0077 ns |  1.14 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.748 ns | 0.0077 ns | 0.0072 ns |  1.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.748 ns | 0.0161 ns | 0.0142 ns |  1.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.971 ns | 0.0120 ns | 0.0112 ns |  1.08 |      - |     - |     - |         - |
             ToChar |        net461 |  2.125 ns | 0.0060 ns | 0.0056 ns |  0.77 |      - |     - |     - |         - |
             ToChar |        net472 |  2.109 ns | 0.0085 ns | 0.0079 ns |  0.77 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.199 ns | 0.0110 ns | 0.0097 ns |  1.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.167 ns | 0.0362 ns | 0.0321 ns |  0.99 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.985 ns | 0.0231 ns | 0.0216 ns |  0.96 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.370 ns | 0.0066 ns | 0.0058 ns |  1.03 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.343 ns | 0.0286 ns | 0.0239 ns |  1.03 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.873 ns | 0.0203 ns | 0.0190 ns |  1.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.835 ns | 0.0119 ns | 0.0100 ns |  0.99 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  3.190 ns | 0.0090 ns | 0.0085 ns |  1.11 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.121 ns | 0.0149 ns | 0.0139 ns |  0.74 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.111 ns | 0.0062 ns | 0.0055 ns |  0.74 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.198 ns | 0.0105 ns | 0.0098 ns |  1.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.124 ns | 0.0072 ns | 0.0061 ns |  0.99 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.705 ns | 0.0102 ns | 0.0085 ns |  0.91 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.368 ns | 0.0160 ns | 0.0150 ns |  1.03 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.346 ns | 0.0083 ns | 0.0065 ns |  1.03 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
             ToByte | .NET Core 2.0 |  3.004 ns | 0.0128 ns | 0.0120 ns |  1.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.776 ns | 0.0063 ns | 0.0059 ns |  0.92 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.872 ns | 0.0055 ns | 0.0043 ns |  0.96 |      - |     - |     - |         - |
             ToByte |        net461 |  2.335 ns | 0.0039 ns | 0.0033 ns |  0.78 |      - |     - |     - |         - |
             ToByte |        net472 |  2.393 ns | 0.0097 ns | 0.0091 ns |  0.80 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.198 ns | 0.0144 ns | 0.0135 ns |  1.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.163 ns | 0.0394 ns | 0.0368 ns |  0.99 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.699 ns | 0.0115 ns | 0.0096 ns |  0.90 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.426 ns | 0.0308 ns | 0.0257 ns |  1.04 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.344 ns | 0.0083 ns | 0.0078 ns |  1.03 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.706 ns | 0.0141 ns | 0.0132 ns |  1.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.775 ns | 0.0088 ns | 0.0082 ns |  1.03 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  3.267 ns | 0.0223 ns | 0.0208 ns |  1.21 |      - |     - |     - |         - |
            ToShort |        net461 |  2.592 ns | 0.0075 ns | 0.0066 ns |  0.96 |      - |     - |     - |         - |
            ToShort |        net472 |  2.603 ns | 0.0055 ns | 0.0049 ns |  0.96 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.254 ns | 0.0166 ns | 0.0147 ns |  1.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.119 ns | 0.0096 ns | 0.0090 ns |  0.97 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.700 ns | 0.0061 ns | 0.0054 ns |  0.89 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.372 ns | 0.0079 ns | 0.0070 ns |  1.02 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.357 ns | 0.0179 ns | 0.0158 ns |  1.02 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
           ToUShort | .NET Core 2.0 |  3.110 ns | 0.0102 ns | 0.0095 ns |  1.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.782 ns | 0.0083 ns | 0.0078 ns |  0.89 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.672 ns | 0.0078 ns | 0.0069 ns |  0.86 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.363 ns | 0.0051 ns | 0.0045 ns |  0.76 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.347 ns | 0.0034 ns | 0.0028 ns |  0.75 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.232 ns | 0.0445 ns | 0.0417 ns |  1.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.125 ns | 0.0121 ns | 0.0113 ns |  0.98 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.949 ns | 0.0074 ns | 0.0062 ns |  0.95 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.381 ns | 0.0117 ns | 0.0109 ns |  1.03 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.345 ns | 0.0093 ns | 0.0082 ns |  1.02 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
              ToInt | .NET Core 2.0 |  2.625 ns | 0.0072 ns | 0.0068 ns |  1.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.769 ns | 0.0065 ns | 0.0058 ns |  1.06 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.848 ns | 0.0083 ns | 0.0078 ns |  1.09 |      - |     - |     - |         - |
              ToInt |        net461 |  2.327 ns | 0.0051 ns | 0.0048 ns |  0.89 |      - |     - |     - |         - |
              ToInt |        net472 |  2.357 ns | 0.0160 ns | 0.0150 ns |  0.90 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  5.433 ns | 0.0150 ns | 0.0140 ns |  1.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  5.120 ns | 0.0106 ns | 0.0099 ns |  0.94 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.699 ns | 0.0076 ns | 0.0064 ns |  0.86 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  5.375 ns | 0.0105 ns | 0.0093 ns |  0.99 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  5.378 ns | 0.0275 ns | 0.0257 ns |  0.99 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
             ToUInt | .NET Core 2.0 |  2.975 ns | 0.0153 ns | 0.0143 ns |  1.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  2.642 ns | 0.0084 ns | 0.0070 ns |  0.89 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  2.829 ns | 0.0102 ns | 0.0095 ns |  0.95 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.338 ns | 0.0103 ns | 0.0086 ns |  0.79 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.444 ns | 0.0115 ns | 0.0096 ns |  0.82 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  5.198 ns | 0.0090 ns | 0.0084 ns |  1.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  5.157 ns | 0.0319 ns | 0.0298 ns |  0.99 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.750 ns | 0.0414 ns | 0.0387 ns |  0.91 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.373 ns | 0.0111 ns | 0.0104 ns |  1.03 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.344 ns | 0.0082 ns | 0.0073 ns |  1.03 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.437 ns | 0.0041 ns | 0.0034 ns |  1.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.660 ns | 0.0090 ns | 0.0080 ns |  1.16 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.542 ns | 0.0049 ns | 0.0043 ns |  1.07 |      - |     - |     - |         - |
             ToLong |        net461 |  1.888 ns | 0.0068 ns | 0.0060 ns |  1.31 |      - |     - |     - |         - |
             ToLong |        net472 |  1.946 ns | 0.0055 ns | 0.0052 ns |  1.36 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.773 ns | 0.0043 ns | 0.0038 ns |  1.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.595 ns | 0.0076 ns | 0.0071 ns |  0.90 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.664 ns | 0.0042 ns | 0.0033 ns |  0.94 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.808 ns | 0.0060 ns | 0.0056 ns |  1.02 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.571 ns | 0.0054 ns | 0.0050 ns |  0.89 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.867 ns | 0.0048 ns | 0.0040 ns |  1.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.665 ns | 0.0076 ns | 0.0071 ns |  0.89 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.606 ns | 0.0070 ns | 0.0065 ns |  0.86 |      - |     - |     - |         - |
            ToULong |        net461 |  2.358 ns | 0.0056 ns | 0.0052 ns |  1.26 |      - |     - |     - |         - |
            ToULong |        net472 |  2.345 ns | 0.0207 ns | 0.0193 ns |  1.26 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.222 ns | 0.0077 ns | 0.0072 ns |  1.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.098 ns | 0.0050 ns | 0.0046 ns |  0.94 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.258 ns | 0.0198 ns | 0.0185 ns |  1.02 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.134 ns | 0.0064 ns | 0.0057 ns |  1.41 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.053 ns | 0.0104 ns | 0.0087 ns |  1.37 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.734 ns | 0.0027 ns | 0.0024 ns |  1.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.738 ns | 0.0166 ns | 0.0155 ns |  1.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.716 ns | 0.0070 ns | 0.0065 ns |  0.99 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.439 ns | 0.0063 ns | 0.0056 ns |  0.83 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.411 ns | 0.0047 ns | 0.0044 ns |  0.81 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.499 ns | 0.0059 ns | 0.0055 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.652 ns | 0.0048 ns | 0.0040 ns |  1.03 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.480 ns | 0.0039 ns | 0.0031 ns |  1.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.915 ns | 0.0078 ns | 0.0069 ns |  1.09 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.921 ns | 0.0068 ns | 0.0063 ns |  1.09 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.638 ns | 0.0048 ns | 0.0042 ns |  1.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.781 ns | 0.0056 ns | 0.0050 ns |  1.09 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.514 ns | 0.0110 ns | 0.0092 ns |  0.92 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.175 ns | 0.0107 ns | 0.0095 ns |  0.72 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.246 ns | 0.0041 ns | 0.0038 ns |  0.76 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.890 ns | 0.0064 ns | 0.0060 ns |  1.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.817 ns | 0.0074 ns | 0.0066 ns |  0.96 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.199 ns | 0.0199 ns | 0.0186 ns |  1.16 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.635 ns | 0.0100 ns | 0.0094 ns |  1.39 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.563 ns | 0.0182 ns | 0.0170 ns |  1.36 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.114 ns | 0.0129 ns | 0.0121 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.106 ns | 0.0206 ns | 0.0193 ns |  1.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.068 ns | 0.0083 ns | 0.0069 ns |  0.99 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.780 ns | 0.0169 ns | 0.0158 ns |  1.11 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.516 ns | 0.0183 ns | 0.0171 ns |  1.07 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.705 ns | 0.0180 ns | 0.0160 ns |  1.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 19.065 ns | 0.0318 ns | 0.0282 ns |  1.02 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.357 ns | 0.1695 ns | 0.1585 ns |  0.71 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 19.078 ns | 0.1382 ns | 0.1293 ns |  1.02 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.827 ns | 0.0478 ns | 0.0447 ns |  1.01 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.335 ns | 0.0040 ns | 0.0035 ns |  1.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.315 ns | 0.0088 ns | 0.0082 ns |  0.99 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.325 ns | 0.0093 ns | 0.0087 ns |  1.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.203 ns | 0.0044 ns | 0.0041 ns |  0.52 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.138 ns | 0.0050 ns | 0.0047 ns |  0.49 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.215 ns | 0.0138 ns | 0.0122 ns |  1.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.255 ns | 0.0243 ns | 0.0215 ns |  1.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.016 ns | 0.0033 ns | 0.0027 ns |  0.25 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.472 ns | 0.0134 ns | 0.0126 ns |  1.03 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.653 ns | 0.0352 ns | 0.0329 ns |  1.05 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.976 ns | 0.0132 ns | 0.0117 ns |  1.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.531 ns | 0.0112 ns | 0.0099 ns |  1.14 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.600 ns | 0.0317 ns | 0.0296 ns |  1.16 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.877 ns | 0.0121 ns | 0.0101 ns |  0.97 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.776 ns | 0.0204 ns | 0.0181 ns |  0.95 | 0.0038 |     - |     - |      24 B |
                    |               |           |           |           |       |        |       |       |           |
          To_String | .NET Core 2.0 | 32.082 ns | 0.1691 ns | 0.1581 ns |  1.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 19.203 ns | 0.0611 ns | 0.0542 ns |  0.60 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.595 ns | 0.0328 ns | 0.0290 ns |  0.39 |      - |     - |     - |         - |
          To_String |        net461 | 33.069 ns | 0.0935 ns | 0.0875 ns |  1.03 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 33.250 ns | 0.0842 ns | 0.0658 ns |  1.04 | 0.0051 |     - |     - |      32 B |
                    |               |           |           |           |       |        |       |       |           |
             ToEnum | .NET Core 2.0 | 13.160 ns | 0.0337 ns | 0.0299 ns |  1.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.898 ns | 0.0709 ns | 0.0663 ns |  0.98 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.884 ns | 0.0257 ns | 0.0240 ns |  0.68 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.825 ns | 0.0421 ns | 0.0373 ns |  1.20 |      - |     - |     - |         - |
             ToEnum |        net472 | 16.267 ns | 0.0363 ns | 0.0340 ns |  1.24 |      - |     - |     - |         - |
                    |               |           |           |           |       |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 17.482 ns | 0.0439 ns | 0.0411 ns |  1.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 17.050 ns | 0.0391 ns | 0.0347 ns |  0.98 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.468 ns | 0.0304 ns | 0.0270 ns |  0.77 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.409 ns | 0.0403 ns | 0.0377 ns |  1.17 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.321 ns | 0.0379 ns | 0.0296 ns |  1.16 |      - |     - |     - |         - |
