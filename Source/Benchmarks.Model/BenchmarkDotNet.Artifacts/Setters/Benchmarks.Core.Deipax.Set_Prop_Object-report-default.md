
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 3.800 ns | 0.0180 ns | 0.0168 ns | 3.807 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 2.2 | 4.410 ns | 0.0084 ns | 0.0079 ns | 4.410 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 3.0 | 4.251 ns | 0.0366 ns | 0.0342 ns | 4.232 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool |        net461 | 3.837 ns | 0.0558 ns | 0.0522 ns | 3.863 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromBool |        net472 | 3.885 ns | 0.1011 ns | 0.1082 ns | 3.838 ns |  1.02 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 1.208 ns | 0.0027 ns | 0.0025 ns | 1.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 1.138 ns | 0.0035 ns | 0.0031 ns | 1.139 ns |  0.94 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 1.050 ns | 0.0030 ns | 0.0028 ns | 1.050 ns |  0.87 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.135 ns | 0.0140 ns | 0.0131 ns | 1.141 ns |  0.94 |    0.01 |      - |     - |     - |         - |
     FromBoolNullable |        net472 | 1.122 ns | 0.0197 ns | 0.0175 ns | 1.113 ns |  0.93 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromChar | .NET Core 2.0 | 3.778 ns | 0.0146 ns | 0.0122 ns | 3.779 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 2.2 | 4.433 ns | 0.0364 ns | 0.0340 ns | 4.441 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 3.0 | 4.363 ns | 0.0573 ns | 0.0536 ns | 4.385 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromChar |        net461 | 3.752 ns | 0.0123 ns | 0.0115 ns | 3.747 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar |        net472 | 3.744 ns | 0.0163 ns | 0.0136 ns | 3.745 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromCharNullable | .NET Core 2.0 | 1.254 ns | 0.0120 ns | 0.0112 ns | 1.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 1.285 ns | 0.0024 ns | 0.0023 ns | 1.286 ns |  1.02 |    0.01 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 1.358 ns | 0.0045 ns | 0.0040 ns | 1.358 ns |  1.08 |    0.01 |      - |     - |     - |         - |
     FromCharNullable |        net461 | 1.338 ns | 0.0040 ns | 0.0038 ns | 1.338 ns |  1.07 |    0.01 |      - |     - |     - |         - |
     FromCharNullable |        net472 | 1.259 ns | 0.0096 ns | 0.0090 ns | 1.259 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromSByte | .NET Core 2.0 | 3.748 ns | 0.0118 ns | 0.0111 ns | 3.749 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 2.2 | 4.416 ns | 0.0080 ns | 0.0067 ns | 4.417 ns |  1.18 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 3.0 | 4.275 ns | 0.0313 ns | 0.0292 ns | 4.267 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net461 | 3.715 ns | 0.0189 ns | 0.0177 ns | 3.708 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromSByte |        net472 | 3.737 ns | 0.0086 ns | 0.0077 ns | 3.736 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.679 ns | 0.0038 ns | 0.0036 ns | 1.680 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.200 ns | 0.0175 ns | 0.0164 ns | 1.207 ns |  0.71 |    0.01 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 1.105 ns | 0.0021 ns | 0.0019 ns | 1.104 ns |  0.66 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.132 ns | 0.0017 ns | 0.0015 ns | 1.132 ns |  0.67 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.102 ns | 0.0014 ns | 0.0012 ns | 1.102 ns |  0.66 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromByte | .NET Core 2.0 | 3.761 ns | 0.0202 ns | 0.0179 ns | 3.761 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 2.2 | 4.411 ns | 0.0038 ns | 0.0033 ns | 4.412 ns |  1.17 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 3.0 | 4.270 ns | 0.0320 ns | 0.0284 ns | 4.254 ns |  1.14 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromByte |        net461 | 3.737 ns | 0.0152 ns | 0.0142 ns | 3.738 ns |  0.99 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte |        net472 | 3.793 ns | 0.0393 ns | 0.0348 ns | 3.791 ns |  1.01 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.226 ns | 0.0168 ns | 0.0157 ns | 1.232 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 1.139 ns | 0.0050 ns | 0.0045 ns | 1.139 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 1.045 ns | 0.0020 ns | 0.0018 ns | 1.046 ns |  0.85 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net461 | 1.136 ns | 0.0040 ns | 0.0037 ns | 1.136 ns |  0.93 |    0.01 |      - |     - |     - |         - |
     FromByteNullable |        net472 | 1.113 ns | 0.0091 ns | 0.0085 ns | 1.112 ns |  0.91 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromShort | .NET Core 2.0 | 3.953 ns | 0.0155 ns | 0.0137 ns | 3.957 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 2.2 | 4.446 ns | 0.0332 ns | 0.0294 ns | 4.454 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 3.0 | 4.755 ns | 0.1179 ns | 0.1533 ns | 4.786 ns |  1.20 |    0.05 | 0.0038 |     - |     - |      24 B |
            FromShort |        net461 | 4.039 ns | 0.0097 ns | 0.0086 ns | 4.039 ns |  1.02 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort |        net472 | 3.739 ns | 0.0098 ns | 0.0087 ns | 3.737 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.247 ns | 0.0087 ns | 0.0073 ns | 1.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.286 ns | 0.0034 ns | 0.0032 ns | 1.287 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.291 ns | 0.0019 ns | 0.0018 ns | 1.290 ns |  1.04 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net461 | 1.281 ns | 0.0032 ns | 0.0027 ns | 1.281 ns |  1.03 |    0.01 |      - |     - |     - |         - |
    FromShortNullable |        net472 | 1.255 ns | 0.0033 ns | 0.0031 ns | 1.255 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromUShort | .NET Core 2.0 | 3.791 ns | 0.0246 ns | 0.0192 ns | 3.799 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 2.2 | 4.265 ns | 0.0068 ns | 0.0064 ns | 4.264 ns |  1.12 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 3.0 | 4.365 ns | 0.0517 ns | 0.0484 ns | 4.371 ns |  1.15 |    0.02 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net461 | 3.806 ns | 0.0195 ns | 0.0163 ns | 3.808 ns |  1.00 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromUShort |        net472 | 4.173 ns | 0.0099 ns | 0.0088 ns | 4.172 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.265 ns | 0.0033 ns | 0.0031 ns | 1.265 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.284 ns | 0.0036 ns | 0.0033 ns | 1.285 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.291 ns | 0.0026 ns | 0.0025 ns | 1.291 ns |  1.02 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.280 ns | 0.0033 ns | 0.0029 ns | 1.281 ns |  1.01 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.252 ns | 0.0031 ns | 0.0028 ns | 1.253 ns |  0.99 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
              FromInt | .NET Core 2.0 | 3.773 ns | 0.0188 ns | 0.0176 ns | 3.776 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 2.2 | 4.543 ns | 0.0323 ns | 0.0302 ns | 4.552 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 3.0 | 4.261 ns | 0.0247 ns | 0.0232 ns | 4.250 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt |        net461 | 4.182 ns | 0.0220 ns | 0.0195 ns | 4.182 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
              FromInt |        net472 | 4.124 ns | 0.0590 ns | 0.0552 ns | 4.116 ns |  1.09 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.261 ns | 0.0145 ns | 0.0136 ns | 1.267 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.284 ns | 0.0033 ns | 0.0031 ns | 1.285 ns |  1.02 |    0.01 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.290 ns | 0.0027 ns | 0.0024 ns | 1.290 ns |  1.02 |    0.01 |      - |     - |     - |         - |
      FromIntNullable |        net461 | 1.289 ns | 0.0022 ns | 0.0019 ns | 1.288 ns |  1.02 |    0.01 |      - |     - |     - |         - |
      FromIntNullable |        net472 | 1.252 ns | 0.0025 ns | 0.0022 ns | 1.253 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromUInt | .NET Core 2.0 | 3.754 ns | 0.0227 ns | 0.0177 ns | 3.759 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 2.2 | 4.485 ns | 0.0103 ns | 0.0086 ns | 4.485 ns |  1.19 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 3.0 | 5.155 ns | 0.0233 ns | 0.0218 ns | 5.144 ns |  1.37 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net461 | 3.939 ns | 0.0162 ns | 0.0143 ns | 3.938 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt |        net472 | 3.949 ns | 0.0132 ns | 0.0123 ns | 3.952 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.244 ns | 0.0046 ns | 0.0038 ns | 1.244 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.282 ns | 0.0070 ns | 0.0065 ns | 1.282 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.323 ns | 0.0169 ns | 0.0158 ns | 1.329 ns |  1.06 |    0.01 |      - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.282 ns | 0.0033 ns | 0.0031 ns | 1.281 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.311 ns | 0.0025 ns | 0.0023 ns | 1.310 ns |  1.05 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromLong | .NET Core 2.0 | 3.764 ns | 0.0131 ns | 0.0122 ns | 3.766 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 2.2 | 4.470 ns | 0.0121 ns | 0.0113 ns | 4.467 ns |  1.19 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 3.0 | 4.311 ns | 0.0302 ns | 0.0268 ns | 4.323 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromLong |        net461 | 4.313 ns | 0.0155 ns | 0.0145 ns | 4.315 ns |  1.15 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong |        net472 | 3.911 ns | 0.0206 ns | 0.0193 ns | 3.906 ns |  1.04 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.653 ns | 0.0044 ns | 0.0041 ns | 1.653 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.642 ns | 0.0058 ns | 0.0051 ns | 1.641 ns |  0.99 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.698 ns | 0.0030 ns | 0.0029 ns | 1.697 ns |  1.03 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net461 | 1.504 ns | 0.0040 ns | 0.0035 ns | 1.505 ns |  0.91 |    0.00 |      - |     - |     - |         - |
     FromLongNullable |        net472 | 1.681 ns | 0.0022 ns | 0.0020 ns | 1.682 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromULong | .NET Core 2.0 | 3.761 ns | 0.0144 ns | 0.0120 ns | 3.765 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 2.2 | 4.517 ns | 0.0468 ns | 0.0438 ns | 4.526 ns |  1.20 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 3.0 | 4.994 ns | 0.1230 ns | 0.1555 ns | 5.065 ns |  1.31 |    0.05 | 0.0038 |     - |     - |      24 B |
            FromULong |        net461 | 3.966 ns | 0.0098 ns | 0.0082 ns | 3.968 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong |        net472 | 4.245 ns | 0.0075 ns | 0.0063 ns | 4.246 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.480 ns | 0.0025 ns | 0.0022 ns | 1.479 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.568 ns | 0.0030 ns | 0.0028 ns | 1.568 ns |  1.06 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.614 ns | 0.0031 ns | 0.0029 ns | 1.615 ns |  1.09 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net461 | 1.456 ns | 0.0029 ns | 0.0024 ns | 1.456 ns |  0.98 |    0.00 |      - |     - |     - |         - |
    FromULongNullable |        net472 | 1.503 ns | 0.0062 ns | 0.0058 ns | 1.502 ns |  1.02 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromFloat | .NET Core 2.0 | 4.006 ns | 0.0090 ns | 0.0075 ns | 4.006 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 2.2 | 4.525 ns | 0.0208 ns | 0.0185 ns | 4.527 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 3.0 | 4.442 ns | 0.0296 ns | 0.0263 ns | 4.433 ns |  1.11 |    0.01 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net461 | 4.509 ns | 0.0144 ns | 0.0120 ns | 4.506 ns |  1.13 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat |        net472 | 3.924 ns | 0.0136 ns | 0.0120 ns | 3.922 ns |  0.98 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.282 ns | 0.0070 ns | 0.0062 ns | 1.284 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.266 ns | 0.0027 ns | 0.0025 ns | 1.266 ns |  0.99 |    0.01 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.236 ns | 0.0031 ns | 0.0026 ns | 1.236 ns |  0.96 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net461 | 1.248 ns | 0.0023 ns | 0.0020 ns | 1.248 ns |  0.97 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable |        net472 | 1.267 ns | 0.0103 ns | 0.0086 ns | 1.268 ns |  0.99 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromDouble | .NET Core 2.0 | 3.963 ns | 0.0139 ns | 0.0130 ns | 3.968 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 2.2 | 4.426 ns | 0.0079 ns | 0.0070 ns | 4.427 ns |  1.12 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 3.0 | 4.471 ns | 0.0252 ns | 0.0236 ns | 4.477 ns |  1.13 |    0.01 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net461 | 3.775 ns | 0.0070 ns | 0.0058 ns | 3.775 ns |  0.95 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble |        net472 | 4.305 ns | 0.0064 ns | 0.0053 ns | 4.307 ns |  1.09 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.530 ns | 0.0166 ns | 0.0156 ns | 1.524 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.806 ns | 0.0018 ns | 0.0015 ns | 1.806 ns |  1.18 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.851 ns | 0.0026 ns | 0.0025 ns | 1.851 ns |  1.21 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.566 ns | 0.0041 ns | 0.0035 ns | 1.566 ns |  1.02 |    0.01 |      - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.611 ns | 0.0042 ns | 0.0040 ns | 1.611 ns |  1.05 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
          FromDecimal | .NET Core 2.0 | 5.405 ns | 0.0102 ns | 0.0085 ns | 5.406 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 2.2 | 5.729 ns | 0.0616 ns | 0.0576 ns | 5.757 ns |  1.06 |    0.01 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 3.0 | 5.790 ns | 0.0132 ns | 0.0117 ns | 5.789 ns |  1.07 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net461 | 5.562 ns | 0.0078 ns | 0.0065 ns | 5.563 ns |  1.03 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal |        net472 | 5.682 ns | 0.0197 ns | 0.0185 ns | 5.677 ns |  1.05 |    0.00 | 0.0051 |     - |     - |      32 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.588 ns | 0.0067 ns | 0.0056 ns | 1.587 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.652 ns | 0.0027 ns | 0.0025 ns | 1.652 ns |  1.04 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.712 ns | 0.0041 ns | 0.0036 ns | 1.711 ns |  1.08 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable |        net461 | 2.341 ns | 0.0746 ns | 0.1400 ns | 2.390 ns |  1.47 |    0.08 |      - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.658 ns | 0.0139 ns | 0.0130 ns | 1.660 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
         FromDateTime | .NET Core 2.0 | 3.739 ns | 0.0180 ns | 0.0160 ns | 3.741 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 2.2 | 4.593 ns | 0.0078 ns | 0.0069 ns | 4.594 ns |  1.23 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 3.0 | 4.305 ns | 0.0262 ns | 0.0245 ns | 4.289 ns |  1.15 |    0.01 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net461 | 3.916 ns | 0.0140 ns | 0.0117 ns | 3.917 ns |  1.05 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime |        net472 | 3.869 ns | 0.0085 ns | 0.0075 ns | 3.870 ns |  1.03 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.512 ns | 0.0032 ns | 0.0030 ns | 1.511 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.785 ns | 0.0059 ns | 0.0055 ns | 1.786 ns |  1.18 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.634 ns | 0.0028 ns | 0.0026 ns | 1.634 ns |  1.08 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.717 ns | 0.0057 ns | 0.0054 ns | 1.715 ns |  1.14 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.641 ns | 0.0037 ns | 0.0033 ns | 1.640 ns |  1.09 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromObject | .NET Core 2.0 | 1.622 ns | 0.0161 ns | 0.0150 ns | 1.615 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 1.688 ns | 0.0054 ns | 0.0048 ns | 1.688 ns |  1.04 |    0.01 |      - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 1.483 ns | 0.0034 ns | 0.0030 ns | 1.483 ns |  0.91 |    0.01 |      - |     - |     - |         - |
           FromObject |        net461 | 1.640 ns | 0.0041 ns | 0.0038 ns | 1.640 ns |  1.01 |    0.01 |      - |     - |     - |         - |
           FromObject |        net472 | 1.668 ns | 0.0093 ns | 0.0082 ns | 1.670 ns |  1.03 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromString | .NET Core 2.0 | 2.998 ns | 0.0042 ns | 0.0040 ns | 2.998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.845 ns | 0.0103 ns | 0.0086 ns | 1.849 ns |  0.62 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.624 ns | 0.0229 ns | 0.0214 ns | 1.632 ns |  0.54 |    0.01 |      - |     - |     - |         - |
           FromString |        net461 | 2.927 ns | 0.0089 ns | 0.0069 ns | 2.928 ns |  0.98 |    0.00 |      - |     - |     - |         - |
           FromString |        net472 | 2.926 ns | 0.0060 ns | 0.0050 ns | 2.925 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromEnum | .NET Core 2.0 | 3.767 ns | 0.0143 ns | 0.0133 ns | 3.769 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 2.2 | 4.802 ns | 0.0087 ns | 0.0073 ns | 4.803 ns |  1.27 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 3.0 | 4.379 ns | 0.0242 ns | 0.0226 ns | 4.387 ns |  1.16 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net461 | 4.126 ns | 0.0471 ns | 0.0417 ns | 4.106 ns |  1.10 |    0.01 | 0.0038 |     - |     - |      24 B |
             FromEnum |        net472 | 4.168 ns | 0.0144 ns | 0.0135 ns | 4.171 ns |  1.11 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.257 ns | 0.0042 ns | 0.0032 ns | 1.257 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.272 ns | 0.0056 ns | 0.0047 ns | 1.272 ns |  1.01 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.359 ns | 0.0035 ns | 0.0031 ns | 1.360 ns |  1.08 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.388 ns | 0.0145 ns | 0.0129 ns | 1.384 ns |  1.10 |    0.01 |      - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.380 ns | 0.0030 ns | 0.0027 ns | 1.380 ns |  1.10 |    0.00 |      - |     - |     - |         - |
