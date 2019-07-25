
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
             FromBool | .NET Core 2.0 | 0.6860 ns | 0.0058 ns | 0.0054 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 | 0.4818 ns | 0.0033 ns | 0.0029 ns |  0.70 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 | 0.4655 ns | 0.0019 ns | 0.0018 ns |  0.68 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 | 0.7051 ns | 0.0020 ns | 0.0019 ns |  1.03 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 | 0.7150 ns | 0.0024 ns | 0.0021 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 | 0.6899 ns | 0.0021 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 | 0.7108 ns | 0.0026 ns | 0.0023 ns |  1.03 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 | 0.6902 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 | 0.9205 ns | 0.0032 ns | 0.0028 ns |  1.33 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 | 0.9476 ns | 0.0025 ns | 0.0022 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 | 0.6894 ns | 0.0028 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 | 0.5050 ns | 0.0022 ns | 0.0020 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 | 0.4668 ns | 0.0019 ns | 0.0018 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 | 0.7042 ns | 0.0023 ns | 0.0021 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 | 0.7416 ns | 0.0060 ns | 0.0050 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 | 1.1474 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 | 0.9674 ns | 0.0071 ns | 0.0063 ns |  0.84 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 | 0.9235 ns | 0.0028 ns | 0.0023 ns |  0.80 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 | 1.4155 ns | 0.0140 ns | 0.0131 ns |  1.23 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 | 1.4097 ns | 0.0044 ns | 0.0039 ns |  1.23 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 | 1.1360 ns | 0.0078 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 | 1.3638 ns | 0.0027 ns | 0.0024 ns |  1.20 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 | 0.4922 ns | 0.0017 ns | 0.0015 ns |  0.43 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 | 1.8660 ns | 0.0041 ns | 0.0036 ns |  1.64 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 | 1.8876 ns | 0.0097 ns | 0.0086 ns |  1.66 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 | 1.4862 ns | 0.0022 ns | 0.0018 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 | 1.4772 ns | 0.0023 ns | 0.0019 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 | 0.7235 ns | 0.0036 ns | 0.0032 ns |  0.49 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 | 2.6741 ns | 0.0058 ns | 0.0054 ns |  1.80 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 | 2.7492 ns | 0.0817 ns | 0.1063 ns |  1.85 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 | 0.6936 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 | 0.4824 ns | 0.0013 ns | 0.0012 ns |  0.70 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 | 0.4634 ns | 0.0021 ns | 0.0019 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 | 0.7326 ns | 0.0128 ns | 0.0120 ns |  1.06 |    0.02 |     - |     - |     - |         - |
             FromByte |        net472 | 0.7193 ns | 0.0028 ns | 0.0025 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 | 1.1498 ns | 0.0042 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 | 0.9430 ns | 0.0025 ns | 0.0023 ns |  0.82 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 | 0.9571 ns | 0.0047 ns | 0.0041 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 | 1.6738 ns | 0.0137 ns | 0.0128 ns |  1.46 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 | 1.6748 ns | 0.0035 ns | 0.0031 ns |  1.46 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 | 1.1487 ns | 0.0057 ns | 0.0053 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 | 1.1105 ns | 0.0103 ns | 0.0097 ns |  0.97 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 | 0.7266 ns | 0.0029 ns | 0.0026 ns |  0.63 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 | 1.8579 ns | 0.0048 ns | 0.0043 ns |  1.62 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 | 1.8693 ns | 0.0038 ns | 0.0030 ns |  1.63 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 | 1.6263 ns | 0.0039 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 | 1.6151 ns | 0.0042 ns | 0.0039 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 | 0.9228 ns | 0.0028 ns | 0.0025 ns |  0.57 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 | 2.1379 ns | 0.0041 ns | 0.0036 ns |  1.31 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 | 2.1408 ns | 0.0027 ns | 0.0024 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 | 0.6883 ns | 0.0030 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 | 0.5075 ns | 0.0021 ns | 0.0019 ns |  0.74 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 | 0.4661 ns | 0.0051 ns | 0.0048 ns |  0.68 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 | 0.7039 ns | 0.0030 ns | 0.0027 ns |  1.02 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 | 0.7458 ns | 0.0028 ns | 0.0026 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 | 1.1464 ns | 0.0022 ns | 0.0017 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 | 0.9435 ns | 0.0027 ns | 0.0024 ns |  0.82 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 | 0.9572 ns | 0.0044 ns | 0.0041 ns |  0.84 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 | 2.2943 ns | 0.0061 ns | 0.0054 ns |  2.00 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 | 1.6425 ns | 0.0099 ns | 0.0083 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 | 1.6124 ns | 0.0016 ns | 0.0014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 | 1.6020 ns | 0.0016 ns | 0.0013 ns |  0.99 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 | 1.4644 ns | 0.0022 ns | 0.0020 ns |  0.91 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 | 1.6541 ns | 0.0045 ns | 0.0040 ns |  1.03 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 | 1.6621 ns | 0.0038 ns | 0.0035 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 | 2.0246 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 | 2.3126 ns | 0.0063 ns | 0.0056 ns |  1.14 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 | 1.7702 ns | 0.0037 ns | 0.0033 ns |  0.87 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 | 2.1563 ns | 0.0055 ns | 0.0051 ns |  1.07 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 | 2.2059 ns | 0.0106 ns | 0.0099 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 | 1.2685 ns | 0.0030 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 | 1.1603 ns | 0.0039 ns | 0.0036 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 | 0.6891 ns | 0.0056 ns | 0.0052 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 | 1.8851 ns | 0.0030 ns | 0.0028 ns |  1.49 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 | 1.8248 ns | 0.0028 ns | 0.0025 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 | 1.7520 ns | 0.0120 ns | 0.0112 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 | 1.6257 ns | 0.0021 ns | 0.0016 ns |  0.93 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 | 0.8154 ns | 0.0029 ns | 0.0026 ns |  0.47 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 | 2.5631 ns | 0.0056 ns | 0.0052 ns |  1.46 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 | 2.5352 ns | 0.0069 ns | 0.0058 ns |  1.45 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 | 1.6036 ns | 0.0035 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 | 1.6147 ns | 0.0069 ns | 0.0065 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 | 1.5029 ns | 0.0044 ns | 0.0039 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 | 1.6637 ns | 0.0149 ns | 0.0139 ns |  1.04 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 | 1.6586 ns | 0.0023 ns | 0.0021 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 | 2.6100 ns | 0.0228 ns | 0.0214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 | 2.8119 ns | 0.0056 ns | 0.0053 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 | 3.0788 ns | 0.0104 ns | 0.0087 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 | 2.8437 ns | 0.0133 ns | 0.0118 ns |  1.09 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 | 2.8396 ns | 0.0059 ns | 0.0055 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 | 1.6055 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 | 1.5355 ns | 0.0026 ns | 0.0023 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 | 1.4834 ns | 0.0042 ns | 0.0035 ns |  0.92 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 | 1.6464 ns | 0.0047 ns | 0.0041 ns |  1.03 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 | 1.5923 ns | 0.0027 ns | 0.0022 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 | 2.7134 ns | 0.0076 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 | 2.7684 ns | 0.0049 ns | 0.0046 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 | 2.8705 ns | 0.0103 ns | 0.0096 ns |  1.06 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 | 2.7818 ns | 0.0094 ns | 0.0079 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 | 2.7946 ns | 0.0032 ns | 0.0027 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 | 0.6787 ns | 0.0075 ns | 0.0070 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 | 0.4719 ns | 0.0020 ns | 0.0019 ns |  0.70 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 | 0.6906 ns | 0.0030 ns | 0.0028 ns |  1.02 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 | 0.7152 ns | 0.0015 ns | 0.0013 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 | 0.6734 ns | 0.0051 ns | 0.0045 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 | 0.6885 ns | 0.0040 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 | 0.7208 ns | 0.0028 ns | 0.0025 ns |  1.05 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 | 0.6745 ns | 0.0037 ns | 0.0034 ns |  0.98 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 | 0.7363 ns | 0.0030 ns | 0.0026 ns |  1.07 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 | 0.7199 ns | 0.0031 ns | 0.0028 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 | 0.6622 ns | 0.0094 ns | 0.0088 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 | 0.4763 ns | 0.0012 ns | 0.0011 ns |  0.72 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 | 0.6885 ns | 0.0030 ns | 0.0028 ns |  1.04 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net461 | 0.7222 ns | 0.0021 ns | 0.0020 ns |  1.09 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 | 0.6685 ns | 0.0029 ns | 0.0027 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 | 1.1740 ns | 0.0037 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 | 1.1960 ns | 0.0097 ns | 0.0091 ns |  1.02 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 | 1.1612 ns | 0.0103 ns | 0.0096 ns |  0.99 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 | 1.1126 ns | 0.0032 ns | 0.0027 ns |  0.95 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 1.1233 ns | 0.0017 ns | 0.0016 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 1.1869 ns | 0.0066 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 1.5914 ns | 0.0574 ns | 0.0877 ns |  1.33 |    0.07 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 | 1.1330 ns | 0.0034 ns | 0.0032 ns |  0.95 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 1.1152 ns | 0.0040 ns | 0.0036 ns |  0.94 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 1.1215 ns | 0.0040 ns | 0.0035 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 1.4181 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 1.1715 ns | 0.0021 ns | 0.0020 ns |  0.83 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 1.2219 ns | 0.0052 ns | 0.0048 ns |  0.86 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 1.1195 ns | 0.0021 ns | 0.0019 ns |  0.79 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 1.3888 ns | 0.0059 ns | 0.0052 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 | 0.6897 ns | 0.0024 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 | 0.4906 ns | 0.0041 ns | 0.0036 ns |  0.71 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 | 0.5125 ns | 0.0013 ns | 0.0010 ns |  0.74 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 | 0.7405 ns | 0.0027 ns | 0.0024 ns |  1.07 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 | 0.6645 ns | 0.0016 ns | 0.0015 ns |  0.96 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 | 1.5733 ns | 0.0038 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 | 1.4536 ns | 0.0170 ns | 0.0159 ns |  0.92 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 | 1.2276 ns | 0.0086 ns | 0.0080 ns |  0.78 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 | 1.4138 ns | 0.0034 ns | 0.0032 ns |  0.90 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 | 1.4038 ns | 0.0033 ns | 0.0029 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 | 2.2352 ns | 0.0050 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 2.2473 ns | 0.0039 ns | 0.0035 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 2.1307 ns | 0.0022 ns | 0.0018 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 2.2455 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 2.3029 ns | 0.0069 ns | 0.0061 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 3.1732 ns | 0.0069 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 2.2327 ns | 0.0025 ns | 0.0023 ns |  0.70 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 | 2.5783 ns | 0.0042 ns | 0.0033 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 2.5591 ns | 0.0051 ns | 0.0047 ns |  0.81 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 2.5231 ns | 0.0138 ns | 0.0116 ns |  0.80 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 | 1.6143 ns | 0.0025 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 | 1.6026 ns | 0.0041 ns | 0.0039 ns |  0.99 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 | 1.6564 ns | 0.0036 ns | 0.0032 ns |  1.03 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 | 1.6526 ns | 0.0032 ns | 0.0029 ns |  1.02 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 | 1.6269 ns | 0.0026 ns | 0.0023 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 | 2.0316 ns | 0.0193 ns | 0.0181 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 | 2.0467 ns | 0.0169 ns | 0.0158 ns |  1.01 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 | 2.2516 ns | 0.0063 ns | 0.0059 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 | 2.1759 ns | 0.0055 ns | 0.0049 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 | 2.3536 ns | 0.0038 ns | 0.0036 ns |  1.16 |    0.01 |     - |     - |     - |         - |
