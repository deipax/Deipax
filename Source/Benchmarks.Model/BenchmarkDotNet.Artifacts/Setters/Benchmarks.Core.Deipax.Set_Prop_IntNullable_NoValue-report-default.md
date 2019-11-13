
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
             FromBool | .NET Core 2.0 |  0.9490 ns | 0.0030 ns | 0.0028 ns |  0.9490 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6703 ns | 0.0033 ns | 0.0031 ns |  0.6714 ns |  0.71 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.8576 ns | 0.0116 ns | 0.0108 ns |  0.8509 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9303 ns | 0.0027 ns | 0.0025 ns |  0.9303 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9215 ns | 0.0045 ns | 0.0040 ns |  0.9203 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1745 ns | 0.0033 ns | 0.0031 ns |  1.1753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9149 ns | 0.0027 ns | 0.0024 ns |  0.9151 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9417 ns | 0.0014 ns | 0.0013 ns |  0.9418 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0600 ns | 0.0052 ns | 0.0046 ns |  2.0602 ns |  1.75 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1225 ns | 0.0036 ns | 0.0034 ns |  2.1228 ns |  1.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9435 ns | 0.0025 ns | 0.0023 ns |  0.9439 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6351 ns | 0.0031 ns | 0.0029 ns |  0.6345 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6571 ns | 0.0020 ns | 0.0019 ns |  0.6567 ns |  0.70 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.3673 ns | 0.0026 ns | 0.0023 ns |  1.3678 ns |  1.45 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.9175 ns | 0.0039 ns | 0.0034 ns |  0.9169 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1769 ns | 0.0036 ns | 0.0034 ns |  1.1775 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.0517 ns | 0.0022 ns | 0.0020 ns |  1.0523 ns |  0.89 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1669 ns | 0.0025 ns | 0.0021 ns |  1.1669 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9215 ns | 0.0018 ns | 0.0016 ns |  1.9210 ns |  1.63 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9312 ns | 0.0192 ns | 0.0180 ns |  1.9411 ns |  1.64 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7154 ns | 0.0032 ns | 0.0030 ns |  0.7146 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5528 ns | 0.0022 ns | 0.0021 ns |  0.5527 ns |  0.77 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6660 ns | 0.0026 ns | 0.0025 ns |  0.6660 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.9422 ns | 0.0021 ns | 0.0019 ns |  0.9422 ns |  1.32 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.9399 ns | 0.0036 ns | 0.0034 ns |  0.9395 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.5033 ns | 0.0559 ns | 0.1613 ns |  1.4964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.8832 ns | 0.0035 ns | 0.0033 ns |  0.8834 ns |  0.60 |    0.07 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.8831 ns | 0.0033 ns | 0.0029 ns |  0.8827 ns |  0.60 |    0.07 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9311 ns | 0.0023 ns | 0.0022 ns |  1.9316 ns |  1.31 |    0.14 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9359 ns | 0.0040 ns | 0.0037 ns |  1.9356 ns |  1.31 |    0.14 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9483 ns | 0.0025 ns | 0.0024 ns |  0.9484 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6195 ns | 0.0028 ns | 0.0025 ns |  0.6196 ns |  0.65 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6310 ns | 0.0061 ns | 0.0057 ns |  0.6287 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.9612 ns | 0.0029 ns | 0.0026 ns |  0.9612 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.9508 ns | 0.0037 ns | 0.0035 ns |  0.9518 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1795 ns | 0.0034 ns | 0.0032 ns |  1.1793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9150 ns | 0.0025 ns | 0.0024 ns |  0.9153 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9375 ns | 0.0028 ns | 0.0026 ns |  0.9377 ns |  0.79 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9258 ns | 0.0059 ns | 0.0055 ns |  1.9249 ns |  1.63 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9251 ns | 0.0035 ns | 0.0033 ns |  1.9246 ns |  1.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7193 ns | 0.0026 ns | 0.0024 ns |  0.7193 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6784 ns | 0.0026 ns | 0.0025 ns |  0.6783 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.8543 ns | 0.0020 ns | 0.0018 ns |  0.8543 ns |  1.19 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  0.9242 ns | 0.0030 ns | 0.0027 ns |  0.9242 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.9213 ns | 0.0025 ns | 0.0023 ns |  0.9215 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.2005 ns | 0.0032 ns | 0.0030 ns |  1.2001 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.0826 ns | 0.0019 ns | 0.0017 ns |  1.0825 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.2057 ns | 0.0124 ns | 0.0116 ns |  1.1988 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9206 ns | 0.0086 ns | 0.0080 ns |  1.9229 ns |  1.60 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9089 ns | 0.0021 ns | 0.0020 ns |  1.9086 ns |  1.59 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9454 ns | 0.0023 ns | 0.0022 ns |  0.9455 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6360 ns | 0.0024 ns | 0.0022 ns |  0.6360 ns |  0.67 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6778 ns | 0.0027 ns | 0.0026 ns |  0.6772 ns |  0.72 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.9219 ns | 0.0022 ns | 0.0020 ns |  0.9220 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.9195 ns | 0.0019 ns | 0.0017 ns |  0.9194 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1817 ns | 0.0035 ns | 0.0030 ns |  1.1826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0917 ns | 0.0033 ns | 0.0029 ns |  1.0916 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1302 ns | 0.0018 ns | 0.0016 ns |  1.1302 ns |  0.96 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9071 ns | 0.0031 ns | 0.0027 ns |  1.9067 ns |  1.61 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9101 ns | 0.0037 ns | 0.0031 ns |  1.9106 ns |  1.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7162 ns | 0.0030 ns | 0.0025 ns |  0.7155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.5719 ns | 0.0013 ns | 0.0011 ns |  0.5723 ns |  0.80 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6741 ns | 0.0037 ns | 0.0029 ns |  0.6748 ns |  0.94 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.9597 ns | 0.0033 ns | 0.0031 ns |  0.9604 ns |  1.34 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.9410 ns | 0.0033 ns | 0.0030 ns |  0.9410 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.7197 ns | 0.0025 ns | 0.0023 ns |  0.7199 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.6791 ns | 0.0019 ns | 0.0017 ns |  0.6789 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.8716 ns | 0.0020 ns | 0.0019 ns |  0.8710 ns |  1.21 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  0.7175 ns | 0.0019 ns | 0.0018 ns |  0.7173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  0.7166 ns | 0.0023 ns | 0.0022 ns |  0.7165 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4288 ns | 0.0028 ns | 0.0026 ns |  1.4295 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3454 ns | 0.0042 ns | 0.0033 ns |  1.3458 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7164 ns | 0.0011 ns | 0.0010 ns |  0.7166 ns |  0.50 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7289 ns | 0.0032 ns | 0.0030 ns |  1.7298 ns |  1.21 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7353 ns | 0.0022 ns | 0.0017 ns |  1.7350 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0111 ns | 0.0034 ns | 0.0032 ns |  2.0119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.8715 ns | 0.0031 ns | 0.0027 ns |  1.8706 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0556 ns | 0.0092 ns | 0.0086 ns |  1.0506 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.0369 ns | 0.0033 ns | 0.0030 ns |  2.0364 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9114 ns | 0.0036 ns | 0.0032 ns |  1.9116 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8074 ns | 0.0047 ns | 0.0039 ns |  1.8068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6550 ns | 0.0033 ns | 0.0031 ns |  1.6551 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6814 ns | 0.0041 ns | 0.0038 ns |  1.6798 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7608 ns | 0.0035 ns | 0.0029 ns |  1.7611 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7656 ns | 0.0032 ns | 0.0030 ns |  1.7652 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7983 ns | 0.0027 ns | 0.0024 ns |  1.7983 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7997 ns | 0.0053 ns | 0.0050 ns |  1.7992 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7961 ns | 0.0027 ns | 0.0025 ns |  1.7959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.8522 ns | 0.0033 ns | 0.0029 ns |  1.8517 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.8568 ns | 0.0027 ns | 0.0022 ns |  1.8571 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8872 ns | 0.0034 ns | 0.0032 ns |  1.8879 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6920 ns | 0.0028 ns | 0.0027 ns |  1.6912 ns |  0.90 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6090 ns | 0.0120 ns | 0.0112 ns |  1.6044 ns |  0.85 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7683 ns | 0.0020 ns | 0.0018 ns |  1.7682 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7388 ns | 0.0038 ns | 0.0035 ns |  1.7384 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.7938 ns | 0.0030 ns | 0.0028 ns |  1.7939 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7211 ns | 0.0033 ns | 0.0031 ns |  1.7214 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7871 ns | 0.0019 ns | 0.0017 ns |  1.7870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.2606 ns | 0.0048 ns | 0.0040 ns |  2.2617 ns |  1.26 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9439 ns | 0.0019 ns | 0.0018 ns |  1.9443 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5094 ns | 0.0060 ns | 0.0050 ns |  3.5079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4392 ns | 0.0140 ns | 0.0124 ns |  3.4422 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.4505 ns | 0.0182 ns | 0.0170 ns |  3.4402 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4371 ns | 0.0055 ns | 0.0052 ns |  3.4383 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4160 ns | 0.0061 ns | 0.0054 ns |  3.4160 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8783 ns | 0.0029 ns | 0.0025 ns |  1.8781 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7398 ns | 0.0019 ns | 0.0018 ns |  1.7399 ns |  0.93 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.6971 ns | 0.0047 ns | 0.0044 ns |  1.6963 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  2.0725 ns | 0.0030 ns | 0.0026 ns |  2.0718 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9149 ns | 0.0029 ns | 0.0028 ns |  1.9150 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.6196 ns | 0.0130 ns | 0.0122 ns |  2.6215 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5468 ns | 0.0049 ns | 0.0043 ns |  2.5470 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.8404 ns | 0.0048 ns | 0.0043 ns |  2.8403 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.5545 ns | 0.0039 ns | 0.0037 ns |  2.5543 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5690 ns | 0.0058 ns | 0.0055 ns |  2.5688 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9382 ns | 0.0044 ns | 0.0041 ns |  1.9375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9094 ns | 0.0024 ns | 0.0021 ns |  1.9094 ns |  0.98 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.8758 ns | 0.0114 ns | 0.0106 ns |  1.8722 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1034 ns | 0.0030 ns | 0.0028 ns |  2.1047 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1456 ns | 0.0027 ns | 0.0025 ns |  2.1456 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.9653 ns | 0.0093 ns | 0.0087 ns | 12.9667 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.2787 ns | 0.0129 ns | 0.0120 ns | 13.2786 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8389 ns | 0.0064 ns | 0.0060 ns |  5.8382 ns |  0.45 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 |  7.1906 ns | 0.0094 ns | 0.0083 ns |  7.1920 ns |  0.55 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  7.2167 ns | 0.0093 ns | 0.0087 ns |  7.2161 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.5661 ns | 0.0565 ns | 0.0528 ns |  8.5937 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.9660 ns | 0.0083 ns | 0.0078 ns |  8.9647 ns |  1.05 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.4988 ns | 0.0164 ns | 0.0145 ns |  2.4931 ns |  0.29 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.8564 ns | 0.0211 ns | 0.0187 ns |  8.8527 ns |  1.03 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.9418 ns | 0.0447 ns | 0.0418 ns |  8.9578 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.4978 ns | 0.0037 ns | 0.0034 ns |  1.4986 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6791 ns | 0.0018 ns | 0.0015 ns |  0.6792 ns |  0.45 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.6665 ns | 0.0083 ns | 0.0078 ns |  0.6636 ns |  0.45 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7276 ns | 0.0025 ns | 0.0022 ns |  0.7280 ns |  0.49 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7266 ns | 0.0025 ns | 0.0023 ns |  0.7272 ns |  0.49 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4518 ns | 0.0033 ns | 0.0031 ns |  1.4522 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6564 ns | 0.0034 ns | 0.0032 ns |  1.6564 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4942 ns | 0.0034 ns | 0.0032 ns |  1.4939 ns |  1.03 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.8235 ns | 0.0059 ns | 0.0055 ns |  1.8228 ns |  1.26 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.8369 ns | 0.0034 ns | 0.0032 ns |  1.8372 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0521 ns | 0.0228 ns | 0.0214 ns |  3.0448 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8174 ns | 0.0034 ns | 0.0030 ns |  2.8175 ns |  0.92 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.6651 ns | 0.0043 ns | 0.0040 ns |  2.6659 ns |  0.87 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.8379 ns | 0.0053 ns | 0.0049 ns |  2.8385 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8635 ns | 0.0173 ns | 0.0161 ns |  2.8670 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  2.2908 ns | 0.0021 ns | 0.0020 ns |  2.2913 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8680 ns | 0.0056 ns | 0.0049 ns |  1.8670 ns |  0.82 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9097 ns | 0.0108 ns | 0.0101 ns |  1.9063 ns |  0.83 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  2.2973 ns | 0.0031 ns | 0.0029 ns |  2.2978 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8055 ns | 0.0032 ns | 0.0030 ns |  1.8054 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.0438 ns | 0.0021 ns | 0.0020 ns |  1.0444 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6050 ns | 0.0024 ns | 0.0022 ns |  0.6056 ns |  0.58 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7029 ns | 0.0042 ns | 0.0037 ns |  0.7021 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7063 ns | 0.0031 ns | 0.0029 ns |  0.7065 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.7065 ns | 0.0022 ns | 0.0019 ns |  0.7062 ns |  0.68 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.0155 ns | 0.0036 ns | 0.0032 ns |  1.0148 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.0747 ns | 0.0025 ns | 0.0022 ns |  1.0746 ns |  1.06 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0463 ns | 0.0023 ns | 0.0021 ns |  1.0466 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9053 ns | 0.0039 ns | 0.0036 ns |  1.9051 ns |  1.88 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9079 ns | 0.0029 ns | 0.0027 ns |  1.9086 ns |  1.88 |    0.01 |     - |     - |     - |         - |
