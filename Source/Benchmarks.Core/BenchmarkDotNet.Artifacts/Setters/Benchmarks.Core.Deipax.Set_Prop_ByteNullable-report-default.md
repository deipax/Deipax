
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
             FromBool | .NET Core 2.0 |  0.7237 ns | 0.0042 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9490 ns | 0.0057 ns | 0.0050 ns |  1.31 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9160 ns | 0.0024 ns | 0.0021 ns |  1.27 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.6515 ns | 0.0025 ns | 0.0024 ns |  0.90 |    0.00 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9480 ns | 0.0053 ns | 0.0050 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1573 ns | 0.0044 ns | 0.0041 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1984 ns | 0.0105 ns | 0.0099 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9758 ns | 0.0024 ns | 0.0022 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  2.0542 ns | 0.0033 ns | 0.0031 ns |  1.78 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  2.1783 ns | 0.0113 ns | 0.0101 ns |  1.88 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.3048 ns | 0.0109 ns | 0.0102 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.3955 ns | 0.0029 ns | 0.0026 ns |  1.07 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.7063 ns | 0.0037 ns | 0.0033 ns |  0.54 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.7408 ns | 0.0033 ns | 0.0029 ns |  1.33 |    0.01 |     - |     - |     - |         - |
             FromChar |        net472 |  2.1155 ns | 0.0035 ns | 0.0033 ns |  1.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.9692 ns | 0.0169 ns | 0.0158 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.7981 ns | 0.0044 ns | 0.0039 ns |  0.91 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  1.0875 ns | 0.0037 ns | 0.0031 ns |  0.55 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.7138 ns | 0.0046 ns | 0.0043 ns |  1.38 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.8197 ns | 0.0050 ns | 0.0047 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.2883 ns | 0.0050 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.3966 ns | 0.0039 ns | 0.0032 ns |  1.08 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7365 ns | 0.0116 ns | 0.0109 ns |  0.57 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7350 ns | 0.0039 ns | 0.0032 ns |  1.35 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.9108 ns | 0.0028 ns | 0.0023 ns |  1.48 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.7828 ns | 0.0022 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8345 ns | 0.0041 ns | 0.0036 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1571 ns | 0.0061 ns | 0.0057 ns |  0.65 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.8450 ns | 0.0200 ns | 0.0187 ns |  1.60 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.8851 ns | 0.0137 ns | 0.0128 ns |  1.62 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.7236 ns | 0.0037 ns | 0.0035 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.7155 ns | 0.0028 ns | 0.0026 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5742 ns | 0.0025 ns | 0.0023 ns |  0.79 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7970 ns | 0.0033 ns | 0.0031 ns |  1.10 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5698 ns | 0.0061 ns | 0.0057 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.6089 ns | 0.0071 ns | 0.0066 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.7206 ns | 0.0030 ns | 0.0028 ns |  1.18 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9350 ns | 0.0086 ns | 0.0080 ns |  1.54 |    0.02 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  0.5512 ns | 0.0034 ns | 0.0028 ns |  0.90 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  0.7163 ns | 0.0032 ns | 0.0030 ns |  1.18 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.8169 ns | 0.0048 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  2.1515 ns | 0.0041 ns | 0.0039 ns |  1.18 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.8002 ns | 0.0039 ns | 0.0037 ns |  0.99 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.8325 ns | 0.0029 ns | 0.0025 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  2.1085 ns | 0.0038 ns | 0.0034 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.6019 ns | 0.0117 ns | 0.0110 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.5750 ns | 0.0056 ns | 0.0052 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.3281 ns | 0.0183 ns | 0.0171 ns |  0.89 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.6712 ns | 0.0043 ns | 0.0038 ns |  1.03 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.8681 ns | 0.0062 ns | 0.0055 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.2921 ns | 0.0151 ns | 0.0141 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.3980 ns | 0.0016 ns | 0.0013 ns |  1.08 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7282 ns | 0.0025 ns | 0.0022 ns |  0.56 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.7547 ns | 0.0039 ns | 0.0035 ns |  1.36 |    0.02 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.8993 ns | 0.0163 ns | 0.0153 ns |  1.47 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.9082 ns | 0.0025 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.9836 ns | 0.0041 ns | 0.0037 ns |  1.04 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1770 ns | 0.0115 ns | 0.0107 ns |  0.62 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.7109 ns | 0.0045 ns | 0.0043 ns |  1.42 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.7430 ns | 0.0050 ns | 0.0044 ns |  1.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  2.1965 ns | 0.0025 ns | 0.0022 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8203 ns | 0.0040 ns | 0.0034 ns |  0.83 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.7025 ns | 0.0027 ns | 0.0024 ns |  0.78 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7163 ns | 0.0099 ns | 0.0088 ns |  0.78 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7386 ns | 0.0051 ns | 0.0043 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.5659 ns | 0.0073 ns | 0.0068 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.5520 ns | 0.0098 ns | 0.0092 ns |  0.99 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.1188 ns | 0.0037 ns | 0.0032 ns |  0.83 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.6891 ns | 0.0047 ns | 0.0041 ns |  1.05 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.7242 ns | 0.0057 ns | 0.0053 ns |  1.06 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.5574 ns | 0.0024 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4195 ns | 0.0046 ns | 0.0041 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9054 ns | 0.0032 ns | 0.0027 ns |  0.58 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7359 ns | 0.0029 ns | 0.0027 ns |  1.11 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8240 ns | 0.0040 ns | 0.0036 ns |  1.17 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0427 ns | 0.0038 ns | 0.0033 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9381 ns | 0.0170 ns | 0.0159 ns |  0.95 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1802 ns | 0.0119 ns | 0.0105 ns |  0.58 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.6210 ns | 0.0039 ns | 0.0036 ns |  1.28 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.6467 ns | 0.0295 ns | 0.0276 ns |  1.30 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.8144 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8296 ns | 0.0177 ns | 0.0165 ns |  1.01 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  2.1419 ns | 0.0156 ns | 0.0130 ns |  1.18 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  2.2662 ns | 0.0136 ns | 0.0128 ns |  1.25 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.7079 ns | 0.0050 ns | 0.0044 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.8053 ns | 0.0173 ns | 0.0162 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.8683 ns | 0.0084 ns | 0.0066 ns |  1.02 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1118 ns | 0.0068 ns | 0.0064 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.9718 ns | 0.0149 ns | 0.0139 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.9222 ns | 0.0074 ns | 0.0069 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.7924 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.7142 ns | 0.0056 ns | 0.0053 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.8172 ns | 0.0048 ns | 0.0037 ns |  1.01 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7384 ns | 0.0050 ns | 0.0045 ns |  0.97 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.7373 ns | 0.0029 ns | 0.0026 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  2.9242 ns | 0.0086 ns | 0.0080 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  2.7882 ns | 0.0060 ns | 0.0050 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.8845 ns | 0.0087 ns | 0.0081 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.9275 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.1366 ns | 0.0225 ns | 0.0210 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8033 ns | 0.0072 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.9986 ns | 0.0150 ns | 0.0133 ns |  1.05 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.0849 ns | 0.0090 ns | 0.0084 ns |  1.07 |    0.00 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9024 ns | 0.0223 ns | 0.0209 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  3.9047 ns | 0.0048 ns | 0.0043 ns |  1.03 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.7391 ns | 0.0116 ns | 0.0103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.4494 ns | 0.0066 ns | 0.0058 ns |  0.94 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.3325 ns | 0.0091 ns | 0.0076 ns |  0.91 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.3682 ns | 0.0070 ns | 0.0062 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.3115 ns | 0.0094 ns | 0.0088 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  3.7897 ns | 0.0161 ns | 0.0151 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.9088 ns | 0.0186 ns | 0.0174 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.1855 ns | 0.0105 ns | 0.0098 ns |  1.10 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.3335 ns | 0.0056 ns | 0.0047 ns |  0.88 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.3396 ns | 0.0082 ns | 0.0069 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  4.5630 ns | 0.0352 ns | 0.0329 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  5.1129 ns | 0.0092 ns | 0.0086 ns |  1.12 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.7355 ns | 0.0123 ns | 0.0115 ns |  1.04 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  5.6369 ns | 0.0506 ns | 0.0473 ns |  1.24 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  4.9744 ns | 0.0388 ns | 0.0363 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.7726 ns | 0.0183 ns | 0.0171 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.7330 ns | 0.0162 ns | 0.0151 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.7541 ns | 0.0349 ns | 0.0327 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 14.0002 ns | 0.0205 ns | 0.0181 ns |  1.02 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.9813 ns | 0.0316 ns | 0.0280 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.6168 ns | 0.0304 ns | 0.0237 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 25.3743 ns | 0.0248 ns | 0.0207 ns |  1.03 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.8271 ns | 0.0545 ns | 0.0510 ns |  0.56 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 25.4910 ns | 0.0499 ns | 0.0417 ns |  1.04 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 25.4879 ns | 0.0363 ns | 0.0322 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.6904 ns | 0.0029 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7006 ns | 0.0031 ns | 0.0029 ns |  1.01 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7133 ns | 0.0028 ns | 0.0027 ns |  1.03 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.6699 ns | 0.0030 ns | 0.0027 ns |  0.97 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.8864 ns | 0.0021 ns | 0.0018 ns |  1.28 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4789 ns | 0.0029 ns | 0.0024 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6536 ns | 0.0157 ns | 0.0147 ns |  1.12 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4698 ns | 0.0025 ns | 0.0022 ns |  0.99 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6641 ns | 0.0075 ns | 0.0067 ns |  1.13 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6335 ns | 0.0062 ns | 0.0055 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.9868 ns | 0.0072 ns | 0.0064 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 13.8829 ns | 0.0261 ns | 0.0231 ns |  1.39 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 14.5284 ns | 0.0209 ns | 0.0186 ns |  1.45 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 13.5055 ns | 0.0412 ns | 0.0365 ns |  1.35 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.6452 ns | 0.0927 ns | 0.0867 ns |  1.37 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 47.5295 ns | 0.0641 ns | 0.0599 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 42.2635 ns | 0.0589 ns | 0.0523 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  8.9386 ns | 0.0447 ns | 0.0418 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.0419 ns | 0.1261 ns | 0.1053 ns |  0.97 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 | 46.1176 ns | 0.0632 ns | 0.0560 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8734 ns | 0.0038 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.8784 ns | 0.0076 ns | 0.0071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.7066 ns | 0.0029 ns | 0.0027 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7064 ns | 0.0032 ns | 0.0029 ns |  0.91 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.8238 ns | 0.0044 ns | 0.0039 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.5976 ns | 0.0062 ns | 0.0058 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.7041 ns | 0.0211 ns | 0.0197 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2943 ns | 0.0032 ns | 0.0030 ns |  0.88 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.7030 ns | 0.0136 ns | 0.0128 ns |  1.04 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.8681 ns | 0.0054 ns | 0.0048 ns |  1.10 |    0.00 |     - |     - |     - |         - |
