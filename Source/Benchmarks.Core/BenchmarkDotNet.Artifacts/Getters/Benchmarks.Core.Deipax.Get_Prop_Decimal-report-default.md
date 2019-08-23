
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
             ToBool | .NET Core 2.0 |  7.4079 ns | 0.0114 ns | 0.0107 ns |  7.4077 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  7.3118 ns | 0.0114 ns | 0.0107 ns |  7.3108 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  4.4378 ns | 0.0304 ns | 0.0284 ns |  4.4457 ns |  0.60 |    0.00 |      - |     - |     - |         - |
             ToBool |        net461 |  6.5423 ns | 0.0077 ns | 0.0072 ns |  6.5407 ns |  0.88 |    0.00 |      - |     - |     - |         - |
             ToBool |        net472 |  6.5903 ns | 0.0103 ns | 0.0097 ns |  6.5907 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 | 14.1798 ns | 0.0198 ns | 0.0185 ns | 14.1802 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 14.3069 ns | 0.0240 ns | 0.0212 ns | 14.3074 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  7.1762 ns | 0.0109 ns | 0.0102 ns |  7.1762 ns |  0.51 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 | 15.0189 ns | 0.0208 ns | 0.0195 ns | 15.0137 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 | 15.2450 ns | 0.0189 ns | 0.0177 ns | 15.2481 ns |  1.08 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  1.1623 ns | 0.0026 ns | 0.0024 ns |  1.1629 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.1361 ns | 0.0028 ns | 0.0027 ns |  1.1365 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.1234 ns | 0.0076 ns | 0.0067 ns |  1.1251 ns |  0.97 |    0.01 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4288 ns | 0.0014 ns | 0.0013 ns |  0.4294 ns |  0.37 |    0.00 |      - |     - |     - |         - |
             ToChar |        net472 |  0.7275 ns | 0.0024 ns | 0.0023 ns |  0.7274 ns |  0.63 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  3.9260 ns | 0.0069 ns | 0.0061 ns |  3.9246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1947 ns | 0.0264 ns | 0.0247 ns |  4.2047 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9485 ns | 0.0056 ns | 0.0047 ns |  3.9478 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.1768 ns | 0.0135 ns | 0.0126 ns |  4.1793 ns |  1.06 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.1489 ns | 0.0073 ns | 0.0065 ns |  4.1477 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 | 13.9002 ns | 0.0189 ns | 0.0167 ns | 13.9028 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 13.2333 ns | 0.0103 ns | 0.0096 ns | 13.2315 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  7.3603 ns | 0.0461 ns | 0.0431 ns |  7.3752 ns |  0.53 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net461 | 13.1734 ns | 0.0140 ns | 0.0124 ns | 13.1741 ns |  0.95 |    0.00 |      - |     - |     - |         - |
            ToSByte |        net472 | 13.4719 ns | 0.0137 ns | 0.0128 ns | 13.4741 ns |  0.97 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 21.0594 ns | 0.0259 ns | 0.0242 ns | 21.0539 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 21.7133 ns | 0.0392 ns | 0.0348 ns | 21.7148 ns |  1.03 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  8.7911 ns | 0.0119 ns | 0.0099 ns |  8.7897 ns |  0.42 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 | 22.0162 ns | 0.0262 ns | 0.0245 ns | 22.0146 ns |  1.05 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 | 21.7949 ns | 0.0213 ns | 0.0200 ns | 21.7933 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 | 13.1419 ns | 0.0542 ns | 0.0507 ns | 13.1595 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 12.9843 ns | 0.0149 ns | 0.0124 ns | 12.9843 ns |  0.99 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  7.3236 ns | 0.1689 ns | 0.2311 ns |  7.4047 ns |  0.55 |    0.02 |      - |     - |     - |         - |
             ToByte |        net461 | 12.9386 ns | 0.0115 ns | 0.0096 ns | 12.9371 ns |  0.98 |    0.00 |      - |     - |     - |         - |
             ToByte |        net472 | 12.9660 ns | 0.0127 ns | 0.0113 ns | 12.9702 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 | 21.2431 ns | 0.0306 ns | 0.0287 ns | 21.2351 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 21.4979 ns | 0.0229 ns | 0.0203 ns | 21.4954 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  8.8540 ns | 0.0179 ns | 0.0158 ns |  8.8561 ns |  0.42 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 | 21.4551 ns | 0.0330 ns | 0.0308 ns | 21.4578 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 | 21.9647 ns | 0.0284 ns | 0.0237 ns | 21.9568 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 | 13.2923 ns | 0.0165 ns | 0.0154 ns | 13.2871 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 13.1755 ns | 0.0206 ns | 0.0193 ns | 13.1792 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  7.3009 ns | 0.0318 ns | 0.0298 ns |  7.3070 ns |  0.55 |    0.00 |      - |     - |     - |         - |
            ToShort |        net461 | 13.3013 ns | 0.0507 ns | 0.0474 ns | 13.3050 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort |        net472 | 13.2606 ns | 0.0135 ns | 0.0120 ns | 13.2622 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 | 21.6507 ns | 0.0238 ns | 0.0223 ns | 21.6527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 21.6964 ns | 0.0229 ns | 0.0214 ns | 21.7034 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  9.0973 ns | 0.4194 ns | 0.4307 ns |  8.8899 ns |  0.42 |    0.02 |      - |     - |     - |         - |
    ToShortNullable |        net461 | 21.6283 ns | 0.0216 ns | 0.0202 ns | 21.6252 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 | 22.0368 ns | 0.0139 ns | 0.0130 ns | 22.0371 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 | 13.7891 ns | 0.0338 ns | 0.0316 ns | 13.7969 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 13.0819 ns | 0.0522 ns | 0.0463 ns | 13.0842 ns |  0.95 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  6.7105 ns | 0.0189 ns | 0.0177 ns |  6.7062 ns |  0.49 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net461 | 13.1879 ns | 0.0091 ns | 0.0085 ns | 13.1886 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 | 12.9986 ns | 0.0123 ns | 0.0109 ns | 12.9978 ns |  0.94 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 21.4433 ns | 0.0185 ns | 0.0174 ns | 21.4470 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 21.4303 ns | 0.0191 ns | 0.0178 ns | 21.4253 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  8.7925 ns | 0.0125 ns | 0.0117 ns |  8.7952 ns |  0.41 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 | 22.0480 ns | 0.0263 ns | 0.0246 ns | 22.0475 ns |  1.03 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net472 | 21.4620 ns | 0.0214 ns | 0.0200 ns | 21.4633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 | 12.5721 ns | 0.0169 ns | 0.0158 ns | 12.5726 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 12.7384 ns | 0.0253 ns | 0.0224 ns | 12.7340 ns |  1.01 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  6.0092 ns | 0.0673 ns | 0.0630 ns |  5.9916 ns |  0.48 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  5.9933 ns | 0.0064 ns | 0.0057 ns |  5.9926 ns |  0.48 |    0.00 |      - |     - |     - |         - |
              ToInt |        net472 |  6.6474 ns | 0.0120 ns | 0.0107 ns |  6.6450 ns |  0.53 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 | 20.6589 ns | 0.0267 ns | 0.0237 ns | 20.6547 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 21.1909 ns | 0.0242 ns | 0.0214 ns | 21.1944 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  7.9376 ns | 0.0101 ns | 0.0094 ns |  7.9364 ns |  0.38 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net461 | 14.6605 ns | 0.0702 ns | 0.0657 ns | 14.6791 ns |  0.71 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 | 14.3010 ns | 0.0192 ns | 0.0170 ns | 14.2955 ns |  0.69 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 | 12.2623 ns | 0.0111 ns | 0.0103 ns | 12.2633 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 12.5814 ns | 0.0163 ns | 0.0145 ns | 12.5834 ns |  1.03 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  5.5253 ns | 0.0184 ns | 0.0163 ns |  5.5259 ns |  0.45 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net461 | 12.2696 ns | 0.0127 ns | 0.0119 ns | 12.2731 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt |        net472 | 12.3545 ns | 0.0637 ns | 0.0596 ns | 12.3763 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 20.8620 ns | 0.0189 ns | 0.0177 ns | 20.8592 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 20.6634 ns | 0.0283 ns | 0.0265 ns | 20.6685 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  7.8661 ns | 0.0122 ns | 0.0108 ns |  7.8664 ns |  0.38 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net461 | 20.7370 ns | 0.0205 ns | 0.0192 ns | 20.7293 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable |        net472 | 20.9918 ns | 0.0210 ns | 0.0197 ns | 20.9918 ns |  1.01 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 | 12.5081 ns | 0.0135 ns | 0.0126 ns | 12.5097 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 12.8719 ns | 0.0926 ns | 0.0866 ns | 12.8318 ns |  1.03 |    0.01 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  5.3660 ns | 0.0110 ns | 0.0097 ns |  5.3645 ns |  0.43 |    0.00 |      - |     - |     - |         - |
             ToLong |        net461 | 12.5381 ns | 0.0096 ns | 0.0090 ns | 12.5383 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 | 12.7891 ns | 0.0106 ns | 0.0099 ns | 12.7906 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 | 13.1852 ns | 0.0165 ns | 0.0155 ns | 13.1833 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 13.3346 ns | 0.0255 ns | 0.0226 ns | 13.3326 ns |  1.01 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  6.0880 ns | 0.0050 ns | 0.0047 ns |  6.0875 ns |  0.46 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net461 | 13.5312 ns | 0.0211 ns | 0.0176 ns | 13.5289 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     ToLongNullable |        net472 | 13.5344 ns | 0.0163 ns | 0.0152 ns | 13.5305 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 | 12.2924 ns | 0.0192 ns | 0.0161 ns | 12.2955 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 12.5274 ns | 0.0179 ns | 0.0167 ns | 12.5245 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  5.3682 ns | 0.0085 ns | 0.0075 ns |  5.3681 ns |  0.44 |    0.00 |      - |     - |     - |         - |
            ToULong |        net461 | 12.5405 ns | 0.0150 ns | 0.0141 ns | 12.5423 ns |  1.02 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 | 12.5417 ns | 0.0166 ns | 0.0155 ns | 12.5392 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 | 12.9889 ns | 0.0117 ns | 0.0110 ns | 12.9898 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 12.9925 ns | 0.0227 ns | 0.0202 ns | 12.9937 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  5.6137 ns | 0.0077 ns | 0.0068 ns |  5.6149 ns |  0.43 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 | 13.2027 ns | 0.0133 ns | 0.0111 ns | 13.2013 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net472 | 13.2915 ns | 0.0587 ns | 0.0490 ns | 13.3091 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  9.5882 ns | 0.0391 ns | 0.0365 ns |  9.5976 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 10.0697 ns | 0.0134 ns | 0.0125 ns | 10.0726 ns |  1.05 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  5.1948 ns | 0.0180 ns | 0.0168 ns |  5.1893 ns |  0.54 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net461 |  8.9330 ns | 0.0135 ns | 0.0126 ns |  8.9323 ns |  0.93 |    0.00 |      - |     - |     - |         - |
            ToFloat |        net472 |  9.1028 ns | 0.0108 ns | 0.0101 ns |  9.1037 ns |  0.95 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 14.8695 ns | 0.0189 ns | 0.0177 ns | 14.8700 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 15.0092 ns | 0.0312 ns | 0.0244 ns | 15.0077 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  6.9756 ns | 0.0110 ns | 0.0103 ns |  6.9739 ns |  0.47 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 | 15.1838 ns | 0.0256 ns | 0.0227 ns | 15.1932 ns |  1.02 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 | 15.1562 ns | 0.0213 ns | 0.0199 ns | 15.1541 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  7.6061 ns | 0.0161 ns | 0.0151 ns |  7.5998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  8.8181 ns | 0.0096 ns | 0.0090 ns |  8.8165 ns |  1.16 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  4.8915 ns | 0.0068 ns | 0.0060 ns |  4.8915 ns |  0.64 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net461 |  7.2909 ns | 0.0315 ns | 0.0280 ns |  7.2933 ns |  0.96 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  6.4695 ns | 0.0075 ns | 0.0066 ns |  6.4703 ns |  0.85 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  8.2588 ns | 0.0116 ns | 0.0102 ns |  8.2612 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  8.2990 ns | 0.0087 ns | 0.0082 ns |  8.2986 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  6.0922 ns | 0.0059 ns | 0.0052 ns |  6.0931 ns |  0.74 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  8.5973 ns | 0.0158 ns | 0.0148 ns |  8.5942 ns |  1.04 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  8.4835 ns | 0.0074 ns | 0.0069 ns |  8.4836 ns |  1.03 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  1.7715 ns | 0.0024 ns | 0.0023 ns |  1.7717 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.5653 ns | 0.0025 ns | 0.0023 ns |  1.5652 ns |  0.88 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.0159 ns | 0.0034 ns | 0.0032 ns |  2.0160 ns |  1.14 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net461 |  1.5674 ns | 0.0041 ns | 0.0036 ns |  1.5667 ns |  0.88 |    0.00 |      - |     - |     - |         - |
          ToDecimal |        net472 |  1.8077 ns | 0.0027 ns | 0.0025 ns |  1.8081 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  5.5985 ns | 0.0326 ns | 0.0305 ns |  5.6107 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  5.5528 ns | 0.0061 ns | 0.0057 ns |  5.5518 ns |  0.99 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  5.6034 ns | 0.0205 ns | 0.0171 ns |  5.6045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  5.5408 ns | 0.0074 ns | 0.0069 ns |  5.5398 ns |  0.99 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  5.5466 ns | 0.0073 ns | 0.0069 ns |  5.5479 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.2591 ns | 0.0053 ns | 0.0050 ns |  2.2571 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.3197 ns | 0.0075 ns | 0.0063 ns |  2.3209 ns |  1.03 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  1.8516 ns | 0.0027 ns | 0.0025 ns |  1.8523 ns |  0.82 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net461 |  0.9255 ns | 0.0106 ns | 0.0099 ns |  0.9204 ns |  0.41 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1196 ns | 0.0021 ns | 0.0017 ns |  1.1193 ns |  0.50 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  7.8618 ns | 0.0105 ns | 0.0087 ns |  7.8615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  7.8093 ns | 0.0163 ns | 0.0152 ns |  7.8091 ns |  0.99 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.8621 ns | 0.0044 ns | 0.0039 ns |  1.8617 ns |  0.24 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  7.7341 ns | 0.0081 ns | 0.0075 ns |  7.7313 ns |  0.98 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  7.9847 ns | 0.0106 ns | 0.0099 ns |  7.9831 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.9983 ns | 0.0549 ns | 0.0513 ns |  3.9987 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 2.2 |  4.6104 ns | 0.0058 ns | 0.0045 ns |  4.6107 ns |  1.15 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject | .NET Core 3.0 |  4.3241 ns | 0.0414 ns | 0.0387 ns |  4.3361 ns |  1.08 |    0.02 | 0.0051 |     - |     - |      32 B |
           ToObject |        net461 |  3.2693 ns | 0.0094 ns | 0.0088 ns |  3.2688 ns |  0.82 |    0.01 | 0.0051 |     - |     - |      32 B |
           ToObject |        net472 |  3.2094 ns | 0.0126 ns | 0.0112 ns |  3.2104 ns |  0.80 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
          To_String | .NET Core 2.0 | 51.9832 ns | 0.1024 ns | 0.0958 ns | 51.9872 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 | 47.3875 ns | 0.0838 ns | 0.0783 ns | 47.3900 ns |  0.91 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 | 47.4211 ns | 0.0891 ns | 0.0833 ns | 47.4104 ns |  0.91 |    0.00 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 | 50.7794 ns | 0.0419 ns | 0.0371 ns | 50.7815 ns |  0.98 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 | 51.0607 ns | 0.0730 ns | 0.0647 ns | 51.0359 ns |  0.98 |    0.00 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |            |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 27.4242 ns | 0.0509 ns | 0.0425 ns | 27.4359 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 26.9643 ns | 0.1415 ns | 0.1254 ns | 27.0106 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 12.3954 ns | 0.0168 ns | 0.0157 ns | 12.4022 ns |  0.45 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 22.8028 ns | 0.0293 ns | 0.0274 ns | 22.8044 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net472 | 24.5318 ns | 0.0294 ns | 0.0245 ns | 24.5394 ns |  0.89 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |            |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 31.2103 ns | 0.0495 ns | 0.0463 ns | 31.2084 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 31.1561 ns | 0.0313 ns | 0.0277 ns | 31.1624 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 22.0737 ns | 0.0201 ns | 0.0188 ns | 22.0789 ns |  0.71 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 27.4819 ns | 0.1218 ns | 0.1080 ns | 27.5306 ns |  0.88 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 27.2270 ns | 0.0131 ns | 0.0117 ns | 27.2285 ns |  0.87 |    0.00 |      - |     - |     - |         - |
