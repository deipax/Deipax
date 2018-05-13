
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |  1.5178 ns | 0.0033 ns | 0.0029 ns |       0 B |
     FromBoolNullable |  2.2829 ns | 0.0006 ns | 0.0005 ns |       0 B |
             FromChar |  1.9866 ns | 0.0030 ns | 0.0026 ns |       0 B |
     FromCharNullable |  2.2601 ns | 0.0011 ns | 0.0009 ns |       0 B |
            FromSByte |  1.7113 ns | 0.0074 ns | 0.0065 ns |       0 B |
    FromSByteNullable |  2.2474 ns | 0.0053 ns | 0.0049 ns |       0 B |
             FromByte |  0.9830 ns | 0.0223 ns | 0.0208 ns |       0 B |
     FromByteNullable |  1.6210 ns | 0.0063 ns | 0.0059 ns |       0 B |
            FromShort |  2.7972 ns | 0.0050 ns | 0.0039 ns |       0 B |
    FromShortNullable |  3.3151 ns | 0.0060 ns | 0.0050 ns |       0 B |
           FromUShort |  1.6610 ns | 0.0035 ns | 0.0033 ns |       0 B |
   FromUShortNullable |  2.2765 ns | 0.0068 ns | 0.0063 ns |       0 B |
              FromInt |  2.5427 ns | 0.0092 ns | 0.0086 ns |       0 B |
      FromIntNullable |  3.0582 ns | 0.0066 ns | 0.0062 ns |       0 B |
             FromUInt |  1.7873 ns | 0.0049 ns | 0.0046 ns |       0 B |
     FromUIntNullable |  2.5571 ns | 0.0090 ns | 0.0085 ns |       0 B |
             FromLong |  2.5399 ns | 0.0007 ns | 0.0006 ns |       0 B |
     FromLongNullable |  4.0838 ns | 0.0036 ns | 0.0030 ns |       0 B |
            FromULong |  2.5375 ns | 0.0063 ns | 0.0056 ns |       0 B |
    FromULongNullable | 11.1096 ns | 0.0039 ns | 0.0031 ns |       0 B |
            FromFloat |  5.3123 ns | 0.0101 ns | 0.0095 ns |       0 B |
    FromFloatNullable |  5.9600 ns | 0.0173 ns | 0.0162 ns |       0 B |
           FromDouble |  5.2454 ns | 0.0081 ns | 0.0076 ns |       0 B |
   FromDoubleNullable |  7.2070 ns | 0.0084 ns | 0.0070 ns |       0 B |
          FromDecimal | 15.6655 ns | 0.0155 ns | 0.0138 ns |       0 B |
  FromDecimalNullable | 25.4582 ns | 0.0207 ns | 0.0194 ns |       0 B |
         FromDateTime |  0.8742 ns | 0.0034 ns | 0.0031 ns |       0 B |
 FromDateTimeNullable |  1.7937 ns | 0.0028 ns | 0.0026 ns |       0 B |
           FromObject |  3.4660 ns | 0.0941 ns | 0.0880 ns |       0 B |
           FromString | 75.0234 ns | 0.0966 ns | 0.0807 ns |       0 B |
             FromEnum |  2.5460 ns | 0.0088 ns | 0.0082 ns |       0 B |
     FromEnumNullable |  3.0568 ns | 0.0041 ns | 0.0036 ns |       0 B |
