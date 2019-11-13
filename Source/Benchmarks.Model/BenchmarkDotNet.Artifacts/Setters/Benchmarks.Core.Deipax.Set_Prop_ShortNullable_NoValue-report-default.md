
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9101 ns | 0.0183 ns | 0.0172 ns |  0.9187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6740 ns | 0.0128 ns | 0.0119 ns |  0.6771 ns |  0.74 |    0.02 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9407 ns | 0.0204 ns | 0.0191 ns |  0.9431 ns |  1.03 |    0.03 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9390 ns | 0.0123 ns | 0.0115 ns |  0.9432 ns |  1.03 |    0.03 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9348 ns | 0.0125 ns | 0.0117 ns |  0.9346 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1549 ns | 0.0141 ns | 0.0132 ns |  1.1505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9133 ns | 0.0127 ns | 0.0119 ns |  0.9171 ns |  0.79 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1373 ns | 0.0482 ns | 0.0676 ns |  1.1390 ns |  0.99 |    0.06 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0638 ns | 0.0260 ns | 0.0243 ns |  2.0478 ns |  1.79 |    0.03 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9494 ns | 0.0204 ns | 0.0191 ns |  1.9458 ns |  1.69 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3207 ns | 0.0165 ns | 0.0155 ns |  1.3291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.3691 ns | 0.0161 ns | 0.0151 ns |  1.3753 ns |  1.04 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6470 ns | 0.0104 ns | 0.0097 ns |  0.6522 ns |  0.49 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7765 ns | 0.0166 ns | 0.0155 ns |  1.7741 ns |  1.35 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  1.7910 ns | 0.0258 ns | 0.0241 ns |  1.7941 ns |  1.36 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.8542 ns | 0.0260 ns | 0.0243 ns |  1.8564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7311 ns | 0.0249 ns | 0.0233 ns |  1.7290 ns |  0.93 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1001 ns | 0.0116 ns | 0.0109 ns |  1.1007 ns |  0.59 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9523 ns | 0.0222 ns | 0.0208 ns |  1.9422 ns |  1.05 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9230 ns | 0.0165 ns | 0.0154 ns |  1.9194 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6958 ns | 0.0117 ns | 0.0110 ns |  0.7015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6763 ns | 0.0109 ns | 0.0102 ns |  0.6760 ns |  0.97 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5978 ns | 0.0229 ns | 0.0203 ns |  0.5903 ns |  0.86 |    0.04 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7083 ns | 0.0131 ns | 0.0122 ns |  0.7027 ns |  1.02 |    0.03 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7268 ns | 0.0136 ns | 0.0127 ns |  0.7258 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1544 ns | 0.0207 ns | 0.0194 ns |  1.1507 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9175 ns | 0.0206 ns | 0.0193 ns |  0.9198 ns |  0.80 |    0.03 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9758 ns | 0.0185 ns | 0.0173 ns |  0.9773 ns |  0.85 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9606 ns | 0.0165 ns | 0.0146 ns |  1.9645 ns |  1.70 |    0.04 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9598 ns | 0.0181 ns | 0.0170 ns |  1.9679 ns |  1.70 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9858 ns | 0.0185 ns | 0.0173 ns |  0.9946 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5602 ns | 0.0113 ns | 0.0106 ns |  0.5663 ns |  0.57 |    0.02 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7442 ns | 0.0124 ns | 0.0116 ns |  0.7401 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7201 ns | 0.0130 ns | 0.0121 ns |  0.7256 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7363 ns | 0.0140 ns | 0.0124 ns |  0.7401 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1534 ns | 0.0139 ns | 0.0130 ns |  1.1559 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9257 ns | 0.0140 ns | 0.0131 ns |  0.9197 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9677 ns | 0.0111 ns | 0.0104 ns |  0.9626 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9461 ns | 0.0179 ns | 0.0168 ns |  1.9409 ns |  1.69 |    0.03 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9403 ns | 0.0146 ns | 0.0122 ns |  1.9445 ns |  1.69 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7025 ns | 0.0103 ns | 0.0096 ns |  0.6974 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7415 ns | 0.0205 ns | 0.0192 ns |  0.7399 ns |  1.06 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6004 ns | 0.0193 ns | 0.0180 ns |  0.6011 ns |  0.85 |    0.03 |     - |     - |     - |         - |
            FromShort |        net461 |  0.7128 ns | 0.0137 ns | 0.0129 ns |  0.7090 ns |  1.01 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7039 ns | 0.0094 ns | 0.0083 ns |  0.7015 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.6922 ns | 0.0120 ns | 0.0112 ns |  0.6868 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.6051 ns | 0.0120 ns | 0.0113 ns |  0.6121 ns |  0.87 |    0.03 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  0.9394 ns | 0.0189 ns | 0.0177 ns |  0.9428 ns |  1.36 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  0.7016 ns | 0.0109 ns | 0.0101 ns |  0.7023 ns |  1.01 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  0.7297 ns | 0.0158 ns | 0.0148 ns |  0.7271 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.3585 ns | 0.0215 ns | 0.0201 ns |  1.3615 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.4464 ns | 0.0175 ns | 0.0163 ns |  1.4563 ns |  1.06 |    0.02 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6549 ns | 0.0123 ns | 0.0115 ns |  0.6571 ns |  0.48 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7813 ns | 0.0182 ns | 0.0171 ns |  1.7825 ns |  1.31 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.7818 ns | 0.0157 ns | 0.0147 ns |  1.7890 ns |  1.31 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.8625 ns | 0.0156 ns | 0.0146 ns |  1.8620 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.9232 ns | 0.0238 ns | 0.0223 ns |  1.9166 ns |  1.03 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1944 ns | 0.0161 ns | 0.0150 ns |  1.1911 ns |  0.64 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9158 ns | 0.0191 ns | 0.0178 ns |  1.9151 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9493 ns | 0.0398 ns | 0.0373 ns |  1.9358 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8630 ns | 0.0246 ns | 0.0231 ns |  1.8548 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8013 ns | 0.0193 ns | 0.0181 ns |  1.7888 ns |  0.97 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.7122 ns | 0.0140 ns | 0.0131 ns |  1.7106 ns |  0.92 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7712 ns | 0.0172 ns | 0.0161 ns |  1.7720 ns |  0.95 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7785 ns | 0.0158 ns | 0.0148 ns |  1.7796 ns |  0.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8434 ns | 0.0169 ns | 0.0158 ns |  1.8445 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.7309 ns | 0.0200 ns | 0.0187 ns |  1.7338 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.9147 ns | 0.0199 ns | 0.0187 ns |  1.9207 ns |  1.04 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9681 ns | 0.0865 ns | 0.0850 ns |  1.9338 ns |  1.07 |    0.05 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9275 ns | 0.0169 ns | 0.0158 ns |  1.9238 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.8428 ns | 0.0288 ns | 0.0270 ns |  1.8438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.8137 ns | 0.0225 ns | 0.0210 ns |  1.8100 ns |  0.98 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  1.7201 ns | 0.0150 ns | 0.0140 ns |  1.7201 ns |  0.93 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7887 ns | 0.0127 ns | 0.0119 ns |  1.7932 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7635 ns | 0.0283 ns | 0.0265 ns |  1.7666 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.8448 ns | 0.0202 ns | 0.0189 ns |  1.8453 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.7555 ns | 0.0170 ns | 0.0159 ns |  1.7579 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.7480 ns | 0.0153 ns | 0.0143 ns |  1.7563 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.1552 ns | 0.0182 ns | 0.0170 ns |  2.1602 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9213 ns | 0.0170 ns | 0.0159 ns |  1.9265 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8492 ns | 0.0274 ns | 0.0256 ns |  1.8526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  2.1287 ns | 0.0262 ns | 0.0245 ns |  2.1302 ns |  1.15 |    0.02 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  2.0296 ns | 0.0206 ns | 0.0193 ns |  2.0257 ns |  1.10 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7696 ns | 0.0192 ns | 0.0180 ns |  1.7609 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8516 ns | 0.0208 ns | 0.0195 ns |  1.8407 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.8106 ns | 0.0138 ns | 0.0129 ns |  1.8050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.8735 ns | 0.0248 ns | 0.0232 ns |  1.8770 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7901 ns | 0.0182 ns | 0.0170 ns |  1.7972 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.9936 ns | 0.0172 ns | 0.0152 ns |  1.9956 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.2155 ns | 0.0199 ns | 0.0186 ns |  2.2120 ns |  1.22 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9108 ns | 0.0175 ns | 0.0163 ns |  1.9074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7332 ns | 0.0212 ns | 0.0188 ns |  1.7341 ns |  0.91 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6950 ns | 0.0236 ns | 0.0221 ns |  1.6972 ns |  0.89 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  2.2026 ns | 0.0553 ns | 0.0517 ns |  2.2056 ns |  1.15 |    0.03 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8123 ns | 0.0162 ns | 0.0144 ns |  1.8126 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.8267 ns | 0.0290 ns | 0.0271 ns |  1.8241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7347 ns | 0.0176 ns | 0.0165 ns |  1.7335 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7864 ns | 0.0228 ns | 0.0214 ns |  1.7874 ns |  0.98 |    0.02 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.0411 ns | 0.0172 ns | 0.0161 ns |  2.0433 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.0003 ns | 0.0245 ns | 0.0229 ns |  1.9942 ns |  1.10 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.9130 ns | 0.0275 ns | 0.0258 ns |  3.9105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8724 ns | 0.0393 ns | 0.0368 ns |  3.8856 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.3801 ns | 0.0370 ns | 0.0346 ns |  4.3954 ns |  1.12 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9536 ns | 0.0241 ns | 0.0226 ns |  3.9571 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.9499 ns | 0.0240 ns | 0.0225 ns |  3.9536 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8924 ns | 0.0151 ns | 0.0141 ns |  1.8884 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7994 ns | 0.0173 ns | 0.0162 ns |  1.7915 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7293 ns | 0.0177 ns | 0.0166 ns |  1.7363 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9430 ns | 0.0216 ns | 0.0202 ns |  1.9426 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9353 ns | 0.0167 ns | 0.0156 ns |  1.9391 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.9209 ns | 0.0355 ns | 0.0332 ns |  3.9064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9796 ns | 0.0295 ns | 0.0276 ns |  3.9930 ns |  1.02 |    0.02 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.2956 ns | 0.0273 ns | 0.0255 ns |  4.3098 ns |  1.10 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4410 ns | 0.0236 ns | 0.0220 ns |  3.4376 ns |  0.88 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4180 ns | 0.0248 ns | 0.0232 ns |  3.4176 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9040 ns | 0.0228 ns | 0.0214 ns |  1.9103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9118 ns | 0.0204 ns | 0.0191 ns |  1.9147 ns |  1.00 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9500 ns | 0.0169 ns | 0.0158 ns |  1.9488 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  9.7294 ns | 0.0345 ns | 0.0322 ns |  9.7160 ns |  5.11 |    0.06 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.0910 ns | 0.0194 ns | 0.0181 ns |  2.0895 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.8128 ns | 0.0902 ns | 0.0843 ns | 13.7815 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.9986 ns | 0.0939 ns | 0.0879 ns | 13.9538 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  7.0247 ns | 0.0403 ns | 0.0377 ns |  7.0119 ns |  0.51 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.2157 ns | 0.0991 ns | 0.0927 ns | 14.1665 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.2589 ns | 0.0954 ns | 0.0892 ns | 14.2763 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.3061 ns | 0.0897 ns | 0.0839 ns |  8.3324 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.7630 ns | 0.0602 ns | 0.0563 ns |  8.7751 ns |  1.06 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.6009 ns | 0.0204 ns | 0.0191 ns |  2.5936 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.7386 ns | 0.0654 ns | 0.0612 ns |  8.7109 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.7545 ns | 0.0552 ns | 0.0517 ns |  8.7460 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9244 ns | 0.0133 ns | 0.0124 ns |  0.9211 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.9457 ns | 0.0189 ns | 0.0176 ns |  0.9461 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6807 ns | 0.0118 ns | 0.0110 ns |  0.6794 ns |  0.74 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9720 ns | 0.0130 ns | 0.0122 ns |  0.9709 ns |  1.05 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9788 ns | 0.0131 ns | 0.0123 ns |  0.9836 ns |  1.06 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4853 ns | 0.0140 ns | 0.0131 ns |  1.4863 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  2.0427 ns | 0.0657 ns | 0.0921 ns |  2.0538 ns |  1.39 |    0.06 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4646 ns | 0.0158 ns | 0.0148 ns |  1.4706 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6291 ns | 0.0200 ns | 0.0187 ns |  1.6269 ns |  1.10 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6467 ns | 0.0192 ns | 0.0180 ns |  1.6406 ns |  1.11 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0522 ns | 0.0210 ns | 0.0197 ns |  3.0609 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8658 ns | 0.0242 ns | 0.0227 ns |  2.8558 ns |  0.94 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7850 ns | 0.0350 ns | 0.0328 ns |  2.7660 ns |  0.91 |    0.02 |     - |     - |     - |         - |
           FromObject |        net461 |  3.3283 ns | 0.0315 ns | 0.0295 ns |  3.3293 ns |  1.09 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.9131 ns | 0.0209 ns | 0.0195 ns |  2.9013 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8491 ns | 0.0261 ns | 0.0244 ns |  1.8551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.9089 ns | 0.0242 ns | 0.0226 ns |  1.9111 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9688 ns | 0.0157 ns | 0.0147 ns |  1.9779 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 |  1.8156 ns | 0.0153 ns | 0.0143 ns |  1.8237 ns |  0.98 |    0.02 |     - |     - |     - |         - |
           FromString |        net472 |  1.8364 ns | 0.0290 ns | 0.0272 ns |  1.8228 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8808 ns | 0.0187 ns | 0.0175 ns |  1.8845 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  2.3559 ns | 0.0219 ns | 0.0205 ns |  2.3463 ns |  1.25 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.9342 ns | 0.0165 ns | 0.0155 ns |  1.9309 ns |  1.03 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.9767 ns | 0.0224 ns | 0.0199 ns |  1.9786 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  2.1779 ns | 0.0692 ns | 0.1247 ns |  2.1732 ns |  1.15 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8474 ns | 0.0194 ns | 0.0182 ns |  1.8438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.7595 ns | 0.0173 ns | 0.0162 ns |  1.7570 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.7301 ns | 0.0166 ns | 0.0155 ns |  1.7324 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9174 ns | 0.0216 ns | 0.0192 ns |  1.9216 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9282 ns | 0.0221 ns | 0.0207 ns |  1.9295 ns |  1.04 |    0.02 |     - |     - |     - |         - |
