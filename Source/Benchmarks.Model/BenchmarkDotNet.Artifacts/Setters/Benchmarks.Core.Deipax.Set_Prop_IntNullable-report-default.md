
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
             FromBool | .NET Core 2.0 |  0.7071 ns | 0.0023 ns | 0.0020 ns |  0.7075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6693 ns | 0.0025 ns | 0.0022 ns |  0.6697 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7295 ns | 0.0102 ns | 0.0095 ns |  0.7247 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6542 ns | 0.0021 ns | 0.0018 ns |  0.6542 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6806 ns | 0.0022 ns | 0.0021 ns |  0.6803 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1534 ns | 0.0024 ns | 0.0023 ns |  1.1532 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1334 ns | 0.0023 ns | 0.0018 ns |  1.1335 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9511 ns | 0.0031 ns | 0.0029 ns |  0.9510 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0978 ns | 0.0119 ns | 0.0111 ns |  2.0999 ns |  1.82 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.0754 ns | 0.0032 ns | 0.0028 ns |  2.0758 ns |  1.80 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6956 ns | 0.0047 ns | 0.0044 ns |  0.6969 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6488 ns | 0.0016 ns | 0.0014 ns |  0.6493 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6610 ns | 0.0032 ns | 0.0030 ns |  0.6608 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6548 ns | 0.0028 ns | 0.0026 ns |  0.6551 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6662 ns | 0.0024 ns | 0.0023 ns |  0.6664 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.0528 ns | 0.0026 ns | 0.0023 ns |  1.0526 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0554 ns | 0.0034 ns | 0.0030 ns |  1.0546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0365 ns | 0.0028 ns | 0.0025 ns |  1.0371 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9261 ns | 0.0028 ns | 0.0024 ns |  1.9254 ns |  1.83 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.1326 ns | 0.0039 ns | 0.0036 ns |  2.1327 ns |  2.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5217 ns | 0.0018 ns | 0.0017 ns |  0.5219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5585 ns | 0.0042 ns | 0.0039 ns |  0.5600 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6436 ns | 0.0022 ns | 0.0019 ns |  0.6431 ns |  1.23 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.6778 ns | 0.0054 ns | 0.0051 ns |  0.6801 ns |  1.30 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.6655 ns | 0.0019 ns | 0.0016 ns |  0.6656 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.3039 ns | 0.0142 ns | 0.0132 ns |  1.3098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9308 ns | 0.0024 ns | 0.0023 ns |  0.9304 ns |  0.71 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1137 ns | 0.0012 ns | 0.0010 ns |  1.1136 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.0359 ns | 0.0034 ns | 0.0032 ns |  2.0360 ns |  1.56 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9091 ns | 0.0034 ns | 0.0032 ns |  1.9096 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7023 ns | 0.0036 ns | 0.0033 ns |  0.7025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5661 ns | 0.0035 ns | 0.0033 ns |  0.5662 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6292 ns | 0.0023 ns | 0.0022 ns |  0.6295 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6670 ns | 0.0024 ns | 0.0020 ns |  0.6665 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6672 ns | 0.0044 ns | 0.0041 ns |  0.6662 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9738 ns | 0.0017 ns | 0.0015 ns |  0.9735 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9589 ns | 0.0049 ns | 0.0043 ns |  0.9596 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1007 ns | 0.0112 ns | 0.0099 ns |  1.1027 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.4299 ns | 0.0032 ns | 0.0030 ns |  2.4303 ns |  2.50 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9024 ns | 0.0035 ns | 0.0032 ns |  1.9024 ns |  1.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.5375 ns | 0.0095 ns | 0.0089 ns |  0.5427 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6869 ns | 0.0025 ns | 0.0023 ns |  0.6873 ns |  1.28 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.8525 ns | 0.0018 ns | 0.0017 ns |  0.8522 ns |  1.59 |    0.03 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6579 ns | 0.0031 ns | 0.0029 ns |  0.6569 ns |  1.22 |    0.02 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6670 ns | 0.0022 ns | 0.0020 ns |  0.6673 ns |  1.24 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  0.9789 ns | 0.0023 ns | 0.0022 ns |  0.9790 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.0937 ns | 0.0048 ns | 0.0045 ns |  1.0933 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1017 ns | 0.0032 ns | 0.0030 ns |  1.1026 ns |  1.13 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.1543 ns | 0.0047 ns | 0.0044 ns |  2.1541 ns |  2.20 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9383 ns | 0.0038 ns | 0.0033 ns |  1.9390 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6928 ns | 0.0024 ns | 0.0022 ns |  0.6931 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6411 ns | 0.0045 ns | 0.0043 ns |  0.6414 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6695 ns | 0.0091 ns | 0.0081 ns |  0.6726 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6651 ns | 0.0036 ns | 0.0030 ns |  0.6655 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6641 ns | 0.0028 ns | 0.0025 ns |  0.6639 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9897 ns | 0.0036 ns | 0.0032 ns |  0.9897 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0563 ns | 0.0029 ns | 0.0027 ns |  1.0560 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1242 ns | 0.0199 ns | 0.0176 ns |  1.1274 ns |  1.14 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9326 ns | 0.0048 ns | 0.0045 ns |  1.9322 ns |  1.95 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9288 ns | 0.0035 ns | 0.0033 ns |  1.9277 ns |  1.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.4933 ns | 0.0024 ns | 0.0022 ns |  0.4932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.5845 ns | 0.0034 ns | 0.0032 ns |  0.5855 ns |  1.19 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6753 ns | 0.0021 ns | 0.0018 ns |  0.6748 ns |  1.37 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6581 ns | 0.0028 ns | 0.0024 ns |  0.6580 ns |  1.33 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.6600 ns | 0.0016 ns | 0.0014 ns |  0.6596 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.6738 ns | 0.0020 ns | 0.0017 ns |  0.6741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.6931 ns | 0.0037 ns | 0.0035 ns |  0.6937 ns |  1.03 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.6786 ns | 0.0023 ns | 0.0019 ns |  0.6783 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  0.5527 ns | 0.0044 ns | 0.0041 ns |  0.5536 ns |  0.82 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  0.5349 ns | 0.0018 ns | 0.0016 ns |  0.5348 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4118 ns | 0.0138 ns | 0.0129 ns |  1.4044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3515 ns | 0.0081 ns | 0.0072 ns |  1.3494 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7226 ns | 0.0034 ns | 0.0030 ns |  0.7218 ns |  0.51 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  2.6379 ns | 0.0019 ns | 0.0017 ns |  2.6382 ns |  1.87 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7308 ns | 0.0033 ns | 0.0031 ns |  1.7310 ns |  1.23 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.8812 ns | 0.0031 ns | 0.0029 ns |  1.8819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.8830 ns | 0.0141 ns | 0.0132 ns |  1.8903 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0498 ns | 0.0027 ns | 0.0024 ns |  1.0499 ns |  0.56 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.5936 ns | 0.0040 ns | 0.0037 ns |  2.5937 ns |  1.38 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.5906 ns | 0.0053 ns | 0.0049 ns |  2.5895 ns |  1.38 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8812 ns | 0.0034 ns | 0.0028 ns |  1.8802 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6572 ns | 0.0026 ns | 0.0025 ns |  1.6576 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6605 ns | 0.0021 ns | 0.0018 ns |  1.6607 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.8984 ns | 0.0037 ns | 0.0035 ns |  1.8975 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  2.3901 ns | 0.0024 ns | 0.0022 ns |  2.3899 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.6830 ns | 0.0058 ns | 0.0054 ns |  2.6832 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.9752 ns | 0.0049 ns | 0.0046 ns |  2.9762 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.5491 ns | 0.0021 ns | 0.0016 ns |  2.5493 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.0716 ns | 0.0095 ns | 0.0079 ns |  3.0715 ns |  1.14 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.0559 ns | 0.0043 ns | 0.0040 ns |  3.0554 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.7696 ns | 0.0024 ns | 0.0020 ns |  1.7693 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6960 ns | 0.0031 ns | 0.0029 ns |  1.6960 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6030 ns | 0.0027 ns | 0.0025 ns |  1.6029 ns |  0.91 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  2.4285 ns | 0.0027 ns | 0.0025 ns |  2.4292 ns |  1.37 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7475 ns | 0.0045 ns | 0.0037 ns |  1.7476 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9630 ns | 0.0179 ns | 0.0167 ns |  2.9574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0948 ns | 0.0042 ns | 0.0039 ns |  3.0946 ns |  1.04 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.7852 ns | 0.0042 ns | 0.0035 ns |  2.7845 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1256 ns | 0.0063 ns | 0.0059 ns |  3.1257 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.9089 ns | 0.0065 ns | 0.0057 ns |  2.9082 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.4601 ns | 0.0054 ns | 0.0050 ns |  3.4588 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4042 ns | 0.0255 ns | 0.0238 ns |  3.3908 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4596 ns | 0.0042 ns | 0.0037 ns |  3.4602 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4105 ns | 0.0034 ns | 0.0031 ns |  3.4105 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4125 ns | 0.0064 ns | 0.0060 ns |  3.4121 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.3767 ns | 0.0051 ns | 0.0040 ns |  3.3766 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.5448 ns | 0.0049 ns | 0.0046 ns |  3.5442 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.4690 ns | 0.0051 ns | 0.0048 ns |  3.4692 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.6924 ns | 0.0059 ns | 0.0056 ns |  3.6931 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.6706 ns | 0.0072 ns | 0.0068 ns |  3.6702 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.5996 ns | 0.0040 ns | 0.0034 ns |  2.6002 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5476 ns | 0.0068 ns | 0.0060 ns |  2.5475 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.8431 ns | 0.0045 ns | 0.0040 ns |  2.8429 ns |  1.09 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5749 ns | 0.0060 ns | 0.0056 ns |  2.5746 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.9836 ns | 0.0035 ns | 0.0031 ns |  2.9831 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.6451 ns | 0.0045 ns | 0.0042 ns |  3.6450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.0239 ns | 0.0223 ns | 0.0209 ns |  4.0146 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.8254 ns | 0.0047 ns | 0.0044 ns |  3.8256 ns |  1.05 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.0856 ns | 0.0060 ns | 0.0056 ns |  4.0855 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.0845 ns | 0.0062 ns | 0.0055 ns |  4.0851 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.2470 ns | 0.0174 ns | 0.0155 ns | 13.2454 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1819 ns | 0.0093 ns | 0.0083 ns | 13.1835 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.0434 ns | 0.1463 ns | 0.1626 ns |  6.1571 ns |  0.45 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  9.1649 ns | 0.0092 ns | 0.0086 ns |  9.1644 ns |  0.69 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  7.2375 ns | 0.0079 ns | 0.0074 ns |  7.2365 ns |  0.55 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.0873 ns | 0.0284 ns | 0.0222 ns | 24.0889 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.0791 ns | 0.0171 ns | 0.0143 ns | 24.0782 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.1387 ns | 0.0207 ns | 0.0183 ns | 13.1412 ns |  0.55 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 17.8200 ns | 0.0332 ns | 0.0294 ns | 17.8109 ns |  0.74 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 18.0335 ns | 0.0216 ns | 0.0202 ns | 18.0295 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6913 ns | 0.0021 ns | 0.0016 ns |  0.6914 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6834 ns | 0.0023 ns | 0.0018 ns |  0.6836 ns |  0.99 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6692 ns | 0.0113 ns | 0.0105 ns |  0.6747 ns |  0.97 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7024 ns | 0.0015 ns | 0.0014 ns |  0.7022 ns |  1.02 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  1.0403 ns | 0.0020 ns | 0.0018 ns |  1.0401 ns |  1.50 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4737 ns | 0.0037 ns | 0.0031 ns |  1.4741 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6630 ns | 0.0028 ns | 0.0026 ns |  1.6627 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4973 ns | 0.0024 ns | 0.0022 ns |  1.4972 ns |  1.02 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6627 ns | 0.0037 ns | 0.0032 ns |  1.6630 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6609 ns | 0.0023 ns | 0.0021 ns |  1.6606 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.1017 ns | 0.0550 ns | 0.0514 ns | 10.0738 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.0501 ns | 0.0147 ns | 0.0130 ns | 14.0470 ns |  1.39 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.8244 ns | 0.0156 ns | 0.0139 ns | 14.8251 ns |  1.47 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.4992 ns | 0.0109 ns | 0.0091 ns | 13.4994 ns |  1.34 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 | 13.2071 ns | 0.0188 ns | 0.0176 ns | 13.2063 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 45.6175 ns | 0.0641 ns | 0.0599 ns | 45.6430 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 41.3911 ns | 0.0341 ns | 0.0284 ns | 41.3907 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.5633 ns | 0.0483 ns | 0.0452 ns | 10.5799 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 44.4734 ns | 0.0389 ns | 0.0364 ns | 44.4702 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 44.4689 ns | 0.0496 ns | 0.0464 ns | 44.4682 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7066 ns | 0.0024 ns | 0.0020 ns |  0.7063 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.5681 ns | 0.0024 ns | 0.0020 ns |  0.5684 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6787 ns | 0.0019 ns | 0.0017 ns |  0.6788 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7176 ns | 0.0020 ns | 0.0019 ns |  0.7181 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7203 ns | 0.0061 ns | 0.0057 ns |  0.7213 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  0.9932 ns | 0.0256 ns | 0.0239 ns |  0.9902 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.3478 ns | 0.0544 ns | 0.1124 ns |  1.3394 ns |  1.37 |    0.13 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0785 ns | 0.0015 ns | 0.0013 ns |  1.0783 ns |  1.09 |    0.03 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.8983 ns | 0.0021 ns | 0.0018 ns |  1.8978 ns |  1.91 |    0.05 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.8996 ns | 0.0026 ns | 0.0025 ns |  1.8999 ns |  1.91 |    0.05 |     - |     - |     - |         - |
