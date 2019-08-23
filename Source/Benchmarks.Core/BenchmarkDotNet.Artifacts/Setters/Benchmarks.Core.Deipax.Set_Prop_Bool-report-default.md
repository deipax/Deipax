
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FAIBOE : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-HDWVEN : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-QWBUFU : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-UUEYQZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-TUNFLE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.4260 ns | 0.0137 ns | 0.0122 ns |  0.4243 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.4490 ns | 0.0035 ns | 0.0031 ns |  0.4488 ns |  1.05 |    0.03 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.5300 ns | 0.0359 ns | 0.0384 ns |  0.5245 ns |  1.25 |    0.11 |     - |     - |     - |         - |
             FromBool |        net461 |  0.4410 ns | 0.0017 ns | 0.0015 ns |  0.4407 ns |  1.04 |    0.03 |     - |     - |     - |         - |
             FromBool |        net472 |  0.7140 ns | 0.0066 ns | 0.0058 ns |  0.7116 ns |  1.68 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9407 ns | 0.0177 ns | 0.0157 ns |  0.9355 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9266 ns | 0.0062 ns | 0.0055 ns |  0.9251 ns |  0.99 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1716 ns | 0.0055 ns | 0.0052 ns |  1.1705 ns |  1.25 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.2563 ns | 0.0150 ns | 0.0141 ns |  1.2488 ns |  1.34 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.2604 ns | 0.0080 ns | 0.0075 ns |  1.2600 ns |  1.34 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.5545 ns | 0.0135 ns | 0.0120 ns |  0.5536 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4596 ns | 0.0049 ns | 0.0043 ns |  0.4604 ns |  0.83 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6953 ns | 0.0043 ns | 0.0040 ns |  0.6945 ns |  1.25 |    0.03 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4379 ns | 0.0026 ns | 0.0023 ns |  0.4380 ns |  0.79 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7314 ns | 0.0027 ns | 0.0023 ns |  0.7313 ns |  1.32 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.4491 ns | 0.0209 ns | 0.0185 ns |  0.4579 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.7169 ns | 0.0177 ns | 0.0157 ns |  0.7116 ns |  1.60 |    0.08 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9418 ns | 0.0197 ns | 0.0174 ns |  0.9402 ns |  2.10 |    0.09 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.6989 ns | 0.0040 ns | 0.0035 ns |  0.6980 ns |  1.56 |    0.07 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9659 ns | 0.0099 ns | 0.0092 ns |  0.9691 ns |  2.15 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.4507 ns | 0.0052 ns | 0.0044 ns |  0.4500 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.4438 ns | 0.0079 ns | 0.0070 ns |  0.4446 ns |  0.99 |    0.02 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6967 ns | 0.0025 ns | 0.0019 ns |  0.6961 ns |  1.54 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.4409 ns | 0.0059 ns | 0.0052 ns |  0.4404 ns |  0.98 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7179 ns | 0.0064 ns | 0.0060 ns |  0.7178 ns |  1.60 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.8970 ns | 0.0066 ns | 0.0058 ns |  0.8970 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9281 ns | 0.0084 ns | 0.0065 ns |  0.9274 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9601 ns | 0.0076 ns | 0.0071 ns |  0.9586 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.6897 ns | 0.0130 ns | 0.0121 ns |  1.6849 ns |  1.88 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.6872 ns | 0.0052 ns | 0.0046 ns |  1.6873 ns |  1.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6628 ns | 0.0108 ns | 0.0084 ns |  0.6654 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4667 ns | 0.0123 ns | 0.0115 ns |  0.4665 ns |  0.70 |    0.02 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4984 ns | 0.0028 ns | 0.0025 ns |  0.4971 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4374 ns | 0.0073 ns | 0.0068 ns |  0.4352 ns |  0.66 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7193 ns | 0.0040 ns | 0.0035 ns |  0.7187 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.8986 ns | 0.0071 ns | 0.0055 ns |  0.8966 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9182 ns | 0.0127 ns | 0.0118 ns |  0.9121 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9746 ns | 0.0098 ns | 0.0091 ns |  0.9707 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6753 ns | 0.0058 ns | 0.0048 ns |  1.6749 ns |  1.86 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6862 ns | 0.0053 ns | 0.0047 ns |  1.6856 ns |  1.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.4332 ns | 0.0107 ns | 0.0095 ns |  0.4313 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7939 ns | 0.0045 ns | 0.0042 ns |  0.7942 ns |  1.83 |    0.04 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.9425 ns | 0.0108 ns | 0.0090 ns |  0.9433 ns |  2.18 |    0.05 |     - |     - |     - |         - |
            FromShort |        net461 |  0.4520 ns | 0.0090 ns | 0.0084 ns |  0.4490 ns |  1.04 |    0.03 |     - |     - |     - |         - |
            FromShort |        net472 |  0.7131 ns | 0.0044 ns | 0.0042 ns |  0.7138 ns |  1.65 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  3.3173 ns | 0.0076 ns | 0.0067 ns |  3.3152 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  0.9090 ns | 0.0030 ns | 0.0025 ns |  0.9092 ns |  0.27 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1758 ns | 0.0075 ns | 0.0066 ns |  1.1747 ns |  0.35 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.6746 ns | 0.0097 ns | 0.0090 ns |  1.6729 ns |  0.51 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.6835 ns | 0.0089 ns | 0.0074 ns |  1.6812 ns |  0.51 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6828 ns | 0.0043 ns | 0.0038 ns |  0.6815 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6935 ns | 0.0064 ns | 0.0060 ns |  0.6928 ns |  1.02 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5027 ns | 0.0209 ns | 0.0195 ns |  0.5013 ns |  0.74 |    0.03 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6826 ns | 0.0055 ns | 0.0046 ns |  0.6824 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.9651 ns | 0.0093 ns | 0.0083 ns |  0.9620 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9269 ns | 0.0099 ns | 0.0088 ns |  0.9233 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.8376 ns | 0.0065 ns | 0.0061 ns |  0.8360 ns |  0.90 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9597 ns | 0.0053 ns | 0.0049 ns |  0.9599 ns |  1.04 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6676 ns | 0.0052 ns | 0.0043 ns |  1.6665 ns |  1.80 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6810 ns | 0.0043 ns | 0.0041 ns |  1.6795 ns |  1.81 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7042 ns | 0.0124 ns | 0.0116 ns |  0.7051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.4632 ns | 0.0297 ns | 0.0277 ns |  0.4481 ns |  0.66 |    0.04 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6933 ns | 0.0037 ns | 0.0033 ns |  0.6932 ns |  0.99 |    0.02 |     - |     - |     - |         - |
              FromInt |        net461 |  0.4688 ns | 0.0086 ns | 0.0077 ns |  0.4695 ns |  0.67 |    0.02 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7199 ns | 0.0031 ns | 0.0027 ns |  0.7197 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.9361 ns | 0.0062 ns | 0.0055 ns |  0.9344 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.9197 ns | 0.0151 ns | 0.0142 ns |  0.9188 ns |  0.98 |    0.02 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.9745 ns | 0.0156 ns | 0.0122 ns |  0.9801 ns |  1.04 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.6521 ns | 0.0052 ns | 0.0049 ns |  1.6520 ns |  1.76 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.6739 ns | 0.0096 ns | 0.0090 ns |  1.6741 ns |  1.79 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9286 ns | 0.0127 ns | 0.0113 ns |  0.9249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6911 ns | 0.0177 ns | 0.0166 ns |  0.6830 ns |  0.75 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6729 ns | 0.0023 ns | 0.0020 ns |  0.6730 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7233 ns | 0.0023 ns | 0.0021 ns |  0.7227 ns |  0.78 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.6716 ns | 0.0137 ns | 0.0128 ns |  0.6658 ns |  0.72 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1810 ns | 0.0144 ns | 0.0135 ns |  1.1745 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.9119 ns | 0.0067 ns | 0.0056 ns |  0.9114 ns |  0.77 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1715 ns | 0.0083 ns | 0.0070 ns |  1.1714 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.5399 ns | 0.0196 ns | 0.0183 ns |  1.5443 ns |  1.30 |    0.03 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6644 ns | 0.0029 ns | 0.0027 ns |  1.6640 ns |  1.41 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6991 ns | 0.0017 ns | 0.0015 ns |  0.6985 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.4496 ns | 0.0097 ns | 0.0081 ns |  0.4458 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.9373 ns | 0.0130 ns | 0.0108 ns |  0.9413 ns |  1.34 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7080 ns | 0.0037 ns | 0.0034 ns |  0.7071 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6676 ns | 0.0041 ns | 0.0037 ns |  0.6665 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.5009 ns | 0.0254 ns | 0.0225 ns |  1.5054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.4754 ns | 0.0074 ns | 0.0069 ns |  1.4750 ns |  0.98 |    0.02 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.5762 ns | 0.0173 ns | 0.0162 ns |  1.5667 ns |  1.05 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.9173 ns | 0.0272 ns | 0.0254 ns |  1.8994 ns |  1.28 |    0.02 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.9748 ns | 0.0063 ns | 0.0059 ns |  1.9742 ns |  1.32 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9362 ns | 0.0066 ns | 0.0051 ns |  0.9366 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.4496 ns | 0.0021 ns | 0.0020 ns |  0.4496 ns |  0.48 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.6576 ns | 0.0053 ns | 0.0050 ns |  0.6573 ns |  0.70 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.7140 ns | 0.0037 ns | 0.0033 ns |  0.7139 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.6640 ns | 0.0026 ns | 0.0023 ns |  0.6638 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.7207 ns | 0.0029 ns | 0.0026 ns |  1.7200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7478 ns | 0.0251 ns | 0.0235 ns |  1.7389 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4707 ns | 0.0109 ns | 0.0096 ns |  1.4668 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.0072 ns | 0.0082 ns | 0.0068 ns |  2.0089 ns |  1.17 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9650 ns | 0.0104 ns | 0.0097 ns |  1.9618 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.7440 ns | 0.0084 ns | 0.0079 ns |  0.7425 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.6945 ns | 0.0048 ns | 0.0040 ns |  0.6938 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.6644 ns | 0.0123 ns | 0.0109 ns |  0.6604 ns |  0.89 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.7531 ns | 0.0110 ns | 0.0098 ns |  0.7552 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.6919 ns | 0.0050 ns | 0.0045 ns |  0.6924 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.1797 ns | 0.0142 ns | 0.0118 ns |  1.1793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9417 ns | 0.0066 ns | 0.0061 ns |  0.9407 ns |  0.80 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.1559 ns | 0.0045 ns | 0.0042 ns |  1.1560 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.8733 ns | 0.0069 ns | 0.0065 ns |  1.8728 ns |  1.59 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.7551 ns | 0.0076 ns | 0.0071 ns |  1.7555 ns |  1.49 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.9193 ns | 0.0534 ns | 0.0473 ns |  0.9006 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.7215 ns | 0.0151 ns | 0.0126 ns |  0.7274 ns |  0.79 |    0.04 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.6974 ns | 0.0067 ns | 0.0056 ns |  0.6971 ns |  0.77 |    0.03 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.7282 ns | 0.0031 ns | 0.0024 ns |  0.7286 ns |  0.81 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.7124 ns | 0.0128 ns | 0.0107 ns |  0.7168 ns |  0.78 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.7648 ns | 0.0157 ns | 0.0131 ns |  1.7646 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.6782 ns | 0.0105 ns | 0.0093 ns |  1.6761 ns |  0.95 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.7418 ns | 0.0065 ns | 0.0057 ns |  1.7402 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1357 ns | 0.0030 ns | 0.0027 ns |  2.1357 ns |  1.21 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1115 ns | 0.0077 ns | 0.0068 ns |  2.1110 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  7.6389 ns | 0.0788 ns | 0.0737 ns |  7.6689 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  7.6130 ns | 0.0533 ns | 0.0498 ns |  7.6157 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.3277 ns | 0.0206 ns | 0.0161 ns |  5.3246 ns |  0.70 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.3873 ns | 0.0429 ns | 0.0401 ns |  8.3694 ns |  1.10 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.7798 ns | 0.0150 ns | 0.0141 ns |  8.7801 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 17.1445 ns | 0.0572 ns | 0.0507 ns | 17.1296 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 17.4982 ns | 0.0913 ns | 0.0713 ns | 17.5220 ns |  1.02 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 10.9798 ns | 0.1340 ns | 0.1253 ns | 10.9652 ns |  0.64 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 17.9545 ns | 0.0475 ns | 0.0421 ns | 17.9394 ns |  1.05 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 18.0290 ns | 0.0673 ns | 0.0562 ns | 18.0393 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7042 ns | 0.0122 ns | 0.0102 ns |  0.7001 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.4511 ns | 0.0076 ns | 0.0071 ns |  0.4484 ns |  0.64 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7100 ns | 0.0215 ns | 0.0201 ns |  0.6981 ns |  1.01 |    0.04 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7039 ns | 0.0030 ns | 0.0028 ns |  0.7030 ns |  1.00 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6732 ns | 0.0158 ns | 0.0147 ns |  0.6674 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4630 ns | 0.0186 ns | 0.0165 ns |  1.4675 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4785 ns | 0.0071 ns | 0.0059 ns |  1.4783 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2313 ns | 0.0034 ns | 0.0032 ns |  1.2314 ns |  0.84 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4886 ns | 0.0086 ns | 0.0081 ns |  1.4864 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4992 ns | 0.0088 ns | 0.0078 ns |  1.4981 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2588 ns | 0.0082 ns | 0.0072 ns |  2.2571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2440 ns | 0.0072 ns | 0.0067 ns |  2.2429 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1466 ns | 0.0063 ns | 0.0059 ns |  2.1436 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2703 ns | 0.0054 ns | 0.0042 ns |  2.2696 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.2289 ns | 0.0073 ns | 0.0065 ns |  2.2262 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  8.2502 ns | 0.0283 ns | 0.0251 ns |  8.2524 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 20.1544 ns | 0.0907 ns | 0.0848 ns | 20.1688 ns |  2.44 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 13.9662 ns | 0.1453 ns | 0.1359 ns | 13.8810 ns |  1.69 |    0.02 |     - |     - |     - |         - |
           FromString |        net461 |  8.1731 ns | 0.0177 ns | 0.0166 ns |  8.1739 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  8.1818 ns | 0.0719 ns | 0.0673 ns |  8.1689 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9313 ns | 0.0038 ns | 0.0035 ns |  0.9315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.4687 ns | 0.0121 ns | 0.0101 ns |  0.4719 ns |  0.50 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6991 ns | 0.0043 ns | 0.0036 ns |  0.6994 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7309 ns | 0.0034 ns | 0.0031 ns |  0.7298 ns |  0.78 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6837 ns | 0.0033 ns | 0.0031 ns |  0.6834 ns |  0.73 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1632 ns | 0.0043 ns | 0.0038 ns |  1.1627 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  0.9064 ns | 0.0040 ns | 0.0033 ns |  0.9070 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1379 ns | 0.0073 ns | 0.0065 ns |  1.1364 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.6712 ns | 0.0050 ns | 0.0047 ns |  1.6698 ns |  1.44 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.6488 ns | 0.0097 ns | 0.0091 ns |  1.6501 ns |  1.42 |    0.01 |     - |     - |     - |         - |
