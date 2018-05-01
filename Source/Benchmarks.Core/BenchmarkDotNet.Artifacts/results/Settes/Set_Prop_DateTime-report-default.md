
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |         NA |        NA |        NA |       N/A |
     FromBoolNullable |   7.356 ns | 0.0052 ns | 0.0046 ns |       0 B |
             FromChar |         NA |        NA |        NA |       N/A |
     FromCharNullable |   7.256 ns | 0.0146 ns | 0.0137 ns |       0 B |
            FromSByte |         NA |        NA |        NA |       N/A |
    FromSByteNullable |   7.218 ns | 0.0047 ns | 0.0042 ns |       0 B |
             FromByte |         NA |        NA |        NA |       N/A |
     FromByteNullable |   8.321 ns | 0.0049 ns | 0.0044 ns |       0 B |
            FromShort |         NA |        NA |        NA |       N/A |
    FromShortNullable |   7.215 ns | 0.0042 ns | 0.0039 ns |       0 B |
           FromUShort |         NA |        NA |        NA |       N/A |
   FromUShortNullable |   7.234 ns | 0.0067 ns | 0.0063 ns |       0 B |
              FromInt |         NA |        NA |        NA |       N/A |
      FromIntNullable |   7.222 ns | 0.0025 ns | 0.0023 ns |       0 B |
             FromUInt |         NA |        NA |        NA |       N/A |
     FromUIntNullable |   7.206 ns | 0.0027 ns | 0.0024 ns |       0 B |
             FromLong |         NA |        NA |        NA |       N/A |
     FromLongNullable |   7.221 ns | 0.0032 ns | 0.0028 ns |       0 B |
            FromULong |         NA |        NA |        NA |       N/A |
    FromULongNullable |   7.261 ns | 0.0040 ns | 0.0031 ns |       0 B |
            FromFloat |         NA |        NA |        NA |       N/A |
    FromFloatNullable |   7.256 ns | 0.0049 ns | 0.0041 ns |       0 B |
           FromDouble |         NA |        NA |        NA |       N/A |
   FromDoubleNullable |   7.217 ns | 0.0052 ns | 0.0049 ns |       0 B |
          FromDecimal |         NA |        NA |        NA |       N/A |
  FromDecimalNullable |   7.216 ns | 0.0017 ns | 0.0013 ns |       0 B |
         FromDateTime |   3.367 ns | 0.0035 ns | 0.0027 ns |       0 B |
 FromDateTimeNullable |   3.345 ns | 0.0039 ns | 0.0036 ns |       0 B |
           FromObject |   3.566 ns | 0.0060 ns | 0.0053 ns |       0 B |
           FromString | 555.783 ns | 2.5293 ns | 2.3659 ns |       0 B |
             FromEnum |         NA |        NA |        NA |       N/A |

Benchmarks with issues:
  Set_Prop_DateTime.FromBool: DefaultJob
  Set_Prop_DateTime.FromChar: DefaultJob
  Set_Prop_DateTime.FromSByte: DefaultJob
  Set_Prop_DateTime.FromByte: DefaultJob
  Set_Prop_DateTime.FromShort: DefaultJob
  Set_Prop_DateTime.FromUShort: DefaultJob
  Set_Prop_DateTime.FromInt: DefaultJob
  Set_Prop_DateTime.FromUInt: DefaultJob
  Set_Prop_DateTime.FromLong: DefaultJob
  Set_Prop_DateTime.FromULong: DefaultJob
  Set_Prop_DateTime.FromFloat: DefaultJob
  Set_Prop_DateTime.FromDouble: DefaultJob
  Set_Prop_DateTime.FromDecimal: DefaultJob
  Set_Prop_DateTime.FromEnum: DefaultJob
