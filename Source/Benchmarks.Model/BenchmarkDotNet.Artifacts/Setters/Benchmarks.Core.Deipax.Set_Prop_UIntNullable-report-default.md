
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
             FromBool | .NET Core 2.0 |  0.6516 ns | 0.0028 ns | 0.0024 ns |  0.6524 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9378 ns | 0.0031 ns | 0.0029 ns |  0.9373 ns |  1.44 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7081 ns | 0.0022 ns | 0.0021 ns |  0.7078 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6551 ns | 0.0017 ns | 0.0015 ns |  0.6546 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6625 ns | 0.0027 ns | 0.0023 ns |  0.6631 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1372 ns | 0.0019 ns | 0.0018 ns |  1.1378 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1718 ns | 0.0026 ns | 0.0024 ns |  1.1718 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9560 ns | 0.0028 ns | 0.0026 ns |  0.9559 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0422 ns | 0.0041 ns | 0.0038 ns |  2.0412 ns |  1.80 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.4898 ns | 0.0047 ns | 0.0044 ns |  2.4901 ns |  2.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6700 ns | 0.0028 ns | 0.0027 ns |  0.6703 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7272 ns | 0.0016 ns | 0.0014 ns |  0.7271 ns |  1.09 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5757 ns | 0.0046 ns | 0.0043 ns |  0.5755 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6667 ns | 0.0030 ns | 0.0026 ns |  0.6660 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6668 ns | 0.0034 ns | 0.0032 ns |  0.6661 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9799 ns | 0.0023 ns | 0.0022 ns |  0.9787 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0920 ns | 0.0028 ns | 0.0026 ns |  1.0918 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0816 ns | 0.0027 ns | 0.0024 ns |  1.0818 ns |  1.10 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9414 ns | 0.0169 ns | 0.0158 ns |  1.9340 ns |  1.98 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9436 ns | 0.0034 ns | 0.0029 ns |  1.9427 ns |  1.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3374 ns | 0.0031 ns | 0.0029 ns |  1.3380 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3496 ns | 0.0029 ns | 0.0027 ns |  1.3492 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6888 ns | 0.0033 ns | 0.0031 ns |  0.6892 ns |  0.52 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.6985 ns | 0.0037 ns | 0.0035 ns |  1.6981 ns |  1.27 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7193 ns | 0.0158 ns | 0.0148 ns |  1.7098 ns |  1.29 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7369 ns | 0.0105 ns | 0.0098 ns |  1.7376 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8296 ns | 0.0018 ns | 0.0017 ns |  1.8292 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9481 ns | 0.0033 ns | 0.0031 ns |  0.9487 ns |  0.55 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.6735 ns | 0.0230 ns | 0.0215 ns |  2.6661 ns |  1.54 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.6670 ns | 0.0067 ns | 0.0062 ns |  2.6654 ns |  1.54 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6490 ns | 0.0018 ns | 0.0017 ns |  0.6483 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7025 ns | 0.0036 ns | 0.0032 ns |  0.7022 ns |  1.08 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5836 ns | 0.0018 ns | 0.0016 ns |  0.5840 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5448 ns | 0.0026 ns | 0.0024 ns |  0.5447 ns |  0.84 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5483 ns | 0.0019 ns | 0.0016 ns |  0.5481 ns |  0.84 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9718 ns | 0.0028 ns | 0.0027 ns |  0.9715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1675 ns | 0.0030 ns | 0.0028 ns |  1.1676 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9454 ns | 0.0019 ns | 0.0018 ns |  0.9452 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9294 ns | 0.0102 ns | 0.0096 ns |  1.9250 ns |  1.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9138 ns | 0.0045 ns | 0.0042 ns |  1.9139 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8795 ns | 0.0587 ns | 0.0549 ns |  1.8940 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3029 ns | 0.0028 ns | 0.0025 ns |  1.3035 ns |  0.69 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6021 ns | 0.0024 ns | 0.0022 ns |  0.6021 ns |  0.32 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7000 ns | 0.0032 ns | 0.0030 ns |  1.6999 ns |  0.91 |    0.03 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7418 ns | 0.0025 ns | 0.0024 ns |  1.7426 ns |  0.93 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8809 ns | 0.0037 ns | 0.0033 ns |  1.8813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7480 ns | 0.0023 ns | 0.0019 ns |  1.7480 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0983 ns | 0.0015 ns | 0.0013 ns |  1.0983 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.5626 ns | 0.0031 ns | 0.0029 ns |  2.5625 ns |  1.36 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.6088 ns | 0.0046 ns | 0.0041 ns |  2.6092 ns |  1.39 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6798 ns | 0.0021 ns | 0.0020 ns |  0.6801 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7401 ns | 0.0021 ns | 0.0019 ns |  0.7403 ns |  1.09 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5478 ns | 0.0025 ns | 0.0023 ns |  0.5470 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.4197 ns | 0.0015 ns | 0.0014 ns |  1.4199 ns |  2.09 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7347 ns | 0.0034 ns | 0.0032 ns |  0.7351 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9822 ns | 0.0035 ns | 0.0033 ns |  0.9817 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1846 ns | 0.0026 ns | 0.0025 ns |  1.1847 ns |  1.21 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2393 ns | 0.0020 ns | 0.0018 ns |  1.2390 ns |  1.26 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9350 ns | 0.0043 ns | 0.0040 ns |  1.9338 ns |  1.97 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9442 ns | 0.0081 ns | 0.0076 ns |  1.9450 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.3765 ns | 0.0018 ns | 0.0016 ns |  1.3763 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.3672 ns | 0.0021 ns | 0.0019 ns |  1.3673 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7176 ns | 0.0013 ns | 0.0011 ns |  0.7179 ns |  0.52 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7019 ns | 0.0031 ns | 0.0024 ns |  1.7020 ns |  1.24 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7099 ns | 0.0036 ns | 0.0034 ns |  1.7105 ns |  1.24 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.8911 ns | 0.0044 ns | 0.0039 ns |  1.8906 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  3.7153 ns | 0.0048 ns | 0.0043 ns |  3.7161 ns |  1.96 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1380 ns | 0.0027 ns | 0.0025 ns |  1.1377 ns |  0.60 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.5633 ns | 0.0053 ns | 0.0050 ns |  2.5631 ns |  1.36 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.5889 ns | 0.0047 ns | 0.0044 ns |  2.5896 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.6519 ns | 0.0026 ns | 0.0024 ns |  0.6515 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6704 ns | 0.0018 ns | 0.0016 ns |  0.6704 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7005 ns | 0.0018 ns | 0.0015 ns |  0.7004 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.5846 ns | 0.0037 ns | 0.0034 ns |  0.5841 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7227 ns | 0.0019 ns | 0.0018 ns |  0.7227 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.6824 ns | 0.0027 ns | 0.0025 ns |  0.6827 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.6708 ns | 0.0022 ns | 0.0021 ns |  0.6711 ns |  0.98 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.6569 ns | 0.0026 ns | 0.0022 ns |  0.6564 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  0.5962 ns | 0.0020 ns | 0.0017 ns |  0.5964 ns |  0.87 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  0.6997 ns | 0.0050 ns | 0.0047 ns |  0.6993 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.7605 ns | 0.0034 ns | 0.0030 ns |  1.7600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  2.3023 ns | 0.0068 ns | 0.0060 ns |  2.3040 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6969 ns | 0.0016 ns | 0.0015 ns |  1.6970 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6791 ns | 0.0026 ns | 0.0025 ns |  1.6796 ns |  0.95 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  2.1973 ns | 0.0028 ns | 0.0025 ns |  2.1974 ns |  1.25 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  3.1432 ns | 0.0069 ns | 0.0064 ns |  3.1422 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.0187 ns | 0.0058 ns | 0.0052 ns |  3.0171 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  2.6011 ns | 0.0074 ns | 0.0066 ns |  2.5999 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.8650 ns | 0.0063 ns | 0.0059 ns |  2.8649 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.8773 ns | 0.0069 ns | 0.0065 ns |  2.8775 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4817 ns | 0.0027 ns | 0.0024 ns |  1.4821 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.3758 ns | 0.0031 ns | 0.0024 ns |  1.3755 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7094 ns | 0.0017 ns | 0.0016 ns |  0.7097 ns |  0.48 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7030 ns | 0.0039 ns | 0.0036 ns |  1.7034 ns |  1.15 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7402 ns | 0.0024 ns | 0.0022 ns |  1.7405 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.0426 ns | 0.0052 ns | 0.0048 ns |  2.0428 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.0004 ns | 0.0025 ns | 0.0022 ns |  2.0004 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.6730 ns | 0.0026 ns | 0.0023 ns |  1.6731 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1383 ns | 0.0070 ns | 0.0062 ns |  3.1386 ns |  1.54 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.8903 ns | 0.0048 ns | 0.0045 ns |  2.8910 ns |  1.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.4903 ns | 0.0033 ns | 0.0030 ns |  3.4896 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4607 ns | 0.0066 ns | 0.0058 ns |  3.4607 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.5341 ns | 0.0162 ns | 0.0152 ns |  3.5396 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4529 ns | 0.0054 ns | 0.0050 ns |  3.4535 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4850 ns | 0.0157 ns | 0.0146 ns |  3.4819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.4043 ns | 0.0050 ns | 0.0046 ns |  3.4036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  3.5018 ns | 0.0045 ns | 0.0040 ns |  3.5015 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  3.4906 ns | 0.0063 ns | 0.0059 ns |  3.4917 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  3.7586 ns | 0.0058 ns | 0.0052 ns |  3.7602 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  3.7445 ns | 0.0087 ns | 0.0077 ns |  3.7460 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.6224 ns | 0.0047 ns | 0.0044 ns |  2.6230 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5633 ns | 0.0059 ns | 0.0055 ns |  2.5645 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.0504 ns | 0.0046 ns | 0.0043 ns |  3.0515 ns |  1.16 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5605 ns | 0.0071 ns | 0.0063 ns |  2.5590 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5869 ns | 0.0042 ns | 0.0039 ns |  2.5878 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  3.6820 ns | 0.0048 ns | 0.0042 ns |  3.6818 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.1171 ns | 0.0055 ns | 0.0043 ns |  4.1171 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.7675 ns | 0.0044 ns | 0.0041 ns |  3.7678 ns |  1.02 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.0600 ns | 0.0082 ns | 0.0073 ns |  4.0601 ns |  1.10 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.0690 ns | 0.0086 ns | 0.0080 ns |  4.0694 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.8513 ns | 0.0135 ns | 0.0126 ns | 12.8521 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.0043 ns | 0.0112 ns | 0.0099 ns | 13.0069 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8143 ns | 0.0115 ns | 0.0107 ns |  5.8136 ns |  0.45 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.3988 ns | 0.0191 ns | 0.0179 ns | 13.4000 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3493 ns | 0.0074 ns | 0.0065 ns | 13.3503 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.8295 ns | 0.0155 ns | 0.0130 ns | 23.8253 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.0818 ns | 0.0285 ns | 0.0252 ns | 24.0914 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.1737 ns | 0.0144 ns | 0.0135 ns | 13.1733 ns |  0.55 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.0079 ns | 0.0199 ns | 0.0186 ns | 24.0109 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.6804 ns | 0.0399 ns | 0.0354 ns | 24.6879 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6696 ns | 0.0022 ns | 0.0020 ns |  0.6691 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6856 ns | 0.0030 ns | 0.0028 ns |  0.6849 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7611 ns | 0.0023 ns | 0.0021 ns |  0.7614 ns |  1.14 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6841 ns | 0.0044 ns | 0.0041 ns |  0.6843 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7047 ns | 0.0037 ns | 0.0033 ns |  0.7043 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4737 ns | 0.0042 ns | 0.0039 ns |  1.4738 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6423 ns | 0.0027 ns | 0.0025 ns |  1.6418 ns |  1.11 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4254 ns | 0.0038 ns | 0.0036 ns |  1.4250 ns |  0.97 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.0464 ns | 0.0043 ns | 0.0040 ns |  2.0459 ns |  1.39 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6613 ns | 0.0038 ns | 0.0034 ns |  1.6624 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.0194 ns | 0.0084 ns | 0.0078 ns | 10.0197 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.0733 ns | 0.0188 ns | 0.0167 ns | 14.0704 ns |  1.40 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.8287 ns | 0.0387 ns | 0.0362 ns | 14.8290 ns |  1.48 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.1777 ns | 0.0110 ns | 0.0103 ns | 13.1780 ns |  1.32 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.7082 ns | 0.0174 ns | 0.0162 ns | 13.7078 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 46.6497 ns | 0.1082 ns | 0.1013 ns | 46.6174 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 39.4859 ns | 0.0694 ns | 0.0650 ns | 39.4724 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.9905 ns | 0.0143 ns | 0.0134 ns | 10.9922 ns |  0.24 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.8109 ns | 0.1366 ns | 0.1278 ns | 46.8020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.8379 ns | 0.0734 ns | 0.0686 ns | 46.8359 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4057 ns | 0.0030 ns | 0.0028 ns |  1.4058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3931 ns | 0.0043 ns | 0.0040 ns |  1.3920 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7444 ns | 0.0024 ns | 0.0022 ns |  0.7437 ns |  0.53 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  2.2053 ns | 0.0026 ns | 0.0024 ns |  2.2054 ns |  1.57 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7356 ns | 0.0036 ns | 0.0032 ns |  1.7348 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.8833 ns | 0.0034 ns | 0.0030 ns |  1.8830 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.8889 ns | 0.0035 ns | 0.0029 ns |  1.8890 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0839 ns | 0.0021 ns | 0.0020 ns |  1.0842 ns |  0.58 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.5569 ns | 0.0044 ns | 0.0042 ns |  2.5575 ns |  1.36 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.6264 ns | 0.0058 ns | 0.0054 ns |  2.6264 ns |  1.39 |    0.00 |     - |     - |     - |         - |
