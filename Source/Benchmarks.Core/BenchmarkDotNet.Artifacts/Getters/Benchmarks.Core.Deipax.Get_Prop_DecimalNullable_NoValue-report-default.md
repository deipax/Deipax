
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
             ToBool | .NET Core 2.0 |  9.3734 ns | 0.0282 ns | 0.0264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 | 10.0332 ns | 0.0250 ns | 0.0233 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.6041 ns | 0.0051 ns | 0.0047 ns |  0.17 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 | 10.1218 ns | 0.0261 ns | 0.0244 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 | 10.0810 ns | 0.0185 ns | 0.0173 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  9.8190 ns | 0.0153 ns | 0.0136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 10.0374 ns | 0.0199 ns | 0.0186 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  5.1512 ns | 0.0100 ns | 0.0088 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 | 10.1972 ns | 0.0149 ns | 0.0132 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 | 10.0306 ns | 0.0233 ns | 0.0218 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  0.8761 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2049 ns | 0.0038 ns | 0.0033 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1380 ns | 0.0060 ns | 0.0056 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.7241 ns | 0.0026 ns | 0.0023 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.4469 ns | 0.0039 ns | 0.0037 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0360 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2471 ns | 0.0161 ns | 0.0134 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9966 ns | 0.0097 ns | 0.0086 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1798 ns | 0.0109 ns | 0.0102 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2098 ns | 0.0057 ns | 0.0051 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  9.4046 ns | 0.0183 ns | 0.0171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 10.0386 ns | 0.0209 ns | 0.0186 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6042 ns | 0.0317 ns | 0.0297 ns |  0.17 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 | 10.0970 ns | 0.0145 ns | 0.0121 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 | 10.0759 ns | 0.0219 ns | 0.0194 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 10.0465 ns | 0.0136 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 10.2203 ns | 0.0138 ns | 0.0122 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  5.1494 ns | 0.0078 ns | 0.0069 ns |  0.51 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  9.9988 ns | 0.0233 ns | 0.0195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 10.2363 ns | 0.0267 ns | 0.0236 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  9.3480 ns | 0.0146 ns | 0.0136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 11.6660 ns | 0.0163 ns | 0.0153 ns |  1.25 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5786 ns | 0.0037 ns | 0.0029 ns |  0.17 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 | 10.0916 ns | 0.0158 ns | 0.0140 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 | 10.1789 ns | 0.0413 ns | 0.0387 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 | 10.0655 ns | 0.0365 ns | 0.0342 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 10.0326 ns | 0.0222 ns | 0.0197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  5.1483 ns | 0.0086 ns | 0.0080 ns |  0.51 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 10.2808 ns | 0.0585 ns | 0.0518 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 10.0334 ns | 0.0264 ns | 0.0247 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  9.3548 ns | 0.0214 ns | 0.0200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 10.0285 ns | 0.0189 ns | 0.0148 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6058 ns | 0.0033 ns | 0.0031 ns |  0.17 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 | 10.1169 ns | 0.0214 ns | 0.0167 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 | 10.0945 ns | 0.0103 ns | 0.0092 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  9.8090 ns | 0.0205 ns | 0.0171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 10.0487 ns | 0.0237 ns | 0.0221 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  5.1571 ns | 0.0181 ns | 0.0160 ns |  0.53 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 10.2762 ns | 0.0332 ns | 0.0310 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 10.0071 ns | 0.0154 ns | 0.0120 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  9.3981 ns | 0.0186 ns | 0.0155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 10.0371 ns | 0.0241 ns | 0.0213 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.6011 ns | 0.0033 ns | 0.0029 ns |  0.17 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 | 10.0991 ns | 0.0223 ns | 0.0209 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 | 10.0830 ns | 0.0171 ns | 0.0142 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  9.9239 ns | 0.0141 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 10.2450 ns | 0.0172 ns | 0.0161 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  5.1621 ns | 0.0075 ns | 0.0067 ns |  0.52 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  9.9815 ns | 0.0288 ns | 0.0269 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 10.2345 ns | 0.0230 ns | 0.0215 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  9.4005 ns | 0.0185 ns | 0.0173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 10.0364 ns | 0.0266 ns | 0.0236 ns |  1.07 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.7526 ns | 0.0037 ns | 0.0032 ns |  0.19 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 | 11.6750 ns | 0.0246 ns | 0.0206 ns |  1.24 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 | 10.0646 ns | 0.0194 ns | 0.0181 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 | 10.0480 ns | 0.0209 ns | 0.0196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 10.2392 ns | 0.0172 ns | 0.0161 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  5.1571 ns | 0.0090 ns | 0.0085 ns |  0.51 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  9.9863 ns | 0.0222 ns | 0.0208 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 10.3322 ns | 0.0112 ns | 0.0099 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  9.3815 ns | 0.0181 ns | 0.0170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 10.0397 ns | 0.0283 ns | 0.0250 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5826 ns | 0.0061 ns | 0.0057 ns |  0.17 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 | 10.1661 ns | 0.0337 ns | 0.0315 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 | 10.0496 ns | 0.0182 ns | 0.0161 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 10.0785 ns | 0.0599 ns | 0.0531 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 10.1186 ns | 0.0531 ns | 0.0470 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  5.1489 ns | 0.0085 ns | 0.0080 ns |  0.51 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 10.1942 ns | 0.0217 ns | 0.0192 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 10.0327 ns | 0.0214 ns | 0.0190 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  9.3827 ns | 0.0276 ns | 0.0258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 10.0282 ns | 0.0233 ns | 0.0218 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.8559 ns | 0.0095 ns | 0.0084 ns |  0.20 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 | 10.0722 ns | 0.0229 ns | 0.0203 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 | 11.6700 ns | 0.0227 ns | 0.0212 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  8.6677 ns | 0.0180 ns | 0.0160 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  8.7372 ns | 0.0295 ns | 0.0261 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.3642 ns | 0.0063 ns | 0.0052 ns |  0.27 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  8.9538 ns | 0.0215 ns | 0.0201 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  9.3108 ns | 0.0239 ns | 0.0224 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  9.6622 ns | 0.0683 ns | 0.0639 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 11.6701 ns | 0.0320 ns | 0.0284 ns |  1.21 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.8748 ns | 0.0187 ns | 0.0175 ns |  0.19 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 | 10.0724 ns | 0.0142 ns | 0.0126 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 | 10.1667 ns | 0.0277 ns | 0.0246 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  8.7419 ns | 0.0210 ns | 0.0186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  8.6451 ns | 0.0197 ns | 0.0175 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  3.1390 ns | 0.0896 ns | 0.1197 ns |  0.36 |    0.02 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  8.8567 ns | 0.0316 ns | 0.0296 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  8.8497 ns | 0.0214 ns | 0.0200 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 | 10.9768 ns | 0.0252 ns | 0.0224 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 11.6626 ns | 0.0157 ns | 0.0131 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.9378 ns | 0.0105 ns | 0.0093 ns |  0.18 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 | 10.1026 ns | 0.0457 ns | 0.0382 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 | 10.0619 ns | 0.0195 ns | 0.0183 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 10.0592 ns | 0.0262 ns | 0.0232 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 10.2592 ns | 0.0516 ns | 0.0457 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  5.1580 ns | 0.0061 ns | 0.0054 ns |  0.51 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  9.9732 ns | 0.0198 ns | 0.0185 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 10.2162 ns | 0.0154 ns | 0.0144 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  9.3386 ns | 0.0157 ns | 0.0139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 10.1068 ns | 0.0118 ns | 0.0098 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6098 ns | 0.0254 ns | 0.0225 ns |  0.17 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 | 10.0844 ns | 0.0330 ns | 0.0293 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 | 10.0632 ns | 0.0266 ns | 0.0236 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  8.8616 ns | 0.0528 ns | 0.0468 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  8.6962 ns | 0.0207 ns | 0.0184 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.4204 ns | 0.0084 ns | 0.0074 ns |  0.27 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  8.7691 ns | 0.0306 ns | 0.0271 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  9.0085 ns | 0.0114 ns | 0.0101 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2314 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1177 ns | 0.0041 ns | 0.0036 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.8412 ns | 0.0049 ns | 0.0043 ns |  0.83 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  2.0885 ns | 0.0066 ns | 0.0062 ns |  0.94 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 |  2.1232 ns | 0.0081 ns | 0.0063 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.4610 ns | 0.0066 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  2.0002 ns | 0.0024 ns | 0.0019 ns |  1.37 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.9745 ns | 0.0645 ns | 0.0690 ns |  1.35 |    0.05 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.5609 ns | 0.0049 ns | 0.0046 ns |  1.07 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.6800 ns | 0.0096 ns | 0.0089 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0848 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1955 ns | 0.0039 ns | 0.0035 ns |  1.05 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3171 ns | 0.0176 ns | 0.0165 ns |  1.11 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.3999 ns | 0.0454 ns | 0.0424 ns |  0.67 |    0.02 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1992 ns | 0.0093 ns | 0.0087 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9643 ns | 0.0221 ns | 0.0196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.6591 ns | 0.1154 ns | 0.1079 ns |  1.09 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8969 ns | 0.0034 ns | 0.0032 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4609 ns | 0.0271 ns | 0.0226 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2424 ns | 0.0241 ns | 0.0214 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2416 ns | 0.0130 ns | 0.0102 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.5683 ns | 0.0041 ns | 0.0034 ns |  1.26 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4322 ns | 0.0046 ns | 0.0041 ns |  1.15 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  1.1887 ns | 0.0070 ns | 0.0065 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9627 ns | 0.0034 ns | 0.0028 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  9.6228 ns | 0.0172 ns | 0.0161 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 | 11.4754 ns | 0.0305 ns | 0.0285 ns |  1.19 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 | 10.7688 ns | 0.0173 ns | 0.0153 ns |  1.12 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 | 10.3273 ns | 0.0227 ns | 0.0201 ns |  1.07 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 | 10.4157 ns | 0.0183 ns | 0.0171 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  9.6269 ns | 0.0189 ns | 0.0168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2644 ns | 0.0099 ns | 0.0088 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  9.7129 ns | 0.0428 ns | 0.0401 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 10.3134 ns | 0.0237 ns | 0.0198 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 | 10.3052 ns | 0.0209 ns | 0.0195 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 10.0333 ns | 0.0150 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 10.1386 ns | 0.0247 ns | 0.0206 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  9.8575 ns | 0.0599 ns | 0.0531 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 10.2576 ns | 0.0497 ns | 0.0465 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 10.0203 ns | 0.0166 ns | 0.0147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
