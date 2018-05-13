
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.200
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


               Method |       Mean |     Error |    StdDev | Allocated |
--------------------- |-----------:|----------:|----------:|----------:|
             FromBool |   7.803 ns | 0.0151 ns | 0.0141 ns |       0 B |
     FromBoolNullable |  10.645 ns | 0.0304 ns | 0.0269 ns |       0 B |
             FromChar |   7.610 ns | 0.0092 ns | 0.0086 ns |       0 B |
     FromCharNullable |   7.806 ns | 0.0156 ns | 0.0146 ns |       0 B |
            FromSByte |   7.682 ns | 0.0219 ns | 0.0183 ns |       0 B |
    FromSByteNullable |   7.869 ns | 0.0142 ns | 0.0126 ns |       0 B |
             FromByte |   7.814 ns | 0.0082 ns | 0.0077 ns |       0 B |
     FromByteNullable |   7.822 ns | 0.0079 ns | 0.0066 ns |       0 B |
            FromShort |  10.526 ns | 0.0163 ns | 0.0153 ns |       0 B |
    FromShortNullable |   7.816 ns | 0.0110 ns | 0.0098 ns |       0 B |
           FromUShort |   7.593 ns | 0.0137 ns | 0.0128 ns |       0 B |
   FromUShortNullable |   7.813 ns | 0.0117 ns | 0.0103 ns |       0 B |
              FromInt |   7.636 ns | 0.0136 ns | 0.0127 ns |       0 B |
      FromIntNullable |  10.619 ns | 0.0187 ns | 0.0166 ns |       0 B |
             FromUInt |   7.803 ns | 0.0172 ns | 0.0160 ns |       0 B |
     FromUIntNullable |   7.914 ns | 0.0232 ns | 0.0205 ns |       0 B |
             FromLong |  10.366 ns | 0.0108 ns | 0.0101 ns |       0 B |
     FromLongNullable |   8.449 ns | 0.0111 ns | 0.0099 ns |       0 B |
            FromULong |   7.671 ns | 0.0194 ns | 0.0182 ns |       0 B |
    FromULongNullable |   8.091 ns | 0.0125 ns | 0.0117 ns |       0 B |
            FromFloat |   7.750 ns | 0.0253 ns | 0.0237 ns |       0 B |
    FromFloatNullable |   8.335 ns | 0.2591 ns | 0.2424 ns |       0 B |
           FromDouble |   7.865 ns | 0.0211 ns | 0.0197 ns |       0 B |
   FromDoubleNullable |   8.359 ns | 0.0203 ns | 0.0180 ns |       0 B |
          FromDecimal |   8.614 ns | 0.0112 ns | 0.0100 ns |       0 B |
  FromDecimalNullable |   8.616 ns | 0.0214 ns | 0.0179 ns |       0 B |
         FromDateTime |   6.780 ns | 0.0096 ns | 0.0090 ns |       0 B |
 FromDateTimeNullable |   1.695 ns | 0.0070 ns | 0.0062 ns |       0 B |
           FromObject |  21.341 ns | 0.0465 ns | 0.0435 ns |       0 B |
           FromString | 550.110 ns | 0.3577 ns | 0.3171 ns |       0 B |
             FromEnum |   7.797 ns | 0.0098 ns | 0.0087 ns |       0 B |
     FromEnumNullable |   7.809 ns | 0.0079 ns | 0.0074 ns |       0 B |
