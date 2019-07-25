
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
             FromBool | .NET Core 2.0 |  0.9591 ns | 0.0120 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9362 ns | 0.0054 ns | 0.0048 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.7252 ns | 0.0030 ns | 0.0026 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6650 ns | 0.0033 ns | 0.0028 ns |  0.69 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6620 ns | 0.0031 ns | 0.0024 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.4184 ns | 0.0030 ns | 0.0027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.4026 ns | 0.0104 ns | 0.0097 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  1.1952 ns | 0.0038 ns | 0.0034 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9733 ns | 0.0066 ns | 0.0059 ns |  1.39 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9810 ns | 0.0213 ns | 0.0199 ns |  1.40 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9487 ns | 0.0022 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.9308 ns | 0.0032 ns | 0.0028 ns |  0.98 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7259 ns | 0.0098 ns | 0.0091 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6384 ns | 0.0053 ns | 0.0047 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6355 ns | 0.0023 ns | 0.0022 ns |  0.67 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.0220 ns | 0.0102 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1477 ns | 0.0130 ns | 0.0122 ns |  1.12 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1369 ns | 0.0030 ns | 0.0028 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  1.9965 ns | 0.0027 ns | 0.0025 ns |  1.95 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9921 ns | 0.0046 ns | 0.0038 ns |  1.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7149 ns | 0.0021 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.7134 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.8846 ns | 0.0027 ns | 0.0022 ns |  1.24 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.5670 ns | 0.0040 ns | 0.0038 ns |  0.79 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.5607 ns | 0.0020 ns | 0.0019 ns |  0.78 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1864 ns | 0.0023 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.1967 ns | 0.0056 ns | 0.0049 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.0200 ns | 0.0022 ns | 0.0021 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9314 ns | 0.0038 ns | 0.0034 ns |  1.63 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.7566 ns | 0.0045 ns | 0.0037 ns |  2.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9574 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7141 ns | 0.0020 ns | 0.0016 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6930 ns | 0.0027 ns | 0.0024 ns |  0.72 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5694 ns | 0.0088 ns | 0.0078 ns |  0.59 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5644 ns | 0.0129 ns | 0.0121 ns |  0.59 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9934 ns | 0.0079 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  1.1975 ns | 0.0093 ns | 0.0082 ns |  1.21 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9568 ns | 0.0089 ns | 0.0083 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9404 ns | 0.0068 ns | 0.0064 ns |  1.95 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9328 ns | 0.0075 ns | 0.0067 ns |  1.95 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7283 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.7057 ns | 0.0025 ns | 0.0021 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.5709 ns | 0.0030 ns | 0.0027 ns |  0.78 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.6360 ns | 0.0025 ns | 0.0023 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6345 ns | 0.0019 ns | 0.0016 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.2193 ns | 0.0032 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1786 ns | 0.0031 ns | 0.0026 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1655 ns | 0.0092 ns | 0.0076 ns |  0.96 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9931 ns | 0.0035 ns | 0.0031 ns |  1.63 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9927 ns | 0.0047 ns | 0.0037 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1857 ns | 0.0500 ns | 0.0468 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.9335 ns | 0.0041 ns | 0.0037 ns |  0.79 |    0.03 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.5915 ns | 0.0029 ns | 0.0025 ns |  0.50 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6353 ns | 0.0040 ns | 0.0036 ns |  0.54 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.7190 ns | 0.0033 ns | 0.0031 ns |  0.61 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0128 ns | 0.0042 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.1443 ns | 0.0120 ns | 0.0112 ns |  1.13 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1090 ns | 0.0119 ns | 0.0111 ns |  1.10 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9969 ns | 0.0038 ns | 0.0035 ns |  1.97 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9982 ns | 0.0058 ns | 0.0052 ns |  1.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7227 ns | 0.0107 ns | 0.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7207 ns | 0.0029 ns | 0.0027 ns |  1.00 |    0.02 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.7029 ns | 0.0018 ns | 0.0016 ns |  0.97 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.5686 ns | 0.0015 ns | 0.0014 ns |  0.79 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.5664 ns | 0.0022 ns | 0.0020 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.1839 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.2293 ns | 0.0067 ns | 0.0056 ns |  1.04 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.0471 ns | 0.0033 ns | 0.0029 ns |  0.88 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  1.9428 ns | 0.0033 ns | 0.0028 ns |  1.64 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9420 ns | 0.0042 ns | 0.0039 ns |  1.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9509 ns | 0.0038 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7121 ns | 0.0029 ns | 0.0026 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.6497 ns | 0.0032 ns | 0.0028 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7249 ns | 0.0025 ns | 0.0022 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.5677 ns | 0.0029 ns | 0.0027 ns |  0.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.0493 ns | 0.0024 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1902 ns | 0.0043 ns | 0.0040 ns |  1.13 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.4198 ns | 0.0035 ns | 0.0031 ns |  1.35 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.1069 ns | 0.0043 ns | 0.0038 ns |  2.01 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9320 ns | 0.0036 ns | 0.0030 ns |  1.84 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.4469 ns | 0.0084 ns | 0.0074 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7323 ns | 0.0036 ns | 0.0033 ns |  0.51 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.6496 ns | 0.0061 ns | 0.0057 ns |  0.45 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.7063 ns | 0.0033 ns | 0.0029 ns |  0.49 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  0.6531 ns | 0.0031 ns | 0.0027 ns |  0.45 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.1601 ns | 0.0080 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.1556 ns | 0.0027 ns | 0.0024 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.2308 ns | 0.0034 ns | 0.0032 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.1813 ns | 0.0053 ns | 0.0047 ns |  1.02 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  1.1833 ns | 0.0071 ns | 0.0066 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.4596 ns | 0.0047 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.4136 ns | 0.0131 ns | 0.0123 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  0.7221 ns | 0.0034 ns | 0.0029 ns |  0.49 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7504 ns | 0.0026 ns | 0.0022 ns |  1.20 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8311 ns | 0.0174 ns | 0.0154 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.4130 ns | 0.0046 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.0667 ns | 0.0128 ns | 0.0107 ns |  0.86 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7168 ns | 0.0047 ns | 0.0039 ns |  0.71 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.8758 ns | 0.0060 ns | 0.0056 ns |  1.19 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.8795 ns | 0.0106 ns | 0.0099 ns |  1.19 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.2189 ns | 0.0082 ns | 0.0073 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  2.1858 ns | 0.0032 ns | 0.0027 ns |  0.68 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  1.9879 ns | 0.0162 ns | 0.0151 ns |  0.62 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.5641 ns | 0.0148 ns | 0.0131 ns |  1.11 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.5045 ns | 0.0061 ns | 0.0054 ns |  1.09 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.0224 ns | 0.0087 ns | 0.0068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  2.8547 ns | 0.0046 ns | 0.0041 ns |  0.71 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  2.4096 ns | 0.0095 ns | 0.0079 ns |  0.60 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.1154 ns | 0.0053 ns | 0.0050 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0101 ns | 0.0203 ns | 0.0190 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.9718 ns | 0.0073 ns | 0.0068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.1883 ns | 0.0106 ns | 0.0099 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  1.9537 ns | 0.0087 ns | 0.0082 ns |  0.66 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.5125 ns | 0.0104 ns | 0.0092 ns |  1.18 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.4313 ns | 0.0145 ns | 0.0121 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.2853 ns | 0.0257 ns | 0.0241 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  3.3818 ns | 0.0063 ns | 0.0052 ns |  0.79 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  2.9892 ns | 0.0068 ns | 0.0064 ns |  0.70 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.7947 ns | 0.0111 ns | 0.0099 ns |  1.12 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.7584 ns | 0.0099 ns | 0.0083 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.1879 ns | 0.0142 ns | 0.0133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.4178 ns | 0.0189 ns | 0.0168 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.9046 ns | 0.0932 ns | 0.0826 ns |  0.45 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.7120 ns | 0.0244 ns | 0.0228 ns |  1.04 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.6295 ns | 0.0268 ns | 0.0251 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.3587 ns | 0.0471 ns | 0.0440 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.5900 ns | 0.0232 ns | 0.0217 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.2569 ns | 0.0098 ns | 0.0081 ns |  0.54 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.2835 ns | 0.0710 ns | 0.0629 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.9940 ns | 0.0437 ns | 0.0365 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9217 ns | 0.0020 ns | 0.0017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7440 ns | 0.0045 ns | 0.0040 ns |  0.81 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7226 ns | 0.0039 ns | 0.0036 ns |  0.78 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.9310 ns | 0.0033 ns | 0.0029 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6975 ns | 0.0090 ns | 0.0085 ns |  0.76 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.8508 ns | 0.0032 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6514 ns | 0.0021 ns | 0.0019 ns |  0.89 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4852 ns | 0.0039 ns | 0.0035 ns |  0.80 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6784 ns | 0.0060 ns | 0.0050 ns |  0.91 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6697 ns | 0.0033 ns | 0.0029 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 10.2227 ns | 0.0242 ns | 0.0202 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.4078 ns | 0.0091 ns | 0.0076 ns |  1.41 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.0691 ns | 0.0977 ns | 0.0914 ns |  1.47 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 | 13.3555 ns | 0.0132 ns | 0.0117 ns |  1.31 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.2407 ns | 0.0393 ns | 0.0348 ns |  1.30 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.8117 ns | 0.2031 ns | 0.1900 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 40.5008 ns | 0.0970 ns | 0.0860 ns |  0.83 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 10.8697 ns | 0.0342 ns | 0.0320 ns |  0.22 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 48.0649 ns | 0.2588 ns | 0.2421 ns |  0.98 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 47.4740 ns | 0.1597 ns | 0.1416 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9043 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.9485 ns | 0.0113 ns | 0.0106 ns |  1.05 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6618 ns | 0.0046 ns | 0.0043 ns |  0.73 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7223 ns | 0.0037 ns | 0.0033 ns |  0.80 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.5786 ns | 0.0124 ns | 0.0116 ns |  0.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.0703 ns | 0.0026 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.0677 ns | 0.0031 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0768 ns | 0.0110 ns | 0.0103 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9775 ns | 0.0031 ns | 0.0029 ns |  1.85 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9512 ns | 0.0047 ns | 0.0042 ns |  1.82 |    0.00 |     - |     - |     - |         - |
