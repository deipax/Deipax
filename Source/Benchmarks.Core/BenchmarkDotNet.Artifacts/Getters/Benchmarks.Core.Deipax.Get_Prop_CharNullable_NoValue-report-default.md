
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
             ToBool | .NET Core 2.0 |  0.9605 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1691 ns | 0.0033 ns | 0.0030 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.0562 ns | 0.0090 ns | 0.0075 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.5375 ns | 0.0134 ns | 0.0125 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.7355 ns | 0.0048 ns | 0.0045 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0472 ns | 0.0079 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2615 ns | 0.0217 ns | 0.0203 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0441 ns | 0.0084 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2711 ns | 0.0074 ns | 0.0069 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2297 ns | 0.0085 ns | 0.0071 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.4515 ns | 0.0110 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5551 ns | 0.0049 ns | 0.0046 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2752 ns | 0.0047 ns | 0.0042 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9708 ns | 0.0036 ns | 0.0030 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  1.2152 ns | 0.0031 ns | 0.0028 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  0.9638 ns | 0.0050 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  1.4182 ns | 0.0033 ns | 0.0029 ns |  1.47 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  1.5540 ns | 0.0189 ns | 0.0177 ns |  1.61 |    0.02 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  0.9828 ns | 0.0138 ns | 0.0129 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  1.1954 ns | 0.0042 ns | 0.0035 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.3834 ns | 0.0233 ns | 0.0218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.6344 ns | 0.0030 ns | 0.0025 ns |  1.18 |    0.02 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6305 ns | 0.0046 ns | 0.0041 ns |  1.18 |    0.02 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9858 ns | 0.0053 ns | 0.0047 ns |  0.71 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  1.1857 ns | 0.0038 ns | 0.0035 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2765 ns | 0.0087 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4505 ns | 0.0116 ns | 0.0103 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0430 ns | 0.0061 ns | 0.0051 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4544 ns | 0.0072 ns | 0.0064 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4628 ns | 0.0094 ns | 0.0073 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.4250 ns | 0.0026 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4321 ns | 0.0061 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4530 ns | 0.0139 ns | 0.0124 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9901 ns | 0.0092 ns | 0.0086 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  1.0130 ns | 0.0053 ns | 0.0047 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2849 ns | 0.0104 ns | 0.0097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4741 ns | 0.0277 ns | 0.0259 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0442 ns | 0.0137 ns | 0.0114 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4491 ns | 0.0055 ns | 0.0043 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4664 ns | 0.0119 ns | 0.0111 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.2774 ns | 0.0104 ns | 0.0097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5660 ns | 0.0090 ns | 0.0084 ns |  1.23 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.7350 ns | 0.0038 ns | 0.0033 ns |  1.36 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9812 ns | 0.0056 ns | 0.0050 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  1.0146 ns | 0.0114 ns | 0.0106 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2823 ns | 0.0086 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4529 ns | 0.0079 ns | 0.0074 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0458 ns | 0.0130 ns | 0.0115 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4510 ns | 0.0080 ns | 0.0075 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4631 ns | 0.0086 ns | 0.0080 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.4065 ns | 0.0055 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6345 ns | 0.0044 ns | 0.0041 ns |  1.16 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.2812 ns | 0.0094 ns | 0.0088 ns |  0.91 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9955 ns | 0.0072 ns | 0.0060 ns |  0.71 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.2148 ns | 0.0114 ns | 0.0101 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0451 ns | 0.0068 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2323 ns | 0.0101 ns | 0.0094 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0400 ns | 0.0090 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4539 ns | 0.0088 ns | 0.0082 ns |  1.10 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4594 ns | 0.0088 ns | 0.0078 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.2359 ns | 0.0143 ns | 0.0134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5610 ns | 0.0037 ns | 0.0031 ns |  1.26 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.3116 ns | 0.0079 ns | 0.0070 ns |  1.06 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9824 ns | 0.0039 ns | 0.0030 ns |  0.79 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  1.0242 ns | 0.0150 ns | 0.0140 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0538 ns | 0.0193 ns | 0.0181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2207 ns | 0.0078 ns | 0.0073 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0635 ns | 0.0272 ns | 0.0255 ns |  1.00 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4528 ns | 0.0068 ns | 0.0063 ns |  1.10 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4570 ns | 0.0094 ns | 0.0084 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4288 ns | 0.0047 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6307 ns | 0.0056 ns | 0.0052 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4416 ns | 0.0213 ns | 0.0199 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  1.0662 ns | 0.0179 ns | 0.0168 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.2003 ns | 0.0048 ns | 0.0045 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0419 ns | 0.0066 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2337 ns | 0.0129 ns | 0.0115 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0766 ns | 0.0267 ns | 0.0250 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4567 ns | 0.0107 ns | 0.0100 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4677 ns | 0.0087 ns | 0.0081 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.2720 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4266 ns | 0.0111 ns | 0.0099 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.2549 ns | 0.0028 ns | 0.0025 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9786 ns | 0.0043 ns | 0.0036 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  1.0106 ns | 0.0050 ns | 0.0047 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9183 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8528 ns | 0.0101 ns | 0.0089 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1601 ns | 0.0058 ns | 0.0054 ns |  1.13 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9146 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.9588 ns | 0.0081 ns | 0.0072 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4363 ns | 0.0095 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4291 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4334 ns | 0.0051 ns | 0.0048 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9866 ns | 0.0089 ns | 0.0083 ns |  0.69 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  1.0191 ns | 0.0128 ns | 0.0120 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9015 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8423 ns | 0.0044 ns | 0.0041 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9001 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.3557 ns | 0.0112 ns | 0.0105 ns |  1.24 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.4875 ns | 0.0089 ns | 0.0079 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1887 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1494 ns | 0.0139 ns | 0.0130 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.1695 ns | 0.0043 ns | 0.0038 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.6539 ns | 0.0053 ns | 0.0050 ns |  0.55 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  0.7215 ns | 0.0067 ns | 0.0059 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.0471 ns | 0.0113 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4565 ns | 0.0149 ns | 0.0132 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2671 ns | 0.0074 ns | 0.0070 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4761 ns | 0.0427 ns | 0.0400 ns |  1.11 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.5027 ns | 0.0143 ns | 0.0134 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.2132 ns | 0.0071 ns | 0.0063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1700 ns | 0.0125 ns | 0.0105 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.0671 ns | 0.0047 ns | 0.0042 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.6548 ns | 0.0030 ns | 0.0028 ns |  0.54 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.7209 ns | 0.0019 ns | 0.0016 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6664 ns | 0.0053 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6192 ns | 0.0046 ns | 0.0041 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.9092 ns | 0.0219 ns | 0.0194 ns |  1.14 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6826 ns | 0.0244 ns | 0.0228 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.8087 ns | 0.0067 ns | 0.0063 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.8965 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.8936 ns | 0.0077 ns | 0.0068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.9396 ns | 0.0076 ns | 0.0063 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  5.8610 ns | 0.0060 ns | 0.0057 ns |  3.09 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  5.8672 ns | 0.0106 ns | 0.0094 ns |  3.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.6618 ns | 0.0060 ns | 0.0056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.8541 ns | 0.0044 ns | 0.0039 ns |  1.12 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.6658 ns | 0.0045 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.8991 ns | 0.0032 ns | 0.0030 ns |  1.14 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.9627 ns | 0.0226 ns | 0.0211 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3674 ns | 0.0083 ns | 0.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1298 ns | 0.0044 ns | 0.0041 ns |  0.90 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3667 ns | 0.0057 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.2057 ns | 0.0101 ns | 0.0095 ns |  0.51 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.2051 ns | 0.0044 ns | 0.0041 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3562 ns | 0.0471 ns | 0.0441 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3110 ns | 0.0236 ns | 0.0221 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9497 ns | 0.0070 ns | 0.0062 ns |  0.23 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2856 ns | 0.0133 ns | 0.0104 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 12.4396 ns | 0.0254 ns | 0.0225 ns |  1.49 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4104 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.6361 ns | 0.0086 ns | 0.0072 ns |  1.16 |    0.01 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2901 ns | 0.0053 ns | 0.0044 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  1.2925 ns | 0.0065 ns | 0.0061 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.0142 ns | 0.0166 ns | 0.0155 ns |  0.72 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4330 ns | 0.0091 ns | 0.0085 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.6347 ns | 0.0070 ns | 0.0062 ns |  1.14 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.6808 ns | 0.0040 ns | 0.0033 ns |  1.17 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.2535 ns | 0.0150 ns | 0.0140 ns |  0.87 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2927 ns | 0.0081 ns | 0.0076 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.4279 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.6308 ns | 0.0036 ns | 0.0034 ns |  1.14 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.4319 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.3139 ns | 0.0036 ns | 0.0028 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.3464 ns | 0.0045 ns | 0.0042 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2771 ns | 0.0086 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4810 ns | 0.0287 ns | 0.0268 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0391 ns | 0.0081 ns | 0.0072 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6871 ns | 0.0079 ns | 0.0074 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.7042 ns | 0.0124 ns | 0.0116 ns |  1.10 |    0.00 |     - |     - |     - |         - |
