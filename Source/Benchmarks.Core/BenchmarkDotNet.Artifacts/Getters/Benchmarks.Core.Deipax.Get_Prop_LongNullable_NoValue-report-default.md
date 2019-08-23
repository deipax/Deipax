
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
             ToBool | .NET Core 2.0 |  1.2647 ns | 0.0029 ns | 0.0026 ns |  1.2641 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  1.3727 ns | 0.0025 ns | 0.0023 ns |  1.3726 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  1.6335 ns | 0.0040 ns | 0.0033 ns |  1.6340 ns |  1.29 |    0.00 |     - |     - |     - |         - |
             ToBool |        net461 |  0.9921 ns | 0.0144 ns | 0.0135 ns |  0.9988 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             ToBool |        net472 |  0.9617 ns | 0.0028 ns | 0.0024 ns |  0.9618 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  3.9945 ns | 0.0039 ns | 0.0037 ns |  3.9937 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.1209 ns | 0.0082 ns | 0.0073 ns |  4.1206 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0039 ns | 0.0088 ns | 0.0082 ns |  4.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.1904 ns | 0.0113 ns | 0.0106 ns |  4.1871 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.1549 ns | 0.0063 ns | 0.0049 ns |  4.1536 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToChar | .NET Core 2.0 |  1.2953 ns | 0.0022 ns | 0.0021 ns |  1.2948 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2120 ns | 0.0110 ns | 0.0103 ns |  1.2078 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  1.5099 ns | 0.0152 ns | 0.0135 ns |  1.5138 ns |  1.17 |    0.01 |     - |     - |     - |         - |
             ToChar |        net461 |  0.9712 ns | 0.0027 ns | 0.0024 ns |  0.9709 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             ToChar |        net472 |  0.9625 ns | 0.0039 ns | 0.0036 ns |  0.9616 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.2338 ns | 0.0114 ns | 0.0101 ns |  4.2322 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.1217 ns | 0.0059 ns | 0.0055 ns |  4.1214 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  3.9989 ns | 0.0062 ns | 0.0055 ns |  4.0006 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net461 |  4.4210 ns | 0.0102 ns | 0.0091 ns |  4.4193 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     ToCharNullable |        net472 |  4.3807 ns | 0.0063 ns | 0.0056 ns |  4.3807 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2249 ns | 0.0034 ns | 0.0028 ns |  1.2249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.3310 ns | 0.0033 ns | 0.0030 ns |  1.3305 ns |  1.09 |    0.00 |     - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.4148 ns | 0.0028 ns | 0.0025 ns |  1.4151 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net461 |  0.9714 ns | 0.0018 ns | 0.0017 ns |  0.9711 ns |  0.79 |    0.00 |     - |     - |     - |         - |
            ToSByte |        net472 |  0.9817 ns | 0.0041 ns | 0.0037 ns |  0.9815 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.2772 ns | 0.0060 ns | 0.0056 ns |  4.2768 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.1280 ns | 0.0103 ns | 0.0091 ns |  4.1255 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0003 ns | 0.0054 ns | 0.0050 ns |  4.0003 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.4175 ns | 0.0123 ns | 0.0109 ns |  4.4141 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.4307 ns | 0.0277 ns | 0.0259 ns |  4.4389 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToByte | .NET Core 2.0 |  1.3198 ns | 0.0039 ns | 0.0035 ns |  1.3194 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.2109 ns | 0.0083 ns | 0.0074 ns |  1.2100 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.2851 ns | 0.0162 ns | 0.0152 ns |  1.2849 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             ToByte |        net461 |  0.9721 ns | 0.0016 ns | 0.0014 ns |  0.9722 ns |  0.74 |    0.00 |     - |     - |     - |         - |
             ToByte |        net472 |  0.9628 ns | 0.0025 ns | 0.0022 ns |  0.9631 ns |  0.73 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.2314 ns | 0.0072 ns | 0.0064 ns |  4.2305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.1238 ns | 0.0071 ns | 0.0067 ns |  4.1241 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0075 ns | 0.0067 ns | 0.0062 ns |  4.0081 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToByteNullable |        net461 |  4.4212 ns | 0.0262 ns | 0.0245 ns |  4.4092 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToByteNullable |        net472 |  4.3867 ns | 0.0042 ns | 0.0037 ns |  4.3868 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToShort | .NET Core 2.0 |  1.2529 ns | 0.0020 ns | 0.0019 ns |  1.2531 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.3301 ns | 0.0037 ns | 0.0029 ns |  1.3291 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.6493 ns | 0.0082 ns | 0.0068 ns |  1.6510 ns |  1.32 |    0.01 |     - |     - |     - |         - |
            ToShort |        net461 |  1.0109 ns | 0.0028 ns | 0.0026 ns |  1.0110 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            ToShort |        net472 |  0.9627 ns | 0.0023 ns | 0.0021 ns |  0.9630 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.2382 ns | 0.0112 ns | 0.0105 ns |  4.2346 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.1231 ns | 0.0064 ns | 0.0060 ns |  4.1217 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0136 ns | 0.0062 ns | 0.0058 ns |  4.0134 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net461 |  4.4108 ns | 0.0062 ns | 0.0055 ns |  4.4107 ns |  1.04 |    0.00 |     - |     - |     - |         - |
    ToShortNullable |        net472 |  4.3890 ns | 0.0053 ns | 0.0050 ns |  4.3878 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToUShort | .NET Core 2.0 |  1.2934 ns | 0.0020 ns | 0.0018 ns |  1.2933 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  1.2122 ns | 0.0044 ns | 0.0041 ns |  1.2128 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  1.2869 ns | 0.0043 ns | 0.0040 ns |  1.2875 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net461 |  0.9697 ns | 0.0022 ns | 0.0018 ns |  0.9699 ns |  0.75 |    0.00 |     - |     - |     - |         - |
           ToUShort |        net472 |  0.9647 ns | 0.0053 ns | 0.0047 ns |  0.9635 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.2337 ns | 0.0080 ns | 0.0075 ns |  4.2317 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.1193 ns | 0.0062 ns | 0.0055 ns |  4.1193 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0164 ns | 0.0062 ns | 0.0058 ns |  4.0156 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.4152 ns | 0.0056 ns | 0.0052 ns |  4.4153 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.3869 ns | 0.0042 ns | 0.0037 ns |  4.3870 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
              ToInt | .NET Core 2.0 |  1.2244 ns | 0.0033 ns | 0.0029 ns |  1.2240 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.3302 ns | 0.0038 ns | 0.0034 ns |  1.3299 ns |  1.09 |    0.00 |     - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  1.6408 ns | 0.0029 ns | 0.0024 ns |  1.6410 ns |  1.34 |    0.00 |     - |     - |     - |         - |
              ToInt |        net461 |  0.9409 ns | 0.0138 ns | 0.0129 ns |  0.9444 ns |  0.77 |    0.01 |     - |     - |     - |         - |
              ToInt |        net472 |  0.9296 ns | 0.0033 ns | 0.0026 ns |  0.9305 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.2337 ns | 0.0039 ns | 0.0036 ns |  4.2330 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.1281 ns | 0.0281 ns | 0.0263 ns |  4.1119 ns |  0.98 |    0.01 |     - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0120 ns | 0.0087 ns | 0.0072 ns |  4.0149 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net461 |  4.4101 ns | 0.0059 ns | 0.0049 ns |  4.4095 ns |  1.04 |    0.00 |     - |     - |     - |         - |
      ToIntNullable |        net472 |  4.3837 ns | 0.0046 ns | 0.0038 ns |  4.3833 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToUInt | .NET Core 2.0 |  1.3137 ns | 0.0047 ns | 0.0044 ns |  1.3133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  1.4712 ns | 0.0042 ns | 0.0039 ns |  1.4711 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  1.2473 ns | 0.0041 ns | 0.0036 ns |  1.2465 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             ToUInt |        net461 |  0.9625 ns | 0.0084 ns | 0.0070 ns |  0.9643 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             ToUInt |        net472 |  0.9274 ns | 0.0030 ns | 0.0028 ns |  0.9268 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.2395 ns | 0.0221 ns | 0.0206 ns |  4.2309 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.1154 ns | 0.0090 ns | 0.0084 ns |  4.1108 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0449 ns | 0.0121 ns | 0.0113 ns |  4.0450 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.4213 ns | 0.0122 ns | 0.0114 ns |  4.4205 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.4285 ns | 0.0183 ns | 0.0172 ns |  4.4338 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToLong | .NET Core 2.0 |  1.4128 ns | 0.0019 ns | 0.0018 ns |  1.4134 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  1.1628 ns | 0.0048 ns | 0.0045 ns |  1.1634 ns |  0.82 |    0.00 |     - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.4667 ns | 0.0022 ns | 0.0021 ns |  1.4670 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             ToLong |        net461 |  0.9579 ns | 0.0028 ns | 0.0027 ns |  0.9583 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             ToLong |        net472 |  0.9493 ns | 0.0026 ns | 0.0023 ns |  0.9495 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6408 ns | 0.0033 ns | 0.0029 ns |  1.6411 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.3751 ns | 0.0032 ns | 0.0029 ns |  1.3751 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.6473 ns | 0.0032 ns | 0.0030 ns |  1.6471 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net461 |  1.6502 ns | 0.0047 ns | 0.0044 ns |  1.6506 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     ToLongNullable |        net472 |  1.4031 ns | 0.0039 ns | 0.0035 ns |  1.4029 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToULong | .NET Core 2.0 |  1.4157 ns | 0.0036 ns | 0.0034 ns |  1.4153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  1.2872 ns | 0.0022 ns | 0.0021 ns |  1.2870 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  1.4207 ns | 0.0076 ns | 0.0071 ns |  1.4186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToULong |        net461 |  0.9387 ns | 0.0021 ns | 0.0019 ns |  0.9390 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            ToULong |        net472 |  0.9293 ns | 0.0036 ns | 0.0034 ns |  0.9285 ns |  0.66 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToULongNullable | .NET Core 2.0 |  2.1168 ns | 0.0020 ns | 0.0017 ns |  2.1169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.8578 ns | 0.0048 ns | 0.0045 ns |  1.8565 ns |  0.88 |    0.00 |     - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  2.1153 ns | 0.0025 ns | 0.0023 ns |  2.1156 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToULongNullable |        net461 |  1.9214 ns | 0.0245 ns | 0.0230 ns |  1.9238 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    ToULongNullable |        net472 |  1.8597 ns | 0.0026 ns | 0.0025 ns |  1.8601 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
            ToFloat | .NET Core 2.0 |  1.4300 ns | 0.0069 ns | 0.0064 ns |  1.4312 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1616 ns | 0.0130 ns | 0.0109 ns |  1.1659 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  1.7698 ns | 0.0080 ns | 0.0074 ns |  1.7714 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            ToFloat |        net461 |  0.9903 ns | 0.0032 ns | 0.0027 ns |  0.9909 ns |  0.69 |    0.00 |     - |     - |     - |         - |
            ToFloat |        net472 |  0.9997 ns | 0.0033 ns | 0.0031 ns |  0.9993 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.2316 ns | 0.0053 ns | 0.0047 ns |  4.2320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.3551 ns | 0.0042 ns | 0.0037 ns |  4.3545 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.2594 ns | 0.0060 ns | 0.0056 ns |  4.2596 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.6435 ns | 0.0074 ns | 0.0062 ns |  4.6440 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.6154 ns | 0.0053 ns | 0.0047 ns |  4.6139 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToDouble | .NET Core 2.0 |  1.6586 ns | 0.0022 ns | 0.0019 ns |  1.6587 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.2085 ns | 0.0031 ns | 0.0027 ns |  1.2088 ns |  0.73 |    0.00 |     - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  1.4154 ns | 0.0032 ns | 0.0028 ns |  1.4154 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net461 |  0.9913 ns | 0.0032 ns | 0.0030 ns |  0.9916 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           ToDouble |        net472 |  0.9857 ns | 0.0045 ns | 0.0042 ns |  0.9848 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  2.1155 ns | 0.0069 ns | 0.0065 ns |  2.1145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.8605 ns | 0.0038 ns | 0.0035 ns |  1.8603 ns |  0.88 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  2.1082 ns | 0.0045 ns | 0.0042 ns |  2.1071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net461 |  2.1190 ns | 0.0043 ns | 0.0038 ns |  2.1187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   ToDoubleNullable |        net472 |  2.0979 ns | 0.0088 ns | 0.0078 ns |  2.0954 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.1338 ns | 0.0155 ns | 0.0137 ns |  2.1367 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  1.8481 ns | 0.0055 ns | 0.0049 ns |  1.8483 ns |  0.87 |    0.01 |     - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.1331 ns | 0.0032 ns | 0.0030 ns |  2.1326 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          ToDecimal |        net461 |  6.2799 ns | 0.0063 ns | 0.0059 ns |  6.2817 ns |  2.94 |    0.02 |     - |     - |     - |         - |
          ToDecimal |        net472 |  6.0456 ns | 0.0250 ns | 0.0234 ns |  6.0405 ns |  2.83 |    0.02 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
  ToDecimalNullable | .NET Core 2.0 | 11.6376 ns | 0.0142 ns | 0.0126 ns | 11.6354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 | 10.7151 ns | 0.0479 ns | 0.0424 ns | 10.7216 ns |  0.92 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  2.8040 ns | 0.0047 ns | 0.0042 ns |  2.8042 ns |  0.24 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net461 | 10.6783 ns | 0.0162 ns | 0.0144 ns | 10.6759 ns |  0.92 |    0.00 |     - |     - |     - |         - |
  ToDecimalNullable |        net472 | 10.6456 ns | 0.0104 ns | 0.0092 ns | 10.6436 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3365 ns | 0.0058 ns | 0.0052 ns |  2.3354 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.0618 ns | 0.0047 ns | 0.0044 ns |  2.0620 ns |  0.88 |    0.00 |     - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  2.3340 ns | 0.0051 ns | 0.0046 ns |  2.3327 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net461 |  1.1822 ns | 0.0051 ns | 0.0048 ns |  1.1810 ns |  0.51 |    0.00 |     - |     - |     - |         - |
         ToDateTime |        net472 |  0.9892 ns | 0.0020 ns | 0.0019 ns |  0.9894 ns |  0.42 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.1536 ns | 0.0138 ns | 0.0122 ns |  8.1512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.4238 ns | 0.0212 ns | 0.0199 ns |  8.4174 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9354 ns | 0.0130 ns | 0.0122 ns |  1.9314 ns |  0.24 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net461 |  8.1982 ns | 0.0116 ns | 0.0109 ns |  8.1992 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.1267 ns | 0.0191 ns | 0.0179 ns |  8.1229 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
           ToObject | .NET Core 2.0 |  1.2414 ns | 0.0039 ns | 0.0034 ns |  1.2411 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 2.2 |  1.1998 ns | 0.0033 ns | 0.0029 ns |  1.1995 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           ToObject | .NET Core 3.0 |  1.2818 ns | 0.0040 ns | 0.0037 ns |  1.2815 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           ToObject |        net461 |  0.9593 ns | 0.0047 ns | 0.0044 ns |  0.9582 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           ToObject |        net472 |  0.9530 ns | 0.0028 ns | 0.0026 ns |  0.9530 ns |  0.77 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
          To_String | .NET Core 2.0 |  1.4132 ns | 0.0046 ns | 0.0040 ns |  1.4138 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 2.2 |  1.3309 ns | 0.0027 ns | 0.0024 ns |  1.3305 ns |  0.94 |    0.00 |     - |     - |     - |         - |
          To_String | .NET Core 3.0 |  1.4576 ns | 0.0096 ns | 0.0085 ns |  1.4586 ns |  1.03 |    0.01 |     - |     - |     - |         - |
          To_String |        net461 |  1.3244 ns | 0.0138 ns | 0.0123 ns |  1.3287 ns |  0.94 |    0.01 |     - |     - |     - |         - |
          To_String |        net472 |  1.2925 ns | 0.0024 ns | 0.0023 ns |  1.2925 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
             ToEnum | .NET Core 2.0 |  1.7648 ns | 0.0041 ns | 0.0034 ns |  1.7631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 2.2 |  1.3222 ns | 0.0039 ns | 0.0035 ns |  1.3223 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  1.6396 ns | 0.0043 ns | 0.0039 ns |  1.6396 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net461 |  1.2444 ns | 0.0029 ns | 0.0027 ns |  1.2446 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             ToEnum |        net472 |  1.2375 ns | 0.0025 ns | 0.0021 ns |  1.2369 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                    |               |            |           |           |            |       |         |       |       |       |           |
     ToEnumNullable | .NET Core 2.0 |  4.2291 ns | 0.0099 ns | 0.0078 ns |  4.2286 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 |  4.3504 ns | 0.0089 ns | 0.0079 ns |  4.3512 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 |  4.0063 ns | 0.0041 ns | 0.0036 ns |  4.0068 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net461 |  4.6451 ns | 0.0077 ns | 0.0069 ns |  4.6458 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     ToEnumNullable |        net472 |  4.6683 ns | 0.0233 ns | 0.0206 ns |  4.6699 ns |  1.10 |    0.01 |     - |     - |     - |         - |
