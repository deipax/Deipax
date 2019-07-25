
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
             ToBool | .NET Core 2.0 |  1.4802 ns | 0.0029 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4250 ns | 0.0030 ns | 0.0024 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2751 ns | 0.0095 ns | 0.0084 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.0016 ns | 0.0049 ns | 0.0046 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9732 ns | 0.0052 ns | 0.0046 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0557 ns | 0.0054 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2112 ns | 0.0101 ns | 0.0089 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0395 ns | 0.0063 ns | 0.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2153 ns | 0.0091 ns | 0.0081 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1919 ns | 0.0101 ns | 0.0089 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5434 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.6349 ns | 0.0045 ns | 0.0042 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.6294 ns | 0.0046 ns | 0.0039 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  1.0134 ns | 0.0091 ns | 0.0080 ns |  0.66 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  1.2939 ns | 0.0019 ns | 0.0015 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0787 ns | 0.0243 ns | 0.0227 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.2208 ns | 0.0111 ns | 0.0098 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0443 ns | 0.0074 ns | 0.0066 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4455 ns | 0.0073 ns | 0.0061 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4689 ns | 0.0217 ns | 0.0192 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.9987 ns | 0.0060 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4967 ns | 0.0053 ns | 0.0047 ns |  0.75 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5176 ns | 0.0091 ns | 0.0081 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.0290 ns | 0.0137 ns | 0.0128 ns |  0.52 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9743 ns | 0.0040 ns | 0.0033 ns |  0.49 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2906 ns | 0.0093 ns | 0.0082 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4891 ns | 0.0133 ns | 0.0125 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0451 ns | 0.0159 ns | 0.0141 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4475 ns | 0.0069 ns | 0.0064 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4300 ns | 0.0140 ns | 0.0117 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5551 ns | 0.0057 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.5521 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3165 ns | 0.0030 ns | 0.0028 ns |  0.85 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  1.0043 ns | 0.0054 ns | 0.0050 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9788 ns | 0.0105 ns | 0.0093 ns |  0.63 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2899 ns | 0.0072 ns | 0.0063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4410 ns | 0.0081 ns | 0.0076 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0341 ns | 0.0108 ns | 0.0096 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4462 ns | 0.0106 ns | 0.0099 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4259 ns | 0.0078 ns | 0.0073 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4991 ns | 0.0185 ns | 0.0173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4281 ns | 0.0048 ns | 0.0045 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.4584 ns | 0.0056 ns | 0.0047 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  1.0189 ns | 0.0161 ns | 0.0150 ns |  0.68 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9753 ns | 0.0043 ns | 0.0038 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2903 ns | 0.0087 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4402 ns | 0.0094 ns | 0.0083 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0600 ns | 0.0233 ns | 0.0218 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4454 ns | 0.0065 ns | 0.0054 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4303 ns | 0.0097 ns | 0.0091 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.7200 ns | 0.0052 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4564 ns | 0.0071 ns | 0.0067 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.3004 ns | 0.0029 ns | 0.0027 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9941 ns | 0.0131 ns | 0.0122 ns |  0.58 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9619 ns | 0.0047 ns | 0.0044 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  1.2020 ns | 0.0226 ns | 0.0211 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  1.1674 ns | 0.0071 ns | 0.0066 ns |  0.97 |    0.02 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  0.9718 ns | 0.0039 ns | 0.0035 ns |  0.81 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  1.1877 ns | 0.0042 ns | 0.0035 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  0.9494 ns | 0.0048 ns | 0.0043 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.4990 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5577 ns | 0.0101 ns | 0.0090 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4448 ns | 0.0026 ns | 0.0022 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.0046 ns | 0.0100 ns | 0.0089 ns |  0.67 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9764 ns | 0.0037 ns | 0.0031 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0508 ns | 0.0050 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2119 ns | 0.0101 ns | 0.0084 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0403 ns | 0.0072 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.5063 ns | 0.0411 ns | 0.0384 ns |  1.11 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4315 ns | 0.0128 ns | 0.0120 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6492 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6210 ns | 0.0036 ns | 0.0033 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2858 ns | 0.0036 ns | 0.0032 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.1769 ns | 0.0052 ns | 0.0049 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9820 ns | 0.0045 ns | 0.0042 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0850 ns | 0.0262 ns | 0.0245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2062 ns | 0.0077 ns | 0.0064 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0385 ns | 0.0085 ns | 0.0079 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4500 ns | 0.0083 ns | 0.0073 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4191 ns | 0.0122 ns | 0.0108 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.5170 ns | 0.0028 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4242 ns | 0.0042 ns | 0.0039 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5507 ns | 0.0139 ns | 0.0130 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  1.0041 ns | 0.0046 ns | 0.0043 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9746 ns | 0.0033 ns | 0.0029 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9579 ns | 0.0058 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8260 ns | 0.0037 ns | 0.0029 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9986 ns | 0.0115 ns | 0.0107 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9598 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.8835 ns | 0.0189 ns | 0.0177 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6558 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4263 ns | 0.0059 ns | 0.0052 ns |  0.86 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4982 ns | 0.0037 ns | 0.0031 ns |  0.91 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9997 ns | 0.0046 ns | 0.0039 ns |  0.60 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9730 ns | 0.0067 ns | 0.0056 ns |  0.59 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0472 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8681 ns | 0.0142 ns | 0.0126 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9176 ns | 0.0025 ns | 0.0021 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.4977 ns | 0.0080 ns | 0.0071 ns |  1.22 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.4266 ns | 0.0127 ns | 0.0119 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5418 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3701 ns | 0.0047 ns | 0.0044 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3047 ns | 0.0052 ns | 0.0046 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0266 ns | 0.0036 ns | 0.0031 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  0.9957 ns | 0.0042 ns | 0.0037 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2895 ns | 0.0104 ns | 0.0092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4441 ns | 0.0062 ns | 0.0055 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2967 ns | 0.0269 ns | 0.0252 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6778 ns | 0.0095 ns | 0.0079 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6501 ns | 0.0057 ns | 0.0050 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6485 ns | 0.0055 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3841 ns | 0.0050 ns | 0.0044 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.2393 ns | 0.0034 ns | 0.0031 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.1716 ns | 0.0042 ns | 0.0035 ns |  0.71 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0047 ns | 0.0024 ns | 0.0022 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1762 ns | 0.0133 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0785 ns | 0.0045 ns | 0.0042 ns |  0.96 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1422 ns | 0.0056 ns | 0.0050 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1350 ns | 0.0034 ns | 0.0031 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1051 ns | 0.0094 ns | 0.0079 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2945 ns | 0.0051 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.3143 ns | 0.0053 ns | 0.0047 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.3698 ns | 0.0049 ns | 0.0046 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.0848 ns | 0.0149 ns | 0.0132 ns |  2.65 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0635 ns | 0.0124 ns | 0.0110 ns |  2.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0989 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7950 ns | 0.0176 ns | 0.0165 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.1753 ns | 0.0073 ns | 0.0064 ns |  0.22 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.7888 ns | 0.0235 ns | 0.0196 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7437 ns | 0.0225 ns | 0.0188 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3504 ns | 0.0038 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1201 ns | 0.0081 ns | 0.0072 ns |  0.90 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3447 ns | 0.0143 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1954 ns | 0.0044 ns | 0.0041 ns |  0.51 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.0106 ns | 0.0047 ns | 0.0044 ns |  0.43 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0093 ns | 0.0123 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.5369 ns | 0.0223 ns | 0.0209 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9516 ns | 0.0077 ns | 0.0072 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 12.3915 ns | 0.0170 ns | 0.0159 ns |  1.55 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3568 ns | 0.0217 ns | 0.0181 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4756 ns | 0.0059 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.4386 ns | 0.0050 ns | 0.0039 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.3231 ns | 0.0153 ns | 0.0143 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9889 ns | 0.0057 ns | 0.0054 ns |  0.67 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9669 ns | 0.0062 ns | 0.0055 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.6464 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6233 ns | 0.0088 ns | 0.0078 ns |  0.99 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.3256 ns | 0.0128 ns | 0.0119 ns |  0.81 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.3335 ns | 0.0031 ns | 0.0024 ns |  0.81 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.3159 ns | 0.0077 ns | 0.0068 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6494 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.7583 ns | 0.0055 ns | 0.0052 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.2780 ns | 0.0061 ns | 0.0057 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2924 ns | 0.0108 ns | 0.0084 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2539 ns | 0.0032 ns | 0.0028 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.3270 ns | 0.0175 ns | 0.0163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4410 ns | 0.0077 ns | 0.0072 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0390 ns | 0.0044 ns | 0.0037 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.5306 ns | 0.0098 ns | 0.0092 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6838 ns | 0.0305 ns | 0.0285 ns |  1.08 |    0.01 |     - |     - |     - |         - |
