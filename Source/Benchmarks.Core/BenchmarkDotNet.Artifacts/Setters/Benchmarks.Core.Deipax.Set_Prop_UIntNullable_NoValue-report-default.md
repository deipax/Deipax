
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
             FromBool | .NET Core 2.0 |  0.7313 ns | 0.0100 ns | 0.0094 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9499 ns | 0.0032 ns | 0.0030 ns |  1.30 |    0.02 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7405 ns | 0.0071 ns | 0.0066 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6655 ns | 0.0028 ns | 0.0026 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6853 ns | 0.0181 ns | 0.0169 ns |  0.94 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.9642 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1877 ns | 0.0047 ns | 0.0044 ns |  1.23 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9211 ns | 0.0085 ns | 0.0071 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9166 ns | 0.0070 ns | 0.0065 ns |  1.99 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9893 ns | 0.0668 ns | 0.0656 ns |  2.06 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9793 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.7427 ns | 0.0025 ns | 0.0024 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5928 ns | 0.0029 ns | 0.0027 ns |  0.61 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6730 ns | 0.0062 ns | 0.0058 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6736 ns | 0.0139 ns | 0.0130 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9636 ns | 0.0034 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1951 ns | 0.0077 ns | 0.0065 ns |  1.24 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0529 ns | 0.0066 ns | 0.0061 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.8948 ns | 0.0038 ns | 0.0033 ns |  1.97 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9059 ns | 0.0110 ns | 0.0097 ns |  1.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3869 ns | 0.0057 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3316 ns | 0.0077 ns | 0.0068 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7170 ns | 0.0032 ns | 0.0030 ns |  0.52 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7166 ns | 0.0060 ns | 0.0056 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.5833 ns | 0.0136 ns | 0.0121 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.6845 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.7845 ns | 0.0100 ns | 0.0089 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9501 ns | 0.0026 ns | 0.0024 ns |  0.56 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9091 ns | 0.0027 ns | 0.0025 ns |  1.13 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.1330 ns | 0.0068 ns | 0.0060 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7194 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7224 ns | 0.0113 ns | 0.0105 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5464 ns | 0.0048 ns | 0.0045 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5452 ns | 0.0023 ns | 0.0019 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5583 ns | 0.0033 ns | 0.0031 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9743 ns | 0.0038 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1992 ns | 0.0054 ns | 0.0051 ns |  1.23 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9268 ns | 0.0109 ns | 0.0102 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9087 ns | 0.0025 ns | 0.0023 ns |  1.96 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9915 ns | 0.0213 ns | 0.0189 ns |  2.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.7210 ns | 0.0051 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.3303 ns | 0.0089 ns | 0.0084 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6242 ns | 0.0049 ns | 0.0041 ns |  0.36 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8400 ns | 0.0053 ns | 0.0049 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  1.8477 ns | 0.0041 ns | 0.0038 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.8243 ns | 0.0126 ns | 0.0118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.7698 ns | 0.0069 ns | 0.0064 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0549 ns | 0.0032 ns | 0.0030 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9689 ns | 0.0029 ns | 0.0026 ns |  1.08 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9120 ns | 0.0062 ns | 0.0052 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6992 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.7390 ns | 0.0029 ns | 0.0024 ns |  1.06 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5930 ns | 0.0052 ns | 0.0048 ns |  0.85 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7635 ns | 0.0410 ns | 0.0342 ns |  1.09 |    0.05 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6271 ns | 0.0047 ns | 0.0044 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  0.9679 ns | 0.0074 ns | 0.0069 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.3639 ns | 0.0045 ns | 0.0042 ns |  1.41 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.2488 ns | 0.0030 ns | 0.0027 ns |  1.29 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.8218 ns | 0.0152 ns | 0.0135 ns |  1.88 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9250 ns | 0.0146 ns | 0.0137 ns |  1.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.3984 ns | 0.0138 ns | 0.0129 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.3942 ns | 0.0132 ns | 0.0124 ns |  1.00 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7655 ns | 0.0102 ns | 0.0095 ns |  0.55 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7516 ns | 0.0296 ns | 0.0262 ns |  1.25 |    0.02 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7422 ns | 0.0122 ns | 0.0114 ns |  1.25 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.9115 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.9237 ns | 0.0042 ns | 0.0035 ns |  1.01 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0692 ns | 0.0157 ns | 0.0147 ns |  0.56 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.1883 ns | 0.0457 ns | 0.0427 ns |  1.14 |    0.02 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9239 ns | 0.0134 ns | 0.0125 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.7223 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.6880 ns | 0.0053 ns | 0.0050 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6628 ns | 0.0042 ns | 0.0040 ns |  0.92 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7445 ns | 0.0197 ns | 0.0174 ns |  1.03 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7294 ns | 0.0068 ns | 0.0057 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  0.6846 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.6910 ns | 0.0046 ns | 0.0043 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.6386 ns | 0.0064 ns | 0.0060 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  0.7202 ns | 0.0217 ns | 0.0192 ns |  1.05 |    0.03 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  0.7193 ns | 0.0067 ns | 0.0059 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.7864 ns | 0.0132 ns | 0.0124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.9028 ns | 0.0086 ns | 0.0077 ns |  1.06 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.7078 ns | 0.0072 ns | 0.0067 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.9056 ns | 0.0102 ns | 0.0090 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8817 ns | 0.0069 ns | 0.0058 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.7672 ns | 0.0040 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.7410 ns | 0.0043 ns | 0.0036 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.7624 ns | 0.0048 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.9935 ns | 0.0250 ns | 0.0195 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.3954 ns | 0.0042 ns | 0.0038 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4990 ns | 0.0052 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4067 ns | 0.0176 ns | 0.0156 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7240 ns | 0.0037 ns | 0.0029 ns |  0.48 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7626 ns | 0.0117 ns | 0.0109 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7618 ns | 0.0045 ns | 0.0042 ns |  1.18 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.3657 ns | 0.0086 ns | 0.0081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.9498 ns | 0.0029 ns | 0.0027 ns |  0.82 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4831 ns | 0.0039 ns | 0.0035 ns |  0.63 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.0020 ns | 0.0666 ns | 0.0713 ns |  0.84 |    0.03 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9318 ns | 0.0382 ns | 0.0357 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5773 ns | 0.0087 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4993 ns | 0.0076 ns | 0.0071 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.5042 ns | 0.0043 ns | 0.0038 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5528 ns | 0.0512 ns | 0.0479 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5182 ns | 0.0072 ns | 0.0068 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.8727 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7844 ns | 0.0117 ns | 0.0109 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7168 ns | 0.0027 ns | 0.0024 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9865 ns | 0.0357 ns | 0.0334 ns |  1.06 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9378 ns | 0.0127 ns | 0.0112 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.6733 ns | 0.0074 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.6047 ns | 0.0074 ns | 0.0069 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  3.0713 ns | 0.0045 ns | 0.0038 ns |  1.15 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.6459 ns | 0.0195 ns | 0.0173 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.6479 ns | 0.0132 ns | 0.0124 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9382 ns | 0.0049 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.8826 ns | 0.0163 ns | 0.0152 ns |  0.97 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9442 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1497 ns | 0.0296 ns | 0.0277 ns |  1.11 |    0.02 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1815 ns | 0.0151 ns | 0.0142 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.9586 ns | 0.0195 ns | 0.0173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1219 ns | 0.0594 ns | 0.0555 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.8548 ns | 0.0055 ns | 0.0052 ns |  0.45 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.5606 ns | 0.0499 ns | 0.0466 ns |  1.05 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.5115 ns | 0.0727 ns | 0.0680 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.2020 ns | 0.0173 ns | 0.0153 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  9.2079 ns | 0.0160 ns | 0.0142 ns |  1.12 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5457 ns | 0.0204 ns | 0.0191 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  9.4986 ns | 0.0949 ns | 0.0841 ns |  1.16 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.3602 ns | 0.0251 ns | 0.0235 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.7032 ns | 0.0058 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7014 ns | 0.0022 ns | 0.0019 ns |  1.00 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7574 ns | 0.0047 ns | 0.0042 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7157 ns | 0.0188 ns | 0.0176 ns |  1.02 |    0.03 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7225 ns | 0.0108 ns | 0.0101 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4845 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6425 ns | 0.0026 ns | 0.0021 ns |  1.11 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4512 ns | 0.0057 ns | 0.0054 ns |  0.98 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6694 ns | 0.0134 ns | 0.0112 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6892 ns | 0.0052 ns | 0.0043 ns |  1.14 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.1439 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8987 ns | 0.0153 ns | 0.0143 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7115 ns | 0.0069 ns | 0.0064 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  3.1602 ns | 0.1018 ns | 0.1000 ns |  1.01 |    0.03 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8837 ns | 0.0137 ns | 0.0114 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8062 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8971 ns | 0.0077 ns | 0.0064 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9033 ns | 0.0045 ns | 0.0040 ns |  1.05 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8458 ns | 0.0369 ns | 0.0327 ns |  1.02 |    0.02 |     - |     - |     - |         - |
           FromString |        net472 |  1.8481 ns | 0.0227 ns | 0.0212 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.4187 ns | 0.0052 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.3855 ns | 0.0140 ns | 0.0131 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.7318 ns | 0.0045 ns | 0.0042 ns |  0.52 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  2.1067 ns | 0.0188 ns | 0.0166 ns |  1.48 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8572 ns | 0.0163 ns | 0.0144 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.9069 ns | 0.0070 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9152 ns | 0.0052 ns | 0.0048 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0907 ns | 0.0126 ns | 0.0112 ns |  0.57 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9433 ns | 0.0113 ns | 0.0106 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.1849 ns | 0.0057 ns | 0.0054 ns |  1.15 |    0.00 |     - |     - |     - |         - |
