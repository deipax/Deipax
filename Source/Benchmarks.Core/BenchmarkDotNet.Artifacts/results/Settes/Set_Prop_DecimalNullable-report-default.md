
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
--------------------- |-----------:|----------:|----------:|-------:|----------:|
             FromBool |  21.365 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
     FromBoolNullable |  21.367 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
             FromChar |         NA |        NA |        NA |    N/A |       N/A |
     FromCharNullable |   8.422 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
            FromSByte |  21.120 ns | 0.0281 ns | 0.0249 ns |      - |       0 B |
    FromSByteNullable |  21.130 ns | 0.0246 ns | 0.0230 ns |      - |       0 B |
             FromByte |  21.103 ns | 0.0154 ns | 0.0136 ns |      - |       0 B |
     FromByteNullable |  21.099 ns | 0.0137 ns | 0.0115 ns |      - |       0 B |
            FromShort |  21.108 ns | 0.0249 ns | 0.0233 ns |      - |       0 B |
    FromShortNullable |  21.358 ns | 0.0150 ns | 0.0125 ns |      - |       0 B |
           FromUShort |  21.353 ns | 0.0096 ns | 0.0080 ns |      - |       0 B |
   FromUShortNullable |  21.098 ns | 0.0080 ns | 0.0071 ns |      - |       0 B |
              FromInt |  21.361 ns | 0.0211 ns | 0.0197 ns |      - |       0 B |
      FromIntNullable |  21.093 ns | 0.0022 ns | 0.0017 ns |      - |       0 B |
             FromUInt |  21.092 ns | 0.0079 ns | 0.0062 ns |      - |       0 B |
     FromUIntNullable |  21.094 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
             FromLong |  21.356 ns | 0.0204 ns | 0.0191 ns |      - |       0 B |
     FromLongNullable |  21.390 ns | 0.0422 ns | 0.0394 ns |      - |       0 B |
            FromULong |  21.106 ns | 0.0141 ns | 0.0125 ns |      - |       0 B |
    FromULongNullable |  21.094 ns | 0.0038 ns | 0.0030 ns |      - |       0 B |
            FromFloat |  43.361 ns | 0.0625 ns | 0.0584 ns |      - |       0 B |
    FromFloatNullable |  43.246 ns | 0.0141 ns | 0.0131 ns |      - |       0 B |
           FromDouble |  82.067 ns | 0.0574 ns | 0.0537 ns |      - |       0 B |
   FromDoubleNullable |  82.072 ns | 0.0575 ns | 0.0538 ns |      - |       0 B |
          FromDecimal |  15.785 ns | 0.0169 ns | 0.0158 ns |      - |       0 B |
  FromDecimalNullable |  15.524 ns | 0.0132 ns | 0.0123 ns |      - |       0 B |
         FromDateTime |         NA |        NA |        NA |    N/A |       N/A |
 FromDateTimeNullable |   8.415 ns | 0.0082 ns | 0.0073 ns |      - |       0 B |
           FromObject |  16.087 ns | 0.0075 ns | 0.0058 ns |      - |       0 B |
           FromString | 120.184 ns | 0.0511 ns | 0.0427 ns |      - |       0 B |
             FromEnum |  47.659 ns | 0.0545 ns | 0.0510 ns | 0.0057 |      24 B |

Benchmarks with issues:
  Set_Prop_DecimalNullable.FromChar: DefaultJob
  Set_Prop_DecimalNullable.FromDateTime: DefaultJob
