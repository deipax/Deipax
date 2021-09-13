
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.7700 ns |  0.0498 ns | 0.0027 ns |  0.7693 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9760 ns |  0.3920 ns | 0.0215 ns |  0.9676 ns |  1.27 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.4550 ns |  0.3784 ns | 0.0207 ns |  1.4434 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.6566 ns |  0.0573 ns | 0.0031 ns |  1.6550 ns |  1.14 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.6276 ns |  0.9384 ns | 0.0514 ns |  0.5985 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7606 ns |  0.3405 ns | 0.0187 ns |  0.7575 ns |  1.22 |    0.10 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.2072 ns |  0.4173 ns | 0.0229 ns |  1.2082 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.3029 ns |  0.8531 ns | 0.0468 ns |  1.2925 ns |  1.08 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.6763 ns |  0.0076 ns | 0.0004 ns |  0.6763 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7780 ns |  0.4667 ns | 0.0256 ns |  0.7841 ns |  1.15 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0579 ns |  0.7184 ns | 0.0394 ns |  1.0363 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.2553 ns |  0.0592 ns | 0.0032 ns |  1.2555 ns |  1.19 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7838 ns |  1.3412 ns | 0.0735 ns |  0.7715 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.9665 ns |  0.1392 ns | 0.0076 ns |  0.9638 ns |  1.24 |    0.11 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.8283 ns |  0.7224 ns | 0.0396 ns |  1.8101 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2975 ns |  0.4201 ns | 0.0230 ns |  1.3055 ns |  0.71 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7069 ns |  0.8307 ns | 0.0455 ns |  0.6850 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7724 ns |  0.3212 ns | 0.0176 ns |  0.7652 ns |  1.10 |    0.09 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2239 ns |  0.4746 ns | 0.0260 ns |  1.2146 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2790 ns |  0.0847 ns | 0.0046 ns |  1.2781 ns |  1.05 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.5927 ns |  0.1347 ns | 0.0074 ns |  0.5919 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7268 ns |  0.1395 ns | 0.0076 ns |  0.7304 ns |  1.23 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.1630 ns |  0.3272 ns | 0.0179 ns |  1.1560 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2943 ns |  0.3353 ns | 0.0184 ns |  1.2996 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.7716 ns |  0.0462 ns | 0.0025 ns |  0.7710 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.9696 ns |  0.1458 ns | 0.0080 ns |  0.9683 ns |  1.26 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.1776 ns |  0.3000 ns | 0.0164 ns |  1.1793 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2329 ns |  0.1271 ns | 0.0070 ns |  1.2365 ns |  1.05 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.9574 ns |  1.5298 ns | 0.0839 ns |  0.9167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7448 ns |  0.0614 ns | 0.0034 ns |  0.7435 ns |  0.78 |    0.07 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.1970 ns |  0.5357 ns | 0.0294 ns |  1.1885 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.1634 ns |  0.5492 ns | 0.0301 ns |  1.1463 ns |  0.97 |    0.05 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.7327 ns |  0.4611 ns | 0.0253 ns |  0.7223 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.7841 ns |  0.0152 ns | 0.0008 ns |  0.7838 ns |  1.07 |    0.04 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.5907 ns |  0.6158 ns | 0.0338 ns |  1.5756 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.7582 ns |  0.7845 ns | 0.0430 ns |  1.7749 ns |  1.11 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  2.6817 ns |  0.4691 ns | 0.0257 ns |  2.6885 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.9529 ns |  0.4923 ns | 0.0270 ns |  0.9399 ns |  0.36 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.2076 ns |  0.1548 ns | 0.0085 ns |  1.2056 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.2124 ns |  0.4247 ns | 0.0233 ns |  1.2160 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.9468 ns |  0.3996 ns | 0.0219 ns |  4.9584 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  2.3091 ns |  0.1927 ns | 0.0106 ns |  2.3075 ns |  0.47 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  3.1176 ns |  0.7469 ns | 0.0409 ns |  3.1375 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  2.8106 ns |  0.0694 ns | 0.0038 ns |  2.8106 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  2.0830 ns |  0.1327 ns | 0.0073 ns |  2.0843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  2.0960 ns |  0.6000 ns | 0.0329 ns |  2.0797 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.2337 ns |  0.1452 ns | 0.0080 ns |  3.2304 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.4215 ns |  2.1029 ns | 0.1153 ns |  3.3837 ns |  1.06 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.0551 ns |  0.8426 ns | 0.0462 ns |  6.0657 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  7.9728 ns |  0.1718 ns | 0.0094 ns |  7.9692 ns |  1.32 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 12.9586 ns |  0.5313 ns | 0.0291 ns | 12.9432 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.6960 ns |  2.3388 ns | 0.1282 ns |  9.7504 ns |  0.75 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.7748 ns |  0.1767 ns | 0.0097 ns |  0.7704 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7013 ns |  0.1153 ns | 0.0063 ns |  0.6988 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5370 ns |  0.0912 ns | 0.0050 ns |  1.5365 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2764 ns |  0.1040 ns | 0.0057 ns |  1.2797 ns |  0.83 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.1568 ns |  0.9278 ns | 0.0509 ns | 12.1552 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.5737 ns |  1.2512 ns | 0.0686 ns | 11.5521 ns |  0.95 |    0.00 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 30.8921 ns | 17.0932 ns | 0.9369 ns | 30.8633 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 10.1739 ns |  2.6434 ns | 0.1449 ns | 10.1490 ns |  0.33 |    0.01 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7984 ns |  0.4133 ns | 0.0227 ns |  0.8052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.9454 ns |  0.0627 ns | 0.0034 ns |  0.9436 ns |  1.18 |    0.03 |     - |     - |     - |         - |
                      |               |            |            |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.3110 ns |  3.4707 ns | 0.1902 ns |  1.2502 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2341 ns |  0.2275 ns | 0.0125 ns |  1.2355 ns |  0.95 |    0.12 |     - |     - |     - |         - |
