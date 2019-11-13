
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  9.3702 ns | 0.0142 ns | 0.0133 ns |  9.3650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  9.9360 ns | 0.0117 ns | 0.0104 ns |  9.9336 ns |  1.06 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.6261 ns | 0.0041 ns | 0.0036 ns |  1.6266 ns |  0.17 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  9.9896 ns | 0.0086 ns | 0.0072 ns |  9.9899 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 | 11.6244 ns | 0.0116 ns | 0.0109 ns | 11.6262 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  9.7331 ns | 0.0087 ns | 0.0081 ns |  9.7328 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 10.1700 ns | 0.0202 ns | 0.0179 ns | 10.1693 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  5.2021 ns | 0.0344 ns | 0.0322 ns |  5.2125 ns |  0.53 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  9.9043 ns | 0.0144 ns | 0.0127 ns |  9.9060 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 | 10.1415 ns | 0.0127 ns | 0.0118 ns | 10.1440 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  0.8686 ns | 0.0030 ns | 0.0026 ns |  0.8679 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  0.9332 ns | 0.0021 ns | 0.0020 ns |  0.9334 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1691 ns | 0.0021 ns | 0.0018 ns |  1.1690 ns |  1.35 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.4351 ns | 0.0042 ns | 0.0035 ns |  0.4361 ns |  0.50 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.7196 ns | 0.0062 ns | 0.0055 ns |  0.7178 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9629 ns | 0.0051 ns | 0.0048 ns |  3.9640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1669 ns | 0.0047 ns | 0.0044 ns |  4.1673 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0070 ns | 0.0064 ns | 0.0060 ns |  4.0082 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1435 ns | 0.0058 ns | 0.0051 ns |  4.1437 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1440 ns | 0.0050 ns | 0.0041 ns |  4.1441 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 | 10.9271 ns | 0.0117 ns | 0.0104 ns | 10.9277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  9.9394 ns | 0.0090 ns | 0.0084 ns |  9.9390 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.6223 ns | 0.0024 ns | 0.0022 ns |  1.6222 ns |  0.15 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  9.9935 ns | 0.0098 ns | 0.0087 ns |  9.9921 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 | 10.1219 ns | 0.0151 ns | 0.0134 ns | 10.1196 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 10.0478 ns | 0.0403 ns | 0.0377 ns | 10.0585 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  9.9494 ns | 0.0127 ns | 0.0118 ns |  9.9504 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  5.1646 ns | 0.0058 ns | 0.0054 ns |  5.1651 ns |  0.51 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 10.1033 ns | 0.0162 ns | 0.0152 ns | 10.1083 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  9.9094 ns | 0.0123 ns | 0.0102 ns |  9.9099 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  9.2711 ns | 0.0115 ns | 0.0108 ns |  9.2721 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  9.9912 ns | 0.0623 ns | 0.0582 ns | 10.0241 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.6347 ns | 0.0122 ns | 0.0108 ns |  1.6397 ns |  0.18 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 | 10.0943 ns | 0.0483 ns | 0.0452 ns | 10.1103 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 | 10.0336 ns | 0.0143 ns | 0.0134 ns | 10.0322 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  9.9677 ns | 0.0126 ns | 0.0112 ns |  9.9655 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 10.1286 ns | 0.0074 ns | 0.0066 ns | 10.1288 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  5.1629 ns | 0.0053 ns | 0.0050 ns |  5.1629 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 14.9810 ns | 0.0136 ns | 0.0121 ns | 14.9845 ns |  1.50 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 10.0995 ns | 0.0099 ns | 0.0083 ns | 10.0994 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  9.2665 ns | 0.0083 ns | 0.0077 ns |  9.2676 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  9.9290 ns | 0.0124 ns | 0.0110 ns |  9.9289 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6239 ns | 0.0027 ns | 0.0026 ns |  1.6239 ns |  0.18 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 |  9.9862 ns | 0.0133 ns | 0.0118 ns |  9.9816 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 | 10.0329 ns | 0.0071 ns | 0.0067 ns | 10.0322 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  9.7308 ns | 0.0115 ns | 0.0108 ns |  9.7285 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 10.1367 ns | 0.0105 ns | 0.0093 ns | 10.1354 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  5.1618 ns | 0.0041 ns | 0.0036 ns |  5.1618 ns |  0.53 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  9.9116 ns | 0.0071 ns | 0.0067 ns |  9.9118 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 10.1594 ns | 0.0502 ns | 0.0469 ns | 10.1880 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  9.4057 ns | 0.0138 ns | 0.0129 ns |  9.4011 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  9.9437 ns | 0.0122 ns | 0.0114 ns |  9.9433 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.6235 ns | 0.0027 ns | 0.0022 ns |  1.6238 ns |  0.17 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  9.9937 ns | 0.0093 ns | 0.0078 ns |  9.9936 ns |  1.06 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 | 10.0365 ns | 0.0097 ns | 0.0090 ns | 10.0384 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  9.7305 ns | 0.0202 ns | 0.0169 ns |  9.7290 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  9.9255 ns | 0.0089 ns | 0.0083 ns |  9.9287 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  5.1610 ns | 0.0065 ns | 0.0058 ns |  5.1607 ns |  0.53 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 10.1750 ns | 0.0505 ns | 0.0473 ns | 10.1874 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  9.9097 ns | 0.0109 ns | 0.0102 ns |  9.9110 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  9.3071 ns | 0.0078 ns | 0.0073 ns |  9.3058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  9.9324 ns | 0.0071 ns | 0.0067 ns |  9.9327 ns |  1.07 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6485 ns | 0.0181 ns | 0.0169 ns |  1.6542 ns |  0.18 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 | 11.0623 ns | 0.0158 ns | 0.0148 ns | 11.0668 ns |  1.19 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 | 10.0133 ns | 0.0084 ns | 0.0079 ns | 10.0141 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  9.9447 ns | 0.0047 ns | 0.0039 ns |  9.9452 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  9.9432 ns | 0.0133 ns | 0.0124 ns |  9.9386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  5.1680 ns | 0.0086 ns | 0.0080 ns |  5.1702 ns |  0.52 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 10.1100 ns | 0.0147 ns | 0.0130 ns | 10.1140 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 10.0161 ns | 0.0130 ns | 0.0122 ns | 10.0169 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  9.2992 ns | 0.0112 ns | 0.0099 ns |  9.3002 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 10.0280 ns | 0.0508 ns | 0.0476 ns | 10.0454 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6244 ns | 0.0026 ns | 0.0022 ns |  1.6251 ns |  0.17 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  9.9636 ns | 0.0072 ns | 0.0068 ns |  9.9622 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 | 10.0061 ns | 0.0086 ns | 0.0076 ns | 10.0059 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  9.9817 ns | 0.0214 ns | 0.0200 ns |  9.9824 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 10.1447 ns | 0.0104 ns | 0.0097 ns | 10.1453 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  5.1639 ns | 0.0044 ns | 0.0041 ns |  5.1629 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  9.9237 ns | 0.0160 ns | 0.0150 ns |  9.9280 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 10.1157 ns | 0.0086 ns | 0.0081 ns | 10.1154 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  9.2963 ns | 0.0093 ns | 0.0087 ns |  9.2969 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 10.0124 ns | 0.0453 ns | 0.0424 ns | 10.0308 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.8507 ns | 0.0027 ns | 0.0024 ns |  1.8510 ns |  0.20 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 | 10.0763 ns | 0.0127 ns | 0.0113 ns | 10.0776 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  9.9880 ns | 0.0094 ns | 0.0078 ns |  9.9891 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  8.5796 ns | 0.0150 ns | 0.0133 ns |  8.5807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  8.4835 ns | 0.0167 ns | 0.0156 ns |  8.4824 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.4438 ns | 0.0059 ns | 0.0055 ns |  2.4448 ns |  0.28 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  9.0597 ns | 0.0131 ns | 0.0122 ns |  9.0611 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  8.6072 ns | 0.0157 ns | 0.0147 ns |  8.6068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  9.4069 ns | 0.0656 ns | 0.0613 ns |  9.4223 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  9.9274 ns | 0.0104 ns | 0.0097 ns |  9.9289 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.8575 ns | 0.0048 ns | 0.0045 ns |  1.8564 ns |  0.20 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  9.9688 ns | 0.0119 ns | 0.0106 ns |  9.9686 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            ToULong |        net472 | 10.1023 ns | 0.0096 ns | 0.0090 ns | 10.1020 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  8.4363 ns | 0.0140 ns | 0.0131 ns |  8.4391 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  8.6131 ns | 0.0145 ns | 0.0135 ns |  8.6160 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.4888 ns | 0.0162 ns | 0.0135 ns |  2.4940 ns |  0.29 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  8.7293 ns | 0.0116 ns | 0.0109 ns |  8.7287 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  8.7029 ns | 0.0137 ns | 0.0128 ns |  8.7041 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  9.2540 ns | 0.0090 ns | 0.0079 ns |  9.2551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 10.0519 ns | 0.0113 ns | 0.0100 ns | 10.0537 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.6690 ns | 0.0025 ns | 0.0022 ns |  1.6690 ns |  0.18 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 |  9.9914 ns | 0.0181 ns | 0.0160 ns |  9.9924 ns |  1.08 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 | 10.0116 ns | 0.0107 ns | 0.0100 ns | 10.0143 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  9.9651 ns | 0.0118 ns | 0.0104 ns |  9.9644 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  9.9953 ns | 0.0462 ns | 0.0433 ns | 10.0145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  5.1584 ns | 0.0050 ns | 0.0047 ns |  5.1578 ns |  0.52 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 10.0994 ns | 0.0114 ns | 0.0101 ns | 10.0993 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  9.9109 ns | 0.0154 ns | 0.0137 ns |  9.9094 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  9.2474 ns | 0.0065 ns | 0.0057 ns |  9.2477 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 10.0563 ns | 0.0113 ns | 0.0106 ns | 10.0563 ns |  1.09 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6181 ns | 0.0041 ns | 0.0036 ns |  1.6176 ns |  0.17 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  9.9742 ns | 0.0093 ns | 0.0078 ns |  9.9747 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 | 10.0087 ns | 0.0099 ns | 0.0088 ns | 10.0101 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  8.4336 ns | 0.0133 ns | 0.0125 ns |  8.4367 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  8.5086 ns | 0.0084 ns | 0.0074 ns |  8.5094 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.4433 ns | 0.0048 ns | 0.0042 ns |  2.4437 ns |  0.29 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  8.6284 ns | 0.0106 ns | 0.0083 ns |  8.6305 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  8.5955 ns | 0.0368 ns | 0.0326 ns |  8.6016 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.3767 ns | 0.0067 ns | 0.0063 ns |  2.3756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.8416 ns | 0.0026 ns | 0.0024 ns |  1.8415 ns |  0.77 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  1.9491 ns | 0.0044 ns | 0.0041 ns |  1.9501 ns |  0.82 |    0.00 |     - |     - |     - |         - |
          ToDecimal |        net461 |  2.3796 ns | 0.0748 ns | 0.1310 ns |  2.3722 ns |  0.99 |    0.06 |     - |     - |     - |         - |
          ToDecimal |        net472 |  2.0772 ns | 0.0021 ns | 0.0017 ns |  2.0767 ns |  0.87 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.4758 ns | 0.0104 ns | 0.0097 ns |  1.4754 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.8547 ns | 0.0049 ns | 0.0043 ns |  1.8549 ns |  1.26 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.6708 ns | 0.0029 ns | 0.0026 ns |  1.6709 ns |  1.13 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 |  1.4744 ns | 0.0040 ns | 0.0037 ns |  1.4731 ns |  1.00 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.5684 ns | 0.0030 ns | 0.0026 ns |  1.5683 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0907 ns | 0.0053 ns | 0.0045 ns |  2.0916 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0828 ns | 0.0026 ns | 0.0024 ns |  2.0829 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3196 ns | 0.0048 ns | 0.0045 ns |  2.3183 ns |  1.11 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  0.8968 ns | 0.0028 ns | 0.0027 ns |  0.8960 ns |  0.43 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.1187 ns | 0.0024 ns | 0.0022 ns |  1.1189 ns |  0.54 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8860 ns | 0.0064 ns | 0.0057 ns |  7.8865 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2080 ns | 0.0133 ns | 0.0124 ns |  8.2056 ns |  1.04 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9622 ns | 0.0023 ns | 0.0020 ns |  1.9619 ns |  0.25 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.7451 ns | 0.0113 ns | 0.0100 ns |  7.7428 ns |  0.98 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  7.9644 ns | 0.0095 ns | 0.0089 ns |  7.9648 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2246 ns | 0.0024 ns | 0.0023 ns |  1.2245 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.3279 ns | 0.0029 ns | 0.0024 ns |  1.3273 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4436 ns | 0.0022 ns | 0.0020 ns |  1.4429 ns |  1.18 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9423 ns | 0.0030 ns | 0.0028 ns |  0.9421 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.1905 ns | 0.0030 ns | 0.0028 ns |  1.1909 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  9.5412 ns | 0.0123 ns | 0.0103 ns |  9.5433 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 | 11.3868 ns | 0.0141 ns | 0.0125 ns | 11.3866 ns |  1.19 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 | 10.7893 ns | 0.0165 ns | 0.0155 ns | 10.7852 ns |  1.13 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 | 11.8421 ns | 0.0698 ns | 0.0652 ns | 11.8634 ns |  1.24 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 | 10.2432 ns | 0.0080 ns | 0.0074 ns | 10.2421 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  9.5520 ns | 0.0118 ns | 0.0110 ns |  9.5520 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.2446 ns | 0.0302 ns | 0.0283 ns | 10.2554 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  9.5678 ns | 0.0110 ns | 0.0092 ns |  9.5699 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 10.2000 ns | 0.0087 ns | 0.0077 ns | 10.2003 ns |  1.07 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 | 10.2387 ns | 0.0116 ns | 0.0103 ns | 10.2356 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 10.0142 ns | 0.0722 ns | 0.0675 ns | 10.0298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 10.1305 ns | 0.0128 ns | 0.0120 ns | 10.1287 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  9.7749 ns | 0.0081 ns | 0.0072 ns |  9.7769 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  9.8982 ns | 0.0097 ns | 0.0081 ns |  9.8997 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 10.1107 ns | 0.0125 ns | 0.0117 ns | 10.1094 ns |  1.01 |    0.01 |     - |     - |     - |         - |
