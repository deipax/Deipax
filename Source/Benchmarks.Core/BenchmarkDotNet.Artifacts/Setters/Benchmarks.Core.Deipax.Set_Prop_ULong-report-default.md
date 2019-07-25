
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
             FromBool | .NET Core 2.0 |  0.9225 ns | 0.0026 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.8969 ns | 0.0035 ns | 0.0027 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  1.1438 ns | 0.0190 ns | 0.0178 ns |  1.24 |    0.02 |     - |     - |     - |         - |
             FromBool |        net461 |  0.8934 ns | 0.0027 ns | 0.0023 ns |  0.97 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9010 ns | 0.0035 ns | 0.0033 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.3986 ns | 0.0089 ns | 0.0075 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1391 ns | 0.0038 ns | 0.0034 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1334 ns | 0.0037 ns | 0.0034 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6322 ns | 0.0042 ns | 0.0039 ns |  1.17 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6325 ns | 0.0060 ns | 0.0056 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.6927 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.4447 ns | 0.0016 ns | 0.0014 ns |  0.64 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6541 ns | 0.0033 ns | 0.0029 ns |  0.94 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.4315 ns | 0.0023 ns | 0.0022 ns |  0.62 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.4340 ns | 0.0017 ns | 0.0014 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.1532 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9170 ns | 0.0044 ns | 0.0041 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1556 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.6155 ns | 0.0046 ns | 0.0036 ns |  1.40 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.6132 ns | 0.0055 ns | 0.0049 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.1304 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.0826 ns | 0.0042 ns | 0.0035 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6892 ns | 0.0028 ns | 0.0026 ns |  0.61 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7927 ns | 0.0042 ns | 0.0039 ns |  1.59 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.5102 ns | 0.0096 ns | 0.0090 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.4961 ns | 0.0031 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4756 ns | 0.0041 ns | 0.0036 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1150 ns | 0.0035 ns | 0.0029 ns |  0.75 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1167 ns | 0.0041 ns | 0.0035 ns |  1.42 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.5442 ns | 0.0784 ns | 0.1197 ns |  1.73 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.6960 ns | 0.0050 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4420 ns | 0.0025 ns | 0.0022 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6715 ns | 0.0045 ns | 0.0040 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4035 ns | 0.0182 ns | 0.0162 ns |  0.58 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4322 ns | 0.0020 ns | 0.0016 ns |  0.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1547 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.7125 ns | 0.0036 ns | 0.0034 ns |  0.62 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1467 ns | 0.0046 ns | 0.0043 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.6496 ns | 0.0131 ns | 0.0122 ns |  1.43 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.6682 ns | 0.0064 ns | 0.0056 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.1460 ns | 0.0039 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.0840 ns | 0.0029 ns | 0.0024 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.6712 ns | 0.0026 ns | 0.0023 ns |  0.59 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.6171 ns | 0.0112 ns | 0.0105 ns |  1.41 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.5913 ns | 0.0078 ns | 0.0073 ns |  1.39 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.6332 ns | 0.0022 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.3026 ns | 0.0042 ns | 0.0038 ns |  1.41 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1349 ns | 0.0062 ns | 0.0051 ns |  0.69 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.2925 ns | 0.0151 ns | 0.0141 ns |  1.40 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.3133 ns | 0.0349 ns | 0.0326 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.6937 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.4476 ns | 0.0033 ns | 0.0031 ns |  0.65 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6886 ns | 0.0030 ns | 0.0028 ns |  0.99 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.4345 ns | 0.0034 ns | 0.0030 ns |  0.63 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.4344 ns | 0.0024 ns | 0.0022 ns |  0.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.1513 ns | 0.0038 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  0.9321 ns | 0.0114 ns | 0.0106 ns |  0.81 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9221 ns | 0.0034 ns | 0.0030 ns |  0.80 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.6295 ns | 0.0037 ns | 0.0031 ns |  1.42 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.6412 ns | 0.0304 ns | 0.0284 ns |  1.43 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.2726 ns | 0.0018 ns | 0.0014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.1532 ns | 0.0032 ns | 0.0028 ns |  0.91 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6987 ns | 0.0078 ns | 0.0073 ns |  0.55 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.6227 ns | 0.0037 ns | 0.0032 ns |  1.28 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6032 ns | 0.0048 ns | 0.0045 ns |  1.26 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.7575 ns | 0.0121 ns | 0.0101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.6179 ns | 0.0029 ns | 0.0024 ns |  0.92 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.8804 ns | 0.0055 ns | 0.0052 ns |  0.50 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.0242 ns | 0.0148 ns | 0.0124 ns |  1.15 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.0272 ns | 0.0296 ns | 0.0277 ns |  1.15 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.6959 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.4333 ns | 0.0029 ns | 0.0027 ns |  0.62 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.4739 ns | 0.0117 ns | 0.0110 ns |  0.68 |    0.02 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.4443 ns | 0.0029 ns | 0.0024 ns |  0.64 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7267 ns | 0.0040 ns | 0.0037 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1401 ns | 0.0026 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  0.7906 ns | 0.0029 ns | 0.0026 ns |  0.69 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1328 ns | 0.0041 ns | 0.0038 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.6408 ns | 0.0077 ns | 0.0069 ns |  1.44 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.6534 ns | 0.0067 ns | 0.0056 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.2364 ns | 0.0094 ns | 0.0088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.2762 ns | 0.0050 ns | 0.0044 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6696 ns | 0.0032 ns | 0.0030 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6046 ns | 0.0068 ns | 0.0060 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6430 ns | 0.0039 ns | 0.0037 ns |  1.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.6856 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.9324 ns | 0.0034 ns | 0.0028 ns |  1.15 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.4806 ns | 0.0122 ns | 0.0114 ns |  0.88 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.6874 ns | 0.0054 ns | 0.0045 ns |  1.59 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.7119 ns | 0.0060 ns | 0.0050 ns |  1.61 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  0.6913 ns | 0.0025 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.4385 ns | 0.0071 ns | 0.0067 ns |  0.63 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.8142 ns | 0.0027 ns | 0.0024 ns |  1.18 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  0.4437 ns | 0.0042 ns | 0.0037 ns |  0.64 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  0.7287 ns | 0.0118 ns | 0.0105 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.5291 ns | 0.0025 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.4701 ns | 0.0029 ns | 0.0026 ns |  0.96 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.4307 ns | 0.0042 ns | 0.0037 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.8162 ns | 0.0138 ns | 0.0129 ns |  1.19 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.8193 ns | 0.0183 ns | 0.0162 ns |  1.19 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.1443 ns | 0.0086 ns | 0.0081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.0856 ns | 0.0078 ns | 0.0073 ns |  0.66 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.9017 ns | 0.0030 ns | 0.0026 ns |  0.60 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5439 ns | 0.0154 ns | 0.0137 ns |  1.13 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.8132 ns | 0.0110 ns | 0.0098 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  3.7552 ns | 0.0185 ns | 0.0164 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.5801 ns | 0.0076 ns | 0.0071 ns |  0.69 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.3392 ns | 0.0032 ns | 0.0029 ns |  0.62 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.1307 ns | 0.0413 ns | 0.0386 ns |  1.10 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0711 ns | 0.0075 ns | 0.0066 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.1540 ns | 0.0039 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  1.8654 ns | 0.0039 ns | 0.0033 ns |  0.59 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.8879 ns | 0.0044 ns | 0.0041 ns |  0.60 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.2864 ns | 0.0315 ns | 0.0295 ns |  1.04 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3315 ns | 0.0202 ns | 0.0189 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.6652 ns | 0.0413 ns | 0.0386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.1718 ns | 0.0056 ns | 0.0052 ns |  0.68 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  3.1057 ns | 0.0049 ns | 0.0041 ns |  0.67 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.6633 ns | 0.0241 ns | 0.0226 ns |  1.00 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.6748 ns | 0.0201 ns | 0.0178 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 12.8735 ns | 0.0088 ns | 0.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.1940 ns | 0.0608 ns | 0.0569 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.6562 ns | 0.0079 ns | 0.0074 ns |  0.44 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.3601 ns | 0.0597 ns | 0.0529 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.3260 ns | 0.0276 ns | 0.0230 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 23.5494 ns | 0.0420 ns | 0.0393 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 23.5502 ns | 0.0274 ns | 0.0256 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 12.4993 ns | 0.1280 ns | 0.1197 ns |  0.53 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 23.8364 ns | 0.1318 ns | 0.1233 ns |  1.01 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 23.7594 ns | 0.1052 ns | 0.0984 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  1.0504 ns | 0.0020 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.4374 ns | 0.0075 ns | 0.0070 ns |  0.42 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  1.0362 ns | 0.0477 ns | 0.0636 ns |  0.96 |    0.05 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.4623 ns | 0.0037 ns | 0.0032 ns |  0.44 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7057 ns | 0.0055 ns | 0.0046 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4276 ns | 0.0143 ns | 0.0126 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6919 ns | 0.0030 ns | 0.0025 ns |  1.19 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2404 ns | 0.0031 ns | 0.0026 ns |  0.87 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.4238 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.4633 ns | 0.0050 ns | 0.0047 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2456 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2283 ns | 0.0061 ns | 0.0054 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1267 ns | 0.0215 ns | 0.0201 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2361 ns | 0.0041 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.6183 ns | 0.0867 ns | 0.0811 ns |  1.17 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.3597 ns | 0.0759 ns | 0.0710 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.4012 ns | 0.0669 ns | 0.0626 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.7373 ns | 0.0183 ns | 0.0171 ns |  0.23 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.2956 ns | 0.1131 ns | 0.1003 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.4100 ns | 0.0703 ns | 0.0549 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.3379 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.1492 ns | 0.0076 ns | 0.0071 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.5221 ns | 0.0069 ns | 0.0061 ns |  0.39 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6143 ns | 0.0059 ns | 0.0049 ns |  1.21 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6637 ns | 0.0086 ns | 0.0076 ns |  1.24 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.7430 ns | 0.0153 ns | 0.0143 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.9109 ns | 0.0029 ns | 0.0028 ns |  1.10 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  0.9019 ns | 0.0022 ns | 0.0019 ns |  0.52 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.0654 ns | 0.0042 ns | 0.0037 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.3545 ns | 0.0215 ns | 0.0201 ns |  1.35 |    0.02 |     - |     - |     - |         - |
