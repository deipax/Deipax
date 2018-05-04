
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


               Method |     Mean |     Error |    StdDev | Allocated |
--------------------- |---------:|----------:|----------:|----------:|
             FromBool | 3.678 ns | 0.0108 ns | 0.0096 ns |       0 B |
     FromBoolNullable | 3.734 ns | 0.0058 ns | 0.0052 ns |       0 B |
             FromChar | 1.040 ns | 0.0022 ns | 0.0021 ns |       0 B |
     FromCharNullable | 1.804 ns | 0.0005 ns | 0.0004 ns |       0 B |
            FromSByte | 4.356 ns | 0.0364 ns | 0.0341 ns |       0 B |
    FromSByteNullable | 4.679 ns | 0.0053 ns | 0.0047 ns |       0 B |
             FromByte | 3.757 ns | 0.0060 ns | 0.0057 ns |       0 B |
     FromByteNullable | 4.665 ns | 0.0042 ns | 0.0035 ns |       0 B |
            FromShort | 4.347 ns | 0.0026 ns | 0.0020 ns |       0 B |
    FromShortNullable | 4.861 ns | 0.0336 ns | 0.0298 ns |       0 B |
           FromUShort | 3.745 ns | 0.0160 ns | 0.0142 ns |       0 B |
   FromUShortNullable | 4.556 ns | 0.0327 ns | 0.0273 ns |       0 B |
              FromInt | 4.564 ns | 0.0069 ns | 0.0064 ns |       0 B |
      FromIntNullable | 5.672 ns | 0.0328 ns | 0.0290 ns |       0 B |
             FromUInt | 4.776 ns | 0.0188 ns | 0.0167 ns |       0 B |
     FromUIntNullable | 4.827 ns | 0.0059 ns | 0.0055 ns |       0 B |
             FromLong | 4.910 ns | 0.0017 ns | 0.0014 ns |       0 B |
     FromLongNullable | 6.427 ns | 0.0119 ns | 0.0112 ns |       0 B |
            FromULong | 4.541 ns | 0.0907 ns | 0.0849 ns |       0 B |
    FromULongNullable | 6.148 ns | 0.0020 ns | 0.0016 ns |       0 B |
            FromFloat | 3.869 ns | 0.0188 ns | 0.0176 ns |       0 B |
    FromFloatNullable | 3.635 ns | 0.0024 ns | 0.0020 ns |       0 B |
           FromDouble | 3.697 ns | 0.0035 ns | 0.0032 ns |       0 B |
   FromDoubleNullable | 3.806 ns | 0.0094 ns | 0.0088 ns |       0 B |
          FromDecimal | 3.988 ns | 0.0022 ns | 0.0020 ns |       0 B |
  FromDecimalNullable | 4.670 ns | 0.0049 ns | 0.0046 ns |       0 B |
         FromDateTime | 3.766 ns | 0.0022 ns | 0.0021 ns |       0 B |
 FromDateTimeNullable | 4.007 ns | 0.0090 ns | 0.0080 ns |       0 B |
           FromObject | 2.728 ns | 0.0021 ns | 0.0018 ns |       0 B |
           FromString | 5.760 ns | 0.0035 ns | 0.0027 ns |       0 B |
             FromEnum | 4.926 ns | 0.0093 ns | 0.0078 ns |       0 B |
     FromEnumNullable | 5.690 ns | 0.0082 ns | 0.0077 ns |       0 B |
