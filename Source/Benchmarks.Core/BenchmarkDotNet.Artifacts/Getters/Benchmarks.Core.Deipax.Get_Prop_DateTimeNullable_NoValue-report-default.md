
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
             ToBool | .NET Core 2.0 |  0.9583 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.5128 ns | 0.0564 ns | 0.0554 ns |  1.58 |    0.06 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1407 ns | 0.0050 ns | 0.0044 ns |  1.19 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.7187 ns | 0.0054 ns | 0.0051 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.4877 ns | 0.0061 ns | 0.0054 ns |  0.51 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  9.7202 ns | 0.0471 ns | 0.0441 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 10.2693 ns | 0.0261 ns | 0.0232 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.9286 ns | 0.0899 ns | 0.0841 ns |  0.51 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 | 10.2522 ns | 0.0171 ns | 0.0152 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 | 10.2394 ns | 0.0182 ns | 0.0170 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.1185 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.4049 ns | 0.0057 ns | 0.0051 ns |  2.15 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1111 ns | 0.0099 ns | 0.0092 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9396 ns | 0.0041 ns | 0.0034 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.6759 ns | 0.0159 ns | 0.0149 ns |  0.60 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  9.6322 ns | 0.0146 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 | 10.2851 ns | 0.0197 ns | 0.0184 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7338 ns | 0.0132 ns | 0.0123 ns |  0.49 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 | 10.2444 ns | 0.0216 ns | 0.0191 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 | 10.2360 ns | 0.0257 ns | 0.0228 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  0.9601 ns | 0.0062 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.1862 ns | 0.0039 ns | 0.0032 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.3464 ns | 0.0055 ns | 0.0051 ns |  1.40 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.7204 ns | 0.0074 ns | 0.0065 ns |  0.75 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.5415 ns | 0.0044 ns | 0.0041 ns |  0.56 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 10.8830 ns | 0.0222 ns | 0.0208 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 10.2786 ns | 0.0206 ns | 0.0193 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.7565 ns | 0.0207 ns | 0.0183 ns |  0.44 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 10.2448 ns | 0.0200 ns | 0.0177 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 10.2474 ns | 0.0248 ns | 0.0232 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.0980 ns | 0.0042 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4221 ns | 0.0085 ns | 0.0075 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3651 ns | 0.0048 ns | 0.0042 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9654 ns | 0.0057 ns | 0.0053 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.6745 ns | 0.0208 ns | 0.0184 ns |  0.61 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 | 10.0977 ns | 0.0192 ns | 0.0170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 10.3811 ns | 0.0559 ns | 0.0496 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.9534 ns | 0.0692 ns | 0.0613 ns |  0.49 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 10.2317 ns | 0.0190 ns | 0.0178 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 10.2451 ns | 0.0147 ns | 0.0123 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.0012 ns | 0.0230 ns | 0.0215 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.2421 ns | 0.0037 ns | 0.0033 ns |  1.24 |    0.03 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.1444 ns | 0.0073 ns | 0.0065 ns |  1.14 |    0.03 |     - |     - |     - |         - |
            ToShort |        net461 |  0.7225 ns | 0.0060 ns | 0.0056 ns |  0.72 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  0.4836 ns | 0.0037 ns | 0.0031 ns |  0.48 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  9.7269 ns | 0.0379 ns | 0.0355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 10.2741 ns | 0.0163 ns | 0.0153 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.7019 ns | 0.0149 ns | 0.0125 ns |  0.48 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 10.2521 ns | 0.0167 ns | 0.0156 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 10.2531 ns | 0.0226 ns | 0.0211 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.8759 ns | 0.0056 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4398 ns | 0.0050 ns | 0.0044 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.1380 ns | 0.0046 ns | 0.0043 ns |  0.61 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9410 ns | 0.0029 ns | 0.0028 ns |  0.50 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.6599 ns | 0.0053 ns | 0.0049 ns |  0.35 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  9.8588 ns | 0.0182 ns | 0.0152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 10.3869 ns | 0.0429 ns | 0.0401 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.7113 ns | 0.0281 ns | 0.0219 ns |  0.48 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 10.2420 ns | 0.0180 ns | 0.0160 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 10.2433 ns | 0.0286 ns | 0.0239 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  0.9610 ns | 0.0040 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.3607 ns | 0.0042 ns | 0.0037 ns |  2.46 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2057 ns | 0.0052 ns | 0.0046 ns |  1.26 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.7207 ns | 0.0041 ns | 0.0037 ns |  0.75 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  5.8270 ns | 0.0475 ns | 0.0445 ns |  6.06 |    0.05 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 | 10.1057 ns | 0.0140 ns | 0.0131 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 10.2882 ns | 0.0179 ns | 0.0158 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.7009 ns | 0.0118 ns | 0.0104 ns |  0.47 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 10.2272 ns | 0.0160 ns | 0.0150 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 10.2317 ns | 0.0168 ns | 0.0157 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.1885 ns | 0.0034 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4203 ns | 0.0070 ns | 0.0062 ns |  1.20 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2298 ns | 0.0048 ns | 0.0043 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9821 ns | 0.0106 ns | 0.0094 ns |  0.83 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  5.7993 ns | 0.0076 ns | 0.0068 ns |  4.88 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  9.8695 ns | 0.0155 ns | 0.0145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 10.2690 ns | 0.0204 ns | 0.0181 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.8849 ns | 0.1149 ns | 0.1018 ns |  0.50 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 10.2434 ns | 0.0214 ns | 0.0200 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 10.2584 ns | 0.0294 ns | 0.0275 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.0302 ns | 0.0165 ns | 0.0154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1904 ns | 0.0052 ns | 0.0049 ns |  1.16 |    0.02 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.1456 ns | 0.0105 ns | 0.0093 ns |  1.11 |    0.02 |     - |     - |     - |         - |
             ToLong |        net461 |  0.7175 ns | 0.0031 ns | 0.0029 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  0.4880 ns | 0.0109 ns | 0.0096 ns |  0.47 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.7743 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8050 ns | 0.0064 ns | 0.0057 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.8979 ns | 0.0045 ns | 0.0038 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  6.9616 ns | 0.0077 ns | 0.0072 ns |  3.92 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.6469 ns | 0.0072 ns | 0.0063 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.1679 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2218 ns | 0.0049 ns | 0.0046 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.1560 ns | 0.0101 ns | 0.0089 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9165 ns | 0.0041 ns | 0.0038 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.4842 ns | 0.0056 ns | 0.0050 ns |  0.41 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.7103 ns | 0.0052 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.9321 ns | 0.0089 ns | 0.0079 ns |  1.13 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7086 ns | 0.0093 ns | 0.0078 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.6378 ns | 0.0035 ns | 0.0032 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.0213 ns | 0.0141 ns | 0.0125 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.2043 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4204 ns | 0.0050 ns | 0.0044 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1315 ns | 0.0035 ns | 0.0031 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  5.8388 ns | 0.0061 ns | 0.0054 ns |  4.85 |    0.02 |     - |     - |     - |         - |
            ToFloat |        net472 |  0.6491 ns | 0.0033 ns | 0.0029 ns |  0.54 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  9.8604 ns | 0.0163 ns | 0.0153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 10.2749 ns | 0.0192 ns | 0.0180 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.7026 ns | 0.0092 ns | 0.0086 ns |  0.48 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 10.2398 ns | 0.0115 ns | 0.0107 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 10.2460 ns | 0.0166 ns | 0.0155 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.2063 ns | 0.0050 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2126 ns | 0.0062 ns | 0.0055 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1335 ns | 0.0063 ns | 0.0052 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.7413 ns | 0.0020 ns | 0.0018 ns |  0.61 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.5408 ns | 0.0043 ns | 0.0036 ns |  0.45 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.8411 ns | 0.0348 ns | 0.0326 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.7695 ns | 0.0114 ns | 0.0107 ns |  0.96 |    0.02 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.8716 ns | 0.0172 ns | 0.0161 ns |  1.02 |    0.02 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6379 ns | 0.0050 ns | 0.0044 ns |  0.89 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6429 ns | 0.0049 ns | 0.0043 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  8.9275 ns | 0.0221 ns | 0.0207 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  8.8071 ns | 0.0209 ns | 0.0195 ns |  0.99 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.7687 ns | 0.0053 ns | 0.0044 ns |  0.31 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 | 11.2012 ns | 0.0236 ns | 0.0221 ns |  1.25 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 | 11.1985 ns | 0.0318 ns | 0.0266 ns |  1.25 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.6993 ns | 0.0291 ns | 0.0258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  2.0359 ns | 0.0054 ns | 0.0048 ns |  1.20 |    0.02 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.8894 ns | 0.0059 ns | 0.0053 ns |  1.11 |    0.02 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.8182 ns | 0.0072 ns | 0.0064 ns |  1.07 |    0.02 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.6721 ns | 0.0185 ns | 0.0164 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3834 ns | 0.0081 ns | 0.0072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.6376 ns | 0.0096 ns | 0.0090 ns |  1.11 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.5881 ns | 0.0099 ns | 0.0088 ns |  1.09 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.6252 ns | 0.0032 ns | 0.0028 ns |  0.68 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.3781 ns | 0.0051 ns | 0.0045 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  1.7392 ns | 0.0052 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  1.9722 ns | 0.0054 ns | 0.0048 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8127 ns | 0.0042 ns | 0.0035 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  1.5680 ns | 0.0058 ns | 0.0051 ns |  0.90 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  1.4766 ns | 0.0177 ns | 0.0165 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2414 ns | 0.0074 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  2.0609 ns | 0.0665 ns | 0.0765 ns |  1.67 |    0.07 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.5845 ns | 0.0122 ns | 0.0108 ns |  1.28 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9916 ns | 0.0035 ns | 0.0030 ns |  0.80 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9607 ns | 0.0037 ns | 0.0031 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4051 ns | 0.0026 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6473 ns | 0.0123 ns | 0.0109 ns |  1.17 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.6103 ns | 0.0071 ns | 0.0063 ns |  1.14 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.4771 ns | 0.0063 ns | 0.0059 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.4476 ns | 0.0042 ns | 0.0038 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4220 ns | 0.0046 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6428 ns | 0.0057 ns | 0.0053 ns |  1.16 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.6018 ns | 0.0040 ns | 0.0033 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.4917 ns | 0.0154 ns | 0.0144 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.4481 ns | 0.0189 ns | 0.0177 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  9.8275 ns | 0.0273 ns | 0.0242 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 10.2848 ns | 0.0151 ns | 0.0142 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.7155 ns | 0.0349 ns | 0.0327 ns |  0.48 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 10.0033 ns | 0.0144 ns | 0.0128 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 10.0085 ns | 0.0141 ns | 0.0118 ns |  1.02 |    0.00 |     - |     - |     - |         - |
