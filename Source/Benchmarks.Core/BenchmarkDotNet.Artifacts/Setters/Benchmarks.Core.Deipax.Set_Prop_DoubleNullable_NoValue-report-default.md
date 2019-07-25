
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
             FromBool | .NET Core 2.0 | 0.8747 ns | 0.0038 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 1.1428 ns | 0.0037 ns | 0.0035 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 0.9348 ns | 0.0028 ns | 0.0025 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 0.9128 ns | 0.0030 ns | 0.0026 ns |  1.04 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 | 0.9347 ns | 0.0024 ns | 0.0021 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.9789 ns | 0.0025 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 1.3976 ns | 0.0042 ns | 0.0037 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 1.1808 ns | 0.0028 ns | 0.0026 ns |  1.21 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 1.9600 ns | 0.0059 ns | 0.0052 ns |  2.00 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 1.9611 ns | 0.0048 ns | 0.0042 ns |  2.00 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.6728 ns | 0.0082 ns | 0.0077 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 0.9261 ns | 0.0024 ns | 0.0022 ns |  1.38 |    0.02 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 0.6841 ns | 0.0038 ns | 0.0036 ns |  1.02 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 | 0.8046 ns | 0.0430 ns | 0.0559 ns |  1.18 |    0.08 |     - |     - |     - |         - |
             FromChar |        net472 | 0.6500 ns | 0.0051 ns | 0.0045 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 0.6684 ns | 0.0031 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.9747 ns | 0.0121 ns | 0.0113 ns |  1.46 |    0.02 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.9762 ns | 0.0034 ns | 0.0032 ns |  1.46 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 1.2465 ns | 0.0036 ns | 0.0030 ns |  1.86 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 0.9363 ns | 0.0131 ns | 0.0116 ns |  1.40 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 0.5876 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 0.9471 ns | 0.0025 ns | 0.0022 ns |  1.61 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.7228 ns | 0.0018 ns | 0.0014 ns |  1.23 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 | 0.6108 ns | 0.0028 ns | 0.0025 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 0.6088 ns | 0.0015 ns | 0.0014 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.0116 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.1906 ns | 0.0024 ns | 0.0019 ns |  1.18 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 0.9534 ns | 0.0049 ns | 0.0046 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 2.0121 ns | 0.0181 ns | 0.0170 ns |  1.99 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 1.9643 ns | 0.0067 ns | 0.0060 ns |  1.94 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.6436 ns | 0.0028 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.7176 ns | 0.0020 ns | 0.0018 ns |  1.12 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.5628 ns | 0.0128 ns | 0.0120 ns |  0.88 |    0.02 |     - |     - |     - |         - |
             FromByte |        net461 | 0.7045 ns | 0.0035 ns | 0.0033 ns |  1.09 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 | 0.7109 ns | 0.0139 ns | 0.0130 ns |  1.11 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.0207 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 0.9659 ns | 0.0104 ns | 0.0097 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 0.9286 ns | 0.0033 ns | 0.0028 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.9785 ns | 0.0082 ns | 0.0069 ns |  1.94 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.9653 ns | 0.0041 ns | 0.0036 ns |  1.93 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 0.6552 ns | 0.0026 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 0.6922 ns | 0.0018 ns | 0.0017 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.5632 ns | 0.0047 ns | 0.0044 ns |  0.86 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 | 0.6918 ns | 0.0022 ns | 0.0017 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 | 0.7103 ns | 0.0045 ns | 0.0040 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 0.9889 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.1859 ns | 0.0109 ns | 0.0102 ns |  1.20 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 1.1107 ns | 0.0060 ns | 0.0056 ns |  1.12 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 1.9172 ns | 0.0047 ns | 0.0041 ns |  1.94 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 1.9182 ns | 0.0043 ns | 0.0040 ns |  1.94 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.6756 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.9282 ns | 0.0031 ns | 0.0027 ns |  1.37 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.7014 ns | 0.0092 ns | 0.0086 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.6598 ns | 0.0025 ns | 0.0024 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.7064 ns | 0.0026 ns | 0.0024 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.0042 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 1.4091 ns | 0.0018 ns | 0.0017 ns |  1.40 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 1.1886 ns | 0.0032 ns | 0.0028 ns |  1.18 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 1.9123 ns | 0.0049 ns | 0.0046 ns |  1.90 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.9322 ns | 0.0222 ns | 0.0207 ns |  1.93 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 0.5573 ns | 0.0026 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 0.9460 ns | 0.0031 ns | 0.0029 ns |  1.70 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 0.7325 ns | 0.0034 ns | 0.0030 ns |  1.31 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 | 0.6316 ns | 0.0030 ns | 0.0027 ns |  1.13 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 | 0.6336 ns | 0.0038 ns | 0.0036 ns |  1.14 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 1.0053 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 1.1975 ns | 0.0039 ns | 0.0035 ns |  1.19 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.1033 ns | 0.0060 ns | 0.0053 ns |  1.10 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 1.9538 ns | 0.0102 ns | 0.0091 ns |  1.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 1.9121 ns | 0.0026 ns | 0.0022 ns |  1.90 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 0.6555 ns | 0.0066 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 0.9267 ns | 0.0036 ns | 0.0028 ns |  1.41 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.7337 ns | 0.0031 ns | 0.0026 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 | 0.9396 ns | 0.0023 ns | 0.0020 ns |  1.43 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 | 0.9374 ns | 0.0029 ns | 0.0027 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.0371 ns | 0.0033 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.1903 ns | 0.0035 ns | 0.0027 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 1.1276 ns | 0.0028 ns | 0.0026 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 1.9335 ns | 0.0163 ns | 0.0145 ns |  1.86 |    0.02 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 1.9123 ns | 0.0020 ns | 0.0019 ns |  1.84 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 0.6590 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 0.9291 ns | 0.0025 ns | 0.0022 ns |  1.41 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 0.7497 ns | 0.0027 ns | 0.0025 ns |  1.14 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 | 0.7306 ns | 0.0039 ns | 0.0036 ns |  1.11 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 0.7071 ns | 0.0024 ns | 0.0023 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 1.7192 ns | 0.0039 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 1.4635 ns | 0.0040 ns | 0.0037 ns |  0.85 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 1.6826 ns | 0.0026 ns | 0.0024 ns |  0.98 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 9.4837 ns | 0.0102 ns | 0.0095 ns |  5.52 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 2.1041 ns | 0.0047 ns | 0.0044 ns |  1.22 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 0.9319 ns | 0.0046 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 1.2053 ns | 0.0028 ns | 0.0026 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 0.7535 ns | 0.0032 ns | 0.0028 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 | 0.9211 ns | 0.0034 ns | 0.0030 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 0.9603 ns | 0.0043 ns | 0.0040 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 1.5412 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 1.6363 ns | 0.0143 ns | 0.0133 ns |  1.06 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 1.6359 ns | 0.0028 ns | 0.0025 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 2.2296 ns | 0.0075 ns | 0.0062 ns |  1.45 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 2.1392 ns | 0.0036 ns | 0.0032 ns |  1.39 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.6057 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.7476 ns | 0.0055 ns | 0.0049 ns |  1.23 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.7527 ns | 0.0035 ns | 0.0031 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.9467 ns | 0.0029 ns | 0.0027 ns |  1.56 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.9403 ns | 0.0028 ns | 0.0025 ns |  1.55 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 1.0028 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 1.1901 ns | 0.0038 ns | 0.0035 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 1.1236 ns | 0.0029 ns | 0.0027 ns |  1.12 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 2.0774 ns | 0.0242 ns | 0.0226 ns |  2.07 |    0.02 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 2.0515 ns | 0.0035 ns | 0.0033 ns |  2.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.7133 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.9290 ns | 0.0033 ns | 0.0028 ns |  1.30 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 0.7226 ns | 0.0035 ns | 0.0033 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 | 1.0371 ns | 0.0468 ns | 0.0701 ns |  1.46 |    0.11 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.7154 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.2043 ns | 0.0099 ns | 0.0093 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.1269 ns | 0.0038 ns | 0.0034 ns |  0.94 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.8527 ns | 0.0030 ns | 0.0027 ns |  1.54 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.4791 ns | 0.0035 ns | 0.0031 ns |  1.23 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.1835 ns | 0.0061 ns | 0.0051 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 8.0938 ns | 0.0136 ns | 0.0127 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 8.5760 ns | 0.0170 ns | 0.0159 ns |  1.06 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 5.5818 ns | 0.0099 ns | 0.0082 ns |  0.69 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 8.0077 ns | 0.0209 ns | 0.0195 ns |  0.99 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 8.0889 ns | 0.0626 ns | 0.0586 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 8.2124 ns | 0.0134 ns | 0.0125 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 8.7413 ns | 0.0240 ns | 0.0213 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 2.5402 ns | 0.0038 ns | 0.0035 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 8.9728 ns | 0.0147 ns | 0.0138 ns |  1.09 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 8.7502 ns | 0.0432 ns | 0.0404 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.6797 ns | 0.0062 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.7555 ns | 0.0026 ns | 0.0020 ns |  1.11 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.7570 ns | 0.0053 ns | 0.0050 ns |  1.11 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.9218 ns | 0.0030 ns | 0.0028 ns |  1.36 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.9635 ns | 0.0038 ns | 0.0034 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.5294 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.6367 ns | 0.0080 ns | 0.0071 ns |  1.07 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.4637 ns | 0.0030 ns | 0.0027 ns |  0.96 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.6811 ns | 0.0154 ns | 0.0129 ns |  1.10 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.6580 ns | 0.0039 ns | 0.0036 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 3.1779 ns | 0.0070 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 3.2250 ns | 0.0047 ns | 0.0041 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 3.0397 ns | 0.0818 ns | 0.0725 ns |  0.96 |    0.02 |     - |     - |     - |         - |
           FromObject |        net461 | 2.9674 ns | 0.0051 ns | 0.0047 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 2.9666 ns | 0.0075 ns | 0.0070 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 1.9409 ns | 0.0112 ns | 0.0104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 2.0303 ns | 0.0045 ns | 0.0042 ns |  1.05 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 1.8676 ns | 0.0106 ns | 0.0099 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromString |        net461 | 1.9311 ns | 0.0031 ns | 0.0024 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 1.9356 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 0.6467 ns | 0.0024 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 0.9293 ns | 0.0035 ns | 0.0033 ns |  1.44 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 0.7216 ns | 0.0032 ns | 0.0030 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 | 0.7230 ns | 0.0048 ns | 0.0043 ns |  1.12 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 | 0.7084 ns | 0.0035 ns | 0.0031 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 1.0367 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 1.1968 ns | 0.0119 ns | 0.0111 ns |  1.16 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 1.1393 ns | 0.0123 ns | 0.0109 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 2.2423 ns | 0.0046 ns | 0.0041 ns |  2.16 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 1.9158 ns | 0.0068 ns | 0.0060 ns |  1.85 |    0.01 |     - |     - |     - |         - |
