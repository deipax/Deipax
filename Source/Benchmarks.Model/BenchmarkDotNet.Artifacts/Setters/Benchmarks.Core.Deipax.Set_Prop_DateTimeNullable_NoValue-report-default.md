
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EESCLK : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-QSSVGP : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-EOYUJY : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-ETYLEW : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-VJGCOH : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  7.456 ns | 0.0153 ns | 0.0143 ns |  7.455 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  7.469 ns | 0.0145 ns | 0.0136 ns |  7.471 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  7.527 ns | 0.0469 ns | 0.0416 ns |  7.540 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  7.512 ns | 0.0167 ns | 0.0148 ns |  7.512 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  7.712 ns | 0.0122 ns | 0.0115 ns |  7.712 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  7.679 ns | 0.0098 ns | 0.0077 ns |  7.680 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  7.780 ns | 0.0207 ns | 0.0184 ns |  7.774 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  7.710 ns | 0.0097 ns | 0.0091 ns |  7.708 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  7.730 ns | 0.0104 ns | 0.0097 ns |  7.731 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  7.908 ns | 0.0356 ns | 0.0316 ns |  7.912 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  7.540 ns | 0.0307 ns | 0.0272 ns |  7.546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  7.453 ns | 0.0113 ns | 0.0106 ns |  7.453 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  7.450 ns | 0.0184 ns | 0.0163 ns |  7.447 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  7.487 ns | 0.0095 ns | 0.0085 ns |  7.488 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  7.696 ns | 0.0115 ns | 0.0108 ns |  7.692 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  7.672 ns | 0.0069 ns | 0.0062 ns |  7.675 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  7.787 ns | 0.0112 ns | 0.0105 ns |  7.784 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  7.788 ns | 0.0103 ns | 0.0086 ns |  7.790 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  7.671 ns | 0.0093 ns | 0.0083 ns |  7.671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  7.652 ns | 0.0118 ns | 0.0104 ns |  7.649 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  7.785 ns | 0.0349 ns | 0.0327 ns |  7.769 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  7.564 ns | 0.0188 ns | 0.0176 ns |  7.559 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  7.447 ns | 0.0170 ns | 0.0151 ns |  7.445 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  7.545 ns | 0.0118 ns | 0.0111 ns |  7.546 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  7.706 ns | 0.0313 ns | 0.0278 ns |  7.713 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  7.525 ns | 0.0456 ns | 0.0427 ns |  7.533 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  7.919 ns | 0.0073 ns | 0.0068 ns |  7.921 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  7.718 ns | 0.0211 ns | 0.0197 ns |  7.712 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  7.961 ns | 0.0121 ns | 0.0113 ns |  7.963 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  7.778 ns | 0.0106 ns | 0.0099 ns |  7.780 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  7.602 ns | 0.0081 ns | 0.0071 ns |  7.603 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  7.694 ns | 0.0103 ns | 0.0096 ns |  7.693 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  7.373 ns | 0.0064 ns | 0.0057 ns |  7.373 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 15.653 ns | 0.0191 ns | 0.0160 ns | 15.659 ns |  2.06 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  7.474 ns | 0.0105 ns | 0.0082 ns |  7.473 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  7.405 ns | 0.0128 ns | 0.0107 ns |  7.404 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  7.791 ns | 0.0121 ns | 0.0095 ns |  7.789 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  7.638 ns | 0.0151 ns | 0.0141 ns |  7.638 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  7.744 ns | 0.0118 ns | 0.0110 ns |  7.743 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  8.112 ns | 0.0387 ns | 0.0362 ns |  8.116 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  7.442 ns | 0.0421 ns | 0.0394 ns |  7.426 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  7.468 ns | 0.0123 ns | 0.0115 ns |  7.470 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  7.272 ns | 0.0367 ns | 0.0344 ns |  7.286 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  7.580 ns | 0.0087 ns | 0.0081 ns |  7.580 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  7.686 ns | 0.0159 ns | 0.0141 ns |  7.685 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  7.763 ns | 0.0085 ns | 0.0080 ns |  7.760 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  7.955 ns | 0.0115 ns | 0.0108 ns |  7.953 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  7.627 ns | 0.0082 ns | 0.0073 ns |  7.629 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  7.785 ns | 0.0132 ns | 0.0110 ns |  7.787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 16.068 ns | 0.0728 ns | 0.0681 ns | 16.087 ns |  2.07 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  7.651 ns | 0.0134 ns | 0.0119 ns |  7.652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  7.479 ns | 0.0105 ns | 0.0098 ns |  7.478 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  7.167 ns | 0.0151 ns | 0.0134 ns |  7.165 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  7.452 ns | 0.0078 ns | 0.0073 ns |  7.450 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  7.763 ns | 0.0130 ns | 0.0121 ns |  7.761 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  7.415 ns | 0.0135 ns | 0.0127 ns |  7.411 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  7.726 ns | 0.0117 ns | 0.0103 ns |  7.724 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  7.606 ns | 0.0103 ns | 0.0091 ns |  7.606 ns |  1.03 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  7.729 ns | 0.0124 ns | 0.0110 ns |  7.728 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  7.600 ns | 0.0069 ns | 0.0065 ns |  7.599 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  7.726 ns | 0.0377 ns | 0.0353 ns |  7.736 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  7.538 ns | 0.0121 ns | 0.0113 ns |  7.539 ns |  0.98 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  7.164 ns | 0.0079 ns | 0.0074 ns |  7.163 ns |  0.93 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  7.441 ns | 0.0079 ns | 0.0070 ns |  7.444 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  7.513 ns | 0.0533 ns | 0.0445 ns |  7.532 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  7.544 ns | 0.0175 ns | 0.0137 ns |  7.545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  7.803 ns | 0.0128 ns | 0.0113 ns |  7.806 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  7.410 ns | 0.0229 ns | 0.0191 ns |  7.415 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  7.672 ns | 0.0093 ns | 0.0087 ns |  7.672 ns |  1.02 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  7.638 ns | 0.0180 ns | 0.0151 ns |  7.638 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  7.415 ns | 0.0199 ns | 0.0176 ns |  7.410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  7.636 ns | 0.0527 ns | 0.0493 ns |  7.612 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  7.272 ns | 0.0091 ns | 0.0081 ns |  7.270 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  7.569 ns | 0.0136 ns | 0.0106 ns |  7.571 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  7.694 ns | 0.0289 ns | 0.0270 ns |  7.695 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  7.519 ns | 0.0126 ns | 0.0112 ns |  7.518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  7.842 ns | 0.0124 ns | 0.0110 ns |  7.845 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  7.738 ns | 0.0110 ns | 0.0103 ns |  7.738 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  7.726 ns | 0.0073 ns | 0.0069 ns |  7.725 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  8.100 ns | 0.0342 ns | 0.0320 ns |  8.107 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  7.425 ns | 0.0133 ns | 0.0118 ns |  7.424 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  7.518 ns | 0.0104 ns | 0.0081 ns |  7.516 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  7.438 ns | 0.0112 ns | 0.0099 ns |  7.439 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  7.593 ns | 0.0081 ns | 0.0072 ns |  7.591 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  7.696 ns | 0.0141 ns | 0.0132 ns |  7.694 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  8.238 ns | 0.0068 ns | 0.0063 ns |  8.239 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  8.031 ns | 0.0208 ns | 0.0162 ns |  8.031 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  8.366 ns | 0.0601 ns | 0.0562 ns |  8.340 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 16.976 ns | 0.0948 ns | 0.0887 ns | 17.016 ns |  2.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  8.163 ns | 0.0107 ns | 0.0095 ns |  8.164 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  7.745 ns | 0.0292 ns | 0.0273 ns |  7.751 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  7.594 ns | 0.0081 ns | 0.0076 ns |  7.593 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  7.410 ns | 0.0147 ns | 0.0137 ns |  7.413 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  7.535 ns | 0.0131 ns | 0.0123 ns |  7.534 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  7.872 ns | 0.0446 ns | 0.0395 ns |  7.891 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  8.128 ns | 0.0135 ns | 0.0126 ns |  8.128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  8.185 ns | 0.0159 ns | 0.0133 ns |  8.181 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  8.768 ns | 0.0248 ns | 0.0220 ns |  8.773 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  8.383 ns | 0.0152 ns | 0.0142 ns |  8.386 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  8.131 ns | 0.0214 ns | 0.0200 ns |  8.132 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  7.685 ns | 0.0108 ns | 0.0101 ns |  7.684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  8.021 ns | 0.0507 ns | 0.0474 ns |  7.997 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  7.739 ns | 0.0446 ns | 0.0417 ns |  7.755 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  7.948 ns | 0.0101 ns | 0.0094 ns |  7.949 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  8.570 ns | 0.1927 ns | 0.2884 ns |  8.692 ns |  1.11 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  7.414 ns | 0.0205 ns | 0.0192 ns |  7.410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  8.015 ns | 0.0102 ns | 0.0090 ns |  8.013 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  7.655 ns | 0.0150 ns | 0.0140 ns |  7.657 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  7.953 ns | 0.0088 ns | 0.0082 ns |  7.951 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  7.761 ns | 0.0165 ns | 0.0154 ns |  7.762 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  7.602 ns | 0.0079 ns | 0.0074 ns |  7.604 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  7.978 ns | 0.0254 ns | 0.0237 ns |  7.978 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  7.493 ns | 0.0137 ns | 0.0128 ns |  7.494 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  8.156 ns | 0.0269 ns | 0.0252 ns |  8.163 ns |  1.07 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  7.700 ns | 0.0117 ns | 0.0109 ns |  7.698 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  8.782 ns | 0.0159 ns | 0.0141 ns |  8.779 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  8.116 ns | 0.0176 ns | 0.0165 ns |  8.115 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  8.280 ns | 0.0094 ns | 0.0074 ns |  8.280 ns |  0.94 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  8.151 ns | 0.0227 ns | 0.0213 ns |  8.151 ns |  0.93 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  8.245 ns | 0.0389 ns | 0.0364 ns |  8.234 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  8.704 ns | 0.0111 ns | 0.0104 ns |  8.700 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.228 ns | 0.0097 ns | 0.0090 ns |  8.228 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  8.173 ns | 0.0114 ns | 0.0101 ns |  8.171 ns |  0.94 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.137 ns | 0.0197 ns | 0.0184 ns |  8.135 ns |  0.93 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.386 ns | 0.0110 ns | 0.0098 ns |  8.387 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.141 ns | 0.0090 ns | 0.0084 ns |  8.140 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.396 ns | 0.0091 ns | 0.0076 ns |  8.397 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  8.171 ns | 0.0087 ns | 0.0082 ns |  8.170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.806 ns | 0.0113 ns | 0.0106 ns |  8.804 ns |  1.08 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.742 ns | 0.0303 ns | 0.0284 ns |  8.741 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  4.721 ns | 0.0128 ns | 0.0120 ns |  4.719 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  4.225 ns | 0.0060 ns | 0.0056 ns |  4.224 ns |  0.89 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  4.024 ns | 0.0292 ns | 0.0274 ns |  4.009 ns |  0.85 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  4.849 ns | 0.0070 ns | 0.0065 ns |  4.849 ns |  1.03 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  4.836 ns | 0.0066 ns | 0.0061 ns |  4.837 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.408 ns | 0.0018 ns | 0.0015 ns |  1.409 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.177 ns | 0.0042 ns | 0.0040 ns |  1.178 ns |  0.84 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.394 ns | 0.0041 ns | 0.0038 ns |  1.392 ns |  0.99 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.411 ns | 0.0029 ns | 0.0024 ns |  1.411 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.370 ns | 0.0045 ns | 0.0040 ns |  1.369 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  8.615 ns | 0.0139 ns | 0.0123 ns |  8.614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  8.609 ns | 0.0246 ns | 0.0230 ns |  8.614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  8.826 ns | 0.0173 ns | 0.0154 ns |  8.826 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  8.424 ns | 0.0108 ns | 0.0096 ns |  8.420 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  8.433 ns | 0.0383 ns | 0.0320 ns |  8.432 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  7.734 ns | 0.0116 ns | 0.0103 ns |  7.732 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  8.069 ns | 0.0353 ns | 0.0330 ns |  8.072 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  7.925 ns | 0.0329 ns | 0.0308 ns |  7.932 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  7.978 ns | 0.0158 ns | 0.0148 ns |  7.980 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  7.736 ns | 0.0163 ns | 0.0152 ns |  7.741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  7.416 ns | 0.0085 ns | 0.0080 ns |  7.412 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  7.810 ns | 0.0089 ns | 0.0083 ns |  7.812 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  7.419 ns | 0.0091 ns | 0.0085 ns |  7.419 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  7.794 ns | 0.0409 ns | 0.0362 ns |  7.780 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  7.530 ns | 0.0125 ns | 0.0117 ns |  7.533 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  7.449 ns | 0.0116 ns | 0.0097 ns |  7.447 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  7.741 ns | 0.0101 ns | 0.0094 ns |  7.740 ns |  1.04 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  7.698 ns | 0.0165 ns | 0.0146 ns |  7.696 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  7.865 ns | 0.0391 ns | 0.0366 ns |  7.874 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  7.923 ns | 0.0101 ns | 0.0095 ns |  7.922 ns |  1.06 |    0.00 |     - |     - |     - |         - |
