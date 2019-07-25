
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
             ToBool | .NET Core 2.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
             ToBool |        net461 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
             ToBool |        net472 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable |        net461 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
     ToBoolNullable |        net472 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  3.2137 ns | 0.0490 ns | 0.0459 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.8487 ns | 0.0076 ns | 0.0068 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  3.5159 ns | 0.0442 ns | 0.0369 ns |  1.09 |    0.02 |     - |     - |     - |         - |
             ToChar |        net461 |  2.6165 ns | 0.0146 ns | 0.0129 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             ToChar |        net472 |  2.6081 ns | 0.0077 ns | 0.0068 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.6721 ns | 0.0111 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.6159 ns | 0.0108 ns | 0.0101 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  5.6520 ns | 0.0101 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  5.6207 ns | 0.0127 ns | 0.0112 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  5.5752 ns | 0.0090 ns | 0.0075 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 | 49.6821 ns | 0.8148 ns | 0.7621 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 42.9450 ns | 0.0823 ns | 0.0729 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  8.9340 ns | 0.0169 ns | 0.0150 ns |  0.18 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 | 46.6355 ns | 0.1526 ns | 0.1427 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 | 46.7834 ns | 0.4426 ns | 0.4140 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 49.4583 ns | 0.0872 ns | 0.0773 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 49.6705 ns | 0.0653 ns | 0.0546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 | 11.7346 ns | 0.0295 ns | 0.0261 ns |  0.24 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 47.8479 ns | 0.2711 ns | 0.2536 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 47.0659 ns | 0.1132 ns | 0.1059 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 | 47.1831 ns | 0.1121 ns | 0.0936 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 42.1559 ns | 0.1091 ns | 0.1021 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 | 10.5135 ns | 0.1011 ns | 0.0946 ns |  0.22 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 | 45.6002 ns | 0.1223 ns | 0.1084 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 | 45.6187 ns | 0.0852 ns | 0.0756 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 | 48.3414 ns | 0.1077 ns | 0.1008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 48.5357 ns | 0.0979 ns | 0.0868 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 | 11.4706 ns | 0.0198 ns | 0.0185 ns |  0.24 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 46.5849 ns | 0.3338 ns | 0.3122 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 46.7235 ns | 0.2610 ns | 0.2441 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 | 48.8451 ns | 0.1122 ns | 0.1049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 43.2027 ns | 0.0673 ns | 0.0630 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  9.0457 ns | 0.0363 ns | 0.0303 ns |  0.19 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 | 45.4468 ns | 0.1009 ns | 0.0944 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 | 45.5107 ns | 0.1125 ns | 0.1052 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 | 48.2984 ns | 0.1290 ns | 0.1144 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 50.3777 ns | 0.0659 ns | 0.0584 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 | 11.7328 ns | 0.0244 ns | 0.0216 ns |  0.24 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 45.5930 ns | 0.0790 ns | 0.0700 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 45.5517 ns | 0.2156 ns | 0.1800 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 | 48.1830 ns | 0.0835 ns | 0.0741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 41.6914 ns | 0.0893 ns | 0.0792 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 | 10.0574 ns | 0.0150 ns | 0.0133 ns |  0.21 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 | 47.1007 ns | 0.1005 ns | 0.0940 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 | 47.1907 ns | 0.1117 ns | 0.0991 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 48.5647 ns | 0.1128 ns | 0.1000 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 48.3147 ns | 0.1157 ns | 0.1026 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 | 11.5600 ns | 0.0886 ns | 0.0829 ns |  0.24 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 48.0724 ns | 0.1225 ns | 0.1023 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 47.8449 ns | 0.1293 ns | 0.1146 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 | 46.9917 ns | 0.1053 ns | 0.0985 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 41.8231 ns | 0.0964 ns | 0.0902 ns |  0.89 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 | 11.0821 ns | 0.0553 ns | 0.0491 ns |  0.24 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 | 44.8489 ns | 0.2253 ns | 0.1997 ns |  0.95 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 | 44.4853 ns | 0.2391 ns | 0.2119 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 | 47.3343 ns | 0.2019 ns | 0.1790 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 48.5388 ns | 0.5214 ns | 0.4877 ns |  1.02 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 | 12.9589 ns | 0.0426 ns | 0.0378 ns |  0.27 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 45.0251 ns | 0.1311 ns | 0.1162 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 45.0071 ns | 0.1018 ns | 0.0903 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 | 46.8466 ns | 0.0352 ns | 0.0312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 40.3433 ns | 0.0962 ns | 0.0803 ns |  0.86 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 | 11.9992 ns | 0.0319 ns | 0.0283 ns |  0.26 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 | 45.6038 ns | 0.1427 ns | 0.1192 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 | 45.4860 ns | 0.3079 ns | 0.2571 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 47.2819 ns | 0.1235 ns | 0.1095 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 47.6648 ns | 0.2837 ns | 0.2654 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 | 13.0226 ns | 0.1007 ns | 0.0942 ns |  0.28 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 46.3995 ns | 0.0823 ns | 0.0730 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 46.1004 ns | 0.1078 ns | 0.1009 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 | 49.0058 ns | 0.1695 ns | 0.1503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 40.8208 ns | 0.0872 ns | 0.0816 ns |  0.83 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 | 11.0041 ns | 0.0668 ns | 0.0625 ns |  0.22 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 | 47.5778 ns | 0.0902 ns | 0.0844 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 | 47.6168 ns | 0.0726 ns | 0.0607 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 | 49.8553 ns | 0.1050 ns | 0.0931 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 41.9883 ns | 0.0312 ns | 0.0260 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 | 11.8548 ns | 0.0310 ns | 0.0242 ns |  0.24 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 | 47.7854 ns | 0.0654 ns | 0.0611 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 | 48.5428 ns | 0.0770 ns | 0.0683 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 | 46.8248 ns | 0.0908 ns | 0.0850 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 40.8949 ns | 0.0618 ns | 0.0578 ns |  0.87 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 | 11.3185 ns | 0.0808 ns | 0.0675 ns |  0.24 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 | 46.7009 ns | 0.0974 ns | 0.0911 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 | 46.2588 ns | 0.2146 ns | 0.2008 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 | 48.6466 ns | 0.0972 ns | 0.0861 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 42.4720 ns | 0.0780 ns | 0.0691 ns |  0.87 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 | 12.5762 ns | 0.0221 ns | 0.0196 ns |  0.26 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 | 46.8750 ns | 0.0959 ns | 0.0801 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 | 46.8738 ns | 0.1064 ns | 0.0996 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 | 57.7901 ns | 0.1014 ns | 0.0899 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 61.6849 ns | 0.2121 ns | 0.1880 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 | 46.5204 ns | 0.3303 ns | 0.3089 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 | 58.6779 ns | 0.0973 ns | 0.0910 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 | 58.5598 ns | 0.0820 ns | 0.0685 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 59.7313 ns | 0.3876 ns | 0.3626 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 67.5216 ns | 0.2078 ns | 0.1735 ns |  1.13 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 | 42.8421 ns | 0.0859 ns | 0.0762 ns |  0.72 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 59.8101 ns | 0.3890 ns | 0.3639 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 59.7284 ns | 0.3826 ns | 0.3579 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 | 58.1348 ns | 0.0629 ns | 0.0558 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 61.9597 ns | 0.1922 ns | 0.1704 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 | 46.3411 ns | 0.3152 ns | 0.2948 ns |  0.80 |    0.01 |     - |     - |     - |         - |
           ToDouble |        net461 | 58.8503 ns | 0.2232 ns | 0.1978 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 | 58.4266 ns | 0.1378 ns | 0.1221 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 | 59.1826 ns | 0.2443 ns | 0.2285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 | 62.9086 ns | 0.4527 ns | 0.4013 ns |  1.06 |    0.01 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 | 44.5059 ns | 0.1654 ns | 0.1547 ns |  0.75 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 | 59.9297 ns | 0.1408 ns | 0.1248 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 | 60.4410 ns | 0.5445 ns | 0.5093 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 | 71.0873 ns | 0.1711 ns | 0.1600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 | 65.0805 ns | 0.3635 ns | 0.3401 ns |  0.92 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 | 45.7032 ns | 0.2067 ns | 0.1832 ns |  0.64 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 | 72.2916 ns | 0.1702 ns | 0.1592 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net472 | 72.6176 ns | 0.1832 ns | 0.1624 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 78.0849 ns | 0.2719 ns | 0.2410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 73.3174 ns | 0.1832 ns | 0.1714 ns |  0.94 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 50.0608 ns | 0.0950 ns | 0.0888 ns |  0.64 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 80.0232 ns | 0.4213 ns | 0.3941 ns |  1.03 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 79.9658 ns | 0.2148 ns | 0.1904 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime |        net461 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
         ToDateTime |        net472 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |         NA |        NA |        NA |     ? |       ? |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  2.1654 ns | 0.0066 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  0.9655 ns | 0.0040 ns | 0.0038 ns |  0.45 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.1567 ns | 0.0048 ns | 0.0042 ns |  0.53 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  2.2161 ns | 0.0061 ns | 0.0057 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  2.2179 ns | 0.0169 ns | 0.0158 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  0.9326 ns | 0.0061 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  0.9678 ns | 0.0046 ns | 0.0040 ns |  1.04 |    0.01 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.1157 ns | 0.0037 ns | 0.0031 ns |  1.20 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  0.7731 ns | 0.0046 ns | 0.0040 ns |  0.83 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  0.7315 ns | 0.0024 ns | 0.0021 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 | 19.3605 ns | 0.0803 ns | 0.0712 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 20.7525 ns | 0.1514 ns | 0.1416 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 14.8345 ns | 0.0352 ns | 0.0329 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 27.6612 ns | 0.0609 ns | 0.0570 ns |  1.43 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 | 28.2937 ns | 0.0400 ns | 0.0355 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 19.4670 ns | 0.0799 ns | 0.0709 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 21.1948 ns | 0.0607 ns | 0.0538 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 15.6393 ns | 0.0357 ns | 0.0316 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 29.8067 ns | 0.0964 ns | 0.0855 ns |  1.53 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 30.5968 ns | 0.2313 ns | 0.2163 ns |  1.57 |    0.01 |     - |     - |     - |         - |

