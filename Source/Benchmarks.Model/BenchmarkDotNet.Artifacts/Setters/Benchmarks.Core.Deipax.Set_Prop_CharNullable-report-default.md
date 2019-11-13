
BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-FAIBOE : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  Job-HDWVEN : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  Job-QWBUFU : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  Job-UUEYQZ : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0
  Job-TUNFLE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3416.0


               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 2.0 |  0.7269 ns | 0.0053 ns | 0.0045 ns |  0.7254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.6231 ns | 0.0030 ns | 0.0026 ns |  0.6222 ns |  0.86 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.5474 ns | 0.0038 ns | 0.0034 ns |  0.5483 ns |  0.75 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  1.0313 ns | 0.0161 ns | 0.0151 ns |  1.0226 ns |  1.42 |    0.03 |     - |     - |     - |         - |
             FromBool |        net472 |  0.6268 ns | 0.0059 ns | 0.0049 ns |  0.6255 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  0.7288 ns | 0.0048 ns | 0.0042 ns |  0.7284 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  0.8104 ns | 0.0035 ns | 0.0027 ns |  0.8102 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9449 ns | 0.0115 ns | 0.0102 ns |  0.9421 ns |  1.30 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  0.8094 ns | 0.0060 ns | 0.0054 ns |  0.8092 ns |  1.11 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  0.8229 ns | 0.0047 ns | 0.0042 ns |  0.8225 ns |  1.13 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  0.9628 ns | 0.0048 ns | 0.0045 ns |  0.9616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  0.6677 ns | 0.0042 ns | 0.0037 ns |  0.6671 ns |  0.69 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.9307 ns | 0.0056 ns | 0.0052 ns |  0.9277 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromChar |        net461 |  0.6829 ns | 0.0235 ns | 0.0220 ns |  0.6706 ns |  0.71 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  0.6750 ns | 0.0125 ns | 0.0117 ns |  0.6730 ns |  0.70 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  0.7255 ns | 0.0126 ns | 0.0111 ns |  0.7218 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  0.5361 ns | 0.0039 ns | 0.0036 ns |  0.5350 ns |  0.74 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.6984 ns | 0.0108 ns | 0.0091 ns |  0.7019 ns |  0.96 |    0.02 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  0.5441 ns | 0.0034 ns | 0.0028 ns |  0.5437 ns |  0.75 |    0.01 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  0.5421 ns | 0.0026 ns | 0.0024 ns |  0.5414 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.3336 ns | 0.0029 ns | 0.0026 ns |  1.3325 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.4157 ns | 0.0032 ns | 0.0029 ns |  1.4159 ns |  1.06 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.7194 ns | 0.0055 ns | 0.0046 ns |  0.7194 ns |  0.54 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.7651 ns | 0.0045 ns | 0.0042 ns |  1.7649 ns |  1.32 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.7586 ns | 0.0059 ns | 0.0056 ns |  1.7582 ns |  1.32 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.8743 ns | 0.0056 ns | 0.0047 ns |  1.8753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.8181 ns | 0.0283 ns | 0.0265 ns |  1.8032 ns |  0.97 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  1.1770 ns | 0.0063 ns | 0.0056 ns |  1.1778 ns |  0.63 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.9353 ns | 0.0415 ns | 0.0388 ns |  2.9146 ns |  1.56 |    0.02 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.9649 ns | 0.0202 ns | 0.0189 ns |  2.9684 ns |  1.58 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  1.3965 ns | 0.0070 ns | 0.0065 ns |  1.3961 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.5606 ns | 0.0014 ns | 0.0012 ns |  0.5610 ns |  0.40 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.5594 ns | 0.0061 ns | 0.0054 ns |  0.5601 ns |  0.40 |    0.00 |     - |     - |     - |         - |
             FromByte |        net461 |  0.5647 ns | 0.0035 ns | 0.0033 ns |  0.5644 ns |  0.40 |    0.00 |     - |     - |     - |         - |
             FromByte |        net472 |  0.5695 ns | 0.0052 ns | 0.0046 ns |  0.5678 ns |  0.41 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  1.0049 ns | 0.0029 ns | 0.0024 ns |  1.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9438 ns | 0.0060 ns | 0.0056 ns |  0.9417 ns |  0.94 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  1.3635 ns | 0.0046 ns | 0.0043 ns |  1.3633 ns |  1.36 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  2.0015 ns | 0.0053 ns | 0.0049 ns |  2.0020 ns |  1.99 |    0.00 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  2.0027 ns | 0.0069 ns | 0.0061 ns |  2.0015 ns |  1.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  1.3349 ns | 0.0066 ns | 0.0062 ns |  1.3347 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.4093 ns | 0.0161 ns | 0.0150 ns |  1.4103 ns |  1.06 |    0.01 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  0.7007 ns | 0.0029 ns | 0.0024 ns |  0.7008 ns |  0.52 |    0.00 |     - |     - |     - |         - |
            FromShort |        net461 |  1.7623 ns | 0.0059 ns | 0.0056 ns |  1.7613 ns |  1.32 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.7885 ns | 0.0275 ns | 0.0257 ns |  1.7833 ns |  1.34 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.0285 ns | 0.0050 ns | 0.0045 ns |  2.0280 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  1.8082 ns | 0.0063 ns | 0.0056 ns |  1.8091 ns |  0.89 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  1.1356 ns | 0.0116 ns | 0.0091 ns |  1.1381 ns |  0.56 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.9679 ns | 0.0085 ns | 0.0080 ns |  2.9694 ns |  1.46 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.7793 ns | 0.0077 ns | 0.0072 ns |  2.7786 ns |  1.37 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  0.9660 ns | 0.0144 ns | 0.0134 ns |  0.9600 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  0.6369 ns | 0.0045 ns | 0.0040 ns |  0.6369 ns |  0.66 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.7027 ns | 0.0039 ns | 0.0036 ns |  0.7025 ns |  0.73 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net461 |  0.6345 ns | 0.0044 ns | 0.0037 ns |  0.6343 ns |  0.66 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  0.6372 ns | 0.0048 ns | 0.0044 ns |  0.6369 ns |  0.66 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.0914 ns | 0.0043 ns | 0.0040 ns |  1.0908 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.0682 ns | 0.0161 ns | 0.0150 ns |  1.0627 ns |  0.98 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  1.0757 ns | 0.0042 ns | 0.0035 ns |  1.0767 ns |  0.99 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.0019 ns | 0.0049 ns | 0.0046 ns |  2.0018 ns |  1.83 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  1.9984 ns | 0.0045 ns | 0.0042 ns |  1.9987 ns |  1.83 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.9261 ns | 0.0090 ns | 0.0080 ns |  1.9247 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.8420 ns | 0.0041 ns | 0.0036 ns |  1.8416 ns |  0.96 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.7119 ns | 0.0236 ns | 0.0184 ns |  1.7205 ns |  0.89 |    0.01 |     - |     - |     - |         - |
              FromInt |        net461 |  1.7539 ns | 0.0065 ns | 0.0060 ns |  1.7524 ns |  0.91 |    0.00 |     - |     - |     - |         - |
              FromInt |        net472 |  1.7538 ns | 0.0049 ns | 0.0038 ns |  1.7533 ns |  0.91 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.6253 ns | 0.0035 ns | 0.0031 ns |  2.6261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.5592 ns | 0.0090 ns | 0.0084 ns |  2.5580 ns |  0.98 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  2.2461 ns | 0.0076 ns | 0.0071 ns |  2.2455 ns |  0.86 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.8970 ns | 0.0244 ns | 0.0203 ns |  2.9038 ns |  1.10 |    0.01 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  3.0121 ns | 0.0097 ns | 0.0086 ns |  3.0126 ns |  1.15 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.4895 ns | 0.0031 ns | 0.0027 ns |  1.4894 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.4763 ns | 0.0259 ns | 0.0242 ns |  1.4851 ns |  0.99 |    0.02 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7233 ns | 0.0040 ns | 0.0038 ns |  0.7215 ns |  0.49 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.7864 ns | 0.0037 ns | 0.0034 ns |  1.7854 ns |  1.20 |    0.00 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.8032 ns | 0.0050 ns | 0.0047 ns |  1.8039 ns |  1.21 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  2.0964 ns | 0.0072 ns | 0.0056 ns |  2.0964 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.9385 ns | 0.0050 ns | 0.0046 ns |  1.9372 ns |  0.92 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  1.0802 ns | 0.0242 ns | 0.0226 ns |  1.0798 ns |  0.52 |    0.01 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.7778 ns | 0.0077 ns | 0.0068 ns |  2.7771 ns |  1.33 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.8338 ns | 0.0227 ns | 0.0201 ns |  2.8247 ns |  1.35 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.9537 ns | 0.0125 ns | 0.0117 ns |  1.9506 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.8745 ns | 0.0090 ns | 0.0084 ns |  1.8750 ns |  0.96 |    0.01 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.8573 ns | 0.0043 ns | 0.0040 ns |  1.8574 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromLong |        net461 |  1.8146 ns | 0.0265 ns | 0.0248 ns |  1.8180 ns |  0.93 |    0.01 |     - |     - |     - |         - |
             FromLong |        net472 |  1.8936 ns | 0.0069 ns | 0.0064 ns |  1.8922 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.9368 ns | 0.0281 ns | 0.0220 ns |  2.9469 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  3.3146 ns | 0.0275 ns | 0.0257 ns |  3.3247 ns |  1.13 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1283 ns | 0.0091 ns | 0.0085 ns |  3.1293 ns |  1.06 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  3.1526 ns | 0.0066 ns | 0.0062 ns |  3.1523 ns |  1.07 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  3.1487 ns | 0.0069 ns | 0.0064 ns |  3.1483 ns |  1.07 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.9179 ns | 0.0049 ns | 0.0046 ns |  1.9170 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  2.1154 ns | 0.0074 ns | 0.0066 ns |  2.1137 ns |  1.10 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  2.0082 ns | 0.0076 ns | 0.0071 ns |  2.0072 ns |  1.05 |    0.01 |     - |     - |     - |         - |
            FromULong |        net461 |  1.7853 ns | 0.0050 ns | 0.0047 ns |  1.7870 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8293 ns | 0.0284 ns | 0.0266 ns |  1.8216 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.0914 ns | 0.0067 ns | 0.0059 ns |  3.0916 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.0992 ns | 0.0107 ns | 0.0095 ns |  3.0977 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.9370 ns | 0.0134 ns | 0.0119 ns |  2.9360 ns |  0.95 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1930 ns | 0.0436 ns | 0.0408 ns |  3.1922 ns |  1.03 |    0.01 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.0712 ns | 0.0071 ns | 0.0066 ns |  3.0715 ns |  0.99 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  0.6944 ns | 0.0150 ns | 0.0125 ns |  0.6995 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  0.9632 ns | 0.0123 ns | 0.0096 ns |  0.9649 ns |  1.39 |    0.03 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  0.6788 ns | 0.0039 ns | 0.0037 ns |  0.6777 ns |  0.98 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net461 |  0.5986 ns | 0.0039 ns | 0.0036 ns |  0.5989 ns |  0.86 |    0.02 |     - |     - |     - |         - |
            FromFloat |        net472 |  0.7225 ns | 0.0046 ns | 0.0043 ns |  0.7228 ns |  1.04 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  0.7358 ns | 0.0054 ns | 0.0045 ns |  0.7349 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  0.9759 ns | 0.0043 ns | 0.0040 ns |  0.9761 ns |  1.33 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  0.8997 ns | 0.0034 ns | 0.0032 ns |  0.9010 ns |  1.22 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  0.9603 ns | 0.0058 ns | 0.0048 ns |  0.9587 ns |  1.31 |    0.01 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  0.9292 ns | 0.0032 ns | 0.0025 ns |  0.9283 ns |  1.26 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  0.9357 ns | 0.0053 ns | 0.0047 ns |  0.9344 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  0.9620 ns | 0.0032 ns | 0.0030 ns |  0.9609 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  0.9776 ns | 0.0198 ns | 0.0185 ns |  0.9659 ns |  1.04 |    0.02 |     - |     - |     - |         - |
           FromDouble |        net461 |  0.6077 ns | 0.0049 ns | 0.0041 ns |  0.6091 ns |  0.65 |    0.01 |     - |     - |     - |         - |
           FromDouble |        net472 |  0.7303 ns | 0.0038 ns | 0.0035 ns |  0.7303 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  1.1084 ns | 0.0038 ns | 0.0035 ns |  1.1076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  1.2131 ns | 0.0052 ns | 0.0046 ns |  1.2133 ns |  1.09 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  1.1944 ns | 0.0070 ns | 0.0066 ns |  1.1930 ns |  1.08 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  1.1809 ns | 0.0035 ns | 0.0033 ns |  1.1805 ns |  1.07 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 |  1.1906 ns | 0.0034 ns | 0.0032 ns |  1.1894 ns |  1.07 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 |  1.4561 ns | 0.0077 ns | 0.0069 ns |  1.4548 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 |  1.1863 ns | 0.0049 ns | 0.0046 ns |  1.1856 ns |  0.81 |    0.01 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  1.1996 ns | 0.0168 ns | 0.0131 ns |  1.2039 ns |  0.82 |    0.01 |     - |     - |     - |         - |
          FromDecimal |        net461 |  1.1699 ns | 0.0031 ns | 0.0027 ns |  1.1706 ns |  0.80 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 |  1.1957 ns | 0.0040 ns | 0.0037 ns |  1.1951 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 |  1.9416 ns | 0.0062 ns | 0.0058 ns |  1.9401 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 |  1.2077 ns | 0.0252 ns | 0.0236 ns |  1.1976 ns |  0.62 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 |  1.1783 ns | 0.0082 ns | 0.0068 ns |  1.1763 ns |  0.61 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 |  1.4284 ns | 0.0194 ns | 0.0162 ns |  1.4323 ns |  0.74 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 |  1.3642 ns | 0.0037 ns | 0.0033 ns |  1.3635 ns |  0.70 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.9608 ns | 0.0030 ns | 0.0028 ns |  0.9608 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.7129 ns | 0.0034 ns | 0.0032 ns |  0.7135 ns |  0.74 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.7594 ns | 0.0045 ns | 0.0042 ns |  0.7589 ns |  0.79 |    0.00 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7046 ns | 0.0109 ns | 0.0097 ns |  0.7009 ns |  0.73 |    0.01 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7139 ns | 0.0031 ns | 0.0028 ns |  0.7136 ns |  0.74 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4575 ns | 0.0040 ns | 0.0032 ns |  1.4575 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.6768 ns | 0.0035 ns | 0.0032 ns |  1.6778 ns |  1.15 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.5212 ns | 0.0178 ns | 0.0158 ns |  1.5267 ns |  1.04 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  2.0868 ns | 0.0053 ns | 0.0047 ns |  2.0867 ns |  1.43 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.6851 ns | 0.0047 ns | 0.0039 ns |  1.6849 ns |  1.16 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  9.9801 ns | 0.0068 ns | 0.0056 ns |  9.9793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 | 14.4365 ns | 0.0688 ns | 0.0574 ns | 14.4473 ns |  1.45 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 | 15.0795 ns | 0.0671 ns | 0.0628 ns | 15.0984 ns |  1.51 |    0.00 |     - |     - |     - |         - |
           FromObject |        net461 | 12.7767 ns | 0.0256 ns | 0.0227 ns | 12.7739 ns |  1.28 |    0.00 |     - |     - |     - |         - |
           FromObject |        net472 | 13.3498 ns | 0.0803 ns | 0.0751 ns | 13.3763 ns |  1.34 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 |  3.1387 ns | 0.0102 ns | 0.0091 ns |  3.1373 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 |  2.9920 ns | 0.0075 ns | 0.0070 ns |  2.9916 ns |  0.95 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  2.9357 ns | 0.0052 ns | 0.0041 ns |  2.9350 ns |  0.94 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 |  3.2337 ns | 0.0467 ns | 0.0437 ns |  3.2108 ns |  1.03 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 |  3.4869 ns | 0.0116 ns | 0.0103 ns |  3.4847 ns |  1.11 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.9221 ns | 0.0077 ns | 0.0064 ns |  1.9193 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  2.1379 ns | 0.0036 ns | 0.0033 ns |  2.1382 ns |  1.11 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.8984 ns | 0.0179 ns | 0.0167 ns |  1.8902 ns |  0.99 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.7650 ns | 0.0028 ns | 0.0024 ns |  1.7648 ns |  0.92 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.7869 ns | 0.0034 ns | 0.0030 ns |  1.7867 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.6555 ns | 0.0062 ns | 0.0055 ns |  2.6547 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.6674 ns | 0.0313 ns | 0.0293 ns |  2.6579 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2431 ns | 0.0051 ns | 0.0043 ns |  2.2422 ns |  0.84 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.8923 ns | 0.0056 ns | 0.0050 ns |  2.8921 ns |  1.09 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.9060 ns | 0.0209 ns | 0.0185 ns |  2.9127 ns |  1.09 |    0.01 |     - |     - |     - |         - |
