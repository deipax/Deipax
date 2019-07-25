
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
             ToBool | .NET Core 2.0 |  1.4671 ns | 0.0104 ns | 0.0097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4939 ns | 0.0069 ns | 0.0061 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4431 ns | 0.0054 ns | 0.0045 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  1.0118 ns | 0.0084 ns | 0.0079 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9872 ns | 0.0056 ns | 0.0049 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9916 ns | 0.0095 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2127 ns | 0.0074 ns | 0.0066 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0345 ns | 0.0106 ns | 0.0094 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2159 ns | 0.0077 ns | 0.0069 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2268 ns | 0.0081 ns | 0.0076 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5786 ns | 0.0057 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.5174 ns | 0.0077 ns | 0.0068 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.4416 ns | 0.0038 ns | 0.0036 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 |  1.0291 ns | 0.0048 ns | 0.0045 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9888 ns | 0.0077 ns | 0.0072 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2189 ns | 0.0117 ns | 0.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4504 ns | 0.0129 ns | 0.0108 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0415 ns | 0.0095 ns | 0.0079 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4503 ns | 0.0108 ns | 0.0101 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4535 ns | 0.0084 ns | 0.0079 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4602 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.4872 ns | 0.0056 ns | 0.0052 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4360 ns | 0.0113 ns | 0.0106 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  1.0147 ns | 0.0055 ns | 0.0046 ns |  0.69 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9868 ns | 0.0043 ns | 0.0040 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2174 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2191 ns | 0.0088 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0250 ns | 0.0269 ns | 0.0251 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4558 ns | 0.0342 ns | 0.0320 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4570 ns | 0.0114 ns | 0.0101 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.5615 ns | 0.0040 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.4893 ns | 0.0043 ns | 0.0040 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4400 ns | 0.0030 ns | 0.0028 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 |  1.1800 ns | 0.0036 ns | 0.0032 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9842 ns | 0.0038 ns | 0.0034 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2177 ns | 0.0078 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2260 ns | 0.0174 ns | 0.0163 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0313 ns | 0.0078 ns | 0.0073 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4484 ns | 0.0110 ns | 0.0103 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.4559 ns | 0.0096 ns | 0.0085 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.6500 ns | 0.0033 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.5681 ns | 0.0077 ns | 0.0072 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5355 ns | 0.0152 ns | 0.0135 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9945 ns | 0.0047 ns | 0.0044 ns |  0.60 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9730 ns | 0.0056 ns | 0.0052 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  1.1219 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  1.1967 ns | 0.0079 ns | 0.0073 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  1.1636 ns | 0.0035 ns | 0.0031 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  1.2059 ns | 0.0021 ns | 0.0019 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  0.9814 ns | 0.0037 ns | 0.0033 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6474 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.5595 ns | 0.0058 ns | 0.0054 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7084 ns | 0.0056 ns | 0.0050 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.0049 ns | 0.0066 ns | 0.0058 ns |  0.61 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  1.1575 ns | 0.0528 ns | 0.0686 ns |  0.70 |    0.04 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2160 ns | 0.0082 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4539 ns | 0.0087 ns | 0.0072 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0360 ns | 0.0066 ns | 0.0062 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4586 ns | 0.0264 ns | 0.0234 ns |  1.06 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4549 ns | 0.0058 ns | 0.0054 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.5233 ns | 0.0044 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.5286 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4989 ns | 0.0024 ns | 0.0020 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  1.0035 ns | 0.0039 ns | 0.0032 ns |  0.66 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9861 ns | 0.0043 ns | 0.0040 ns |  0.65 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  3.9869 ns | 0.0120 ns | 0.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2167 ns | 0.0082 ns | 0.0077 ns |  1.06 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0373 ns | 0.0223 ns | 0.0208 ns |  1.01 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4772 ns | 0.0360 ns | 0.0336 ns |  1.12 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4518 ns | 0.0073 ns | 0.0065 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.5614 ns | 0.0046 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6640 ns | 0.0098 ns | 0.0087 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6349 ns | 0.0167 ns | 0.0148 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9764 ns | 0.0032 ns | 0.0028 ns |  0.63 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9554 ns | 0.0049 ns | 0.0046 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2642 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4550 ns | 0.0100 ns | 0.0089 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0317 ns | 0.0080 ns | 0.0075 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4714 ns | 0.0369 ns | 0.0345 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4692 ns | 0.0302 ns | 0.0283 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4340 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6669 ns | 0.0091 ns | 0.0076 ns |  1.16 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6277 ns | 0.0053 ns | 0.0045 ns |  1.13 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  1.3556 ns | 0.0055 ns | 0.0051 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9862 ns | 0.0043 ns | 0.0040 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0517 ns | 0.0066 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3032 ns | 0.0071 ns | 0.0066 ns |  1.12 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1695 ns | 0.0068 ns | 0.0061 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.4255 ns | 0.0069 ns | 0.0065 ns |  1.18 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.3507 ns | 0.0045 ns | 0.0039 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.5812 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.5161 ns | 0.0068 ns | 0.0060 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4573 ns | 0.0086 ns | 0.0080 ns |  0.92 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9781 ns | 0.0162 ns | 0.0151 ns |  0.62 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 |  1.2419 ns | 0.0527 ns | 0.0894 ns |  0.78 |    0.07 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0983 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.1980 ns | 0.0058 ns | 0.0055 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.9985 ns | 0.0075 ns | 0.0058 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  2.4227 ns | 0.0088 ns | 0.0082 ns |  1.15 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  2.3436 ns | 0.0057 ns | 0.0051 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.3573 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.3533 ns | 0.0066 ns | 0.0055 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6209 ns | 0.0227 ns | 0.0212 ns |  1.19 |    0.02 |     - |     - |     - |         - |
            ToFloat |        net461 |  1.0277 ns | 0.0053 ns | 0.0049 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0081 ns | 0.0041 ns | 0.0036 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2139 ns | 0.0083 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4513 ns | 0.0057 ns | 0.0050 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2452 ns | 0.0100 ns | 0.0094 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.7112 ns | 0.0420 ns | 0.0393 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6872 ns | 0.0100 ns | 0.0083 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5708 ns | 0.0081 ns | 0.0076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6634 ns | 0.0088 ns | 0.0073 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.9676 ns | 0.0635 ns | 0.0594 ns |  1.25 |    0.04 |     - |     - |     - |         - |
           ToDouble |        net461 |  1.0287 ns | 0.0045 ns | 0.0038 ns |  0.66 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  1.0058 ns | 0.0033 ns | 0.0030 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.0361 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9488 ns | 0.0071 ns | 0.0060 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0413 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1789 ns | 0.0104 ns | 0.0087 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.1592 ns | 0.0125 ns | 0.0111 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.0733 ns | 0.0061 ns | 0.0057 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.1797 ns | 0.0069 ns | 0.0061 ns |  1.05 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.3993 ns | 0.0144 ns | 0.0135 ns |  1.16 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.1000 ns | 0.0126 ns | 0.0111 ns |  2.94 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0941 ns | 0.0150 ns | 0.0125 ns |  2.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.0433 ns | 0.0131 ns | 0.0117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.8439 ns | 0.0154 ns | 0.0136 ns |  1.08 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.4410 ns | 0.0178 ns | 0.0167 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.8581 ns | 0.0380 ns | 0.0355 ns |  1.08 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.8734 ns | 0.0431 ns | 0.0382 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2818 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.2376 ns | 0.0043 ns | 0.0040 ns |  0.98 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3270 ns | 0.0062 ns | 0.0052 ns |  1.02 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.2384 ns | 0.0054 ns | 0.0050 ns |  0.54 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.4549 ns | 0.0041 ns | 0.0035 ns |  0.64 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9558 ns | 0.0149 ns | 0.0132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3814 ns | 0.0190 ns | 0.0169 ns |  1.05 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9152 ns | 0.0026 ns | 0.0024 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.4992 ns | 0.0172 ns | 0.0152 ns |  1.07 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2901 ns | 0.0213 ns | 0.0199 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4475 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.6444 ns | 0.0057 ns | 0.0053 ns |  1.14 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4668 ns | 0.0063 ns | 0.0052 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9927 ns | 0.0036 ns | 0.0034 ns |  0.69 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9738 ns | 0.0054 ns | 0.0047 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.5628 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  2.1410 ns | 0.0186 ns | 0.0174 ns |  1.37 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.4404 ns | 0.0051 ns | 0.0040 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.2828 ns | 0.0039 ns | 0.0034 ns |  0.82 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2603 ns | 0.0024 ns | 0.0021 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.5607 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.4847 ns | 0.0061 ns | 0.0057 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5612 ns | 0.0119 ns | 0.0111 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2865 ns | 0.0044 ns | 0.0041 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2831 ns | 0.0106 ns | 0.0094 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2204 ns | 0.0129 ns | 0.0120 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4530 ns | 0.0100 ns | 0.0088 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0020 ns | 0.0080 ns | 0.0075 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6912 ns | 0.0091 ns | 0.0081 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6809 ns | 0.0056 ns | 0.0050 ns |  1.11 |    0.00 |     - |     - |     - |         - |