Benchmarks with issues:
  Get_Prop_String.ToBool: Job-FKBDAG(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToBool: Job-JDTBMX(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToBool: Job-AHQSCO(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToBool: Job-QYPIKG(Toolchain=net461)
  Get_Prop_String.ToBool: Job-PVBQDT(Toolchain=net472)
  Get_Prop_String.ToBoolNullable: Job-FKBDAG(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToBoolNullable: Job-JDTBMX(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToBoolNullable: Job-AHQSCO(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToBoolNullable: Job-QYPIKG(Toolchain=net461)
  Get_Prop_String.ToBoolNullable: Job-PVBQDT(Toolchain=net472)
  Get_Prop_String.ToDateTime: Job-FKBDAG(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToDateTime: Job-JDTBMX(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToDateTime: Job-AHQSCO(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToDateTime: Job-QYPIKG(Toolchain=net461)
  Get_Prop_String.ToDateTime: Job-PVBQDT(Toolchain=net472)
  Get_Prop_String.ToDateTimeNullable: Job-FKBDAG(Toolchain=.NET Core 2.0)
  Get_Prop_String.ToDateTimeNullable: Job-JDTBMX(Toolchain=.NET Core 2.2)
  Get_Prop_String.ToDateTimeNullable: Job-AHQSCO(Toolchain=.NET Core 3.0)
  Get_Prop_String.ToDateTimeNullable: Job-QYPIKG(Toolchain=net461)
  Get_Prop_String.ToDateTimeNullable: Job-PVBQDT(Toolchain=net472)
