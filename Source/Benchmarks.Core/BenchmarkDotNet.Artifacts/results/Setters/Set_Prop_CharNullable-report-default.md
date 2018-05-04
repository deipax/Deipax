
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |      Mean |     Error |    StdDev | Allocated |
--------------------- |----------:|----------:|----------:|----------:|
             FromBool |  6.740 ns | 0.0011 ns | 0.0009 ns |       0 B |
     FromBoolNullable |  6.546 ns | 0.0286 ns | 0.0267 ns |       0 B |
             FromChar |  1.054 ns | 0.0008 ns | 0.0007 ns |       0 B |
     FromCharNullable |  1.055 ns | 0.0010 ns | 0.0008 ns |       0 B |
            FromSByte |  6.822 ns | 0.0046 ns | 0.0036 ns |       0 B |
    FromSByteNullable |  6.808 ns | 0.0331 ns | 0.0310 ns |       0 B |
             FromByte |  6.787 ns | 0.0027 ns | 0.0026 ns |       0 B |
     FromByteNullable |  6.530 ns | 0.0013 ns | 0.0012 ns |       0 B |
            FromShort |  6.828 ns | 0.0036 ns | 0.0030 ns |       0 B |
    FromShortNullable |  6.781 ns | 0.0026 ns | 0.0021 ns |       0 B |
           FromUShort |  6.795 ns | 0.0037 ns | 0.0035 ns |       0 B |
   FromUShortNullable |  6.529 ns | 0.0006 ns | 0.0004 ns |       0 B |
              FromInt |  7.534 ns | 0.0081 ns | 0.0068 ns |       0 B |
      FromIntNullable |  7.187 ns | 0.0085 ns | 0.0080 ns |       0 B |
             FromUInt |  6.769 ns | 0.0017 ns | 0.0013 ns |       0 B |
     FromUIntNullable |  6.789 ns | 0.0153 ns | 0.0143 ns |       0 B |
             FromLong |  7.518 ns | 0.0016 ns | 0.0013 ns |       0 B |
     FromLongNullable |  7.794 ns | 0.0063 ns | 0.0056 ns |       0 B |
            FromULong |  7.280 ns | 0.0017 ns | 0.0016 ns |       0 B |
    FromULongNullable |  7.808 ns | 0.0167 ns | 0.0148 ns |       0 B |
            FromFloat |  6.516 ns | 0.0068 ns | 0.0063 ns |       0 B |
    FromFloatNullable |  6.602 ns | 0.0747 ns | 0.0699 ns |       0 B |
           FromDouble |  6.513 ns | 0.0009 ns | 0.0008 ns |       0 B |
   FromDoubleNullable |  7.242 ns | 0.0152 ns | 0.0135 ns |       0 B |
          FromDecimal |  7.278 ns | 0.0010 ns | 0.0008 ns |       0 B |
  FromDecimalNullable |  7.264 ns | 0.0016 ns | 0.0013 ns |       0 B |
         FromDateTime |  6.857 ns | 0.0100 ns | 0.0094 ns |       0 B |
 FromDateTimeNullable |  7.281 ns | 0.0060 ns | 0.0056 ns |       0 B |
           FromObject | 13.388 ns | 0.0080 ns | 0.0075 ns |       0 B |
           FromString |  7.817 ns | 0.0201 ns | 0.0178 ns |       0 B |
             FromEnum |  7.527 ns | 0.0058 ns | 0.0051 ns |       0 B |
     FromEnumNullable |  7.177 ns | 0.0124 ns | 0.0116 ns |       0 B |
