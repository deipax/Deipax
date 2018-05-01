
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |        NA |        NA |        NA |       N/A |
     FromBoolNullable |  8.619 ns | 0.0130 ns | 0.0122 ns |       0 B |
             FromChar |        NA |        NA |        NA |       N/A |
     FromCharNullable |  8.613 ns | 0.0081 ns | 0.0068 ns |       0 B |
            FromSByte |        NA |        NA |        NA |       N/A |
    FromSByteNullable |  8.613 ns | 0.0040 ns | 0.0034 ns |       0 B |
             FromByte |        NA |        NA |        NA |       N/A |
     FromByteNullable |  8.612 ns | 0.0122 ns | 0.0108 ns |       0 B |
            FromShort |        NA |        NA |        NA |       N/A |
    FromShortNullable |  8.611 ns | 0.0049 ns | 0.0041 ns |       0 B |
           FromUShort |        NA |        NA |        NA |       N/A |
   FromUShortNullable | 10.051 ns | 0.0089 ns | 0.0079 ns |       0 B |
              FromInt |        NA |        NA |        NA |       N/A |
      FromIntNullable |  8.611 ns | 0.0035 ns | 0.0033 ns |       0 B |
             FromUInt |        NA |        NA |        NA |       N/A |
     FromUIntNullable |  8.611 ns | 0.0035 ns | 0.0033 ns |       0 B |
             FromLong |        NA |        NA |        NA |       N/A |
     FromLongNullable |  8.620 ns | 0.0044 ns | 0.0037 ns |       0 B |
            FromULong |        NA |        NA |        NA |       N/A |
    FromULongNullable | 10.058 ns | 0.0011 ns | 0.0010 ns |       0 B |
            FromFloat |        NA |        NA |        NA |       N/A |
    FromFloatNullable |  8.618 ns | 0.0075 ns | 0.0063 ns |       0 B |
           FromDouble |        NA |        NA |        NA |       N/A |
   FromDoubleNullable |  8.617 ns | 0.0025 ns | 0.0024 ns |       0 B |
          FromDecimal |        NA |        NA |        NA |       N/A |
  FromDecimalNullable |  8.618 ns | 0.0041 ns | 0.0036 ns |       0 B |
         FromDateTime | 14.871 ns | 0.0603 ns | 0.0535 ns |       0 B |
 FromDateTimeNullable |  8.616 ns | 0.0074 ns | 0.0066 ns |       0 B |
           FromObject |  8.612 ns | 0.0016 ns | 0.0013 ns |       0 B |
           FromString |  8.623 ns | 0.0082 ns | 0.0077 ns |       0 B |
             FromEnum |        NA |        NA |        NA |       N/A |

Benchmarks with issues:
  Set_Prop_DateTimeNullable_NoValue.FromBool: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromChar: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromSByte: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromByte: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromShort: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromUShort: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromInt: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromUInt: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromLong: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromULong: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromFloat: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromDouble: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromDecimal: DefaultJob
  Set_Prop_DateTimeNullable_NoValue.FromEnum: DefaultJob
