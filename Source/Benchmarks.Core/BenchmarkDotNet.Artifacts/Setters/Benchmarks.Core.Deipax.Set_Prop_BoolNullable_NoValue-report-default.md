
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-JBIYRV : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-GQVRNQ : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-BKGSYN : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-NLOXWC : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-AAMQWS : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 | 0.7219 ns | 0.0101 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 0.6422 ns | 0.0033 ns | 0.0031 ns |  0.89 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 0.5728 ns | 0.0027 ns | 0.0021 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 0.6218 ns | 0.0029 ns | 0.0027 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 0.7101 ns | 0.0014 ns | 0.0013 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.7162 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 0.5741 ns | 0.0022 ns | 0.0021 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 0.5831 ns | 0.0025 ns | 0.0024 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 0.5557 ns | 0.0029 ns | 0.0027 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 0.7120 ns | 0.0025 ns | 0.0021 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.9580 ns | 0.0074 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 0.6388 ns | 0.0029 ns | 0.0027 ns |  0.67 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 0.7981 ns | 0.0041 ns | 0.0036 ns |  0.83 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 | 0.6178 ns | 0.0032 ns | 0.0028 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 | 0.7454 ns | 0.0122 ns | 0.0115 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 0.7176 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.9012 ns | 0.0028 ns | 0.0023 ns |  1.26 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.8122 ns | 0.0034 ns | 0.0027 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 0.9035 ns | 0.0027 ns | 0.0026 ns |  1.26 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 0.9511 ns | 0.0026 ns | 0.0023 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 0.7144 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 0.5820 ns | 0.0029 ns | 0.0023 ns |  0.81 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.5998 ns | 0.0035 ns | 0.0032 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 1.4010 ns | 0.0032 ns | 0.0028 ns |  1.96 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 0.7217 ns | 0.0088 ns | 0.0082 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.1778 ns | 0.0023 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 0.8981 ns | 0.0024 ns | 0.0022 ns |  0.76 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 0.9481 ns | 0.0027 ns | 0.0024 ns |  0.80 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.9266 ns | 0.0054 ns | 0.0050 ns |  1.64 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.9315 ns | 0.0033 ns | 0.0030 ns |  1.64 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.9465 ns | 0.0025 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.6026 ns | 0.0043 ns | 0.0038 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.6083 ns | 0.0082 ns | 0.0073 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 | 0.5596 ns | 0.0028 ns | 0.0025 ns |  0.59 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 0.7165 ns | 0.0042 ns | 0.0039 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.1990 ns | 0.0057 ns | 0.0050 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 0.9229 ns | 0.0030 ns | 0.0027 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 0.9210 ns | 0.0039 ns | 0.0037 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.9130 ns | 0.0147 ns | 0.0138 ns |  1.60 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.9309 ns | 0.0045 ns | 0.0042 ns |  1.61 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 0.7161 ns | 0.0030 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 0.6739 ns | 0.0034 ns | 0.0028 ns |  0.94 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.7329 ns | 0.0054 ns | 0.0051 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 0.6599 ns | 0.0029 ns | 0.0027 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 0.9387 ns | 0.0056 ns | 0.0052 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.2119 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.3634 ns | 0.0052 ns | 0.0046 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.0804 ns | 0.0021 ns | 0.0019 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 1.8873 ns | 0.0044 ns | 0.0039 ns |  1.56 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 1.9130 ns | 0.0055 ns | 0.0046 ns |  1.58 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.9471 ns | 0.0022 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.6802 ns | 0.0036 ns | 0.0031 ns |  0.72 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.7266 ns | 0.0030 ns | 0.0027 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.6574 ns | 0.0047 ns | 0.0044 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.9589 ns | 0.0025 ns | 0.0023 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.1933 ns | 0.0037 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.0775 ns | 0.0065 ns | 0.0061 ns |  0.90 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.0802 ns | 0.0041 ns | 0.0039 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.9365 ns | 0.0031 ns | 0.0026 ns |  1.62 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 2.1020 ns | 0.0048 ns | 0.0045 ns |  1.76 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 1.2604 ns | 0.0025 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 0.6882 ns | 0.0021 ns | 0.0018 ns |  0.55 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 0.7449 ns | 0.0021 ns | 0.0018 ns |  0.59 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 0.5759 ns | 0.0024 ns | 0.0022 ns |  0.46 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 0.7155 ns | 0.0111 ns | 0.0104 ns |  0.57 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 0.9965 ns | 0.0013 ns | 0.0012 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.0660 ns | 0.0041 ns | 0.0034 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.1288 ns | 0.0111 ns | 0.0098 ns |  1.13 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 1.8826 ns | 0.0049 ns | 0.0046 ns |  1.89 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 1.9122 ns | 0.0036 ns | 0.0034 ns |  1.92 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 0.9494 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 0.9365 ns | 0.0041 ns | 0.0038 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.7191 ns | 0.0039 ns | 0.0035 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 0.5760 ns | 0.0030 ns | 0.0025 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 0.6642 ns | 0.0021 ns | 0.0019 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.1860 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.0782 ns | 0.0021 ns | 0.0018 ns |  0.91 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.1736 ns | 0.0033 ns | 0.0031 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.8867 ns | 0.0028 ns | 0.0026 ns |  1.59 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.8867 ns | 0.0035 ns | 0.0031 ns |  1.59 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 0.7196 ns | 0.0043 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 0.6949 ns | 0.0055 ns | 0.0049 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 0.7191 ns | 0.0026 ns | 0.0025 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 0.6728 ns | 0.0030 ns | 0.0028 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 0.6725 ns | 0.0019 ns | 0.0016 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.8193 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.5405 ns | 0.0043 ns | 0.0040 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.5173 ns | 0.0065 ns | 0.0055 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 2.6842 ns | 0.0047 ns | 0.0037 ns |  1.47 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 1.8582 ns | 0.0055 ns | 0.0049 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 0.9441 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 0.7037 ns | 0.0105 ns | 0.0098 ns |  0.75 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 0.7177 ns | 0.0026 ns | 0.0024 ns |  0.76 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 0.6742 ns | 0.0039 ns | 0.0034 ns |  0.71 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 0.6687 ns | 0.0043 ns | 0.0040 ns |  0.71 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.5133 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.5624 ns | 0.0044 ns | 0.0041 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.5226 ns | 0.0036 ns | 0.0034 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 1.9268 ns | 0.0126 ns | 0.0117 ns |  1.27 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 1.9368 ns | 0.0050 ns | 0.0039 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.7685 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.9719 ns | 0.0036 ns | 0.0032 ns |  1.26 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.9402 ns | 0.0032 ns | 0.0029 ns |  1.22 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.9630 ns | 0.0042 ns | 0.0038 ns |  1.25 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.9591 ns | 0.0021 ns | 0.0018 ns |  1.25 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.0463 ns | 0.0040 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.0699 ns | 0.0100 ns | 0.0093 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.1266 ns | 0.0051 ns | 0.0042 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 1.9238 ns | 0.0154 ns | 0.0145 ns |  1.84 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 1.9047 ns | 0.0115 ns | 0.0102 ns |  1.82 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.7695 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.9307 ns | 0.0033 ns | 0.0029 ns |  1.21 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 0.9410 ns | 0.0040 ns | 0.0037 ns |  1.22 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 | 0.9178 ns | 0.0036 ns | 0.0034 ns |  1.19 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.9147 ns | 0.0037 ns | 0.0035 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.8132 ns | 0.0151 ns | 0.0141 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.6994 ns | 0.0194 ns | 0.0182 ns |  0.94 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.6720 ns | 0.0039 ns | 0.0035 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 2.1273 ns | 0.0047 ns | 0.0042 ns |  1.17 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 2.0975 ns | 0.0050 ns | 0.0039 ns |  1.16 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 7.5177 ns | 0.0150 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 7.3866 ns | 0.0119 ns | 0.0105 ns |  0.98 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 4.6317 ns | 0.0055 ns | 0.0046 ns |  0.62 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 7.8858 ns | 0.0141 ns | 0.0132 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 8.1868 ns | 0.0098 ns | 0.0081 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 8.2758 ns | 0.0167 ns | 0.0157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 8.7640 ns | 0.0195 ns | 0.0152 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 2.5307 ns | 0.0061 ns | 0.0054 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 9.0452 ns | 0.0102 ns | 0.0095 ns |  1.09 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 9.1768 ns | 0.0144 ns | 0.0128 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.7198 ns | 0.0032 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.6927 ns | 0.0032 ns | 0.0030 ns |  0.96 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.7464 ns | 0.0023 ns | 0.0021 ns |  1.04 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.6857 ns | 0.0028 ns | 0.0023 ns |  0.95 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.6750 ns | 0.0068 ns | 0.0064 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.4802 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.4510 ns | 0.0038 ns | 0.0032 ns |  0.98 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.4698 ns | 0.0124 ns | 0.0116 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.4466 ns | 0.0047 ns | 0.0044 ns |  0.98 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.4276 ns | 0.0040 ns | 0.0038 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 2.8285 ns | 0.0145 ns | 0.0136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 2.8335 ns | 0.0077 ns | 0.0072 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 2.7306 ns | 0.0065 ns | 0.0061 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 2.7982 ns | 0.0067 ns | 0.0056 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 2.7939 ns | 0.0061 ns | 0.0054 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 1.6814 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.6223 ns | 0.0028 ns | 0.0025 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.7141 ns | 0.0074 ns | 0.0065 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 1.6911 ns | 0.0022 ns | 0.0019 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 1.6465 ns | 0.0049 ns | 0.0046 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 0.7274 ns | 0.0078 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 0.5868 ns | 0.0031 ns | 0.0024 ns |  0.81 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 0.9369 ns | 0.0027 ns | 0.0024 ns |  1.29 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 0.5747 ns | 0.0021 ns | 0.0016 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 | 0.6625 ns | 0.0038 ns | 0.0030 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.4118 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.1046 ns | 0.0038 ns | 0.0036 ns |  0.78 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.1715 ns | 0.0110 ns | 0.0103 ns |  0.83 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.8871 ns | 0.0043 ns | 0.0041 ns |  1.34 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.8841 ns | 0.0025 ns | 0.0022 ns |  1.33 |    0.00 |     - |     - |     - |         - |
