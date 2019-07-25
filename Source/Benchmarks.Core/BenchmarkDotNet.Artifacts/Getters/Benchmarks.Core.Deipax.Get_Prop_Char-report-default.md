
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
             ToBool | .NET Core 2.0 |  0.9575 ns | 0.0070 ns | 0.0062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToBool | .NET Core 2.2 |  0.9672 ns | 0.0057 ns | 0.0051 ns |  1.01 |    0.01 |      - |     - |     - |         - |
             ToBool | .NET Core 3.0 |  0.9444 ns | 0.0055 ns | 0.0051 ns |  0.99 |    0.01 |      - |     - |     - |         - |
             ToBool |        net461 |  0.4441 ns | 0.0067 ns | 0.0063 ns |  0.46 |    0.01 |      - |     - |     - |         - |
             ToBool |        net472 |  0.7357 ns | 0.0036 ns | 0.0034 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToBoolNullable | .NET Core 2.0 |  4.0420 ns | 0.0108 ns | 0.0096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 2.2 |  4.2332 ns | 0.0293 ns | 0.0274 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToBoolNullable | .NET Core 3.0 |  4.0204 ns | 0.0093 ns | 0.0082 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net461 |  4.2618 ns | 0.0078 ns | 0.0073 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToBoolNullable |        net472 |  4.2644 ns | 0.0128 ns | 0.0120 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToChar | .NET Core 2.0 |  0.9402 ns | 0.0170 ns | 0.0159 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToChar | .NET Core 2.2 |  1.2479 ns | 0.0524 ns | 0.0643 ns |  1.31 |    0.08 |      - |     - |     - |         - |
             ToChar | .NET Core 3.0 |  0.9421 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.02 |      - |     - |     - |         - |
             ToChar |        net461 |  0.4394 ns | 0.0035 ns | 0.0033 ns |  0.47 |    0.01 |      - |     - |     - |         - |
             ToChar |        net472 |  0.7408 ns | 0.0107 ns | 0.0089 ns |  0.79 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToCharNullable | .NET Core 2.0 |  4.0481 ns | 0.0084 ns | 0.0075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 2.2 |  4.4540 ns | 0.0101 ns | 0.0090 ns |  1.10 |    0.00 |      - |     - |     - |         - |
     ToCharNullable | .NET Core 3.0 |  4.2525 ns | 0.0084 ns | 0.0079 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net461 |  4.2258 ns | 0.0096 ns | 0.0090 ns |  1.04 |    0.00 |      - |     - |     - |         - |
     ToCharNullable |        net472 |  4.2383 ns | 0.0125 ns | 0.0111 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToSByte | .NET Core 2.0 |  1.2183 ns | 0.0136 ns | 0.0127 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToSByte | .NET Core 2.2 |  1.2669 ns | 0.0095 ns | 0.0089 ns |  1.04 |    0.01 |      - |     - |     - |         - |
            ToSByte | .NET Core 3.0 |  1.0079 ns | 0.0045 ns | 0.0040 ns |  0.83 |    0.01 |      - |     - |     - |         - |
            ToSByte |        net461 |  1.6105 ns | 0.0050 ns | 0.0039 ns |  1.32 |    0.02 |      - |     - |     - |         - |
            ToSByte |        net472 |  2.0066 ns | 0.0101 ns | 0.0089 ns |  1.65 |    0.02 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToSByteNullable | .NET Core 2.0 |  4.0451 ns | 0.0097 ns | 0.0091 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 2.2 |  4.2261 ns | 0.0259 ns | 0.0230 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToSByteNullable | .NET Core 3.0 |  4.0202 ns | 0.0064 ns | 0.0054 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net461 |  4.9690 ns | 0.0114 ns | 0.0101 ns |  1.23 |    0.00 |      - |     - |     - |         - |
    ToSByteNullable |        net472 |  4.9602 ns | 0.0219 ns | 0.0205 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToByte | .NET Core 2.0 |  1.4231 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToByte | .NET Core 2.2 |  1.2710 ns | 0.0146 ns | 0.0137 ns |  0.89 |    0.01 |      - |     - |     - |         - |
             ToByte | .NET Core 3.0 |  1.1824 ns | 0.0073 ns | 0.0068 ns |  0.83 |    0.01 |      - |     - |     - |         - |
             ToByte |        net461 |  1.6271 ns | 0.0081 ns | 0.0076 ns |  1.14 |    0.01 |      - |     - |     - |         - |
             ToByte |        net472 |  1.8886 ns | 0.0054 ns | 0.0045 ns |  1.33 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToByteNullable | .NET Core 2.0 |  4.0333 ns | 0.0068 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 2.2 |  4.2188 ns | 0.0063 ns | 0.0059 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToByteNullable | .NET Core 3.0 |  4.0215 ns | 0.0133 ns | 0.0118 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net461 |  4.9240 ns | 0.0095 ns | 0.0085 ns |  1.22 |    0.00 |      - |     - |     - |         - |
     ToByteNullable |        net472 |  4.9828 ns | 0.0162 ns | 0.0151 ns |  1.24 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToShort | .NET Core 2.0 |  1.2518 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 2.2 |  1.2389 ns | 0.0033 ns | 0.0029 ns |  0.99 |    0.00 |      - |     - |     - |         - |
            ToShort | .NET Core 3.0 |  1.1714 ns | 0.0077 ns | 0.0072 ns |  0.94 |    0.01 |      - |     - |     - |         - |
            ToShort |        net461 |  1.6066 ns | 0.0063 ns | 0.0053 ns |  1.28 |    0.01 |      - |     - |     - |         - |
            ToShort |        net472 |  1.9202 ns | 0.0177 ns | 0.0165 ns |  1.53 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToShortNullable | .NET Core 2.0 |  4.0477 ns | 0.0093 ns | 0.0087 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 2.2 |  4.2183 ns | 0.0081 ns | 0.0072 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToShortNullable | .NET Core 3.0 |  4.0119 ns | 0.0077 ns | 0.0068 ns |  0.99 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net461 |  4.9208 ns | 0.0097 ns | 0.0081 ns |  1.22 |    0.00 |      - |     - |     - |         - |
    ToShortNullable |        net472 |  4.9382 ns | 0.0075 ns | 0.0070 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToUShort | .NET Core 2.0 |  0.9466 ns | 0.0033 ns | 0.0027 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 2.2 |  0.9585 ns | 0.0039 ns | 0.0036 ns |  1.01 |    0.00 |      - |     - |     - |         - |
           ToUShort | .NET Core 3.0 |  0.9397 ns | 0.0049 ns | 0.0046 ns |  0.99 |    0.01 |      - |     - |     - |         - |
           ToUShort |        net461 |  0.4477 ns | 0.0033 ns | 0.0031 ns |  0.47 |    0.00 |      - |     - |     - |         - |
           ToUShort |        net472 |  0.7397 ns | 0.0049 ns | 0.0046 ns |  0.78 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToUShortNullable | .NET Core 2.0 |  4.0393 ns | 0.0170 ns | 0.0142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 2.2 |  4.2209 ns | 0.0070 ns | 0.0062 ns |  1.05 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable | .NET Core 3.0 |  4.0187 ns | 0.0061 ns | 0.0051 ns |  0.99 |    0.00 |      - |     - |     - |         - |
   ToUShortNullable |        net461 |  4.2486 ns | 0.0326 ns | 0.0305 ns |  1.05 |    0.01 |      - |     - |     - |         - |
   ToUShortNullable |        net472 |  4.2342 ns | 0.0082 ns | 0.0073 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
              ToInt | .NET Core 2.0 |  0.9281 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              ToInt | .NET Core 2.2 |  1.3536 ns | 0.0093 ns | 0.0082 ns |  1.46 |    0.01 |      - |     - |     - |         - |
              ToInt | .NET Core 3.0 |  0.9606 ns | 0.0083 ns | 0.0078 ns |  1.04 |    0.01 |      - |     - |     - |         - |
              ToInt |        net461 |  0.4532 ns | 0.0039 ns | 0.0036 ns |  0.49 |    0.01 |      - |     - |     - |         - |
              ToInt |        net472 |  0.7157 ns | 0.0057 ns | 0.0050 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
      ToIntNullable | .NET Core 2.0 |  4.0766 ns | 0.0123 ns | 0.0109 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 2.2 |  4.2207 ns | 0.0075 ns | 0.0066 ns |  1.04 |    0.00 |      - |     - |     - |         - |
      ToIntNullable | .NET Core 3.0 |  4.0290 ns | 0.0344 ns | 0.0322 ns |  0.99 |    0.01 |      - |     - |     - |         - |
      ToIntNullable |        net461 |  4.2188 ns | 0.0083 ns | 0.0078 ns |  1.03 |    0.00 |      - |     - |     - |         - |
      ToIntNullable |        net472 |  4.2339 ns | 0.0083 ns | 0.0074 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToUInt | .NET Core 2.0 |  0.9652 ns | 0.0040 ns | 0.0038 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToUInt | .NET Core 2.2 |  0.9690 ns | 0.0062 ns | 0.0052 ns |  1.00 |    0.01 |      - |     - |     - |         - |
             ToUInt | .NET Core 3.0 |  0.9424 ns | 0.0052 ns | 0.0046 ns |  0.98 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net461 |  0.4438 ns | 0.0063 ns | 0.0059 ns |  0.46 |    0.01 |      - |     - |     - |         - |
             ToUInt |        net472 |  0.7142 ns | 0.0028 ns | 0.0023 ns |  0.74 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToUIntNullable | .NET Core 2.0 |  4.0508 ns | 0.0103 ns | 0.0096 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 2.2 |  4.2642 ns | 0.0168 ns | 0.0157 ns |  1.05 |    0.00 |      - |     - |     - |         - |
     ToUIntNullable | .NET Core 3.0 |  4.0337 ns | 0.0320 ns | 0.0299 ns |  1.00 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net461 |  4.2499 ns | 0.0351 ns | 0.0329 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToUIntNullable |        net472 |  4.2744 ns | 0.0162 ns | 0.0151 ns |  1.06 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
             ToLong | .NET Core 2.0 |  0.9638 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 2.2 |  0.9710 ns | 0.0024 ns | 0.0021 ns |  1.01 |    0.00 |      - |     - |     - |         - |
             ToLong | .NET Core 3.0 |  1.5039 ns | 0.0139 ns | 0.0123 ns |  1.56 |    0.01 |      - |     - |     - |         - |
             ToLong |        net461 |  0.4416 ns | 0.0026 ns | 0.0023 ns |  0.46 |    0.00 |      - |     - |     - |         - |
             ToLong |        net472 |  0.8915 ns | 0.0440 ns | 0.0556 ns |  0.93 |    0.06 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToLongNullable | .NET Core 2.0 |  1.6864 ns | 0.0152 ns | 0.0142 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 2.2 |  1.6428 ns | 0.0225 ns | 0.0211 ns |  0.97 |    0.01 |      - |     - |     - |         - |
     ToLongNullable | .NET Core 3.0 |  1.4588 ns | 0.0048 ns | 0.0042 ns |  0.87 |    0.01 |      - |     - |     - |         - |
     ToLongNullable |        net461 |  1.9010 ns | 0.0216 ns | 0.0202 ns |  1.13 |    0.02 |      - |     - |     - |         - |
     ToLongNullable |        net472 |  2.0670 ns | 0.0132 ns | 0.0124 ns |  1.23 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToULong | .NET Core 2.0 |  0.9606 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 2.2 |  0.9732 ns | 0.0041 ns | 0.0036 ns |  1.01 |    0.00 |      - |     - |     - |         - |
            ToULong | .NET Core 3.0 |  0.9527 ns | 0.0099 ns | 0.0088 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToULong |        net461 |  0.4396 ns | 0.0016 ns | 0.0013 ns |  0.46 |    0.00 |      - |     - |     - |         - |
            ToULong |        net472 |  0.7403 ns | 0.0040 ns | 0.0038 ns |  0.77 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToULongNullable | .NET Core 2.0 |  1.6654 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 2.2 |  1.6800 ns | 0.0029 ns | 0.0025 ns |  1.01 |    0.00 |      - |     - |     - |         - |
    ToULongNullable | .NET Core 3.0 |  1.7729 ns | 0.0076 ns | 0.0068 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    ToULongNullable |        net461 |  1.6377 ns | 0.0173 ns | 0.0162 ns |  0.98 |    0.01 |      - |     - |     - |         - |
    ToULongNullable |        net472 |  1.7931 ns | 0.0234 ns | 0.0219 ns |  1.08 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
            ToFloat | .NET Core 2.0 |  1.2001 ns | 0.0157 ns | 0.0146 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            ToFloat | .NET Core 2.2 |  1.1897 ns | 0.0033 ns | 0.0031 ns |  0.99 |    0.01 |      - |     - |     - |         - |
            ToFloat | .NET Core 3.0 |  0.9646 ns | 0.0045 ns | 0.0037 ns |  0.80 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net461 |  0.4423 ns | 0.0029 ns | 0.0027 ns |  0.37 |    0.01 |      - |     - |     - |         - |
            ToFloat |        net472 |  0.7227 ns | 0.0047 ns | 0.0044 ns |  0.60 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
    ToFloatNullable | .NET Core 2.0 |  4.3189 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 2.2 |  4.4916 ns | 0.0486 ns | 0.0454 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    ToFloatNullable | .NET Core 3.0 |  4.0132 ns | 0.0092 ns | 0.0081 ns |  0.93 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net461 |  4.5074 ns | 0.0164 ns | 0.0153 ns |  1.04 |    0.00 |      - |     - |     - |         - |
    ToFloatNullable |        net472 |  4.4742 ns | 0.0107 ns | 0.0090 ns |  1.04 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToDouble | .NET Core 2.0 |  1.1944 ns | 0.0056 ns | 0.0046 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           ToDouble | .NET Core 2.2 |  1.1846 ns | 0.0041 ns | 0.0039 ns |  0.99 |    0.01 |      - |     - |     - |         - |
           ToDouble | .NET Core 3.0 |  0.9752 ns | 0.0285 ns | 0.0252 ns |  0.82 |    0.02 |      - |     - |     - |         - |
           ToDouble |        net461 |  0.4399 ns | 0.0026 ns | 0.0020 ns |  0.37 |    0.00 |      - |     - |     - |         - |
           ToDouble |        net472 |  0.7203 ns | 0.0043 ns | 0.0040 ns |  0.60 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
   ToDoubleNullable | .NET Core 2.0 |  1.6636 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 2.2 |  1.6190 ns | 0.0056 ns | 0.0044 ns |  0.97 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable | .NET Core 3.0 |  1.5511 ns | 0.0078 ns | 0.0073 ns |  0.93 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net461 |  1.6837 ns | 0.0051 ns | 0.0043 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   ToDoubleNullable |        net472 |  1.7018 ns | 0.0052 ns | 0.0048 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
          ToDecimal | .NET Core 2.0 |  2.8233 ns | 0.0097 ns | 0.0075 ns |  1.00 |    0.00 |      - |     - |     - |         - |
          ToDecimal | .NET Core 2.2 |  3.6329 ns | 0.0190 ns | 0.0178 ns |  1.29 |    0.01 |      - |     - |     - |         - |
          ToDecimal | .NET Core 3.0 |  2.8290 ns | 0.0829 ns | 0.1077 ns |  0.99 |    0.05 |      - |     - |     - |         - |
          ToDecimal |        net461 |  5.8640 ns | 0.0215 ns | 0.0191 ns |  2.08 |    0.01 |      - |     - |     - |         - |
          ToDecimal |        net472 |  6.1180 ns | 0.0141 ns | 0.0132 ns |  2.17 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
  ToDecimalNullable | .NET Core 2.0 |  1.6637 ns | 0.0074 ns | 0.0069 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 2.2 |  1.6595 ns | 0.0098 ns | 0.0092 ns |  1.00 |    0.01 |      - |     - |     - |         - |
  ToDecimalNullable | .NET Core 3.0 |  1.7878 ns | 0.0041 ns | 0.0038 ns |  1.07 |    0.00 |      - |     - |     - |         - |
  ToDecimalNullable |        net461 |  2.1256 ns | 0.0442 ns | 0.0414 ns |  1.28 |    0.03 |      - |     - |     - |         - |
  ToDecimalNullable |        net472 |  1.7803 ns | 0.0049 ns | 0.0041 ns |  1.07 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
         ToDateTime | .NET Core 2.0 |  2.3607 ns | 0.0049 ns | 0.0041 ns |  1.00 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 2.2 |  2.1875 ns | 0.0079 ns | 0.0074 ns |  0.93 |    0.00 |      - |     - |     - |         - |
         ToDateTime | .NET Core 3.0 |  1.9600 ns | 0.0225 ns | 0.0210 ns |  0.83 |    0.01 |      - |     - |     - |         - |
         ToDateTime |        net461 |  1.2098 ns | 0.0041 ns | 0.0036 ns |  0.51 |    0.00 |      - |     - |     - |         - |
         ToDateTime |        net472 |  1.1936 ns | 0.0075 ns | 0.0070 ns |  0.51 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
 ToDateTimeNullable | .NET Core 2.0 |  8.3531 ns | 0.0499 ns | 0.0443 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 2.2 |  8.3050 ns | 0.0239 ns | 0.0212 ns |  0.99 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable | .NET Core 3.0 |  1.9261 ns | 0.0047 ns | 0.0042 ns |  0.23 |    0.00 |      - |     - |     - |         - |
 ToDateTimeNullable |        net461 | 12.3688 ns | 0.0130 ns | 0.0115 ns |  1.48 |    0.01 |      - |     - |     - |         - |
 ToDateTimeNullable |        net472 |  8.4460 ns | 0.0150 ns | 0.0133 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
           ToObject | .NET Core 2.0 |  3.1801 ns | 0.0200 ns | 0.0187 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 2.2 |  3.9943 ns | 0.0234 ns | 0.0207 ns |  1.26 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject | .NET Core 3.0 |  3.7762 ns | 0.0321 ns | 0.0268 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net461 |  2.6190 ns | 0.0225 ns | 0.0199 ns |  0.82 |    0.01 | 0.0038 |     - |     - |      24 B |
           ToObject |        net472 |  2.7003 ns | 0.0105 ns | 0.0088 ns |  0.85 |    0.01 | 0.0038 |     - |     - |      24 B |
                    |               |            |           |           |       |         |        |       |       |           |
          To_String | .NET Core 2.0 |  4.2309 ns | 0.0112 ns | 0.0093 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 2.2 |  4.5240 ns | 0.0474 ns | 0.0443 ns |  1.07 |    0.01 | 0.0051 |     - |     - |      32 B |
          To_String | .NET Core 3.0 |  4.0898 ns | 0.0235 ns | 0.0220 ns |  0.97 |    0.01 | 0.0038 |     - |     - |      24 B |
          To_String |        net461 |  5.2156 ns | 0.0219 ns | 0.0204 ns |  1.23 |    0.00 | 0.0051 |     - |     - |      32 B |
          To_String |        net472 |  5.4843 ns | 0.0439 ns | 0.0410 ns |  1.30 |    0.01 | 0.0051 |     - |     - |      32 B |
                    |               |            |           |           |       |         |        |       |       |           |
             ToEnum | .NET Core 2.0 | 10.1442 ns | 0.0182 ns | 0.0170 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 2.2 | 10.3587 ns | 0.0178 ns | 0.0139 ns |  1.02 |    0.00 |      - |     - |     - |         - |
             ToEnum | .NET Core 3.0 |  8.4205 ns | 0.0152 ns | 0.0142 ns |  0.83 |    0.00 |      - |     - |     - |         - |
             ToEnum |        net461 | 12.3134 ns | 0.0871 ns | 0.0815 ns |  1.21 |    0.01 |      - |     - |     - |         - |
             ToEnum |        net472 | 12.3486 ns | 0.0294 ns | 0.0275 ns |  1.22 |    0.00 |      - |     - |     - |         - |
                    |               |            |           |           |       |         |        |       |       |           |
     ToEnumNullable | .NET Core 2.0 | 14.5511 ns | 0.0295 ns | 0.0246 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 2.2 | 15.3372 ns | 0.0762 ns | 0.0675 ns |  1.05 |    0.01 |      - |     - |     - |         - |
     ToEnumNullable | .NET Core 3.0 | 12.8859 ns | 0.0235 ns | 0.0196 ns |  0.89 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net461 | 16.9511 ns | 0.0265 ns | 0.0248 ns |  1.16 |    0.00 |      - |     - |     - |         - |
     ToEnumNullable |        net472 | 17.0575 ns | 0.0525 ns | 0.0465 ns |  1.17 |    0.00 |      - |     - |     - |         - |
