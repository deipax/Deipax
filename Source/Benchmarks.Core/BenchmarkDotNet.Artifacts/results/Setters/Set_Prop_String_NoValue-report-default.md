
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |   5.388 ns | 0.0093 ns | 0.0087 ns |      - |       0 B |
     FromBoolNullable |   3.347 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
             FromChar |   6.731 ns | 0.0085 ns | 0.0071 ns | 0.0076 |      32 B |
     FromCharNullable |   3.347 ns | 0.0065 ns | 0.0060 ns |      - |       0 B |
            FromSByte |  42.708 ns | 0.1026 ns | 0.0959 ns | 0.0076 |      32 B |
    FromSByteNullable |   3.607 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
             FromByte |  42.862 ns | 0.0841 ns | 0.0787 ns | 0.0076 |      32 B |
     FromByteNullable |   3.345 ns | 0.0032 ns | 0.0027 ns |      - |       0 B |
            FromShort |  43.224 ns | 0.0210 ns | 0.0175 ns | 0.0076 |      32 B |
    FromShortNullable |   3.606 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
           FromUShort |  38.704 ns | 0.0668 ns | 0.0592 ns | 0.0076 |      32 B |
   FromUShortNullable |   3.345 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
              FromInt |  42.812 ns | 0.0737 ns | 0.0689 ns | 0.0076 |      32 B |
      FromIntNullable |   3.348 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
             FromUInt |  38.631 ns | 0.0870 ns | 0.0814 ns | 0.0076 |      32 B |
     FromUIntNullable |   3.598 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
             FromLong |  45.111 ns | 0.1371 ns | 0.1215 ns | 0.0076 |      32 B |
     FromLongNullable |   4.115 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
            FromULong |  43.723 ns | 0.1061 ns | 0.0993 ns | 0.0076 |      32 B |
    FromULongNullable |   4.111 ns | 0.0048 ns | 0.0045 ns |      - |       0 B |
            FromFloat | 138.828 ns | 0.8114 ns | 0.7192 ns | 0.0074 |      32 B |
    FromFloatNullable |   3.597 ns | 0.0096 ns | 0.0085 ns |      - |       0 B |
           FromDouble | 154.772 ns | 0.0832 ns | 0.0695 ns | 0.0074 |      32 B |
   FromDoubleNullable |   4.116 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
          FromDecimal |  71.246 ns | 0.1556 ns | 0.1456 ns | 0.0075 |      32 B |
  FromDecimalNullable |   9.136 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
         FromDateTime | 412.633 ns | 0.3563 ns | 0.2975 ns | 0.0401 |     168 B |
 FromDateTimeNullable |   4.116 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
           FromObject |   4.373 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
           FromString |   2.829 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
             FromEnum | 139.210 ns | 0.2123 ns | 0.1882 ns | 0.0191 |      80 B |
     FromEnumNullable |   3.604 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
