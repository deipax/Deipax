
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
             FromBool | .NET Core 2.0 |  0.9413 ns | 0.0035 ns | 0.0033 ns |  0.9406 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  1.1694 ns | 0.0028 ns | 0.0026 ns |  1.1687 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9462 ns | 0.0046 ns | 0.0043 ns |  0.9465 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.8751 ns | 0.0023 ns | 0.0019 ns |  0.8751 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  1.1704 ns | 0.0034 ns | 0.0030 ns |  1.1699 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.2006 ns | 0.0043 ns | 0.0040 ns |  1.2016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.6636 ns | 0.0028 ns | 0.0023 ns |  1.6635 ns |  1.39 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.4244 ns | 0.0152 ns | 0.0143 ns |  1.4253 ns |  1.19 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0144 ns | 0.0034 ns | 0.0032 ns |  2.0153 ns |  1.68 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1464 ns | 0.0226 ns | 0.0212 ns |  2.1544 ns |  1.79 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6981 ns | 0.0050 ns | 0.0044 ns |  0.6991 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.9640 ns | 0.0031 ns | 0.0028 ns |  0.9649 ns |  1.38 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7253 ns | 0.0178 ns | 0.0166 ns |  0.7290 ns |  1.04 |    0.03 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6256 ns | 0.0025 ns | 0.0021 ns |  0.6264 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.7247 ns | 0.0033 ns | 0.0031 ns |  0.7247 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.6917 ns | 0.0028 ns | 0.0026 ns |  0.6913 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9701 ns | 0.0030 ns | 0.0028 ns |  0.9694 ns |  1.40 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.8538 ns | 0.0180 ns | 0.0168 ns |  0.8498 ns |  1.23 |    0.03 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9150 ns | 0.0029 ns | 0.0028 ns |  0.9154 ns |  1.32 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.0163 ns | 0.0124 ns | 0.0116 ns |  1.0121 ns |  1.47 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.5832 ns | 0.0034 ns | 0.0032 ns |  0.5826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.9492 ns | 0.0053 ns | 0.0050 ns |  0.9488 ns |  1.63 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7386 ns | 0.0294 ns | 0.0275 ns |  0.7231 ns |  1.27 |    0.05 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5855 ns | 0.0029 ns | 0.0027 ns |  0.5851 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.7052 ns | 0.0128 ns | 0.0120 ns |  0.6999 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.0844 ns | 0.0058 ns | 0.0052 ns |  1.0859 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1841 ns | 0.0023 ns | 0.0020 ns |  1.1850 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.0920 ns | 0.0101 ns | 0.0079 ns |  1.0927 ns |  1.01 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9863 ns | 0.0044 ns | 0.0037 ns |  1.9861 ns |  1.83 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.0173 ns | 0.0032 ns | 0.0027 ns |  2.0175 ns |  1.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7198 ns | 0.0040 ns | 0.0037 ns |  0.7200 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7100 ns | 0.0023 ns | 0.0022 ns |  0.7099 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7612 ns | 0.0163 ns | 0.0136 ns |  0.7626 ns |  1.06 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6582 ns | 0.0036 ns | 0.0034 ns |  0.6583 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9401 ns | 0.0031 ns | 0.0029 ns |  0.9410 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0634 ns | 0.0026 ns | 0.0024 ns |  1.0640 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1826 ns | 0.0034 ns | 0.0032 ns |  1.1822 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1547 ns | 0.0584 ns | 0.0573 ns |  1.1373 ns |  1.09 |    0.06 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9837 ns | 0.0030 ns | 0.0027 ns |  1.9831 ns |  1.87 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.8925 ns | 0.0246 ns | 0.0230 ns |  1.9113 ns |  1.78 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6219 ns | 0.0033 ns | 0.0028 ns |  0.6214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7046 ns | 0.0026 ns | 0.0024 ns |  0.7049 ns |  1.13 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6740 ns | 0.0387 ns | 0.0489 ns |  0.6637 ns |  1.09 |    0.08 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6561 ns | 0.0033 ns | 0.0029 ns |  0.6560 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.9383 ns | 0.0028 ns | 0.0027 ns |  0.9391 ns |  1.51 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0671 ns | 0.0033 ns | 0.0031 ns |  1.0669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.2082 ns | 0.0019 ns | 0.0018 ns |  1.2083 ns |  1.13 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.2437 ns | 0.0296 ns | 0.0262 ns |  1.2435 ns |  1.17 |    0.03 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9710 ns | 0.0144 ns | 0.0127 ns |  1.9664 ns |  1.85 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.9507 ns | 0.0037 ns | 0.0033 ns |  2.9515 ns |  2.77 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6929 ns | 0.0027 ns | 0.0025 ns |  0.6927 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9638 ns | 0.0031 ns | 0.0027 ns |  0.9643 ns |  1.39 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7369 ns | 0.0141 ns | 0.0132 ns |  0.7307 ns |  1.06 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6365 ns | 0.0047 ns | 0.0044 ns |  0.6362 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7392 ns | 0.0032 ns | 0.0028 ns |  0.7391 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0726 ns | 0.0026 ns | 0.0021 ns |  1.0728 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.4194 ns | 0.0023 ns | 0.0022 ns |  1.4195 ns |  1.32 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2105 ns | 0.0071 ns | 0.0060 ns |  1.2125 ns |  1.13 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9626 ns | 0.0080 ns | 0.0071 ns |  1.9598 ns |  1.83 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0001 ns | 0.0033 ns | 0.0029 ns |  2.0001 ns |  1.86 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5546 ns | 0.0022 ns | 0.0021 ns |  0.5546 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.9335 ns | 0.0025 ns | 0.0021 ns |  0.9335 ns |  1.68 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7318 ns | 0.0105 ns | 0.0093 ns |  0.7290 ns |  1.32 |    0.02 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6007 ns | 0.0042 ns | 0.0035 ns |  0.6005 ns |  1.08 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7216 ns | 0.0032 ns | 0.0030 ns |  0.7209 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.0417 ns | 0.0031 ns | 0.0027 ns |  1.0416 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.5459 ns | 0.0023 ns | 0.0021 ns |  1.5459 ns |  1.48 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1587 ns | 0.0030 ns | 0.0028 ns |  1.1585 ns |  1.11 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9430 ns | 0.0032 ns | 0.0030 ns |  1.9431 ns |  1.87 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9927 ns | 0.0142 ns | 0.0132 ns |  1.9919 ns |  1.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7199 ns | 0.0040 ns | 0.0034 ns |  0.7213 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.8967 ns | 0.0040 ns | 0.0037 ns |  0.8965 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9686 ns | 0.0033 ns | 0.0029 ns |  0.9687 ns |  1.35 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.6875 ns | 0.0047 ns | 0.0039 ns |  0.6868 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.8803 ns | 0.0034 ns | 0.0032 ns |  0.8798 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0920 ns | 0.0040 ns | 0.0038 ns |  1.0910 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1939 ns | 0.0030 ns | 0.0028 ns |  1.1931 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.2220 ns | 0.0080 ns | 0.0071 ns |  1.2227 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9457 ns | 0.0032 ns | 0.0028 ns |  1.9462 ns |  1.78 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9644 ns | 0.0035 ns | 0.0033 ns |  1.9652 ns |  1.80 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6374 ns | 0.0029 ns | 0.0024 ns |  0.6376 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.8984 ns | 0.0022 ns | 0.0020 ns |  0.8986 ns |  1.41 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.9429 ns | 0.0123 ns | 0.0115 ns |  0.9378 ns |  1.48 |    0.02 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7285 ns | 0.0026 ns | 0.0025 ns |  0.7285 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6794 ns | 0.0027 ns | 0.0021 ns |  0.6794 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7087 ns | 0.0117 ns | 0.0098 ns |  1.7110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.6438 ns | 0.0111 ns | 0.0104 ns |  1.6413 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6867 ns | 0.0029 ns | 0.0026 ns |  1.6868 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.3510 ns | 0.0093 ns | 0.0082 ns |  2.3487 ns |  1.38 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.3345 ns | 0.0041 ns | 0.0038 ns |  2.3348 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9262 ns | 0.0027 ns | 0.0025 ns |  0.9261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.1442 ns | 0.0150 ns | 0.0140 ns |  1.1412 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9693 ns | 0.0037 ns | 0.0031 ns |  0.9696 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  0.7114 ns | 0.0126 ns | 0.0118 ns |  0.7045 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  0.9051 ns | 0.0082 ns | 0.0073 ns |  0.9066 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.9795 ns | 0.0018 ns | 0.0016 ns |  1.9796 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8731 ns | 0.0035 ns | 0.0031 ns |  1.8734 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.9076 ns | 0.0023 ns | 0.0021 ns |  1.9078 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.3772 ns | 0.0290 ns | 0.0271 ns |  2.3888 ns |  1.20 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.3302 ns | 0.0053 ns | 0.0049 ns |  2.3300 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.7313 ns | 0.0070 ns | 0.0062 ns |  0.7298 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.7559 ns | 0.0124 ns | 0.0116 ns |  0.7523 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.7522 ns | 0.0132 ns | 0.0124 ns |  0.7473 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.7398 ns | 0.0043 ns | 0.0040 ns |  0.7389 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.8838 ns | 0.0033 ns | 0.0031 ns |  0.8842 ns |  1.21 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.0974 ns | 0.0025 ns | 0.0023 ns |  1.0981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.1710 ns | 0.0043 ns | 0.0038 ns |  1.1706 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7762 ns | 0.0028 ns | 0.0026 ns |  1.7764 ns |  1.62 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9484 ns | 0.0023 ns | 0.0021 ns |  1.9476 ns |  1.78 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9596 ns | 0.0100 ns | 0.0094 ns |  1.9617 ns |  1.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.9539 ns | 0.0037 ns | 0.0035 ns |  0.9532 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9015 ns | 0.0030 ns | 0.0026 ns |  0.9016 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.7054 ns | 0.0029 ns | 0.0027 ns |  0.7051 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.6154 ns | 0.0018 ns | 0.0017 ns |  0.6160 ns |  0.65 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.6554 ns | 0.0026 ns | 0.0021 ns |  0.6555 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.4025 ns | 0.0093 ns | 0.0083 ns |  1.3995 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.1533 ns | 0.0020 ns | 0.0018 ns |  1.1529 ns |  0.82 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.2384 ns | 0.0195 ns | 0.0182 ns |  1.2269 ns |  0.88 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.2147 ns | 0.0191 ns | 0.0178 ns |  1.2206 ns |  0.87 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.2404 ns | 0.0087 ns | 0.0073 ns |  1.2396 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  8.5258 ns | 0.0102 ns | 0.0096 ns |  8.5241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  8.6521 ns | 0.0084 ns | 0.0078 ns |  8.6533 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.3249 ns | 0.1089 ns | 0.1019 ns |  5.2988 ns |  0.62 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  8.7888 ns | 0.0145 ns | 0.0135 ns |  8.7906 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  8.6741 ns | 0.0147 ns | 0.0137 ns |  8.6732 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.0031 ns | 0.0333 ns | 0.0296 ns | 23.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.0615 ns | 0.2188 ns | 0.1827 ns | 22.9740 ns |  1.00 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 18.0755 ns | 0.1497 ns | 0.1400 ns | 18.1629 ns |  0.79 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 22.9616 ns | 0.0274 ns | 0.0257 ns | 22.9568 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 22.9960 ns | 0.0372 ns | 0.0348 ns | 22.9892 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6907 ns | 0.0020 ns | 0.0018 ns |  0.6907 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7401 ns | 0.0421 ns | 0.0563 ns |  0.7117 ns |  1.11 |    0.09 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  1.4877 ns | 0.0037 ns | 0.0034 ns |  1.4873 ns |  2.15 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7030 ns | 0.0154 ns | 0.0144 ns |  0.7098 ns |  1.02 |    0.02 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8851 ns | 0.0053 ns | 0.0047 ns |  0.8853 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.5017 ns | 0.0107 ns | 0.0100 ns |  1.5026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6800 ns | 0.0581 ns | 0.0543 ns |  1.6928 ns |  1.12 |    0.04 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5344 ns | 0.0093 ns | 0.0087 ns |  1.5371 ns |  1.02 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6691 ns | 0.0055 ns | 0.0051 ns |  1.6686 ns |  1.11 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6531 ns | 0.0025 ns | 0.0022 ns |  1.6537 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.6279 ns | 0.0102 ns | 0.0090 ns | 10.6278 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.6679 ns | 0.0399 ns | 0.0354 ns | 14.6602 ns |  1.38 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.4801 ns | 0.1487 ns | 0.1391 ns | 15.5633 ns |  1.46 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.2502 ns | 0.0141 ns | 0.0110 ns | 13.2481 ns |  1.25 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.4869 ns | 0.0197 ns | 0.0165 ns | 13.4846 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 57.4491 ns | 0.0673 ns | 0.0630 ns | 57.4463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 63.6326 ns | 0.5042 ns | 0.4717 ns | 63.5052 ns |  1.11 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 44.3566 ns | 0.0511 ns | 0.0399 ns | 44.3721 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 58.2993 ns | 0.0708 ns | 0.0628 ns | 58.2855 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 59.9503 ns | 0.0824 ns | 0.0730 ns | 59.9339 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7166 ns | 0.0020 ns | 0.0018 ns |  0.7169 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.9320 ns | 0.0121 ns | 0.0113 ns |  0.9289 ns |  1.30 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7338 ns | 0.0060 ns | 0.0056 ns |  0.7332 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.6065 ns | 0.0033 ns | 0.0031 ns |  0.6066 ns |  0.85 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6950 ns | 0.0023 ns | 0.0022 ns |  0.6952 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.0759 ns | 0.0019 ns | 0.0017 ns |  1.0756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1575 ns | 0.0405 ns | 0.0379 ns |  1.1659 ns |  1.08 |    0.04 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.2107 ns | 0.0166 ns | 0.0155 ns |  1.2171 ns |  1.12 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9458 ns | 0.0021 ns | 0.0020 ns |  1.9451 ns |  1.81 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2856 ns | 0.0054 ns | 0.0050 ns |  2.2856 ns |  2.12 |    0.00 |     - |     - |     - |         - |
