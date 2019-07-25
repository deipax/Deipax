
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  3.4897 ns | 0.0064 ns | 0.0053 ns |  1.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  3.7057 ns | 0.0360 ns | 0.0337 ns |  1.06 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  3.6374 ns | 0.0136 ns | 0.0113 ns |  1.04 |     - |     - |     - |         - |
             ToBool |        net461 |  3.5763 ns | 0.0220 ns | 0.0195 ns |  1.03 |     - |     - |     - |         - |
             ToBool |        net472 |  3.5348 ns | 0.0486 ns | 0.0454 ns |  1.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  6.6056 ns | 0.0178 ns | 0.0167 ns |  1.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  6.7015 ns | 0.0170 ns | 0.0151 ns |  1.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  6.5768 ns | 0.0169 ns | 0.0150 ns |  1.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  6.8112 ns | 0.0287 ns | 0.0268 ns |  1.03 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  6.8441 ns | 0.0463 ns | 0.0434 ns |  1.04 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToChar | .NET Core 2.0 |  3.5325 ns | 0.0102 ns | 0.0085 ns |  1.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  3.6712 ns | 0.0116 ns | 0.0091 ns |  1.04 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  3.5765 ns | 0.0188 ns | 0.0167 ns |  1.01 |     - |     - |     - |         - |
             ToChar |        net461 |  3.5247 ns | 0.0107 ns | 0.0095 ns |  1.00 |     - |     - |     - |         - |
             ToChar |        net472 |  3.4809 ns | 0.0085 ns | 0.0075 ns |  0.99 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  6.6550 ns | 0.0544 ns | 0.0509 ns |  1.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  6.7105 ns | 0.0124 ns | 0.0110 ns |  1.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  6.5820 ns | 0.0176 ns | 0.0156 ns |  0.99 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  6.7357 ns | 0.0213 ns | 0.0199 ns |  1.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  6.7827 ns | 0.0551 ns | 0.0515 ns |  1.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToSByte | .NET Core 2.0 |  3.4812 ns | 0.0095 ns | 0.0084 ns |  1.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  3.6746 ns | 0.0103 ns | 0.0096 ns |  1.06 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  3.4303 ns | 0.0268 ns | 0.0223 ns |  0.99 |     - |     - |     - |         - |
            ToSByte |        net461 |  3.5103 ns | 0.0126 ns | 0.0111 ns |  1.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  3.5133 ns | 0.0397 ns | 0.0371 ns |  1.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  6.6063 ns | 0.0156 ns | 0.0130 ns |  1.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  6.7801 ns | 0.0460 ns | 0.0431 ns |  1.03 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  6.5779 ns | 0.0135 ns | 0.0113 ns |  1.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  6.7451 ns | 0.0175 ns | 0.0163 ns |  1.02 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  6.7773 ns | 0.0228 ns | 0.0214 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToByte | .NET Core 2.0 |  3.5791 ns | 0.0112 ns | 0.0105 ns |  1.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  3.6738 ns | 0.0114 ns | 0.0106 ns |  1.03 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  3.5492 ns | 0.0186 ns | 0.0155 ns |  0.99 |     - |     - |     - |         - |
             ToByte |        net461 |  3.5058 ns | 0.0121 ns | 0.0107 ns |  0.98 |     - |     - |     - |         - |
             ToByte |        net472 |  3.4887 ns | 0.0076 ns | 0.0071 ns |  0.97 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  6.6053 ns | 0.0202 ns | 0.0168 ns |  1.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  6.7176 ns | 0.0252 ns | 0.0210 ns |  1.02 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  6.5916 ns | 0.0164 ns | 0.0146 ns |  1.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  6.7511 ns | 0.0335 ns | 0.0313 ns |  1.02 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  6.8429 ns | 0.0198 ns | 0.0185 ns |  1.04 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToShort | .NET Core 2.0 |  3.5098 ns | 0.0146 ns | 0.0130 ns |  1.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  3.7047 ns | 0.0297 ns | 0.0278 ns |  1.06 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  3.5460 ns | 0.0112 ns | 0.0099 ns |  1.01 |     - |     - |     - |         - |
            ToShort |        net461 |  3.5171 ns | 0.0132 ns | 0.0117 ns |  1.00 |     - |     - |     - |         - |
            ToShort |        net472 |  3.4784 ns | 0.0071 ns | 0.0063 ns |  0.99 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  6.6134 ns | 0.0299 ns | 0.0280 ns |  1.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  6.7136 ns | 0.0164 ns | 0.0145 ns |  1.02 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  6.6009 ns | 0.0544 ns | 0.0509 ns |  1.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  6.7986 ns | 0.0430 ns | 0.0402 ns |  1.03 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  6.7743 ns | 0.0173 ns | 0.0145 ns |  1.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
           ToUShort | .NET Core 2.0 |  4.0297 ns | 0.0313 ns | 0.0261 ns |  1.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  3.6154 ns | 0.0176 ns | 0.0156 ns |  0.90 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  3.5466 ns | 0.0112 ns | 0.0099 ns |  0.88 |     - |     - |     - |         - |
           ToUShort |        net461 |  3.5118 ns | 0.0108 ns | 0.0090 ns |  0.87 |     - |     - |     - |         - |
           ToUShort |        net472 |  3.4836 ns | 0.0127 ns | 0.0119 ns |  0.86 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  6.5850 ns | 0.0180 ns | 0.0159 ns |  1.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  6.7126 ns | 0.0173 ns | 0.0153 ns |  1.02 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  6.5921 ns | 0.0243 ns | 0.0227 ns |  1.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  6.7347 ns | 0.0220 ns | 0.0195 ns |  1.02 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  6.7674 ns | 0.0167 ns | 0.0156 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
              ToInt | .NET Core 2.0 |  3.4907 ns | 0.0099 ns | 0.0088 ns |  1.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  3.6858 ns | 0.0120 ns | 0.0107 ns |  1.06 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  3.3853 ns | 0.0136 ns | 0.0127 ns |  0.97 |     - |     - |     - |         - |
              ToInt |        net461 |  3.5717 ns | 0.0091 ns | 0.0085 ns |  1.02 |     - |     - |     - |         - |
              ToInt |        net472 |  3.5884 ns | 0.0400 ns | 0.0375 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  6.6022 ns | 0.0179 ns | 0.0168 ns |  1.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  6.7868 ns | 0.0988 ns | 0.0924 ns |  1.03 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  6.5799 ns | 0.0151 ns | 0.0134 ns |  1.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  6.7341 ns | 0.0133 ns | 0.0118 ns |  1.02 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  6.7652 ns | 0.0183 ns | 0.0171 ns |  1.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToUInt | .NET Core 2.0 |  3.5101 ns | 0.0077 ns | 0.0065 ns |  1.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  3.7215 ns | 0.0111 ns | 0.0098 ns |  1.06 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  3.7003 ns | 0.0108 ns | 0.0084 ns |  1.05 |     - |     - |     - |         - |
             ToUInt |        net461 |  3.5649 ns | 0.0130 ns | 0.0108 ns |  1.02 |     - |     - |     - |         - |
             ToUInt |        net472 |  3.5451 ns | 0.0271 ns | 0.0240 ns |  1.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  6.6001 ns | 0.0252 ns | 0.0236 ns |  1.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  6.7088 ns | 0.0178 ns | 0.0166 ns |  1.02 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  6.5700 ns | 0.0160 ns | 0.0149 ns |  1.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  6.7362 ns | 0.0122 ns | 0.0108 ns |  1.02 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  6.8609 ns | 0.0150 ns | 0.0141 ns |  1.04 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToLong | .NET Core 2.0 |  3.5096 ns | 0.0096 ns | 0.0086 ns |  1.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  3.6706 ns | 0.0116 ns | 0.0103 ns |  1.05 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  3.4318 ns | 0.0139 ns | 0.0123 ns |  0.98 |     - |     - |     - |         - |
             ToLong |        net461 |  3.6064 ns | 0.0124 ns | 0.0116 ns |  1.03 |     - |     - |     - |         - |
             ToLong |        net472 |  3.4726 ns | 0.0218 ns | 0.0182 ns |  0.99 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  5.1692 ns | 0.0134 ns | 0.0112 ns |  1.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  5.4270 ns | 0.0620 ns | 0.0549 ns |  1.05 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  5.0461 ns | 0.0381 ns | 0.0297 ns |  0.98 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  5.3752 ns | 0.0181 ns | 0.0169 ns |  1.04 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  5.6222 ns | 0.0117 ns | 0.0104 ns |  1.09 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToULong | .NET Core 2.0 |  3.4947 ns | 0.0130 ns | 0.0121 ns |  1.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  3.6764 ns | 0.0117 ns | 0.0110 ns |  1.05 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  3.4973 ns | 0.0083 ns | 0.0074 ns |  1.00 |     - |     - |     - |         - |
            ToULong |        net461 |  3.5874 ns | 0.0294 ns | 0.0275 ns |  1.03 |     - |     - |     - |         - |
            ToULong |        net472 |  3.5356 ns | 0.0388 ns | 0.0363 ns |  1.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  5.0253 ns | 0.0109 ns | 0.0097 ns |  1.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  4.8879 ns | 0.0182 ns | 0.0170 ns |  0.97 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  5.0797 ns | 0.0289 ns | 0.0270 ns |  1.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  5.3910 ns | 0.0140 ns | 0.0131 ns |  1.07 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  5.6595 ns | 0.0118 ns | 0.0098 ns |  1.13 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
            ToFloat | .NET Core 2.0 |  3.7645 ns | 0.0347 ns | 0.0308 ns |  1.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  3.6585 ns | 0.0100 ns | 0.0088 ns |  0.97 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  3.7211 ns | 0.0136 ns | 0.0113 ns |  0.99 |     - |     - |     - |         - |
            ToFloat |        net461 |  3.2218 ns | 0.0143 ns | 0.0119 ns |  0.86 |     - |     - |     - |         - |
            ToFloat |        net472 |  3.2190 ns | 0.0345 ns | 0.0322 ns |  0.86 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  6.8278 ns | 0.0126 ns | 0.0112 ns |  1.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  7.0126 ns | 0.0557 ns | 0.0521 ns |  1.03 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  6.8153 ns | 0.0185 ns | 0.0155 ns |  1.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  6.9748 ns | 0.0235 ns | 0.0208 ns |  1.02 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  7.0084 ns | 0.0213 ns | 0.0189 ns |  1.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
           ToDouble | .NET Core 2.0 |  3.3891 ns | 0.0095 ns | 0.0084 ns |  1.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  3.6507 ns | 0.0108 ns | 0.0101 ns |  1.08 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  3.9549 ns | 0.0386 ns | 0.0361 ns |  1.17 |     - |     - |     - |         - |
           ToDouble |        net461 |  3.7577 ns | 0.0121 ns | 0.0113 ns |  1.11 |     - |     - |     - |         - |
           ToDouble |        net472 |  3.4513 ns | 0.0107 ns | 0.0095 ns |  1.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  5.3053 ns | 0.0181 ns | 0.0170 ns |  1.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  5.6060 ns | 0.0089 ns | 0.0074 ns |  1.06 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  4.9745 ns | 0.0188 ns | 0.0166 ns |  0.94 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  5.1398 ns | 0.0083 ns | 0.0077 ns |  0.97 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  5.2135 ns | 0.0577 ns | 0.0539 ns |  0.98 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  4.4793 ns | 0.0096 ns | 0.0085 ns |  1.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  4.3345 ns | 0.0195 ns | 0.0182 ns |  0.97 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  4.3290 ns | 0.0410 ns | 0.0384 ns |  0.97 |     - |     - |     - |         - |
          ToDecimal |        net461 |  8.1345 ns | 0.0232 ns | 0.0217 ns |  1.82 |     - |     - |     - |         - |
          ToDecimal |        net472 |  8.1539 ns | 0.0152 ns | 0.0142 ns |  1.82 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 11.9550 ns | 0.0682 ns | 0.0638 ns |  1.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 11.7668 ns | 0.0354 ns | 0.0314 ns |  0.98 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  4.9641 ns | 0.0151 ns | 0.0141 ns |  0.42 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 11.5270 ns | 0.0245 ns | 0.0230 ns |  0.96 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 11.7350 ns | 0.0271 ns | 0.0240 ns |  0.98 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  4.0986 ns | 0.0098 ns | 0.0087 ns |  1.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  4.2261 ns | 0.0479 ns | 0.0448 ns |  1.03 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  4.2305 ns | 0.0133 ns | 0.0124 ns |  1.03 |     - |     - |     - |         - |
         ToDateTime |        net461 |  3.9012 ns | 0.0161 ns | 0.0151 ns |  0.95 |     - |     - |     - |         - |
         ToDateTime |        net472 |  3.9953 ns | 0.0166 ns | 0.0148 ns |  0.97 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 | 11.4105 ns | 0.0730 ns | 0.0683 ns |  1.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 | 11.8188 ns | 0.0258 ns | 0.0229 ns |  1.04 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  4.9863 ns | 0.0121 ns | 0.0095 ns |  0.44 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 11.5368 ns | 0.0448 ns | 0.0419 ns |  1.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 11.3298 ns | 0.0226 ns | 0.0211 ns |  0.99 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.1751 ns | 0.0082 ns | 0.0077 ns |  1.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.0559 ns | 0.0058 ns | 0.0049 ns |  0.90 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  0.9608 ns | 0.0052 ns | 0.0049 ns |  0.82 |     - |     - |     - |         - |
           ToObject |        net461 |  0.7304 ns | 0.0044 ns | 0.0042 ns |  0.62 |     - |     - |     - |         - |
           ToObject |        net472 |  0.4478 ns | 0.0145 ns | 0.0129 ns |  0.38 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
          To_String | .NET Core 2.0 | 14.4441 ns | 0.0348 ns | 0.0326 ns |  1.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 | 16.0051 ns | 0.0377 ns | 0.0353 ns |  1.11 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 | 12.7293 ns | 0.0269 ns | 0.0210 ns |  0.88 |     - |     - |     - |         - |
          To_String |        net461 | 15.7615 ns | 0.0555 ns | 0.0464 ns |  1.09 |     - |     - |     - |         - |
          To_String |        net472 | 15.4696 ns | 0.0319 ns | 0.0298 ns |  1.07 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
             ToEnum | .NET Core 2.0 | 17.4211 ns | 0.0427 ns | 0.0399 ns |  1.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 16.3642 ns | 0.0545 ns | 0.0510 ns |  0.94 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 13.5108 ns | 0.0925 ns | 0.0865 ns |  0.78 |     - |     - |     - |         - |
             ToEnum |        net461 | 18.5572 ns | 0.0814 ns | 0.0761 ns |  1.07 |     - |     - |     - |         - |
             ToEnum |        net472 | 18.6548 ns | 0.0540 ns | 0.0422 ns |  1.07 |     - |     - |     - |         - |
                    |               |            |           |           |       |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 19.7801 ns | 0.0341 ns | 0.0266 ns |  1.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 19.1159 ns | 0.1239 ns | 0.1159 ns |  0.97 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 16.7627 ns | 0.1225 ns | 0.1146 ns |  0.85 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 23.8714 ns | 0.0357 ns | 0.0317 ns |  1.21 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 22.5432 ns | 0.0837 ns | 0.0783 ns |  1.14 |     - |     - |     - |         - |
