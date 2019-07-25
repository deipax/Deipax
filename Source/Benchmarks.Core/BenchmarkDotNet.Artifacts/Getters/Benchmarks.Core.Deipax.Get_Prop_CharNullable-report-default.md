
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FKBDAG : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-JDTBMX : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-AHQSCO : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-QYPIKG : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PVBQDT : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  0.9598 ns | 0.0054 ns | 0.0050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1709 ns | 0.0058 ns | 0.0052 ns |  1.22 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.1655 ns | 0.0039 ns | 0.0036 ns |  1.21 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.5404 ns | 0.0033 ns | 0.0028 ns |  0.56 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7389 ns | 0.0079 ns | 0.0070 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0589 ns | 0.0103 ns | 0.0086 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2641 ns | 0.0162 ns | 0.0143 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0470 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2209 ns | 0.0054 ns | 0.0048 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2391 ns | 0.0151 ns | 0.0141 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.4022 ns | 0.0043 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.0090 ns | 0.0127 ns | 0.0119 ns |  1.43 |    0.01 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.5772 ns | 0.0073 ns | 0.0065 ns |  1.13 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  1.8656 ns | 0.0043 ns | 0.0040 ns |  1.33 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.9006 ns | 0.0051 ns | 0.0048 ns |  1.35 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  0.9676 ns | 0.0047 ns | 0.0044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  1.1672 ns | 0.0058 ns | 0.0054 ns |  1.21 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  0.9803 ns | 0.0111 ns | 0.0098 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  0.9739 ns | 0.0034 ns | 0.0032 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  1.2024 ns | 0.0069 ns | 0.0065 ns |  1.24 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.6978 ns | 0.0071 ns | 0.0059 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.8561 ns | 0.0044 ns | 0.0039 ns |  1.09 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6280 ns | 0.0053 ns | 0.0047 ns |  0.96 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.3131 ns | 0.0083 ns | 0.0077 ns |  1.36 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.5880 ns | 0.0086 ns | 0.0080 ns |  1.52 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.5241 ns | 0.0126 ns | 0.0111 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.5340 ns | 0.0495 ns | 0.0463 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.5653 ns | 0.0176 ns | 0.0156 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.4389 ns | 0.0324 ns | 0.0303 ns |  1.20 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.4037 ns | 0.0221 ns | 0.0196 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.6702 ns | 0.0127 ns | 0.0119 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.6806 ns | 0.0227 ns | 0.0212 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.4464 ns | 0.0048 ns | 0.0045 ns |  0.87 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.0755 ns | 0.0201 ns | 0.0188 ns |  1.24 |    0.02 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3599 ns | 0.0070 ns | 0.0062 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.5106 ns | 0.0099 ns | 0.0078 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.4577 ns | 0.0073 ns | 0.0061 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.5472 ns | 0.0144 ns | 0.0128 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3824 ns | 0.0127 ns | 0.0106 ns |  1.19 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3998 ns | 0.0064 ns | 0.0057 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4845 ns | 0.0062 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.0287 ns | 0.0280 ns | 0.0262 ns |  1.37 |    0.02 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.4892 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  2.3116 ns | 0.0059 ns | 0.0052 ns |  1.56 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  2.6258 ns | 0.0110 ns | 0.0103 ns |  1.77 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.5832 ns | 0.0782 ns | 0.0731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4592 ns | 0.0116 ns | 0.0108 ns |  0.97 |    0.02 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.5153 ns | 0.0101 ns | 0.0095 ns |  0.99 |    0.02 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.2614 ns | 0.0192 ns | 0.0179 ns |  1.15 |    0.02 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3990 ns | 0.0104 ns | 0.0087 ns |  1.18 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.4230 ns | 0.0223 ns | 0.0208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6391 ns | 0.0037 ns | 0.0033 ns |  1.15 |    0.02 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4755 ns | 0.0097 ns | 0.0091 ns |  1.04 |    0.02 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.1518 ns | 0.0048 ns | 0.0045 ns |  0.81 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.4377 ns | 0.0048 ns | 0.0043 ns |  1.01 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.3164 ns | 0.0191 ns | 0.0178 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4552 ns | 0.0077 ns | 0.0072 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0491 ns | 0.0149 ns | 0.0139 ns |  0.94 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.5004 ns | 0.0125 ns | 0.0111 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4638 ns | 0.0027 ns | 0.0021 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.7218 ns | 0.0562 ns | 0.0526 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.7980 ns | 0.0226 ns | 0.0212 ns |  1.05 |    0.03 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.5478 ns | 0.0052 ns | 0.0041 ns |  0.90 |    0.03 |      - |     - |     - |         - |
              ToInt |        net461 |  1.1436 ns | 0.0029 ns | 0.0027 ns |  0.66 |    0.02 |      - |     - |     - |         - |
              ToInt |        net472 |  1.4334 ns | 0.0129 ns | 0.0121 ns |  0.83 |    0.03 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2760 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4621 ns | 0.0079 ns | 0.0062 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0660 ns | 0.0364 ns | 0.0341 ns |  0.95 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4966 ns | 0.0178 ns | 0.0166 ns |  1.05 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4747 ns | 0.0289 ns | 0.0270 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4520 ns | 0.0100 ns | 0.0094 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.6420 ns | 0.0060 ns | 0.0056 ns |  1.13 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4269 ns | 0.0038 ns | 0.0029 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.1550 ns | 0.0095 ns | 0.0084 ns |  0.80 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.7659 ns | 0.0053 ns | 0.0047 ns |  1.22 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2779 ns | 0.0077 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4532 ns | 0.0080 ns | 0.0075 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0514 ns | 0.0242 ns | 0.0226 ns |  0.95 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4593 ns | 0.0102 ns | 0.0091 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4681 ns | 0.0101 ns | 0.0094 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.2559 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.4509 ns | 0.0033 ns | 0.0030 ns |  1.16 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.2513 ns | 0.0170 ns | 0.0159 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  0.9757 ns | 0.0206 ns | 0.0193 ns |  0.78 |    0.02 |      - |     - |     - |         - |
             ToLong |        net472 |  1.2073 ns | 0.0051 ns | 0.0046 ns |  0.96 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.9157 ns | 0.0224 ns | 0.0210 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.8539 ns | 0.0037 ns | 0.0033 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1613 ns | 0.0059 ns | 0.0055 ns |  1.13 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.3602 ns | 0.0067 ns | 0.0063 ns |  1.23 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.4638 ns | 0.0100 ns | 0.0093 ns |  1.29 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.4342 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4451 ns | 0.0193 ns | 0.0180 ns |  1.01 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4482 ns | 0.0280 ns | 0.0262 ns |  1.01 |    0.02 |      - |     - |     - |         - |
            ToULong |        net461 |  1.1765 ns | 0.0045 ns | 0.0042 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.4429 ns | 0.0076 ns | 0.0063 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9084 ns | 0.0185 ns | 0.0173 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8461 ns | 0.0081 ns | 0.0076 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.0250 ns | 0.0064 ns | 0.0053 ns |  1.06 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.5773 ns | 0.0083 ns | 0.0077 ns |  1.35 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.6990 ns | 0.0093 ns | 0.0087 ns |  1.41 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.1955 ns | 0.0057 ns | 0.0053 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1674 ns | 0.0223 ns | 0.0198 ns |  0.98 |    0.02 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.0878 ns | 0.0089 ns | 0.0084 ns |  0.91 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.5850 ns | 0.0046 ns | 0.0039 ns |  0.49 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7234 ns | 0.0048 ns | 0.0045 ns |  0.61 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.0430 ns | 0.0093 ns | 0.0077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4738 ns | 0.0384 ns | 0.0359 ns |  1.11 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2740 ns | 0.0072 ns | 0.0064 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.4667 ns | 0.0187 ns | 0.0165 ns |  1.10 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4675 ns | 0.0117 ns | 0.0110 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.1906 ns | 0.0040 ns | 0.0033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1557 ns | 0.0057 ns | 0.0044 ns |  0.97 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.1721 ns | 0.0057 ns | 0.0045 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.6520 ns | 0.0030 ns | 0.0028 ns |  0.55 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7234 ns | 0.0045 ns | 0.0040 ns |  0.61 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6831 ns | 0.0155 ns | 0.0145 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6603 ns | 0.0184 ns | 0.0172 ns |  0.99 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.0262 ns | 0.0057 ns | 0.0054 ns |  1.20 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.0117 ns | 0.0079 ns | 0.0073 ns |  1.20 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.8069 ns | 0.0045 ns | 0.0042 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.9127 ns | 0.0262 ns | 0.0245 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.8952 ns | 0.0066 ns | 0.0055 ns |  0.99 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.9413 ns | 0.0213 ns | 0.0199 ns |  1.02 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.1602 ns | 0.0120 ns | 0.0106 ns |  3.22 |    0.04 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8721 ns | 0.0119 ns | 0.0105 ns |  3.07 |    0.04 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.6579 ns | 0.0054 ns | 0.0048 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.8632 ns | 0.0161 ns | 0.0134 ns |  1.12 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.6695 ns | 0.0040 ns | 0.0036 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.9117 ns | 0.0141 ns | 0.0125 ns |  1.15 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.9541 ns | 0.0068 ns | 0.0060 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3825 ns | 0.0317 ns | 0.0281 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.4377 ns | 0.0041 ns | 0.0037 ns |  1.02 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3651 ns | 0.0046 ns | 0.0039 ns |  0.99 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1988 ns | 0.0041 ns | 0.0034 ns |  0.50 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.2022 ns | 0.0042 ns | 0.0037 ns |  0.50 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3275 ns | 0.0126 ns | 0.0112 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3367 ns | 0.0659 ns | 0.0616 ns |  1.00 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9591 ns | 0.0168 ns | 0.0157 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.3005 ns | 0.0264 ns | 0.0234 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.9170 ns | 0.0733 ns | 0.0612 ns |  1.07 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  4.0561 ns | 0.0645 ns | 0.0604 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.7063 ns | 0.0337 ns | 0.0315 ns |  1.16 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.6559 ns | 0.0411 ns | 0.0384 ns |  1.15 |    0.02 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.8190 ns | 0.0295 ns | 0.0276 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.8272 ns | 0.0136 ns | 0.0120 ns |  0.94 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  4.5366 ns | 0.0116 ns | 0.0103 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 |  5.0320 ns | 0.0280 ns | 0.0262 ns |  1.11 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 |  4.4694 ns | 0.0375 ns | 0.0351 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 |  6.1387 ns | 0.0211 ns | 0.0187 ns |  1.35 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 |  6.3591 ns | 0.0546 ns | 0.0511 ns |  1.40 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 13.0649 ns | 0.0916 ns | 0.0857 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.5333 ns | 0.0189 ns | 0.0177 ns |  0.96 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.6006 ns | 0.0292 ns | 0.0259 ns |  0.66 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.3926 ns | 0.0376 ns | 0.0333 ns |  1.18 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.4654 ns | 0.0695 ns | 0.0650 ns |  1.18 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 17.0461 ns | 0.0251 ns | 0.0235 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.9936 ns | 0.1335 ns | 0.1249 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2472 ns | 0.0157 ns | 0.0147 ns |  0.78 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 20.0668 ns | 0.0435 ns | 0.0406 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 20.1395 ns | 0.1393 ns | 0.1303 ns |  1.18 |    0.01 |      - |     - |     - |         - |
