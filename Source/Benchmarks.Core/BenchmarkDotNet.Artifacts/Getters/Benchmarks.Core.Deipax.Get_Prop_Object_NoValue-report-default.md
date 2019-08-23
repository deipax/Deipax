
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-XPIDXK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-TONOSH : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-YEBKOB : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-TGKQNS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-PNUVLP : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


             Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             ToBool | .NET Core 2.0 | 2.0377 ns | 0.0076 ns | 0.0071 ns | 2.0361 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 | 2.0309 ns | 0.0023 ns | 0.0022 ns | 2.0309 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 | 1.9498 ns | 0.0025 ns | 0.0024 ns | 1.9497 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 | 1.7997 ns | 0.0039 ns | 0.0035 ns | 1.7993 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToBool |        net472 | 1.8198 ns | 0.0053 ns | 0.0044 ns | 1.8197 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 | 5.0039 ns | 0.0075 ns | 0.0070 ns | 5.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 | 4.8517 ns | 0.0055 ns | 0.0049 ns | 4.8523 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 | 4.6569 ns | 0.0048 ns | 0.0045 ns | 4.6561 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 | 4.8603 ns | 0.0079 ns | 0.0070 ns | 4.8591 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 | 4.8995 ns | 0.0259 ns | 0.0217 ns | 4.9073 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 | 2.0295 ns | 0.0025 ns | 0.0023 ns | 2.0284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 | 2.0297 ns | 0.0034 ns | 0.0030 ns | 2.0295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 | 1.9147 ns | 0.0033 ns | 0.0028 ns | 1.9139 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             ToChar |        net461 | 1.7999 ns | 0.0044 ns | 0.0041 ns | 1.7988 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 | 1.7948 ns | 0.0037 ns | 0.0032 ns | 1.7940 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 | 4.9700 ns | 0.0324 ns | 0.0303 ns | 4.9819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 | 5.2615 ns | 0.0054 ns | 0.0045 ns | 5.2615 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 | 4.6749 ns | 0.0272 ns | 0.0254 ns | 4.6900 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net461 | 5.3691 ns | 0.0045 ns | 0.0042 ns | 5.3700 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     ToCharNullable |        net472 | 5.3153 ns | 0.0064 ns | 0.0060 ns | 5.3150 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 | 2.2335 ns | 0.0029 ns | 0.0027 ns | 2.2340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 | 2.3967 ns | 0.0162 ns | 0.0144 ns | 2.4023 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 | 1.9222 ns | 0.0039 ns | 0.0037 ns | 1.9228 ns |  0.86 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 | 1.7993 ns | 0.0026 ns | 0.0025 ns | 1.7989 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 | 1.7950 ns | 0.0025 ns | 0.0021 ns | 1.7945 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 | 4.9346 ns | 0.0094 ns | 0.0088 ns | 4.9359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 | 5.2564 ns | 0.0050 ns | 0.0046 ns | 5.2569 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 | 4.6501 ns | 0.0054 ns | 0.0051 ns | 4.6510 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 | 5.3286 ns | 0.0093 ns | 0.0087 ns | 5.3268 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 | 5.3146 ns | 0.0051 ns | 0.0048 ns | 5.3155 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 | 2.0322 ns | 0.0027 ns | 0.0026 ns | 2.0326 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 | 2.0501 ns | 0.0019 ns | 0.0018 ns | 2.0502 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 | 1.9384 ns | 0.0031 ns | 0.0028 ns | 1.9388 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToByte |        net461 | 1.7973 ns | 0.0024 ns | 0.0020 ns | 1.7981 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 | 2.2640 ns | 0.0034 ns | 0.0032 ns | 2.2651 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 | 4.9241 ns | 0.0042 ns | 0.0040 ns | 4.9249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 | 5.3111 ns | 0.0042 ns | 0.0037 ns | 5.3123 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 | 4.7484 ns | 0.0068 ns | 0.0063 ns | 4.7501 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 | 5.3196 ns | 0.0068 ns | 0.0064 ns | 5.3204 ns |  1.08 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net472 | 5.3182 ns | 0.0089 ns | 0.0079 ns | 5.3196 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 | 2.0352 ns | 0.0040 ns | 0.0038 ns | 2.0346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 | 2.0319 ns | 0.0029 ns | 0.0026 ns | 2.0317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 | 1.9392 ns | 0.0040 ns | 0.0038 ns | 1.9385 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            ToShort |        net461 | 1.8373 ns | 0.0031 ns | 0.0027 ns | 1.8375 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 | 1.8149 ns | 0.0031 ns | 0.0026 ns | 1.8152 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 | 4.9363 ns | 0.0091 ns | 0.0085 ns | 4.9340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 | 5.3132 ns | 0.0046 ns | 0.0040 ns | 5.3136 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 | 4.7521 ns | 0.0075 ns | 0.0070 ns | 4.7506 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 | 5.3222 ns | 0.0057 ns | 0.0051 ns | 5.3222 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 | 5.3127 ns | 0.0061 ns | 0.0057 ns | 5.3139 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 | 2.4239 ns | 0.0143 ns | 0.0127 ns | 2.4266 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 | 2.0337 ns | 0.0040 ns | 0.0038 ns | 2.0338 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 | 1.9118 ns | 0.0023 ns | 0.0021 ns | 1.9122 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 | 1.7992 ns | 0.0042 ns | 0.0037 ns | 1.8002 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 | 2.3824 ns | 0.0043 ns | 0.0040 ns | 2.3827 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 | 4.9273 ns | 0.0094 ns | 0.0083 ns | 4.9283 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 | 5.2885 ns | 0.0295 ns | 0.0276 ns | 5.2734 ns |  1.07 |    0.01 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 | 4.6617 ns | 0.0056 ns | 0.0050 ns | 4.6622 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 | 5.3183 ns | 0.0067 ns | 0.0053 ns | 5.3189 ns |  1.08 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 | 5.3172 ns | 0.0081 ns | 0.0072 ns | 5.3182 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 | 2.0314 ns | 0.0053 ns | 0.0049 ns | 2.0305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 | 2.0526 ns | 0.0032 ns | 0.0030 ns | 2.0520 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 | 1.9114 ns | 0.0025 ns | 0.0024 ns | 1.9111 ns |  0.94 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 | 1.8554 ns | 0.0045 ns | 0.0042 ns | 1.8556 ns |  0.91 |    0.00 |     - |     - |     - |         - |
              ToInt |        net472 | 1.8509 ns | 0.0033 ns | 0.0031 ns | 1.8501 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 | 4.8952 ns | 0.0045 ns | 0.0042 ns | 4.8961 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 | 5.2573 ns | 0.0046 ns | 0.0043 ns | 5.2570 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 | 4.6523 ns | 0.0079 ns | 0.0074 ns | 4.6516 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 | 5.3612 ns | 0.0074 ns | 0.0069 ns | 5.3612 ns |  1.10 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 | 5.3073 ns | 0.0050 ns | 0.0047 ns | 5.3079 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 | 2.2445 ns | 0.0044 ns | 0.0039 ns | 2.2435 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 | 2.0526 ns | 0.0021 ns | 0.0019 ns | 2.0526 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 | 1.9530 ns | 0.0046 ns | 0.0043 ns | 1.9540 ns |  0.87 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 | 1.8284 ns | 0.0031 ns | 0.0029 ns | 1.8276 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net472 | 1.8239 ns | 0.0029 ns | 0.0028 ns | 1.8243 ns |  0.81 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 | 4.9652 ns | 0.0184 ns | 0.0153 ns | 4.9691 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 | 5.3070 ns | 0.0061 ns | 0.0057 ns | 5.3056 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 | 4.6546 ns | 0.0048 ns | 0.0045 ns | 4.6555 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 | 5.3236 ns | 0.0059 ns | 0.0052 ns | 5.3241 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net472 | 5.3102 ns | 0.0054 ns | 0.0051 ns | 5.3107 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 | 2.0501 ns | 0.0038 ns | 0.0034 ns | 2.0491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 | 2.0574 ns | 0.0240 ns | 0.0225 ns | 2.0637 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 | 1.9427 ns | 0.0029 ns | 0.0027 ns | 1.9431 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 | 1.8280 ns | 0.0040 ns | 0.0037 ns | 1.8285 ns |  0.89 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 | 1.8223 ns | 0.0024 ns | 0.0022 ns | 1.8214 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 | 3.6608 ns | 0.0210 ns | 0.0186 ns | 3.6670 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 | 3.9975 ns | 0.0070 ns | 0.0062 ns | 3.9969 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 | 2.8367 ns | 0.0113 ns | 0.0094 ns | 2.8386 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 | 4.3973 ns | 0.0778 ns | 0.0727 ns | 4.4108 ns |  1.20 |    0.02 |     - |     - |     - |         - |
     ToLongNullable |        net472 | 2.8021 ns | 0.0046 ns | 0.0043 ns | 2.8021 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 | 2.0475 ns | 0.0053 ns | 0.0049 ns | 2.0485 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 | 2.0394 ns | 0.0118 ns | 0.0110 ns | 2.0432 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 | 1.9139 ns | 0.0033 ns | 0.0031 ns | 1.9142 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 | 1.8274 ns | 0.0022 ns | 0.0020 ns | 1.8274 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 | 1.8688 ns | 0.0035 ns | 0.0033 ns | 1.8691 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 | 3.0709 ns | 0.0033 ns | 0.0031 ns | 3.0702 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 | 2.8368 ns | 0.0044 ns | 0.0041 ns | 2.8385 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 | 2.8452 ns | 0.0302 ns | 0.0282 ns | 2.8534 ns |  0.93 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net461 | 2.8595 ns | 0.0064 ns | 0.0060 ns | 2.8595 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net472 | 3.6519 ns | 0.0089 ns | 0.0084 ns | 3.6506 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 | 2.1876 ns | 0.0037 ns | 0.0031 ns | 2.1881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 | 2.1330 ns | 0.0059 ns | 0.0055 ns | 2.1338 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 | 1.9549 ns | 0.0032 ns | 0.0030 ns | 1.9557 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net461 | 1.8011 ns | 0.0038 ns | 0.0032 ns | 1.8013 ns |  0.82 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 | 2.2571 ns | 0.0043 ns | 0.0040 ns | 2.2580 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 | 5.1502 ns | 0.0066 ns | 0.0062 ns | 5.1490 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 | 5.3128 ns | 0.0042 ns | 0.0039 ns | 5.3124 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 | 4.8828 ns | 0.0051 ns | 0.0047 ns | 4.8836 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 | 5.4409 ns | 0.0073 ns | 0.0069 ns | 5.4422 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 | 5.4280 ns | 0.0088 ns | 0.0082 ns | 5.4282 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 | 2.1507 ns | 0.0039 ns | 0.0034 ns | 2.1505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 | 2.1775 ns | 0.0047 ns | 0.0044 ns | 2.1776 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 | 2.0023 ns | 0.0041 ns | 0.0036 ns | 2.0011 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 | 1.8034 ns | 0.0039 ns | 0.0037 ns | 1.8030 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 | 2.2201 ns | 0.0033 ns | 0.0031 ns | 2.2201 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 | 3.3035 ns | 0.0061 ns | 0.0057 ns | 3.3045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 | 3.2458 ns | 0.0082 ns | 0.0077 ns | 3.2446 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 | 3.0412 ns | 0.0041 ns | 0.0036 ns | 3.0400 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 | 3.0342 ns | 0.0062 ns | 0.0058 ns | 3.0354 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 | 3.0278 ns | 0.0046 ns | 0.0043 ns | 3.0284 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 | 3.3672 ns | 0.0929 ns | 0.1106 ns | 3.4218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 | 3.1886 ns | 0.0031 ns | 0.0027 ns | 3.1881 ns |  0.96 |    0.04 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 | 3.6023 ns | 0.1534 ns | 0.4522 ns | 3.4465 ns |  1.04 |    0.10 |     - |     - |     - |         - |
          ToDecimal |        net461 | 6.9353 ns | 0.0086 ns | 0.0081 ns | 6.9334 ns |  2.08 |    0.08 |     - |     - |     - |         - |
          ToDecimal |        net472 | 6.9417 ns | 0.0062 ns | 0.0051 ns | 6.9410 ns |  2.07 |    0.08 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 9.5682 ns | 0.0118 ns | 0.0111 ns | 9.5684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 9.8072 ns | 0.0170 ns | 0.0159 ns | 9.8092 ns |  1.02 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 | 3.2656 ns | 0.0126 ns | 0.0118 ns | 3.2611 ns |  0.34 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 9.3428 ns | 0.0144 ns | 0.0134 ns | 9.3430 ns |  0.98 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 9.3395 ns | 0.0133 ns | 0.0124 ns | 9.3444 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 | 2.7653 ns | 0.0099 ns | 0.0093 ns | 2.7686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 | 2.9203 ns | 0.0039 ns | 0.0033 ns | 2.9203 ns |  1.06 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 | 2.8447 ns | 0.0044 ns | 0.0039 ns | 2.8447 ns |  1.03 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 | 2.1005 ns | 0.0044 ns | 0.0039 ns | 2.1006 ns |  0.76 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 | 2.0965 ns | 0.0030 ns | 0.0028 ns | 2.0963 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 | 9.0800 ns | 0.0101 ns | 0.0085 ns | 9.0825 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 | 9.7670 ns | 0.0234 ns | 0.0219 ns | 9.7736 ns |  1.08 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 | 3.5673 ns | 0.0946 ns | 0.0971 ns | 3.5423 ns |  0.39 |    0.01 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 9.3433 ns | 0.0107 ns | 0.0095 ns | 9.3417 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 | 9.3512 ns | 0.0147 ns | 0.0131 ns | 9.3489 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 | 1.1628 ns | 0.0041 ns | 0.0038 ns | 1.1617 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 | 1.1410 ns | 0.0018 ns | 0.0017 ns | 1.1413 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 | 0.9173 ns | 0.0023 ns | 0.0022 ns | 0.9178 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 | 0.4321 ns | 0.0020 ns | 0.0018 ns | 0.4325 ns |  0.37 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 | 0.4284 ns | 0.0020 ns | 0.0018 ns | 0.4281 ns |  0.37 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
          To_String | .NET Core 2.0 | 1.9341 ns | 0.0031 ns | 0.0027 ns | 1.9338 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 | 1.8411 ns | 0.0030 ns | 0.0028 ns | 1.8412 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 | 1.6072 ns | 0.0042 ns | 0.0040 ns | 1.6071 ns |  0.83 |    0.00 |     - |     - |     - |         - |
          To_String |        net461 | 1.6770 ns | 0.0027 ns | 0.0023 ns | 1.6774 ns |  0.87 |    0.00 |     - |     - |     - |         - |
          To_String |        net472 | 1.6697 ns | 0.0036 ns | 0.0032 ns | 1.6705 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 | 1.8697 ns | 0.0035 ns | 0.0033 ns | 1.8695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 1.8467 ns | 0.0093 ns | 0.0077 ns | 1.8442 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 | 1.6776 ns | 0.0034 ns | 0.0032 ns | 1.6771 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 | 1.6764 ns | 0.0027 ns | 0.0025 ns | 1.6759 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 | 1.6718 ns | 0.0031 ns | 0.0027 ns | 1.6708 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                    |               |           |           |           |           |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 4.7327 ns | 0.0154 ns | 0.0136 ns | 4.7348 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 4.8561 ns | 0.0066 ns | 0.0062 ns | 4.8562 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 4.4183 ns | 0.0042 ns | 0.0039 ns | 4.4183 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 | 4.8601 ns | 0.0060 ns | 0.0053 ns | 4.8606 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 | 4.9107 ns | 0.0061 ns | 0.0057 ns | 4.9110 ns |  1.04 |    0.00 |     - |     - |     - |         - |
