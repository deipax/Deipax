
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
             ToBool | .NET Core 2.0 |  1.4046 ns | 0.0058 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.7222 ns | 0.0064 ns | 0.0060 ns |  1.23 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.8770 ns | 0.0185 ns | 0.0164 ns |  1.34 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.4314 ns | 0.0073 ns | 0.0064 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  1.4555 ns | 0.0348 ns | 0.0308 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0001 ns | 0.0087 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.0642 ns | 0.0122 ns | 0.0108 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0542 ns | 0.0368 ns | 0.0344 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2620 ns | 0.0072 ns | 0.0060 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2579 ns | 0.0427 ns | 0.0356 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.4846 ns | 0.0175 ns | 0.0164 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4803 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.0384 ns | 0.0129 ns | 0.0108 ns |  1.37 |    0.02 |     - |     - |     - |         - |
             ToChar |        net461 |  1.1937 ns | 0.0041 ns | 0.0034 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  1.1471 ns | 0.0043 ns | 0.0039 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2396 ns | 0.0153 ns | 0.0143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4832 ns | 0.0281 ns | 0.0263 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0584 ns | 0.0335 ns | 0.0313 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2565 ns | 0.0255 ns | 0.0238 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2043 ns | 0.0117 ns | 0.0110 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.7166 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6255 ns | 0.0153 ns | 0.0143 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.9405 ns | 0.0143 ns | 0.0134 ns |  1.13 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.6479 ns | 0.0045 ns | 0.0042 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.6474 ns | 0.0084 ns | 0.0079 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.5370 ns | 0.0222 ns | 0.0208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  9.5717 ns | 0.0168 ns | 0.0157 ns |  2.11 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  5.1567 ns | 0.0110 ns | 0.0102 ns |  1.14 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4387 ns | 0.0083 ns | 0.0078 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4085 ns | 0.0086 ns | 0.0081 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.7119 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.9682 ns | 0.0142 ns | 0.0126 ns |  1.15 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.7080 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  1.1849 ns | 0.0051 ns | 0.0048 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.2132 ns | 0.0061 ns | 0.0054 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.5136 ns | 0.0141 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  9.6019 ns | 0.0579 ns | 0.0542 ns |  2.13 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  5.1978 ns | 0.0166 ns | 0.0147 ns |  1.15 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4910 ns | 0.0253 ns | 0.0225 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4391 ns | 0.0147 ns | 0.0137 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.7727 ns | 0.0119 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4541 ns | 0.0097 ns | 0.0086 ns |  0.82 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.8457 ns | 0.0061 ns | 0.0054 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  1.1989 ns | 0.0078 ns | 0.0073 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.1910 ns | 0.0065 ns | 0.0058 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.5196 ns | 0.0190 ns | 0.0178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  9.5831 ns | 0.0254 ns | 0.0199 ns |  2.12 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  5.1930 ns | 0.0115 ns | 0.0102 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4428 ns | 0.0092 ns | 0.0072 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4194 ns | 0.0081 ns | 0.0076 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.7160 ns | 0.0077 ns | 0.0068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.8807 ns | 0.0238 ns | 0.0223 ns |  1.10 |    0.02 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.9528 ns | 0.0050 ns | 0.0041 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.6557 ns | 0.0048 ns | 0.0045 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.6532 ns | 0.0092 ns | 0.0082 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.5112 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  9.5723 ns | 0.0139 ns | 0.0130 ns |  2.12 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  5.1930 ns | 0.0130 ns | 0.0115 ns |  1.15 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4396 ns | 0.0087 ns | 0.0081 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4090 ns | 0.0073 ns | 0.0068 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.7607 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7253 ns | 0.0087 ns | 0.0082 ns |  0.98 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.0968 ns | 0.0083 ns | 0.0074 ns |  1.19 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.4242 ns | 0.0059 ns | 0.0049 ns |  0.81 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.4197 ns | 0.0059 ns | 0.0049 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.5415 ns | 0.0297 ns | 0.0278 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  9.5796 ns | 0.0315 ns | 0.0295 ns |  2.11 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.9316 ns | 0.0138 ns | 0.0129 ns |  1.09 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4736 ns | 0.0228 ns | 0.0190 ns |  0.99 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4133 ns | 0.0084 ns | 0.0075 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.7184 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.9166 ns | 0.0146 ns | 0.0136 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.9445 ns | 0.0127 ns | 0.0119 ns |  1.13 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.1808 ns | 0.0071 ns | 0.0063 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.2273 ns | 0.0050 ns | 0.0044 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.5127 ns | 0.0100 ns | 0.0093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  9.5687 ns | 0.0236 ns | 0.0209 ns |  2.12 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.9302 ns | 0.0099 ns | 0.0088 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4416 ns | 0.0120 ns | 0.0106 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4117 ns | 0.0127 ns | 0.0119 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.7742 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.8643 ns | 0.0068 ns | 0.0060 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.9142 ns | 0.0170 ns | 0.0159 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  1.6743 ns | 0.0107 ns | 0.0089 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.6523 ns | 0.0039 ns | 0.0037 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.6214 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3494 ns | 0.0206 ns | 0.0193 ns |  0.90 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.3976 ns | 0.0066 ns | 0.0058 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.6648 ns | 0.0080 ns | 0.0075 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.5601 ns | 0.0066 ns | 0.0059 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.7011 ns | 0.0130 ns | 0.0121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.7051 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  2.0948 ns | 0.0125 ns | 0.0117 ns |  1.23 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  1.6744 ns | 0.0084 ns | 0.0070 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  1.6681 ns | 0.0048 ns | 0.0045 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.5493 ns | 0.0338 ns | 0.0316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.3767 ns | 0.0119 ns | 0.0111 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.5184 ns | 0.0108 ns | 0.0096 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.6863 ns | 0.0121 ns | 0.0108 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.6392 ns | 0.0098 ns | 0.0092 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7688 ns | 0.0095 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.9034 ns | 0.0067 ns | 0.0063 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.8383 ns | 0.0114 ns | 0.0107 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.1611 ns | 0.0064 ns | 0.0054 ns |  0.66 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.1995 ns | 0.0211 ns | 0.0197 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.5074 ns | 0.0120 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  9.9222 ns | 0.0411 ns | 0.0364 ns |  2.20 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.9951 ns | 0.0303 ns | 0.0283 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6998 ns | 0.0168 ns | 0.0157 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6396 ns | 0.0075 ns | 0.0070 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6845 ns | 0.0143 ns | 0.0134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.9201 ns | 0.0182 ns | 0.0171 ns |  1.14 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  2.0589 ns | 0.0053 ns | 0.0047 ns |  1.22 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.4137 ns | 0.0049 ns | 0.0046 ns |  0.84 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.4267 ns | 0.0056 ns | 0.0049 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.8285 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.8255 ns | 0.0106 ns | 0.0089 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.3725 ns | 0.0163 ns | 0.0153 ns |  0.84 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.4347 ns | 0.0193 ns | 0.0161 ns |  0.86 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.2791 ns | 0.0093 ns | 0.0087 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.5790 ns | 0.0065 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.3631 ns | 0.0058 ns | 0.0048 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.4749 ns | 0.0102 ns | 0.0095 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.3645 ns | 0.0641 ns | 0.0600 ns |  2.47 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0511 ns | 0.0150 ns | 0.0140 ns |  2.35 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.1287 ns | 0.0184 ns | 0.0163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  8.7154 ns | 0.0238 ns | 0.0211 ns |  0.86 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3630 ns | 0.0330 ns | 0.0308 ns |  0.23 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 12.2811 ns | 0.0488 ns | 0.0456 ns |  1.21 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7979 ns | 0.0837 ns | 0.0783 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.8687 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.8305 ns | 0.0101 ns | 0.0089 ns |  0.99 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.5578 ns | 0.0136 ns | 0.0121 ns |  0.89 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.7235 ns | 0.0061 ns | 0.0057 ns |  0.60 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.6137 ns | 0.0116 ns | 0.0108 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.2361 ns | 0.0267 ns | 0.0223 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5542 ns | 0.0332 ns | 0.0310 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.6616 ns | 0.0105 ns | 0.0098 ns |  0.32 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4720 ns | 0.0292 ns | 0.0273 ns |  1.03 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.5081 ns | 0.0244 ns | 0.0216 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4627 ns | 0.0051 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  0.9686 ns | 0.0058 ns | 0.0048 ns |  0.66 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.1610 ns | 0.0049 ns | 0.0046 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  1.1843 ns | 0.0101 ns | 0.0094 ns |  0.81 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  1.1854 ns | 0.0030 ns | 0.0026 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.1817 ns | 0.0044 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.1937 ns | 0.0087 ns | 0.0082 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.1564 ns | 0.0120 ns | 0.0113 ns |  0.98 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  0.7141 ns | 0.0041 ns | 0.0036 ns |  0.60 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  0.7196 ns | 0.0042 ns | 0.0037 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.7108 ns | 0.0143 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4949 ns | 0.0081 ns | 0.0075 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.9998 ns | 0.0581 ns | 0.0543 ns |  1.17 |    0.03 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.4279 ns | 0.0021 ns | 0.0018 ns |  0.84 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.4437 ns | 0.0034 ns | 0.0028 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.0407 ns | 0.0117 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4737 ns | 0.0108 ns | 0.0101 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0476 ns | 0.0125 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.4505 ns | 0.0243 ns | 0.0203 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.4608 ns | 0.0257 ns | 0.0240 ns |  1.10 |    0.01 |     - |     - |     - |         - |
