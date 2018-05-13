
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  7.603 ns | 0.0226 ns | 0.0201 ns |       0 B |
     FromBoolNullable |  8.050 ns | 0.0101 ns | 0.0085 ns |       0 B |
             FromChar |  7.815 ns | 0.0217 ns | 0.0192 ns |       0 B |
     FromCharNullable |  7.840 ns | 0.0168 ns | 0.0158 ns |       0 B |
            FromSByte |  7.815 ns | 0.0085 ns | 0.0080 ns |       0 B |
    FromSByteNullable |  7.816 ns | 0.0129 ns | 0.0114 ns |       0 B |
             FromByte |  7.618 ns | 0.0172 ns | 0.0152 ns |       0 B |
     FromByteNullable |  7.684 ns | 0.0173 ns | 0.0144 ns |       0 B |
            FromShort |  7.644 ns | 0.0161 ns | 0.0150 ns |       0 B |
    FromShortNullable |  7.898 ns | 0.0090 ns | 0.0080 ns |       0 B |
           FromUShort |  7.809 ns | 0.0057 ns | 0.0044 ns |       0 B |
   FromUShortNullable | 10.648 ns | 0.0166 ns | 0.0155 ns |       0 B |
              FromInt |  7.818 ns | 0.0110 ns | 0.0103 ns |       0 B |
      FromIntNullable |  7.809 ns | 0.0186 ns | 0.0174 ns |       0 B |
             FromUInt |  7.568 ns | 0.0115 ns | 0.0102 ns |       0 B |
     FromUIntNullable |  7.878 ns | 0.0188 ns | 0.0176 ns |       0 B |
             FromLong |  7.665 ns | 0.0146 ns | 0.0129 ns |       0 B |
     FromLongNullable |  8.174 ns | 0.0242 ns | 0.0202 ns |       0 B |
            FromULong |  7.806 ns | 0.0186 ns | 0.0174 ns |       0 B |
    FromULongNullable |  8.587 ns | 0.0093 ns | 0.0078 ns |       0 B |
            FromFloat |  7.823 ns | 0.0188 ns | 0.0176 ns |       0 B |
    FromFloatNullable |  7.822 ns | 0.0157 ns | 0.0131 ns |       0 B |
           FromDouble |  7.737 ns | 0.0187 ns | 0.0174 ns |       0 B |
   FromDoubleNullable |  8.425 ns | 0.0138 ns | 0.0123 ns |       0 B |
          FromDecimal |  8.094 ns | 0.0156 ns | 0.0145 ns |       0 B |
  FromDecimalNullable |  8.497 ns | 0.0147 ns | 0.0138 ns |       0 B |
         FromDateTime |  5.244 ns | 0.0055 ns | 0.0046 ns |       0 B |
 FromDateTimeNullable |  1.537 ns | 0.0012 ns | 0.0010 ns |       0 B |
           FromObject |  9.599 ns | 0.0172 ns | 0.0161 ns |       0 B |
           FromString |  8.362 ns | 0.0214 ns | 0.0201 ns |       0 B |
             FromEnum |  7.573 ns | 0.0140 ns | 0.0131 ns |       0 B |
     FromEnumNullable |  8.021 ns | 0.0134 ns | 0.0119 ns |       0 B |
