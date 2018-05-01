
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  16.701 ns | 0.0237 ns | 0.0211 ns |      - |       0 B |
     FromBoolNullable |  16.819 ns | 0.0252 ns | 0.0223 ns |      - |       0 B |
             FromChar |         NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |   8.269 ns | 0.0173 ns | 0.0162 ns |      - |       0 B |
            FromSByte |  16.834 ns | 0.0312 ns | 0.0292 ns |      - |       0 B |
    FromSByteNullable |  16.702 ns | 0.0108 ns | 0.0096 ns |      - |       0 B |
             FromByte |  16.691 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
     FromByteNullable |  16.708 ns | 0.0100 ns | 0.0078 ns |      - |       0 B |
            FromShort |  16.956 ns | 0.0143 ns | 0.0134 ns |      - |       0 B |
    FromShortNullable |  17.081 ns | 0.0349 ns | 0.0326 ns |      - |       0 B |
           FromUShort |  16.803 ns | 0.0077 ns | 0.0064 ns |      - |       0 B |
   FromUShortNullable |  16.817 ns | 0.0229 ns | 0.0214 ns |      - |       0 B |
              FromInt |  16.815 ns | 0.0159 ns | 0.0148 ns |      - |       0 B |
      FromIntNullable |  16.701 ns | 0.0175 ns | 0.0155 ns |      - |       0 B |
             FromUInt |  16.941 ns | 0.0161 ns | 0.0143 ns |      - |       0 B |
     FromUIntNullable |  16.948 ns | 0.0215 ns | 0.0201 ns |      - |       0 B |
             FromLong |  16.952 ns | 0.0216 ns | 0.0202 ns |      - |       0 B |
     FromLongNullable |  16.948 ns | 0.0242 ns | 0.0227 ns |      - |       0 B |
            FromULong |  17.451 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
    FromULongNullable |  17.455 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
            FromFloat |  16.676 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
    FromFloatNullable |  16.701 ns | 0.0258 ns | 0.0241 ns |      - |       0 B |
           FromDouble |  14.103 ns | 0.0148 ns | 0.0132 ns |      - |       0 B |
   FromDoubleNullable |  14.087 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
          FromDecimal |  22.063 ns | 0.0167 ns | 0.0148 ns |      - |       0 B |
  FromDecimalNullable |  22.050 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
         FromDateTime |         NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |   8.263 ns | 0.0099 ns | 0.0092 ns |      - |       0 B |
           FromObject |  14.276 ns | 0.0187 ns | 0.0156 ns |      - |       0 B |
           FromString | 106.218 ns | 0.1702 ns | 0.1592 ns |      - |       0 B |
             FromEnum |  48.147 ns | 0.0478 ns | 0.0424 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_DoubleNullable.FromChar: DefaultJob
  Set_Prop_DoubleNullable.FromDateTime: DefaultJob
