
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |   7.627 ns | 0.0258 ns | 0.0229 ns |   7.627 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |   7.890 ns | 0.0347 ns | 0.0325 ns |   7.907 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |   7.601 ns | 0.0523 ns | 0.0464 ns |   7.594 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |   7.908 ns | 0.0093 ns | 0.0073 ns |   7.911 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |   7.806 ns | 0.1746 ns | 0.1363 ns |   7.743 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |   7.659 ns | 0.0138 ns | 0.0115 ns |   7.661 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |   7.787 ns | 0.0101 ns | 0.0089 ns |   7.788 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |   7.824 ns | 0.0510 ns | 0.0452 ns |   7.810 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |   7.928 ns | 0.0346 ns | 0.0324 ns |   7.921 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |   8.050 ns | 0.0778 ns | 0.0650 ns |   8.060 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |   7.529 ns | 0.0121 ns | 0.0114 ns |   7.526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |   7.791 ns | 0.0352 ns | 0.0329 ns |   7.779 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |   7.574 ns | 0.0147 ns | 0.0137 ns |   7.571 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |   7.880 ns | 0.0328 ns | 0.0291 ns |   7.869 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |   7.882 ns | 0.1002 ns | 0.0837 ns |   7.884 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |   7.680 ns | 0.0466 ns | 0.0413 ns |   7.663 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |   7.889 ns | 0.0082 ns | 0.0073 ns |   7.891 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |   7.786 ns | 0.0289 ns | 0.0241 ns |   7.776 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |   7.785 ns | 0.0355 ns | 0.0332 ns |   7.764 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |   8.126 ns | 0.0587 ns | 0.0521 ns |   8.112 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |   7.779 ns | 0.0131 ns | 0.0122 ns |   7.777 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |   7.577 ns | 0.0092 ns | 0.0082 ns |   7.577 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |   7.384 ns | 0.0652 ns | 0.0610 ns |   7.394 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |   7.857 ns | 0.0220 ns | 0.0195 ns |   7.856 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |   7.834 ns | 0.1283 ns | 0.1200 ns |   7.772 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |   7.476 ns | 0.0126 ns | 0.0118 ns |   7.473 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |   7.909 ns | 0.0113 ns | 0.0106 ns |   7.911 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |   7.829 ns | 0.0483 ns | 0.0428 ns |   7.827 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |   7.946 ns | 0.0229 ns | 0.0203 ns |   7.940 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |   8.145 ns | 0.1406 ns | 0.1246 ns |   8.098 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |   7.432 ns | 0.0134 ns | 0.0119 ns |   7.431 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |   7.642 ns | 0.0151 ns | 0.0141 ns |   7.641 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |   7.417 ns | 0.0335 ns | 0.0280 ns |   7.410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |   7.734 ns | 0.0705 ns | 0.0660 ns |   7.700 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |   7.990 ns | 0.1591 ns | 0.1488 ns |   7.914 ns |  1.08 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |   7.508 ns | 0.0375 ns | 0.0350 ns |   7.518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |   8.055 ns | 0.0461 ns | 0.0431 ns |   8.068 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |   7.809 ns | 0.0870 ns | 0.0771 ns |   7.815 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |   8.144 ns | 0.0613 ns | 0.0544 ns |   8.135 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  11.762 ns | 0.0264 ns | 0.0220 ns |  11.767 ns |  1.57 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |   7.433 ns | 0.0099 ns | 0.0083 ns |   7.434 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |   7.773 ns | 0.0158 ns | 0.0148 ns |   7.771 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |   7.628 ns | 0.0174 ns | 0.0155 ns |   7.626 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |   7.932 ns | 0.0581 ns | 0.0485 ns |   7.928 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |   7.664 ns | 0.0152 ns | 0.0135 ns |   7.661 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |   7.787 ns | 0.0345 ns | 0.0322 ns |   7.794 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |   7.903 ns | 0.0395 ns | 0.0370 ns |   7.922 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |   7.620 ns | 0.0381 ns | 0.0356 ns |   7.623 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |   7.957 ns | 0.0407 ns | 0.0361 ns |   7.943 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |   7.954 ns | 0.0280 ns | 0.0249 ns |   7.945 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |   7.652 ns | 0.0113 ns | 0.0089 ns |   7.653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |   7.774 ns | 0.0129 ns | 0.0114 ns |   7.774 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |   7.570 ns | 0.0417 ns | 0.0370 ns |   7.553 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |   7.906 ns | 0.0268 ns | 0.0224 ns |   7.911 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |   7.713 ns | 0.0304 ns | 0.0284 ns |   7.706 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |   7.510 ns | 0.0152 ns | 0.0142 ns |   7.512 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |   7.835 ns | 0.0127 ns | 0.0119 ns |   7.837 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |   7.568 ns | 0.0240 ns | 0.0212 ns |   7.561 ns |  1.01 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |   7.759 ns | 0.0483 ns | 0.0452 ns |   7.734 ns |  1.03 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |   7.882 ns | 0.0472 ns | 0.0418 ns |   7.863 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |   7.656 ns | 0.0127 ns | 0.0112 ns |   7.656 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |   7.568 ns | 0.0151 ns | 0.0142 ns |   7.568 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |   7.587 ns | 0.0645 ns | 0.0603 ns |   7.551 ns |  0.99 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |   7.578 ns | 0.0224 ns | 0.0198 ns |   7.572 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |   7.996 ns | 0.0450 ns | 0.0399 ns |   7.997 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |   7.559 ns | 0.0145 ns | 0.0128 ns |   7.558 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |   7.780 ns | 0.0173 ns | 0.0153 ns |   7.784 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |   7.904 ns | 0.0517 ns | 0.0483 ns |   7.898 ns |  1.05 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |   8.076 ns | 0.0859 ns | 0.0804 ns |   8.048 ns |  1.07 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |   8.589 ns | 0.1713 ns | 0.1602 ns |   8.590 ns |  1.14 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |   7.443 ns | 0.0126 ns | 0.0111 ns |   7.443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |   8.392 ns | 0.2939 ns | 0.8144 ns |   8.005 ns |  1.16 |    0.16 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |   7.782 ns | 0.0673 ns | 0.0629 ns |   7.766 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |   7.578 ns | 0.0597 ns | 0.0529 ns |   7.571 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |   7.649 ns | 0.0205 ns | 0.0192 ns |   7.648 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |   7.452 ns | 0.0114 ns | 0.0101 ns |   7.454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |   8.167 ns | 0.1918 ns | 0.2751 ns |   8.061 ns |  1.12 |    0.03 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |   7.833 ns | 0.0369 ns | 0.0308 ns |   7.836 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |   8.151 ns | 0.0117 ns | 0.0103 ns |   8.149 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |   7.905 ns | 0.0197 ns | 0.0165 ns |   7.902 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |   7.439 ns | 0.0125 ns | 0.0104 ns |   7.438 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |   8.255 ns | 0.0548 ns | 0.0513 ns |   8.255 ns |  1.11 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |   7.592 ns | 0.0397 ns | 0.0372 ns |   7.580 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |   7.831 ns | 0.0180 ns | 0.0151 ns |   7.823 ns |  1.05 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |   7.642 ns | 0.0143 ns | 0.0126 ns |   7.638 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |   8.251 ns | 0.0454 ns | 0.0424 ns |   8.261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |   8.713 ns | 0.0915 ns | 0.0811 ns |   8.684 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |   8.694 ns | 0.0438 ns | 0.0366 ns |   8.700 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |   8.327 ns | 0.0137 ns | 0.0121 ns |   8.325 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |   8.414 ns | 0.0268 ns | 0.0224 ns |   8.405 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |   7.651 ns | 0.0149 ns | 0.0140 ns |   7.653 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |   7.952 ns | 0.0443 ns | 0.0393 ns |   7.942 ns |  1.04 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |   7.579 ns | 0.0385 ns | 0.0342 ns |   7.570 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |   7.999 ns | 0.0360 ns | 0.0319 ns |   7.997 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |   7.777 ns | 0.0372 ns | 0.0330 ns |   7.775 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |   8.156 ns | 0.0117 ns | 0.0104 ns |   8.157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |   8.296 ns | 0.0593 ns | 0.0555 ns |   8.268 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |   8.577 ns | 0.0975 ns | 0.0912 ns |   8.531 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |   8.240 ns | 0.0087 ns | 0.0077 ns |   8.239 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |   8.470 ns | 0.0167 ns | 0.0148 ns |   8.468 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |   7.766 ns | 0.0140 ns | 0.0124 ns |   7.764 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |   7.815 ns | 0.0518 ns | 0.0459 ns |   7.800 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |   7.685 ns | 0.0399 ns | 0.0353 ns |   7.676 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |   7.861 ns | 0.0153 ns | 0.0127 ns |   7.858 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |   7.882 ns | 0.0457 ns | 0.0428 ns |   7.882 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |   7.447 ns | 0.0203 ns | 0.0190 ns |   7.449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |   7.858 ns | 0.0080 ns | 0.0066 ns |   7.857 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |   7.804 ns | 0.0216 ns | 0.0202 ns |   7.800 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |   7.943 ns | 0.0524 ns | 0.0490 ns |   7.933 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |   8.182 ns | 0.0736 ns | 0.0689 ns |   8.137 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |   7.659 ns | 0.0333 ns | 0.0295 ns |   7.672 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |   7.700 ns | 0.0834 ns | 0.0780 ns |   7.661 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |   8.063 ns | 0.0622 ns | 0.0552 ns |   8.082 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |   7.880 ns | 0.0371 ns | 0.0329 ns |   7.865 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |   7.819 ns | 0.0169 ns | 0.0150 ns |   7.817 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |   8.799 ns | 0.0173 ns | 0.0162 ns |   8.793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |   8.870 ns | 0.1639 ns | 0.1368 ns |   8.808 ns |  1.01 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |   8.706 ns | 0.0189 ns | 0.0158 ns |   8.701 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |   8.614 ns | 0.0654 ns | 0.0580 ns |   8.594 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |   8.268 ns | 0.0244 ns | 0.0191 ns |   8.264 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |   8.782 ns | 0.0118 ns | 0.0110 ns |   8.782 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |   8.368 ns | 0.0509 ns | 0.0451 ns |   8.353 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |   8.985 ns | 0.0495 ns | 0.0463 ns |   8.988 ns |  1.02 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |   8.365 ns | 0.0124 ns | 0.0110 ns |   8.365 ns |  0.95 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |   8.846 ns | 0.0279 ns | 0.0261 ns |   8.844 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |   8.170 ns | 0.0152 ns | 0.0142 ns |   8.169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |   8.423 ns | 0.0282 ns | 0.0263 ns |   8.419 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |   8.371 ns | 0.0722 ns | 0.0640 ns |   8.395 ns |  1.02 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |   8.711 ns | 0.0531 ns | 0.0497 ns |   8.710 ns |  1.07 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |   8.680 ns | 0.0547 ns | 0.0485 ns |   8.697 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |   5.186 ns | 0.0053 ns | 0.0042 ns |   5.187 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |   4.252 ns | 0.0071 ns | 0.0063 ns |   4.251 ns |  0.82 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |   4.087 ns | 0.0386 ns | 0.0361 ns |   4.070 ns |  0.79 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |   5.405 ns | 0.0459 ns | 0.0407 ns |   5.378 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |   4.935 ns | 0.0311 ns | 0.0290 ns |   4.920 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |   1.413 ns | 0.0045 ns | 0.0042 ns |   1.412 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |   1.172 ns | 0.0054 ns | 0.0048 ns |   1.171 ns |  0.83 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |   1.404 ns | 0.0065 ns | 0.0054 ns |   1.404 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |   1.402 ns | 0.0072 ns | 0.0068 ns |   1.398 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |   1.459 ns | 0.0070 ns | 0.0066 ns |   1.459 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  16.594 ns | 0.0333 ns | 0.0296 ns |  16.593 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  20.537 ns | 0.0587 ns | 0.0521 ns |  20.528 ns |  1.24 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  20.652 ns | 0.2159 ns | 0.2020 ns |  20.583 ns |  1.24 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  21.587 ns | 0.1663 ns | 0.1555 ns |  21.491 ns |  1.30 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  21.300 ns | 0.0411 ns | 0.0364 ns |  21.300 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 392.468 ns | 0.5690 ns | 0.5044 ns | 392.374 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 328.478 ns | 0.6230 ns | 0.4864 ns | 328.478 ns |  0.84 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 303.429 ns | 0.9610 ns | 0.8025 ns | 303.253 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 658.473 ns | 1.0189 ns | 0.8509 ns | 658.368 ns |  1.68 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 664.683 ns | 1.1534 ns | 0.9005 ns | 664.772 ns |  1.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |   7.449 ns | 0.0095 ns | 0.0089 ns |   7.448 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |   7.780 ns | 0.1307 ns | 0.1158 ns |   7.762 ns |  1.04 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |   7.645 ns | 0.0757 ns | 0.0709 ns |   7.623 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |   7.682 ns | 0.0652 ns | 0.0610 ns |   7.662 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |   7.890 ns | 0.0500 ns | 0.0468 ns |   7.902 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |   7.449 ns | 0.0120 ns | 0.0100 ns |   7.451 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |   8.171 ns | 0.0798 ns | 0.0746 ns |   8.170 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |   7.802 ns | 0.0247 ns | 0.0206 ns |   7.795 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |   8.128 ns | 0.0518 ns | 0.0485 ns |   8.113 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |   7.818 ns | 0.0142 ns | 0.0133 ns |   7.819 ns |  1.05 |    0.00 |     - |     - |     - |         - |
