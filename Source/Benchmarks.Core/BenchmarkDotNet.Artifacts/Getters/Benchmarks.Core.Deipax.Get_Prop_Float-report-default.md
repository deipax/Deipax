
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
             ToBool | .NET Core 2.0 |   0.9518 ns | 0.0117 ns | 0.0110 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |   1.4247 ns | 0.0072 ns | 0.0060 ns |  1.50 |    0.02 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |   1.1566 ns | 0.0059 ns | 0.0056 ns |  1.22 |    0.02 |      - |     - |     - |         - |
             ToBool |        net461 |   0.9497 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |   0.9518 ns | 0.0055 ns | 0.0052 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |   4.7451 ns | 0.0152 ns | 0.0127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |   4.9181 ns | 0.0213 ns | 0.0199 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |   4.4949 ns | 0.0110 ns | 0.0103 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |   4.8881 ns | 0.0137 ns | 0.0128 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |   4.8991 ns | 0.0158 ns | 0.0147 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |   0.9437 ns | 0.0074 ns | 0.0069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |   1.2112 ns | 0.0084 ns | 0.0079 ns |  1.28 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |   1.1212 ns | 0.0061 ns | 0.0051 ns |  1.19 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |   0.7225 ns | 0.0093 ns | 0.0087 ns |  0.77 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |   0.5879 ns | 0.0049 ns | 0.0044 ns |  0.62 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |   4.3022 ns | 0.0307 ns | 0.0287 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |   4.4438 ns | 0.0243 ns | 0.0216 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |   4.0654 ns | 0.0086 ns | 0.0076 ns |  0.94 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |   4.4113 ns | 0.0102 ns | 0.0091 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |   4.4442 ns | 0.0093 ns | 0.0087 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |   4.4721 ns | 0.0218 ns | 0.0204 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |   4.8988 ns | 0.0126 ns | 0.0112 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |   4.7475 ns | 0.0130 ns | 0.0121 ns |  1.06 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |   3.6355 ns | 0.0126 ns | 0.0111 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |   3.6391 ns | 0.0045 ns | 0.0037 ns |  0.81 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |   6.5928 ns | 0.0159 ns | 0.0141 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |   6.7646 ns | 0.0236 ns | 0.0221 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |   7.1081 ns | 0.0223 ns | 0.0198 ns |  1.08 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |   6.7457 ns | 0.0210 ns | 0.0196 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |   6.7824 ns | 0.0135 ns | 0.0119 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |   4.6940 ns | 0.1509 ns | 0.1549 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |   4.8590 ns | 0.0240 ns | 0.0213 ns |  1.03 |    0.03 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |   5.0170 ns | 0.0108 ns | 0.0090 ns |  1.06 |    0.03 |      - |     - |     - |         - |
             ToByte |        net461 |   3.6065 ns | 0.0091 ns | 0.0085 ns |  0.77 |    0.02 |      - |     - |     - |         - |
             ToByte |        net472 |   3.6486 ns | 0.0195 ns | 0.0173 ns |  0.77 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |   6.6382 ns | 0.0472 ns | 0.0442 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |   6.7666 ns | 0.0223 ns | 0.0208 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |   7.0253 ns | 0.0217 ns | 0.0192 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net461 |   6.7630 ns | 0.0202 ns | 0.0189 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     ToByteNullable |        net472 |   6.7818 ns | 0.0196 ns | 0.0184 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |   4.6116 ns | 0.0349 ns | 0.0309 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |   4.8376 ns | 0.0086 ns | 0.0076 ns |  1.05 |    0.01 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |   4.8636 ns | 0.0082 ns | 0.0073 ns |  1.05 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |   3.6563 ns | 0.0190 ns | 0.0168 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |   3.6502 ns | 0.0075 ns | 0.0067 ns |  0.79 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |   6.6302 ns | 0.0354 ns | 0.0314 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |   6.7998 ns | 0.0250 ns | 0.0222 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |   7.0246 ns | 0.0412 ns | 0.0365 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |   6.7430 ns | 0.0183 ns | 0.0171 ns |  1.02 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net472 |   6.7830 ns | 0.0195 ns | 0.0182 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |   4.5578 ns | 0.0270 ns | 0.0240 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |   4.9027 ns | 0.0211 ns | 0.0197 ns |  1.08 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |   5.1810 ns | 0.0790 ns | 0.0739 ns |  1.14 |    0.02 |      - |     - |     - |         - |
           ToUShort |        net461 |   3.7770 ns | 0.0116 ns | 0.0109 ns |  0.83 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |   3.7650 ns | 0.0131 ns | 0.0116 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |   6.6720 ns | 0.1049 ns | 0.0876 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |   6.7772 ns | 0.0451 ns | 0.0422 ns |  1.02 |    0.02 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |   7.0221 ns | 0.0163 ns | 0.0144 ns |  1.05 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |   6.7921 ns | 0.0324 ns | 0.0287 ns |  1.02 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |   6.7855 ns | 0.0195 ns | 0.0182 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |   3.0603 ns | 0.0180 ns | 0.0160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |   3.4539 ns | 0.0255 ns | 0.0239 ns |  1.13 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |   3.6485 ns | 0.0109 ns | 0.0102 ns |  1.19 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |   2.3567 ns | 0.0060 ns | 0.0056 ns |  0.77 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |   2.3536 ns | 0.0061 ns | 0.0054 ns |  0.77 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |   5.9550 ns | 0.0279 ns | 0.0261 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |   6.0723 ns | 0.0111 ns | 0.0104 ns |  1.02 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |   6.3294 ns | 0.0303 ns | 0.0283 ns |  1.06 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |   6.0454 ns | 0.0091 ns | 0.0081 ns |  1.01 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |   6.0699 ns | 0.0145 ns | 0.0136 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |   3.0908 ns | 0.0273 ns | 0.0228 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |   3.4673 ns | 0.0373 ns | 0.0331 ns |  1.12 |    0.02 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |   3.4350 ns | 0.0111 ns | 0.0093 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |   2.4526 ns | 0.0092 ns | 0.0081 ns |  0.79 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |   2.3463 ns | 0.0052 ns | 0.0049 ns |  0.76 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |   5.9654 ns | 0.0524 ns | 0.0465 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |   6.1287 ns | 0.0151 ns | 0.0142 ns |  1.03 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |   6.3197 ns | 0.0093 ns | 0.0087 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |   6.0371 ns | 0.0183 ns | 0.0172 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |   6.0759 ns | 0.0135 ns | 0.0126 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |   4.0913 ns | 0.0269 ns | 0.0225 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |   2.7202 ns | 0.0179 ns | 0.0168 ns |  0.67 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |   2.6929 ns | 0.0103 ns | 0.0091 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |   3.7192 ns | 0.0112 ns | 0.0099 ns |  0.91 |    0.01 |      - |     - |     - |         - |
             ToLong |        net472 |   3.6943 ns | 0.0076 ns | 0.0063 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |   4.3206 ns | 0.0539 ns | 0.0504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |   3.2308 ns | 0.0099 ns | 0.0093 ns |  0.75 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |   3.2108 ns | 0.0130 ns | 0.0115 ns |  0.74 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |   4.9530 ns | 0.0112 ns | 0.0105 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |   5.6006 ns | 0.0103 ns | 0.0096 ns |  1.30 |    0.02 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |   4.1138 ns | 0.0216 ns | 0.0192 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |   2.7630 ns | 0.0097 ns | 0.0086 ns |  0.67 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |   2.7189 ns | 0.0081 ns | 0.0072 ns |  0.66 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |   3.7422 ns | 0.0124 ns | 0.0116 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToULong |        net472 |   3.7606 ns | 0.0122 ns | 0.0109 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |   4.3805 ns | 0.0533 ns | 0.0445 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |   3.2713 ns | 0.0163 ns | 0.0153 ns |  0.75 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |   3.1616 ns | 0.0188 ns | 0.0176 ns |  0.72 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |   5.0317 ns | 0.0261 ns | 0.0244 ns |  1.15 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |   4.9914 ns | 0.0309 ns | 0.0289 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |   1.2038 ns | 0.0235 ns | 0.0209 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |   1.1801 ns | 0.0073 ns | 0.0069 ns |  0.98 |    0.02 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |   1.1215 ns | 0.0048 ns | 0.0045 ns |  0.93 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |   0.7175 ns | 0.0053 ns | 0.0050 ns |  0.60 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |   0.7145 ns | 0.0036 ns | 0.0034 ns |  0.59 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |   4.0636 ns | 0.0140 ns | 0.0131 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |   4.4437 ns | 0.0178 ns | 0.0158 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |   4.2155 ns | 0.0122 ns | 0.0108 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |   4.1769 ns | 0.0084 ns | 0.0074 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |   4.2110 ns | 0.0089 ns | 0.0079 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |   1.4208 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |   1.2239 ns | 0.0102 ns | 0.0095 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |   1.1424 ns | 0.0081 ns | 0.0076 ns |  0.80 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |   0.7390 ns | 0.0081 ns | 0.0076 ns |  0.52 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |   0.7160 ns | 0.0036 ns | 0.0033 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |   1.9085 ns | 0.0129 ns | 0.0114 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |   1.6839 ns | 0.0069 ns | 0.0057 ns |  0.88 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |   1.6057 ns | 0.0057 ns | 0.0051 ns |  0.84 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |   1.8420 ns | 0.0147 ns | 0.0137 ns |  0.97 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |   1.8627 ns | 0.0062 ns | 0.0058 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  23.7785 ns | 0.0362 ns | 0.0321 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  23.8753 ns | 0.0573 ns | 0.0536 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  11.4938 ns | 0.0272 ns | 0.0241 ns |  0.48 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  23.6377 ns | 0.0695 ns | 0.0616 ns |  0.99 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  23.7508 ns | 0.0333 ns | 0.0295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  34.0213 ns | 0.0578 ns | 0.0512 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  33.9722 ns | 0.0393 ns | 0.0349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  16.8479 ns | 0.1753 ns | 0.1640 ns |  0.50 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  34.1556 ns | 0.0953 ns | 0.0845 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  34.0376 ns | 0.0746 ns | 0.0661 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |   2.3473 ns | 0.0071 ns | 0.0067 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |   2.3816 ns | 0.0112 ns | 0.0094 ns |  1.02 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |   2.2762 ns | 0.0046 ns | 0.0043 ns |  0.97 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |   1.1205 ns | 0.0042 ns | 0.0035 ns |  0.48 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |   1.3683 ns | 0.0083 ns | 0.0078 ns |  0.58 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |   8.2302 ns | 0.0195 ns | 0.0163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |   8.1628 ns | 0.0205 ns | 0.0181 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |   2.0417 ns | 0.0036 ns | 0.0030 ns |  0.25 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  12.3073 ns | 0.0327 ns | 0.0290 ns |  1.50 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |   8.0270 ns | 0.0258 ns | 0.0241 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |   3.2351 ns | 0.0077 ns | 0.0069 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |   4.0937 ns | 0.0355 ns | 0.0296 ns |  1.27 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |   4.0073 ns | 0.0412 ns | 0.0385 ns |  1.24 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |   3.2667 ns | 0.0226 ns | 0.0212 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |   3.0556 ns | 0.0136 ns | 0.0127 ns |  0.94 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |             |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 163.5812 ns | 0.4075 ns | 0.3403 ns |  1.00 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 104.8686 ns | 0.5254 ns | 0.4915 ns |  0.64 |    0.00 | 0.0050 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 110.5476 ns | 0.2249 ns | 0.2104 ns |  0.68 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 280.8015 ns | 0.8406 ns | 0.7863 ns |  1.72 |    0.01 | 0.0048 |     - |     - |      32 B |
          To_String |        net472 | 281.0662 ns | 0.6750 ns | 0.5983 ns |  1.72 |    0.01 | 0.0048 |     - |     - |      32 B |
                    |               |             |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  12.3611 ns | 0.0282 ns | 0.0250 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  12.4290 ns | 0.0765 ns | 0.0715 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  10.5955 ns | 0.0382 ns | 0.0357 ns |  0.86 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 |  14.4585 ns | 0.0493 ns | 0.0437 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 |  14.3675 ns | 0.0404 ns | 0.0378 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |             |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  16.9984 ns | 0.0668 ns | 0.0625 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  17.0371 ns | 0.0311 ns | 0.0291 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  14.9132 ns | 0.0278 ns | 0.0260 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 |  19.2852 ns | 0.0533 ns | 0.0499 ns |  1.13 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 |  19.4249 ns | 0.0946 ns | 0.0885 ns |  1.14 |    0.01 |      - |     - |     - |         - |
