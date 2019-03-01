
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 16.5135 ns | 0.0667 ns | 0.0591 ns |           - |           - |           - |                   - |
     FromBoolNullable | 17.2770 ns | 0.1040 ns | 0.0973 ns |           - |           - |           - |                   - |
             FromChar |  0.5941 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.9332 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
            FromSByte | 15.8401 ns | 0.0901 ns | 0.0843 ns |           - |           - |           - |                   - |
    FromSByteNullable | 17.6089 ns | 0.1245 ns | 0.1165 ns |           - |           - |           - |                   - |
             FromByte | 16.4801 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
     FromByteNullable | 16.3541 ns | 0.1130 ns | 0.1057 ns |           - |           - |           - |                   - |
            FromShort | 16.5043 ns | 0.1408 ns | 0.1317 ns |           - |           - |           - |                   - |
    FromShortNullable | 16.2565 ns | 0.0749 ns | 0.0701 ns |           - |           - |           - |                   - |
           FromUShort | 16.5203 ns | 0.1284 ns | 0.1201 ns |           - |           - |           - |                   - |
   FromUShortNullable | 17.0230 ns | 0.0762 ns | 0.0636 ns |           - |           - |           - |                   - |
              FromInt | 16.0632 ns | 0.0720 ns | 0.0638 ns |           - |           - |           - |                   - |
      FromIntNullable | 16.3570 ns | 0.0663 ns | 0.0620 ns |           - |           - |           - |                   - |
             FromUInt | 15.9339 ns | 0.0903 ns | 0.0845 ns |           - |           - |           - |                   - |
     FromUIntNullable | 16.3204 ns | 0.0689 ns | 0.0644 ns |           - |           - |           - |                   - |
             FromLong | 16.6052 ns | 0.1086 ns | 0.1016 ns |           - |           - |           - |                   - |
     FromLongNullable | 17.4638 ns | 0.1162 ns | 0.1087 ns |           - |           - |           - |                   - |
            FromULong | 15.9279 ns | 0.1105 ns | 0.1033 ns |           - |           - |           - |                   - |
    FromULongNullable | 17.9511 ns | 0.0993 ns | 0.0929 ns |           - |           - |           - |                   - |
            FromFloat | 31.3946 ns | 0.2058 ns | 0.1925 ns |           - |           - |           - |                   - |
    FromFloatNullable | 31.8993 ns | 0.2743 ns | 0.2566 ns |           - |           - |           - |                   - |
           FromDouble | 60.6119 ns | 0.3680 ns | 0.3443 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 61.8973 ns | 0.2980 ns | 0.2488 ns |           - |           - |           - |                   - |
          FromDecimal |  5.2370 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  1.8660 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6969 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5624 ns | 0.0191 ns | 0.0179 ns |           - |           - |           - |                   - |
           FromObject | 20.6857 ns | 0.0757 ns | 0.0708 ns |           - |           - |           - |                   - |
           FromString | 74.4821 ns | 0.2502 ns | 0.2341 ns |           - |           - |           - |                   - |
             FromEnum | 16.4973 ns | 0.0869 ns | 0.0813 ns |           - |           - |           - |                   - |
     FromEnumNullable | 16.9671 ns | 0.1234 ns | 0.1154 ns |           - |           - |           - |                   - |
