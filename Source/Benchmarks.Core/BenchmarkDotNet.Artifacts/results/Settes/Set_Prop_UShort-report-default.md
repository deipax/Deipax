
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  3.6886 ns | 0.0080 ns | 0.0075 ns |       0 B |
     FromBoolNullable |  4.6054 ns | 0.0063 ns | 0.0056 ns |       0 B |
             FromChar |  3.6763 ns | 0.0012 ns | 0.0009 ns |       0 B |
     FromCharNullable |  4.2331 ns | 0.0014 ns | 0.0012 ns |       0 B |
            FromSByte |  5.0069 ns | 0.0102 ns | 0.0085 ns |       0 B |
    FromSByteNullable |  4.7166 ns | 0.0018 ns | 0.0015 ns |       0 B |
             FromByte |  3.7579 ns | 0.0033 ns | 0.0028 ns |       0 B |
     FromByteNullable |  4.6842 ns | 0.0025 ns | 0.0021 ns |       0 B |
            FromShort |  4.4046 ns | 0.0153 ns | 0.0143 ns |       0 B |
    FromShortNullable |  4.8358 ns | 0.0024 ns | 0.0019 ns |       0 B |
           FromUShort |  0.7828 ns | 0.0003 ns | 0.0002 ns |       0 B |
   FromUShortNullable |  1.7420 ns | 0.0651 ns | 0.0823 ns |       0 B |
              FromInt |  5.3675 ns | 0.0091 ns | 0.0081 ns |       0 B |
      FromIntNullable |  5.6391 ns | 0.0037 ns | 0.0033 ns |       0 B |
             FromUInt |  4.6272 ns | 0.0287 ns | 0.0239 ns |       0 B |
     FromUIntNullable |  4.8234 ns | 0.0046 ns | 0.0041 ns |       0 B |
             FromLong |  4.5801 ns | 0.0019 ns | 0.0015 ns |       0 B |
     FromLongNullable |  6.6600 ns | 0.0029 ns | 0.0027 ns |       0 B |
            FromULong |  4.8235 ns | 0.0040 ns | 0.0036 ns |       0 B |
    FromULongNullable |  6.4188 ns | 0.0017 ns | 0.0013 ns |       0 B |
            FromFloat |  8.2741 ns | 0.0139 ns | 0.0123 ns |       0 B |
    FromFloatNullable |  9.3566 ns | 0.0151 ns | 0.0141 ns |       0 B |
           FromDouble |  8.1879 ns | 0.0094 ns | 0.0088 ns |       0 B |
   FromDoubleNullable |  9.2094 ns | 0.0054 ns | 0.0048 ns |       0 B |
          FromDecimal | 16.0886 ns | 0.0299 ns | 0.0279 ns |       0 B |
  FromDecimalNullable | 21.3358 ns | 0.0118 ns | 0.0104 ns |       0 B |
         FromDateTime |  3.7321 ns | 0.0007 ns | 0.0005 ns |       0 B |
 FromDateTimeNullable |  4.2355 ns | 0.0073 ns | 0.0065 ns |       0 B |
           FromObject |  2.6994 ns | 0.0063 ns | 0.0059 ns |       0 B |
           FromString | 75.4021 ns | 0.0146 ns | 0.0114 ns |       0 B |
             FromEnum |  4.8744 ns | 0.0083 ns | 0.0078 ns |       0 B |
     FromEnumNullable |  5.6429 ns | 0.0063 ns | 0.0056 ns |       0 B |
