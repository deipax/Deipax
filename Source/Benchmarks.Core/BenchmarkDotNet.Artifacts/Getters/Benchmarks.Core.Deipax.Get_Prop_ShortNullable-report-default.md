
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
             ToBool | .NET Core 2.0 |  1.4361 ns | 0.0025 ns | 0.0022 ns |  1.4364 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.4823 ns | 0.0042 ns | 0.0040 ns |  1.4819 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.2626 ns | 0.0043 ns | 0.0038 ns |  1.2624 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  1.0206 ns | 0.0036 ns | 0.0031 ns |  1.0208 ns |  0.71 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  1.1958 ns | 0.0027 ns | 0.0024 ns |  1.1964 ns |  0.83 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.4164 ns | 0.0134 ns | 0.0118 ns |  4.4138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.4156 ns | 0.0129 ns | 0.0121 ns |  4.4139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.2874 ns | 0.0215 ns | 0.0190 ns |  4.2938 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.6790 ns | 0.0276 ns | 0.0258 ns |  4.6839 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.6179 ns | 0.0085 ns | 0.0079 ns |  4.6171 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  2.0057 ns | 0.0050 ns | 0.0045 ns |  2.0042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.7107 ns | 0.0048 ns | 0.0040 ns |  1.7112 ns |  0.85 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.2615 ns | 0.0025 ns | 0.0021 ns |  1.2618 ns |  0.63 |    0.00 |      - |     - |     - |         - |
             ToChar |        net461 |  2.0398 ns | 0.0027 ns | 0.0024 ns |  2.0396 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  2.3808 ns | 0.0057 ns | 0.0050 ns |  2.3809 ns |  1.19 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.4191 ns | 0.0168 ns | 0.0149 ns |  4.4172 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4098 ns | 0.0065 ns | 0.0061 ns |  4.4091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.5356 ns | 0.0154 ns | 0.0144 ns |  4.5317 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  5.3615 ns | 0.0274 ns | 0.0256 ns |  5.3498 ns |  1.21 |    0.01 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  5.3148 ns | 0.0101 ns | 0.0090 ns |  5.3156 ns |  1.20 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  2.6219 ns | 0.0082 ns | 0.0077 ns |  2.6239 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  3.0181 ns | 0.0214 ns | 0.0189 ns |  3.0218 ns |  1.15 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  2.6014 ns | 0.0055 ns | 0.0051 ns |  2.6010 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 |  2.1202 ns | 0.0040 ns | 0.0035 ns |  2.1195 ns |  0.81 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.3965 ns | 0.0040 ns | 0.0034 ns |  2.3962 ns |  0.91 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  5.1042 ns | 0.0036 ns | 0.0030 ns |  5.1042 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  5.1023 ns | 0.0076 ns | 0.0067 ns |  5.1028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.9887 ns | 0.0099 ns | 0.0087 ns |  4.9904 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  5.3488 ns | 0.0087 ns | 0.0077 ns |  5.3498 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  5.3066 ns | 0.0054 ns | 0.0048 ns |  5.3059 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  3.1741 ns | 0.0265 ns | 0.0248 ns |  3.1588 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  2.8659 ns | 0.0153 ns | 0.0136 ns |  2.8591 ns |  0.90 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  2.8384 ns | 0.0081 ns | 0.0068 ns |  2.8378 ns |  0.89 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  2.0449 ns | 0.0037 ns | 0.0031 ns |  2.0445 ns |  0.64 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  2.3515 ns | 0.0032 ns | 0.0028 ns |  2.3510 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  5.1119 ns | 0.0076 ns | 0.0071 ns |  5.1136 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  5.1108 ns | 0.0067 ns | 0.0059 ns |  5.1116 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.9437 ns | 0.0118 ns | 0.0105 ns |  4.9397 ns |  0.97 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  5.3520 ns | 0.0051 ns | 0.0045 ns |  5.3529 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  5.3098 ns | 0.0071 ns | 0.0063 ns |  5.3102 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.4238 ns | 0.0025 ns | 0.0022 ns |  1.4243 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.6566 ns | 0.0055 ns | 0.0049 ns |  1.6552 ns |  1.16 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.5288 ns | 0.0025 ns | 0.0023 ns |  1.5285 ns |  1.07 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 |  1.8445 ns | 0.0032 ns | 0.0030 ns |  1.8444 ns |  1.30 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 |  1.9042 ns | 0.0049 ns | 0.0044 ns |  1.9035 ns |  1.34 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  1.1284 ns | 0.0065 ns | 0.0061 ns |  1.1295 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  1.1882 ns | 0.0071 ns | 0.0066 ns |  1.1899 ns |  1.05 |    0.01 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  1.3891 ns | 0.0536 ns | 0.0910 ns |  1.3731 ns |  1.24 |    0.08 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  0.9792 ns | 0.0014 ns | 0.0013 ns |  0.9795 ns |  0.87 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  1.1335 ns | 0.0031 ns | 0.0024 ns |  1.1331 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  2.0138 ns | 0.0068 ns | 0.0060 ns |  2.0118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.9875 ns | 0.0031 ns | 0.0028 ns |  1.9871 ns |  0.99 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.7257 ns | 0.0162 ns | 0.0151 ns |  1.7195 ns |  0.86 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  2.0450 ns | 0.0050 ns | 0.0044 ns |  2.0465 ns |  1.02 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  2.3532 ns | 0.0041 ns | 0.0038 ns |  2.3526 ns |  1.17 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.6439 ns | 0.0073 ns | 0.0068 ns |  4.6437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.4241 ns | 0.0292 ns | 0.0273 ns |  4.4108 ns |  0.95 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.4762 ns | 0.0042 ns | 0.0037 ns |  4.4757 ns |  0.96 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  5.3813 ns | 0.0218 ns | 0.0193 ns |  5.3897 ns |  1.16 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  5.3190 ns | 0.0182 ns | 0.0170 ns |  5.3151 ns |  1.15 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  1.4851 ns | 0.0026 ns | 0.0025 ns |  1.4853 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.4979 ns | 0.0028 ns | 0.0025 ns |  1.4979 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.4867 ns | 0.0032 ns | 0.0027 ns |  1.4858 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt |        net461 |  1.1324 ns | 0.0024 ns | 0.0023 ns |  1.1325 ns |  0.76 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  1.4265 ns | 0.0086 ns | 0.0076 ns |  1.4242 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2211 ns | 0.0177 ns | 0.0166 ns |  4.2259 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.4090 ns | 0.0058 ns | 0.0055 ns |  4.4071 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0189 ns | 0.0065 ns | 0.0061 ns |  4.0185 ns |  0.95 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4571 ns | 0.0225 ns | 0.0210 ns |  4.4624 ns |  1.06 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3852 ns | 0.0075 ns | 0.0067 ns |  4.3866 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  1.7858 ns | 0.0047 ns | 0.0044 ns |  1.7867 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.8902 ns | 0.0035 ns | 0.0031 ns |  1.8909 ns |  1.06 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.6341 ns | 0.0037 ns | 0.0035 ns |  1.6334 ns |  0.92 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 |  2.0528 ns | 0.0040 ns | 0.0037 ns |  2.0540 ns |  1.15 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 |  2.3936 ns | 0.0072 ns | 0.0064 ns |  2.3956 ns |  1.34 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.4581 ns | 0.0099 ns | 0.0093 ns |  4.4555 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.4102 ns | 0.0053 ns | 0.0050 ns |  4.4120 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.2469 ns | 0.0177 ns | 0.0148 ns |  4.2498 ns |  0.95 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  5.1457 ns | 0.0066 ns | 0.0062 ns |  5.1457 ns |  1.15 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  5.0797 ns | 0.0094 ns | 0.0078 ns |  5.0788 ns |  1.14 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  1.3937 ns | 0.0020 ns | 0.0016 ns |  1.3941 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.6368 ns | 0.0054 ns | 0.0051 ns |  1.6359 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.6292 ns | 0.0026 ns | 0.0024 ns |  1.6288 ns |  1.17 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 |  1.1341 ns | 0.0036 ns | 0.0034 ns |  1.1336 ns |  0.81 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  1.4264 ns | 0.0033 ns | 0.0030 ns |  1.4272 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  2.0928 ns | 0.0178 ns | 0.0166 ns |  2.0835 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  2.3623 ns | 0.0060 ns | 0.0056 ns |  2.3616 ns |  1.13 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.9396 ns | 0.0032 ns | 0.0030 ns |  1.9396 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  2.6636 ns | 0.0059 ns | 0.0055 ns |  2.6651 ns |  1.27 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.6093 ns | 0.0159 ns | 0.0149 ns |  2.6080 ns |  1.25 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  1.9472 ns | 0.0036 ns | 0.0032 ns |  1.9480 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.7083 ns | 0.0029 ns | 0.0027 ns |  1.7089 ns |  0.88 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4431 ns | 0.0040 ns | 0.0037 ns |  1.4430 ns |  0.74 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 |  2.0658 ns | 0.0061 ns | 0.0054 ns |  2.0656 ns |  1.06 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  2.3523 ns | 0.0031 ns | 0.0027 ns |  2.3514 ns |  1.21 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.0935 ns | 0.0041 ns | 0.0034 ns |  2.0930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  2.2637 ns | 0.0033 ns | 0.0027 ns |  2.2637 ns |  1.08 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1594 ns | 0.0097 ns | 0.0091 ns |  2.1603 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  3.4871 ns | 0.0024 ns | 0.0020 ns |  3.4873 ns |  1.67 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  3.4707 ns | 0.0094 ns | 0.0088 ns |  3.4698 ns |  1.66 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.7240 ns | 0.0042 ns | 0.0039 ns |  1.7236 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.4785 ns | 0.0054 ns | 0.0048 ns |  1.4767 ns |  0.86 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.5367 ns | 0.0044 ns | 0.0041 ns |  1.5382 ns |  0.89 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  1.0147 ns | 0.0033 ns | 0.0027 ns |  1.0145 ns |  0.59 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  1.1876 ns | 0.0046 ns | 0.0041 ns |  1.1860 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.4136 ns | 0.0123 ns | 0.0115 ns |  4.4138 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.6423 ns | 0.0141 ns | 0.0132 ns |  4.6372 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.4877 ns | 0.0131 ns | 0.0123 ns |  4.4849 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.8810 ns | 0.0048 ns | 0.0042 ns |  4.8814 ns |  1.11 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.8468 ns | 0.0051 ns | 0.0045 ns |  4.8462 ns |  1.10 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.5989 ns | 0.0097 ns | 0.0081 ns |  1.5996 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.6555 ns | 0.0197 ns | 0.0184 ns |  1.6655 ns |  1.04 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4444 ns | 0.0048 ns | 0.0043 ns |  1.4433 ns |  0.90 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net461 |  1.7828 ns | 0.0030 ns | 0.0027 ns |  1.7828 ns |  1.11 |    0.01 |      - |     - |     - |         - |
           ToDouble |        net472 |  1.4457 ns | 0.0040 ns | 0.0037 ns |  1.4455 ns |  0.90 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.7877 ns | 0.0107 ns | 0.0100 ns |  1.7824 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  2.1481 ns | 0.0081 ns | 0.0076 ns |  2.1460 ns |  1.20 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1889 ns | 0.0072 ns | 0.0064 ns |  2.1867 ns |  1.22 |    0.01 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.7387 ns | 0.0249 ns | 0.0233 ns |  2.7484 ns |  1.53 |    0.02 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.6727 ns | 0.0270 ns | 0.0239 ns |  2.6678 ns |  1.49 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  6.0146 ns | 0.0098 ns | 0.0092 ns |  6.0158 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  6.2589 ns | 0.0132 ns | 0.0117 ns |  6.2570 ns |  1.04 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  6.0807 ns | 0.0053 ns | 0.0049 ns |  6.0807 ns |  1.01 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  6.5221 ns | 0.0108 ns | 0.0101 ns |  6.5191 ns |  1.08 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.2455 ns | 0.0121 ns | 0.0113 ns |  6.2470 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 18.5450 ns | 0.0317 ns | 0.0281 ns | 18.5439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 18.3312 ns | 0.0270 ns | 0.0239 ns | 18.3306 ns |  0.99 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 13.4073 ns | 0.0248 ns | 0.0207 ns | 13.4062 ns |  0.72 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 | 18.5660 ns | 0.0632 ns | 0.0560 ns | 18.5425 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 | 18.4677 ns | 0.0671 ns | 0.0627 ns | 18.4754 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2951 ns | 0.0081 ns | 0.0072 ns |  2.2973 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1378 ns | 0.0033 ns | 0.0029 ns |  2.1376 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3390 ns | 0.0038 ns | 0.0032 ns |  2.3387 ns |  1.02 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.4375 ns | 0.0020 ns | 0.0018 ns |  1.4375 ns |  0.63 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1338 ns | 0.0021 ns | 0.0020 ns |  1.1347 ns |  0.49 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8925 ns | 0.0179 ns | 0.0158 ns |  7.8912 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.2762 ns | 0.0116 ns | 0.0103 ns |  8.2759 ns |  1.05 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9442 ns | 0.0039 ns | 0.0036 ns |  1.9438 ns |  0.25 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.2216 ns | 0.0077 ns | 0.0065 ns |  8.2239 ns |  1.04 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4181 ns | 0.0112 ns | 0.0094 ns |  8.4149 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.9163 ns | 0.0068 ns | 0.0060 ns |  3.9159 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  4.5312 ns | 0.0329 ns | 0.0308 ns |  4.5211 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  4.5631 ns | 0.0327 ns | 0.0306 ns |  4.5602 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  3.6277 ns | 0.0181 ns | 0.0161 ns |  3.6320 ns |  0.93 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  3.7428 ns | 0.0131 ns | 0.0109 ns |  3.7411 ns |  0.96 |    0.00 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 29.1283 ns | 0.0474 ns | 0.0421 ns | 29.1370 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 17.6088 ns | 0.0276 ns | 0.0231 ns | 17.6121 ns |  0.60 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 13.3729 ns | 0.0900 ns | 0.0842 ns | 13.3298 ns |  0.46 |    0.00 |      - |     - |     - |         - |
          To_String |        net461 | 31.9372 ns | 0.1956 ns | 0.1734 ns | 31.8454 ns |  1.10 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 32.0456 ns | 0.0679 ns | 0.0567 ns | 32.0496 ns |  1.10 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 12.6350 ns | 0.0721 ns | 0.0639 ns | 12.6637 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 12.4187 ns | 0.0475 ns | 0.0444 ns | 12.4127 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.4788 ns | 0.0152 ns | 0.0135 ns |  8.4761 ns |  0.67 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 16.2021 ns | 0.0232 ns | 0.0205 ns | 16.2021 ns |  1.28 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 15.4896 ns | 0.0244 ns | 0.0204 ns | 15.4893 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 16.6969 ns | 0.0252 ns | 0.0223 ns | 16.7051 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 16.7373 ns | 0.0191 ns | 0.0160 ns | 16.7385 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 13.2187 ns | 0.0384 ns | 0.0359 ns | 13.2245 ns |  0.79 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 19.9565 ns | 0.1063 ns | 0.0994 ns | 19.8948 ns |  1.19 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 19.9834 ns | 0.0741 ns | 0.0657 ns | 20.0040 ns |  1.20 |    0.00 |      - |     - |     - |         - |
