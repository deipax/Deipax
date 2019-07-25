
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.9422 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9040 ns | 0.0024 ns | 0.0021 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1501 ns | 0.0109 ns | 0.0102 ns |  1.22 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9004 ns | 0.0040 ns | 0.0033 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9177 ns | 0.0062 ns | 0.0058 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1966 ns | 0.0032 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.2065 ns | 0.0049 ns | 0.0046 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.4396 ns | 0.0032 ns | 0.0028 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0136 ns | 0.0037 ns | 0.0031 ns |  1.68 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.8225 ns | 0.0118 ns | 0.0110 ns |  2.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6940 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6449 ns | 0.0021 ns | 0.0019 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6413 ns | 0.0034 ns | 0.0032 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6236 ns | 0.0012 ns | 0.0009 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6355 ns | 0.0040 ns | 0.0031 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.7006 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9227 ns | 0.0020 ns | 0.0018 ns |  1.32 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.8853 ns | 0.0032 ns | 0.0028 ns |  1.26 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9160 ns | 0.0177 ns | 0.0165 ns |  1.31 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.9551 ns | 0.0050 ns | 0.0047 ns |  1.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.6909 ns | 0.0067 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5966 ns | 0.0030 ns | 0.0024 ns |  0.86 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6747 ns | 0.0066 ns | 0.0059 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.6596 ns | 0.0019 ns | 0.0017 ns |  0.95 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.6579 ns | 0.0016 ns | 0.0013 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  2.0444 ns | 0.0060 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.0892 ns | 0.0034 ns | 0.0030 ns |  0.53 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1161 ns | 0.0021 ns | 0.0018 ns |  0.55 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.2355 ns | 0.0031 ns | 0.0029 ns |  1.09 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9925 ns | 0.0023 ns | 0.0020 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7135 ns | 0.0027 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6780 ns | 0.0031 ns | 0.0029 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.9131 ns | 0.0016 ns | 0.0015 ns |  1.28 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.6014 ns | 0.0126 ns | 0.0117 ns |  0.84 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5864 ns | 0.0031 ns | 0.0029 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.5113 ns | 0.0131 ns | 0.0123 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.0690 ns | 0.0033 ns | 0.0029 ns |  0.71 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1497 ns | 0.0046 ns | 0.0043 ns |  0.76 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9927 ns | 0.0041 ns | 0.0038 ns |  1.32 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9955 ns | 0.0051 ns | 0.0040 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.6030 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6818 ns | 0.0104 ns | 0.0097 ns |  1.13 |    0.02 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.9135 ns | 0.0128 ns | 0.0120 ns |  1.51 |    0.02 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6654 ns | 0.0217 ns | 0.0203 ns |  1.11 |    0.03 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6565 ns | 0.0034 ns | 0.0032 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.0661 ns | 0.0058 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.2161 ns | 0.0043 ns | 0.0036 ns |  1.14 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1732 ns | 0.0026 ns | 0.0020 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9790 ns | 0.0039 ns | 0.0036 ns |  1.86 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9782 ns | 0.0181 ns | 0.0170 ns |  1.86 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.7026 ns | 0.0026 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6559 ns | 0.0099 ns | 0.0092 ns |  0.93 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6729 ns | 0.0033 ns | 0.0031 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6427 ns | 0.0044 ns | 0.0042 ns |  0.91 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6468 ns | 0.0120 ns | 0.0112 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0608 ns | 0.0039 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1932 ns | 0.0032 ns | 0.0030 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1732 ns | 0.0032 ns | 0.0030 ns |  1.11 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9972 ns | 0.0088 ns | 0.0074 ns |  1.88 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9829 ns | 0.0030 ns | 0.0025 ns |  1.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.5526 ns | 0.0021 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7483 ns | 0.0408 ns | 0.0486 ns |  1.35 |    0.10 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.8933 ns | 0.0019 ns | 0.0018 ns |  1.62 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6421 ns | 0.0058 ns | 0.0052 ns |  1.16 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.6096 ns | 0.0023 ns | 0.0020 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.0430 ns | 0.0054 ns | 0.0045 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.1907 ns | 0.0118 ns | 0.0105 ns |  1.14 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1373 ns | 0.0042 ns | 0.0040 ns |  1.09 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9510 ns | 0.0037 ns | 0.0033 ns |  1.87 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.5067 ns | 0.0043 ns | 0.0034 ns |  2.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7070 ns | 0.0046 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7270 ns | 0.0012 ns | 0.0010 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7316 ns | 0.0031 ns | 0.0029 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7918 ns | 0.0268 ns | 0.0251 ns |  1.12 |    0.03 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7486 ns | 0.0034 ns | 0.0032 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1737 ns | 0.0021 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.3021 ns | 0.0100 ns | 0.0094 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.2287 ns | 0.0082 ns | 0.0077 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.0793 ns | 0.0465 ns | 0.0435 ns |  1.77 |    0.04 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.0194 ns | 0.0072 ns | 0.0060 ns |  1.72 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.6630 ns | 0.0039 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.8272 ns | 0.0032 ns | 0.0030 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.7172 ns | 0.0029 ns | 0.0027 ns |  1.08 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7501 ns | 0.0170 ns | 0.0159 ns |  1.13 |    0.02 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7594 ns | 0.0046 ns | 0.0041 ns |  1.15 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.0805 ns | 0.0682 ns | 0.1511 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7108 ns | 0.0054 ns | 0.0051 ns |  0.83 |    0.08 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6973 ns | 0.0055 ns | 0.0051 ns |  0.82 |    0.08 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.3615 ns | 0.0048 ns | 0.0040 ns |  1.14 |    0.12 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.3655 ns | 0.0067 ns | 0.0059 ns |  1.15 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.9291 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9117 ns | 0.0015 ns | 0.0012 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.9514 ns | 0.0022 ns | 0.0020 ns |  1.02 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.1830 ns | 0.0049 ns | 0.0044 ns |  1.27 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.9365 ns | 0.0108 ns | 0.0101 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.0190 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.1105 ns | 0.0048 ns | 0.0040 ns |  1.05 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.5355 ns | 0.0040 ns | 0.0034 ns |  1.26 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.5652 ns | 0.0057 ns | 0.0053 ns |  1.27 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.5750 ns | 0.0047 ns | 0.0044 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.7156 ns | 0.0011 ns | 0.0010 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.5927 ns | 0.0066 ns | 0.0062 ns |  0.83 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.6715 ns | 0.0014 ns | 0.0012 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.7355 ns | 0.0153 ns | 0.0143 ns |  1.03 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.5989 ns | 0.0035 ns | 0.0033 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.6734 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.5369 ns | 0.0021 ns | 0.0020 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.6299 ns | 0.0031 ns | 0.0029 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  0.9562 ns | 0.0038 ns | 0.0035 ns |  1.42 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  0.6806 ns | 0.0032 ns | 0.0030 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.9589 ns | 0.0073 ns | 0.0068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.6880 ns | 0.0066 ns | 0.0062 ns |  0.72 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.5770 ns | 0.0039 ns | 0.0035 ns |  0.60 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.9594 ns | 0.0083 ns | 0.0074 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.6985 ns | 0.0018 ns | 0.0017 ns |  0.73 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.7504 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.6980 ns | 0.0036 ns | 0.0031 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.6928 ns | 0.0023 ns | 0.0020 ns |  0.97 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.3693 ns | 0.0344 ns | 0.0321 ns |  1.35 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.3611 ns | 0.0211 ns | 0.0198 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.3109 ns | 0.0296 ns | 0.0263 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 11.0040 ns | 0.0330 ns | 0.0293 ns |  0.89 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6471 ns | 0.0830 ns | 0.0648 ns |  0.46 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 11.1925 ns | 0.0152 ns | 0.0135 ns |  0.91 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 11.1324 ns | 0.0211 ns | 0.0187 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 25.5967 ns | 0.0476 ns | 0.0445 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.4912 ns | 0.0312 ns | 0.0292 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 18.9678 ns | 0.1621 ns | 0.1516 ns |  0.74 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.6561 ns | 0.0314 ns | 0.0294 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.8876 ns | 0.0979 ns | 0.0916 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7024 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7036 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7556 ns | 0.0103 ns | 0.0091 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9426 ns | 0.0091 ns | 0.0081 ns |  1.34 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6915 ns | 0.0033 ns | 0.0031 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4819 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6536 ns | 0.0033 ns | 0.0031 ns |  1.12 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5093 ns | 0.0341 ns | 0.0302 ns |  1.02 |    0.02 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6882 ns | 0.0127 ns | 0.0113 ns |  1.14 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6804 ns | 0.0040 ns | 0.0037 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.2618 ns | 0.0137 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.5710 ns | 0.0185 ns | 0.0173 ns |  1.42 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.2598 ns | 0.0846 ns | 0.0792 ns |  1.49 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 14.1967 ns | 0.0215 ns | 0.0201 ns |  1.38 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.4028 ns | 0.0323 ns | 0.0286 ns |  1.31 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 59.3993 ns | 0.1009 ns | 0.0944 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 61.4023 ns | 0.0882 ns | 0.0825 ns |  1.03 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 43.5733 ns | 0.3858 ns | 0.3420 ns |  0.73 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 | 60.6072 ns | 0.3562 ns | 0.3157 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 59.8045 ns | 0.1008 ns | 0.0943 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.6226 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6230 ns | 0.0077 ns | 0.0072 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7085 ns | 0.0042 ns | 0.0035 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.9399 ns | 0.0030 ns | 0.0024 ns |  1.51 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.6831 ns | 0.0028 ns | 0.0025 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.1768 ns | 0.0130 ns | 0.0121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1880 ns | 0.0038 ns | 0.0036 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1272 ns | 0.0040 ns | 0.0035 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.2286 ns | 0.0081 ns | 0.0076 ns |  1.89 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.2324 ns | 0.0040 ns | 0.0037 ns |  1.90 |    0.02 |     - |     - |     - |         - |
