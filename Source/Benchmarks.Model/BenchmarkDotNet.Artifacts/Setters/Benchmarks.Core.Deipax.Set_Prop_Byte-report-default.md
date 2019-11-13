
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
             FromBool | .NET Core 2.0 |  0.7267 ns | 0.0038 ns | 0.0036 ns |  0.7251 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 2.2 |  0.9154 ns | 0.0060 ns | 0.0056 ns |  0.9169 ns |  1.26 |    0.01 |     - |     - |     - |         - |
             FromBool | .NET Core 3.0 |  0.9424 ns | 0.0109 ns | 0.0097 ns |  0.9403 ns |  1.30 |    0.01 |     - |     - |     - |         - |
             FromBool |        net461 |  0.9008 ns | 0.0040 ns | 0.0038 ns |  0.8995 ns |  1.24 |    0.01 |     - |     - |     - |         - |
             FromBool |        net472 |  0.9051 ns | 0.0030 ns | 0.0028 ns |  0.9044 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 2.0 |  1.1677 ns | 0.0046 ns | 0.0041 ns |  1.1669 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 2.2 |  1.1542 ns | 0.0155 ns | 0.0145 ns |  1.1515 ns |  0.99 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 3.0 |  0.9344 ns | 0.0049 ns | 0.0046 ns |  0.9341 ns |  0.80 |    0.01 |     - |     - |     - |         - |
     FromBoolNullable |        net461 |  1.6439 ns | 0.0041 ns | 0.0034 ns |  1.6429 ns |  1.41 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable |        net472 |  1.6554 ns | 0.0197 ns | 0.0184 ns |  1.6446 ns |  1.42 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 2.0 |  1.1298 ns | 0.0119 ns | 0.0111 ns |  1.1335 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 2.2 |  1.0914 ns | 0.0046 ns | 0.0043 ns |  1.0911 ns |  0.97 |    0.01 |     - |     - |     - |         - |
             FromChar | .NET Core 3.0 |  0.5020 ns | 0.0031 ns | 0.0024 ns |  0.5021 ns |  0.44 |    0.00 |     - |     - |     - |         - |
             FromChar |        net461 |  1.5937 ns | 0.0053 ns | 0.0050 ns |  1.5939 ns |  1.41 |    0.02 |     - |     - |     - |         - |
             FromChar |        net472 |  1.5910 ns | 0.0035 ns | 0.0033 ns |  1.5913 ns |  1.41 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 2.0 |  1.6217 ns | 0.0039 ns | 0.0037 ns |  1.6209 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 2.2 |  1.6267 ns | 0.0150 ns | 0.0140 ns |  1.6334 ns |  1.00 |    0.01 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 3.0 |  0.9568 ns | 0.0065 ns | 0.0058 ns |  0.9556 ns |  0.59 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net461 |  2.0818 ns | 0.0041 ns | 0.0038 ns |  2.0813 ns |  1.28 |    0.00 |     - |     - |     - |         - |
     FromCharNullable |        net472 |  2.0889 ns | 0.0045 ns | 0.0042 ns |  2.0886 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 2.0 |  1.1106 ns | 0.0040 ns | 0.0038 ns |  1.1105 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 2.2 |  1.0952 ns | 0.0101 ns | 0.0089 ns |  1.0932 ns |  0.99 |    0.01 |     - |     - |     - |         - |
            FromSByte | .NET Core 3.0 |  0.5039 ns | 0.0027 ns | 0.0024 ns |  0.5044 ns |  0.45 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net461 |  1.5964 ns | 0.0032 ns | 0.0025 ns |  1.5965 ns |  1.44 |    0.00 |     - |     - |     - |         - |
            FromSByte |        net472 |  1.5887 ns | 0.0048 ns | 0.0042 ns |  1.5879 ns |  1.43 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 2.0 |  1.4923 ns | 0.0137 ns | 0.0122 ns |  1.4968 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 2.2 |  1.4971 ns | 0.0117 ns | 0.0098 ns |  1.4966 ns |  1.00 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 3.0 |  0.7282 ns | 0.0055 ns | 0.0046 ns |  0.7293 ns |  0.49 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable |        net461 |  2.1334 ns | 0.0057 ns | 0.0051 ns |  2.1323 ns |  1.43 |    0.01 |     - |     - |     - |         - |
    FromSByteNullable |        net472 |  2.1161 ns | 0.0089 ns | 0.0079 ns |  2.1136 ns |  1.42 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 2.0 |  0.4947 ns | 0.0037 ns | 0.0033 ns |  0.4952 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 2.2 |  0.4501 ns | 0.0028 ns | 0.0026 ns |  0.4498 ns |  0.91 |    0.01 |     - |     - |     - |         - |
             FromByte | .NET Core 3.0 |  0.4697 ns | 0.0022 ns | 0.0021 ns |  0.4694 ns |  0.95 |    0.01 |     - |     - |     - |         - |
             FromByte |        net461 |  0.4466 ns | 0.0026 ns | 0.0024 ns |  0.4462 ns |  0.90 |    0.01 |     - |     - |     - |         - |
             FromByte |        net472 |  0.4462 ns | 0.0143 ns | 0.0134 ns |  0.4491 ns |  0.90 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 2.0 |  0.9547 ns | 0.0042 ns | 0.0035 ns |  0.9558 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 2.2 |  0.9203 ns | 0.0071 ns | 0.0067 ns |  0.9207 ns |  0.96 |    0.01 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 3.0 |  0.7693 ns | 0.0053 ns | 0.0050 ns |  0.7675 ns |  0.81 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net461 |  1.2370 ns | 0.0030 ns | 0.0028 ns |  1.2376 ns |  1.30 |    0.01 |     - |     - |     - |         - |
     FromByteNullable |        net472 |  1.2300 ns | 0.0043 ns | 0.0038 ns |  1.2294 ns |  1.29 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 2.0 |  2.0138 ns | 0.0089 ns | 0.0084 ns |  2.0147 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 2.2 |  1.8662 ns | 0.0076 ns | 0.0064 ns |  1.8653 ns |  0.93 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 3.0 |  1.4845 ns | 0.0227 ns | 0.0213 ns |  1.4727 ns |  0.74 |    0.01 |     - |     - |     - |         - |
            FromShort |        net461 |  1.6304 ns | 0.0167 ns | 0.0157 ns |  1.6251 ns |  0.81 |    0.01 |     - |     - |     - |         - |
            FromShort |        net472 |  1.6303 ns | 0.0195 ns | 0.0173 ns |  1.6344 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 2.0 |  2.3317 ns | 0.0042 ns | 0.0037 ns |  2.3318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 2.2 |  2.2707 ns | 0.0060 ns | 0.0050 ns |  2.2716 ns |  0.97 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 3.0 |  2.3670 ns | 0.0076 ns | 0.0063 ns |  2.3656 ns |  1.02 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net461 |  2.1090 ns | 0.0081 ns | 0.0072 ns |  2.1074 ns |  0.90 |    0.00 |     - |     - |     - |         - |
    FromShortNullable |        net472 |  2.2029 ns | 0.0287 ns | 0.0268 ns |  2.2064 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 2.0 |  1.1171 ns | 0.0057 ns | 0.0050 ns |  1.1186 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 2.2 |  1.1115 ns | 0.0049 ns | 0.0043 ns |  1.1113 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromUShort | .NET Core 3.0 |  0.4720 ns | 0.0033 ns | 0.0030 ns |  0.4725 ns |  0.42 |    0.00 |     - |     - |     - |         - |
           FromUShort |        net461 |  1.6182 ns | 0.0154 ns | 0.0136 ns |  1.6198 ns |  1.45 |    0.01 |     - |     - |     - |         - |
           FromUShort |        net472 |  1.6740 ns | 0.0046 ns | 0.0041 ns |  1.6735 ns |  1.50 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 2.0 |  1.6258 ns | 0.0138 ns | 0.0129 ns |  1.6213 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 2.2 |  1.6412 ns | 0.0078 ns | 0.0069 ns |  1.6397 ns |  1.01 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 3.0 |  0.9716 ns | 0.0085 ns | 0.0080 ns |  0.9735 ns |  0.60 |    0.01 |     - |     - |     - |         - |
   FromUShortNullable |        net461 |  2.6343 ns | 0.0798 ns | 0.1119 ns |  2.6434 ns |  1.64 |    0.07 |     - |     - |     - |         - |
   FromUShortNullable |        net472 |  2.0805 ns | 0.0040 ns | 0.0033 ns |  2.0804 ns |  1.28 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 2.0 |  1.8631 ns | 0.0039 ns | 0.0036 ns |  1.8623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 2.2 |  1.6812 ns | 0.0076 ns | 0.0067 ns |  1.6808 ns |  0.90 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 3.0 |  1.4584 ns | 0.0045 ns | 0.0042 ns |  1.4585 ns |  0.78 |    0.00 |     - |     - |     - |         - |
              FromInt |        net461 |  1.6638 ns | 0.0233 ns | 0.0206 ns |  1.6697 ns |  0.89 |    0.01 |     - |     - |     - |         - |
              FromInt |        net472 |  1.6350 ns | 0.0074 ns | 0.0066 ns |  1.6323 ns |  0.88 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 2.0 |  2.1080 ns | 0.0070 ns | 0.0065 ns |  2.1091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 2.2 |  2.5148 ns | 0.0051 ns | 0.0046 ns |  2.5131 ns |  1.19 |    0.01 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 3.0 |  1.9965 ns | 0.0045 ns | 0.0042 ns |  1.9962 ns |  0.95 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net461 |  2.0349 ns | 0.0036 ns | 0.0034 ns |  2.0346 ns |  0.97 |    0.00 |     - |     - |     - |         - |
      FromIntNullable |        net472 |  2.1211 ns | 0.0065 ns | 0.0061 ns |  2.1213 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 2.0 |  1.2571 ns | 0.0058 ns | 0.0045 ns |  1.2564 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 2.2 |  1.9320 ns | 0.0133 ns | 0.0124 ns |  1.9321 ns |  1.54 |    0.01 |     - |     - |     - |         - |
             FromUInt | .NET Core 3.0 |  0.7307 ns | 0.0114 ns | 0.0101 ns |  0.7355 ns |  0.58 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net461 |  1.6650 ns | 0.0049 ns | 0.0046 ns |  1.6641 ns |  1.32 |    0.01 |     - |     - |     - |         - |
             FromUInt |        net472 |  1.6892 ns | 0.0218 ns | 0.0204 ns |  1.6840 ns |  1.34 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 2.0 |  1.7235 ns | 0.0046 ns | 0.0041 ns |  1.7232 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 2.2 |  1.6171 ns | 0.0046 ns | 0.0036 ns |  1.6173 ns |  0.94 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 3.0 |  0.9604 ns | 0.0039 ns | 0.0032 ns |  0.9608 ns |  0.56 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net461 |  2.3399 ns | 0.0037 ns | 0.0035 ns |  2.3397 ns |  1.36 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable |        net472 |  2.3387 ns | 0.0038 ns | 0.0034 ns |  2.3388 ns |  1.36 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 2.0 |  1.6507 ns | 0.0061 ns | 0.0057 ns |  1.6511 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 2.2 |  1.6434 ns | 0.0058 ns | 0.0049 ns |  1.6429 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 3.0 |  1.5558 ns | 0.0035 ns | 0.0031 ns |  1.5555 ns |  0.94 |    0.00 |     - |     - |     - |         - |
             FromLong |        net461 |  1.6548 ns | 0.0030 ns | 0.0027 ns |  1.6543 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong |        net472 |  1.6587 ns | 0.0127 ns | 0.0113 ns |  1.6564 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 2.0 |  2.8719 ns | 0.0251 ns | 0.0235 ns |  2.8614 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 2.2 |  2.6502 ns | 0.0092 ns | 0.0086 ns |  2.6509 ns |  0.92 |    0.01 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 3.0 |  3.1035 ns | 0.0363 ns | 0.0340 ns |  3.1162 ns |  1.08 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net461 |  2.9700 ns | 0.0079 ns | 0.0070 ns |  2.9689 ns |  1.03 |    0.01 |     - |     - |     - |         - |
     FromLongNullable |        net472 |  2.9605 ns | 0.0091 ns | 0.0081 ns |  2.9604 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 2.0 |  1.8635 ns | 0.0045 ns | 0.0040 ns |  1.8621 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 2.2 |  1.6206 ns | 0.0177 ns | 0.0166 ns |  1.6119 ns |  0.87 |    0.01 |     - |     - |     - |         - |
            FromULong | .NET Core 3.0 |  1.4529 ns | 0.0035 ns | 0.0031 ns |  1.4533 ns |  0.78 |    0.00 |     - |     - |     - |         - |
            FromULong |        net461 |  1.6375 ns | 0.0038 ns | 0.0034 ns |  1.6384 ns |  0.88 |    0.00 |     - |     - |     - |         - |
            FromULong |        net472 |  1.8967 ns | 0.0103 ns | 0.0097 ns |  1.8938 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 2.0 |  3.1629 ns | 0.0092 ns | 0.0086 ns |  3.1634 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 2.2 |  3.2026 ns | 0.0091 ns | 0.0085 ns |  3.2006 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 3.0 |  2.8988 ns | 0.0080 ns | 0.0071 ns |  2.8992 ns |  0.92 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net461 |  3.1461 ns | 0.0079 ns | 0.0074 ns |  3.1472 ns |  0.99 |    0.00 |     - |     - |     - |         - |
    FromULongNullable |        net472 |  3.1499 ns | 0.0094 ns | 0.0083 ns |  3.1473 ns |  1.00 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 2.0 |  3.8441 ns | 0.0292 ns | 0.0273 ns |  3.8343 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 2.2 |  3.8825 ns | 0.0275 ns | 0.0257 ns |  3.8909 ns |  1.01 |    0.01 |     - |     - |     - |         - |
            FromFloat | .NET Core 3.0 |  4.1127 ns | 0.0278 ns | 0.0260 ns |  4.1155 ns |  1.07 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net461 |  3.9911 ns | 0.0154 ns | 0.0129 ns |  3.9876 ns |  1.04 |    0.01 |     - |     - |     - |         - |
            FromFloat |        net472 |  4.1864 ns | 0.0086 ns | 0.0072 ns |  4.1837 ns |  1.09 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 2.0 |  4.0289 ns | 0.0088 ns | 0.0078 ns |  4.0274 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 2.2 |  4.0219 ns | 0.0131 ns | 0.0110 ns |  4.0210 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 3.0 |  4.4849 ns | 0.0086 ns | 0.0076 ns |  4.4864 ns |  1.11 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net461 |  4.0877 ns | 0.0085 ns | 0.0080 ns |  4.0890 ns |  1.01 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable |        net472 |  4.0590 ns | 0.0089 ns | 0.0074 ns |  4.0605 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 2.0 |  4.0102 ns | 0.0126 ns | 0.0112 ns |  4.0106 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 2.2 |  3.5530 ns | 0.0098 ns | 0.0082 ns |  3.5512 ns |  0.89 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 3.0 |  4.3207 ns | 0.0107 ns | 0.0095 ns |  4.3215 ns |  1.08 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net461 |  3.4208 ns | 0.0066 ns | 0.0061 ns |  3.4207 ns |  0.85 |    0.00 |     - |     - |     - |         - |
           FromDouble |        net472 |  3.2783 ns | 0.0077 ns | 0.0064 ns |  3.2778 ns |  0.82 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 2.0 |  5.3029 ns | 0.0321 ns | 0.0301 ns |  5.2885 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 2.2 |  4.8901 ns | 0.0148 ns | 0.0138 ns |  4.8878 ns |  0.92 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 3.0 |  4.9600 ns | 0.0144 ns | 0.0127 ns |  4.9588 ns |  0.94 |    0.01 |     - |     - |     - |         - |
   FromDoubleNullable |        net461 |  4.6569 ns | 0.0071 ns | 0.0066 ns |  4.6572 ns |  0.88 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable |        net472 | 16.1697 ns | 0.0127 ns | 0.0119 ns | 16.1686 ns |  3.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 2.0 | 13.4554 ns | 0.0313 ns | 0.0261 ns | 13.4571 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 2.2 | 13.6341 ns | 0.0186 ns | 0.0155 ns | 13.6363 ns |  1.01 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 3.0 |  6.5748 ns | 0.0139 ns | 0.0130 ns |  6.5717 ns |  0.49 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net461 | 13.8990 ns | 0.0252 ns | 0.0223 ns | 13.9043 ns |  1.03 |    0.00 |     - |     - |     - |         - |
          FromDecimal |        net472 | 13.9801 ns | 0.0282 ns | 0.0235 ns | 13.9889 ns |  1.04 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 2.0 | 24.3017 ns | 0.0328 ns | 0.0291 ns | 24.2944 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 2.2 | 24.3522 ns | 0.0270 ns | 0.0252 ns | 24.3602 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 3.0 | 13.3817 ns | 0.1604 ns | 0.1501 ns | 13.3286 ns |  0.55 |    0.01 |     - |     - |     - |         - |
  FromDecimalNullable |        net461 | 24.4733 ns | 0.0292 ns | 0.0274 ns | 24.4764 ns |  1.01 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable |        net472 | 24.6058 ns | 0.2211 ns | 0.2069 ns | 24.4807 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 2.0 |  0.4841 ns | 0.0344 ns | 0.0305 ns |  0.4718 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 2.2 |  0.4518 ns | 0.0068 ns | 0.0064 ns |  0.4512 ns |  0.94 |    0.06 |     - |     - |     - |         - |
         FromDateTime | .NET Core 3.0 |  0.5274 ns | 0.0038 ns | 0.0033 ns |  0.5277 ns |  1.09 |    0.07 |     - |     - |     - |         - |
         FromDateTime |        net461 |  0.7156 ns | 0.0172 ns | 0.0160 ns |  0.7068 ns |  1.48 |    0.10 |     - |     - |     - |         - |
         FromDateTime |        net472 |  0.7084 ns | 0.0047 ns | 0.0044 ns |  0.7071 ns |  1.47 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 2.0 |  1.4325 ns | 0.0059 ns | 0.0055 ns |  1.4305 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 2.2 |  1.4533 ns | 0.0175 ns | 0.0163 ns |  1.4453 ns |  1.01 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 3.0 |  1.2401 ns | 0.0044 ns | 0.0037 ns |  1.2409 ns |  0.87 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable |        net461 |  1.9617 ns | 0.0031 ns | 0.0024 ns |  1.9615 ns |  1.37 |    0.01 |     - |     - |     - |         - |
 FromDateTimeNullable |        net472 |  1.5729 ns | 0.0049 ns | 0.0041 ns |  1.5717 ns |  1.10 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 2.0 |  2.2473 ns | 0.0213 ns | 0.0200 ns |  2.2410 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 2.2 |  2.2562 ns | 0.0200 ns | 0.0187 ns |  2.2457 ns |  1.00 |    0.01 |     - |     - |     - |         - |
           FromObject | .NET Core 3.0 |  2.1436 ns | 0.0048 ns | 0.0040 ns |  2.1441 ns |  0.95 |    0.01 |     - |     - |     - |         - |
           FromObject |        net461 |  2.2643 ns | 0.0032 ns | 0.0027 ns |  2.2650 ns |  1.01 |    0.01 |     - |     - |     - |         - |
           FromObject |        net472 |  2.3574 ns | 0.0299 ns | 0.0280 ns |  2.3426 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 2.0 | 48.1047 ns | 0.3565 ns | 0.3335 ns | 47.8990 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 2.2 | 43.2989 ns | 0.1318 ns | 0.1169 ns | 43.3009 ns |  0.90 |    0.01 |     - |     - |     - |         - |
           FromString | .NET Core 3.0 |  9.1657 ns | 0.0266 ns | 0.0236 ns |  9.1618 ns |  0.19 |    0.00 |     - |     - |     - |         - |
           FromString |        net461 | 46.7323 ns | 0.4222 ns | 0.3950 ns | 46.9145 ns |  0.97 |    0.01 |     - |     - |     - |         - |
           FromString |        net472 | 47.4029 ns | 0.0898 ns | 0.0796 ns | 47.3914 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 2.0 |  1.8984 ns | 0.0089 ns | 0.0074 ns |  1.8959 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 2.2 |  1.6764 ns | 0.0163 ns | 0.0144 ns |  1.6738 ns |  0.88 |    0.01 |     - |     - |     - |         - |
             FromEnum | .NET Core 3.0 |  1.6465 ns | 0.0187 ns | 0.0166 ns |  1.6511 ns |  0.87 |    0.01 |     - |     - |     - |         - |
             FromEnum |        net461 |  1.6665 ns | 0.0045 ns | 0.0038 ns |  1.6657 ns |  0.88 |    0.00 |     - |     - |     - |         - |
             FromEnum |        net472 |  1.6775 ns | 0.0255 ns | 0.0238 ns |  1.6637 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 2.0 |  2.1319 ns | 0.0047 ns | 0.0041 ns |  2.1315 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 2.2 |  2.8730 ns | 0.0076 ns | 0.0067 ns |  2.8758 ns |  1.35 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 3.0 |  2.2759 ns | 0.0033 ns | 0.0031 ns |  2.2765 ns |  1.07 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net461 |  2.5670 ns | 0.0052 ns | 0.0046 ns |  2.5671 ns |  1.20 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable |        net472 |  2.5680 ns | 0.0072 ns | 0.0060 ns |  2.5665 ns |  1.20 |    0.00 |     - |     - |     - |         - |
