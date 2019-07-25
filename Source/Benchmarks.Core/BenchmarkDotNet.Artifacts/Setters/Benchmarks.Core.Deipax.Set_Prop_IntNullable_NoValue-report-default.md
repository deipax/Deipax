
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
             FromBool | .NET Core 2.0 |  0.9663 ns | 0.0041 ns | 0.0036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6769 ns | 0.0038 ns | 0.0036 ns |  0.70 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.6984 ns | 0.0102 ns | 0.0096 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9439 ns | 0.0031 ns | 0.0029 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.5436 ns | 0.0035 ns | 0.0031 ns |  0.56 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.2058 ns | 0.0131 ns | 0.0116 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.9302 ns | 0.0031 ns | 0.0029 ns |  0.77 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9280 ns | 0.0035 ns | 0.0033 ns |  0.77 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9545 ns | 0.0064 ns | 0.0054 ns |  1.62 |    0.02 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9227 ns | 0.0044 ns | 0.0039 ns |  1.59 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9681 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6465 ns | 0.0033 ns | 0.0028 ns |  0.67 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7212 ns | 0.0142 ns | 0.0133 ns |  0.74 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.9388 ns | 0.0048 ns | 0.0043 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6869 ns | 0.0120 ns | 0.0112 ns |  0.71 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.2002 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.1148 ns | 0.0036 ns | 0.0032 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.1595 ns | 0.0129 ns | 0.0121 ns |  0.97 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.8506 ns | 0.0159 ns | 0.0133 ns |  2.37 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.9257 ns | 0.0037 ns | 0.0035 ns |  1.60 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7362 ns | 0.0104 ns | 0.0098 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.5639 ns | 0.0030 ns | 0.0026 ns |  0.77 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6920 ns | 0.0025 ns | 0.0022 ns |  0.94 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.9579 ns | 0.0030 ns | 0.0028 ns |  1.30 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.6800 ns | 0.0052 ns | 0.0046 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.5282 ns | 0.0048 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9019 ns | 0.0043 ns | 0.0038 ns |  0.59 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.9607 ns | 0.0037 ns | 0.0029 ns |  0.63 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9588 ns | 0.0045 ns | 0.0040 ns |  1.28 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9184 ns | 0.0059 ns | 0.0053 ns |  1.26 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9636 ns | 0.0034 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5633 ns | 0.0025 ns | 0.0021 ns |  0.58 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.6998 ns | 0.0036 ns | 0.0032 ns |  0.73 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.9620 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.6707 ns | 0.0038 ns | 0.0035 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.2127 ns | 0.0072 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9278 ns | 0.0028 ns | 0.0025 ns |  0.77 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.1436 ns | 0.0043 ns | 0.0038 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9658 ns | 0.0019 ns | 0.0017 ns |  1.62 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9188 ns | 0.0066 ns | 0.0059 ns |  1.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7307 ns | 0.0030 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6911 ns | 0.0036 ns | 0.0034 ns |  0.95 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.9048 ns | 0.0033 ns | 0.0031 ns |  1.24 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.9397 ns | 0.0065 ns | 0.0054 ns |  1.29 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  0.6739 ns | 0.0052 ns | 0.0048 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.2371 ns | 0.0231 ns | 0.0216 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1262 ns | 0.0026 ns | 0.0023 ns |  0.91 |    0.02 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.0702 ns | 0.0042 ns | 0.0035 ns |  0.87 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.0937 ns | 0.0039 ns | 0.0032 ns |  1.69 |    0.03 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9025 ns | 0.0037 ns | 0.0035 ns |  1.54 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9647 ns | 0.0059 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6480 ns | 0.0038 ns | 0.0036 ns |  0.67 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6611 ns | 0.0048 ns | 0.0045 ns |  0.69 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.9399 ns | 0.0037 ns | 0.0031 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6699 ns | 0.0028 ns | 0.0025 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.2111 ns | 0.0203 ns | 0.0190 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0739 ns | 0.0087 ns | 0.0078 ns |  0.89 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1579 ns | 0.0034 ns | 0.0032 ns |  0.96 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9400 ns | 0.0068 ns | 0.0061 ns |  1.60 |    0.03 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0578 ns | 0.0125 ns | 0.0111 ns |  1.70 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7295 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.6033 ns | 0.0025 ns | 0.0022 ns |  0.83 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  0.6842 ns | 0.0095 ns | 0.0089 ns |  0.94 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.9567 ns | 0.0048 ns | 0.0043 ns |  1.31 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  0.6686 ns | 0.0049 ns | 0.0041 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  0.7302 ns | 0.0022 ns | 0.0019 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  0.6859 ns | 0.0039 ns | 0.0034 ns |  0.94 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  0.8867 ns | 0.0058 ns | 0.0048 ns |  1.21 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  0.7291 ns | 0.0036 ns | 0.0032 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  0.5361 ns | 0.0048 ns | 0.0045 ns |  0.73 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4629 ns | 0.0059 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.3647 ns | 0.0051 ns | 0.0047 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7578 ns | 0.0032 ns | 0.0027 ns |  0.52 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7623 ns | 0.0057 ns | 0.0051 ns |  1.20 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.7609 ns | 0.0108 ns | 0.0096 ns |  1.20 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0428 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.8989 ns | 0.0039 ns | 0.0032 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0962 ns | 0.0150 ns | 0.0140 ns |  0.54 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.9391 ns | 0.0045 ns | 0.0040 ns |  0.95 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9079 ns | 0.0054 ns | 0.0048 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8071 ns | 0.0044 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6759 ns | 0.0067 ns | 0.0056 ns |  0.93 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.6590 ns | 0.0042 ns | 0.0039 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.7977 ns | 0.0169 ns | 0.0158 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7786 ns | 0.0028 ns | 0.0024 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.8103 ns | 0.0049 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.8203 ns | 0.0152 ns | 0.0142 ns |  1.01 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.8295 ns | 0.0038 ns | 0.0034 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  1.8894 ns | 0.0095 ns | 0.0084 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.0257 ns | 0.0034 ns | 0.0031 ns |  1.12 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9210 ns | 0.0071 ns | 0.0059 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7108 ns | 0.0053 ns | 0.0047 ns |  0.89 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.6249 ns | 0.0039 ns | 0.0035 ns |  0.85 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.9222 ns | 0.0043 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7295 ns | 0.0029 ns | 0.0025 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.8198 ns | 0.0045 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.7577 ns | 0.0097 ns | 0.0090 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.7297 ns | 0.0074 ns | 0.0062 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  1.9742 ns | 0.0055 ns | 0.0046 ns |  1.08 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  1.9070 ns | 0.0053 ns | 0.0050 ns |  1.05 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.5042 ns | 0.0075 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.4340 ns | 0.0049 ns | 0.0046 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  3.5165 ns | 0.0036 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.4586 ns | 0.0093 ns | 0.0087 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.4347 ns | 0.0093 ns | 0.0072 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  1.9345 ns | 0.0095 ns | 0.0089 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.7710 ns | 0.0163 ns | 0.0153 ns |  0.92 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  1.7390 ns | 0.0203 ns | 0.0190 ns |  0.90 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  1.9945 ns | 0.0172 ns | 0.0153 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  1.9260 ns | 0.0088 ns | 0.0082 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  2.6674 ns | 0.0064 ns | 0.0060 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  2.5787 ns | 0.0067 ns | 0.0056 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  2.8827 ns | 0.0056 ns | 0.0052 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  2.6090 ns | 0.0081 ns | 0.0067 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  2.5795 ns | 0.0073 ns | 0.0065 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.9242 ns | 0.0033 ns | 0.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.9325 ns | 0.0069 ns | 0.0061 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.9225 ns | 0.0071 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.0971 ns | 0.0036 ns | 0.0032 ns |  1.09 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.1219 ns | 0.0049 ns | 0.0046 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.3930 ns | 0.0131 ns | 0.0122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.3640 ns | 0.0207 ns | 0.0173 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.1375 ns | 0.1492 ns | 0.1596 ns |  0.46 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  7.4331 ns | 0.0248 ns | 0.0220 ns |  0.55 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  9.6590 ns | 0.0248 ns | 0.0232 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.4921 ns | 0.0116 ns | 0.0109 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  9.2490 ns | 0.0220 ns | 0.0206 ns |  1.09 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5994 ns | 0.0048 ns | 0.0045 ns |  0.31 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.9604 ns | 0.0337 ns | 0.0299 ns |  1.06 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  9.1846 ns | 0.0446 ns | 0.0372 ns |  1.08 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9611 ns | 0.0036 ns | 0.0028 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.6836 ns | 0.0026 ns | 0.0024 ns |  0.71 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7305 ns | 0.0115 ns | 0.0107 ns |  0.76 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7472 ns | 0.0045 ns | 0.0042 ns |  0.78 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.6925 ns | 0.0042 ns | 0.0040 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4770 ns | 0.0027 ns | 0.0025 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6777 ns | 0.0086 ns | 0.0072 ns |  1.14 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4977 ns | 0.0048 ns | 0.0045 ns |  1.01 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6510 ns | 0.0048 ns | 0.0045 ns |  1.12 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6739 ns | 0.0061 ns | 0.0051 ns |  1.13 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.0611 ns | 0.0084 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.8511 ns | 0.0043 ns | 0.0038 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.6748 ns | 0.0085 ns | 0.0071 ns |  0.87 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  3.0400 ns | 0.0075 ns | 0.0067 ns |  0.99 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.8743 ns | 0.0061 ns | 0.0054 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.8750 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  1.8854 ns | 0.0072 ns | 0.0060 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.9440 ns | 0.0063 ns | 0.0059 ns |  1.04 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.8354 ns | 0.0049 ns | 0.0046 ns |  0.98 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.8393 ns | 0.0049 ns | 0.0043 ns |  0.98 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.9650 ns | 0.0044 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.5943 ns | 0.0058 ns | 0.0052 ns |  0.62 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.6389 ns | 0.0020 ns | 0.0017 ns |  0.66 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.7383 ns | 0.0028 ns | 0.0025 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.5741 ns | 0.0032 ns | 0.0030 ns |  0.59 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.0079 ns | 0.0102 ns | 0.0090 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.0831 ns | 0.0040 ns | 0.0035 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.0619 ns | 0.0036 ns | 0.0028 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.9351 ns | 0.0046 ns | 0.0043 ns |  1.92 |    0.02 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9264 ns | 0.0071 ns | 0.0063 ns |  1.91 |    0.02 |     - |     - |     - |         - |
