
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 |  1.4418 ns | 0.0034 ns | 0.0031 ns |  1.4424 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.3326 ns | 0.0040 ns | 0.0033 ns |  1.3320 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4125 ns | 0.0039 ns | 0.0035 ns |  1.4111 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  0.9733 ns | 0.0033 ns | 0.0030 ns |  0.9734 ns |  0.68 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  0.9809 ns | 0.0028 ns | 0.0026 ns |  0.9806 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.1788 ns | 0.0047 ns | 0.0039 ns |  4.1773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.3867 ns | 0.0111 ns | 0.0092 ns |  4.3829 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.4683 ns | 0.0101 ns | 0.0094 ns |  4.4675 ns |  1.07 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.9164 ns | 0.0189 ns | 0.0176 ns |  4.9095 ns |  1.18 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.8850 ns | 0.0058 ns | 0.0054 ns |  4.8848 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.9478 ns | 0.0112 ns | 0.0104 ns |  2.9516 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  2.3894 ns | 0.0043 ns | 0.0038 ns |  2.3896 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  2.4085 ns | 0.0073 ns | 0.0057 ns |  2.4086 ns |  0.82 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.0457 ns | 0.0038 ns | 0.0036 ns |  2.0455 ns |  0.69 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.0904 ns | 0.0030 ns | 0.0027 ns |  2.0902 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  5.1005 ns | 0.0063 ns | 0.0059 ns |  5.1009 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  5.0515 ns | 0.0062 ns | 0.0058 ns |  5.0503 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.7808 ns | 0.0204 ns | 0.0191 ns |  4.7823 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3710 ns | 0.0059 ns | 0.0052 ns |  5.3706 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3593 ns | 0.0103 ns | 0.0097 ns |  5.3565 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.6001 ns | 0.0046 ns | 0.0043 ns |  2.6014 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.6169 ns | 0.0049 ns | 0.0041 ns |  2.6159 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.6861 ns | 0.0040 ns | 0.0036 ns |  2.6858 ns |  1.03 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.0565 ns | 0.0046 ns | 0.0043 ns |  2.0551 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.9204 ns | 0.0876 ns | 0.1789 ns |  2.9166 ns |  1.08 |    0.08 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.1168 ns | 0.0054 ns | 0.0051 ns |  5.1169 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.0538 ns | 0.0139 ns | 0.0130 ns |  5.0482 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.6946 ns | 0.0054 ns | 0.0048 ns |  4.6952 ns |  0.92 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3070 ns | 0.0118 ns | 0.0105 ns |  5.3048 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3505 ns | 0.0081 ns | 0.0075 ns |  5.3487 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  3.1473 ns | 0.0085 ns | 0.0071 ns |  3.1461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.4256 ns | 0.0050 ns | 0.0047 ns |  2.4256 ns |  0.77 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.1895 ns | 0.0028 ns | 0.0024 ns |  2.1897 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToByte |        net461 |  2.0948 ns | 0.0049 ns | 0.0041 ns |  2.0944 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 |  2.1209 ns | 0.0040 ns | 0.0037 ns |  2.1213 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.1583 ns | 0.0056 ns | 0.0052 ns |  5.1584 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.0491 ns | 0.0078 ns | 0.0069 ns |  5.0494 ns |  0.98 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7124 ns | 0.0042 ns | 0.0040 ns |  4.7121 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3707 ns | 0.0048 ns | 0.0040 ns |  5.3703 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3579 ns | 0.0137 ns | 0.0129 ns |  5.3520 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  2.8291 ns | 0.0050 ns | 0.0047 ns |  2.8289 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  2.6259 ns | 0.0097 ns | 0.0086 ns |  2.6236 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  2.7628 ns | 0.0358 ns | 0.0335 ns |  2.7659 ns |  0.98 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  2.0807 ns | 0.0035 ns | 0.0031 ns |  2.0794 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  2.0556 ns | 0.0060 ns | 0.0050 ns |  2.0547 ns |  0.73 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  5.1032 ns | 0.0107 ns | 0.0094 ns |  5.1006 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  5.0536 ns | 0.0168 ns | 0.0149 ns |  5.0482 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.7318 ns | 0.0226 ns | 0.0201 ns |  4.7245 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  5.3138 ns | 0.0121 ns | 0.0113 ns |  5.3146 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  5.3744 ns | 0.0221 ns | 0.0207 ns |  5.3857 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  3.1459 ns | 0.0044 ns | 0.0041 ns |  3.1449 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  2.9860 ns | 0.0059 ns | 0.0055 ns |  2.9869 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  2.6769 ns | 0.0179 ns | 0.0167 ns |  2.6794 ns |  0.85 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.1319 ns | 0.0053 ns | 0.0047 ns |  2.1316 ns |  0.68 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.1211 ns | 0.0031 ns | 0.0027 ns |  2.1217 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  5.1017 ns | 0.0060 ns | 0.0056 ns |  5.1008 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  5.0406 ns | 0.0052 ns | 0.0048 ns |  5.0417 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.7634 ns | 0.0185 ns | 0.0164 ns |  4.7653 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3152 ns | 0.0045 ns | 0.0040 ns |  5.3140 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3672 ns | 0.0253 ns | 0.0236 ns |  5.3575 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4632 ns | 0.0036 ns | 0.0032 ns |  1.4644 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.6044 ns | 0.0032 ns | 0.0028 ns |  1.6055 ns |  1.10 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.5551 ns | 0.0024 ns | 0.0023 ns |  1.5556 ns |  1.06 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.8447 ns | 0.0053 ns | 0.0047 ns |  1.8444 ns |  1.26 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.8549 ns | 0.0069 ns | 0.0061 ns |  1.8529 ns |  1.27 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  1.0854 ns | 0.0029 ns | 0.0027 ns |  1.0853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  0.8988 ns | 0.0025 ns | 0.0023 ns |  0.8997 ns |  0.83 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  1.1691 ns | 0.0024 ns | 0.0023 ns |  1.1692 ns |  1.08 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  1.4755 ns | 0.0037 ns | 0.0031 ns |  1.4756 ns |  1.36 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  1.1733 ns | 0.0042 ns | 0.0037 ns |  1.1722 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.7956 ns | 0.0109 ns | 0.0102 ns |  1.7967 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4165 ns | 0.0028 ns | 0.0025 ns |  1.4163 ns |  0.79 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2547 ns | 0.0035 ns | 0.0031 ns |  1.2543 ns |  0.70 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.0554 ns | 0.0095 ns | 0.0089 ns |  2.0515 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.0672 ns | 0.0043 ns | 0.0036 ns |  2.0679 ns |  1.15 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4094 ns | 0.0067 ns | 0.0059 ns |  4.4088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4095 ns | 0.0200 ns | 0.0187 ns |  4.4160 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0002 ns | 0.0075 ns | 0.0058 ns |  3.9991 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.0851 ns | 0.0113 ns | 0.0106 ns |  5.0867 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.1006 ns | 0.0048 ns | 0.0045 ns |  5.1000 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.4130 ns | 0.0083 ns | 0.0078 ns |  1.4137 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1771 ns | 0.0019 ns | 0.0015 ns |  1.1773 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5480 ns | 0.0025 ns | 0.0022 ns |  1.5483 ns |  1.10 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1324 ns | 0.0029 ns | 0.0026 ns |  1.1314 ns |  0.80 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.1362 ns | 0.0043 ns | 0.0038 ns |  1.1362 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.2838 ns | 0.0088 ns | 0.0078 ns |  2.2807 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.7379 ns | 0.0027 ns | 0.0024 ns |  1.7377 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.1098 ns | 0.0035 ns | 0.0032 ns |  2.1095 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.0963 ns | 0.0039 ns | 0.0036 ns |  2.0964 ns |  0.92 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.1222 ns | 0.0038 ns | 0.0036 ns |  2.1227 ns |  0.93 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.7953 ns | 0.0035 ns | 0.0028 ns |  1.7950 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.4146 ns | 0.0036 ns | 0.0032 ns |  1.4143 ns |  0.79 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.5255 ns | 0.0027 ns | 0.0024 ns |  1.5251 ns |  0.85 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  2.1485 ns | 0.0033 ns | 0.0030 ns |  2.1486 ns |  1.20 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  2.1759 ns | 0.0145 ns | 0.0129 ns |  2.1707 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0993 ns | 0.0050 ns | 0.0044 ns |  2.0985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.6052 ns | 0.0177 ns | 0.0166 ns |  2.6092 ns |  1.24 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1534 ns | 0.0048 ns | 0.0043 ns |  2.1534 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.9040 ns | 0.0057 ns | 0.0054 ns |  2.9037 ns |  1.38 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.0090 ns | 0.0060 ns | 0.0056 ns |  3.0084 ns |  1.43 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.6036 ns | 0.0085 ns | 0.0076 ns |  1.6056 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.2793 ns | 0.0025 ns | 0.0021 ns |  1.2794 ns |  0.80 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3201 ns | 0.0033 ns | 0.0028 ns |  1.3209 ns |  0.82 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.1190 ns | 0.0047 ns | 0.0044 ns |  1.1196 ns |  0.70 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1307 ns | 0.0022 ns | 0.0020 ns |  1.1307 ns |  0.71 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4074 ns | 0.0053 ns | 0.0044 ns |  4.4088 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.5907 ns | 0.0071 ns | 0.0063 ns |  4.5908 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.7031 ns | 0.0071 ns | 0.0067 ns |  4.7034 ns |  1.07 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  5.1196 ns | 0.0180 ns | 0.0169 ns |  5.1220 ns |  1.16 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  5.1067 ns | 0.0066 ns | 0.0062 ns |  5.1071 ns |  1.16 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6611 ns | 0.0039 ns | 0.0032 ns |  1.6605 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.3187 ns | 0.0026 ns | 0.0025 ns |  1.3186 ns |  0.79 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.5451 ns | 0.0028 ns | 0.0026 ns |  1.5447 ns |  0.93 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.9510 ns | 0.0031 ns | 0.0028 ns |  0.9509 ns |  0.57 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.7797 ns | 0.0028 ns | 0.0023 ns |  1.7802 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7711 ns | 0.0034 ns | 0.0028 ns |  1.7708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.9197 ns | 0.0033 ns | 0.0026 ns |  1.9200 ns |  1.08 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1134 ns | 0.0064 ns | 0.0060 ns |  2.1126 ns |  1.19 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.5474 ns | 0.0086 ns | 0.0072 ns |  2.5469 ns |  1.44 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.5813 ns | 0.0054 ns | 0.0048 ns |  2.5801 ns |  1.46 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0684 ns | 0.0188 ns | 0.0175 ns |  6.0740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  5.9717 ns | 0.0099 ns | 0.0092 ns |  5.9706 ns |  0.98 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0598 ns | 0.0085 ns | 0.0079 ns |  6.0614 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.4810 ns | 0.0092 ns | 0.0076 ns |  6.4823 ns |  1.07 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2774 ns | 0.0123 ns | 0.0115 ns |  6.2801 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.2595 ns | 0.0220 ns | 0.0205 ns | 18.2533 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.1959 ns | 0.0391 ns | 0.0366 ns | 18.1930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.5225 ns | 0.0119 ns | 0.0100 ns | 12.5240 ns |  0.69 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.5113 ns | 0.0339 ns | 0.0317 ns | 18.5150 ns |  1.01 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.9428 ns | 0.0255 ns | 0.0226 ns | 18.9422 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2567 ns | 0.0034 ns | 0.0029 ns |  2.2572 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0696 ns | 0.0035 ns | 0.0032 ns |  2.0701 ns |  0.92 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3331 ns | 0.0023 ns | 0.0021 ns |  2.3337 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.4106 ns | 0.0107 ns | 0.0100 ns |  1.4143 ns |  0.62 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1908 ns | 0.0039 ns | 0.0036 ns |  1.1906 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8931 ns | 0.0230 ns | 0.0215 ns |  7.8909 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3433 ns | 0.0177 ns | 0.0138 ns |  8.3436 ns |  1.06 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  2.6966 ns | 0.0053 ns | 0.0049 ns |  2.6971 ns |  0.34 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1424 ns | 0.0181 ns | 0.0160 ns |  8.1372 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.3410 ns | 0.0115 ns | 0.0096 ns |  8.3421 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  4.1005 ns | 0.0079 ns | 0.0062 ns |  4.1019 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.4625 ns | 0.0115 ns | 0.0096 ns |  4.4642 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.6088 ns | 0.0206 ns | 0.0192 ns |  4.6089 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.7750 ns | 0.0104 ns | 0.0092 ns |  3.7778 ns |  0.92 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.8182 ns | 0.0198 ns | 0.0186 ns |  3.8135 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 30.0824 ns | 0.1082 ns | 0.1012 ns | 30.0980 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.5987 ns | 0.1060 ns | 0.0992 ns | 17.5572 ns |  0.59 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.5741 ns | 0.0186 ns | 0.0174 ns | 12.5730 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.6411 ns | 0.1329 ns | 0.1178 ns | 31.5967 ns |  1.05 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.9772 ns | 0.0663 ns | 0.0588 ns | 31.9771 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.7281 ns | 0.0198 ns | 0.0175 ns | 12.7303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.5890 ns | 0.0447 ns | 0.0418 ns | 12.5972 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.1914 ns | 0.0108 ns | 0.0101 ns |  8.1922 ns |  0.64 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 15.2566 ns | 0.0221 ns | 0.0196 ns | 15.2576 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.2257 ns | 0.0231 ns | 0.0216 ns | 15.2269 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.7278 ns | 0.0621 ns | 0.0581 ns | 16.7430 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.8427 ns | 0.0325 ns | 0.0304 ns | 16.8352 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.7470 ns | 0.0110 ns | 0.0103 ns | 12.7454 ns |  0.76 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.6500 ns | 0.0264 ns | 0.0247 ns | 19.6392 ns |  1.17 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.6922 ns | 0.0595 ns | 0.0497 ns | 19.6789 ns |  1.18 |    0.00 |      - |     - |     - |         - |
