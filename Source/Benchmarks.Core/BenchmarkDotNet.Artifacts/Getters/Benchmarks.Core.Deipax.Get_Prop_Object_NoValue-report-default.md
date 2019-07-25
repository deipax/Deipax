
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
             ToBool | .NET Core 2.0 |  2.6193 ns | 0.0104 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  2.0450 ns | 0.0079 ns | 0.0074 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.9950 ns | 0.0251 ns | 0.0235 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.8623 ns | 0.0180 ns | 0.0169 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  1.8479 ns | 0.0048 ns | 0.0038 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  5.0591 ns | 0.0071 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.9341 ns | 0.0147 ns | 0.0130 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.7309 ns | 0.0133 ns | 0.0124 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.9291 ns | 0.0293 ns | 0.0274 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.9638 ns | 0.0176 ns | 0.0165 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  2.0929 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.0860 ns | 0.0131 ns | 0.0116 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.0291 ns | 0.0288 ns | 0.0269 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  1.8488 ns | 0.0034 ns | 0.0032 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.8224 ns | 0.0068 ns | 0.0057 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.9720 ns | 0.0091 ns | 0.0081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.3194 ns | 0.0102 ns | 0.0096 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7246 ns | 0.0433 ns | 0.0405 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3618 ns | 0.0141 ns | 0.0125 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  5.4318 ns | 0.0334 ns | 0.0312 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  2.5860 ns | 0.0278 ns | 0.0260 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.0365 ns | 0.0252 ns | 0.0236 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.0103 ns | 0.0074 ns | 0.0070 ns |  0.78 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.8538 ns | 0.0102 ns | 0.0091 ns |  0.72 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.8242 ns | 0.0085 ns | 0.0071 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.9830 ns | 0.0195 ns | 0.0182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.3185 ns | 0.0103 ns | 0.0092 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.7680 ns | 0.0104 ns | 0.0092 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3840 ns | 0.0405 ns | 0.0379 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3618 ns | 0.0067 ns | 0.0059 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  2.0492 ns | 0.0039 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.0158 ns | 0.0308 ns | 0.0288 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.3008 ns | 0.0029 ns | 0.0022 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  1.8502 ns | 0.0032 ns | 0.0030 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  1.8224 ns | 0.0092 ns | 0.0086 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.9803 ns | 0.0178 ns | 0.0166 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.3149 ns | 0.0115 ns | 0.0102 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.9073 ns | 0.0368 ns | 0.0345 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3459 ns | 0.0061 ns | 0.0054 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  5.4394 ns | 0.0088 ns | 0.0083 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  2.0545 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.0367 ns | 0.0071 ns | 0.0063 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.9728 ns | 0.0071 ns | 0.0066 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  2.2082 ns | 0.0059 ns | 0.0055 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  1.9965 ns | 0.0078 ns | 0.0065 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.0059 ns | 0.0436 ns | 0.0408 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.3245 ns | 0.0134 ns | 0.0125 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.7365 ns | 0.0117 ns | 0.0109 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3066 ns | 0.0069 ns | 0.0064 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3697 ns | 0.0096 ns | 0.0080 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  2.0826 ns | 0.0209 ns | 0.0195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.0465 ns | 0.0255 ns | 0.0239 ns |  0.98 |    0.02 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.0194 ns | 0.0188 ns | 0.0176 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  2.0636 ns | 0.0045 ns | 0.0042 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.8260 ns | 0.0068 ns | 0.0057 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.9798 ns | 0.0118 ns | 0.0099 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.3269 ns | 0.0131 ns | 0.0116 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.8684 ns | 0.0067 ns | 0.0062 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3512 ns | 0.0100 ns | 0.0093 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3805 ns | 0.0146 ns | 0.0122 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  2.0714 ns | 0.0189 ns | 0.0177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  2.0296 ns | 0.0172 ns | 0.0161 ns |  0.98 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  2.0321 ns | 0.0090 ns | 0.0075 ns |  0.98 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  1.9040 ns | 0.0047 ns | 0.0042 ns |  0.92 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.8793 ns | 0.0045 ns | 0.0038 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.9792 ns | 0.0155 ns | 0.0137 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  5.3107 ns | 0.0104 ns | 0.0092 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.6951 ns | 0.0095 ns | 0.0088 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  5.3480 ns | 0.0154 ns | 0.0137 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  5.4156 ns | 0.0234 ns | 0.0218 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  2.1048 ns | 0.0204 ns | 0.0181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  2.0429 ns | 0.0343 ns | 0.0321 ns |  0.97 |    0.02 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  2.3019 ns | 0.0613 ns | 0.0573 ns |  1.09 |    0.03 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.8785 ns | 0.0033 ns | 0.0027 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  2.0334 ns | 0.0567 ns | 0.0530 ns |  0.96 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.9677 ns | 0.0376 ns | 0.0352 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  5.2707 ns | 0.0140 ns | 0.0117 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.7283 ns | 0.0096 ns | 0.0085 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.3250 ns | 0.0097 ns | 0.0091 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.3752 ns | 0.0086 ns | 0.0080 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  2.0737 ns | 0.0047 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  2.0428 ns | 0.0049 ns | 0.0044 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.9423 ns | 0.0059 ns | 0.0046 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.8780 ns | 0.0056 ns | 0.0049 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.8507 ns | 0.0068 ns | 0.0061 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  3.1061 ns | 0.0128 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.8130 ns | 0.0259 ns | 0.0230 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.8743 ns | 0.0085 ns | 0.0079 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  3.2001 ns | 0.0120 ns | 0.0112 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.8508 ns | 0.0257 ns | 0.0241 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  2.2163 ns | 0.0148 ns | 0.0138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  2.0397 ns | 0.0092 ns | 0.0086 ns |  0.92 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.9885 ns | 0.0057 ns | 0.0053 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  1.8750 ns | 0.0030 ns | 0.0025 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  1.8531 ns | 0.0050 ns | 0.0044 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  3.2810 ns | 0.0103 ns | 0.0097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.7810 ns | 0.0104 ns | 0.0092 ns |  0.85 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.9042 ns | 0.0315 ns | 0.0295 ns |  0.89 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.8491 ns | 0.0235 ns | 0.0220 ns |  0.87 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.9704 ns | 0.0267 ns | 0.0249 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  2.2287 ns | 0.0227 ns | 0.0212 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  2.1058 ns | 0.0066 ns | 0.0062 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  2.0667 ns | 0.0073 ns | 0.0068 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.8541 ns | 0.0035 ns | 0.0029 ns |  0.83 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.8323 ns | 0.0064 ns | 0.0057 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  5.2054 ns | 0.0102 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  5.3136 ns | 0.0112 ns | 0.0105 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.9643 ns | 0.0174 ns | 0.0145 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.5980 ns | 0.0287 ns | 0.0269 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.5534 ns | 0.0332 ns | 0.0311 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  2.1760 ns | 0.0077 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  2.1397 ns | 0.0053 ns | 0.0050 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  2.0277 ns | 0.0082 ns | 0.0073 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.8553 ns | 0.0066 ns | 0.0062 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.8270 ns | 0.0069 ns | 0.0064 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  3.3328 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  3.4034 ns | 0.0132 ns | 0.0123 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  3.0765 ns | 0.0127 ns | 0.0119 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  3.0482 ns | 0.0144 ns | 0.0135 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  3.0692 ns | 0.0103 ns | 0.0096 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  3.2105 ns | 0.0123 ns | 0.0096 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  3.0969 ns | 0.0540 ns | 0.0506 ns |  0.97 |    0.02 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  3.1617 ns | 0.0136 ns | 0.0121 ns |  0.99 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.9798 ns | 0.0166 ns | 0.0156 ns |  2.17 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  7.2622 ns | 0.0244 ns | 0.0228 ns |  2.26 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  9.4057 ns | 0.0304 ns | 0.0284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  9.5833 ns | 0.0234 ns | 0.0208 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  3.4309 ns | 0.0584 ns | 0.0546 ns |  0.36 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 |  9.6891 ns | 0.0208 ns | 0.0195 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 |  9.6468 ns | 0.0227 ns | 0.0212 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.7577 ns | 0.0334 ns | 0.0312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.8517 ns | 0.0104 ns | 0.0092 ns |  1.03 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.9514 ns | 0.0384 ns | 0.0359 ns |  1.07 |    0.02 |     - |     - |     - |         - |
         ToDateTime |        net461 |  2.1412 ns | 0.0207 ns | 0.0194 ns |  0.78 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  2.1442 ns | 0.0327 ns | 0.0306 ns |  0.78 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  9.3085 ns | 0.0451 ns | 0.0400 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 | 10.1513 ns | 0.1331 ns | 0.1245 ns |  1.09 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  3.4603 ns | 0.0577 ns | 0.0540 ns |  0.37 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  9.6394 ns | 0.0207 ns | 0.0193 ns |  1.04 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  9.5013 ns | 0.0298 ns | 0.0279 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.1841 ns | 0.0142 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  0.8919 ns | 0.0058 ns | 0.0054 ns |  0.75 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.1190 ns | 0.0033 ns | 0.0031 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.7269 ns | 0.0031 ns | 0.0028 ns |  0.61 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  0.4380 ns | 0.0024 ns | 0.0021 ns |  0.37 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.8838 ns | 0.0100 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.8019 ns | 0.0217 ns | 0.0203 ns |  0.96 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.6238 ns | 0.0063 ns | 0.0052 ns |  0.86 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.7271 ns | 0.0059 ns | 0.0055 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.6968 ns | 0.0060 ns | 0.0053 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.8860 ns | 0.0056 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.8049 ns | 0.0063 ns | 0.0059 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.7468 ns | 0.0097 ns | 0.0091 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.7237 ns | 0.0047 ns | 0.0042 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.6977 ns | 0.0096 ns | 0.0090 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.7818 ns | 0.0449 ns | 0.0420 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.8696 ns | 0.0400 ns | 0.0375 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.4883 ns | 0.0069 ns | 0.0065 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.9190 ns | 0.0403 ns | 0.0377 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.9062 ns | 0.0129 ns | 0.0114 ns |  1.03 |    0.01 |     - |     - |     - |         - |
