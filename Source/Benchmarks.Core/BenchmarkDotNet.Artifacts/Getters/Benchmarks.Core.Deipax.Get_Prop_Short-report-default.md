
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
             ToBool | .NET Core 2.0 |  0.8620 ns | 0.0037 ns | 0.0032 ns |  0.8623 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.1829 ns | 0.0029 ns | 0.0027 ns |  1.1834 ns |  1.37 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9606 ns | 0.0080 ns | 0.0071 ns |  0.9631 ns |  1.11 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.7221 ns | 0.0037 ns | 0.0035 ns |  0.7211 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.4459 ns | 0.0073 ns | 0.0068 ns |  0.4415 ns |  0.52 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0082 ns | 0.0264 ns | 0.0221 ns |  4.0163 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2103 ns | 0.0280 ns | 0.0262 ns |  4.2232 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  3.9739 ns | 0.0064 ns | 0.0057 ns |  3.9722 ns |  0.99 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1497 ns | 0.0101 ns | 0.0090 ns |  4.1467 ns |  1.04 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1811 ns | 0.0070 ns | 0.0062 ns |  4.1817 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.2176 ns | 0.0028 ns | 0.0026 ns |  1.2175 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4904 ns | 0.0034 ns | 0.0030 ns |  1.4913 ns |  1.22 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.0058 ns | 0.0119 ns | 0.0100 ns |  1.0101 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  1.6586 ns | 0.0028 ns | 0.0023 ns |  1.6591 ns |  1.36 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  1.3651 ns | 0.0141 ns | 0.0132 ns |  1.3698 ns |  1.12 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9695 ns | 0.0054 ns | 0.0048 ns |  3.9705 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1871 ns | 0.0284 ns | 0.0266 ns |  4.1722 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0025 ns | 0.0061 ns | 0.0057 ns |  4.0024 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.8491 ns | 0.0104 ns | 0.0098 ns |  4.8485 ns |  1.22 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.8855 ns | 0.0110 ns | 0.0098 ns |  4.8857 ns |  1.23 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.0365 ns | 0.0036 ns | 0.0034 ns |  2.0385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  2.7262 ns | 0.0141 ns | 0.0131 ns |  2.7292 ns |  1.34 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.2845 ns | 0.0017 ns | 0.0013 ns |  2.2843 ns |  1.12 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6474 ns | 0.0035 ns | 0.0029 ns |  1.6473 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  1.3589 ns | 0.0027 ns | 0.0024 ns |  1.3588 ns |  0.67 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.6738 ns | 0.0078 ns | 0.0073 ns |  4.6747 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.8692 ns | 0.0048 ns | 0.0042 ns |  4.8698 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.6677 ns | 0.0063 ns | 0.0059 ns |  4.6684 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.8413 ns | 0.0079 ns | 0.0074 ns |  4.8397 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.8714 ns | 0.0071 ns | 0.0066 ns |  4.8721 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  2.6717 ns | 0.0385 ns | 0.0360 ns |  2.6899 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.5982 ns | 0.0239 ns | 0.0224 ns |  2.5998 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.8977 ns | 0.0030 ns | 0.0028 ns |  1.8981 ns |  0.71 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.7102 ns | 0.0146 ns | 0.0137 ns |  1.7031 ns |  0.64 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.3614 ns | 0.0033 ns | 0.0030 ns |  1.3606 ns |  0.51 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.6661 ns | 0.0054 ns | 0.0048 ns |  4.6672 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.8733 ns | 0.0085 ns | 0.0075 ns |  4.8709 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.7285 ns | 0.0205 ns | 0.0191 ns |  4.7378 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.8467 ns | 0.0094 ns | 0.0088 ns |  4.8438 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.8994 ns | 0.0348 ns | 0.0325 ns |  4.8833 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  0.8609 ns | 0.0028 ns | 0.0026 ns |  0.8611 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.1904 ns | 0.0156 ns | 0.0146 ns |  1.1887 ns |  1.38 |    0.02 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  0.9491 ns | 0.0031 ns | 0.0028 ns |  0.9490 ns |  1.10 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  0.7251 ns | 0.0062 ns | 0.0058 ns |  0.7225 ns |  0.84 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  0.5823 ns | 0.0022 ns | 0.0020 ns |  0.5821 ns |  0.68 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  3.9746 ns | 0.0060 ns | 0.0054 ns |  3.9732 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.4215 ns | 0.0075 ns | 0.0066 ns |  4.4201 ns |  1.11 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.2355 ns | 0.0216 ns | 0.0191 ns |  4.2417 ns |  1.07 |    0.01 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.1476 ns | 0.0043 ns | 0.0038 ns |  4.1469 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.1781 ns | 0.0033 ns | 0.0029 ns |  4.1774 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  1.3396 ns | 0.0046 ns | 0.0043 ns |  1.3389 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.6764 ns | 0.0152 ns | 0.0142 ns |  1.6687 ns |  1.25 |    0.01 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9955 ns | 0.0028 ns | 0.0026 ns |  0.9962 ns |  0.74 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 |  1.6469 ns | 0.0034 ns | 0.0030 ns |  1.6469 ns |  1.23 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  1.3439 ns | 0.0031 ns | 0.0029 ns |  1.3431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0030 ns | 0.0338 ns | 0.0317 ns |  4.0170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1816 ns | 0.0088 ns | 0.0082 ns |  4.1814 ns |  1.04 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  3.9997 ns | 0.0068 ns | 0.0053 ns |  3.9980 ns |  1.00 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.8725 ns | 0.0334 ns | 0.0312 ns |  4.8969 ns |  1.22 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.9099 ns | 0.0329 ns | 0.0307 ns |  4.9236 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  0.8784 ns | 0.0025 ns | 0.0022 ns |  0.8788 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.1875 ns | 0.0091 ns | 0.0085 ns |  1.1833 ns |  1.35 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9252 ns | 0.0012 ns | 0.0011 ns |  0.9253 ns |  1.05 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  0.7220 ns | 0.0044 ns | 0.0042 ns |  0.7206 ns |  0.82 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  0.4322 ns | 0.0017 ns | 0.0014 ns |  0.4322 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0124 ns | 0.0325 ns | 0.0304 ns |  4.0263 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1841 ns | 0.0057 ns | 0.0053 ns |  4.1855 ns |  1.04 |    0.01 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0005 ns | 0.0084 ns | 0.0079 ns |  4.0001 ns |  1.00 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.1455 ns | 0.0046 ns | 0.0039 ns |  4.1460 ns |  1.03 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.2107 ns | 0.0244 ns | 0.0228 ns |  4.2206 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.4030 ns | 0.0050 ns | 0.0039 ns |  1.4026 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4726 ns | 0.0031 ns | 0.0029 ns |  1.4715 ns |  1.05 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9633 ns | 0.0024 ns | 0.0023 ns |  0.9627 ns |  0.69 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  1.6783 ns | 0.0023 ns | 0.0021 ns |  1.6779 ns |  1.20 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  1.3574 ns | 0.0029 ns | 0.0025 ns |  1.3571 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  3.9979 ns | 0.0307 ns | 0.0287 ns |  4.0121 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1777 ns | 0.0053 ns | 0.0050 ns |  4.1773 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.7438 ns | 0.0069 ns | 0.0065 ns |  3.7442 ns |  0.94 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.6103 ns | 0.0094 ns | 0.0078 ns |  4.6090 ns |  1.15 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.6739 ns | 0.0369 ns | 0.0345 ns |  4.6926 ns |  1.17 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.2322 ns | 0.0035 ns | 0.0031 ns |  1.2317 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1807 ns | 0.0040 ns | 0.0034 ns |  1.1807 ns |  0.96 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  0.9585 ns | 0.0104 ns | 0.0097 ns |  0.9532 ns |  0.78 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  0.7236 ns | 0.0035 ns | 0.0033 ns |  0.7235 ns |  0.59 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.4361 ns | 0.0090 ns | 0.0084 ns |  0.4389 ns |  0.35 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.4501 ns | 0.0033 ns | 0.0027 ns |  1.4504 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.9402 ns | 0.0053 ns | 0.0049 ns |  1.9394 ns |  1.34 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6411 ns | 0.0028 ns | 0.0025 ns |  1.6413 ns |  1.13 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.8052 ns | 0.0060 ns | 0.0050 ns |  1.8043 ns |  1.24 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  1.9089 ns | 0.0043 ns | 0.0040 ns |  1.9089 ns |  1.32 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.3907 ns | 0.0039 ns | 0.0034 ns |  1.3912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6841 ns | 0.0219 ns | 0.0205 ns |  1.6830 ns |  1.21 |    0.01 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9665 ns | 0.0037 ns | 0.0032 ns |  0.9659 ns |  0.69 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  1.6509 ns | 0.0026 ns | 0.0023 ns |  1.6510 ns |  1.19 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  1.3709 ns | 0.0156 ns | 0.0146 ns |  1.3662 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0158 ns | 0.0182 ns | 0.0170 ns |  2.0246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.9566 ns | 0.0066 ns | 0.0059 ns |  1.9564 ns |  0.97 |    0.01 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.6554 ns | 0.0146 ns | 0.0136 ns |  1.6629 ns |  0.82 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  2.7282 ns | 0.0033 ns | 0.0030 ns |  2.7282 ns |  1.35 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  2.7905 ns | 0.0060 ns | 0.0053 ns |  2.7899 ns |  1.38 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  0.9149 ns | 0.0026 ns | 0.0024 ns |  0.9146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.2004 ns | 0.0027 ns | 0.0025 ns |  1.2000 ns |  1.31 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.0838 ns | 0.0025 ns | 0.0023 ns |  1.0832 ns |  1.18 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.7208 ns | 0.0063 ns | 0.0059 ns |  0.7235 ns |  0.79 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.4307 ns | 0.0020 ns | 0.0019 ns |  0.4306 ns |  0.47 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2259 ns | 0.0310 ns | 0.0290 ns |  4.2103 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4126 ns | 0.0045 ns | 0.0038 ns |  4.4117 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2158 ns | 0.0269 ns | 0.0251 ns |  4.2022 ns |  1.00 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.3805 ns | 0.0053 ns | 0.0050 ns |  4.3811 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4086 ns | 0.0052 ns | 0.0049 ns |  4.4090 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.4458 ns | 0.0051 ns | 0.0042 ns |  1.4454 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1891 ns | 0.0038 ns | 0.0032 ns |  1.1892 ns |  0.82 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.0743 ns | 0.0030 ns | 0.0028 ns |  1.0744 ns |  0.74 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.7518 ns | 0.0095 ns | 0.0089 ns |  0.7509 ns |  0.52 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.4303 ns | 0.0034 ns | 0.0032 ns |  0.4296 ns |  0.30 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6678 ns | 0.0024 ns | 0.0020 ns |  1.6683 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8448 ns | 0.0033 ns | 0.0026 ns |  1.8453 ns |  1.11 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.4840 ns | 0.0118 ns | 0.0110 ns |  1.4800 ns |  0.89 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.5550 ns | 0.0023 ns | 0.0021 ns |  1.5551 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.6297 ns | 0.0031 ns | 0.0026 ns |  1.6298 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  5.8532 ns | 0.0278 ns | 0.0260 ns |  5.8632 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.0401 ns | 0.0384 ns | 0.0360 ns |  6.0184 ns |  1.03 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  5.8393 ns | 0.0132 ns | 0.0110 ns |  5.8389 ns |  1.00 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.9969 ns | 0.0086 ns | 0.0067 ns |  5.9956 ns |  1.03 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  5.8027 ns | 0.0106 ns | 0.0094 ns |  5.8025 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.1326 ns | 0.0239 ns | 0.0212 ns | 18.1359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.1257 ns | 0.0424 ns | 0.0376 ns | 18.1272 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 12.8555 ns | 0.0393 ns | 0.0307 ns | 12.8591 ns |  0.71 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.0009 ns | 0.0200 ns | 0.0187 ns | 18.0002 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 17.8021 ns | 0.0187 ns | 0.0175 ns | 17.8072 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.0851 ns | 0.0191 ns | 0.0179 ns |  2.0764 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1329 ns | 0.0039 ns | 0.0035 ns |  2.1328 ns |  1.02 |    0.01 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  1.9104 ns | 0.0032 ns | 0.0028 ns |  1.9106 ns |  0.92 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.1253 ns | 0.0023 ns | 0.0019 ns |  1.1250 ns |  0.54 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1865 ns | 0.0024 ns | 0.0022 ns |  1.1863 ns |  0.57 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.9241 ns | 0.0227 ns | 0.0202 ns |  7.9203 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.0139 ns | 0.0285 ns | 0.0266 ns |  8.0200 ns |  1.01 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8960 ns | 0.0053 ns | 0.0041 ns |  1.8960 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1827 ns | 0.0146 ns | 0.0137 ns |  8.1828 ns |  1.03 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  7.9880 ns | 0.0134 ns | 0.0118 ns |  7.9869 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.3381 ns | 0.0172 ns | 0.0161 ns |  3.3415 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.7717 ns | 0.0064 ns | 0.0053 ns |  3.7698 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7852 ns | 0.0295 ns | 0.0261 ns |  3.7947 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.9980 ns | 0.0174 ns | 0.0155 ns |  3.0023 ns |  0.90 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.6930 ns | 0.0107 ns | 0.0100 ns |  2.6891 ns |  0.81 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.7292 ns | 0.0719 ns | 0.0672 ns | 29.7273 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.3636 ns | 0.0734 ns | 0.0686 ns | 17.3447 ns |  0.58 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 12.3501 ns | 0.0470 ns | 0.0367 ns | 12.3381 ns |  0.42 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 30.2673 ns | 0.0585 ns | 0.0519 ns | 30.2753 ns |  1.02 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 31.3820 ns | 0.0843 ns | 0.0747 ns | 31.3813 ns |  1.06 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 |  9.8930 ns | 0.0554 ns | 0.0518 ns |  9.8830 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.1943 ns | 0.0150 ns | 0.0125 ns | 10.1918 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.3417 ns | 0.0284 ns | 0.0252 ns |  8.3485 ns |  0.84 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.2340 ns | 0.0223 ns | 0.0186 ns | 12.2313 ns |  1.24 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.1689 ns | 0.0326 ns | 0.0305 ns | 12.1583 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.4306 ns | 0.0140 ns | 0.0131 ns | 14.4305 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 14.7836 ns | 0.0244 ns | 0.0228 ns | 14.7893 ns |  1.02 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.5457 ns | 0.0212 ns | 0.0199 ns | 12.5543 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.7838 ns | 0.0144 ns | 0.0120 ns | 16.7848 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 16.7661 ns | 0.0298 ns | 0.0264 ns | 16.7570 ns |  1.16 |    0.00 |      - |     - |     - |         - |
