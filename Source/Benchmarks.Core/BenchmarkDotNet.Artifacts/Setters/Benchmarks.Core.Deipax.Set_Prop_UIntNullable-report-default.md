
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  1.3994 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9394 ns | 0.0043 ns | 0.0040 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.6936 ns | 0.0034 ns | 0.0030 ns |  0.50 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9459 ns | 0.0035 ns | 0.0033 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9585 ns | 0.0085 ns | 0.0079 ns |  0.68 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1712 ns | 0.0052 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.6469 ns | 0.0150 ns | 0.0141 ns |  1.41 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9420 ns | 0.0136 ns | 0.0128 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.2577 ns | 0.0176 ns | 0.0165 ns |  1.93 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.2253 ns | 0.0168 ns | 0.0157 ns |  1.90 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.7025 ns | 0.0086 ns | 0.0081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7641 ns | 0.0028 ns | 0.0025 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5632 ns | 0.0029 ns | 0.0024 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.9786 ns | 0.0134 ns | 0.0125 ns |  1.39 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  0.9760 ns | 0.0054 ns | 0.0050 ns |  1.39 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9936 ns | 0.0077 ns | 0.0072 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1085 ns | 0.0028 ns | 0.0025 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0886 ns | 0.0044 ns | 0.0041 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.1689 ns | 0.0187 ns | 0.0165 ns |  2.18 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9874 ns | 0.0138 ns | 0.0123 ns |  2.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3494 ns | 0.0090 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3510 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7257 ns | 0.0085 ns | 0.0080 ns |  0.54 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7715 ns | 0.0156 ns | 0.0146 ns |  1.31 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7479 ns | 0.0051 ns | 0.0048 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7556 ns | 0.0169 ns | 0.0158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8724 ns | 0.0030 ns | 0.0028 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9992 ns | 0.0031 ns | 0.0029 ns |  0.57 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.7307 ns | 0.0128 ns | 0.0113 ns |  1.55 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  3.3516 ns | 0.0066 ns | 0.0062 ns |  1.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7291 ns | 0.0128 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7126 ns | 0.0092 ns | 0.0086 ns |  0.98 |    0.02 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5835 ns | 0.0101 ns | 0.0094 ns |  0.80 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7170 ns | 0.0044 ns | 0.0039 ns |  0.98 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7177 ns | 0.0031 ns | 0.0027 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9830 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1769 ns | 0.0041 ns | 0.0038 ns |  1.20 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9560 ns | 0.0055 ns | 0.0049 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.0217 ns | 0.0095 ns | 0.0080 ns |  2.05 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9664 ns | 0.0076 ns | 0.0071 ns |  2.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3859 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3189 ns | 0.0029 ns | 0.0027 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6225 ns | 0.0034 ns | 0.0028 ns |  0.45 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  2.1334 ns | 0.0116 ns | 0.0103 ns |  1.54 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  2.1143 ns | 0.0042 ns | 0.0040 ns |  1.53 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8920 ns | 0.0059 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7981 ns | 0.0115 ns | 0.0107 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1386 ns | 0.0083 ns | 0.0077 ns |  0.60 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.6846 ns | 0.0107 ns | 0.0094 ns |  1.42 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.6323 ns | 0.0134 ns | 0.0126 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6981 ns | 0.0059 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7415 ns | 0.0042 ns | 0.0040 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5621 ns | 0.0021 ns | 0.0016 ns |  0.81 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7381 ns | 0.0038 ns | 0.0034 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7442 ns | 0.0037 ns | 0.0034 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9950 ns | 0.0078 ns | 0.0065 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1951 ns | 0.0117 ns | 0.0109 ns |  1.20 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2789 ns | 0.0019 ns | 0.0015 ns |  1.28 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9823 ns | 0.0086 ns | 0.0080 ns |  1.99 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9747 ns | 0.0037 ns | 0.0031 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.3938 ns | 0.0063 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8521 ns | 0.0072 ns | 0.0064 ns |  1.33 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7563 ns | 0.0046 ns | 0.0040 ns |  0.54 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.8123 ns | 0.0089 ns | 0.0079 ns |  1.30 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7615 ns | 0.0042 ns | 0.0040 ns |  1.26 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.9268 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.1661 ns | 0.0224 ns | 0.0210 ns |  1.12 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1010 ns | 0.0123 ns | 0.0115 ns |  0.57 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.6488 ns | 0.0178 ns | 0.0158 ns |  1.38 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.6330 ns | 0.0060 ns | 0.0050 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7321 ns | 0.0089 ns | 0.0083 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6837 ns | 0.0031 ns | 0.0027 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7261 ns | 0.0033 ns | 0.0029 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6622 ns | 0.0038 ns | 0.0034 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6603 ns | 0.0064 ns | 0.0056 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.6842 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.6856 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.6253 ns | 0.0027 ns | 0.0025 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  0.6700 ns | 0.0053 ns | 0.0049 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  0.6718 ns | 0.0024 ns | 0.0022 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.7823 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8659 ns | 0.0047 ns | 0.0044 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  2.1565 ns | 0.0038 ns | 0.0030 ns |  1.21 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.8305 ns | 0.0091 ns | 0.0085 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8352 ns | 0.0075 ns | 0.0070 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.1540 ns | 0.0087 ns | 0.0081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.0685 ns | 0.0236 ns | 0.0221 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.0450 ns | 0.0092 ns | 0.0082 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.0101 ns | 0.0199 ns | 0.0186 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.0094 ns | 0.0222 ns | 0.0208 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.5066 ns | 0.0123 ns | 0.0115 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.3970 ns | 0.0030 ns | 0.0028 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7608 ns | 0.0063 ns | 0.0059 ns |  0.51 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7239 ns | 0.0168 ns | 0.0141 ns |  1.15 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7281 ns | 0.0076 ns | 0.0071 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.3940 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.0168 ns | 0.0050 ns | 0.0047 ns |  0.84 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7712 ns | 0.0062 ns | 0.0055 ns |  0.74 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.8647 ns | 0.0192 ns | 0.0179 ns |  1.20 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.8423 ns | 0.0165 ns | 0.0146 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5920 ns | 0.0196 ns | 0.0184 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.5276 ns | 0.0071 ns | 0.0063 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.5100 ns | 0.0054 ns | 0.0051 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4714 ns | 0.0072 ns | 0.0060 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4832 ns | 0.0089 ns | 0.0084 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.4368 ns | 0.0149 ns | 0.0139 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.5493 ns | 0.0264 ns | 0.0247 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.1477 ns | 1.1011 ns | 1.1308 ns |  1.23 |    0.35 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.7611 ns | 0.0274 ns | 0.0256 ns |  1.09 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.7662 ns | 0.0088 ns | 0.0082 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.8608 ns | 0.0161 ns | 0.0151 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.6225 ns | 0.0228 ns | 0.0213 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.1153 ns | 0.0165 ns | 0.0154 ns |  1.09 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5767 ns | 0.0083 ns | 0.0078 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.7082 ns | 0.0124 ns | 0.0116 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.6344 ns | 0.0117 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.1820 ns | 0.0068 ns | 0.0056 ns |  1.15 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.9355 ns | 0.0069 ns | 0.0058 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.0658 ns | 0.0074 ns | 0.0065 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.0935 ns | 0.0135 ns | 0.0113 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.3522 ns | 0.0643 ns | 0.0601 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1269 ns | 0.0259 ns | 0.0217 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8722 ns | 0.0139 ns | 0.0123 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 16.4235 ns | 0.0530 ns | 0.0496 ns |  1.23 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3112 ns | 0.0152 ns | 0.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.0479 ns | 0.1087 ns | 0.1016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.8891 ns | 0.0234 ns | 0.0208 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.2864 ns | 0.0572 ns | 0.0535 ns |  0.55 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.3772 ns | 0.0977 ns | 0.0914 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.1815 ns | 0.0329 ns | 0.0308 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6938 ns | 0.0035 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6966 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7504 ns | 0.0030 ns | 0.0027 ns |  1.08 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6842 ns | 0.0106 ns | 0.0099 ns |  0.99 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6835 ns | 0.0014 ns | 0.0012 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5135 ns | 0.0032 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6876 ns | 0.0080 ns | 0.0075 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4540 ns | 0.0115 ns | 0.0102 ns |  0.96 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6412 ns | 0.0037 ns | 0.0035 ns |  1.08 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6738 ns | 0.0205 ns | 0.0192 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.0744 ns | 0.0145 ns | 0.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.1730 ns | 0.0230 ns | 0.0215 ns |  1.41 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.9473 ns | 0.0107 ns | 0.0100 ns |  1.48 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.5702 ns | 0.0720 ns | 0.0674 ns |  1.35 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.6883 ns | 0.0310 ns | 0.0290 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.5390 ns | 0.1023 ns | 0.0957 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.1380 ns | 0.1735 ns | 0.1538 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 11.6149 ns | 0.0961 ns | 0.0899 ns |  0.25 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.1942 ns | 0.1304 ns | 0.1220 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.0321 ns | 0.0865 ns | 0.0767 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4156 ns | 0.0033 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3745 ns | 0.0045 ns | 0.0040 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7335 ns | 0.0068 ns | 0.0057 ns |  0.52 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7314 ns | 0.0080 ns | 0.0075 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7132 ns | 0.0040 ns | 0.0038 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.0150 ns | 0.0125 ns | 0.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.1457 ns | 0.0032 ns | 0.0027 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0917 ns | 0.0033 ns | 0.0031 ns |  0.54 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.5968 ns | 0.0188 ns | 0.0176 ns |  1.29 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.6053 ns | 0.0173 ns | 0.0162 ns |  1.29 |    0.01 |     - |     - |     - |         - |
