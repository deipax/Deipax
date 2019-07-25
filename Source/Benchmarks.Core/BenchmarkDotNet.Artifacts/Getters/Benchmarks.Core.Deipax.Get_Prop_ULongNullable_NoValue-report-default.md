
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
             ToBool | .NET Core 2.0 |  1.4992 ns | 0.0137 ns | 0.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.6451 ns | 0.0061 ns | 0.0054 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4266 ns | 0.0049 ns | 0.0041 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9868 ns | 0.0047 ns | 0.0039 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9819 ns | 0.0048 ns | 0.0042 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0639 ns | 0.0110 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2481 ns | 0.0130 ns | 0.0121 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0654 ns | 0.0195 ns | 0.0183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.3048 ns | 0.0776 ns | 0.0726 ns |  1.06 |    0.02 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2334 ns | 0.0339 ns | 0.0317 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5745 ns | 0.0178 ns | 0.0149 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5565 ns | 0.0458 ns | 0.0383 ns |  0.99 |    0.02 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4666 ns | 0.0038 ns | 0.0033 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  1.0005 ns | 0.0238 ns | 0.0199 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9812 ns | 0.0093 ns | 0.0087 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.3368 ns | 0.0469 ns | 0.0415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1977 ns | 0.0151 ns | 0.0134 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0281 ns | 0.0105 ns | 0.0099 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4533 ns | 0.0177 ns | 0.0157 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4919 ns | 0.0226 ns | 0.0211 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4928 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4882 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.2481 ns | 0.0062 ns | 0.0052 ns |  0.84 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9832 ns | 0.0024 ns | 0.0022 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9778 ns | 0.0077 ns | 0.0065 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.5498 ns | 0.0192 ns | 0.0170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4513 ns | 0.0156 ns | 0.0146 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0663 ns | 0.0127 ns | 0.0112 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4808 ns | 0.0083 ns | 0.0077 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4929 ns | 0.0217 ns | 0.0193 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5726 ns | 0.0120 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4872 ns | 0.0071 ns | 0.0063 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.5933 ns | 0.0058 ns | 0.0049 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9866 ns | 0.0074 ns | 0.0065 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9845 ns | 0.0209 ns | 0.0185 ns |  0.63 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.3462 ns | 0.0540 ns | 0.0505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2049 ns | 0.0076 ns | 0.0071 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0299 ns | 0.0104 ns | 0.0092 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4748 ns | 0.0164 ns | 0.0145 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4978 ns | 0.0248 ns | 0.0219 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.5013 ns | 0.0153 ns | 0.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6059 ns | 0.0128 ns | 0.0120 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.3068 ns | 0.0052 ns | 0.0046 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9928 ns | 0.0121 ns | 0.0107 ns |  0.66 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9971 ns | 0.0204 ns | 0.0191 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2828 ns | 0.0274 ns | 0.0229 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2093 ns | 0.0148 ns | 0.0139 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0146 ns | 0.0118 ns | 0.0104 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.5160 ns | 0.0322 ns | 0.0301 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4627 ns | 0.0168 ns | 0.0157 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.5605 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5016 ns | 0.0056 ns | 0.0052 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.6187 ns | 0.0041 ns | 0.0034 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9798 ns | 0.0121 ns | 0.0113 ns |  0.63 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9851 ns | 0.0088 ns | 0.0082 ns |  0.63 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.3079 ns | 0.0296 ns | 0.0262 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2106 ns | 0.0120 ns | 0.0107 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0811 ns | 0.0372 ns | 0.0348 ns |  0.95 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4643 ns | 0.0395 ns | 0.0350 ns |  1.04 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4548 ns | 0.0202 ns | 0.0179 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4985 ns | 0.0155 ns | 0.0121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5959 ns | 0.0057 ns | 0.0054 ns |  1.07 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4671 ns | 0.0110 ns | 0.0097 ns |  0.98 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9415 ns | 0.0057 ns | 0.0053 ns |  0.63 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9635 ns | 0.0207 ns | 0.0193 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.3122 ns | 0.0272 ns | 0.0227 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2057 ns | 0.0112 ns | 0.0099 ns |  0.97 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0885 ns | 0.0428 ns | 0.0357 ns |  0.95 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4462 ns | 0.0197 ns | 0.0164 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4659 ns | 0.0253 ns | 0.0224 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5585 ns | 0.0051 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4851 ns | 0.0072 ns | 0.0067 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.5933 ns | 0.0031 ns | 0.0026 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9431 ns | 0.0090 ns | 0.0075 ns |  0.61 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9399 ns | 0.0031 ns | 0.0027 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.6019 ns | 0.0319 ns | 0.0299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4504 ns | 0.0276 ns | 0.0258 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0403 ns | 0.0196 ns | 0.0183 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.5357 ns | 0.0314 ns | 0.0293 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4600 ns | 0.0213 ns | 0.0199 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4681 ns | 0.0062 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.5232 ns | 0.0114 ns | 0.0095 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5998 ns | 0.0074 ns | 0.0062 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9403 ns | 0.0065 ns | 0.0058 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9540 ns | 0.0137 ns | 0.0128 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9955 ns | 0.0211 ns | 0.0187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.4553 ns | 0.0064 ns | 0.0053 ns |  1.23 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1067 ns | 0.0308 ns | 0.0273 ns |  1.06 |    0.02 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3505 ns | 0.0132 ns | 0.0117 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.4427 ns | 0.0758 ns | 0.0778 ns |  1.23 |    0.04 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6961 ns | 0.0137 ns | 0.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5080 ns | 0.0186 ns | 0.0174 ns |  0.89 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4610 ns | 0.0107 ns | 0.0095 ns |  0.86 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9899 ns | 0.0184 ns | 0.0163 ns |  0.58 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9603 ns | 0.0082 ns | 0.0069 ns |  0.57 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0108 ns | 0.0069 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.7093 ns | 0.0057 ns | 0.0051 ns |  0.85 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6104 ns | 0.0037 ns | 0.0029 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.6536 ns | 0.0149 ns | 0.0140 ns |  0.82 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.6308 ns | 0.0097 ns | 0.0091 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6469 ns | 0.0069 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.5643 ns | 0.0392 ns | 0.0306 ns |  0.95 |    0.02 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3234 ns | 0.0085 ns | 0.0079 ns |  0.80 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0132 ns | 0.0155 ns | 0.0137 ns |  0.62 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0298 ns | 0.0140 ns | 0.0117 ns |  0.63 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2803 ns | 0.0100 ns | 0.0093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4661 ns | 0.0327 ns | 0.0306 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2531 ns | 0.0110 ns | 0.0086 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.7054 ns | 0.0452 ns | 0.0422 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.7324 ns | 0.0465 ns | 0.0435 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.7315 ns | 0.0150 ns | 0.0140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6099 ns | 0.0052 ns | 0.0040 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3151 ns | 0.0112 ns | 0.0099 ns |  0.76 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0182 ns | 0.0064 ns | 0.0060 ns |  0.59 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0055 ns | 0.0197 ns | 0.0174 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.4780 ns | 0.0069 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.1985 ns | 0.0046 ns | 0.0036 ns |  0.89 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0776 ns | 0.0206 ns | 0.0193 ns |  0.84 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.3476 ns | 0.0134 ns | 0.0119 ns |  0.95 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.3595 ns | 0.0186 ns | 0.0174 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2724 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1702 ns | 0.0047 ns | 0.0042 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.0805 ns | 0.0087 ns | 0.0077 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.3162 ns | 0.0326 ns | 0.0305 ns |  2.78 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.1806 ns | 0.0371 ns | 0.0329 ns |  2.72 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.1083 ns | 0.0284 ns | 0.0237 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.8063 ns | 0.0212 ns | 0.0188 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3769 ns | 0.0173 ns | 0.0153 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7845 ns | 0.0512 ns | 0.0479 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7914 ns | 0.0473 ns | 0.0419 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.1585 ns | 0.0084 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3655 ns | 0.0109 ns | 0.0091 ns |  1.10 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3269 ns | 0.0209 ns | 0.0195 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.2041 ns | 0.0150 ns | 0.0141 ns |  0.56 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.2103 ns | 0.0146 ns | 0.0122 ns |  0.56 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3442 ns | 0.0298 ns | 0.0279 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3215 ns | 0.0520 ns | 0.0487 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9130 ns | 0.0085 ns | 0.0079 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4228 ns | 0.0715 ns | 0.0633 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2838 ns | 0.0341 ns | 0.0302 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4741 ns | 0.0041 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4992 ns | 0.0051 ns | 0.0048 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4121 ns | 0.0069 ns | 0.0061 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9642 ns | 0.0050 ns | 0.0047 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9595 ns | 0.0042 ns | 0.0037 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6451 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.5077 ns | 0.0046 ns | 0.0039 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.5753 ns | 0.0036 ns | 0.0033 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.2640 ns | 0.0101 ns | 0.0095 ns |  0.77 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2707 ns | 0.0137 ns | 0.0128 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6519 ns | 0.0084 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6546 ns | 0.0096 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5966 ns | 0.0184 ns | 0.0172 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.3080 ns | 0.0060 ns | 0.0050 ns |  0.79 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.3120 ns | 0.0047 ns | 0.0044 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.3011 ns | 0.0301 ns | 0.0282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4405 ns | 0.0150 ns | 0.0125 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0544 ns | 0.0554 ns | 0.0462 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6930 ns | 0.0133 ns | 0.0111 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.7019 ns | 0.0237 ns | 0.0221 ns |  1.09 |    0.01 |     - |     - |     - |         - |
