
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  1.520 ns | 0.0025 ns | 0.0023 ns |       0 B |
     FromBoolNullable |  2.032 ns | 0.0052 ns | 0.0049 ns |       0 B |
             FromChar |  1.250 ns | 0.0043 ns | 0.0038 ns |       0 B |
     FromCharNullable |  1.702 ns | 0.0048 ns | 0.0042 ns |       0 B |
            FromSByte |  1.924 ns | 0.0071 ns | 0.0063 ns |       0 B |
    FromSByteNullable |  2.877 ns | 0.0070 ns | 0.0058 ns |       0 B |
             FromByte |  1.005 ns | 0.0045 ns | 0.0040 ns |       0 B |
     FromByteNullable |  1.839 ns | 0.0110 ns | 0.0103 ns |       0 B |
            FromShort |  1.933 ns | 0.0105 ns | 0.0099 ns |       0 B |
    FromShortNullable |  3.197 ns | 0.0338 ns | 0.0283 ns |       0 B |
           FromUShort |  1.049 ns | 0.0030 ns | 0.0028 ns |       0 B |
   FromUShortNullable |  1.049 ns | 0.0016 ns | 0.0014 ns |       0 B |
              FromInt |  2.758 ns | 0.0457 ns | 0.0428 ns |       0 B |
      FromIntNullable |  3.905 ns | 0.0041 ns | 0.0039 ns |       0 B |
             FromUInt |  2.706 ns | 0.0060 ns | 0.0053 ns |       0 B |
     FromUIntNullable |  2.945 ns | 0.0109 ns | 0.0101 ns |       0 B |
             FromLong |  2.746 ns | 0.0059 ns | 0.0046 ns |       0 B |
     FromLongNullable |  4.352 ns | 0.0254 ns | 0.0212 ns |       0 B |
            FromULong |  2.574 ns | 0.0077 ns | 0.0068 ns |       0 B |
    FromULongNullable |  4.338 ns | 0.0077 ns | 0.0068 ns |       0 B |
            FromFloat |  5.658 ns | 0.0125 ns | 0.0111 ns |       0 B |
    FromFloatNullable |  6.917 ns | 0.0153 ns | 0.0143 ns |       0 B |
           FromDouble |  5.606 ns | 0.0142 ns | 0.0133 ns |       0 B |
   FromDoubleNullable |  6.860 ns | 0.0100 ns | 0.0094 ns |       0 B |
          FromDecimal | 15.549 ns | 0.0217 ns | 0.0193 ns |       0 B |
  FromDecimalNullable | 30.045 ns | 0.0225 ns | 0.0188 ns |       0 B |
         FromDateTime |  1.009 ns | 0.0036 ns | 0.0034 ns |       0 B |
 FromDateTimeNullable |  1.901 ns | 0.0070 ns | 0.0065 ns |       0 B |
           FromObject | 14.673 ns | 0.0398 ns | 0.0373 ns |       0 B |
           FromString | 73.481 ns | 0.0693 ns | 0.0614 ns |       0 B |
             FromEnum |  2.714 ns | 0.0023 ns | 0.0021 ns |       0 B |
     FromEnumNullable |  4.627 ns | 0.0081 ns | 0.0076 ns |       0 B |
