
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
             FromBool | .NET Core 2.0 |  1.1752 ns | 0.0036 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9106 ns | 0.0033 ns | 0.0031 ns |  0.77 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9517 ns | 0.0024 ns | 0.0021 ns |  0.81 |    0.00 |     - |     - |     - |         - |
             FromBool |        net461 |  1.1725 ns | 0.0055 ns | 0.0052 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  1.6217 ns | 0.0596 ns | 0.1282 ns |  1.38 |    0.15 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.0224 ns | 0.0026 ns | 0.0023 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.0132 ns | 0.0033 ns | 0.0031 ns |  0.99 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9779 ns | 0.0023 ns | 0.0020 ns |  0.96 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.9571 ns | 0.0051 ns | 0.0045 ns |  1.91 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.9642 ns | 0.0053 ns | 0.0047 ns |  1.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9573 ns | 0.0041 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6473 ns | 0.0021 ns | 0.0020 ns |  0.68 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.6064 ns | 0.0046 ns | 0.0038 ns |  0.63 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.7277 ns | 0.0040 ns | 0.0038 ns |  0.76 |    0.00 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6987 ns | 0.0028 ns | 0.0025 ns |  0.73 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.9551 ns | 0.0041 ns | 0.0038 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.9505 ns | 0.0034 ns | 0.0030 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.8182 ns | 0.0032 ns | 0.0028 ns |  0.86 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.9992 ns | 0.0042 ns | 0.0040 ns |  1.05 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  1.0283 ns | 0.0137 ns | 0.0128 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  0.7321 ns | 0.0103 ns | 0.0096 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  0.6062 ns | 0.0044 ns | 0.0037 ns |  0.83 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.6067 ns | 0.0028 ns | 0.0026 ns |  0.83 |    0.01 |     - |     - |     - |         - |
            FromSByte |        net461 |  0.9425 ns | 0.0030 ns | 0.0026 ns |  1.29 |    0.02 |     - |     - |     - |         - |
            FromSByte |        net472 |  0.9507 ns | 0.0037 ns | 0.0033 ns |  1.30 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.1955 ns | 0.0049 ns | 0.0044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  0.9648 ns | 0.0028 ns | 0.0026 ns |  0.81 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.0182 ns | 0.0105 ns | 0.0093 ns |  0.85 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  1.9610 ns | 0.0033 ns | 0.0031 ns |  1.64 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  1.9604 ns | 0.0065 ns | 0.0061 ns |  1.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.9486 ns | 0.0021 ns | 0.0016 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.6831 ns | 0.0149 ns | 0.0132 ns |  0.72 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.7293 ns | 0.0066 ns | 0.0058 ns |  0.77 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.7077 ns | 0.0032 ns | 0.0030 ns |  0.75 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.7165 ns | 0.0036 ns | 0.0030 ns |  0.76 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.1883 ns | 0.0051 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9876 ns | 0.0029 ns | 0.0026 ns |  0.83 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.9577 ns | 0.0041 ns | 0.0034 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.9583 ns | 0.0043 ns | 0.0040 ns |  1.65 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.9535 ns | 0.0035 ns | 0.0029 ns |  1.64 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  0.7237 ns | 0.0028 ns | 0.0026 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  0.6730 ns | 0.0044 ns | 0.0039 ns |  0.93 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7166 ns | 0.0034 ns | 0.0031 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  0.9366 ns | 0.0043 ns | 0.0038 ns |  1.29 |    0.00 |     - |     - |     - |         - |
            FromShort |        net472 |  0.9252 ns | 0.0028 ns | 0.0026 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  1.2135 ns | 0.0130 ns | 0.0121 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.1989 ns | 0.0073 ns | 0.0061 ns |  0.99 |    0.01 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1349 ns | 0.0036 ns | 0.0033 ns |  0.94 |    0.01 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  1.9126 ns | 0.0032 ns | 0.0029 ns |  1.58 |    0.02 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  1.9244 ns | 0.0034 ns | 0.0028 ns |  1.59 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9529 ns | 0.0044 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6857 ns | 0.0026 ns | 0.0023 ns |  0.72 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.6083 ns | 0.0052 ns | 0.0049 ns |  0.64 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.7364 ns | 0.0047 ns | 0.0042 ns |  0.77 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6896 ns | 0.0021 ns | 0.0018 ns |  0.72 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.2028 ns | 0.0076 ns | 0.0067 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0717 ns | 0.0052 ns | 0.0049 ns |  0.89 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.1244 ns | 0.0040 ns | 0.0035 ns |  0.93 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  1.9548 ns | 0.0129 ns | 0.0114 ns |  1.63 |    0.02 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9387 ns | 0.0200 ns | 0.0187 ns |  1.61 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  0.7251 ns | 0.0040 ns | 0.0037 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  0.7110 ns | 0.0058 ns | 0.0054 ns |  0.98 |    0.01 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.0448 ns | 0.0027 ns | 0.0024 ns |  1.44 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  0.6994 ns | 0.0035 ns | 0.0033 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  0.7274 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  1.2002 ns | 0.0032 ns | 0.0030 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  1.0822 ns | 0.0022 ns | 0.0020 ns |  0.90 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.1228 ns | 0.0052 ns | 0.0046 ns |  0.94 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.1245 ns | 0.0030 ns | 0.0028 ns |  1.77 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  1.9512 ns | 0.0033 ns | 0.0027 ns |  1.63 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  0.9571 ns | 0.0045 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  0.7255 ns | 0.0046 ns | 0.0041 ns |  0.76 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.9397 ns | 0.0039 ns | 0.0034 ns |  0.98 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  0.7832 ns | 0.0035 ns | 0.0033 ns |  0.82 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  0.7956 ns | 0.0028 ns | 0.0026 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.1892 ns | 0.0022 ns | 0.0020 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.1112 ns | 0.0032 ns | 0.0027 ns |  0.93 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.1819 ns | 0.0090 ns | 0.0084 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  1.8866 ns | 0.0042 ns | 0.0039 ns |  1.59 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  1.9241 ns | 0.0033 ns | 0.0030 ns |  1.62 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  0.7262 ns | 0.0024 ns | 0.0021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  0.7250 ns | 0.0038 ns | 0.0035 ns |  1.00 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  0.9206 ns | 0.0035 ns | 0.0033 ns |  1.27 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  0.6938 ns | 0.0010 ns | 0.0008 ns |  0.96 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  0.7341 ns | 0.0027 ns | 0.0025 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  1.6695 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  1.6867 ns | 0.0035 ns | 0.0033 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  1.6783 ns | 0.0094 ns | 0.0079 ns |  1.01 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.0750 ns | 0.0061 ns | 0.0054 ns |  1.24 |    0.00 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.2393 ns | 0.0156 ns | 0.0138 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.1802 ns | 0.0041 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  0.9084 ns | 0.0038 ns | 0.0035 ns |  0.77 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.1591 ns | 0.0038 ns | 0.0036 ns |  0.98 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.1346 ns | 0.0039 ns | 0.0034 ns |  0.96 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.2164 ns | 0.0083 ns | 0.0078 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  1.5254 ns | 0.0046 ns | 0.0043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  1.8841 ns | 0.0168 ns | 0.0157 ns |  1.24 |    0.01 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  1.8910 ns | 0.0050 ns | 0.0047 ns |  1.24 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  2.1032 ns | 0.0066 ns | 0.0061 ns |  1.38 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  2.1035 ns | 0.0055 ns | 0.0051 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6914 ns | 0.0035 ns | 0.0031 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.5823 ns | 0.0028 ns | 0.0024 ns |  0.84 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.7149 ns | 0.0032 ns | 0.0029 ns |  1.03 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.6612 ns | 0.0028 ns | 0.0025 ns |  0.96 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.7085 ns | 0.0029 ns | 0.0024 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.7235 ns | 0.0054 ns | 0.0042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  1.1232 ns | 0.0029 ns | 0.0024 ns |  1.55 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.6868 ns | 0.0038 ns | 0.0033 ns |  0.95 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  0.8954 ns | 0.0040 ns | 0.0038 ns |  1.24 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  0.9469 ns | 0.0018 ns | 0.0017 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.9261 ns | 0.0100 ns | 0.0084 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.6868 ns | 0.0057 ns | 0.0050 ns |  0.74 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.6949 ns | 0.0030 ns | 0.0025 ns |  0.75 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.8922 ns | 0.0059 ns | 0.0055 ns |  0.96 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.9337 ns | 0.0036 ns | 0.0030 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.5078 ns | 0.0070 ns | 0.0055 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.7231 ns | 0.0047 ns | 0.0041 ns |  1.14 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.6942 ns | 0.0040 ns | 0.0036 ns |  1.12 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  2.1148 ns | 0.0071 ns | 0.0063 ns |  1.40 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  2.0786 ns | 0.0191 ns | 0.0178 ns |  1.38 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 10.3579 ns | 0.1065 ns | 0.0996 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 10.4214 ns | 0.0281 ns | 0.0263 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  5.4801 ns | 0.0064 ns | 0.0053 ns |  0.53 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 | 10.4348 ns | 0.0611 ns | 0.0571 ns |  1.01 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net472 | 10.4489 ns | 0.0146 ns | 0.0129 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  8.8108 ns | 0.0165 ns | 0.0155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  8.5338 ns | 0.0187 ns | 0.0156 ns |  0.97 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  2.5452 ns | 0.0056 ns | 0.0050 ns |  0.29 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  8.7451 ns | 0.0215 ns | 0.0191 ns |  0.99 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  8.5298 ns | 0.0647 ns | 0.0605 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9566 ns | 0.0050 ns | 0.0047 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  1.0379 ns | 0.0079 ns | 0.0066 ns |  1.08 |    0.01 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7193 ns | 0.0038 ns | 0.0034 ns |  0.75 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.8809 ns | 0.0029 ns | 0.0024 ns |  0.92 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.9625 ns | 0.0035 ns | 0.0029 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4624 ns | 0.0114 ns | 0.0107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6530 ns | 0.0033 ns | 0.0031 ns |  1.13 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.4775 ns | 0.0138 ns | 0.0129 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.6275 ns | 0.0036 ns | 0.0034 ns |  1.11 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6282 ns | 0.0036 ns | 0.0034 ns |  1.11 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  3.1999 ns | 0.0057 ns | 0.0051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  3.2018 ns | 0.0102 ns | 0.0095 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.7655 ns | 0.0054 ns | 0.0047 ns |  0.86 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 |  2.9492 ns | 0.0071 ns | 0.0063 ns |  0.92 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 |  2.9305 ns | 0.0055 ns | 0.0049 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  1.9829 ns | 0.0053 ns | 0.0049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  2.0046 ns | 0.0059 ns | 0.0052 ns |  1.01 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  1.8430 ns | 0.0067 ns | 0.0052 ns |  0.93 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  1.9090 ns | 0.0062 ns | 0.0058 ns |  0.96 |    0.00 |     - |     - |     - |         - |
           FromString |        net472 |  1.9314 ns | 0.0028 ns | 0.0024 ns |  0.97 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  0.7298 ns | 0.0127 ns | 0.0119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  0.6157 ns | 0.0123 ns | 0.0115 ns |  0.84 |    0.02 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  0.9227 ns | 0.0052 ns | 0.0046 ns |  1.26 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net461 |  0.8843 ns | 0.0036 ns | 0.0033 ns |  1.21 |    0.02 |     - |     - |     - |         - |
             FromEnum |        net472 |  0.9333 ns | 0.0028 ns | 0.0026 ns |  1.28 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  1.4111 ns | 0.0042 ns | 0.0039 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  1.1363 ns | 0.0050 ns | 0.0042 ns |  0.81 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  1.1241 ns | 0.0111 ns | 0.0098 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  1.8869 ns | 0.0033 ns | 0.0031 ns |  1.34 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  1.9217 ns | 0.0030 ns | 0.0028 ns |  1.36 |    0.00 |     - |     - |     - |         - |
