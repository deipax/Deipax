
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
             ToBool | .NET Core 2.0 |  1.4658 ns | 0.0075 ns | 0.0067 ns |  1.4650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.2440 ns | 0.0053 ns | 0.0044 ns |  1.2432 ns |  0.85 |    0.01 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.4511 ns | 0.0138 ns | 0.0129 ns |  1.4529 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9707 ns | 0.0031 ns | 0.0029 ns |  0.9700 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9631 ns | 0.0024 ns | 0.0022 ns |  0.9631 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0235 ns | 0.0247 ns | 0.0231 ns |  4.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2730 ns | 0.0131 ns | 0.0116 ns |  4.2739 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0178 ns | 0.0049 ns | 0.0038 ns |  4.0170 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1691 ns | 0.0048 ns | 0.0043 ns |  4.1676 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1753 ns | 0.0076 ns | 0.0064 ns |  4.1768 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.5633 ns | 0.0139 ns | 0.0130 ns |  1.5614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.4125 ns | 0.0034 ns | 0.0032 ns |  1.4122 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.6323 ns | 0.0025 ns | 0.0022 ns |  1.6319 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9689 ns | 0.0035 ns | 0.0029 ns |  0.9694 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9646 ns | 0.0029 ns | 0.0026 ns |  0.9647 ns |  0.62 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0244 ns | 0.0240 ns | 0.0224 ns |  4.0154 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1810 ns | 0.0086 ns | 0.0076 ns |  4.1817 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.0131 ns | 0.0041 ns | 0.0038 ns |  4.0131 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.3956 ns | 0.0088 ns | 0.0083 ns |  4.3963 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.4054 ns | 0.0059 ns | 0.0052 ns |  4.4057 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.4850 ns | 0.0160 ns | 0.0142 ns |  1.4864 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.3562 ns | 0.0042 ns | 0.0039 ns |  1.3573 ns |  0.91 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.5467 ns | 0.0074 ns | 0.0066 ns |  1.5451 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9700 ns | 0.0036 ns | 0.0034 ns |  0.9695 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9831 ns | 0.0038 ns | 0.0034 ns |  0.9820 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2593 ns | 0.0227 ns | 0.0212 ns |  4.2486 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.4174 ns | 0.0111 ns | 0.0098 ns |  4.4138 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  3.9588 ns | 0.0225 ns | 0.0211 ns |  3.9498 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.3926 ns | 0.0059 ns | 0.0053 ns |  4.3919 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4032 ns | 0.0070 ns | 0.0065 ns |  4.4050 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.7075 ns | 0.0193 ns | 0.0180 ns |  1.7067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.5082 ns | 0.0134 ns | 0.0112 ns |  1.5134 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.6120 ns | 0.0115 ns | 0.0107 ns |  1.6079 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9581 ns | 0.0027 ns | 0.0021 ns |  0.9582 ns |  0.56 |    0.01 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9511 ns | 0.0029 ns | 0.0027 ns |  0.9511 ns |  0.56 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  1.1755 ns | 0.0097 ns | 0.0086 ns |  1.1744 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  0.9761 ns | 0.0040 ns | 0.0034 ns |  0.9766 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  1.0996 ns | 0.0047 ns | 0.0044 ns |  1.0992 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  0.9313 ns | 0.0034 ns | 0.0028 ns |  0.9314 ns |  0.79 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  0.9736 ns | 0.0030 ns | 0.0027 ns |  0.9740 ns |  0.83 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.4999 ns | 0.0159 ns | 0.0148 ns |  1.4968 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.4009 ns | 0.0034 ns | 0.0030 ns |  1.4008 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5547 ns | 0.0161 ns | 0.0151 ns |  1.5614 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  0.9692 ns | 0.0019 ns | 0.0017 ns |  0.9690 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            ToShort |        net472 |  0.8715 ns | 0.0037 ns | 0.0033 ns |  0.8719 ns |  0.58 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0732 ns | 0.0317 ns | 0.0297 ns |  4.0645 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1879 ns | 0.0083 ns | 0.0078 ns |  4.1881 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0104 ns | 0.0059 ns | 0.0052 ns |  4.0107 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.3879 ns | 0.0055 ns | 0.0049 ns |  4.3884 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.4003 ns | 0.0050 ns | 0.0041 ns |  4.4013 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.6475 ns | 0.0088 ns | 0.0078 ns |  1.6444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2889 ns | 0.0148 ns | 0.0138 ns |  1.2944 ns |  0.78 |    0.01 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.4020 ns | 0.0035 ns | 0.0033 ns |  1.4012 ns |  0.85 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net461 |  1.3054 ns | 0.0057 ns | 0.0050 ns |  1.3043 ns |  0.79 |    0.01 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9658 ns | 0.0049 ns | 0.0046 ns |  0.9659 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0455 ns | 0.0254 ns | 0.0238 ns |  4.0492 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1804 ns | 0.0116 ns | 0.0103 ns |  4.1787 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0169 ns | 0.0085 ns | 0.0080 ns |  4.0164 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.3906 ns | 0.0040 ns | 0.0035 ns |  4.3901 ns |  1.09 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.4598 ns | 0.0068 ns | 0.0063 ns |  4.4588 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.5022 ns | 0.0121 ns | 0.0113 ns |  1.5008 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4272 ns | 0.0041 ns | 0.0034 ns |  1.4274 ns |  0.95 |    0.01 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6445 ns | 0.0142 ns | 0.0126 ns |  1.6489 ns |  1.09 |    0.01 |     - |     - |     - |         - |
              ToInt |        net461 |  1.2941 ns | 0.0039 ns | 0.0032 ns |  1.2930 ns |  0.86 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9817 ns | 0.0186 ns | 0.0165 ns |  0.9854 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0336 ns | 0.0160 ns | 0.0150 ns |  4.0325 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1821 ns | 0.0055 ns | 0.0046 ns |  4.1827 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  3.9439 ns | 0.0083 ns | 0.0073 ns |  3.9446 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.3954 ns | 0.0122 ns | 0.0102 ns |  4.3922 ns |  1.09 |    0.01 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.4186 ns | 0.0098 ns | 0.0091 ns |  4.4210 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.6376 ns | 0.0114 ns | 0.0107 ns |  1.6355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.2516 ns | 0.0025 ns | 0.0022 ns |  1.2519 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.4571 ns | 0.0084 ns | 0.0074 ns |  1.4596 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9779 ns | 0.0074 ns | 0.0069 ns |  0.9798 ns |  0.60 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  1.0029 ns | 0.0033 ns | 0.0028 ns |  1.0019 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0455 ns | 0.0209 ns | 0.0174 ns |  4.0479 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2156 ns | 0.0281 ns | 0.0263 ns |  4.2202 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  3.9419 ns | 0.0078 ns | 0.0073 ns |  3.9426 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.3907 ns | 0.0076 ns | 0.0067 ns |  4.3902 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4246 ns | 0.0249 ns | 0.0233 ns |  4.4177 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.5131 ns | 0.0140 ns | 0.0124 ns |  1.5136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.2697 ns | 0.0042 ns | 0.0037 ns |  1.2693 ns |  0.84 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4992 ns | 0.0030 ns | 0.0028 ns |  1.4996 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9707 ns | 0.0025 ns | 0.0024 ns |  0.9708 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9642 ns | 0.0043 ns | 0.0038 ns |  0.9638 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0370 ns | 0.0203 ns | 0.0180 ns |  2.0317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.0878 ns | 0.0033 ns | 0.0031 ns |  2.0876 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  2.0918 ns | 0.0033 ns | 0.0031 ns |  2.0916 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  2.1238 ns | 0.0045 ns | 0.0038 ns |  2.1235 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  2.4431 ns | 0.0029 ns | 0.0025 ns |  2.4427 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.6314 ns | 0.0102 ns | 0.0091 ns |  1.6275 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.6534 ns | 0.0146 ns | 0.0130 ns |  1.6589 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4412 ns | 0.0035 ns | 0.0029 ns |  1.4406 ns |  0.88 |    0.01 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9796 ns | 0.0041 ns | 0.0036 ns |  0.9791 ns |  0.60 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9991 ns | 0.0159 ns | 0.0149 ns |  0.9998 ns |  0.61 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.9078 ns | 0.0137 ns | 0.0128 ns |  1.9033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8792 ns | 0.0024 ns | 0.0023 ns |  1.8796 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1660 ns | 0.0030 ns | 0.0028 ns |  2.1662 ns |  1.14 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.8682 ns | 0.0042 ns | 0.0037 ns |  1.8672 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.9046 ns | 0.0051 ns | 0.0046 ns |  1.9035 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.5842 ns | 0.0571 ns | 0.0701 ns |  1.5709 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.6489 ns | 0.0041 ns | 0.0036 ns |  1.6475 ns |  1.05 |    0.05 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.3769 ns | 0.0030 ns | 0.0028 ns |  1.3768 ns |  0.87 |    0.04 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9911 ns | 0.0020 ns | 0.0017 ns |  0.9912 ns |  0.64 |    0.02 |     - |     - |     - |         - |
            ToFloat |        net472 |  1.0002 ns | 0.0028 ns | 0.0026 ns |  0.9998 ns |  0.63 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2595 ns | 0.0260 ns | 0.0231 ns |  4.2582 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.8775 ns | 0.0060 ns | 0.0057 ns |  4.8764 ns |  1.15 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.1754 ns | 0.0076 ns | 0.0067 ns |  4.1750 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6210 ns | 0.0063 ns | 0.0052 ns |  4.6198 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6490 ns | 0.0218 ns | 0.0204 ns |  4.6408 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.7068 ns | 0.0672 ns | 0.0773 ns |  1.6711 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.4175 ns | 0.0043 ns | 0.0041 ns |  1.4161 ns |  0.83 |    0.04 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.6333 ns | 0.0073 ns | 0.0065 ns |  1.6310 ns |  0.95 |    0.04 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9892 ns | 0.0031 ns | 0.0026 ns |  0.9889 ns |  0.57 |    0.03 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.9843 ns | 0.0039 ns | 0.0034 ns |  0.9838 ns |  0.57 |    0.03 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.3518 ns | 0.1019 ns | 0.0903 ns |  2.3192 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.3176 ns | 0.0020 ns | 0.0019 ns |  2.3178 ns |  0.99 |    0.04 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.9118 ns | 0.0077 ns | 0.0072 ns |  1.9111 ns |  0.81 |    0.03 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1377 ns | 0.0076 ns | 0.0071 ns |  2.1377 ns |  0.91 |    0.03 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.3255 ns | 0.0035 ns | 0.0032 ns |  2.3261 ns |  0.99 |    0.04 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.1674 ns | 0.0386 ns | 0.0342 ns |  2.1681 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  2.5523 ns | 0.0049 ns | 0.0045 ns |  2.5525 ns |  1.18 |    0.02 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1341 ns | 0.0049 ns | 0.0046 ns |  2.1342 ns |  0.98 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.2611 ns | 0.0113 ns | 0.0106 ns |  6.2597 ns |  2.89 |    0.05 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.3340 ns | 0.0326 ns | 0.0305 ns |  6.3384 ns |  2.92 |    0.05 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 10.2575 ns | 0.1137 ns | 0.1008 ns | 10.2521 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7435 ns | 0.0811 ns | 0.0759 ns | 10.7874 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.2535 ns | 0.0028 ns | 0.0023 ns |  2.2526 ns |  0.22 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6440 ns | 0.0036 ns | 0.0028 ns | 10.6435 ns |  1.04 |    0.01 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6591 ns | 0.0121 ns | 0.0101 ns | 10.6634 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3333 ns | 0.0180 ns | 0.0168 ns |  2.3402 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3277 ns | 0.0048 ns | 0.0045 ns |  2.3273 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3387 ns | 0.0173 ns | 0.0162 ns |  2.3470 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1418 ns | 0.0041 ns | 0.0036 ns |  1.1421 ns |  0.49 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  1.4119 ns | 0.0024 ns | 0.0021 ns |  1.4112 ns |  0.61 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.0422 ns | 0.0311 ns | 0.0291 ns |  8.0346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4591 ns | 0.0091 ns | 0.0080 ns |  8.4598 ns |  1.05 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9413 ns | 0.0040 ns | 0.0035 ns |  1.9415 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2158 ns | 0.0169 ns | 0.0150 ns |  8.2124 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.2231 ns | 0.0276 ns | 0.0244 ns |  8.2159 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.4738 ns | 0.0054 ns | 0.0051 ns |  1.4741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.2687 ns | 0.0043 ns | 0.0038 ns |  1.2682 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.4747 ns | 0.0057 ns | 0.0053 ns |  1.4740 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           ToObject |        net461 |  1.1381 ns | 0.0028 ns | 0.0025 ns |  1.1382 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  1.1282 ns | 0.0032 ns | 0.0029 ns |  1.1286 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.7053 ns | 0.0060 ns | 0.0053 ns |  1.7058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.4120 ns | 0.0027 ns | 0.0025 ns |  1.4122 ns |  0.83 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.4852 ns | 0.0030 ns | 0.0028 ns |  1.4856 ns |  0.87 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 |  1.2457 ns | 0.0028 ns | 0.0024 ns |  1.2458 ns |  0.73 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 |  1.2562 ns | 0.0125 ns | 0.0117 ns |  1.2602 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.6449 ns | 0.0072 ns | 0.0060 ns |  1.6454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.5282 ns | 0.0032 ns | 0.0030 ns |  1.5279 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.5497 ns | 0.0060 ns | 0.0056 ns |  1.5500 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2428 ns | 0.0031 ns | 0.0024 ns |  1.2428 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2379 ns | 0.0036 ns | 0.0030 ns |  1.2372 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2930 ns | 0.0136 ns | 0.0128 ns |  4.2886 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.4228 ns | 0.0055 ns | 0.0049 ns |  4.4225 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0162 ns | 0.0047 ns | 0.0036 ns |  4.0170 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6243 ns | 0.0056 ns | 0.0053 ns |  4.6243 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6408 ns | 0.0068 ns | 0.0061 ns |  4.6398 ns |  1.08 |    0.00 |     - |     - |     - |         - |
