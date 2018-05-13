
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.294 ns | 0.0025 ns | 0.0022 ns |       0 B |
     FromBoolNullable |  1.808 ns | 0.0035 ns | 0.0033 ns |       0 B |
             FromChar |  1.043 ns | 0.0025 ns | 0.0023 ns |       0 B |
     FromCharNullable |  1.806 ns | 0.0027 ns | 0.0023 ns |       0 B |
            FromSByte |  2.345 ns | 0.0053 ns | 0.0050 ns |       0 B |
    FromSByteNullable |  2.282 ns | 0.0047 ns | 0.0044 ns |       0 B |
             FromByte |  1.042 ns | 0.0030 ns | 0.0027 ns |       0 B |
     FromByteNullable |  1.804 ns | 0.0005 ns | 0.0004 ns |       0 B |
            FromShort |  1.939 ns | 0.0065 ns | 0.0061 ns |       0 B |
    FromShortNullable |  2.808 ns | 0.0411 ns | 0.0384 ns |       0 B |
           FromUShort |  1.040 ns | 0.0032 ns | 0.0030 ns |       0 B |
   FromUShortNullable |  1.063 ns | 0.0018 ns | 0.0016 ns |       0 B |
              FromInt |  2.671 ns | 0.0075 ns | 0.0066 ns |       0 B |
      FromIntNullable |  2.507 ns | 0.0184 ns | 0.0144 ns |       0 B |
             FromUInt |  2.024 ns | 0.0089 ns | 0.0084 ns |       0 B |
     FromUIntNullable |  3.646 ns | 0.0074 ns | 0.0070 ns |       0 B |
             FromLong |  2.756 ns | 0.0077 ns | 0.0068 ns |       0 B |
     FromLongNullable |  2.335 ns | 0.0064 ns | 0.0057 ns |       0 B |
            FromULong |  2.599 ns | 0.0107 ns | 0.0095 ns |       0 B |
    FromULongNullable |  2.331 ns | 0.0028 ns | 0.0026 ns |       0 B |
            FromFloat |  5.649 ns | 0.0136 ns | 0.0128 ns |       0 B |
    FromFloatNullable |  2.468 ns | 0.0064 ns | 0.0054 ns |       0 B |
           FromDouble |  5.609 ns | 0.0063 ns | 0.0056 ns |       0 B |
   FromDoubleNullable |  2.960 ns | 0.0088 ns | 0.0082 ns |       0 B |
          FromDecimal | 15.486 ns | 0.0117 ns | 0.0109 ns |       0 B |
  FromDecimalNullable |  8.414 ns | 0.0045 ns | 0.0035 ns |       0 B |
         FromDateTime |  1.133 ns | 0.0014 ns | 0.0012 ns |       0 B |
 FromDateTimeNullable |  3.096 ns | 0.0088 ns | 0.0082 ns |       0 B |
           FromObject |  3.876 ns | 0.0019 ns | 0.0016 ns |       0 B |
           FromString |  2.834 ns | 0.0029 ns | 0.0026 ns |       0 B |
             FromEnum |  2.740 ns | 0.0040 ns | 0.0037 ns |       0 B |
     FromEnumNullable |  3.081 ns | 0.0472 ns | 0.0419 ns |       0 B |
