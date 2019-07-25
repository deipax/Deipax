
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
             FromBool | .NET Core 2.0 | 0.5290 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 0.7041 ns | 0.0026 ns | 0.0025 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 0.5800 ns | 0.0090 ns | 0.0084 ns |  1.10 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 | 0.6212 ns | 0.0082 ns | 0.0076 ns |  1.17 |    0.02 |     - |     - |     - |         - |
             FromBool |        net472 | 0.7130 ns | 0.0034 ns | 0.0032 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.6983 ns | 0.0032 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 0.9419 ns | 0.0057 ns | 0.0054 ns |  1.35 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 0.7200 ns | 0.0025 ns | 0.0022 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 0.8069 ns | 0.0062 ns | 0.0052 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 0.9394 ns | 0.0027 ns | 0.0024 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.9204 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 0.9394 ns | 0.0084 ns | 0.0079 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 0.6873 ns | 0.0025 ns | 0.0023 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 1.3926 ns | 0.0023 ns | 0.0020 ns |  1.51 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 0.9722 ns | 0.0084 ns | 0.0079 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 0.6914 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.7284 ns | 0.0024 ns | 0.0021 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.6648 ns | 0.0034 ns | 0.0032 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 0.5316 ns | 0.0031 ns | 0.0029 ns |  0.77 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 0.7227 ns | 0.0052 ns | 0.0046 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 1.4668 ns | 0.0064 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 1.3958 ns | 0.0062 ns | 0.0051 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.7163 ns | 0.0023 ns | 0.0021 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 1.7411 ns | 0.0061 ns | 0.0051 ns |  1.19 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 1.8791 ns | 0.0042 ns | 0.0039 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.7425 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.7747 ns | 0.0150 ns | 0.0141 ns |  1.02 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 0.9758 ns | 0.0091 ns | 0.0085 ns |  0.56 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 1.9110 ns | 0.0048 ns | 0.0043 ns |  1.10 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.9409 ns | 0.0047 ns | 0.0044 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.7171 ns | 0.0030 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.7214 ns | 0.0028 ns | 0.0026 ns |  1.01 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.5402 ns | 0.0020 ns | 0.0019 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 0.5532 ns | 0.0038 ns | 0.0032 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 | 0.7104 ns | 0.0022 ns | 0.0021 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 0.9745 ns | 0.0041 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 1.1808 ns | 0.0110 ns | 0.0103 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 0.9678 ns | 0.0037 ns | 0.0031 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.9102 ns | 0.0031 ns | 0.0029 ns |  1.96 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.9405 ns | 0.0042 ns | 0.0039 ns |  1.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 1.2933 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 1.3984 ns | 0.0114 ns | 0.0107 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.6383 ns | 0.0015 ns | 0.0013 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 1.7636 ns | 0.0032 ns | 0.0027 ns |  1.36 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 1.8891 ns | 0.0101 ns | 0.0090 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.8106 ns | 0.0036 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.7532 ns | 0.0026 ns | 0.0024 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.0553 ns | 0.0041 ns | 0.0038 ns |  0.58 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 2.2902 ns | 0.0039 ns | 0.0034 ns |  1.26 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 1.9179 ns | 0.0097 ns | 0.0091 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.6916 ns | 0.0023 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.7024 ns | 0.0016 ns | 0.0013 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.5722 ns | 0.0105 ns | 0.0098 ns |  0.83 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.6284 ns | 0.0040 ns | 0.0037 ns |  0.91 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.7363 ns | 0.0029 ns | 0.0027 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.0610 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.2043 ns | 0.0047 ns | 0.0042 ns |  1.14 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.0515 ns | 0.0032 ns | 0.0028 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.8780 ns | 0.0041 ns | 0.0038 ns |  1.77 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.9110 ns | 0.0050 ns | 0.0047 ns |  1.80 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 1.7681 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 1.9098 ns | 0.0043 ns | 0.0038 ns |  1.08 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 1.7194 ns | 0.0028 ns | 0.0024 ns |  0.97 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 1.7412 ns | 0.0115 ns | 0.0108 ns |  0.99 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 | 1.7779 ns | 0.0095 ns | 0.0088 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.8127 ns | 0.0036 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.7508 ns | 0.0052 ns | 0.0049 ns |  0.97 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 2.2579 ns | 0.0021 ns | 0.0017 ns |  1.25 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 1.9440 ns | 0.0080 ns | 0.0075 ns |  1.07 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 2.3042 ns | 0.0063 ns | 0.0059 ns |  1.27 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 1.4508 ns | 0.0024 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 1.4334 ns | 0.0056 ns | 0.0052 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.7474 ns | 0.0081 ns | 0.0072 ns |  0.52 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 1.8902 ns | 0.0098 ns | 0.0092 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 1.8296 ns | 0.0025 ns | 0.0023 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.8982 ns | 0.0056 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.9266 ns | 0.0146 ns | 0.0137 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.1188 ns | 0.0022 ns | 0.0021 ns |  0.59 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.9051 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 2.0185 ns | 0.0037 ns | 0.0033 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 1.7717 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 1.8192 ns | 0.0037 ns | 0.0033 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 1.7063 ns | 0.0045 ns | 0.0042 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 1.7630 ns | 0.0087 ns | 0.0072 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 | 1.7401 ns | 0.0043 ns | 0.0040 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.7798 ns | 0.0031 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.7246 ns | 0.0047 ns | 0.0044 ns |  0.97 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.7883 ns | 0.0022 ns | 0.0017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 1.9822 ns | 0.0043 ns | 0.0039 ns |  1.11 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 1.8754 ns | 0.0038 ns | 0.0034 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 1.8033 ns | 0.0132 ns | 0.0124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 1.9114 ns | 0.0045 ns | 0.0042 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 1.9521 ns | 0.0027 ns | 0.0022 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 1.7897 ns | 0.0042 ns | 0.0035 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromULong |        net472 | 1.7914 ns | 0.0109 ns | 0.0102 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.7659 ns | 0.0039 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.7729 ns | 0.0016 ns | 0.0013 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.7352 ns | 0.0032 ns | 0.0027 ns |  0.98 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 1.8950 ns | 0.0056 ns | 0.0052 ns |  1.07 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 1.9597 ns | 0.0026 ns | 0.0024 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.7260 ns | 0.0034 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.9528 ns | 0.0072 ns | 0.0067 ns |  1.31 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.7385 ns | 0.0032 ns | 0.0027 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.7146 ns | 0.0027 ns | 0.0024 ns |  0.98 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.6623 ns | 0.0034 ns | 0.0032 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 0.7198 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 0.9813 ns | 0.0038 ns | 0.0035 ns |  1.36 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 0.8060 ns | 0.0044 ns | 0.0036 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 0.9950 ns | 0.0238 ns | 0.0222 ns |  1.38 |    0.03 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 0.9798 ns | 0.0018 ns | 0.0015 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.9587 ns | 0.0051 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.9412 ns | 0.0019 ns | 0.0016 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 1.4073 ns | 0.0026 ns | 0.0023 ns |  1.47 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 | 0.7295 ns | 0.0040 ns | 0.0036 ns |  0.76 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.6652 ns | 0.0062 ns | 0.0055 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.2929 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.1858 ns | 0.0072 ns | 0.0064 ns |  0.92 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.1463 ns | 0.0048 ns | 0.0045 ns |  0.89 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.1794 ns | 0.0037 ns | 0.0035 ns |  0.91 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.1463 ns | 0.0029 ns | 0.0027 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 1.1929 ns | 0.0055 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 1.1760 ns | 0.0024 ns | 0.0021 ns |  0.99 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 1.6015 ns | 0.0028 ns | 0.0025 ns |  1.34 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 1.1926 ns | 0.0039 ns | 0.0037 ns |  1.00 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 1.1393 ns | 0.0063 ns | 0.0059 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.2600 ns | 0.0084 ns | 0.0079 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.2773 ns | 0.0102 ns | 0.0095 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.1775 ns | 0.0058 ns | 0.0054 ns |  0.93 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 1.3472 ns | 0.0027 ns | 0.0022 ns |  1.07 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.6156 ns | 0.0037 ns | 0.0032 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.6909 ns | 0.0034 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.7480 ns | 0.0030 ns | 0.0027 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.9302 ns | 0.0025 ns | 0.0023 ns |  1.35 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.7065 ns | 0.0034 ns | 0.0032 ns |  1.02 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.6852 ns | 0.0036 ns | 0.0032 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.4828 ns | 0.0053 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.6607 ns | 0.0132 ns | 0.0123 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.4687 ns | 0.0153 ns | 0.0144 ns |  0.99 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 2.3651 ns | 0.0127 ns | 0.0119 ns |  1.59 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.6340 ns | 0.0025 ns | 0.0023 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 3.0011 ns | 0.0055 ns | 0.0052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 2.8500 ns | 0.0052 ns | 0.0046 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 2.7305 ns | 0.0033 ns | 0.0029 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 2.8451 ns | 0.0051 ns | 0.0048 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 2.8211 ns | 0.0038 ns | 0.0032 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 1.8897 ns | 0.0044 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 1.6491 ns | 0.0022 ns | 0.0019 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.6498 ns | 0.0030 ns | 0.0025 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 1.7151 ns | 0.0031 ns | 0.0029 ns |  0.91 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 1.6625 ns | 0.0088 ns | 0.0083 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 1.8167 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 1.9097 ns | 0.0136 ns | 0.0127 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 1.7020 ns | 0.0037 ns | 0.0034 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 | 1.7633 ns | 0.0040 ns | 0.0035 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 1.8891 ns | 0.0056 ns | 0.0052 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.8152 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.7498 ns | 0.0033 ns | 0.0031 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.7106 ns | 0.0040 ns | 0.0033 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 1.9072 ns | 0.0086 ns | 0.0081 ns |  1.05 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.8881 ns | 0.0102 ns | 0.0095 ns |  1.04 |    0.01 |     - |     - |     - |         - |
