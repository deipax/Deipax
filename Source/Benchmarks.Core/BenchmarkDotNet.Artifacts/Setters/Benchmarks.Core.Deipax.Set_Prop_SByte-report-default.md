
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
             FromBool | .NET Core 2.0 |  0.9387 ns | 0.0136 ns | 0.0120 ns |  0.9426 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9086 ns | 0.0032 ns | 0.0028 ns |  0.9082 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1348 ns | 0.0049 ns | 0.0038 ns |  1.1344 ns |  1.21 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1888 ns | 0.0213 ns | 0.0189 ns |  1.1806 ns |  1.27 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 |  1.2168 ns | 0.0244 ns | 0.0228 ns |  1.2119 ns |  1.29 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3962 ns | 0.0052 ns | 0.0046 ns |  1.3952 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1426 ns | 0.0161 ns | 0.0151 ns |  1.1506 ns |  0.82 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9280 ns | 0.0034 ns | 0.0027 ns |  0.9270 ns |  0.66 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6983 ns | 0.0212 ns | 0.0188 ns |  1.6983 ns |  1.22 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6838 ns | 0.0215 ns | 0.0201 ns |  1.6759 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.1645 ns | 0.0034 ns | 0.0032 ns |  1.1649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.0835 ns | 0.0044 ns | 0.0039 ns |  1.0836 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.4712 ns | 0.0025 ns | 0.0024 ns |  0.4702 ns |  0.40 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.6864 ns | 0.0172 ns | 0.0152 ns |  1.6874 ns |  1.45 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  1.6960 ns | 0.0198 ns | 0.0185 ns |  1.6882 ns |  1.46 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.6608 ns | 0.0156 ns | 0.0146 ns |  1.6660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.6134 ns | 0.0050 ns | 0.0042 ns |  1.6139 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9574 ns | 0.0047 ns | 0.0036 ns |  0.9562 ns |  0.58 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.2202 ns | 0.0458 ns | 0.0428 ns |  2.2120 ns |  1.34 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.1990 ns | 0.0295 ns | 0.0261 ns |  2.2008 ns |  1.32 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6942 ns | 0.0039 ns | 0.0035 ns |  0.6940 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.4477 ns | 0.0109 ns | 0.0102 ns |  0.4534 ns |  0.65 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6496 ns | 0.0026 ns | 0.0023 ns |  0.6493 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.7376 ns | 0.0105 ns | 0.0098 ns |  0.7392 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7274 ns | 0.0125 ns | 0.0117 ns |  0.7268 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  0.9490 ns | 0.0039 ns | 0.0036 ns |  0.9499 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.7271 ns | 0.0033 ns | 0.0029 ns |  0.7276 ns |  0.77 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.4767 ns | 0.0048 ns | 0.0042 ns |  1.4754 ns |  1.56 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.4605 ns | 0.0244 ns | 0.0229 ns |  1.4533 ns |  1.54 |    0.03 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.4348 ns | 0.0154 ns | 0.0144 ns |  1.4374 ns |  1.51 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.1717 ns | 0.0144 ns | 0.0135 ns |  1.1763 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  1.0682 ns | 0.0037 ns | 0.0032 ns |  1.0679 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6783 ns | 0.0122 ns | 0.0114 ns |  0.6733 ns |  0.58 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  1.6896 ns | 0.0261 ns | 0.0244 ns |  1.6865 ns |  1.44 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  1.7106 ns | 0.0294 ns | 0.0275 ns |  1.7148 ns |  1.46 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.4849 ns | 0.0028 ns | 0.0023 ns |  1.4856 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.4574 ns | 0.0196 ns | 0.0183 ns |  1.4657 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1389 ns | 0.0032 ns | 0.0029 ns |  1.1384 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.2171 ns | 0.0264 ns | 0.0246 ns |  2.2083 ns |  1.49 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.2032 ns | 0.0160 ns | 0.0150 ns |  2.2045 ns |  1.48 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.9287 ns | 0.0212 ns | 0.0177 ns |  1.9357 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.9059 ns | 0.0022 ns | 0.0020 ns |  1.9063 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  2.1136 ns | 0.0031 ns | 0.0026 ns |  2.1146 ns |  1.10 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7115 ns | 0.0222 ns | 0.0207 ns |  1.7066 ns |  0.89 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  1.6996 ns | 0.0159 ns | 0.0141 ns |  1.7052 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.3287 ns | 0.0055 ns | 0.0052 ns |  2.3264 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.1060 ns | 0.0046 ns | 0.0041 ns |  2.1054 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.9141 ns | 0.0062 ns | 0.0049 ns |  1.9148 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.4183 ns | 0.0414 ns | 0.0387 ns |  2.4136 ns |  1.04 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.2739 ns | 0.0384 ns | 0.0359 ns |  2.2676 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1643 ns | 0.0043 ns | 0.0040 ns |  1.1645 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.0727 ns | 0.0042 ns | 0.0039 ns |  1.0728 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7210 ns | 0.0123 ns | 0.0102 ns |  0.7190 ns |  0.62 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.6733 ns | 0.0245 ns | 0.0217 ns |  1.6708 ns |  1.44 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.6897 ns | 0.0208 ns | 0.0195 ns |  1.6912 ns |  1.45 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.6571 ns | 0.0230 ns | 0.0192 ns |  1.6645 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.6142 ns | 0.0065 ns | 0.0061 ns |  1.6128 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9787 ns | 0.0205 ns | 0.0192 ns |  0.9711 ns |  0.59 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.1943 ns | 0.0254 ns | 0.0237 ns |  2.1899 ns |  1.32 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.1881 ns | 0.0183 ns | 0.0171 ns |  2.1945 ns |  1.32 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8454 ns | 0.0074 ns | 0.0058 ns |  1.8469 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.6494 ns | 0.0240 ns | 0.0224 ns |  1.6543 ns |  0.89 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.9124 ns | 0.0160 ns | 0.0133 ns |  1.9077 ns |  1.04 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7231 ns | 0.0242 ns | 0.0227 ns |  1.7211 ns |  0.93 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7052 ns | 0.0379 ns | 0.0354 ns |  1.6992 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.2176 ns | 0.0057 ns | 0.0053 ns |  2.2181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.0681 ns | 0.0037 ns | 0.0032 ns |  2.0679 ns |  0.93 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.9201 ns | 0.0226 ns | 0.0211 ns |  1.9159 ns |  0.87 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.2190 ns | 0.0235 ns | 0.0208 ns |  2.2196 ns |  1.00 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.2150 ns | 0.0194 ns | 0.0182 ns |  2.2246 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.2554 ns | 0.0095 ns | 0.0088 ns |  1.2573 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.6475 ns | 0.0157 ns | 0.0147 ns |  1.6412 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.5262 ns | 0.0131 ns | 0.0116 ns |  0.5263 ns |  0.42 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.6882 ns | 0.0185 ns | 0.0173 ns |  1.6906 ns |  1.34 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.6316 ns | 0.0204 ns | 0.0191 ns |  1.6247 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.3471 ns | 0.0052 ns | 0.0048 ns |  2.3473 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6522 ns | 0.0052 ns | 0.0046 ns |  1.6513 ns |  0.70 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9320 ns | 0.0058 ns | 0.0048 ns |  0.9320 ns |  0.40 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3738 ns | 0.0223 ns | 0.0198 ns |  2.3758 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.3884 ns | 0.0515 ns | 0.0482 ns |  2.3799 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  2.0797 ns | 0.0059 ns | 0.0052 ns |  2.0793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8728 ns | 0.0047 ns | 0.0044 ns |  1.8720 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.5535 ns | 0.0221 ns | 0.0196 ns |  1.5475 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6919 ns | 0.0139 ns | 0.0130 ns |  1.6938 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6322 ns | 0.0108 ns | 0.0090 ns |  1.6303 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.1983 ns | 0.0241 ns | 0.0225 ns |  3.2048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.9530 ns | 0.0097 ns | 0.0086 ns |  2.9554 ns |  0.92 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.9781 ns | 0.0243 ns | 0.0215 ns |  2.9756 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.0885 ns | 0.0394 ns | 0.0369 ns |  3.0913 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.9599 ns | 0.0077 ns | 0.0072 ns |  2.9607 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.2377 ns | 0.0030 ns | 0.0026 ns |  1.2380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.2017 ns | 0.0071 ns | 0.0059 ns |  1.2019 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.5836 ns | 0.0287 ns | 0.0269 ns |  0.5725 ns |  0.47 |    0.02 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7189 ns | 0.0338 ns | 0.0316 ns |  1.7154 ns |  1.39 |    0.03 |     - |     - |     - |         - |
            FromULong |        net472 |  1.6111 ns | 0.0199 ns | 0.0186 ns |  1.6224 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9767 ns | 0.0043 ns | 0.0038 ns |  1.9767 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9192 ns | 0.0046 ns | 0.0043 ns |  1.9204 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6966 ns | 0.0128 ns | 0.0120 ns |  1.6947 ns |  0.86 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1504 ns | 0.0270 ns | 0.0252 ns |  3.1470 ns |  1.59 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.9826 ns | 0.0047 ns | 0.0044 ns |  2.9812 ns |  1.51 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  4.0142 ns | 0.0482 ns | 0.0451 ns |  4.0282 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  4.0179 ns | 0.0057 ns | 0.0050 ns |  4.0178 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.0618 ns | 0.0550 ns | 0.0514 ns |  4.0534 ns |  1.01 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  4.0659 ns | 0.0669 ns | 0.0626 ns |  4.0589 ns |  1.01 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.9984 ns | 0.0065 ns | 0.0058 ns |  3.9992 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.6711 ns | 0.0091 ns | 0.0086 ns |  4.6686 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.2312 ns | 0.0289 ns | 0.0271 ns |  4.2200 ns |  0.91 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.1895 ns | 0.0857 ns | 0.0802 ns |  4.1701 ns |  0.90 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.3012 ns | 0.0603 ns | 0.0564 ns |  4.2837 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.1860 ns | 0.0055 ns | 0.0046 ns |  4.1847 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  4.1970 ns | 0.0084 ns | 0.0078 ns |  4.1964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9817 ns | 0.0072 ns | 0.0064 ns |  3.9815 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.0780 ns | 0.0446 ns | 0.0395 ns |  4.0791 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.3645 ns | 0.0715 ns | 0.0669 ns |  3.3562 ns |  0.80 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2644 ns | 0.0090 ns | 0.0080 ns |  3.2622 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.2465 ns | 0.0467 ns | 0.0437 ns |  5.2622 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.9237 ns | 0.0292 ns | 0.0273 ns |  4.9155 ns |  0.94 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  5.0637 ns | 0.0692 ns | 0.0647 ns |  5.0676 ns |  0.97 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.1241 ns | 0.0551 ns | 0.0515 ns |  5.1227 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  5.2940 ns | 0.0321 ns | 0.0285 ns |  5.3040 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.7539 ns | 0.0165 ns | 0.0154 ns | 13.7531 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.8317 ns | 0.0337 ns | 0.0282 ns | 13.8347 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.7336 ns | 0.0559 ns | 0.0467 ns |  6.7188 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.3596 ns | 0.1699 ns | 0.1589 ns | 14.3035 ns |  1.04 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 14.1007 ns | 0.0231 ns | 0.0216 ns | 14.0989 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.0816 ns | 0.0321 ns | 0.0300 ns | 25.0684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.8044 ns | 0.0180 ns | 0.0169 ns | 24.8072 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.4489 ns | 0.1716 ns | 0.1605 ns | 13.4773 ns |  0.54 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.2278 ns | 0.1172 ns | 0.1039 ns | 25.2523 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.8018 ns | 0.0356 ns | 0.0278 ns | 24.8026 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7018 ns | 0.0087 ns | 0.0077 ns |  0.7036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7036 ns | 0.0035 ns | 0.0033 ns |  0.7032 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.9023 ns | 0.0196 ns | 0.0164 ns |  0.9013 ns |  1.28 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7687 ns | 0.0139 ns | 0.0130 ns |  0.7665 ns |  1.10 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6735 ns | 0.0056 ns | 0.0050 ns |  0.6746 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.3912 ns | 0.0034 ns | 0.0032 ns |  1.3912 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4773 ns | 0.0033 ns | 0.0029 ns |  1.4769 ns |  1.06 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.3959 ns | 0.0341 ns | 0.0302 ns |  1.3903 ns |  1.00 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 10.8456 ns | 0.0338 ns | 0.0316 ns | 10.8528 ns |  7.80 |    0.03 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4251 ns | 0.0030 ns | 0.0026 ns |  1.4250 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.3414 ns | 0.0097 ns | 0.0086 ns |  2.3388 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2882 ns | 0.0198 ns | 0.0185 ns |  2.2951 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1720 ns | 0.0346 ns | 0.0323 ns |  2.1738 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.3101 ns | 0.0286 ns | 0.0268 ns |  2.3077 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.9691 ns | 0.0051 ns | 0.0042 ns |  2.9686 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.8482 ns | 0.1003 ns | 0.0889 ns | 47.8278 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 43.5575 ns | 0.1207 ns | 0.1008 ns | 43.5358 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.8536 ns | 0.0587 ns | 0.0549 ns |  8.8385 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.8700 ns | 0.3441 ns | 0.3050 ns | 46.8181 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 46.6848 ns | 0.0748 ns | 0.0664 ns | 46.6937 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.9590 ns | 0.0183 ns | 0.0171 ns |  1.9645 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.9465 ns | 0.0070 ns | 0.0058 ns |  1.9462 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.5084 ns | 0.0218 ns | 0.0204 ns |  1.5126 ns |  0.77 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7083 ns | 0.0299 ns | 0.0280 ns |  1.7002 ns |  0.87 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6650 ns | 0.0212 ns | 0.0198 ns |  1.6778 ns |  0.85 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.2179 ns | 0.0034 ns | 0.0030 ns |  2.2182 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.3453 ns | 0.0044 ns | 0.0041 ns |  2.3449 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.7889 ns | 0.0225 ns | 0.0210 ns |  1.7829 ns |  0.81 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.6254 ns | 0.0276 ns | 0.0258 ns |  2.6164 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.5271 ns | 0.0056 ns | 0.0052 ns |  2.5273 ns |  1.14 |    0.00 |     - |     - |     - |         - |
