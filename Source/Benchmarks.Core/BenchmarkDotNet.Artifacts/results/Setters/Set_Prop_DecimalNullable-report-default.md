
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  14.956 ns | 0.0010 ns | 0.0008 ns |       0 B |
     FromBoolNullable |  15.192 ns | 0.0023 ns | 0.0018 ns |       0 B |
             FromChar |   4.703 ns | 0.0060 ns | 0.0056 ns |       0 B |
     FromCharNullable |   4.620 ns | 0.0022 ns | 0.0021 ns |       0 B |
            FromSByte |  14.699 ns | 0.0016 ns | 0.0013 ns |       0 B |
    FromSByteNullable |  15.200 ns | 0.0089 ns | 0.0083 ns |       0 B |
             FromByte |  14.956 ns | 0.0011 ns | 0.0009 ns |       0 B |
     FromByteNullable |  15.194 ns | 0.0017 ns | 0.0013 ns |       0 B |
            FromShort |  14.963 ns | 0.0136 ns | 0.0127 ns |       0 B |
    FromShortNullable |  15.200 ns | 0.0111 ns | 0.0098 ns |       0 B |
           FromUShort |  14.699 ns | 0.0021 ns | 0.0016 ns |       0 B |
   FromUShortNullable |  15.198 ns | 0.0073 ns | 0.0068 ns |       0 B |
              FromInt |  14.701 ns | 0.0009 ns | 0.0007 ns |       0 B |
      FromIntNullable |  15.193 ns | 0.0016 ns | 0.0013 ns |       0 B |
             FromUInt |  14.955 ns | 0.0007 ns | 0.0006 ns |       0 B |
     FromUIntNullable |  15.204 ns | 0.0098 ns | 0.0092 ns |       0 B |
             FromLong |  15.211 ns | 0.0008 ns | 0.0006 ns |       0 B |
     FromLongNullable |  15.728 ns | 0.0102 ns | 0.0090 ns |       0 B |
            FromULong |  14.700 ns | 0.0007 ns | 0.0006 ns |       0 B |
    FromULongNullable |  15.473 ns | 0.0126 ns | 0.0112 ns |       0 B |
            FromFloat |  33.995 ns | 0.0592 ns | 0.0494 ns |       0 B |
    FromFloatNullable |  34.469 ns | 0.0171 ns | 0.0133 ns |       0 B |
           FromDouble |  68.795 ns | 0.0057 ns | 0.0050 ns |       0 B |
   FromDoubleNullable |  70.025 ns | 0.0359 ns | 0.0318 ns |       0 B |
          FromDecimal |   6.271 ns | 0.0007 ns | 0.0006 ns |       0 B |
  FromDecimalNullable |   1.800 ns | 0.0068 ns | 0.0064 ns |       0 B |
         FromDateTime |   4.853 ns | 0.0084 ns | 0.0079 ns |       0 B |
 FromDateTimeNullable |   5.129 ns | 0.0031 ns | 0.0028 ns |       0 B |
           FromObject |  15.136 ns | 0.0063 ns | 0.0052 ns |       0 B |
           FromString | 109.926 ns | 0.0485 ns | 0.0430 ns |       0 B |
             FromEnum |  14.955 ns | 0.0024 ns | 0.0021 ns |       0 B |
     FromEnumNullable |  15.207 ns | 0.0095 ns | 0.0089 ns |       0 B |
