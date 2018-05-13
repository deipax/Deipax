
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5171 ns | 0.0015 ns | 0.0012 ns |       0 B |
     FromBoolNullable |  2.0346 ns | 0.0067 ns | 0.0063 ns |       0 B |
             FromChar |  1.0641 ns | 0.0036 ns | 0.0034 ns |       0 B |
     FromCharNullable |  1.8993 ns | 0.0171 ns | 0.0160 ns |       0 B |
            FromSByte |  1.2358 ns | 0.0052 ns | 0.0049 ns |       0 B |
    FromSByteNullable |  1.5653 ns | 0.0057 ns | 0.0053 ns |       0 B |
             FromByte |  1.3356 ns | 0.0045 ns | 0.0042 ns |       0 B |
     FromByteNullable |  1.6221 ns | 0.0026 ns | 0.0023 ns |       0 B |
            FromShort |  1.0067 ns | 0.0025 ns | 0.0022 ns |       0 B |
    FromShortNullable |  1.6760 ns | 0.0056 ns | 0.0047 ns |       0 B |
           FromUShort |  1.0084 ns | 0.0023 ns | 0.0020 ns |       0 B |
   FromUShortNullable |  1.7165 ns | 0.0067 ns | 0.0056 ns |       0 B |
              FromInt |  1.0705 ns | 0.0079 ns | 0.0074 ns |       0 B |
      FromIntNullable |  0.9144 ns | 0.0049 ns | 0.0045 ns |       0 B |
             FromUInt |  2.0128 ns | 0.0063 ns | 0.0056 ns |       0 B |
     FromUIntNullable |  2.5253 ns | 0.0040 ns | 0.0035 ns |       0 B |
             FromLong |  2.5842 ns | 0.0102 ns | 0.0091 ns |       0 B |
     FromLongNullable |  4.3384 ns | 0.0141 ns | 0.0125 ns |       0 B |
            FromULong |  2.5640 ns | 0.0058 ns | 0.0051 ns |       0 B |
    FromULongNullable |  4.3370 ns | 0.0069 ns | 0.0061 ns |       0 B |
            FromFloat |  4.6631 ns | 0.0084 ns | 0.0078 ns |       0 B |
    FromFloatNullable |  5.6491 ns | 0.0156 ns | 0.0146 ns |       0 B |
           FromDouble |  4.4070 ns | 0.0120 ns | 0.0113 ns |       0 B |
   FromDoubleNullable |  5.2915 ns | 0.0076 ns | 0.0071 ns |       0 B |
          FromDecimal | 14.7018 ns | 0.0162 ns | 0.0144 ns |       0 B |
  FromDecimalNullable | 25.4438 ns | 0.0217 ns | 0.0192 ns |       0 B |
         FromDateTime |  1.0090 ns | 0.0030 ns | 0.0028 ns |       0 B |
 FromDateTimeNullable |  1.9174 ns | 0.0033 ns | 0.0030 ns |       0 B |
           FromObject | 13.7918 ns | 0.0053 ns | 0.0041 ns |       0 B |
           FromString | 73.7804 ns | 0.1168 ns | 0.1036 ns |       0 B |
             FromEnum |  1.0109 ns | 0.0046 ns | 0.0043 ns |       0 B |
     FromEnumNullable |  1.5242 ns | 0.0046 ns | 0.0043 ns |       0 B |
