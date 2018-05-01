
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |         NA |        NA |        NA |       N/A |
     FromBoolNullable |   8.368 ns | 0.0114 ns | 0.0107 ns |       0 B |
             FromChar |         NA |        NA |        NA |       N/A |
     FromCharNullable |   8.342 ns | 0.0052 ns | 0.0041 ns |       0 B |
            FromSByte |         NA |        NA |        NA |       N/A |
    FromSByteNullable |   8.336 ns | 0.0097 ns | 0.0086 ns |       0 B |
             FromByte |         NA |        NA |        NA |       N/A |
     FromByteNullable |   8.388 ns | 0.0036 ns | 0.0028 ns |       0 B |
            FromShort |         NA |        NA |        NA |       N/A |
    FromShortNullable |   8.401 ns | 0.0142 ns | 0.0133 ns |       0 B |
           FromUShort |         NA |        NA |        NA |       N/A |
   FromUShortNullable |   8.369 ns | 0.0066 ns | 0.0062 ns |       0 B |
              FromInt |         NA |        NA |        NA |       N/A |
      FromIntNullable |   8.366 ns | 0.0141 ns | 0.0132 ns |       0 B |
             FromUInt |         NA |        NA |        NA |       N/A |
     FromUIntNullable |   8.389 ns | 0.0026 ns | 0.0022 ns |       0 B |
             FromLong |         NA |        NA |        NA |       N/A |
     FromLongNullable |   8.361 ns | 0.0071 ns | 0.0063 ns |       0 B |
            FromULong |         NA |        NA |        NA |       N/A |
    FromULongNullable |   8.368 ns | 0.0094 ns | 0.0083 ns |       0 B |
            FromFloat |         NA |        NA |        NA |       N/A |
    FromFloatNullable |   8.366 ns | 0.0089 ns | 0.0084 ns |       0 B |
           FromDouble |         NA |        NA |        NA |       N/A |
   FromDoubleNullable |   8.386 ns | 0.0059 ns | 0.0055 ns |       0 B |
          FromDecimal |         NA |        NA |        NA |       N/A |
  FromDecimalNullable |   8.362 ns | 0.0071 ns | 0.0063 ns |       0 B |
         FromDateTime |  14.073 ns | 0.0288 ns | 0.0269 ns |       0 B |
 FromDateTimeNullable |  14.385 ns | 0.0217 ns | 0.0192 ns |       0 B |
           FromObject |  14.002 ns | 0.0161 ns | 0.0143 ns |       0 B |
           FromString | 558.290 ns | 0.6731 ns | 0.6296 ns |       0 B |
             FromEnum |         NA |        NA |        NA |       N/A |

Benchmarks with issues:
  Set_Prop_DateTimeNullable.FromBool: DefaultJob
  Set_Prop_DateTimeNullable.FromChar: DefaultJob
  Set_Prop_DateTimeNullable.FromSByte: DefaultJob
  Set_Prop_DateTimeNullable.FromByte: DefaultJob
  Set_Prop_DateTimeNullable.FromShort: DefaultJob
  Set_Prop_DateTimeNullable.FromUShort: DefaultJob
  Set_Prop_DateTimeNullable.FromInt: DefaultJob
  Set_Prop_DateTimeNullable.FromUInt: DefaultJob
  Set_Prop_DateTimeNullable.FromLong: DefaultJob
  Set_Prop_DateTimeNullable.FromULong: DefaultJob
  Set_Prop_DateTimeNullable.FromFloat: DefaultJob
  Set_Prop_DateTimeNullable.FromDouble: DefaultJob
  Set_Prop_DateTimeNullable.FromDecimal: DefaultJob
  Set_Prop_DateTimeNullable.FromEnum: DefaultJob
