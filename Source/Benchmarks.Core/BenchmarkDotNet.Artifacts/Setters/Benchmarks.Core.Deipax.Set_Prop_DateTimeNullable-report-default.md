
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   7.460 ns | 0.0159 ns | 0.0133 ns |   7.460 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   7.799 ns | 0.0121 ns | 0.0107 ns |   7.799 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   7.479 ns | 0.0082 ns | 0.0073 ns |   7.480 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |   7.587 ns | 0.0139 ns | 0.0130 ns |   7.591 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |   7.800 ns | 0.0131 ns | 0.0117 ns |   7.800 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   7.639 ns | 0.0096 ns | 0.0090 ns |   7.640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   7.754 ns | 0.0142 ns | 0.0126 ns |   7.753 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   7.713 ns | 0.0097 ns | 0.0086 ns |   7.714 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |   7.780 ns | 0.0088 ns | 0.0068 ns |   7.780 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |   7.699 ns | 0.0147 ns | 0.0137 ns |   7.698 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |   7.412 ns | 0.0125 ns | 0.0111 ns |   7.412 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |   7.830 ns | 0.0380 ns | 0.0337 ns |   7.837 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |   7.199 ns | 0.0062 ns | 0.0055 ns |   7.199 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |   7.578 ns | 0.0098 ns | 0.0091 ns |   7.580 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |   7.805 ns | 0.0547 ns | 0.0511 ns |   7.820 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |   7.641 ns | 0.0101 ns | 0.0089 ns |   7.640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   7.951 ns | 0.0142 ns | 0.0132 ns |   7.946 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   7.422 ns | 0.0104 ns | 0.0092 ns |   7.424 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |   8.018 ns | 0.0124 ns | 0.0116 ns |   8.020 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |   7.568 ns | 0.0131 ns | 0.0123 ns |   7.567 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |   7.763 ns | 0.0129 ns | 0.0121 ns |   7.760 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |   7.650 ns | 0.0132 ns | 0.0124 ns |   7.647 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |   7.248 ns | 0.0116 ns | 0.0091 ns |   7.246 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |   7.527 ns | 0.0123 ns | 0.0109 ns |   7.528 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |   7.728 ns | 0.0334 ns | 0.0313 ns |   7.739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   7.423 ns | 0.0148 ns | 0.0131 ns |   7.422 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   7.858 ns | 0.0254 ns | 0.0238 ns |   7.865 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   7.825 ns | 0.0141 ns | 0.0132 ns |   7.822 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |   8.037 ns | 0.0381 ns | 0.0318 ns |   8.044 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |   7.793 ns | 0.0089 ns | 0.0084 ns |   7.794 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |   7.546 ns | 0.0113 ns | 0.0106 ns |   7.543 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |   7.642 ns | 0.0129 ns | 0.0114 ns |   7.641 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |   7.482 ns | 0.0148 ns | 0.0138 ns |   7.485 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |   7.794 ns | 0.0114 ns | 0.0107 ns |   7.792 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |   7.577 ns | 0.0108 ns | 0.0084 ns |   7.578 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |   7.444 ns | 0.0120 ns | 0.0112 ns |   7.445 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   7.955 ns | 0.0083 ns | 0.0074 ns |   7.954 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   7.717 ns | 0.0095 ns | 0.0088 ns |   7.717 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |   7.813 ns | 0.0112 ns | 0.0104 ns |   7.814 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |   7.949 ns | 0.0141 ns | 0.0132 ns |   7.946 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |   7.555 ns | 0.0146 ns | 0.0122 ns |   7.556 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |   7.756 ns | 0.0126 ns | 0.0118 ns |   7.752 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |   7.527 ns | 0.0101 ns | 0.0094 ns |   7.526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |   7.579 ns | 0.0138 ns | 0.0115 ns |   7.577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  11.370 ns | 0.0122 ns | 0.0114 ns |  11.372 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |   7.671 ns | 0.0099 ns | 0.0093 ns |   7.671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   7.781 ns | 0.0119 ns | 0.0112 ns |   7.785 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   7.652 ns | 0.0098 ns | 0.0092 ns |   7.652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |   7.722 ns | 0.0130 ns | 0.0102 ns |   7.725 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |   7.814 ns | 0.0394 ns | 0.0368 ns |   7.802 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |   7.667 ns | 0.0091 ns | 0.0081 ns |   7.667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |   7.736 ns | 0.0070 ns | 0.0062 ns |   7.737 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |   7.248 ns | 0.0091 ns | 0.0080 ns |   7.247 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |   7.508 ns | 0.0135 ns | 0.0127 ns |   7.506 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |   7.733 ns | 0.0290 ns | 0.0257 ns |   7.730 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   7.436 ns | 0.0077 ns | 0.0069 ns |   7.438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   7.949 ns | 0.0143 ns | 0.0134 ns |   7.952 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   7.483 ns | 0.0110 ns | 0.0103 ns |   7.486 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |   7.871 ns | 0.0190 ns | 0.0178 ns |   7.871 ns |  1.06 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |   7.801 ns | 0.0144 ns | 0.0128 ns |   7.801 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |   7.668 ns | 0.0103 ns | 0.0096 ns |   7.669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |   7.735 ns | 0.0143 ns | 0.0134 ns |   7.731 ns |  1.01 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |   7.484 ns | 0.0156 ns | 0.0138 ns |   7.483 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |   7.694 ns | 0.0088 ns | 0.0078 ns |   7.695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |   7.430 ns | 0.0240 ns | 0.0225 ns |   7.437 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |   7.487 ns | 0.0091 ns | 0.0085 ns |   7.489 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   8.036 ns | 0.0142 ns | 0.0118 ns |   8.038 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   7.426 ns | 0.0131 ns | 0.0110 ns |   7.428 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |   7.935 ns | 0.0075 ns | 0.0066 ns |   7.934 ns |  1.06 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |   7.615 ns | 0.0091 ns | 0.0085 ns |   7.617 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |   7.449 ns | 0.0099 ns | 0.0077 ns |   7.450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |   7.657 ns | 0.0074 ns | 0.0069 ns |   7.659 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |   7.414 ns | 0.0088 ns | 0.0074 ns |   7.415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  15.661 ns | 0.0123 ns | 0.0115 ns |  15.662 ns |  2.10 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |   7.464 ns | 0.0128 ns | 0.0113 ns |   7.463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   7.506 ns | 0.0084 ns | 0.0078 ns |   7.505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   7.964 ns | 0.0086 ns | 0.0080 ns |   7.964 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   7.643 ns | 0.0093 ns | 0.0087 ns |   7.644 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |   7.669 ns | 0.0097 ns | 0.0091 ns |   7.670 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |   8.032 ns | 0.0456 ns | 0.0427 ns |   8.049 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |   7.439 ns | 0.0102 ns | 0.0095 ns |   7.440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |   7.741 ns | 0.0059 ns | 0.0055 ns |   7.742 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |   7.444 ns | 0.0110 ns | 0.0098 ns |   7.444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |   7.475 ns | 0.0097 ns | 0.0076 ns |   7.474 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |   7.724 ns | 0.0088 ns | 0.0082 ns |   7.724 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |   8.550 ns | 0.0550 ns | 0.0515 ns |   8.573 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   8.430 ns | 0.0125 ns | 0.0117 ns |   8.429 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   8.195 ns | 0.0108 ns | 0.0101 ns |   8.198 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |   8.777 ns | 0.0173 ns | 0.0162 ns |   8.776 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |   8.438 ns | 0.0279 ns | 0.0261 ns |   8.426 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |   7.674 ns | 0.0128 ns | 0.0120 ns |   7.672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |   7.741 ns | 0.0108 ns | 0.0090 ns |   7.743 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |   7.607 ns | 0.0170 ns | 0.0159 ns |   7.605 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |   7.461 ns | 0.0084 ns | 0.0079 ns |   7.460 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |   7.814 ns | 0.0266 ns | 0.0248 ns |   7.821 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |   8.162 ns | 0.0142 ns | 0.0126 ns |   8.159 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   8.020 ns | 0.0282 ns | 0.0250 ns |   8.019 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   8.798 ns | 0.0109 ns | 0.0085 ns |   8.802 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |   8.217 ns | 0.0102 ns | 0.0090 ns |   8.218 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |   8.088 ns | 0.0136 ns | 0.0127 ns |   8.089 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |   7.668 ns | 0.0066 ns | 0.0058 ns |   7.668 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |   7.834 ns | 0.0086 ns | 0.0072 ns |   7.834 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |   7.415 ns | 0.0156 ns | 0.0146 ns |   7.414 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  11.534 ns | 0.0161 ns | 0.0151 ns |  11.534 ns |  1.50 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |   7.851 ns | 0.0123 ns | 0.0109 ns |   7.853 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   7.441 ns | 0.0131 ns | 0.0123 ns |   7.443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   7.788 ns | 0.0295 ns | 0.0276 ns |   7.792 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   7.798 ns | 0.0095 ns | 0.0089 ns |   7.800 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |   7.901 ns | 0.0078 ns | 0.0073 ns |   7.903 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |   7.723 ns | 0.0122 ns | 0.0114 ns |   7.726 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |   7.506 ns | 0.0115 ns | 0.0096 ns |   7.503 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |   7.733 ns | 0.0095 ns | 0.0084 ns |   7.736 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |   7.770 ns | 0.0466 ns | 0.0435 ns |   7.749 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |   7.674 ns | 0.0118 ns | 0.0105 ns |   7.678 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |   8.298 ns | 0.1889 ns | 0.2457 ns |   8.244 ns |  1.10 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   8.786 ns | 0.0137 ns | 0.0128 ns |   8.786 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   8.460 ns | 0.0378 ns | 0.0353 ns |   8.470 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   8.818 ns | 0.0128 ns | 0.0120 ns |   8.819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |   8.965 ns | 0.1331 ns | 0.1245 ns |   8.989 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |   8.408 ns | 0.0409 ns | 0.0383 ns |   8.398 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |   8.505 ns | 0.0113 ns | 0.0106 ns |   8.505 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |   8.164 ns | 0.0142 ns | 0.0132 ns |   8.163 ns |  0.96 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |   8.807 ns | 0.0141 ns | 0.0118 ns |   8.805 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |   8.243 ns | 0.0169 ns | 0.0158 ns |   8.244 ns |  0.97 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |   8.191 ns | 0.0083 ns | 0.0074 ns |   8.193 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |   8.169 ns | 0.0071 ns | 0.0067 ns |   8.168 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   8.451 ns | 0.0167 ns | 0.0156 ns |   8.451 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   8.120 ns | 0.0101 ns | 0.0090 ns |   8.121 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |   8.550 ns | 0.0339 ns | 0.0301 ns |   8.538 ns |  1.05 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |   8.733 ns | 0.0173 ns | 0.0154 ns |   8.737 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |   5.246 ns | 0.0064 ns | 0.0060 ns |   5.249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |   4.193 ns | 0.0102 ns | 0.0096 ns |   4.194 ns |  0.80 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |   4.353 ns | 0.1112 ns | 0.1522 ns |   4.406 ns |  0.82 |    0.04 |     - |     - |     - |         - |
         FromDateTime |        net461 |   4.831 ns | 0.0046 ns | 0.0040 ns |   4.831 ns |  0.92 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |   4.862 ns | 0.0227 ns | 0.0213 ns |   4.852 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   1.415 ns | 0.0030 ns | 0.0026 ns |   1.415 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   1.149 ns | 0.0028 ns | 0.0026 ns |   1.148 ns |  0.81 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   1.428 ns | 0.0027 ns | 0.0025 ns |   1.428 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   1.997 ns | 0.0095 ns | 0.0089 ns |   1.993 ns |  1.41 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   1.356 ns | 0.0044 ns | 0.0041 ns |   1.356 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  16.683 ns | 0.0261 ns | 0.0244 ns |  16.684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  19.700 ns | 0.0423 ns | 0.0375 ns |  19.697 ns |  1.18 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  20.165 ns | 0.0239 ns | 0.0200 ns |  20.161 ns |  1.21 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  22.136 ns | 0.0165 ns | 0.0154 ns |  22.133 ns |  1.33 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  21.158 ns | 0.0191 ns | 0.0169 ns |  21.153 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 379.856 ns | 0.5124 ns | 0.4543 ns | 379.916 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 322.955 ns | 0.4031 ns | 0.3771 ns | 322.915 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 301.179 ns | 0.3921 ns | 0.3476 ns | 301.329 ns |  0.79 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 645.848 ns | 0.5610 ns | 0.4973 ns | 645.921 ns |  1.70 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 647.649 ns | 2.8578 ns | 2.6732 ns | 649.078 ns |  1.70 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |   7.443 ns | 0.0101 ns | 0.0095 ns |   7.443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |   7.546 ns | 0.0123 ns | 0.0109 ns |   7.547 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |   7.413 ns | 0.0116 ns | 0.0109 ns |   7.411 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  11.435 ns | 0.0387 ns | 0.0343 ns |  11.440 ns |  1.54 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |   7.515 ns | 0.0074 ns | 0.0069 ns |   7.516 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   7.553 ns | 0.0152 ns | 0.0119 ns |   7.555 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   8.025 ns | 0.0365 ns | 0.0341 ns |   8.036 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   8.603 ns | 0.0968 ns | 0.0906 ns |   8.607 ns |  1.14 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |   7.755 ns | 0.0134 ns | 0.0119 ns |   7.752 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |   8.040 ns | 0.0079 ns | 0.0074 ns |   8.040 ns |  1.06 |    0.00 |     - |     - |     - |         - |
