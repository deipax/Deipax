
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
             ToBool | .NET Core 2.0 |  1.4984 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4290 ns | 0.0041 ns | 0.0038 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2807 ns | 0.0092 ns | 0.0086 ns |  0.85 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.0086 ns | 0.0041 ns | 0.0038 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9761 ns | 0.0036 ns | 0.0033 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0694 ns | 0.0090 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2242 ns | 0.0132 ns | 0.0117 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0564 ns | 0.0125 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2271 ns | 0.0093 ns | 0.0082 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2571 ns | 0.0550 ns | 0.0514 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5752 ns | 0.0121 ns | 0.0113 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4302 ns | 0.0034 ns | 0.0030 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2638 ns | 0.0035 ns | 0.0029 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  1.0343 ns | 0.0050 ns | 0.0047 ns |  0.66 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  1.0097 ns | 0.0041 ns | 0.0036 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.3059 ns | 0.0119 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.5009 ns | 0.0144 ns | 0.0127 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0530 ns | 0.0096 ns | 0.0085 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4586 ns | 0.0092 ns | 0.0072 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4609 ns | 0.0123 ns | 0.0115 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.6732 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6325 ns | 0.0059 ns | 0.0055 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6365 ns | 0.0062 ns | 0.0058 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.1873 ns | 0.0098 ns | 0.0091 ns |  0.71 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9669 ns | 0.0052 ns | 0.0048 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  1.1822 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  1.1653 ns | 0.0052 ns | 0.0044 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  0.9708 ns | 0.0042 ns | 0.0039 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  1.1964 ns | 0.0046 ns | 0.0041 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  1.0041 ns | 0.0023 ns | 0.0022 ns |  0.85 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.6786 ns | 0.0126 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.5609 ns | 0.0121 ns | 0.0113 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.3357 ns | 0.0026 ns | 0.0021 ns |  0.80 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  1.1840 ns | 0.0057 ns | 0.0053 ns |  0.71 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9782 ns | 0.0035 ns | 0.0031 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.3110 ns | 0.0091 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.3059 ns | 0.0084 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0535 ns | 0.0106 ns | 0.0089 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4959 ns | 0.0192 ns | 0.0180 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4578 ns | 0.0113 ns | 0.0105 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.5081 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5559 ns | 0.0073 ns | 0.0069 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6577 ns | 0.0038 ns | 0.0032 ns |  1.10 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  1.0072 ns | 0.0042 ns | 0.0035 ns |  0.67 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9802 ns | 0.0045 ns | 0.0040 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0706 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2317 ns | 0.0090 ns | 0.0080 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0506 ns | 0.0098 ns | 0.0082 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4633 ns | 0.0161 ns | 0.0143 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4670 ns | 0.0370 ns | 0.0346 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6779 ns | 0.0114 ns | 0.0107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.4983 ns | 0.0046 ns | 0.0041 ns |  0.89 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.5079 ns | 0.0046 ns | 0.0043 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.0095 ns | 0.0045 ns | 0.0035 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9810 ns | 0.0045 ns | 0.0042 ns |  0.58 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.3030 ns | 0.0059 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4766 ns | 0.0321 ns | 0.0300 ns |  1.04 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0569 ns | 0.0131 ns | 0.0116 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4609 ns | 0.0117 ns | 0.0103 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.5002 ns | 0.0208 ns | 0.0184 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.5516 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5016 ns | 0.0046 ns | 0.0036 ns |  0.97 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.2856 ns | 0.0038 ns | 0.0034 ns |  0.83 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.0083 ns | 0.0046 ns | 0.0043 ns |  0.65 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9813 ns | 0.0055 ns | 0.0052 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0639 ns | 0.0057 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2198 ns | 0.0055 ns | 0.0052 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0463 ns | 0.0077 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.5002 ns | 0.0196 ns | 0.0184 ns |  1.11 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4952 ns | 0.0214 ns | 0.0190 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6572 ns | 0.0150 ns | 0.0141 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6346 ns | 0.0053 ns | 0.0044 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4385 ns | 0.0094 ns | 0.0079 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9746 ns | 0.0045 ns | 0.0042 ns |  0.59 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9477 ns | 0.0029 ns | 0.0025 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.3131 ns | 0.0100 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4539 ns | 0.0067 ns | 0.0059 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0796 ns | 0.0154 ns | 0.0136 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.5036 ns | 0.0165 ns | 0.0146 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4529 ns | 0.0106 ns | 0.0094 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4937 ns | 0.0117 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6230 ns | 0.0048 ns | 0.0043 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6357 ns | 0.0045 ns | 0.0037 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  1.0102 ns | 0.0031 ns | 0.0029 ns |  0.68 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9786 ns | 0.0047 ns | 0.0039 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.2479 ns | 0.0037 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0918 ns | 0.0020 ns | 0.0018 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1871 ns | 0.0140 ns | 0.0131 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3053 ns | 0.0035 ns | 0.0031 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1251 ns | 0.0082 ns | 0.0076 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6566 ns | 0.0036 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4312 ns | 0.0052 ns | 0.0048 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.2619 ns | 0.0035 ns | 0.0029 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9780 ns | 0.0070 ns | 0.0062 ns |  0.59 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9472 ns | 0.0055 ns | 0.0046 ns |  0.57 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1831 ns | 0.0042 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1009 ns | 0.0029 ns | 0.0024 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9013 ns | 0.0056 ns | 0.0052 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.2232 ns | 0.0132 ns | 0.0110 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.1165 ns | 0.0240 ns | 0.0224 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5573 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3813 ns | 0.0035 ns | 0.0033 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.4331 ns | 0.0023 ns | 0.0019 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0352 ns | 0.0037 ns | 0.0035 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0034 ns | 0.0066 ns | 0.0062 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2986 ns | 0.0065 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4591 ns | 0.0089 ns | 0.0069 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2815 ns | 0.0067 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.7147 ns | 0.0288 ns | 0.0269 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6973 ns | 0.0218 ns | 0.0193 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6574 ns | 0.0072 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6274 ns | 0.0110 ns | 0.0103 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.3107 ns | 0.0050 ns | 0.0047 ns |  0.79 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.1799 ns | 0.0034 ns | 0.0030 ns |  0.71 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0007 ns | 0.0057 ns | 0.0053 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.2511 ns | 0.0138 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.0920 ns | 0.0077 ns | 0.0065 ns |  0.93 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1564 ns | 0.0173 ns | 0.0162 ns |  0.96 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.2345 ns | 0.0067 ns | 0.0060 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1474 ns | 0.0070 ns | 0.0059 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.2554 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.0870 ns | 0.0068 ns | 0.0057 ns |  0.93 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.3658 ns | 0.0098 ns | 0.0086 ns |  1.05 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.1363 ns | 0.0569 ns | 0.0532 ns |  2.72 |    0.03 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.1486 ns | 0.0558 ns | 0.0522 ns |  2.72 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0996 ns | 0.0162 ns | 0.0144 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.8444 ns | 0.0241 ns | 0.0214 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.3821 ns | 0.0180 ns | 0.0168 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.8288 ns | 0.0288 ns | 0.0269 ns |  1.07 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.7676 ns | 0.0216 ns | 0.0180 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3564 ns | 0.0063 ns | 0.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1263 ns | 0.0041 ns | 0.0038 ns |  0.90 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3715 ns | 0.0088 ns | 0.0074 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.6381 ns | 0.0211 ns | 0.0187 ns |  0.70 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1987 ns | 0.0076 ns | 0.0064 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1026 ns | 0.0263 ns | 0.0233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3246 ns | 0.0241 ns | 0.0201 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.0423 ns | 0.0064 ns | 0.0057 ns |  0.25 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.6622 ns | 0.0224 ns | 0.0198 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.6458 ns | 0.0142 ns | 0.0126 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4794 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.6492 ns | 0.0081 ns | 0.0071 ns |  1.11 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4748 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  1.0145 ns | 0.0117 ns | 0.0097 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9683 ns | 0.0079 ns | 0.0074 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.8010 ns | 0.0038 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6231 ns | 0.0034 ns | 0.0030 ns |  0.90 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.3292 ns | 0.0094 ns | 0.0084 ns |  0.74 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.2864 ns | 0.0042 ns | 0.0035 ns |  0.71 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2660 ns | 0.0207 ns | 0.0173 ns |  0.70 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6543 ns | 0.0056 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.8603 ns | 0.0027 ns | 0.0025 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5629 ns | 0.0037 ns | 0.0033 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2875 ns | 0.0045 ns | 0.0042 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2598 ns | 0.0063 ns | 0.0059 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.3055 ns | 0.0107 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4524 ns | 0.0101 ns | 0.0095 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0520 ns | 0.0064 ns | 0.0054 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6940 ns | 0.0088 ns | 0.0069 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.7067 ns | 0.0327 ns | 0.0306 ns |  1.09 |    0.01 |     - |     - |     - |         - |
